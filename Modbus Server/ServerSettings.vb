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

    Public Sub put_modbus_commands(ByVal index As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        command_to_ECB = New ETM_ETHERNET_COMMAND_STRUCTURE(index, word2, word1, word0)
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
        Dim command_id As Byte

        command_id = command_index_number

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
            xmitBuffer(8) = 0
            xmitBuffer(9) = CByte(QueueCommandToECB.Count) '  This tells the ECB how many messages are waiting on the GUI
            xmitBuffer(10) = board_to_monitor ' This tells the ECB what slave board to store debug data for
            xmitBuffer(11) = 0


            If (command_id >= CUShort(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) And command_id <= CUShort(MODBUS_COMMANDS.MODBUS_WR_ETHERNET)) Then
                ' DPARKER do we need to check received data
                ETMEthernetBoardLoggingData(command_id).SetData(recvBuffer, CUShort(word_count * 2), 12)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_DEBUG_DATA) Then

                ETMEthernetDebugData.SetData(recvBuffer, CUShort(word_count * 2), 12)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_EVENTS) Then

                For i = 0 To CUShort((word_count * 2 - 1))
                    'ETMEthernetEventData(event_index, i) = recvBuffer(13 + i) ' for debug only
                    If (i < MAX_EVENT_SIZE_DATA) Then event_data(i) = recvBuffer(12 + i)
                Next
                event_index = CUShort(event_index + 1)
                If (event_index >= MAX_EVENT_SIZE_ROW) Then event_index = 0
                Call save_event_data(event_data, CUShort(word_count * 2))
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack


            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_PULSE_LOG) Then
                For i = 0 To CUShort((word_count * 2 - 1))
                    '    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)  ' for debug only
                    If (i < MAX_PULSE_SIZE_DATA) Then pulse_data(i) = recvBuffer(12 + i)
                Next
                pulse_index = CUShort(pulse_index + 1)
                If (pulse_index >= MAX_PULSE_SIZE_ROW) Then pulse_index = 0
                Call save_pulse_data(pulse_data)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            End If


        ElseIf (function_code = READ_FUNCTION) Then
            ' The ECB is Requesting Commands from the GUI
            ' Send the requested list of commands to the ECB

            connect_status = 5
            word_count = 4
            datalen = word_count * 2
            msglen = datalen + 3


            xmitBuffer(0) = recvBuffer(0) '  Transaction number high byte
            xmitBuffer(1) = recvBuffer(1) '  Transaction number low byte
            xmitBuffer(2) = 0 ' Protocol high Byte
            xmitBuffer(3) = 0 ' Protocol low byte
            xmitBuffer(4) = CByte(Math.Truncate(msglen / 256))
            xmitBuffer(5) = CByte(msglen Mod 256)
            xmitBuffer(6) = command_id ' Respond with the same command_id
            xmitBuffer(7) = recvBuffer(7) ' Respond with the same function code
            xmitBuffer(8) = CByte(datalen Mod 256)

            i = 0
            Do While (word_count >= 4 And QueueCommandToECB.Count > 0)
                ' Add each to the xmitBuffer
                command_to_ECB = CType(QueueCommandToECB.Dequeue, ETM_ETHERNET_COMMAND_STRUCTURE)
                xmitBuffer(9 + i * 8) = CByte(Math.Truncate(command_to_ECB.command_index / 256))
                xmitBuffer(10 + i * 8) = CByte(command_to_ECB.command_index Mod 256)
                xmitBuffer(11 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(2) / 256))
                xmitBuffer(12 + i * 8) = CByte(command_to_ECB.data(2) Mod 256)
                xmitBuffer(13 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(1) / 256))
                xmitBuffer(14 + i * 8) = CByte(command_to_ECB.data(1) Mod 256)
                xmitBuffer(15 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(0) / 256))
                xmitBuffer(16 + i * 8) = CByte(command_to_ECB.data(0) Mod 256)

                word_count = CUShort(word_count - 4)
                i = CUShort(i + 1)
            Loop


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
        event_log_enabled = True
        If event_log_enabled Then
            If (length > MAX_EVENT_SIZE_DATA) Then length = MAX_EVENT_SIZE_DATA
            event_count = CInt(length / 8)  ' one event is 8 bytes
            If (event_count < 1) Then Exit Sub
            OpenEventLogFile()
            For index = 0 To (event_count - 1)
                head = index * 8
                event_number = CUShort(bytes(head + 1)) << 8
                event_number += CUShort(bytes(head + 0))
                time = CUInt(bytes(head + 5)) << 24
                time += CUInt(bytes(head + 4)) << 16
                time += CUInt(bytes(head + 3)) << 8
                time += CUInt(bytes(head + 2))

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
                event_id = CUShort(bytes(head + 7)) << 8
                event_id += CUShort(bytes(head + 6))
                If EventLogMessages.TryGetValue(event_id, Log_Message) Then
                    event_log_file.WriteLine(event_number & "," & time_log & "," & Log_Message.Trim())
                Else
                    event_log_file.WriteLine(event_number & "," & time_log & "," & "Unknow ID = 0x" & event_id.ToString("X4"))
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

        pulse_log_file.Write("Pulse Count, ")
        pulse_log_file.Write("Status Bits, ")
        pulse_log_file.Write("Pulse Seconds, ")
        pulse_log_file.Write("Pulse Milliseconds, ")
        pulse_log_file.Write("Lambda Vmon, ")
        pulse_log_file.Write("Lambda Vmon Pre-Pulse, ")
        pulse_log_file.Write("Lambda Vprog Pre-Pulse, ")
        pulse_log_file.Write("Unused, ")
        pulse_log_file.Write("Unused, ")
        pulse_log_file.Write("AFC Current Position, ")
        pulse_log_file.Write("Reverse Power, ")
        pulse_log_file.Write("Reverse Power Internal, ")
        pulse_log_file.Write("Ion Pump High Target Current, ")
        pulse_log_file.Write("Ion Pump Low Target Current, ")
        pulse_log_file.Write("Magnetron Current Internal ADC, ")
        pulse_log_file.Write("Magnetron Current External ADC, ")
        pulse_log_file.Write("Pulse Sync Trigger Width, ")
        pulse_log_file.Write("Pulse Sync Trigger Width Filtered, ")
        pulse_log_file.Write("Pulse Grid Start, ")
        pulse_log_file.Write("Pulse Grid Stop, ")
        pulse_log_file.Write("Pulse PRF (.1Hz), ")
        pulse_log_file.Write("ECB Message Count")
        pulse_log_file.WriteLine("")
    End Sub


    Public Sub ClosePulseLogFile()
        If pulse_log_enabled Then
            pulse_log_file.Close()
        End If
        pulse_log_enabled = False

    End Sub

    Private Sub save_pulse_data(ByRef bytes As Byte())
        Static file_index As UInt16 = 0
        Static file_opened As Boolean = False
        Dim data_word As Integer
        Dim mem_location As Integer

        If pulse_log_enabled Then
            For data_row = 0 To 15
                For data_column = 0 To 15
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
                    If data_column = 11 Then
                        If (data_word > &H8000) Then
                            data_word = -(data_word - &H8000)
                        End If
                    End If
                    pulse_log_file.Write(data_word & ",")
                Next

                For data_column = 16 To 17
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location)
                    pulse_log_file.Write(data_word & ",")
                    data_word = bytes(mem_location + 1)
                    pulse_log_file.Write(data_word & ",")
                Next

                For data_column = 18 To 18
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
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





    Private Sub LoadLogRegisterText()
