Option Explicit On
Option Strict On

Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO


Public Class ServerSettings

    Public EventLogMessages As New Dictionary(Of UInt16, String)


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

    Public Const MAX_CAL_INDEX = 65536


    Public Const MODBUS_COMMAND_REFRESH_TOTAL = 2

    Public ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET + 1) As ETM_ETHERNET_TX_DATA_STRUCTURE
    Public ETMEthernetCalStructure(MAX_CAL_INDEX + 1) As ETM_ETHERNET_CAL_STRUCTURE


    Public Const MAX_PULSE_SIZE_ROW = 5000
    Public Const MAX_PULSE_SIZE_DATA = 620
    '    Public ETMEthernetPulseData(MAX_PULSE_SIZE_ROW, MAX_PULSE_SIZE_DATA) As Byte
    Public pulse_index As UInt16

    Public Const MAX_EVENT_SIZE_ROW = 5000
    Public Const MAX_EVENT_SIZE_DATA = 512 ' 64 entries
    '   Public ETMEthernetEventData(MAX_EVENT_SIZE_ROW, MAX_EVENT_SIZE_DATA) As Byte
    Public event_index As UInt16


    Public QueueCommandToECB As Queue
 
    Public Const MAX_CUSTOM_DATA_LENGTH = 32
 
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
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_AFC), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_COOLING), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC), MAX_CUSTOM_DATA_LENGTH)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_ETHERNET), MAX_CUSTOM_DATA_LENGTH)




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

    Public pulse_log_enabled As Boolean
    Public pulse_log_file_name As String
    Public pulse_log_file_path As String
    Public pulse_log_file As System.IO.StreamWriter

    Public Sub OpenPulseLogFile()
        pulse_log_file_name = "Pulse_log_" & DateTime.Now.ToString("yyyy_MM_dd_HH_mm") & ".csv"
        pulse_log_file_path = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, pulse_log_file_name)
        pulse_log_file = My.Computer.FileSystem.OpenTextFileWriter(pulse_log_file_path, True)
        pulse_log_enabled = True

        pulse_log_file.Write("Pulse Count, ")
        pulse_log_file.Write("Status Bits, ")
        pulse_log_file.Write("Pulse Seconds, ")
        pulse_log_file.Write("Pulse Milliseconds, ")
        pulse_log_file.Write("Lambda Readback High Vprog, ")
        pulse_log_file.Write("Lambda Readback Low Vprog, ")
        pulse_log_file.Write("Lambda Vpeak, ")
        pulse_log_file.Write("AFC Current Position, ")
        pulse_log_file.Write("AFC Target Position, ")
        pulse_log_file.Write("AFC Readback A, ")
        pulse_log_file.Write("AFC Readback B, ")
        pulse_log_file.Write("AFC Readback Error Filtered, ")
        pulse_log_file.Write("Ion Pump High Target Current, ")
        pulse_log_file.Write("Ion Pump Low Target Current, ")
        pulse_log_file.Write("Magnetron Current High Energy, ")
        pulse_log_file.Write("Magnetron Current Low Energy, ")
        pulse_log_file.Write("Pulse Sync Trigger Width, ")
        pulse_log_file.Write("Pulse Sync High Energy, ")
        pulse_log_file.Write("Pulse Sync Low Energy, ")
        pulse_log_file.Write("ECB Message Count")
        pulse_log_file.WriteLine("")
    End Sub


    Public Sub ClosePulseLogFile()
        pulse_log_enabled = False
        pulse_log_file.Close()
    End Sub

    Private Sub save_pulse_data(ByRef bytes As Byte())
        Static file_index As UInt16 = 0
        Static file_opened As Boolean = False
        Dim data_word As Integer
        Dim mem_location As Integer

        If pulse_log_enabled Then
            For data_row = 0 To 15
                For data_column = 0 To 18
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
                    If data_column = 11 Then
                        If (data_word > &H8000) Then
                            data_word = -(data_word - &H8000)
                        End If
                    End If
                    pulse_log_file.Write(data_word & ",")
                Next
                data_word = bytes(0) * 256 + bytes(1)
                pulse_log_file.Write(data_word)
                pulse_log_file.WriteLine("")
            Next
            'pulse_log_file.WriteLine("")
            'pulse_log_file.WriteLine("")

        End If

    End Sub
    Public event_log_enabled As Boolean
    Public event_log_file_name As String
    Public event_log_file_path As String
    Public event_log_file As System.IO.StreamWriter

    Public Sub OpenEventLogFile()
        event_log_file_name = "P1395_Event_log.csv"
        event_log_file_path = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, event_log_file_name)
        event_log_file = My.Computer.FileSystem.OpenTextFileWriter(event_log_file_path, True)

        'event_log_file.Write("Event Number, ")
        'event_log_file.Write("Event Time, ")
        'event_log_file.Write("Event ID")
        'event_log_file.WriteLine("")
    End Sub


    Public Sub CloseEventLogFile()
        event_log_file.Close()
    End Sub

    Private Sub save_event_data(ByRef bytes As Byte(), ByVal length As UInt16)
        Dim time As UInt32
        Dim event_id As UInt16
        Dim event_number As UInt16
        Dim event_count As Integer
        Dim head As Integer
        Dim time_log As String
        Dim year As Integer
        Dim month As Integer
        Dim day As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer
        Dim Log_Message As String = ""




        If event_log_enabled Then
            If (length > MAX_EVENT_SIZE_DATA) Then length = MAX_EVENT_SIZE_DATA
            event_count = CInt(length / 8)  ' one event is 8 bytes
            If (event_count < 1) Then Exit Sub
            OpenEventLogFile()
            For index = 0 To (event_count - 1)
                head = index * 8
                event_number = CUShort(bytes(head + 0)) << 8
                event_number += CUShort(bytes(head + 1))
                time = CUInt(bytes(head + 2)) << 24
                time += CUInt(bytes(head + 3)) << 16
                time += CUInt(bytes(head + 4)) << 8
                time += CUInt(bytes(head + 5))

                year = CInt(Math.Truncate(time / 31622400))

                time = CUInt(time Mod 31622400)
                month = CInt(Math.Truncate(time / 2678400))

                time = CUInt(time Mod 2678400)
                day = CInt(Math.Truncate(time / 86400))

                time = CUInt(time Mod 86400)
                hour = CInt(Math.Truncate(time / 3600))

                time = CUInt(time Mod 3600)
                minute = CInt(Math.Truncate(time / 60))

                second = CInt(time Mod 60)
                time_log = "20" & Format(year, "00") & "/" & Format(month, "00") & "/" & Format(day, "00") & " " & Format(hour, "00") & ":" & Format(minute, "00") & ":" & Format(second, "00")
                event_id = CUShort(bytes(head + 6)) << 8
                event_id += CUShort(bytes(head + 7))
                If EventLogMessages.TryGetValue(event_id, Log_Message) Then
                    event_log_file.WriteLine(event_number & "," & time_log & "," & Log_Message.Trim())
                Else
                    event_log_file.WriteLine(event_number & "," & time_log & "," & "Unknow ID = 0x" & event_id.ToString("X4"))
                End If

            Next
            CloseEventLogFile()
        End If

    End Sub

  

    Public Sub modbus_reply()
        Dim i As UInt16, row As UInt16
        Dim msglen As Integer, datalen As Integer
        Dim data(30) As Byte  ' max data length 30
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        Dim pulse_data(MAX_PULSE_SIZE_DATA) As Byte
        Dim event_data(MAX_EVENT_SIZE_DATA) As Byte

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
                    '  ETMEthernetEventData(event_index, i) = recvBuffer(13 + i) ' for debug only
                    If (i < MAX_EVENT_SIZE_DATA) Then event_data(i) = recvBuffer(13 + i)
                Next
                event_index = CUShort(event_index + 1)
                If (event_index >= MAX_EVENT_SIZE_ROW) Then event_index = 0
                Call save_event_data(event_data, CUShort(word_count * 2))
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
                    '    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)  ' for debug only
                    If (i < MAX_PULSE_SIZE_DATA) Then pulse_data(i) = recvBuffer(13 + i)
                Next
                pulse_index = CUShort(pulse_index + 1)
                If (pulse_index >= MAX_PULSE_SIZE_ROW) Then pulse_index = 0
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
