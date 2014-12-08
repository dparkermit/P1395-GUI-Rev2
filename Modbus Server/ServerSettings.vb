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
    Private reference_number As UInt16
    Private word_count As UInt16

    Private trans_index As UShort = 0

    Public update_loop_count As Byte


    Public Const MAX_TX_SIZE = 255
    Public Const WRITE_CMD = 0
    Public Const READ_CMD = 1


    Public Const MODBUS_COMMAND_TOTAL = 2
    Public ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET + 1) As ETM_ETHERNET_TX_DATA_STRUCTURE

    Public command_ready As UInt16 = 0
    Public command_index As UInt16
    Public command_data As UInt16

    Dim main_screen As frmMain
 

    Private Sub ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        main_screen = New frmMain
        txtIPAddr.Text = My.Settings.ServerIP

        My.Settings.HighLowEnergyReverse = True
        connect_status = 0
        update_loop_count = 0
        trans_index = 0

        ' init modbus data
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA), 5)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP), 4)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_AFC), 5)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_COOLING), 12)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET), 10)
        ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) = New ETM_ETHERNET_TX_DATA_STRUCTURE(CByte(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER), 16)
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

#If LIST_BOX > 0 Then
        Dim outstring As String
#End If
        If (connect_status > 0) Then
            Try
                bytecount = CShort(myStream.EndRead(ar))
                Do While (bytecount > 6)
                    connect_timeout = 0
                    ' get msg length
                    msglength = CShort(recvBuffer(4) * 256 + recvBuffer(5))
                    If (bytecount >= (6 + msglength)) Then
                        function_code = recvBuffer(7)
                        reference_number = CUShort(recvBuffer(8) * 256 + recvBuffer(9)) ' register offset
                        If (last_ref = reference_number) Then
                            If (trans_index < 100) Then
                                trans_num(trans_index) = CUShort(recvBuffer(0) * 256 + recvBuffer(1))  ' for debug
                                trans_index = CUShort(trans_index + 1)
                            Else
                                '   Do While (connect_status > 0)
                                ' Application.DoEvents()
                                ' Loop
                            End If
                        Else
                            If (reference_number = MODBUS_COMMAND_TOTAL) Then
                                If (update_loop_count < 255) Then
                                    update_loop_count = CByte(update_loop_count + 1)
                                Else
                                    update_loop_count = 1
                                End If
                            End If

                        End If
                        last_ref = reference_number
                        word_count = CUShort(recvBuffer(10) * 256 + recvBuffer(11))   ' read data length or number of registers
                        Call modbus_reply()

#If LIST_BOX > 0 Then
                        ' show on the debug list
                        outstring = ""
                        For i = 1 To (6 + msglength)
                            outstring = outstring & recvBuffer(i - 1).ToString("X") & " "
                        Next
                        lstRemMsg.Items.Add(outstring)
#End If
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


    Public Sub modbus_reply()
        Dim i As Integer, row As UInt16
        Dim msglen As Integer, datalen As Integer
        Dim data(30) As Byte  ' max data length 30

        If (function_code = WRITE_FUNCTION) Then
            For i = 0 To 11
                xmitBuffer(i) = recvBuffer(i)  ' use the same unit ID 0xff
            Next
            '  xmitBuffer(4) = 0 ' assume msglen < 256
            xmitBuffer(5) = 6 ' length is always 6 for write cmd
            ' update data
            For row = CUShort(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) To CUShort(MODBUS_COMMANDS.MODBUS_WR_ETHERNET)
                If (ETMEthernetTXDataStructure(row).data_identification = reference_number) Then Exit For
            Next row
            If (row <= CUShort(MODBUS_COMMANDS.MODBUS_WR_ETHERNET)) Then
                ' found addr
                If (word_count <> (ETMEthernetTXDataStructure(row).custom_data_word_count + 54)) Then Exit Sub ' data isn't valid, maybe add some checking??
                connect_status = 5

                ETMEthernetTXDataStructure(row).SetData(recvBuffer, CUShort(word_count * 2), 13)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            End If
#If LIST_BOX > 0 Then
        Dim outstring As String
            outstring = ""
            For i = 1 To 12
                outstring = outstring & xmitBuffer(i - 1).ToString("X") & " "
            Next
            lstRemMsg.Items.Add(outstring)

#End If
        ElseIf (function_code = READ_FUNCTION) Then
            For i = 0 To 7
                xmitBuffer(i) = recvBuffer(i)  ' use the same unit ID 0xff
            Next
            datalen = word_count * 2
            msglen = datalen + 3
            '  xmitBuffer(4) = 0 ' assume msglen < 256
            xmitBuffer(5) = Convert.ToByte(msglen Mod 256)
            xmitBuffer(8) = Convert.ToByte(datalen Mod 256)

            ' need update data
            xmitBuffer(9) = Convert.ToByte(command_ready Mod 256)
            xmitBuffer(10) = Convert.ToByte((command_ready >> 8) Mod 256)
            xmitBuffer(11) = Convert.ToByte(command_index Mod 256)
            xmitBuffer(12) = Convert.ToByte((command_index >> 8) Mod 256)
            xmitBuffer(13) = Convert.ToByte(command_data Mod 256)
            xmitBuffer(14) = Convert.ToByte((command_data >> 8) Mod 256)


            connect_status = 5
            stream.BeginWrite(xmitBuffer, 0, (msglen + 6), New AsyncCallback(AddressOf DoXmitDoneCallback), stream)           '(xmitBuffer, 0, 12)
#If False Then
            ' update data
            For row = MAX_WR_LEN To (CMDLENGTH - 1)
                If (modbus_address(row) = (reference_number + 1)) Then Exit For
            Next
            If row < CMDLENGTH Then
                ' found addr
                If (word_count <> modbus_length(row)) Then Exit Sub ' data isn't valid, maybe add some checking??
                For i = 0 To (datalen - 1)
                    xmitBuffer(9 + i) = modbus_data(row, i)
                Next

                connect_status = 5
                stream.BeginWrite(xmitBuffer, 0, (msglen + 6), New AsyncCallback(AddressOf DoXmitDoneCallback), stream)           '(xmitBuffer, 0, 12)
                If (row = MODBUS_COMMANDS.RD_ENERGY_CMDS) Then
                    If (MainScreen.dose_reading = 1) Then MainScreen.dose_reading = 2 ' signal cmd data out
                ElseIf (row = MODBUS_COMMANDS.RD_DIGI_CMDS) Then
                    If (modbus_data(row, 1) And &H8) > 0 Then
                        SF6_newbottle_cmd_timer_count = CByte(SF6_newbottle_cmd_timer_count + 1)
                        If (SF6_newbottle_cmd_timer_count > 5) Then
                            ' reset SF6 new bottle status
                            SF6_newbottle_cmd_timer_count = 0
                            modbus_data(row, 1) = CByte(modbus_data(row, 1) And &HF7)
                        End If
                    ElseIf SF6_newbottle_cmd_timer_count > 0 Then
                        SF6_newbottle_cmd_timer_count = 0
                    End If

                End If
            End If
#End If
#If LIST_BOX > 0 Then
            Dim outstring As String
            outstring = ""
            For i = 1 To (msglen + 6)
                outstring = outstring & xmitBuffer(i - 1).ToString("X") & " "
            Next
            lstRemMsg.Items.Add(outstring)
#End If
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