#If 0 Then


        Me.EventLogMessages.Add(&H10, "State - Entered State Startup")
        Me.EventLogMessages.Add(&H10, "	State - Entered State Startup	")
        Me.EventLogMessages.Add(&H11, "	State - Entered State Wait for Personality from Pulse Sync	")
        Me.EventLogMessages.Add(&H12, "	State - Entered State Personality Received	")
        Me.EventLogMessages.Add(&H13, "	Error - Personality not valid 6/4 MeV	")
        Me.EventLogMessages.Add(&H14, "	Error - Personality not valid 2.5 MeV	")
        Me.EventLogMessages.Add(&H15, "	State - Entered State Waiting for Initialization	")
        Me.EventLogMessages.Add(&H16, "	Notice - All Modules Configured	")
        Me.EventLogMessages.Add(&H17, "	State - Entered State warmup	")
        Me.EventLogMessages.Add(&H18, "	Notice - Warmup Done	")
        Me.EventLogMessages.Add(&H19, "	State - Entered State Standby	")
        Me.EventLogMessages.Add(&H1A, "	Input - HV ON	")
        Me.EventLogMessages.Add(&H1B, "	State - Entered State Drive Up	")
        Me.EventLogMessages.Add(&H1C, "	Notice - Drive up Complete	")
        Me.EventLogMessages.Add(&H1D, "	Input - HV OFF	")
        Me.EventLogMessages.Add(&H1E, "	Fault - Drive Up Timeout 	")
        Me.EventLogMessages.Add(&H1F, "	State - Entered State Ready	")
        Me.EventLogMessages.Add(&H20, "	Input - XRAY ON	")
        Me.EventLogMessages.Add(&H22, "	State - Entered State XRAY On	")
        Me.EventLogMessages.Add(&H23, "	Input - XRAY OFF	")
        Me.EventLogMessages.Add(&H25, "	State - Entered State Fault Hold	")
        Me.EventLogMessages.Add(&H27, "	State - Entered State Fault Reset	")
        Me.EventLogMessages.Add(&H28, "	State - Entered State HV Off Faults Clear	")
        Me.EventLogMessages.Add(&H29, "	State - Entered State System Fault	")

        Me.EventLogMessages.Add(&H1110, "	Status - Ion Pump Not Ready	")
        Me.EventLogMessages.Add(&H1111, "	Status - Ion Pump Read	")
        Me.EventLogMessages.Add(&H1112, "	Status - Ion Pump not Configured	")
        Me.EventLogMessages.Add(&H1113, "	Status - Ion Pump Configured	")
        Me.EventLogMessages.Add(&H1114, "	Fault - Ion Pump Connection Lost	")
        Me.EventLogMessages.Add(&H1115, "	Status - Ion Pump Connection Established	")
        Me.EventLogMessages.Add(&H1010, "	Fault - Ion Pump 1	")
        Me.EventLogMessages.Add(&H1011, "	Fault - Ion Pump 2	")
        Me.EventLogMessages.Add(&H1012, "	Fault - Ion Pump 3	")
        Me.EventLogMessages.Add(&H1013, "	Fault - Ion Pump 4	")
        Me.EventLogMessages.Add(&H1014, "	Fault - Ion Pump 5	")
        Me.EventLogMessages.Add(&H1015, "	Fault - Ion Pump 6	")
        Me.EventLogMessages.Add(&H1016, "	Fault - Ion Pump 7	")
        Me.EventLogMessages.Add(&H1017, "	Fault - Ion Pump 8	")
        Me.EventLogMessages.Add(&H1018, "	Fault - Ion Pump 9	")
        Me.EventLogMessages.Add(&H1019, "	Fault - Ion Pump 10	")
        Me.EventLogMessages.Add(&H101A, "	Fault - Ion Pump 11	")
        Me.EventLogMessages.Add(&H101B, "	Fault - Ion Pump 12	")
        Me.EventLogMessages.Add(&H101C, "	Fault - Ion Pump 13	")
        Me.EventLogMessages.Add(&H101D, "	Fault - Ion Pump 14	")
        Me.EventLogMessages.Add(&H101E, "	Fault - Ion Pump 15	")
        Me.EventLogMessages.Add(&H101F, "	Fault - Ion Pump 16	")

        Me.EventLogMessages.Add(&H1120, "	Status - Pulse Current Monitor Not Ready	")
        Me.EventLogMessages.Add(&H1121, "	Status - Pulse Current Monitor Read	")
        Me.EventLogMessages.Add(&H1122, "	Status - Pulse Current Monitor not Configured	")
        Me.EventLogMessages.Add(&H1123, "	Status - Pulse Current Monitor Configured	")
        Me.EventLogMessages.Add(&H1124, "	Fault - Pulse Current Monitor Connection Lost	")
        Me.EventLogMessages.Add(&H1125, "	Status - Pulse Current Monitor Connection Established	")
        Me.EventLogMessages.Add(&H1020, "	Fault - Pulse Current Monitor 1	")
        Me.EventLogMessages.Add(&H1021, "	Fault - Pulse Current Monitor 2	")
        Me.EventLogMessages.Add(&H1022, "	Fault - Pulse Current Monitor 3	")
        Me.EventLogMessages.Add(&H1023, "	Fault - Pulse Current Monitor 4	")
        Me.EventLogMessages.Add(&H1024, "	Fault - Pulse Current Monitor 5	")
        Me.EventLogMessages.Add(&H1025, "	Fault - Pulse Current Monitor 6	")
        Me.EventLogMessages.Add(&H1026, "	Fault - Pulse Current Monitor 7	")
        Me.EventLogMessages.Add(&H1027, "	Fault - Pulse Current Monitor 8	")
        Me.EventLogMessages.Add(&H1028, "	Fault - Pulse Current Monitor 9	")
        Me.EventLogMessages.Add(&H1029, "	Fault - Pulse Current Monitor 10	")
        Me.EventLogMessages.Add(&H102A, "	Fault - Pulse Current Monitor 11	")
        Me.EventLogMessages.Add(&H102B, "	Fault - Pulse Current Monitor 12	")
        Me.EventLogMessages.Add(&H102C, "	Fault - Pulse Current Monitor 13	")
        Me.EventLogMessages.Add(&H102D, "	Fault - Pulse Current Monitor 14	")
        Me.EventLogMessages.Add(&H102E, "	Fault - Pulse Current Monitor 15	")
        Me.EventLogMessages.Add(&H102F, "	Fault - Pulse Current Monitor 16	")

        Me.EventLogMessages.Add(&H1130, "	Status - Pulse Sync Not Ready	")
        Me.EventLogMessages.Add(&H1131, "	Status - Pulse Sync Read	")
        Me.EventLogMessages.Add(&H1132, "	Status - Pulse Sync not Configured	")
        Me.EventLogMessages.Add(&H1133, "	Status - Pulse Sync Configured	")
        Me.EventLogMessages.Add(&H1134, "	Fault - Pulse Sync Connection Lost	")
        Me.EventLogMessages.Add(&H1135, "	Status - Pulse Sync Connection Established	")
        Me.EventLogMessages.Add(&H1030, "	Fault - Pulse Sync 1	")
        Me.EventLogMessages.Add(&H1031, "	Fault - Pulse Sync 2	")
        Me.EventLogMessages.Add(&H1032, "	Fault - Pulse Sync 3	")
        Me.EventLogMessages.Add(&H1033, "	Fault - Pulse Sync 4	")
        Me.EventLogMessages.Add(&H1034, "	Fault - Pulse Sync 5	")
        Me.EventLogMessages.Add(&H1035, "	Fault - Pulse Sync 6	")
        Me.EventLogMessages.Add(&H1036, "	Fault - Pulse Sync 7	")
        Me.EventLogMessages.Add(&H1037, "	Fault - Pulse Sync 8	")
        Me.EventLogMessages.Add(&H1038, "	Fault - Pulse Sync 9	")
        Me.EventLogMessages.Add(&H1039, "	Fault - Pulse Sync 10	")
        Me.EventLogMessages.Add(&H103A, "	Fault - Pulse Sync 11	")
        Me.EventLogMessages.Add(&H103B, "	Fault - Pulse Sync 12	")
        Me.EventLogMessages.Add(&H103C, "	Fault - Pulse Sync 13	")
        Me.EventLogMessages.Add(&H103D, "	Fault - Pulse Sync 14	")
        Me.EventLogMessages.Add(&H103E, "	Fault - Pulse Sync 15	")
        Me.EventLogMessages.Add(&H103F, "	Fault - Pulse Sync 16	")

        Me.EventLogMessages.Add(&H1140, "	Status - HV Lambda Not Ready	")
        Me.EventLogMessages.Add(&H1141, "	Status - HV Lambda Read	")
        Me.EventLogMessages.Add(&H1142, "	Status - HV Lambda not Configured	")
        Me.EventLogMessages.Add(&H1143, "	Status - HV Lambda Configured	")
        Me.EventLogMessages.Add(&H1144, "	Fault - HV Lambda Connection Lost	")
        Me.EventLogMessages.Add(&H1145, "	Status - HV Lambda Connection Established	")
        Me.EventLogMessages.Add(&H1040, "	Fault - HV Lambda 1	")
        Me.EventLogMessages.Add(&H1041, "	Fault - HV Lambda 2	")
        Me.EventLogMessages.Add(&H1042, "	Fault - HV Lambda 3	")
        Me.EventLogMessages.Add(&H1043, "	Fault - HV Lambda 4	")
        Me.EventLogMessages.Add(&H1044, "	Fault - HV Lambda 5	")
        Me.EventLogMessages.Add(&H1045, "	Fault - HV Lambda 6	")
        Me.EventLogMessages.Add(&H1046, "	Fault - HV Lambda 7	")
        Me.EventLogMessages.Add(&H1047, "	Fault - HV Lambda 8	")
        Me.EventLogMessages.Add(&H1048, "	Fault - HV Lambda 9	")
        Me.EventLogMessages.Add(&H1049, "	Fault - HV Lambda 10	")
        Me.EventLogMessages.Add(&H104A, "	Fault - HV Lambda 11	")
        Me.EventLogMessages.Add(&H104B, "	Fault - HV Lambda 12	")
        Me.EventLogMessages.Add(&H104C, "	Fault - HV Lambda 13	")
        Me.EventLogMessages.Add(&H104D, "	Fault - HV Lambda 14	")
        Me.EventLogMessages.Add(&H104E, "	Fault - HV Lambda 15	")
        Me.EventLogMessages.Add(&H104F, "	Fault - HV Lambda 16	")

        Me.EventLogMessages.Add(&H1150, "	Status - AFC Not Ready	")
        Me.EventLogMessages.Add(&H1151, "	Status - AFC Read	")
        Me.EventLogMessages.Add(&H1152, "	Status - AFC not Configured	")
        Me.EventLogMessages.Add(&H1153, "	Status - AFC Configured	")
        Me.EventLogMessages.Add(&H1154, "	Fault - AFC Connection Lost	")
        Me.EventLogMessages.Add(&H1155, "	Status - AFC Connection Established	")
        Me.EventLogMessages.Add(&H1050, "	Fault - AFC 1	")
        Me.EventLogMessages.Add(&H1051, "	Fault - AFC 2	")
        Me.EventLogMessages.Add(&H1052, "	Fault - AFC 3	")
        Me.EventLogMessages.Add(&H1053, "	Fault - AFC 4	")
        Me.EventLogMessages.Add(&H1054, "	Fault - AFC 5	")
        Me.EventLogMessages.Add(&H1055, "	Fault - AFC 6	")
        Me.EventLogMessages.Add(&H1056, "	Fault - AFC 7	")
        Me.EventLogMessages.Add(&H1057, "	Fault - AFC 8	")
        Me.EventLogMessages.Add(&H1058, "	Fault - AFC 9	")
        Me.EventLogMessages.Add(&H1059, "	Fault - AFC 10	")
        Me.EventLogMessages.Add(&H105A, "	Fault - AFC 11	")
        Me.EventLogMessages.Add(&H105B, "	Fault - AFC 12	")
        Me.EventLogMessages.Add(&H105C, "	Fault - AFC 13	")
        Me.EventLogMessages.Add(&H105D, "	Fault - AFC 14	")
        Me.EventLogMessages.Add(&H105E, "	Fault - AFC 15	")
        Me.EventLogMessages.Add(&H105F, "	Fault - AFC 16	")

        Me.EventLogMessages.Add(&H1160, "	Status - Cooling Not Ready	")
        Me.EventLogMessages.Add(&H1161, "	Status - Cooling Read	")
        Me.EventLogMessages.Add(&H1162, "	Status - Cooling not Configured	")
        Me.EventLogMessages.Add(&H1163, "	Status - Cooling Configured	")
        Me.EventLogMessages.Add(&H1164, "	Fault - Cooling Connection Lost	")
        Me.EventLogMessages.Add(&H1165, "	Status - Cooling Connection Established	")
        Me.EventLogMessages.Add(&H1060, "	Fault - Cooling 1	")
        Me.EventLogMessages.Add(&H1061, "	Fault - Cooling 2	")
        Me.EventLogMessages.Add(&H1062, "	Fault - Cooling 3	")
        Me.EventLogMessages.Add(&H1063, "	Fault - Cooling 4	")
        Me.EventLogMessages.Add(&H1064, "	Fault - Cooling 5	")
        Me.EventLogMessages.Add(&H1065, "	Fault - Cooling 6	")
        Me.EventLogMessages.Add(&H1066, "	Fault - Cooling 7	")
        Me.EventLogMessages.Add(&H1067, "	Fault - Cooling 8	")
        Me.EventLogMessages.Add(&H1068, "	Fault - Cooling 9	")
        Me.EventLogMessages.Add(&H1069, "	Fault - Cooling 10	")
        Me.EventLogMessages.Add(&H106A, "	Fault - Cooling 11	")
        Me.EventLogMessages.Add(&H106B, "	Fault - Cooling 12	")
        Me.EventLogMessages.Add(&H106C, "	Fault - Cooling 13	")
        Me.EventLogMessages.Add(&H106D, "	Fault - Cooling 14	")
        Me.EventLogMessages.Add(&H106E, "	Fault - Cooling 15	")
        Me.EventLogMessages.Add(&H106F, "	Fault - Cooling 16	")

        Me.EventLogMessages.Add(&H1170, "	Status - Heater Magnet Interface Not Ready	")
        Me.EventLogMessages.Add(&H1171, "	Status - Heater Magnet Interface Read	")
        Me.EventLogMessages.Add(&H1172, "	Status - Heater Magnet Interface not Configured	")
        Me.EventLogMessages.Add(&H1173, "	Status - Heater Magnet Interface Configured	")
        Me.EventLogMessages.Add(&H1174, "	Fault - Heater Magnet Interface Connection Lost	")
        Me.EventLogMessages.Add(&H1175, "	Status - Heater Magnet Interface Connection Established	")
        Me.EventLogMessages.Add(&H1070, "	Fault - HTR-MAG Heater over current absolute	")
        Me.EventLogMessages.Add(&H1071, "	Fault - HTR-MAG Heater under current absolute	")
        Me.EventLogMessages.Add(&H1072, "	Fault - HTR-MAG Heater over current relative	")
        Me.EventLogMessages.Add(&H1073, "	Fault - HTR-MAG Heater under current relative	")
        Me.EventLogMessages.Add(&H1074, "	Fault - HTR-MAG Heater over voltage absolute	")
        Me.EventLogMessages.Add(&H1075, "	Fault - HTR-MAG Heater under voltage relative	")
        Me.EventLogMessages.Add(&H1076, "	Fault - HTR-MAG Magnet over current absolute	")
        Me.EventLogMessages.Add(&H1077, "	Fault - HTR-MAG Magnet under current absolute	")
        Me.EventLogMessages.Add(&H1078, "	Fault - HTR-MAG Magnet over current relative	")
        Me.EventLogMessages.Add(&H1079, "	Fault - HTR-MAG Magnet under current relative	")
        Me.EventLogMessages.Add(&H107A, "	Fault - HTR-MAG Magnet over voltage absolute	")
        Me.EventLogMessages.Add(&H107B, "	Fault - HTR-MAG Magnet under voltage relative	")
        Me.EventLogMessages.Add(&H107C, "	Fault - HTR-MAG Heater Hardware over voltage	")
        Me.EventLogMessages.Add(&H107D, "	Fault - HTR-MAG Hardware temperature switch	")
        Me.EventLogMessages.Add(&H107E, "	Fault - HTR-MAG coolant fault	")
        Me.EventLogMessages.Add(&H107F, "	Fault - HTR-MAG can fault	")

        Me.EventLogMessages.Add(&H1180, "	Status - Gun Driver Not Ready	")
        Me.EventLogMessages.Add(&H1181, "	Status - Gun Driver Read	")
        Me.EventLogMessages.Add(&H1182, "	Status - Gun Driver not Configured	")
        Me.EventLogMessages.Add(&H1183, "	Status - Gun Driver Configured	")
        Me.EventLogMessages.Add(&H1184, "	Fault - Gun Driver Connection Lost	")
        Me.EventLogMessages.Add(&H1185, "	Status - Gun Driver Connection Established	")
        Me.EventLogMessages.Add(&H1186, "	Fault - Gun Driver Heater Off	")
        Me.EventLogMessages.Add(&H1187, "	Status - Gun Driver Heater On	")
        Me.EventLogMessages.Add(&H1080, "	Fault - Gun Driver 1	")
        Me.EventLogMessages.Add(&H1081, "	Fault - Gun Driver 2	")
        Me.EventLogMessages.Add(&H1082, "	Fault - Gun Driver 3	")
        Me.EventLogMessages.Add(&H1083, "	Fault - Gun Driver 4	")
        Me.EventLogMessages.Add(&H1084, "	Fault - Gun Driver 5	")
        Me.EventLogMessages.Add(&H1085, "	Fault - Gun Driver 6	")
        Me.EventLogMessages.Add(&H1086, "	Fault - Gun Driver 7	")
        Me.EventLogMessages.Add(&H1087, "	Fault - Gun Driver 8	")
        Me.EventLogMessages.Add(&H1088, "	Fault - Gun Driver 9	")
        Me.EventLogMessages.Add(&H1089, "	Fault - Gun Driver 10	")
        Me.EventLogMessages.Add(&H108A, "	Fault - Gun Driver 11	")
        Me.EventLogMessages.Add(&H108B, "	Fault - Gun Driver 12	")
        Me.EventLogMessages.Add(&H108C, "	Fault - Gun Driver 13	")
        Me.EventLogMessages.Add(&H108D, "	Fault - Gun Driver 14	")
        Me.EventLogMessages.Add(&H108E, "	Fault - Gun Driver 15	")
        Me.EventLogMessages.Add(&H108F, "	Fault - Gun Driver 16	")

