Option Explicit On
Option Strict On

Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Public Class ServerSettings
    Private client As TcpClient
    Private server As TcpListener

    Private stream As NetworkStream
    Private xmitBuffer(200) As Byte
    Private recvBuffer(1024) As Byte

    Private connect_status As Integer  ' 0 idle, 1 waiting, 3 connected, 5 waiting for write done
    Private connect_timeout As Integer  ' reset the timeout when receiving incoming packets

    ' modbus header
    Private Const PROTOCOL_IDENTIFIER = &H0
    Private Const UNIT_IDENTIFIER = &HFF


    ' modbus function codes
    Private Const READ_FUNCTION = &H3
    Private Const WRITE_FUNCTION = &H10

    ' modbus protocol
    Private function_code As Byte
    Private command_index_number As Byte
    Private word_count As UInt16

    Private trans_index As UShort = 0

    Public update_loop_count As Byte


    Public Const MAX_TX_SIZE = 255
    Public Const WRITE_CMD = 0
    Public Const READ_CMD = 1

    Public Const MAX_CAL_INDEX = 400
    Public Const MAX_EVENTS_SIZE = 200
    Public Const MAX_PULSE_SIZE = 1000

    Public Const MODBUS_COMMAND_REFRESH_TOTAL = 2
    Public ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET + 1) As ETM_ETHERNET_TX_DATA_STRUCTURE
    Public ETMEthernetCalStructure(MAX_CAL_INDEX + 1) As ETM_ETHERNET_CAL_STRUCTURE


    Public ETMEthernetEventsByte(MAX_EVENTS_SIZE + 1) As Byte

    Public ETMEthernetPulseData(MAX_PULSE_SIZE, 200) As Byte
    Public pulse_index As UInt16


    Public QueueCommandToECB As Queue
 

 
    Dim main_screen As frmMain


    Private Sub ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        main_screen = New frmMain
        txtIPAddr.Text = My.Settings.ServerIP

        My.Settings.HighLowEnergyReverse = True
        connect_status = 0
        update_loop_count = 0
        trans_index = 0

        pulse_index = 0
        QueueCommandToECB = New Queue()

        ' init modbus data
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA), 6)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP), 4)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_AFC), 5)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_COOLING), 12)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET), 10)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER), 20)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT), 12)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC), 13)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_ETHERNET), 5)




        ' restore modbus_data
        '   Call load_save_modbus_data(False)

        TimerUpdate.Enabled = True

    End Sub

    Private Sub ServerSettings_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim status As Integer = connect_status
        TimerUpdate.Enabled = False
        My.Settings.ServerIP = txtIPAddr.Text
        connect_status = 0

        Try
            Select Case (status)
                Case 1
                    '   server.EndAcceptTcpClient()
                    server.Stop()
                Case 2, 3, 4, 5
                    stream.Close()
                    client.Close()
                    server.Stop()
                Case Else
            End Select
            '  load_save_modbus_data(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function get_modbus_status() As Integer
        get_modbus_status = connect_status
    End Function

    Public Sub put_modbus_commands(ByVal index As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        command_to_ECB = New ETM_ETHERNET_COMMAND_STRUCTURE(index, word2, word1, word0)
        QueueCommandToECB.Enqueue(command_to_ECB)
    End Sub

    Private Sub DoXmitDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        If (connect_status > 3) Then
            myStream.EndWrite(ar)

            connect_status = 3
            ' start a new read
            '    If (connect_status > 0) Then
            stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
            'End If

        End If
    End Sub
    Private Sub DoRecvDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        Dim bytecount As Int16, msglength As Int16
        Static last_ref As UShort = 0
        Static trans_num(100) As UShort

        If (connect_status > 0) Then
            Try
                bytecount = CShort(myStream.EndRead(ar))
#If DEBUG_MODBUS Then
                If (bytecount > 0) Then
                    main_screen.modbus_recv_bytecount(main_screen.modbus_recv_index) = CUShort(bytecount)
                    For i = 0 To (bytecount - 1)
                        main_screen.modbus_recv_buffer(main_screen.modbus_recv_index, i) = recvBuffer(i)
                    Next i
                    If (main_screen.modbus_recv_index >= 255) Then
                        main_screen.modbus_recv_index = 0
                    Else
                        main_screen.modbus_recv_index = CByte(main_screen.modbus_recv_index + 1)
                    End 

                End If
#End If
                        Do While (bytecount > 6)
                            connect_timeout = 0
                            ' get msg length
                            msglength = CShort(recvBuffer(4) * 256 + recvBuffer(5))
                            If (bytecount >= (6 + msglength)) Then
                                function_code = recvBuffer(7)
                                command_index_number = recvBuffer(6)
                                If (command_index_number = MODBUS_COMMAND_REFRESH_TOTAL) Then
                                    If (update_loop_count < 255) Then
                                        update_loop_count = CByte(update_loop_count + 1)
                                    Else
                                        update_loop_count = 1
                                    End If
                                End If
                                word_count = CUShort(recvBuffer(10) * 256 + recvBuffer(11))   ' read data length or number of registers
                                Call modbus_reply()

#If True Then  ' reply all requests
                                bytecount = CShort(bytecount - (6 + msglength))
                                If (bytecount > 6) Then
                                    '   overlaps = overlaps + 1
                                    For i = 0 To (bytecount - 1)
                                        recvBuffer(i) = recvBuffer(i + 6 + msglength)  ' shift to next packet
                                    Next
                                Else
                                    bytecount = 0
                                End If
#Else
                            bytecount = 0
#End If
                            Else
                                bytecount = 0
                            End If
                        Loop
#If False Then
                ' start a new read
                If (connect_status > 0) Then
                    stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
                End If
#End If
            Catch ex As Exception
                MsgBox("DoRecvDoneCallback: " + ex.ToString)
            End Try

        End If


    End Sub
    Private Sub DoAcceptTcpClientCallback(ByVal ar As IAsyncResult)
        ' Get the listener that handles the client request.
        Dim listener As TcpListener = CType(ar.AsyncState, TcpListener)

        ' End the operation 
        If (connect_status > 0) Then
            Try
                client = listener.EndAcceptTcpClient(ar)
                stream = client.GetStream()
                '   lblConnectStatus.Text = "Connected"
                stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
                connect_status = 3
                connect_timeout = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub 'DoAcceptTcpClientCallback

    Public Sub init_server()
        Try
            '       lblConnectStatus.Text = "Waiting for client connection..."
            Application.DoEvents()
            server = New TcpListener(IPAddress.Parse(txtIPAddr.Text), 502)
            server.Start()
            server.BeginAcceptTcpClient(New AsyncCallback(AddressOf DoAcceptTcpClientCallback), server)
            connect_status = 1
            connect_timeout = 0
            trans_index = 0
            update_loop_count = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        btnConnect.Enabled = False
        Call init_server()
        ' load the main screen
        Me.Hide()
        main_screen.Show()
    End Sub

    Private Sub save_pulse_data(ByRef bytes As Byte())
        Static file_index As UInt16 = 0
        Static file_name As String = "c:\pulse_log0.txt"
        Static file_opened As Boolean = False
        Static sw As StreamWriter = File.AppendText(file_name)
        Dim sb As StringBuilder = New StringBuilder


        If My.Computer.FileSystem.FileExists(file_name) Then
            If (FileLen(file_name) >= 65535) Then
                sw.Close()
                If (file_index >= 65535) Then
                    file_index = 0
                Else
                    file_index = CUShort(file_index + 1)
                End If
                file_name = "c:\pulse_log" & Trim(CStr(file_index)) & ".txt"
                sw = File.AppendText(file_name)
            End If
        End If

        sb.Append((bytes(0) * 256 + bytes(1)) & ",")
        For i = 2 To 127
            sb.Append(" " & bytes(i).ToString("d3"))
        Next

        sw.WriteLine(sb.ToString)



    End Sub
    Public Sub modbus_reply()
        Dim i As UInt16, row As UInt16
        Dim msglen As Integer, datalen As Integer
        Dim data(30) As Byte  ' max data length 30
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        Dim pulse_data(128) As Byte

        If (function_code = WRITE_FUNCTION) Then
            For i = 0 To 11
                xmitBuffer(i) = recvBuffer(i)  ' use the same unit ID 0xff
            Next
            '  xmitBuffer(4) = 0 ' assume msglen < 256
            xmitBuffer(5) = 6 ' length is always 6 for write cmd

            i = CUShort(QueueCommandToECB.Count)
            xmitBuffer(8) = CByte((i >> 8) And &HFF) ' use reference to tell how many commands available
            xmitBuffer(9) = CByte(i And &HFF)
            ' update data
            row = command_index_number
            connect_status = 5
            If (row >= CUShort(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) And row <= CUShort(MODBUS_COMMANDS.MODBUS_WR_ETHERNET)) Then
                ' found addr
                If (word_count <> (ETMEthernetTXDataStructure(row).custom_data_word_count + 54)) Then
                    Exit Sub ' data isn't valid, maybe add some checking??
                End If

                ETMEthernetTXDataStructure(row).SetData(recvBuffer, CUShort(word_count * 2), 13)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            ElseIf (row = MODBUS_COMMANDS.MODBUS_WR_EVENTS) Then
                For i = 0 To CUShort((word_count * 2 - 1))
                    ETMEthernetEventsByte(i) = recvBuffer(13 + i)
                Next
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            ElseIf (row = MODBUS_COMMANDS.MODBUS_WR_ONE_CAL_ENTRY) Then
                If (word_count >= 3) Then
                    i = CUShort(recvBuffer(13) * 256 + recvBuffer(14))
                    ETMEthernetCalStructure(i).scale = CUShort(recvBuffer(15) * 256 + recvBuffer(16))
                    ETMEthernetCalStructure(i).offset = CUShort(recvBuffer(17) * 256 + recvBuffer(18))
                    stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                End If
            ElseIf (row = MODBUS_COMMANDS.MODBUS_WR_PULSE_LOG) Then
                For i = 0 To CUShort((word_count * 2 - 1))
                    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)
                    If (i < 128) Then pulse_data(i) = recvBuffer(13 + i)
                Next
                pulse_index = CUShort(pulse_index + 1)
                If (pulse_index >= MAX_PULSE_SIZE) Then pulse_index = 0
                Call save_pulse_data(pulse_data)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            End If
        ElseIf (function_code = READ_FUNCTION) Then
            For i = 0 To 7
                xmitBuffer(i) = recvBuffer(i)  ' use the same unit ID )
            Next
            datalen = word_count * 2
            msglen = datalen + 3
            '  xmitBuffer(4) = 0 ' assume msglen < 256
            xmitBuffer(5) = Convert.ToByte(msglen Mod 256)
            xmitBuffer(8) = Convert.ToByte(datalen Mod 256)

            ' need update data
            row = 0
            Do While (word_count >= 4 And QueueCommandToECB.Count > 0)
                command_to_ECB = CType(QueueCommandToECB.Dequeue, ETM_ETHERNET_COMMAND_STRUCTURE)

                xmitBuffer(9 + row * 8) = Convert.ToByte((command_to_ECB.command_index >> 8) Mod 256)
                xmitBuffer(10 + row * 8) = Convert.ToByte(command_to_ECB.command_index Mod 256)
                For i = 0 To 2
                    xmitBuffer(11 + i * 2 + row * 8) = Convert.ToByte((command_to_ECB.data(2 - i) >> 8) Mod 256)
                    xmitBuffer(12 + i * 2 + row * 8) = Convert.ToByte(command_to_ECB.data(2 - i) Mod 256)
                Next
                word_count = CUShort(word_count - 4)
                row = CUShort(row + 1)
            Loop
            connect_status = 5
            stream.BeginWrite(xmitBuffer, 0, (msglen + 6), New AsyncCallback(AddressOf DoXmitDoneCallback), stream)           '(xmitBuffer, 0, 12)
        End If
    End Sub

    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick
        Dim tmpstr As String
        Select Case connect_status
            Case 0
                lblConnectStatus.Text = "Idle"
            Case 1
                lblConnectStatus.Text = "Linac Disconnected"
            Case 2
                lblConnectStatus.Text = "Restart connection..."
                init_server()
            Case Else
                '   lblConnectStatus.Text = "Connected, " & "Loop Count:" & update_loop_count & "   RepeatCmd Index:" & trans_index
                tmpstr = "Linac Connected "
                If (update_loop_count Mod 2) > 0 Then
                    tmpstr = tmpstr & "."
                Else
                    tmpstr = tmpstr & " "
                End If


                lblConnectStatus.Text = tmpstr
                connect_timeout = connect_timeout + 1
                If (connect_timeout = 5) Then
                    update_loop_count = 0
                    connect_status = 0  ' closing the connection
                    stream.Close()
                    client.Close()
                    server.Stop()
                    init_server()
                End If

        End Select

    End Sub



End Class
