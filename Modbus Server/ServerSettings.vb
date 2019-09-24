Option Explicit On
Option Strict On

Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO


Public Class ServerSettings


    Public EventLogMessages As New Dictionary(Of UInt16, String)

    Public board_to_monitor As Byte




    Private client As TcpClient
    Private server As TcpListener
    Private stream As NetworkStream
    Private xmitBuffer(200) As Byte
    Private recvBuffer(1024) As Byte
    Private connect_status As Integer  ' 0 idle, 1 waiting, 3 connected, 5 waiting for write done
    Private connect_timeout As Integer  ' reset the timeout when receiving incoming packets





    ' modbus function codes
    Private Const READ_FUNCTION = &H3
    Private Const WRITE_FUNCTION = &H10
    Private function_code As Byte
    Private command_index_number As Byte
    Private word_count As UInt16
    Private update_loop_count As Byte
    Private Const MODBUS_COMMAND_REFRESH_TOTAL = 2


    Public Const MAX_BOARD_ADDRESSES = 16
    Public ETMEthernetBoardLoggingData(MAX_BOARD_ADDRESSES) As ETM_CAN_BOARD_DATA
    Public ETMEthernetDebugData As ETM_CAN_DEBUG_DATA
    Public ETMEthernetECBLoggingData As ETM_ECB_BOARD_DATA

    Public Const MAX_CAL_INDEX = 65536
    Public ETMEthernetCalStructure(MAX_CAL_INDEX + 1) As ETM_ETHERNET_CAL_STRUCTURE


    Public Const MAX_PULSE_SIZE_ROW = 5000
    Public Const MAX_PULSE_SIZE_DATA = 620
    '    Public ETMEthernetPulseData(MAX_PULSE_SIZE_ROW, MAX_PULSE_SIZE_DATA) As Byte
    Public pulse_index As UInt16


    Public Const MAX_EVENT_SIZE_ROW = 5000
    Public Const MAX_EVENT_SIZE_DATA = 512 ' 64 entries
    '   Public ETMEthernetEventData(MAX_EVENT_SIZE_ROW, MAX_EVENT_SIZE_DATA) As Byte
    Public event_index As UInt16
    Dim main_screen As frmMain


    Public QueueCommandToECB As Queue

    Public Sub put_modbus_commands(ByVal index As UInt16, ByVal word3 As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        command_to_ECB = New ETM_ETHERNET_COMMAND_STRUCTURE(index, word3, word2, word1, word0)
        QueueCommandToECB.Enqueue(command_to_ECB)
    End Sub

    Public Function get_modbus_status() As Integer
        get_modbus_status = connect_status
    End Function



    Private Sub ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        main_screen = New frmMain
        txtIPAddr.Text = My.Settings.ServerIP

        My.Settings.HighLowEnergyReverse = True
        connect_status = 0
        update_loop_count = 0
        LoadLogRegisterText()

        pulse_index = 0
        QueueCommandToECB = New Queue()



        ' init modbus data
        For i = 0 To (MAX_BOARD_ADDRESSES - 1)
            ETMEthernetBoardLoggingData(i) = New ETM_CAN_BOARD_DATA(CByte(i))
        Next
        ETMEthernetDebugData = New ETM_CAN_DEBUG_DATA(0)
        ETMEthernetECBLoggingData = New ETM_ECB_BOARD_DATA(15)

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




    Public command_length_error As Long = 0
    Public command_rcv_count As Long = 0

    ' This looks for new messages
    Private Sub DoRecvDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        Dim bytecount As UInt16, msglength As UInt16
        Static last_ref As UShort = 0
        Static trans_num(100) As UShort

        If (connect_status > 0) Then
            Try
                bytecount = CUShort(myStream.EndRead(ar))

                Do While (bytecount > 6)
                    connect_timeout = 0
                    ' get msg length
                    msglength = CUShort(recvBuffer(4) * 256 + recvBuffer(5))
                    If (bytecount >= (6 + msglength)) Then
                        command_rcv_count += 1
                        function_code = recvBuffer(7)
                        command_index_number = recvBuffer(6)
                        If (command_index_number = MODBUS_COMMAND_REFRESH_TOTAL) Then
                            If (update_loop_count < 255) Then
                                update_loop_count = CByte(update_loop_count + 1)
                            Else
                                update_loop_count = 1
                            End If
                        End If
                        word_count = CUShort((msglength - 4) / 2) 'CUShort(recvBuffer(10) * 256 + recvBuffer(11))   ' read data length or number of registers
                        Call modbus_reply()
                        bytecount = CUShort(bytecount - (6 + msglength))
                        If (bytecount > 6) Then
                            For i = 0 To (bytecount - 1)
                                recvBuffer(i) = recvBuffer(i + 6 + msglength)  ' shift to next packet
                            Next
                        Else
                            bytecount = 0
                        End If
                    Else
                        bytecount = 0
                        command_length_error += 1
                    End If
                Loop
            Catch ex As Exception
                MsgBox("DoRecvDoneCallback: " + ex.ToString)
            End Try

        End If

    End Sub


    Public Const SCOPE_DATA_SIZE As UInt16 = 10000
    Const SCOPE_MESSAGE_SIZE As UInt16 = 128
    Public q_scope_a As Queue(Of UShort) = New Queue(Of UShort)
    Public q_scope_b As Queue(Of UShort) = New Queue(Of UShort)
    Public q_scope_hv As Queue(Of UShort) = New Queue(Of UShort)
   
    Public scope_data_hv_vmon(SCOPE_DATA_SIZE - 1) As UShort
    Dim scope_hv_vmon_write_index As UInt16 = 0
    Public scopecount_a As UInt16
    Public scopecount_b As UInt16
    Public scopecount_hv_vmon As UInt16
    Dim hvps_data(512) As Byte

    ' This sends out a reply to a message from the ECB
    ' If the ECB is transmitting data to the GUI, the GUI processes the data and sends out ack
    ' If the ECB is requesting a command list, the GUI sends out the command list
    Public Sub modbus_reply()
        Dim i As UInt16
        Dim msglen As Integer, datalen As Integer
        Dim data(30) As Byte  ' max data length 30
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        Dim pulse_data(MAX_PULSE_SIZE_DATA) As Byte
        Dim event_data(MAX_EVENT_SIZE_DATA) As Byte
        Dim magnetron_current_data(80) As Byte
        Dim command_id As Byte
        Dim can_address_of_board As UShort

        command_id = command_index_number

        Dim milli_seconds_10 As Long = CLng(DateTime.Now.Ticks / 100000)

        Dim time_byte_low As Byte = CByte(milli_seconds_10 And &HFF)
        Dim time_byte_high As Byte = CByte((milli_seconds_10 >> 8) And &HFF)

        test_time = time_byte_high * 256 + time_byte_low

        If (function_code = WRITE_FUNCTION) Then
            ' The ECB is writing Data to the GUI
            ' Process the data and send ack back to the ECB

            connect_status = 5

            xmitBuffer(0) = recvBuffer(0) '  Transaction number high byte
            xmitBuffer(1) = recvBuffer(1) '  Transaction number low byte
            xmitBuffer(2) = 0 ' Protocol high Byte
            xmitBuffer(3) = 0 ' Protocol low byte
            xmitBuffer(4) = 0 ' Byte length is always 6 for write cmd
            xmitBuffer(5) = 6 ' Byte length is always 6 for write cmd
            xmitBuffer(6) = command_id ' Respond with the same command_id
            xmitBuffer(7) = recvBuffer(7) ' Respond with the same function code
            xmitBuffer(8) = time_byte_high
            xmitBuffer(9) = CByte(QueueCommandToECB.Count) '  This tells the ECB how many messages are waiting on the GUI
            xmitBuffer(10) = board_to_monitor ' This tells the ECB what slave board to store debug data for
            xmitBuffer(11) = time_byte_low

            can_address_of_board = CUShort(CUShort(command_id) - 1)
            If (can_address_of_board >= 10) Then
                can_address_of_board = 10
            End If


            If (command_id >= CUShort(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) And command_id <= CUShort(MODBUS_COMMANDS.MODBUS_WR_PFN_BOARD)) Then
                ' DPARKER do we need to check received data
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                ETMEthernetBoardLoggingData(can_address_of_board).SetData(recvBuffer, CUShort(word_count * 2), 12)

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_ETHERNET) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                ETMEthernetECBLoggingData.SetData(recvBuffer, CUShort(word_count * 2), 12)

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_DEBUG_DATA) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                ETMEthernetDebugData.SetData(recvBuffer, CUShort(word_count * 2), 12)

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_EVENTS) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                For i = 0 To CUShort((word_count * 2 - 1))
                    'ETMEthernetEventData(event_index, i) = recvBuffer(13 + i) ' for debug only
                    If (i < MAX_EVENT_SIZE_DATA) Then event_data(i) = recvBuffer(12 + i)
                Next
                event_index = CUShort(event_index + 1)
                If (event_index >= MAX_EVENT_SIZE_ROW) Then event_index = 0
                Call save_event_data(event_data, CUShort(word_count * 2))

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_SCOPE_MAGNETRON_CURRENT) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                For i = 0 To CUShort((word_count * 2 - 1))
                    '    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)  ' for debug only
                    If (i < MAX_PULSE_SIZE_DATA) Then
                        Try
                            magnetron_current_data(i) = recvBuffer(12 + i)
                        Catch ex As Exception
                        End Try
                    End If

                Next
                Call save_magnetron_current_data(magnetron_current_data)

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_SCOPE_A) Then
                If ScopeRun Then
                    For i = 0 To CUShort((word_count - 1))
                        If (q_scope_a.Count >= SCOPE_DATA_SIZE) Then
                            q_scope_a.Dequeue()
                        End If
                        q_scope_a.Enqueue(CUShort(recvBuffer(12 + i * 2) + (CUShort(recvBuffer(12 + i * 2 + 1)) << 8)))
                    Next
                    If ScopeRunSingle Then
                        scopecount_a = CUShort(scopecount_a + SCOPE_MESSAGE_SIZE)
                        If scopecount_a > SCOPE_DATA_SIZE Then
                            ScopeRun = False
                        End If
                    End If
                End If
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_SCOPE_B) Then
                If ScopeRun Then
                    For i = 0 To CUShort((word_count - 1))
                        If (q_scope_b.Count >= SCOPE_DATA_SIZE) Then
                            q_scope_b.Dequeue()
                        End If
                        q_scope_b.Enqueue(CUShort(recvBuffer(12 + i * 2) + (CUShort(recvBuffer(12 + i * 2 + 1)) << 8)))
                    Next
                    If ScopeRunSingle Then
                        scopecount_b = CUShort(scopecount_b + SCOPE_MESSAGE_SIZE)
                        If scopecount_b > SCOPE_DATA_SIZE Then
                            ScopeRun = False
                        End If
                    End If
                End If
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_SCOPE_HV) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                If ScopeRun Then
                    For i = 0 To CUShort((word_count * 2 - 1))
                        If (i < MAX_PULSE_SIZE_DATA) Then
                            Try
                                hvps_data(i) = recvBuffer(12 + i)
                            Catch ex As Exception
                            End Try
                        End If

                    Next
                    Call save_hvps_data()

                    If ScopeRunSingle Then
                        scopecount_hv_vmon = CUShort(scopecount_hv_vmon + SCOPE_MESSAGE_SIZE * 2)
                        If scopecount_hv_vmon > SCOPE_DATA_SIZE Then
                            ScopeRun = False
                        End If
                    End If
                End If

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_PULSE_LOG) Then
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                For i = 0 To CUShort((word_count * 2 - 1))
                    '    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)  ' for debug only
                    If (i < MAX_PULSE_SIZE_DATA) Then pulse_data(i) = recvBuffer(12 + i)
                Next
                pulse_index = CUShort(pulse_index + 1)
                If (pulse_index >= MAX_PULSE_SIZE_ROW) Then pulse_index = 0
                Call save_pulse_data(pulse_data)
            End If

            ElseIf (function_code = READ_FUNCTION) Then
                ' The ECB is Requesting Commands from the GUI
                ' Send the requested list of commands to the ECB

                connect_status = 5
                word_count = 5
                datalen = word_count * 2
                msglen = datalen + 6


                xmitBuffer(0) = recvBuffer(0) '  Transaction number high byte
                xmitBuffer(1) = recvBuffer(1) '  Transaction number low byte
                xmitBuffer(2) = 0 ' Protocol high Byte
                xmitBuffer(3) = 0 ' Protocol low byte
                xmitBuffer(4) = CByte(Math.Truncate(msglen / 256))
                xmitBuffer(5) = CByte(msglen Mod 256)
                xmitBuffer(6) = command_id ' Respond with the same command_id
                xmitBuffer(7) = recvBuffer(7) ' Respond with the same function code
                xmitBuffer(8) = time_byte_high
                xmitBuffer(11) = time_byte_low

                If (QueueCommandToECB.Count > 0) Then
                    command_to_ECB = CType(QueueCommandToECB.Dequeue, ETM_ETHERNET_COMMAND_STRUCTURE)
                    xmitBuffer(12) = CByte(Math.Truncate(command_to_ECB.command_index / 256))
                    xmitBuffer(13) = CByte(command_to_ECB.command_index Mod 256)
                    xmitBuffer(14) = CByte(Math.Truncate(command_to_ECB.data(3) / 256))
                    xmitBuffer(15) = CByte(command_to_ECB.data(3) Mod 256)
                    xmitBuffer(16) = CByte(Math.Truncate(command_to_ECB.data(2) / 256))
                    xmitBuffer(17) = CByte(command_to_ECB.data(2) Mod 256)
                    xmitBuffer(18) = CByte(Math.Truncate(command_to_ECB.data(1) / 256))
                    xmitBuffer(19) = CByte(command_to_ECB.data(1) Mod 256)
                    xmitBuffer(20) = CByte(Math.Truncate(command_to_ECB.data(0) / 256))
                    xmitBuffer(21) = CByte(command_to_ECB.data(0) Mod 256)


                End If

                stream.BeginWrite(xmitBuffer, 0, (msglen + 6), New AsyncCallback(AddressOf DoXmitDoneCallback), stream)           '(xmitBuffer, 0, 12)
            End If
    End Sub


    Public Sub init_server()
        Try
            Application.DoEvents()
            server = New TcpListener(IPAddress.Parse(txtIPAddr.Text), 502)
            server.Start()
            server.BeginAcceptTcpClient(New AsyncCallback(AddressOf DoAcceptTcpClientCallback), server)
            connect_status = 1
            connect_timeout = 0
            update_loop_count = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DoAcceptTcpClientCallback(ByVal ar As IAsyncResult)
        ' Get the listener that handles the client request.
        Dim listener As TcpListener = CType(ar.AsyncState, TcpListener)
        ' End the operation 
        If (connect_status > 0) Then
            Try
                client = listener.EndAcceptTcpClient(ar)
                stream = client.GetStream()
                stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
                connect_status = 3
                connect_timeout = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub DoXmitDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        If (connect_status > 3) Then
            myStream.EndWrite(ar)
            connect_status = 3
            stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
        End If
    End Sub



    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        btnConnect.Enabled = False
        Call init_server()
        ' load the main screen
        Me.Hide()
        main_screen.Show()
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






    ' --------------------------------- Logging Functions ----------------------------------- '



    Public event_log_enabled As Boolean
    Public event_log_file_name As String
    Public event_log_file_path As String
    Public event_log_file As System.IO.StreamWriter
    Public ScopeRun As Boolean = False
    Public ScopeRunSingle As Boolean = False

    Public Sub OpenEventLogFile()
        event_log_file_name = "NewEventLog.csv"
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


    Dim test_time As Long

    Dim event_count_log As Integer = 0

    Private Sub save_event_data(ByRef bytes As Byte(), ByVal length As UInt16)
        Dim event_id As UInt16
        Dim event_time As UInt16
        Dim event_count As Integer
        Dim head As Integer
        Dim Log_Message As String = ""
        event_log_enabled = True
        If event_log_enabled Then
            If (length > MAX_EVENT_SIZE_DATA) Then length = MAX_EVENT_SIZE_DATA
            event_count = CInt(length / 4)  ' one event is 4 bytes
            If (event_count < 1) Then Exit Sub
            OpenEventLogFile()
            For index = 0 To (event_count - 1)
                event_count_log = event_count_log + 1
                head = index * 4
                event_time = CUShort(bytes(head + 1)) << 8
                event_time += CUShort(bytes(head + 0))


                'Dim milli_seconds_10 As Long = CLng(DateTime.UtcNow.Ticks / 100000)
                'Dim time_byte_low As Byte = CByte(milli_seconds_10 And &HFF)
                'Dim time_byte_high As Byte = CByte((milli_seconds_10 >> 8) And &HFF)


                Dim new_time As Long = CLng(DateTime.Now.Ticks / 100000)

                Dim comp As Long = CLng(new_time And &HFFFF)
                Dim old_time As Long = CLng(new_time And &HFFFFFFFFFFFF0000)

                If (comp < event_time) Then
                    ' The timer has rolled since the time was sent
                    old_time = CLng(old_time - &H10000)
                End If

                Dim set_time As Long = old_time + event_time

                Dim event_date As New DateTime(set_time * 100000)


                event_id = CUShort(bytes(head + 3)) << 8
                event_id += CUShort(bytes(head + 2))


                If EventLogMessages.TryGetValue(event_id, Log_Message) Then
                    event_log_file.WriteLine(Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss.fff") & "," & Format(event_date, "yyyy/MM/dd HH:mm:ss.fff") & "," & Log_Message.Trim())
                Else
                    event_log_file.WriteLine(Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss.fff") & "," & Format(event_date, "yyyy/MM/dd HH:mm:ss.fff") & "," & "Unknow ID = 0x" & event_id.ToString("X4"))
                End If


            Next
            CloseEventLogFile()
        End If

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
        pulse_log_file.Write("Computer Time, ")
        pulse_log_file.Write("Count / Status, ")
        pulse_log_file.Write("Tick High Word, ")
        pulse_log_file.Write("Tick Low Word, ")
        pulse_log_file.Write("Gun Trigger Width A, ")
        pulse_log_file.Write("Gun Trigger Start A, ")
        pulse_log_file.Write("Gun Trigger Width B, ")
        pulse_log_file.Write("Gun Trigger Start B, ")
        pulse_log_file.Write("HVPS Vmon EOC A, ")
        pulse_log_file.Write("HVPS Spare A, ")
        pulse_log_file.Write("HVPS Vmon EOC B, ")
        pulse_log_file.Write("HVPS Spare B, ")
        pulse_log_file.Write("AFC Current Position A, ")
        pulse_log_file.Write("AFC Reverse Power A, ")
        pulse_log_file.Write("AFC Current Position B, ")
        pulse_log_file.Write("AFC Reverse Power B, ")
        pulse_log_file.Write("Magnetron Current Sample A, ")
        pulse_log_file.Write("Magnetron Current Integral A, ")
        pulse_log_file.Write("Magnetron Current Sample B, ")
        pulse_log_file.Write("Magnetron Current Integral B, ")
        pulse_log_file.Write("Target Current Sample A, ")
        pulse_log_file.Write("Target Current Integral A, ")
        pulse_log_file.Write("Target Current Sample B, ")
        pulse_log_file.Write("Target Current Integral B, ")
        pulse_log_file.Write("Gun Driver Data 0 A, ")
        pulse_log_file.Write("Gun Driver Data 1 A, ")
        pulse_log_file.Write("Gun Driver Data 0 B, ")
        pulse_log_file.Write("Gun Driver Data 1 B, ")
        pulse_log_file.WriteLine("")
    End Sub


    Public Sub ClosePulseLogFile()
        If pulse_log_enabled Then
            pulse_log_file.Close()
        End If
        pulse_log_enabled = False

    End Sub

    Public magnetron_pulse_data(49) As UInt16
    Public magnetron_arc_data(49) As UInt16
    Dim newSeries As New DataVisualization.Charting.Series()

    Private Sub save_magnetron_current_data(ByRef bytes As Byte())
        Dim write As Integer = 0
        Dim read As Integer = 0

        For msg_cnt = 0 To 9

            ' First two words 
            magnetron_pulse_data(write + 0) = CUShort(bytes(read + 0) + ((bytes(read + 1) And &HF) * 256))
            magnetron_pulse_data(write + 1) = CUShort((bytes(read + 1) >> 4) + (bytes(read + 2) * 16))

            ' Next two words
            magnetron_pulse_data(write + 2) = CUShort(bytes(read + 3) + ((bytes(read + 4) And &HF) * 256))
            magnetron_pulse_data(write + 3) = CUShort((bytes(read + 4) >> 4) + (bytes(read + 5) * 16))

            ' Final word
            magnetron_pulse_data(write + 4) = CUShort(bytes(read + 6) + ((bytes(read + 7) And &HF) * 256))

            write = write + 5
            read = read + 8
        Next

        read = read
        read = read


    End Sub



    Private Sub save_hvps_data()
        Dim write As Integer = 0
        Dim read As Integer = 0

        Dim data_4 As UShort
        Dim data_3 As UShort
        Dim data_2 As UShort
        Dim data_1 As UShort
        Dim data_0 As UShort

        For msg_blk = 0 To 63
            data_0 = CUShort(hvps_data(msg_blk * 8 + 0) + ((hvps_data(msg_blk * 8 + 1) And &HF) * 256))
            data_1 = CUShort((hvps_data(msg_blk * 8 + 1) >> 4) + (hvps_data(msg_blk * 8 + 2) * 16))

            data_2 = CUShort(hvps_data(msg_blk * 8 + 3) + ((hvps_data(msg_blk * 8 + 4) And &HF) * 256))
            data_3 = CUShort((hvps_data(msg_blk * 8 + 4) >> 4) + (hvps_data(msg_blk * 8 + 5) * 16))

            data_4 = CUShort(hvps_data(msg_blk * 8 + 6) + ((hvps_data(msg_blk * 8 + 7) And &HF) * 256))

            If (q_scope_hv.Count >= SCOPE_DATA_SIZE) Then
                q_scope_hv.Dequeue()
            End If
            q_scope_hv.Enqueue(data_0)

            If (q_scope_hv.Count >= SCOPE_DATA_SIZE) Then
                q_scope_hv.Dequeue()
            End If
            q_scope_hv.Enqueue(data_1)

            If (q_scope_hv.Count >= SCOPE_DATA_SIZE) Then
                q_scope_hv.Dequeue()
            End If
            q_scope_hv.Enqueue(data_2)

            If (q_scope_hv.Count >= SCOPE_DATA_SIZE) Then
                q_scope_hv.Dequeue()
            End If
            q_scope_hv.Enqueue(data_3)

            If (q_scope_hv.Count >= SCOPE_DATA_SIZE) Then
                q_scope_hv.Dequeue()
            End If
            q_scope_hv.Enqueue(data_4)
        Next

    End Sub


    Private Sub save_pulse_data(ByRef bytes As Byte())
        Static file_index As UInt16 = 0
        Static file_opened As Boolean = False
        Dim data_word As Integer
        Dim mem_location As Integer

        If pulse_log_enabled Then
            For data_row = 0 To 7
                pulse_log_file.Write(Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss.fff"))
                pulse_log_file.Write(",")
                For data_column = 0 To 26
                    mem_location = data_row * 54 + data_column * 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
                    pulse_log_file.Write(data_word & ",")
                Next

                'data_word = bytes(0) * 256 + bytes(1)
                'pulse_log_file.Write(data_word)
                pulse_log_file.WriteLine("")
            Next
            pulse_log_file.WriteLine("")
            pulse_log_file.WriteLine("")

        End If

    End Sub





    Private Sub LoadLogRegisterText()

        Me.EventLogMessages.Add(&H110, "State - Entered State Startup")
        Me.EventLogMessages.Add(&H112, "State - Entered State Wait for Personality from Pulse Sync")
        Me.EventLogMessages.Add(&H115, "State - Entered State Waiting for Initialization")
        Me.EventLogMessages.Add(&H120, "State - Entered State warmup")
        Me.EventLogMessages.Add(&H130, "State - Entered State Standby")
        Me.EventLogMessages.Add(&H140, "State - Entered State Drive Up")
        Me.EventLogMessages.Add(&H150, "State - Entered State Ready")
        Me.EventLogMessages.Add(&H160, "State - Entered State XRAY On")
        Me.EventLogMessages.Add(&H180, "State - Entered State Fault Hold")
        Me.EventLogMessages.Add(&H190, "State - Entered State Fault Reset")
        Me.EventLogMessages.Add(&H1A0, "State - Entered State System Fault")
        Me.EventLogMessages.Add(&H1B0, "State - Entered State Warmup Fault")
        Me.EventLogMessages.Add(&H1C0, "State - Entered State Standby Fault")












        Me.EventLogMessages.Add(&H200, "State - Entered State Personality Received")
        Me.EventLogMessages.Add(&H201, "Error - Personality not valid")
        Me.EventLogMessages.Add(&H202, "Notice - All Modules Configured")
        Me.EventLogMessages.Add(&H203, "Notice - Warmup Done")
        Me.EventLogMessages.Add(&H204, "Notice - Drive up Complete")
        Me.EventLogMessages.Add(&H205, "Fault - Drive Up Timeout ")
        Me.EventLogMessages.Add(&H206, "State - Entered State HV Off Faults Clear")





        Me.EventLogMessages.Add(&HC0F0, "Connection - HVPS Interface Connection Lost")
        Me.EventLogMessages.Add(&HC0F1, "Connection - HVPS Interface Connection Established")

        Me.EventLogMessages.Add(&HC000, "Control - HVPS Interface Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC010, "Control - HVPS Interface Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC001, "Control - HVPS Interface Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC011, "Control - HVPS Interface Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC002, "Control - HVPS Interface Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC012, "Control - HVPS Interface Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC003, "Control - HVPS Interface Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC013, "Control - HVPS Interface Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC004, "Control - HVPS Interface Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC014, "Control - HVPS Interface Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC005, "Control - HVPS Interface Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC015, "Control - HVPS Interface Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC006, "Control - HVPS Interface Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC016, "Control - HVPS Interface Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC007, "Control - HVPS Interface Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC017, "Control - HVPS Interface Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC020, "Notice - HVPS Interface Notice 0")
        Me.EventLogMessages.Add(&HC021, "Notice - HVPS Interface Notice 1")
        Me.EventLogMessages.Add(&HC022, "Notice - HVPS Interface Notice 2")
        Me.EventLogMessages.Add(&HC023, "Notice - HVPS Interface Notice 3")
        Me.EventLogMessages.Add(&HC024, "Notice - HVPS Interface Notice 4")
        Me.EventLogMessages.Add(&HC025, "Notice - HVPS Interface Notice 5")
        Me.EventLogMessages.Add(&HC026, "Notice - HVPS Interface Notice 6")
        Me.EventLogMessages.Add(&HC027, "Notice - HVPS Interface Notice 7")

        Me.EventLogMessages.Add(&HC030, "Fault - HVPS Interface - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC040, "Fault - HVPS Interface - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC031, "Fault - HVPS Interface Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC041, "Fault - HVPS Interface Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC032, "Fault - HVPS Interface Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC042, "Fault - HVPS Interface Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC033, "Fault - HVPS Interface Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC043, "Fault - HVPS Interface Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC034, "Fault - HVPS Interface Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC044, "Fault - HVPS Interface Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC035, "Fault - HVPS Interface Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC045, "Fault - HVPS Interface Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC036, "Fault - HVPS Interface Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC046, "Fault - HVPS Interface Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC037, "Fault - HVPS Interface Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC047, "Fault - HVPS Interface Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC038, "Fault - HVPS Interface Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC048, "Fault - HVPS Interface Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC039, "Fault - HVPS Interface Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC049, "Fault - HVPS Interface Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC03A, "Fault - HVPS Interface Fault A Bit Set")
        Me.EventLogMessages.Add(&HC04A, "Fault - HVPS Interface Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC03B, "Fault - HVPS Interface Fault B Bit Set")
        Me.EventLogMessages.Add(&HC04B, "Fault - HVPS Interface Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC03C, "Fault - HVPS Interface Fault C Bit Set")
        Me.EventLogMessages.Add(&HC04C, "Fault - HVPS Interface Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC03D, "Fault - HVPS Interface Fault D Bit Set")
        Me.EventLogMessages.Add(&HC04D, "Fault - HVPS Interface Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC03E, "Fault - HVPS Interface Fault E Bit Set")
        Me.EventLogMessages.Add(&HC04E, "Fault - HVPS Interface Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC03F, "Fault - HVPS Interface Fault F Bit Set")
        Me.EventLogMessages.Add(&HC04F, "Fault - HVPS Interface Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC050, "Log - HVPS Interface Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC060, "Log - HVPS Interface Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC051, "Log - HVPS Interface Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC061, "Log - HVPS Interface Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC052, "Log - HVPS Interface Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC062, "Log - HVPS Interface Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC053, "Log - HVPS Interface Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC063, "Log - HVPS Interface Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC054, "Log - HVPS Interface Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC064, "Log - HVPS Interface Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC055, "Log - HVPS Interface Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC065, "Log - HVPS Interface Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC056, "Log - HVPS Interface Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC066, "Log - HVPS Interface Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC057, "Log - HVPS Interface Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC067, "Log - HVPS Interface Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC058, "Log - HVPS Interface Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC068, "Log - HVPS Interface Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC059, "Log - HVPS Interface Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC069, "Log - HVPS Interface Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC05A, "Log - HVPS Interface Logged A Bit Set")
        Me.EventLogMessages.Add(&HC06A, "Log - HVPS Interface Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC05B, "Log - HVPS Interface Logged B Bit Set")
        Me.EventLogMessages.Add(&HC06B, "Log - HVPS Interface Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC05C, "Log - HVPS Interface Logged C Bit Set")
        Me.EventLogMessages.Add(&HC06C, "Log - HVPS Interface Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC05D, "Log - HVPS Interface Logged D Bit Set")
        Me.EventLogMessages.Add(&HC06D, "Log - HVPS Interface Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC05E, "Log - HVPS Interface Logged E Bit Set")
        Me.EventLogMessages.Add(&HC06E, "Log - HVPS Interface Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC05F, "Log - HVPS Interface Logged F Bit Set")
        Me.EventLogMessages.Add(&HC06F, "Log - HVPS Interface Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC1F0, "Connection - Ion Pump Connection Lost")
        Me.EventLogMessages.Add(&HC1F1, "Connection - Ion Pump Connection Established")

        Me.EventLogMessages.Add(&HC100, "Control - Ion Pump Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC110, "Control - Ion Pump Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC101, "Control - Ion Pump Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC111, "Control - Ion Pump Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC102, "Control - Ion Pump Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC112, "Control - Ion Pump Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC103, "Control - Ion Pump Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC113, "Control - Ion Pump Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC104, "Control - Ion Pump Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC114, "Control - Ion Pump Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC105, "Control - Ion Pump Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC115, "Control - Ion Pump Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC106, "Control - Ion Pump Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC116, "Control - Ion Pump Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC107, "Control - Ion Pump Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC117, "Control - Ion Pump Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC120, "Notice - Ion Pump Notice 0")
        Me.EventLogMessages.Add(&HC121, "Notice - Ion Pump Notice 1")
        Me.EventLogMessages.Add(&HC122, "Notice - Ion Pump Notice 2")
        Me.EventLogMessages.Add(&HC123, "Notice - Ion Pump Notice 3")
        Me.EventLogMessages.Add(&HC124, "Notice - Ion Pump Notice 4")
        Me.EventLogMessages.Add(&HC125, "Notice - Ion Pump Notice 5")
        Me.EventLogMessages.Add(&HC126, "Notice - Ion Pump Notice 6")
        Me.EventLogMessages.Add(&HC127, "Notice - Ion Pump Notice 7")

        Me.EventLogMessages.Add(&HC130, "Fault - Ion Pump - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC140, "Fault - Ion Pump - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC131, "Fault - Ion Pump Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC141, "Fault - Ion Pump Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC132, "Fault - Ion Pump Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC142, "Fault - Ion Pump Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC133, "Fault - Ion Pump Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC143, "Fault - Ion Pump Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC134, "Fault - Ion Pump Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC144, "Fault - Ion Pump Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC135, "Fault - Ion Pump Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC145, "Fault - Ion Pump Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC136, "Fault - Ion Pump Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC146, "Fault - Ion Pump Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC137, "Fault - Ion Pump Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC147, "Fault - Ion Pump Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC138, "Fault - Ion Pump Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC148, "Fault - Ion Pump Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC139, "Fault - Ion Pump Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC149, "Fault - Ion Pump Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC13A, "Fault - Ion Pump Fault A Bit Set")
        Me.EventLogMessages.Add(&HC14A, "Fault - Ion Pump Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC13B, "Fault - Ion Pump Fault B Bit Set")
        Me.EventLogMessages.Add(&HC14B, "Fault - Ion Pump Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC13C, "Fault - Ion Pump Fault C Bit Set")
        Me.EventLogMessages.Add(&HC14C, "Fault - Ion Pump Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC13D, "Fault - Ion Pump Fault D Bit Set")
        Me.EventLogMessages.Add(&HC14D, "Fault - Ion Pump Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC13E, "Fault - Ion Pump Fault E Bit Set")
        Me.EventLogMessages.Add(&HC14E, "Fault - Ion Pump Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC13F, "Fault - Ion Pump Fault F Bit Set")
        Me.EventLogMessages.Add(&HC14F, "Fault - Ion Pump Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC150, "Log - Ion Pump Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC160, "Log - Ion Pump Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC151, "Log - Ion Pump Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC161, "Log - Ion Pump Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC152, "Log - Ion Pump Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC162, "Log - Ion Pump Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC153, "Log - Ion Pump Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC163, "Log - Ion Pump Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC154, "Log - Ion Pump Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC164, "Log - Ion Pump Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC155, "Log - Ion Pump Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC165, "Log - Ion Pump Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC156, "Log - Ion Pump Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC166, "Log - Ion Pump Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC157, "Log - Ion Pump Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC167, "Log - Ion Pump Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC158, "Log - Ion Pump Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC168, "Log - Ion Pump Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC159, "Log - Ion Pump Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC169, "Log - Ion Pump Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC15A, "Log - Ion Pump Logged A Bit Set")
        Me.EventLogMessages.Add(&HC16A, "Log - Ion Pump Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC15B, "Log - Ion Pump Logged B Bit Set")
        Me.EventLogMessages.Add(&HC16B, "Log - Ion Pump Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC15C, "Log - Ion Pump Logged C Bit Set")
        Me.EventLogMessages.Add(&HC16C, "Log - Ion Pump Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC15D, "Log - Ion Pump Logged D Bit Set")
        Me.EventLogMessages.Add(&HC16D, "Log - Ion Pump Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC15E, "Log - Ion Pump Logged E Bit Set")
        Me.EventLogMessages.Add(&HC16E, "Log - Ion Pump Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC15F, "Log - Ion Pump Logged F Bit Set")
        Me.EventLogMessages.Add(&HC16F, "Log - Ion Pump Logged F Bit Cleared")







        Me.EventLogMessages.Add(&HC2F0, "Connection - AFC Connection Lost")
        Me.EventLogMessages.Add(&HC2F1, "Connection - AFC Connection Established")

        Me.EventLogMessages.Add(&HC200, "Control - AFC Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC210, "Control - AFC Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC201, "Control - AFC Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC211, "Control - AFC Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC202, "Control - AFC Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC212, "Control - AFC Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC203, "Control - AFC Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC213, "Control - AFC Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC204, "Control - AFC Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC214, "Control - AFC Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC205, "Control - AFC Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC215, "Control - AFC Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC206, "Control - AFC Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC216, "Control - AFC Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC207, "Control - AFC Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC217, "Control - AFC Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC220, "Notice - AFC Notice 0")
        Me.EventLogMessages.Add(&HC221, "Notice - AFC Notice 1")
        Me.EventLogMessages.Add(&HC222, "Notice - AFC Notice 2")
        Me.EventLogMessages.Add(&HC223, "Notice - AFC Notice 3")
        Me.EventLogMessages.Add(&HC224, "Notice - AFC Notice 4")
        Me.EventLogMessages.Add(&HC225, "Notice - AFC Notice 5")
        Me.EventLogMessages.Add(&HC226, "Notice - AFC Notice 6")
        Me.EventLogMessages.Add(&HC227, "Notice - AFC Notice 7")

        Me.EventLogMessages.Add(&HC230, "Fault - AFC - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC240, "Fault - AFC - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC231, "Fault - AFC Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC241, "Fault - AFC Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC232, "Fault - AFC Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC242, "Fault - AFC Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC233, "Fault - AFC Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC243, "Fault - AFC Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC234, "Fault - AFC Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC244, "Fault - AFC Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC235, "Fault - AFC Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC245, "Fault - AFC Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC236, "Fault - AFC Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC246, "Fault - AFC Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC237, "Fault - AFC Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC247, "Fault - AFC Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC238, "Fault - AFC Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC248, "Fault - AFC Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC239, "Fault - AFC Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC249, "Fault - AFC Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC23A, "Fault - AFC Fault A Bit Set")
        Me.EventLogMessages.Add(&HC24A, "Fault - AFC Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC23B, "Fault - AFC Fault B Bit Set")
        Me.EventLogMessages.Add(&HC24B, "Fault - AFC Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC23C, "Fault - AFC Fault C Bit Set")
        Me.EventLogMessages.Add(&HC24C, "Fault - AFC Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC23D, "Fault - AFC Fault D Bit Set")
        Me.EventLogMessages.Add(&HC24D, "Fault - AFC Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC23E, "Fault - AFC Fault E Bit Set")
        Me.EventLogMessages.Add(&HC24E, "Fault - AFC Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC23F, "Fault - AFC Fault F Bit Set")
        Me.EventLogMessages.Add(&HC24F, "Fault - AFC Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC250, "Log - AFC Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC260, "Log - AFC Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC251, "Log - AFC Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC261, "Log - AFC Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC252, "Log - AFC Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC262, "Log - AFC Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC253, "Log - AFC Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC263, "Log - AFC Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC254, "Log - AFC Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC264, "Log - AFC Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC255, "Log - AFC Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC265, "Log - AFC Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC256, "Log - AFC Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC266, "Log - AFC Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC257, "Log - AFC Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC267, "Log - AFC Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC258, "Log - AFC Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC268, "Log - AFC Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC259, "Log - AFC Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC269, "Log - AFC Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC25A, "Log - AFC Logged A Bit Set")
        Me.EventLogMessages.Add(&HC26A, "Log - AFC Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC25B, "Log - AFC Logged B Bit Set")
        Me.EventLogMessages.Add(&HC26B, "Log - AFC Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC25C, "Log - AFC Logged C Bit Set")
        Me.EventLogMessages.Add(&HC26C, "Log - AFC Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC25D, "Log - AFC Logged D Bit Set")
        Me.EventLogMessages.Add(&HC26D, "Log - AFC Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC25E, "Log - AFC Logged E Bit Set")
        Me.EventLogMessages.Add(&HC26E, "Log - AFC Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC25F, "Log - AFC Logged F Bit Set")
        Me.EventLogMessages.Add(&HC26F, "Log - AFC Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC3F0, "Connection - Cooling Interface Connection Lost")
        Me.EventLogMessages.Add(&HC3F1, "Connection - Cooling Interface Connection Established")

        Me.EventLogMessages.Add(&HC300, "Control - Cooling Interface Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC310, "Control - Cooling Interface Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC301, "Control - Cooling Interface Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC311, "Control - Cooling Interface Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC302, "Control - Cooling Interface Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC312, "Control - Cooling Interface Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC303, "Control - Cooling Interface Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC313, "Control - Cooling Interface Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC304, "Control - Cooling Interface Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC314, "Control - Cooling Interface Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC305, "Control - Cooling Interface Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC315, "Control - Cooling Interface Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC306, "Control - Cooling Interface Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC316, "Control - Cooling Interface Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC307, "Control - Cooling Interface Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC317, "Control - Cooling Interface Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC320, "Notice - Cooling Interface Notice 0")
        Me.EventLogMessages.Add(&HC321, "Notice - Cooling Interface Notice 1")
        Me.EventLogMessages.Add(&HC322, "Notice - Cooling Interface Notice 2")
        Me.EventLogMessages.Add(&HC323, "Notice - Cooling Interface Notice 3")
        Me.EventLogMessages.Add(&HC324, "Notice - Cooling Interface Notice 4")
        Me.EventLogMessages.Add(&HC325, "Notice - Cooling Interface Notice 5")
        Me.EventLogMessages.Add(&HC326, "Notice - Cooling Interface Notice 6")
        Me.EventLogMessages.Add(&HC327, "Notice - Cooling Interface Notice 7")

        Me.EventLogMessages.Add(&HC330, "Fault - Cooling Interface - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC340, "Fault - Cooling Interface - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC331, "Fault - Cooling Interface Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC341, "Fault - Cooling Interface Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC332, "Fault - Cooling Interface Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC342, "Fault - Cooling Interface Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC333, "Fault - Cooling Interface Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC343, "Fault - Cooling Interface Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC334, "Fault - Cooling Interface Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC344, "Fault - Cooling Interface Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC335, "Fault - Cooling Interface Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC345, "Fault - Cooling Interface Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC336, "Fault - Cooling Interface Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC346, "Fault - Cooling Interface Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC337, "Fault - Cooling Interface Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC347, "Fault - Cooling Interface Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC338, "Fault - Cooling Interface Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC348, "Fault - Cooling Interface Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC339, "Fault - Cooling Interface Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC349, "Fault - Cooling Interface Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC33A, "Fault - Cooling Interface Fault A Bit Set")
        Me.EventLogMessages.Add(&HC34A, "Fault - Cooling Interface Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC33B, "Fault - Cooling Interface Fault B Bit Set")
        Me.EventLogMessages.Add(&HC34B, "Fault - Cooling Interface Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC33C, "Fault - Cooling Interface Fault C Bit Set")
        Me.EventLogMessages.Add(&HC34C, "Fault - Cooling Interface Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC33D, "Fault - Cooling Interface Fault D Bit Set")
        Me.EventLogMessages.Add(&HC34D, "Fault - Cooling Interface Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC33E, "Fault - Cooling Interface Fault E Bit Set")
        Me.EventLogMessages.Add(&HC34E, "Fault - Cooling Interface Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC33F, "Fault - Cooling Interface Fault F Bit Set")
        Me.EventLogMessages.Add(&HC34F, "Fault - Cooling Interface Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC350, "Log - Cooling Interface Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC360, "Log - Cooling Interface Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC351, "Log - Cooling Interface Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC361, "Log - Cooling Interface Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC352, "Log - Cooling Interface Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC362, "Log - Cooling Interface Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC353, "Log - Cooling Interface Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC363, "Log - Cooling Interface Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC354, "Log - Cooling Interface Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC364, "Log - Cooling Interface Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC355, "Log - Cooling Interface Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC365, "Log - Cooling Interface Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC356, "Log - Cooling Interface Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC366, "Log - Cooling Interface Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC357, "Log - Cooling Interface Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC367, "Log - Cooling Interface Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC358, "Log - Cooling Interface Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC368, "Log - Cooling Interface Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC359, "Log - Cooling Interface Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC369, "Log - Cooling Interface Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC35A, "Log - Cooling Interface Logged A Bit Set")
        Me.EventLogMessages.Add(&HC36A, "Log - Cooling Interface Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC35B, "Log - Cooling Interface Logged B Bit Set")
        Me.EventLogMessages.Add(&HC36B, "Log - Cooling Interface Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC35C, "Log - Cooling Interface Logged C Bit Set")
        Me.EventLogMessages.Add(&HC36C, "Log - Cooling Interface Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC35D, "Log - Cooling Interface Logged D Bit Set")
        Me.EventLogMessages.Add(&HC36D, "Log - Cooling Interface Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC35E, "Log - Cooling Interface Logged E Bit Set")
        Me.EventLogMessages.Add(&HC36E, "Log - Cooling Interface Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC35F, "Log - Cooling Interface Logged F Bit Set")
        Me.EventLogMessages.Add(&HC36F, "Log - Cooling Interface Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC4F0, "Connection - Heater Magnet Connection Lost")
        Me.EventLogMessages.Add(&HC4F1, "Connection - Heater Magnet Connection Established")

        Me.EventLogMessages.Add(&HC400, "Control - Heater Magnet Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC410, "Control - Heater Magnet Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC401, "Control - Heater Magnet Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC411, "Control - Heater Magnet Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC402, "Control - Heater Magnet Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC412, "Control - Heater Magnet Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC403, "Control - Heater Magnet Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC413, "Control - Heater Magnet Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC404, "Control - Heater Magnet Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC414, "Control - Heater Magnet Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC405, "Control - Heater Magnet Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC415, "Control - Heater Magnet Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC406, "Control - Heater Magnet Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC416, "Control - Heater Magnet Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC407, "Control - Heater Magnet Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC417, "Control - Heater Magnet Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC420, "Notice - Heater Magnet Notice 0")
        Me.EventLogMessages.Add(&HC421, "Notice - Heater Magnet Notice 1")
        Me.EventLogMessages.Add(&HC422, "Notice - Heater Magnet Notice 2")
        Me.EventLogMessages.Add(&HC423, "Notice - Heater Magnet Notice 3")
        Me.EventLogMessages.Add(&HC424, "Notice - Heater Magnet Notice 4")
        Me.EventLogMessages.Add(&HC425, "Notice - Heater Magnet Notice 5")
        Me.EventLogMessages.Add(&HC426, "Notice - Heater Magnet Notice 6")
        Me.EventLogMessages.Add(&HC427, "Notice - Heater Magnet Notice 7")

        Me.EventLogMessages.Add(&HC430, "Fault - Heater Magnet - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC440, "Fault - Heater Magnet - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC431, "Fault - Heater Magnet Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC441, "Fault - Heater Magnet Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC432, "Fault - Heater Magnet Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC442, "Fault - Heater Magnet Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC433, "Fault - Heater Magnet Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC443, "Fault - Heater Magnet Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC434, "Fault - Heater Magnet Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC444, "Fault - Heater Magnet Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC435, "Fault - Heater Magnet Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC445, "Fault - Heater Magnet Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC436, "Fault - Heater Magnet Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC446, "Fault - Heater Magnet Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC437, "Fault - Heater Magnet Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC447, "Fault - Heater Magnet Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC438, "Fault - Heater Magnet Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC448, "Fault - Heater Magnet Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC439, "Fault - Heater Magnet Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC449, "Fault - Heater Magnet Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC43A, "Fault - Heater Magnet Fault A Bit Set")
        Me.EventLogMessages.Add(&HC44A, "Fault - Heater Magnet Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC43B, "Fault - Heater Magnet Fault B Bit Set")
        Me.EventLogMessages.Add(&HC44B, "Fault - Heater Magnet Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC43C, "Fault - Heater Magnet Fault C Bit Set")
        Me.EventLogMessages.Add(&HC44C, "Fault - Heater Magnet Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC43D, "Fault - Heater Magnet Fault D Bit Set")
        Me.EventLogMessages.Add(&HC44D, "Fault - Heater Magnet Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC43E, "Fault - Heater Magnet Fault E Bit Set")
        Me.EventLogMessages.Add(&HC44E, "Fault - Heater Magnet Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC43F, "Fault - Heater Magnet Fault F Bit Set")
        Me.EventLogMessages.Add(&HC44F, "Fault - Heater Magnet Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC450, "Log - Heater Magnet Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC460, "Log - Heater Magnet Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC451, "Log - Heater Magnet Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC461, "Log - Heater Magnet Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC452, "Log - Heater Magnet Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC462, "Log - Heater Magnet Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC453, "Log - Heater Magnet Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC463, "Log - Heater Magnet Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC454, "Log - Heater Magnet Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC464, "Log - Heater Magnet Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC455, "Log - Heater Magnet Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC465, "Log - Heater Magnet Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC456, "Log - Heater Magnet Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC466, "Log - Heater Magnet Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC457, "Log - Heater Magnet Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC467, "Log - Heater Magnet Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC458, "Log - Heater Magnet Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC468, "Log - Heater Magnet Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC459, "Log - Heater Magnet Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC469, "Log - Heater Magnet Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC45A, "Log - Heater Magnet Logged A Bit Set")
        Me.EventLogMessages.Add(&HC46A, "Log - Heater Magnet Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC45B, "Log - Heater Magnet Logged B Bit Set")
        Me.EventLogMessages.Add(&HC46B, "Log - Heater Magnet Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC45C, "Log - Heater Magnet Logged C Bit Set")
        Me.EventLogMessages.Add(&HC46C, "Log - Heater Magnet Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC45D, "Log - Heater Magnet Logged D Bit Set")
        Me.EventLogMessages.Add(&HC46D, "Log - Heater Magnet Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC45E, "Log - Heater Magnet Logged E Bit Set")
        Me.EventLogMessages.Add(&HC46E, "Log - Heater Magnet Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC45F, "Log - Heater Magnet Logged F Bit Set")
        Me.EventLogMessages.Add(&HC46F, "Log - Heater Magnet Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC5F0, "Connection - Gun Driver Connection Lost")
        Me.EventLogMessages.Add(&HC5F1, "Connection - Gun Driver Connection Established")

        Me.EventLogMessages.Add(&HC500, "Control - Gun Driver Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC510, "Control - Gun Driver Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC501, "Control - Gun Driver Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC511, "Control - Gun Driver Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC502, "Control - Gun Driver Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC512, "Control - Gun Driver Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC503, "Control - Gun Driver Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC513, "Control - Gun Driver Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC504, "Control - Gun Driver Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC514, "Control - Gun Driver Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC505, "Control - Gun Driver Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC515, "Control - Gun Driver Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC506, "Control - Gun Driver Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC516, "Control - Gun Driver Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC507, "Control - Gun Driver Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC517, "Control - Gun Driver Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC520, "Notice - Gun Driver Notice 0")
        Me.EventLogMessages.Add(&HC521, "Notice - Gun Driver Notice 1")
        Me.EventLogMessages.Add(&HC522, "Notice - Gun Driver Notice 2")
        Me.EventLogMessages.Add(&HC523, "Notice - Gun Driver Notice 3")
        Me.EventLogMessages.Add(&HC524, "Notice - Gun Driver Notice 4")
        Me.EventLogMessages.Add(&HC525, "Notice - Gun Driver Notice 5")
        Me.EventLogMessages.Add(&HC526, "Notice - Gun Driver Notice 6")
        Me.EventLogMessages.Add(&HC527, "Notice - Gun Driver Notice 7")

        Me.EventLogMessages.Add(&HC530, "Fault - Gun Driver - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC540, "Fault - Gun Driver - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC531, "Fault - Gun Driver Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC541, "Fault - Gun Driver Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC532, "Fault - Gun Driver Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC542, "Fault - Gun Driver Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC533, "Fault - Gun Driver Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC543, "Fault - Gun Driver Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC534, "Fault - Gun Driver Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC544, "Fault - Gun Driver Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC535, "Fault - Gun Driver Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC545, "Fault - Gun Driver Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC536, "Fault - Gun Driver Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC546, "Fault - Gun Driver Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC537, "Fault - Gun Driver Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC547, "Fault - Gun Driver Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC538, "Fault - Gun Driver Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC548, "Fault - Gun Driver Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC539, "Fault - Gun Driver Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC549, "Fault - Gun Driver Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC53A, "Fault - Gun Driver Fault A Bit Set")
        Me.EventLogMessages.Add(&HC54A, "Fault - Gun Driver Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC53B, "Fault - Gun Driver Fault B Bit Set")
        Me.EventLogMessages.Add(&HC54B, "Fault - Gun Driver Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC53C, "Fault - Gun Driver Fault C Bit Set")
        Me.EventLogMessages.Add(&HC54C, "Fault - Gun Driver Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC53D, "Fault - Gun Driver Fault D Bit Set")
        Me.EventLogMessages.Add(&HC54D, "Fault - Gun Driver Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC53E, "Fault - Gun Driver Fault E Bit Set")
        Me.EventLogMessages.Add(&HC54E, "Fault - Gun Driver Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC53F, "Fault - Gun Driver Fault F Bit Set")
        Me.EventLogMessages.Add(&HC54F, "Fault - Gun Driver Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC550, "Log - Gun Driver Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC560, "Log - Gun Driver Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC551, "Log - Gun Driver Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC561, "Log - Gun Driver Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC552, "Log - Gun Driver Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC562, "Log - Gun Driver Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC553, "Log - Gun Driver Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC563, "Log - Gun Driver Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC554, "Log - Gun Driver Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC564, "Log - Gun Driver Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC555, "Log - Gun Driver Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC565, "Log - Gun Driver Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC556, "Log - Gun Driver Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC566, "Log - Gun Driver Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC557, "Log - Gun Driver Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC567, "Log - Gun Driver Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC558, "Log - Gun Driver Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC568, "Log - Gun Driver Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC559, "Log - Gun Driver Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC569, "Log - Gun Driver Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC55A, "Log - Gun Driver Logged A Bit Set")
        Me.EventLogMessages.Add(&HC56A, "Log - Gun Driver Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC55B, "Log - Gun Driver Logged B Bit Set")
        Me.EventLogMessages.Add(&HC56B, "Log - Gun Driver Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC55C, "Log - Gun Driver Logged C Bit Set")
        Me.EventLogMessages.Add(&HC56C, "Log - Gun Driver Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC55D, "Log - Gun Driver Logged D Bit Set")
        Me.EventLogMessages.Add(&HC56D, "Log - Gun Driver Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC55E, "Log - Gun Driver Logged E Bit Set")
        Me.EventLogMessages.Add(&HC56E, "Log - Gun Driver Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC55F, "Log - Gun Driver Logged F Bit Set")
        Me.EventLogMessages.Add(&HC56F, "Log - Gun Driver Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC6F0, "Connection - Magnetron Current Connection Lost")
        Me.EventLogMessages.Add(&HC6F1, "Connection - Magnetron Current Connection Established")

        Me.EventLogMessages.Add(&HC600, "Control - Magnetron Current Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC610, "Control - Magnetron Current Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC601, "Control - Magnetron Current Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC611, "Control - Magnetron Current Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC602, "Control - Magnetron Current Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC612, "Control - Magnetron Current Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC603, "Control - Magnetron Current Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC613, "Control - Magnetron Current Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC604, "Control - Magnetron Current Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC614, "Control - Magnetron Current Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC605, "Control - Magnetron Current Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC615, "Control - Magnetron Current Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC606, "Control - Magnetron Current Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC616, "Control - Magnetron Current Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC607, "Control - Magnetron Current Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC617, "Control - Magnetron Current Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC620, "Notice - Magnetron Current Notice 0")
        Me.EventLogMessages.Add(&HC621, "Notice - Magnetron Current Notice 1")
        Me.EventLogMessages.Add(&HC622, "Notice - Magnetron Current Notice 2")
        Me.EventLogMessages.Add(&HC623, "Notice - Magnetron Current Notice 3")
        Me.EventLogMessages.Add(&HC624, "Notice - Magnetron Current Notice 4")
        Me.EventLogMessages.Add(&HC625, "Notice - Magnetron Current Notice 5")
        Me.EventLogMessages.Add(&HC626, "Notice - Magnetron Current Notice 6")
        Me.EventLogMessages.Add(&HC627, "Notice - Magnetron Current Notice 7")

        Me.EventLogMessages.Add(&HC630, "Fault - Magnetron Current - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HC640, "Fault - Magnetron Current - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HC631, "Fault - Magnetron Current Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC641, "Fault - Magnetron Current Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC632, "Fault - Magnetron Current Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC642, "Fault - Magnetron Current Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC633, "Fault - Magnetron Current Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC643, "Fault - Magnetron Current Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC634, "Fault - Magnetron Current Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC644, "Fault - Magnetron Current Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC635, "Fault - Magnetron Current Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC645, "Fault - Magnetron Current Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC636, "Fault - Magnetron Current Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC646, "Fault - Magnetron Current Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC637, "Fault - Magnetron Current Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC647, "Fault - Magnetron Current Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC638, "Fault - Magnetron Current Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC648, "Fault - Magnetron Current Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC639, "Fault - Magnetron Current Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC649, "Fault - Magnetron Current Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC63A, "Fault - Magnetron Current Fault A Bit Set")
        Me.EventLogMessages.Add(&HC64A, "Fault - Magnetron Current Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC63B, "Fault - Magnetron Current Fault B Bit Set")
        Me.EventLogMessages.Add(&HC64B, "Fault - Magnetron Current Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC63C, "Fault - Magnetron Current Fault C Bit Set")
        Me.EventLogMessages.Add(&HC64C, "Fault - Magnetron Current Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC63D, "Fault - Magnetron Current Fault D Bit Set")
        Me.EventLogMessages.Add(&HC64D, "Fault - Magnetron Current Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC63E, "Fault - Magnetron Current Fault E Bit Set")
        Me.EventLogMessages.Add(&HC64E, "Fault - Magnetron Current Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC63F, "Fault - Magnetron Current Fault F Bit Set")
        Me.EventLogMessages.Add(&HC64F, "Fault - Magnetron Current Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC650, "Log - Magnetron Current Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC660, "Log - Magnetron Current Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC651, "Log - Magnetron Current Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC661, "Log - Magnetron Current Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC652, "Log - Magnetron Current Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC662, "Log - Magnetron Current Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC653, "Log - Magnetron Current Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC663, "Log - Magnetron Current Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC654, "Log - Magnetron Current Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC664, "Log - Magnetron Current Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC655, "Log - Magnetron Current Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC665, "Log - Magnetron Current Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC656, "Log - Magnetron Current Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC666, "Log - Magnetron Current Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC657, "Log - Magnetron Current Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC667, "Log - Magnetron Current Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC658, "Log - Magnetron Current Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC668, "Log - Magnetron Current Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC659, "Log - Magnetron Current Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC669, "Log - Magnetron Current Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC65A, "Log - Magnetron Current Logged A Bit Set")
        Me.EventLogMessages.Add(&HC66A, "Log - Magnetron Current Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC65B, "Log - Magnetron Current Logged B Bit Set")
        Me.EventLogMessages.Add(&HC66B, "Log - Magnetron Current Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC65C, "Log - Magnetron Current Logged C Bit Set")
        Me.EventLogMessages.Add(&HC66C, "Log - Magnetron Current Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC65D, "Log - Magnetron Current Logged D Bit Set")
        Me.EventLogMessages.Add(&HC66D, "Log - Magnetron Current Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC65E, "Log - Magnetron Current Logged E Bit Set")
        Me.EventLogMessages.Add(&HC66E, "Log - Magnetron Current Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC65F, "Log - Magnetron Current Logged F Bit Set")
        Me.EventLogMessages.Add(&HC66F, "Log - Magnetron Current Logged F Bit Cleared")









        Me.EventLogMessages.Add(&HCF00, "Control - Ethernet Not Ready Bit Set")
        Me.EventLogMessages.Add(&HCF10, "Control - Ethernet Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HCF01, "Control - Ethernet Not Configured Bit Set")
        Me.EventLogMessages.Add(&HCF11, "Control - Ethernet Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HCF02, "Control - Ethernet Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HCF12, "Control - Ethernet Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HCF03, "Control - Ethernet Control 3 Bit Set")
        Me.EventLogMessages.Add(&HCF13, "Control - Ethernet Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HCF04, "Control - Ethernet Control 4 Bit Set")
        Me.EventLogMessages.Add(&HCF14, "Control - Ethernet Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HCF05, "Control - Ethernet Control 5 Bit Set")
        Me.EventLogMessages.Add(&HCF15, "Control - Ethernet Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HCF06, "Control - Ethernet Control 6 Bit Set")
        Me.EventLogMessages.Add(&HCF16, "Control - Ethernet Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HCF07, "Control - Ethernet Control 7 Bit Set")
        Me.EventLogMessages.Add(&HCF17, "Control - Ethernet Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HCF20, "Notice - Ethernet Notice 0")
        Me.EventLogMessages.Add(&HCF21, "Notice - Ethernet Notice 1")
        Me.EventLogMessages.Add(&HCF22, "Notice - Ethernet Notice 2")
        Me.EventLogMessages.Add(&HCF23, "Notice - Ethernet Notice 3")
        Me.EventLogMessages.Add(&HCF24, "Notice - Ethernet Notice 4")
        Me.EventLogMessages.Add(&HCF25, "Notice - Ethernet Notice 5")
        Me.EventLogMessages.Add(&HCF26, "Notice - Ethernet Notice 6")
        Me.EventLogMessages.Add(&HCF27, "Notice - Ethernet Notice 7")

        Me.EventLogMessages.Add(&HCF30, "Fault - Ethernet - Can Communication Bit Set")
        Me.EventLogMessages.Add(&HCF40, "Fault - Ethernet - Can Communication Bit Cleared")
        Me.EventLogMessages.Add(&HCF31, "Fault - Ethernet Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HCF41, "Fault - Ethernet Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HCF32, "Fault - Ethernet Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HCF42, "Fault - Ethernet Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HCF33, "Fault - Ethernet Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HCF43, "Fault - Ethernet Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HCF34, "Fault - Ethernet Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HCF44, "Fault - Ethernet Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HCF35, "Fault - Ethernet Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HCF45, "Fault - Ethernet Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HCF36, "Fault - Ethernet Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HCF46, "Fault - Ethernet Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HCF37, "Fault - Ethernet Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HCF47, "Fault - Ethernet Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HCF38, "Fault - Ethernet Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HCF48, "Fault - Ethernet Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HCF39, "Fault - Ethernet Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HCF49, "Fault - Ethernet Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HCF3A, "Fault - Ethernet Fault A Bit Set")
        Me.EventLogMessages.Add(&HCF4A, "Fault - Ethernet Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HCF3B, "Fault - Ethernet Fault B Bit Set")
        Me.EventLogMessages.Add(&HCF4B, "Fault - Ethernet Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HCF3C, "Fault - Ethernet Fault C Bit Set")
        Me.EventLogMessages.Add(&HCF4C, "Fault - Ethernet Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HCF3D, "Fault - Ethernet Fault D Bit Set")
        Me.EventLogMessages.Add(&HCF4D, "Fault - Ethernet Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HCF3E, "Fault - Ethernet Fault E Bit Set")
        Me.EventLogMessages.Add(&HCF4E, "Fault - Ethernet Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HCF3F, "Fault - Ethernet Fault F Bit Set")
        Me.EventLogMessages.Add(&HCF4F, "Fault - Ethernet Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HCF50, "Log - Ethernet Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HCF60, "Log - Ethernet Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HCF51, "Log - Ethernet Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HCF61, "Log - Ethernet Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HCF52, "Log - Ethernet Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HCF62, "Log - Ethernet Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HCF53, "Log - Ethernet Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HCF63, "Log - Ethernet Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HCF54, "Log - Ethernet Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HCF64, "Log - Ethernet Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HCF55, "Log - Ethernet Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HCF65, "Log - Ethernet Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HCF56, "Log - Ethernet Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HCF66, "Log - Ethernet Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HCF57, "Log - Ethernet Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HCF67, "Log - Ethernet Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HCF58, "Log - Ethernet Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HCF68, "Log - Ethernet Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HCF59, "Log - Ethernet Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HCF69, "Log - Ethernet Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HCF5A, "Log - Ethernet Logged A Bit Set")
        Me.EventLogMessages.Add(&HCF6A, "Log - Ethernet Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HCF5B, "Log - Ethernet Logged B Bit Set")
        Me.EventLogMessages.Add(&HCF6B, "Log - Ethernet Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HCF5C, "Log - Ethernet Logged C Bit Set")
        Me.EventLogMessages.Add(&HCF6C, "Log - Ethernet Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HCF5D, "Log - Ethernet Logged D Bit Set")
        Me.EventLogMessages.Add(&HCF6D, "Log - Ethernet Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HCF5E, "Log - Ethernet Logged E Bit Set")
        Me.EventLogMessages.Add(&HCF6E, "Log - Ethernet Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HCF5F, "Log - Ethernet Logged F Bit Set")
        Me.EventLogMessages.Add(&HCF6F, "Log - Ethernet Logged F Bit Cleared")




    End Sub






End Class