#End If

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

        Me.EventLogMessages.Add(&H1, "Connection - Ion Pump Board Connection Lost")
        Me.EventLogMessages.Add(&H81, "Connection - Ion Pump Board Connection Established")
        Me.EventLogMessages.Add(&H2, "Connection - Pulse Current Board Connection Lost")
        Me.EventLogMessages.Add(&H82, "Connection - Pulse Current Board Connection Established")
        Me.EventLogMessages.Add(&H3, "Connection - PulseSync Board Connection Lost")
        Me.EventLogMessages.Add(&H83, "Connection - Pulse Sync Board Connection Established")
        Me.EventLogMessages.Add(&H4, "Connection - HV Interface Board Connection Lost")
        Me.EventLogMessages.Add(&H84, "Connection - HV Interface Board Connection Established")
        Me.EventLogMessages.Add(&H5, "Connection - AFC Board Connection Lost")
        Me.EventLogMessages.Add(&H85, "Connection - AFC Board Connection Established")
        Me.EventLogMessages.Add(&H6, "Connection - Cooling Interface Board Connection Lost")
        Me.EventLogMessages.Add(&H86, "Connection - Cooling Interface Board Connection Established")
        Me.EventLogMessages.Add(&H7, "Connection - Heater Magnet Board Connection Lost")
        Me.EventLogMessages.Add(&H87, "Connection - Heater Magnet Board Connection Established")
        Me.EventLogMessages.Add(&H8, "Connection - Gun Driver Connection Lost")
        Me.EventLogMessages.Add(&H88, "Connection - Gun Driver Connection Established")

        Me.EventLogMessages.Add(&H200, "State - Entered State Personality Received")
        Me.EventLogMessages.Add(&H201, "Error - Personality not valid")
        Me.EventLogMessages.Add(&H202, "Notice - All Modules Configured")
        Me.EventLogMessages.Add(&H203, "Notice - Warmup Done")
        Me.EventLogMessages.Add(&H204, "Notice - Drive up Complete")
        Me.EventLogMessages.Add(&H205, "Fault - Drive Up Timeout ")
        Me.EventLogMessages.Add(&H206, "State - Entered State HV Off Faults Clear")





        Me.EventLogMessages.Add(&HC100, "Control - Ion Pump Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC108, "Control - Ion Pump Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC101, "Control - Ion Pump Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC109, "Control - Ion Pump Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC102, "Control - Ion Pump Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC10A, "Control - Ion Pump Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC103, "Control - Ion Pump Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC10B, "Control - Ion Pump Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC104, "Control - Ion Pump Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC10C, "Control - Ion Pump Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC105, "Control - Ion Pump Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC10D, "Control - Ion Pump Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC106, "Control - Ion Pump Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC10E, "Control - Ion Pump Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC107, "Control - Ion Pump Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC10F, "Control - Ion Pump Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC110, "Notice - Ion Pump Notice 0")
        Me.EventLogMessages.Add(&HC111, "Notice - Ion Pump Notice 1")
        Me.EventLogMessages.Add(&HC112, "Notice - Ion Pump Notice 2")
        Me.EventLogMessages.Add(&HC113, "Notice - Ion Pump Notice 3")
        Me.EventLogMessages.Add(&HC114, "Notice - Ion Pump Notice 4")
        Me.EventLogMessages.Add(&HC115, "Notice - Ion Pump Notice 5")
        Me.EventLogMessages.Add(&HC116, "Notice - Ion Pump Notice 6")
        Me.EventLogMessages.Add(&HC117, "Notice - Ion Pump Notice 7")

        Me.EventLogMessages.Add(&HC120, "Fault - Ion Pump Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC130, "Fault - Ion Pump Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC121, "Fault - Ion Pump Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC131, "Fault - Ion Pump Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC122, "Fault - Ion Pump Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC132, "Fault - Ion Pump Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC123, "Fault - Ion Pump Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC133, "Fault - Ion Pump Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC124, "Fault - Ion Pump Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC134, "Fault - Ion Pump Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC125, "Fault - Ion Pump Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC135, "Fault - Ion Pump Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC126, "Fault - Ion Pump Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC136, "Fault - Ion Pump Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC127, "Fault - Ion Pump Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC137, "Fault - Ion Pump Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC128, "Fault - Ion Pump Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC138, "Fault - Ion Pump Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC129, "Fault - Ion Pump Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC139, "Fault - Ion Pump Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC12A, "Fault - Ion Pump Fault A Bit Set")
        Me.EventLogMessages.Add(&HC13A, "Fault - Ion Pump Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC12B, "Fault - Ion Pump Fault B Bit Set")
        Me.EventLogMessages.Add(&HC13B, "Fault - Ion Pump Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC12C, "Fault - Ion Pump Fault C Bit Set")
        Me.EventLogMessages.Add(&HC13C, "Fault - Ion Pump Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC12D, "Fault - Ion Pump Fault D Bit Set")
        Me.EventLogMessages.Add(&HC13D, "Fault - Ion Pump Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC12E, "Fault - Ion Pump Fault E Bit Set")
        Me.EventLogMessages.Add(&HC13E, "Fault - Ion Pump Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC12F, "Fault - Ion Pump Fault F Bit Set")
        Me.EventLogMessages.Add(&HC13F, "Fault - Ion Pump Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC140, "Log - Ion Pump Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC150, "Log - Ion Pump Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC141, "Log - Ion Pump Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC151, "Log - Ion Pump Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC142, "Log - Ion Pump Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC152, "Log - Ion Pump Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC143, "Log - Ion Pump Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC153, "Log - Ion Pump Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC144, "Log - Ion Pump Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC154, "Log - Ion Pump Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC145, "Log - Ion Pump Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC155, "Log - Ion Pump Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC146, "Log - Ion Pump Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC156, "Log - Ion Pump Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC147, "Log - Ion Pump Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC157, "Log - Ion Pump Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC148, "Log - Ion Pump Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC158, "Log - Ion Pump Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC149, "Log - Ion Pump Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC159, "Log - Ion Pump Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC14A, "Log - Ion Pump Logged A Bit Set")
        Me.EventLogMessages.Add(&HC15A, "Log - Ion Pump Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC14B, "Log - Ion Pump Logged B Bit Set")
        Me.EventLogMessages.Add(&HC15B, "Log - Ion Pump Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC14C, "Log - Ion Pump Logged C Bit Set")
        Me.EventLogMessages.Add(&HC15C, "Log - Ion Pump Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC14D, "Log - Ion Pump Logged D Bit Set")
        Me.EventLogMessages.Add(&HC15D, "Log - Ion Pump Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC14E, "Log - Ion Pump Logged E Bit Set")
        Me.EventLogMessages.Add(&HC15E, "Log - Ion Pump Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC14F, "Log - Ion Pump Logged F Bit Set")
        Me.EventLogMessages.Add(&HC15F, "Log - Ion Pump Logged F Bit Cleared")




        Me.EventLogMessages.Add(&HC200, "Control - Pulse Current Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC208, "Control - Pulse Current Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC201, "Control - Pulse Current Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC209, "Control - Pulse Current Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC202, "Control - Pulse Current Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC20A, "Control - Pulse Current Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC203, "Control - Pulse Current Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC20B, "Control - Pulse Current Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC204, "Control - Pulse Current Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC20C, "Control - Pulse Current Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC205, "Control - Pulse Current Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC20D, "Control - Pulse Current Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC206, "Control - Pulse Current Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC20E, "Control - Pulse Current Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC207, "Control - Pulse Current Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC20F, "Control - Pulse Current Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC210, "Notice - Pulse Current Notice 0")
        Me.EventLogMessages.Add(&HC211, "Notice - Pulse Current Notice 1")
        Me.EventLogMessages.Add(&HC212, "Notice - Pulse Current Notice 2")
        Me.EventLogMessages.Add(&HC213, "Notice - Pulse Current Notice 3")
        Me.EventLogMessages.Add(&HC214, "Notice - Pulse Current Notice 4")
        Me.EventLogMessages.Add(&HC215, "Notice - Pulse Current Notice 5")
        Me.EventLogMessages.Add(&HC216, "Notice - Pulse Current Notice 6")
        Me.EventLogMessages.Add(&HC217, "Notice - Pulse Current Notice 7")

        Me.EventLogMessages.Add(&HC220, "Fault - Pulse Current Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC230, "Fault - Pulse Current Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC221, "Fault - Pulse Current Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC231, "Fault - Pulse Current Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC222, "Fault - Pulse Current Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC232, "Fault - Pulse Current Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC223, "Fault - Pulse Current Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC233, "Fault - Pulse Current Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC224, "Fault - Pulse Current Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC234, "Fault - Pulse Current Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC225, "Fault - Pulse Current Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC235, "Fault - Pulse Current Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC226, "Fault - Pulse Current Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC236, "Fault - Pulse Current Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC227, "Fault - Pulse Current Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC237, "Fault - Pulse Current Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC228, "Fault - Pulse Current Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC238, "Fault - Pulse Current Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC229, "Fault - Pulse Current Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC239, "Fault - Pulse Current Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC22A, "Fault - Pulse Current Fault A Bit Set")
        Me.EventLogMessages.Add(&HC23A, "Fault - Pulse Current Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC22B, "Fault - Pulse Current Fault B Bit Set")
        Me.EventLogMessages.Add(&HC23B, "Fault - Pulse Current Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC22C, "Fault - Pulse Current Fault C Bit Set")
        Me.EventLogMessages.Add(&HC23C, "Fault - Pulse Current Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC22D, "Fault - Pulse Current Fault D Bit Set")
        Me.EventLogMessages.Add(&HC23D, "Fault - Pulse Current Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC22E, "Fault - Pulse Current Fault E Bit Set")
        Me.EventLogMessages.Add(&HC23E, "Fault - Pulse Current Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC22F, "Fault - Pulse Current Fault F Bit Set")
        Me.EventLogMessages.Add(&HC23F, "Fault - Pulse Current Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC240, "Log - Pulse Current Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC250, "Log - Pulse Current Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC241, "Log - Pulse Current Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC251, "Log - Pulse Current Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC242, "Log - Pulse Current Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC252, "Log - Pulse Current Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC243, "Log - Pulse Current Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC253, "Log - Pulse Current Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC244, "Log - Pulse Current Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC254, "Log - Pulse Current Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC245, "Log - Pulse Current Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC255, "Log - Pulse Current Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC246, "Log - Pulse Current Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC256, "Log - Pulse Current Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC247, "Log - Pulse Current Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC257, "Log - Pulse Current Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC248, "Log - Pulse Current Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC258, "Log - Pulse Current Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC249, "Log - Pulse Current Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC259, "Log - Pulse Current Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC24A, "Log - Pulse Current Logged A Bit Set")
        Me.EventLogMessages.Add(&HC25A, "Log - Pulse Current Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC24B, "Log - Pulse Current Logged B Bit Set")
        Me.EventLogMessages.Add(&HC25B, "Log - Pulse Current Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC24C, "Log - Pulse Current Logged C Bit Set")
        Me.EventLogMessages.Add(&HC25C, "Log - Pulse Current Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC24D, "Log - Pulse Current Logged D Bit Set")
        Me.EventLogMessages.Add(&HC25D, "Log - Pulse Current Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC24E, "Log - Pulse Current Logged E Bit Set")
        Me.EventLogMessages.Add(&HC25E, "Log - Pulse Current Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC24F, "Log - Pulse Current Logged F Bit Set")
        Me.EventLogMessages.Add(&HC25F, "Log - Pulse Current Logged F Bit Cleared")





        Me.EventLogMessages.Add(&HC300, "Control - Pulse Sync Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC308, "Control - Pulse Sync Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC301, "Control - Pulse Sync Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC309, "Control - Pulse Sync Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC302, "Control - Pulse Sync Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC30A, "Control - Pulse Sync Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC303, "Control - Pulse Sync Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC30B, "Control - Pulse Sync Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC304, "Control - Pulse Sync Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC30C, "Control - Pulse Sync Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC305, "Control - Pulse Sync Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC30D, "Control - Pulse Sync Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC306, "Control - Pulse Sync Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC30E, "Control - Pulse Sync Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC307, "Control - Pulse Sync Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC30F, "Control - Pulse Sync Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC310, "Notice - Pulse Sync Notice 0")
        Me.EventLogMessages.Add(&HC311, "Notice - Pulse Sync Notice 1")
        Me.EventLogMessages.Add(&HC312, "Notice - Pulse Sync Notice 2")
        Me.EventLogMessages.Add(&HC313, "Notice - Pulse Sync Notice 3")
        Me.EventLogMessages.Add(&HC314, "Notice - Pulse Sync Notice 4")
        Me.EventLogMessages.Add(&HC315, "Notice - Pulse Sync Notice 5")
        Me.EventLogMessages.Add(&HC316, "Notice - Pulse Sync Notice 6")
        Me.EventLogMessages.Add(&HC317, "Notice - Pulse Sync Notice 7")

        Me.EventLogMessages.Add(&HC320, "Fault - Pulse Sync Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC330, "Fault - Pulse Sync Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC321, "Fault - Pulse Sync Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC331, "Fault - Pulse Sync Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC322, "Fault - Pulse Sync Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC332, "Fault - Pulse Sync Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC323, "Fault - Pulse Sync Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC333, "Fault - Pulse Sync Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC324, "Fault - Pulse Sync Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC334, "Fault - Pulse Sync Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC325, "Fault - Pulse Sync Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC335, "Fault - Pulse Sync Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC326, "Fault - Pulse Sync Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC336, "Fault - Pulse Sync Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC327, "Fault - Pulse Sync Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC337, "Fault - Pulse Sync Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC328, "Fault - Pulse Sync Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC338, "Fault - Pulse Sync Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC329, "Fault - Pulse Sync Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC339, "Fault - Pulse Sync Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC32A, "Fault - Pulse Sync Fault A Bit Set")
        Me.EventLogMessages.Add(&HC33A, "Fault - Pulse Sync Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC32B, "Fault - Pulse Sync Fault B Bit Set")
        Me.EventLogMessages.Add(&HC33B, "Fault - Pulse Sync Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC32C, "Fault - Pulse Sync Fault C Bit Set")
        Me.EventLogMessages.Add(&HC33C, "Fault - Pulse Sync Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC32D, "Fault - Pulse Sync Fault D Bit Set")
        Me.EventLogMessages.Add(&HC33D, "Fault - Pulse Sync Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC32E, "Fault - Pulse Sync Fault E Bit Set")
        Me.EventLogMessages.Add(&HC33E, "Fault - Pulse Sync Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC32F, "Fault - Pulse Sync Fault F Bit Set")
        Me.EventLogMessages.Add(&HC33F, "Fault - Pulse Sync Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC340, "Log - Pulse Sync Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC350, "Log - Pulse Sync Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC341, "Log - Pulse Sync Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC351, "Log - Pulse Sync Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC342, "Log - Pulse Sync Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC352, "Log - Pulse Sync Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC343, "Log - Pulse Sync Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC353, "Log - Pulse Sync Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC344, "Log - Pulse Sync Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC354, "Log - Pulse Sync Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC345, "Log - Pulse Sync Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC355, "Log - Pulse Sync Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC346, "Log - Pulse Sync Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC356, "Log - Pulse Sync Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC347, "Log - Pulse Sync Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC357, "Log - Pulse Sync Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC348, "Log - Pulse Sync Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC358, "Log - Pulse Sync Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC349, "Log - Pulse Sync Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC359, "Log - Pulse Sync Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC34A, "Log - Pulse Sync Logged A Bit Set")
        Me.EventLogMessages.Add(&HC35A, "Log - Pulse Sync Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC34B, "Log - Pulse Sync Logged B Bit Set")
        Me.EventLogMessages.Add(&HC35B, "Log - Pulse Sync Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC34C, "Log - Pulse Sync Logged C Bit Set")
        Me.EventLogMessages.Add(&HC35C, "Log - Pulse Sync Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC34D, "Log - Pulse Sync Logged D Bit Set")
        Me.EventLogMessages.Add(&HC35D, "Log - Pulse Sync Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC34E, "Log - Pulse Sync Logged E Bit Set")
        Me.EventLogMessages.Add(&HC35E, "Log - Pulse Sync Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC34F, "Log - Pulse Sync Logged F Bit Set")
        Me.EventLogMessages.Add(&HC35F, "Log - Pulse Sync Logged F Bit Cleared")




        Me.EventLogMessages.Add(&HC400, "Control - HV Interface Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC408, "Control - HV Interface Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC401, "Control - HV Interface Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC409, "Control - HV Interface Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC402, "Control - HV Interface Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC40A, "Control - HV Interface Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC403, "Control - HV Interface Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC40B, "Control - HV Interface Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC404, "Control - HV Interface Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC40C, "Control - HV Interface Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC405, "Control - HV Interface Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC40D, "Control - HV Interface Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC406, "Control - HV Interface Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC40E, "Control - HV Interface Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC407, "Control - HV Interface Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC40F, "Control - HV Interface Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC410, "Notice - HV Interface Notice 0")
        Me.EventLogMessages.Add(&HC411, "Notice - HV Interface Notice 1")
        Me.EventLogMessages.Add(&HC412, "Notice - HV Interface Notice 2")
        Me.EventLogMessages.Add(&HC413, "Notice - HV Interface Notice 3")
        Me.EventLogMessages.Add(&HC414, "Notice - HV Interface Notice 4")
        Me.EventLogMessages.Add(&HC415, "Notice - HV Interface Notice 5")
        Me.EventLogMessages.Add(&HC416, "Notice - HV Interface Notice 6")
        Me.EventLogMessages.Add(&HC417, "Notice - HV Interface Notice 7")

        Me.EventLogMessages.Add(&HC420, "Fault - HV Interface Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC430, "Fault - HV Interface Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC421, "Fault - HV Interface Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC431, "Fault - HV Interface Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC422, "Fault - HV Interface Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC432, "Fault - HV Interface Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC423, "Fault - HV Interface Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC433, "Fault - HV Interface Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC424, "Fault - HV Interface Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC434, "Fault - HV Interface Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC425, "Fault - HV Interface Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC435, "Fault - HV Interface Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC426, "Fault - HV Interface Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC436, "Fault - HV Interface Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC427, "Fault - HV Interface Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC437, "Fault - HV Interface Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC428, "Fault - HV Interface Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC438, "Fault - HV Interface Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC429, "Fault - HV Interface Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC439, "Fault - HV Interface Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC42A, "Fault - HV Interface Fault A Bit Set")
        Me.EventLogMessages.Add(&HC43A, "Fault - HV Interface Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC42B, "Fault - HV Interface Fault B Bit Set")
        Me.EventLogMessages.Add(&HC43B, "Fault - HV Interface Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC42C, "Fault - HV Interface Fault C Bit Set")
        Me.EventLogMessages.Add(&HC43C, "Fault - HV Interface Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC42D, "Fault - HV Interface Fault D Bit Set")
        Me.EventLogMessages.Add(&HC43D, "Fault - HV Interface Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC42E, "Fault - HV Interface Fault E Bit Set")
        Me.EventLogMessages.Add(&HC43E, "Fault - HV Interface Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC42F, "Fault - HV Interface Fault F Bit Set")
        Me.EventLogMessages.Add(&HC43F, "Fault - HV Interface Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC440, "Log - HV Interface Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC450, "Log - HV Interface Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC441, "Log - HV Interface Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC451, "Log - HV Interface Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC442, "Log - HV Interface Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC452, "Log - HV Interface Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC443, "Log - HV Interface Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC453, "Log - HV Interface Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC444, "Log - HV Interface Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC454, "Log - HV Interface Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC445, "Log - HV Interface Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC455, "Log - HV Interface Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC446, "Log - HV Interface Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC456, "Log - HV Interface Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC447, "Log - HV Interface Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC457, "Log - HV Interface Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC448, "Log - HV Interface Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC458, "Log - HV Interface Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC449, "Log - HV Interface Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC459, "Log - HV Interface Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC44A, "Log - HV Interface Logged A Bit Set")
        Me.EventLogMessages.Add(&HC45A, "Log - HV Interface Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC44B, "Log - HV Interface Logged B Bit Set")
        Me.EventLogMessages.Add(&HC45B, "Log - HV Interface Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC44C, "Log - HV Interface Logged C Bit Set")
        Me.EventLogMessages.Add(&HC45C, "Log - HV Interface Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC44D, "Log - HV Interface Logged D Bit Set")
        Me.EventLogMessages.Add(&HC45D, "Log - HV Interface Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC44E, "Log - HV Interface Logged E Bit Set")
        Me.EventLogMessages.Add(&HC45E, "Log - HV Interface Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC44F, "Log - HV Interface Logged F Bit Set")
        Me.EventLogMessages.Add(&HC45F, "Log - HV Interface Logged F Bit Cleared")




        Me.EventLogMessages.Add(&HC500, "Control - AFC Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC508, "Control - AFC Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC501, "Control - AFC Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC509, "Control - AFC Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC502, "Control - AFC Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC50A, "Control - AFC Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC503, "Control - AFC Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC50B, "Control - AFC Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC504, "Control - AFC Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC50C, "Control - AFC Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC505, "Control - AFC Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC50D, "Control - AFC Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC506, "Control - AFC Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC50E, "Control - AFC Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC507, "Control - AFC Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC50F, "Control - AFC Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC510, "Notice - AFC Notice 0")
        Me.EventLogMessages.Add(&HC511, "Notice - AFC Notice 1")
        Me.EventLogMessages.Add(&HC512, "Notice - AFC Notice 2")
        Me.EventLogMessages.Add(&HC513, "Notice - AFC Notice 3")
        Me.EventLogMessages.Add(&HC514, "Notice - AFC Notice 4")
        Me.EventLogMessages.Add(&HC515, "Notice - AFC Notice 5")
        Me.EventLogMessages.Add(&HC516, "Notice - AFC Notice 6")
        Me.EventLogMessages.Add(&HC517, "Notice - AFC Notice 7")

        Me.EventLogMessages.Add(&HC520, "Fault - AFC Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC530, "Fault - AFC Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC521, "Fault - AFC Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC531, "Fault - AFC Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC522, "Fault - AFC Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC532, "Fault - AFC Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC523, "Fault - AFC Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC533, "Fault - AFC Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC524, "Fault - AFC Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC534, "Fault - AFC Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC525, "Fault - AFC Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC535, "Fault - AFC Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC526, "Fault - AFC Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC536, "Fault - AFC Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC527, "Fault - AFC Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC537, "Fault - AFC Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC528, "Fault - AFC Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC538, "Fault - AFC Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC529, "Fault - AFC Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC539, "Fault - AFC Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC52A, "Fault - AFC Fault A Bit Set")
        Me.EventLogMessages.Add(&HC53A, "Fault - AFC Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC52B, "Fault - AFC Fault B Bit Set")
        Me.EventLogMessages.Add(&HC53B, "Fault - AFC Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC52C, "Fault - AFC Fault C Bit Set")
        Me.EventLogMessages.Add(&HC53C, "Fault - AFC Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC52D, "Fault - AFC Fault D Bit Set")
        Me.EventLogMessages.Add(&HC53D, "Fault - AFC Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC52E, "Fault - AFC Fault E Bit Set")
        Me.EventLogMessages.Add(&HC53E, "Fault - AFC Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC52F, "Fault - AFC Fault F Bit Set")
        Me.EventLogMessages.Add(&HC53F, "Fault - AFC Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC540, "Log - AFC Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC550, "Log - AFC Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC541, "Log - AFC Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC551, "Log - AFC Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC542, "Log - AFC Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC552, "Log - AFC Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC543, "Log - AFC Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC553, "Log - AFC Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC544, "Log - AFC Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC554, "Log - AFC Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC545, "Log - AFC Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC555, "Log - AFC Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC546, "Log - AFC Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC556, "Log - AFC Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC547, "Log - AFC Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC557, "Log - AFC Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC548, "Log - AFC Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC558, "Log - AFC Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC549, "Log - AFC Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC559, "Log - AFC Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC54A, "Log - AFC Logged A Bit Set")
        Me.EventLogMessages.Add(&HC55A, "Log - AFC Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC54B, "Log - AFC Logged B Bit Set")
        Me.EventLogMessages.Add(&HC55B, "Log - AFC Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC54C, "Log - AFC Logged C Bit Set")
        Me.EventLogMessages.Add(&HC55C, "Log - AFC Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC54D, "Log - AFC Logged D Bit Set")
        Me.EventLogMessages.Add(&HC55D, "Log - AFC Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC54E, "Log - AFC Logged E Bit Set")
        Me.EventLogMessages.Add(&HC55E, "Log - AFC Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC54F, "Log - AFC Logged F Bit Set")
        Me.EventLogMessages.Add(&HC55F, "Log - AFC Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC600, "Control - Cooling Interfacce Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC608, "Control - Cooling Interfacce Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC601, "Control - Cooling Interfacce Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC609, "Control - Cooling Interfacce Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC602, "Control - Cooling Interfacce Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC60A, "Control - Cooling Interfacce Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC603, "Control - Cooling Interfacce Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC60B, "Control - Cooling Interfacce Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC604, "Control - Cooling Interfacce Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC60C, "Control - Cooling Interfacce Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC605, "Control - Cooling Interfacce Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC60D, "Control - Cooling Interfacce Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC606, "Control - Cooling Interfacce Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC60E, "Control - Cooling Interfacce Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC607, "Control - Cooling Interfacce Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC60F, "Control - Cooling Interfacce Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC610, "Notice - Cooling Interfacce Notice 0")
        Me.EventLogMessages.Add(&HC611, "Notice - Cooling Interfacce Notice 1")
        Me.EventLogMessages.Add(&HC612, "Notice - Cooling Interfacce Notice 2")
        Me.EventLogMessages.Add(&HC613, "Notice - Cooling Interfacce Notice 3")
        Me.EventLogMessages.Add(&HC614, "Notice - Cooling Interfacce Notice 4")
        Me.EventLogMessages.Add(&HC615, "Notice - Cooling Interfacce Notice 5")
        Me.EventLogMessages.Add(&HC616, "Notice - Cooling Interfacce Notice 6")
        Me.EventLogMessages.Add(&HC617, "Notice - Cooling Interfacce Notice 7")

        Me.EventLogMessages.Add(&HC620, "Fault - Cooling Interfacce Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC630, "Fault - Cooling Interfacce Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC621, "Fault - Cooling Interfacce Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC631, "Fault - Cooling Interfacce Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC622, "Fault - Cooling Interfacce Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC632, "Fault - Cooling Interfacce Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC623, "Fault - Cooling Interfacce Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC633, "Fault - Cooling Interfacce Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC624, "Fault - Cooling Interfacce Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC634, "Fault - Cooling Interfacce Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC625, "Fault - Cooling Interfacce Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC635, "Fault - Cooling Interfacce Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC626, "Fault - Cooling Interfacce Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC636, "Fault - Cooling Interfacce Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC627, "Fault - Cooling Interfacce Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC637, "Fault - Cooling Interfacce Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC628, "Fault - Cooling Interfacce Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC638, "Fault - Cooling Interfacce Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC629, "Fault - Cooling Interfacce Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC639, "Fault - Cooling Interfacce Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC62A, "Fault - Cooling Interfacce Fault A Bit Set")
        Me.EventLogMessages.Add(&HC63A, "Fault - Cooling Interfacce Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC62B, "Fault - Cooling Interfacce Fault B Bit Set")
        Me.EventLogMessages.Add(&HC63B, "Fault - Cooling Interfacce Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC62C, "Fault - Cooling Interfacce Fault C Bit Set")
        Me.EventLogMessages.Add(&HC63C, "Fault - Cooling Interfacce Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC62D, "Fault - Cooling Interfacce Fault D Bit Set")
        Me.EventLogMessages.Add(&HC63D, "Fault - Cooling Interfacce Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC62E, "Fault - Cooling Interfacce Fault E Bit Set")
        Me.EventLogMessages.Add(&HC63E, "Fault - Cooling Interfacce Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC62F, "Fault - Cooling Interfacce Fault F Bit Set")
        Me.EventLogMessages.Add(&HC63F, "Fault - Cooling Interfacce Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC640, "Log - Cooling Interfacce Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC650, "Log - Cooling Interfacce Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC641, "Log - Cooling Interfacce Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC651, "Log - Cooling Interfacce Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC642, "Log - Cooling Interfacce Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC652, "Log - Cooling Interfacce Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC643, "Log - Cooling Interfacce Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC653, "Log - Cooling Interfacce Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC644, "Log - Cooling Interfacce Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC654, "Log - Cooling Interfacce Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC645, "Log - Cooling Interfacce Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC655, "Log - Cooling Interfacce Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC646, "Log - Cooling Interfacce Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC656, "Log - Cooling Interfacce Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC647, "Log - Cooling Interfacce Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC657, "Log - Cooling Interfacce Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC648, "Log - Cooling Interfacce Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC658, "Log - Cooling Interfacce Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC649, "Log - Cooling Interfacce Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC659, "Log - Cooling Interfacce Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC64A, "Log - Cooling Interfacce Logged A Bit Set")
        Me.EventLogMessages.Add(&HC65A, "Log - Cooling Interfacce Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC64B, "Log - Cooling Interfacce Logged B Bit Set")
        Me.EventLogMessages.Add(&HC65B, "Log - Cooling Interfacce Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC64C, "Log - Cooling Interfacce Logged C Bit Set")
        Me.EventLogMessages.Add(&HC65C, "Log - Cooling Interfacce Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC64D, "Log - Cooling Interfacce Logged D Bit Set")
        Me.EventLogMessages.Add(&HC65D, "Log - Cooling Interfacce Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC64E, "Log - Cooling Interfacce Logged E Bit Set")
        Me.EventLogMessages.Add(&HC65E, "Log - Cooling Interfacce Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC64F, "Log - Cooling Interfacce Logged F Bit Set")
        Me.EventLogMessages.Add(&HC65F, "Log - Cooling Interfacce Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC700, "Control - Heater Magnet Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC708, "Control - Heater Magnet Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC701, "Control - Heater Magnet Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC709, "Control - Heater Magnet Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC702, "Control - Heater Magnet Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC70A, "Control - Heater Magnet Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC703, "Control - Heater Magnet Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC70B, "Control - Heater Magnet Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC704, "Control - Heater Magnet Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC70C, "Control - Heater Magnet Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC705, "Control - Heater Magnet Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC70D, "Control - Heater Magnet Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC706, "Control - Heater Magnet Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC70E, "Control - Heater Magnet Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC707, "Control - Heater Magnet Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC70F, "Control - Heater Magnet Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC710, "Notice - Heater Magnet Notice 0")
        Me.EventLogMessages.Add(&HC711, "Notice - Heater Magnet Notice 1")
        Me.EventLogMessages.Add(&HC712, "Notice - Heater Magnet Notice 2")
        Me.EventLogMessages.Add(&HC713, "Notice - Heater Magnet Notice 3")
        Me.EventLogMessages.Add(&HC714, "Notice - Heater Magnet Notice 4")
        Me.EventLogMessages.Add(&HC715, "Notice - Heater Magnet Notice 5")
        Me.EventLogMessages.Add(&HC716, "Notice - Heater Magnet Notice 6")
        Me.EventLogMessages.Add(&HC717, "Notice - Heater Magnet Notice 7")

        Me.EventLogMessages.Add(&HC720, "Fault - Heater Magnet Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC730, "Fault - Heater Magnet Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC721, "Fault - Heater Magnet Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC731, "Fault - Heater Magnet Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC722, "Fault - Heater Magnet Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC732, "Fault - Heater Magnet Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC723, "Fault - Heater Magnet Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC733, "Fault - Heater Magnet Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC724, "Fault - Heater Magnet Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC734, "Fault - Heater Magnet Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC725, "Fault - Heater Magnet Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC735, "Fault - Heater Magnet Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC726, "Fault - Heater Magnet Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC736, "Fault - Heater Magnet Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC727, "Fault - Heater Magnet Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC737, "Fault - Heater Magnet Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC728, "Fault - Heater Magnet Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC738, "Fault - Heater Magnet Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC729, "Fault - Heater Magnet Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC739, "Fault - Heater Magnet Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC72A, "Fault - Heater Magnet Fault A Bit Set")
        Me.EventLogMessages.Add(&HC73A, "Fault - Heater Magnet Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC72B, "Fault - Heater Magnet Fault B Bit Set")
        Me.EventLogMessages.Add(&HC73B, "Fault - Heater Magnet Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC72C, "Fault - Heater Magnet Fault C Bit Set")
        Me.EventLogMessages.Add(&HC73C, "Fault - Heater Magnet Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC72D, "Fault - Heater Magnet Fault D Bit Set")
        Me.EventLogMessages.Add(&HC73D, "Fault - Heater Magnet Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC72E, "Fault - Heater Magnet Fault E Bit Set")
        Me.EventLogMessages.Add(&HC73E, "Fault - Heater Magnet Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC72F, "Fault - Heater Magnet Fault F Bit Set")
        Me.EventLogMessages.Add(&HC73F, "Fault - Heater Magnet Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC740, "Log - Heater Magnet Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC750, "Log - Heater Magnet Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC741, "Log - Heater Magnet Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC751, "Log - Heater Magnet Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC742, "Log - Heater Magnet Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC752, "Log - Heater Magnet Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC743, "Log - Heater Magnet Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC753, "Log - Heater Magnet Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC744, "Log - Heater Magnet Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC754, "Log - Heater Magnet Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC745, "Log - Heater Magnet Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC755, "Log - Heater Magnet Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC746, "Log - Heater Magnet Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC756, "Log - Heater Magnet Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC747, "Log - Heater Magnet Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC757, "Log - Heater Magnet Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC748, "Log - Heater Magnet Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC758, "Log - Heater Magnet Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC749, "Log - Heater Magnet Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC759, "Log - Heater Magnet Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC74A, "Log - Heater Magnet Logged A Bit Set")
        Me.EventLogMessages.Add(&HC75A, "Log - Heater Magnet Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC74B, "Log - Heater Magnet Logged B Bit Set")
        Me.EventLogMessages.Add(&HC75B, "Log - Heater Magnet Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC74C, "Log - Heater Magnet Logged C Bit Set")
        Me.EventLogMessages.Add(&HC75C, "Log - Heater Magnet Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC74D, "Log - Heater Magnet Logged D Bit Set")
        Me.EventLogMessages.Add(&HC75D, "Log - Heater Magnet Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC74E, "Log - Heater Magnet Logged E Bit Set")
        Me.EventLogMessages.Add(&HC75E, "Log - Heater Magnet Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC74F, "Log - Heater Magnet Logged F Bit Set")
        Me.EventLogMessages.Add(&HC75F, "Log - Heater Magnet Logged F Bit Cleared")






        Me.EventLogMessages.Add(&HC800, "Control - Gun Driver Not Ready Bit Set")
        Me.EventLogMessages.Add(&HC808, "Control - Gun Driver Not Ready Bit Cleared")
        Me.EventLogMessages.Add(&HC801, "Control - Gun Driver Not Configured Bit Set")
        Me.EventLogMessages.Add(&HC809, "Control - Gun Driver Not Configured Bit Cleared")
        Me.EventLogMessages.Add(&HC802, "Control - Gun Driver Self Check Error Bit Set")
        Me.EventLogMessages.Add(&HC80A, "Control - Gun Driver Self Check Error Bit Cleared")
        Me.EventLogMessages.Add(&HC803, "Control - Gun Driver Control 3 Bit Set")
        Me.EventLogMessages.Add(&HC80B, "Control - Gun Driver Control 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC804, "Control - Gun Driver Control 4 Bit Set")
        Me.EventLogMessages.Add(&HC80C, "Control - Gun Driver Control 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC805, "Control - Gun Driver Control 5 Bit Set")
        Me.EventLogMessages.Add(&HC80D, "Control - Gun Driver Control 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC806, "Control - Gun Driver Control 6 Bit Set")
        Me.EventLogMessages.Add(&HC80E, "Control - Gun Driver Control 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC807, "Control - Gun Driver Control 7 Bit Set")
        Me.EventLogMessages.Add(&HC80F, "Control - Gun Driver Control 7 Bit Cleared")

        Me.EventLogMessages.Add(&HC810, "Notice - Gun Driver Notice 0")
        Me.EventLogMessages.Add(&HC811, "Notice - Gun Driver Notice 1")
        Me.EventLogMessages.Add(&HC812, "Notice - Gun Driver Notice 2")
        Me.EventLogMessages.Add(&HC813, "Notice - Gun Driver Notice 3")
        Me.EventLogMessages.Add(&HC814, "Notice - Gun Driver Notice 4")
        Me.EventLogMessages.Add(&HC815, "Notice - Gun Driver Notice 5")
        Me.EventLogMessages.Add(&HC816, "Notice - Gun Driver Notice 6")
        Me.EventLogMessages.Add(&HC817, "Notice - Gun Driver Notice 7")

        Me.EventLogMessages.Add(&HC820, "Fault - Gun Driver Fault 0 Bit Set")
        Me.EventLogMessages.Add(&HC830, "Fault - Gun Driver Fault 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC821, "Fault - Gun Driver Fault 1 Bit Set")
        Me.EventLogMessages.Add(&HC831, "Fault - Gun Driver Fault 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC822, "Fault - Gun Driver Fault 2 Bit Set")
        Me.EventLogMessages.Add(&HC832, "Fault - Gun Driver Fault 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC823, "Fault - Gun Driver Fault 3 Bit Set")
        Me.EventLogMessages.Add(&HC833, "Fault - Gun Driver Fault 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC824, "Fault - Gun Driver Fault 4 Bit Set")
        Me.EventLogMessages.Add(&HC834, "Fault - Gun Driver Fault 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC825, "Fault - Gun Driver Fault 5 Bit Set")
        Me.EventLogMessages.Add(&HC835, "Fault - Gun Driver Fault 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC826, "Fault - Gun Driver Fault 6 Bit Set")
        Me.EventLogMessages.Add(&HC836, "Fault - Gun Driver Fault 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC827, "Fault - Gun Driver Fault 7 Bit Set")
        Me.EventLogMessages.Add(&HC837, "Fault - Gun Driver Fault 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC828, "Fault - Gun Driver Fault 8 Bit Set")
        Me.EventLogMessages.Add(&HC838, "Fault - Gun Driver Fault 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC829, "Fault - Gun Driver Fault 9 Bit Set")
        Me.EventLogMessages.Add(&HC839, "Fault - Gun Driver Fault 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC82A, "Fault - Gun Driver Fault A Bit Set")
        Me.EventLogMessages.Add(&HC83A, "Fault - Gun Driver Fault A Bit Cleared")
        Me.EventLogMessages.Add(&HC82B, "Fault - Gun Driver Fault B Bit Set")
        Me.EventLogMessages.Add(&HC83B, "Fault - Gun Driver Fault B Bit Cleared")
        Me.EventLogMessages.Add(&HC82C, "Fault - Gun Driver Fault C Bit Set")
        Me.EventLogMessages.Add(&HC83C, "Fault - Gun Driver Fault C Bit Cleared")
        Me.EventLogMessages.Add(&HC82D, "Fault - Gun Driver Fault D Bit Set")
        Me.EventLogMessages.Add(&HC83D, "Fault - Gun Driver Fault D Bit Cleared")
        Me.EventLogMessages.Add(&HC82E, "Fault - Gun Driver Fault E Bit Set")
        Me.EventLogMessages.Add(&HC83E, "Fault - Gun Driver Fault E Bit Cleared")
        Me.EventLogMessages.Add(&HC82F, "Fault - Gun Driver Fault F Bit Set")
        Me.EventLogMessages.Add(&HC83F, "Fault - Gun Driver Fault F Bit Cleared")

        Me.EventLogMessages.Add(&HC840, "Log - Gun Driver Logged 0 Bit Set")
        Me.EventLogMessages.Add(&HC850, "Log - Gun Driver Logged 0 Bit Cleared")
        Me.EventLogMessages.Add(&HC841, "Log - Gun Driver Logged 1 Bit Set")
        Me.EventLogMessages.Add(&HC851, "Log - Gun Driver Logged 1 Bit Cleared")
        Me.EventLogMessages.Add(&HC842, "Log - Gun Driver Logged 2 Bit Set")
        Me.EventLogMessages.Add(&HC852, "Log - Gun Driver Logged 2 Bit Cleared")
        Me.EventLogMessages.Add(&HC843, "Log - Gun Driver Logged 3 Bit Set")
        Me.EventLogMessages.Add(&HC853, "Log - Gun Driver Logged 3 Bit Cleared")
        Me.EventLogMessages.Add(&HC844, "Log - Gun Driver Logged 4 Bit Set")
        Me.EventLogMessages.Add(&HC854, "Log - Gun Driver Logged 4 Bit Cleared")
        Me.EventLogMessages.Add(&HC845, "Log - Gun Driver Logged 5 Bit Set")
        Me.EventLogMessages.Add(&HC855, "Log - Gun Driver Logged 5 Bit Cleared")
        Me.EventLogMessages.Add(&HC846, "Log - Gun Driver Logged 6 Bit Set")
        Me.EventLogMessages.Add(&HC856, "Log - Gun Driver Logged 6 Bit Cleared")
        Me.EventLogMessages.Add(&HC847, "Log - Gun Driver Logged 7 Bit Set")
        Me.EventLogMessages.Add(&HC857, "Log - Gun Driver Logged 7 Bit Cleared")
        Me.EventLogMessages.Add(&HC848, "Log - Gun Driver Logged 8 Bit Set")
        Me.EventLogMessages.Add(&HC858, "Log - Gun Driver Logged 8 Bit Cleared")
        Me.EventLogMessages.Add(&HC849, "Log - Gun Driver Logged 9 Bit Set")
        Me.EventLogMessages.Add(&HC859, "Log - Gun Driver Logged 9 Bit Cleared")
        Me.EventLogMessages.Add(&HC84A, "Log - Gun Driver Logged A Bit Set")
        Me.EventLogMessages.Add(&HC85A, "Log - Gun Driver Logged A Bit Cleared")
        Me.EventLogMessages.Add(&HC84B, "Log - Gun Driver Logged B Bit Set")
        Me.EventLogMessages.Add(&HC85B, "Log - Gun Driver Logged B Bit Cleared")
        Me.EventLogMessages.Add(&HC84C, "Log - Gun Driver Logged C Bit Set")
        Me.EventLogMessages.Add(&HC85C, "Log - Gun Driver Logged C Bit Cleared")
        Me.EventLogMessages.Add(&HC84D, "Log - Gun Driver Logged D Bit Set")
        Me.EventLogMessages.Add(&HC85D, "Log - Gun Driver Logged D Bit Cleared")
        Me.EventLogMessages.Add(&HC84E, "Log - Gun Driver Logged E Bit Set")
        Me.EventLogMessages.Add(&HC85E, "Log - Gun Driver Logged E Bit Cleared")
        Me.EventLogMessages.Add(&HC84F, "Log - Gun Driver Logged F Bit Set")
        Me.EventLogMessages.Add(&HC85F, "Log - Gun Driver Logged F Bit Cleared")

    End Sub






End Class
