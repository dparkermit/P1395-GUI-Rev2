﻿Public Class frmMain

    Public Const REGISTER_NONE As UInt16 = &HFF0


    Public Const REGISTER_HVPS_SET_POINT_DOSE_0 As UInt16 = &H400
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_0 As UInt16 = &H401
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_0 As UInt16 = &H402
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_0 As UInt16 = &H403
    Public Const REGISTER_PULSE_SYNC_SPARE_TRIG_DOSE_0 As UInt16 = &H404
    Public Const REGISTER_PULSE_SYNC_AFC_TRIGGER_DOSE_0 As UInt16 = &H405
    Public Const REGISTER_PULSE_SYNC_GRID_START_MIN_DOSE_0 As UInt16 = &H406
    Public Const REGISTER_PULSE_SYNC_GRID_START_MAX_DOSE_0 As UInt16 = &H407
    Public Const REGISTER_PULSE_SYNC_GRID_STOP_MIN_DOSE_0 As UInt16 = &H408
    Public Const REGISTER_PULSE_SYNC_GRID_STOP_MAX_DOSE_0 As UInt16 = &H409
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_0 As UInt16 = &H40A
    Public Const REGISTER_PULSE_SYNC_PRF_DOSE_0 As UInt16 = &H40B





    Public Const REGISTER_HVPS_SET_POINT_DOSE_1 As UInt16 = &H410
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_1 As UInt16 = &H411
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_1 As UInt16 = &H412
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_1 As UInt16 = &H413
    Public Const REGISTER_PULSE_SYNC_SPARE_TRIG_DOSE_1 As UInt16 = &H414
    Public Const REGISTER_PULSE_SYNC_AFC_TRIGGER_DOSE_1 As UInt16 = &H415
    Public Const REGISTER_PULSE_SYNC_GRID_START_MIN_DOSE_1 As UInt16 = &H416
    Public Const REGISTER_PULSE_SYNC_GRID_START_MAX_DOSE_1 As UInt16 = &H417
    Public Const REGISTER_PULSE_SYNC_GRID_STOP_MIN_DOSE_1 As UInt16 = &H418
    Public Const REGISTER_PULSE_SYNC_GRID_STOP_MAX_DOSE_1 As UInt16 = &H419
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_1 As UInt16 = &H41A
    Public Const REGISTER_PULSE_SYNC_PRF_DOSE_1 As UInt16 = &H41B

    Public Const REGISTER_MAGNETRON_HEATER_CURRENT_DOSE_ALL As UInt16 = &H500
    Public Const REGISTER_GUN_DRIVER_HEATER_VOLTAGE_DOSE_ALL As UInt16 = &H501
    Public Const REGISTER_PULSE_SYNC_HVPS_TRIGGER_START_DOSE_ALL As UInt16 = &H502
    Public Const REGISTER_PULSE_SYNC_HVPS_TRIGGER_STOP_DOSE_ALL As UInt16 = &H503
    Public Const REGISTER_PULSE_SYNC_PFN_TRIGGER_DOSE_ALL As UInt16 = &H504
    Public Const REGISTER_PULSE_SYNC_MAGNETRON_AND_TARGET_CURRENT_TRIGGER_START_DOSE_ALL As UInt16 = &H505
    Public Const REGISTER_PULSE_SYNC_MAGNETRON_AND_TARGET_CURRENT_TRIGGER_STOP_DOSE_ALL As UInt16 = &H506
    Public Const REGISTER_X_RAY_ON_TIME_DOSE_ALL As UInt16 = &H507
    Public Const REGISTER_GUN_BIAS_VOLTAGE_DOSE_ALL As UInt16 = &H508
    Public Const REGISTER_AFC_AFT_CONTROL_VOLTAGE_DOSE_ALL As UInt16 = &H509

    Public Const REGISTER_CMD_ECB_RESET_FAULTS As UInt16 = &H1000
    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES As UInt16 = &H1001
    Public Const REGISTER_SET_ACCESS_MODE_DEFAULT As UInt16 = &H1002
    Public Const REGISTER_SET_ACCESS_MODE_SERVICE As UInt16 = &H1003
    Public Const REGISTER_SET_ACCESS_MODE_ETM As UInt16 = &H1004
    Public Const REGISTER_CLEAR_EEPROM_WRITE_STATUS As UInt16 = &H1005

    Public Const REGISTER_CMD_AFC_SELECT_AFC_MODE As UInt16 = &H1100
    Public Const REGISTER_CMD_AFC_SELECT_MANUAL_MODE As UInt16 = &H1101
    Public Const REGISTER_CMD_AFC_MANUAL_TARGET_POSITION As UInt16 = &H1102
    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT As UInt16 = &H1103
    Public Const REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE As UInt16 = &H1104
    Public Const REGISTER_SYSTEM_SET_TIME As UInt16 = &H1105
    Public Const REGISTER_SYSTEM_ENABLE_HIGH_SPEED_LOGGING As UInt16 = &H1106
    Public Const REGISTER_SYSTEM_DISABLE_HIGH_SPEED_LOGGING As UInt16 = &H1107
    Public Const REGISTER_SYSTEM_LOAD_FACTORY_DEFAULTS_AND_REBOOT As UInt16 = &H1108
    Public Const REGISTER_SYSTEM_SAVE_CURRENT_SETTINGS_TO_CUSTOMER_SAVE As UInt16 = &H1109
    Public Const REGISTER_SYSTEM_LOAD_CUSTOMER_SETTINGS_SAVE_AND_REBOOT As UInt16 = &H110A
    Public Const REGISTER_REMOTE_IP_ADDRESS As UInt16 = &H110B
    Public Const REGISTER_IP_ADDRESS As UInt16 = &H110C



    Public Const REGISTER_DEBUG_TOGGLE_RESET_DEBUG As UInt16 = &H1200
    Public Const REGISTER_DEBUG_RESET_MCU As UInt16 = &H1201
    Public Const REGISTER_ECB_SYSTEM_SERIAL_NUMBER As UInt16 = &H1202
    Public Const REGISTER_DEBUG_GUN_DRIVER_RESET_FPGA As UInt16 = &H1203
    Public Const REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT As UInt16 = &H1204
    Public Const REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON As UInt16 = &H1205
    Public Const REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT As UInt16 = &H1206
    Public Const REGISTER_ETM_SET_REVISION_AND_SERIAL_NUMBER As UInt16 = &H1207
    Public Const REGISTER_ETM_SAVE_CURRENT_SETTINGS_TO_FACTORY_DEFAULT As UInt16 = &H1208

    Public Const YEAR_MULT As UInt32 = 35942400
    Public Const MONTH_MULT As UInt32 = 2764800
    Public Const DAY_MULT As UInt32 = 86400
    Public Const HOUR_MULT As UInt32 = 3600
    Public Const MIN_MULT As UInt32 = 60


    Public Class ButtonParameters
        Public max_value As UInt16
        Public min_value As UInt16
        Public scale As Double
        Public offset As UInt16
        Public button_name As String
        Public button_index As UInt16
        Public enabled As Boolean
        Public button_only As Boolean
    End Class



    Public inputbutton1 As New ButtonParameters
    Public inputbutton2 As New ButtonParameters
    Public inputbutton3 As New ButtonParameters
    Public inputbutton4 As New ButtonParameters
    Public inputbutton5 As New ButtonParameters


    Public EEProm_index As UInt16

    Public command_count As UInt16

    Public board_index As Byte

    Public selected_board_index As UInt16

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Application.DoEvents()


            '     TextBoxIPAddress.Text = ServerSettings.txtIPAddr.Text
            '     ModBusPort = 502      'Modbus = 502 , Explicit Ethernet/IP = 44818 (TCP) , Implicit Ethernet/IP = 2222 (UDP)
            TimerUpdate.Enabled = True


        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormMainLoad  " + ex.ToString)
        End Try


        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxComPorts.Items.Add(sp)
        Next



        ServerSettings.OpenEventLogFile()
        ServerSettings.event_log_file.WriteLine("GUI Started at " & Format(DateTime.UtcNow, "yyyy/MM/dd HH:mm:ss"))
        ServerSettings.CloseEventLogFile()


        inputbutton1.button_name = "loading"
        inputbutton2.button_name = "loading"
        inputbutton3.button_name = "loading"
        inputbutton4.button_name = "loading"
        inputbutton5.button_name = "loading"

        Me.BackColor = Color.LightCoral
        Splitter1.BackColor = Color.Coral

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version not Available in Debug Mode"
        End If




        


        ButtonStartLog.Visible = False
        ButtonStopLog.Visible = False

        ' Hide all of the advanced controls
        LabelCanCXECReg.Visible = False
        LabelCanErrorFlagCount.Visible = False
        LabelCanTX1Count.Visible = False
        LabelCanTX2Count.Visible = False
        LabelCanRX0Filt0Count.Visible = False
        LabelCanRX0Filt1Count.Visible = False
        LabelCanRX1Filt2Count.Visible = False
        LabelCanISREnteredCount.Visible = False
        LabelCanUnknownIdentifierCount.Visible = False
        LabelCanInvalidIndexCount.Visible = False
        LabelCanAddressErrorCount.Visible = False
        LabelCanTX0Count.Visible = False
        LabelCanTXBufOverflowCount.Visible = False
        LabelCanRXBufferOverflowCount.Visible = False
        LabelCAnDataLogRXBufferOVerflowCount.Visible = False
        LabelCanTimeoutCount.Visible = False
        CheckBoxControlBit0.Visible = False
        CheckBoxControlBit1.Visible = False
        CheckBoxControlBit2.Visible = False
        CheckBoxControlBit3.Visible = False
        CheckBoxControlBit4.Visible = False
        CheckBoxControlBit5.Visible = False
        CheckBoxControlBit6.Visible = False
        CheckBoxControlBit7.Visible = False
        LabelErrorI2CBusCount.Visible = False
        LabelErrorResetCount.Visible = False
        LabelErrorScaleCount.Visible = False
        LabelErrorSelfTestResultRegister.Visible = False
        LabelErrorSPIBusCount.Visible = False
        LabelErrorReserved0.Visible = False
        LabelErrorReserved1.Visible = False
        LabelRCON.Visible = False
        LabelDebug0.Visible = False
        LabelDebug1.Visible = False
        LabelDebug2.Visible = False
        LabelDebug3.Visible = False
        LabelDebug4.Visible = False
        LabelDebug5.Visible = False
        LabelDebug6.Visible = False
        LabelDebug7.Visible = False
        LabelDebug8.Visible = False
        LabelDebug9.Visible = False
        LabelDebugA.Visible = False
        LabelDebugB.Visible = False
        LabelDebugC.Visible = False
        LabelDebugD.Visible = False
        LabelDebugE.Visible = False
        LabelDebugF.Visible = False
        LabelValueDebug0.Visible = False
        LabelValueDebug1.Visible = False
        LabelValueDebug2.Visible = False
        LabelValueDebug3.Visible = False
        LabelValueDebug4.Visible = False
        LabelValueDebug5.Visible = False
        LabelValueDebug6.Visible = False
        LabelValueDebug7.Visible = False
        LabelValueDebug8.Visible = False
        LabelValueDebug9.Visible = False
        LabelValueDebugA.Visible = False
        LabelValueDebugB.Visible = False
        LabelValueDebugC.Visible = False
        LabelValueDebugD.Visible = False
        LabelValueDebugE.Visible = False
        LabelValueDebugF.Visible = False
       

        LabelComputerTime.Visible = False
        LabelSyncMessageCntrlBits.Visible = False

        ButtonToggleResetDebug.Visible = False
        CheckBoxSyncBitF.Visible = False
        ButtonSetTime.Visible = False

        ButtonReloadECBDefaults.Visible = False
        ButtonZeroOnTime.Visible = False
        ButtonZeroPulseCounters.Visible = False
        Me.Size = New System.Drawing.Size(1200, 520)

    End Sub

    Private Sub frmMain_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        ServerSettings.CloseEventLogFile()
    End Sub


    Private Sub ComboBoxComPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComPorts.SelectedIndexChanged
        Try
            If SerialPortETM.IsOpen Then
                SerialPortETM.Close()
            End If
        Catch ex As Exception

        End Try

        Try
            SerialPortETM.PortName = ComboBoxComPorts.SelectedItem.ToString
            SerialPortETM.ReadTimeout = 10
            SerialPortETM.BaudRate = 113000
            SerialPortETM.Open()
        Catch ex As Exception
            MsgBox("Serial Port Failed to Open")
        End Try

    End Sub


    Dim SerialCommandTransmitBuffer(9) As Byte
    Dim SerialCommandReceiveBuffer(9) As Byte

    Public Function SendAndValidateWatchdog() As Boolean
        Dim valid_return As Boolean = False
        Dim CheckSum As UInt16 = 0


        SerialCommandTransmitBuffer(0) = &HF1
        SerialCommandTransmitBuffer(1) = &HF2
        SerialCommandTransmitBuffer(2) = &HF3
        SerialCommandTransmitBuffer(3) = 0
        SerialCommandTransmitBuffer(4) = 0
        SerialCommandTransmitBuffer(5) = &HF4
        SerialCommandTransmitBuffer(6) = &H1E
        SerialCommandTransmitBuffer(7) = &H37

        Try
            SerialPortETM.Write(SerialCommandTransmitBuffer, 0, 8)
        Catch ex As Exception
            LabelWatchDogResponse.Text = "WD ERROR"
            Return False
        End Try

        Try
            SerialCommandReceiveBuffer(0) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(1) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(2) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(3) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(4) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(5) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(6) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(7) = SerialPortETM.ReadByte
            LabelWatchDogResponse.Text = "WD Recieved"

        Catch ex As Exception
            LabelWatchDogResponse.Text = "WD ERROR"
            Return False
        End Try

        LabelWatchDogResponse.Text = SerialCommandReceiveBuffer(4) + SerialCommandReceiveBuffer(3) * 256

#If (0) Then
         Try

            If SerialCommandReceiveBuffer(0) = &HF1 Then
                If SerialCommandReceiveBuffer(1) = &HF2 Then
                    If SerialCommandReceiveBuffer(2) = &HF3 Then
                        If CheckCRC() = True Then
                            valid_command = True
                            LabelComMsg.Text = "Message Sent/Received"
                            'A valid return was recieved.  Check what the responce was
                            If SerialCommandReceiveBuffer(3) <> SerialCommandTransmitBuffer(3) Then
                                'The pic was not able to process the command
                                If SerialCommandReceiveBuffer(3) = &H1 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Unknown Command"
                                ElseIf SerialCommandReceiveBuffer(3) = &H22 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Program Value out of Valid Range"
                                ElseIf SerialCommandReceiveBuffer(3) = &H23 Then
                                    LabelComMsg.Text = "ETM Controller Responds - EEPROM ERROR - Unable to set value"
                                Else
                                    LabelComMsg.Text = "ETM Controller Responce Error - " & SerialCommandReceiveBuffer(3)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If valid_command <> True Then
                LabelComMsg.Text = "Serial Port return data was not valid"
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Error processing Serial Port data"
            ComError = True
            Return 0
        End Try
        ReturnData = SerialCommandReceiveBuffer(4) * 256 + SerialCommandReceiveBuffer(5)
#End If



        Return True
    End Function




    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick
        Dim ivalue As Integer
        Static connected As Boolean = False
        Static admin_param_checked As Boolean = False

        TimerUpdate.Enabled = False
        ServerSettings.board_to_monitor = CByte(board_index)

        ivalue = ServerSettings.get_modbus_status()
        If (ivalue <= 2) Then
            connected = False
            Me.Text = "A36507 Test GUI(Linac Disconnected)"
            Me.BackColor = Color.LightCoral
            Splitter1.BackColor = Color.Coral
        Else
            connected = True
            ServerSettings.event_log_enabled = True
            Me.Text = "A36507 Test GUI"
            Splitter1.BackColor = Color.LightSteelBlue


            ' ------------------------------------------------------------------------------------------------------------'
            ' Display System Data in the left pane
            DisplayLeftPane()

            ' ------------------------------------------------------------------------------------------------------------'
            ' UDisplay the board specific data and buttons in the right plane
            DisplayBoardCommonElements(board_index)
            DisplayBoardSpecificData(board_index)
            DisplayDebugData()

        End If ' connected

        TimerUpdate.Enabled = True

    End Sub


    Private Sub DisplayBoardCommonElements(ByVal selected_baord As Byte)
        'Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_rev_ascii) 
        LabelAgileInfo.Text = "A" & ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_number & "-" &
            Format(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_dash, "000") & "  Rev-" &
            Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_rev_ascii) & "  SN-" &
            ServerSettings.ETMEthernetBoardLoggingData(board_index).serial_number 'Dparker need to add in the first Char
        LabelFirmwareVerssion.Text = "Firmware Version " &
            ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_agile_rev & "." &
            ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch & "." &
            ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch_rev

        Dim test As UInt16 = 1

        Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
        Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).fault_bits
        Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).logged_bits

        CheckBoxControlBit0.Checked = control_bits And &H1
        CheckBoxControlBit1.Checked = control_bits And &H2
        CheckBoxControlBit2.Checked = control_bits And &H4
        CheckBoxControlBit3.Checked = control_bits And &H8
        CheckBoxControlBit4.Checked = control_bits And &H10
        CheckBoxControlBit5.Checked = control_bits And &H20
        CheckBoxControlBit6.Checked = control_bits And &H40
        CheckBoxControlBit7.Checked = control_bits And &H80


        CheckBoxFaultBit0.Checked = fault_bits And &H1
        CheckBoxFaultBit1.Checked = fault_bits And &H2
        CheckBoxFaultBit2.Checked = fault_bits And &H4
        CheckBoxFaultBit3.Checked = fault_bits And &H8
        CheckBoxFaultBit4.Checked = fault_bits And &H10
        CheckBoxFaultBit5.Checked = fault_bits And &H20
        CheckBoxFaultBit6.Checked = fault_bits And &H40
        CheckBoxFaultBit7.Checked = fault_bits And &H80
        CheckBoxFaultBit8.Checked = fault_bits And &H100
        CheckBoxFaultBit9.Checked = fault_bits And &H200
        CheckBoxFaultBitA.Checked = fault_bits And &H400
        CheckBoxFaultBitB.Checked = fault_bits And &H800
        CheckBoxFaultBitC.Checked = fault_bits And &H1000
        CheckBoxFaultBitD.Checked = fault_bits And &H2000
        CheckBoxFaultBitE.Checked = fault_bits And &H4000
        CheckBoxFaultBitF.Checked = fault_bits And &H8000

        CheckBoxLoggedBit0.Checked = logged_bits And &H1
        CheckBoxLoggedBit1.Checked = logged_bits And &H2
        CheckBoxLoggedBit2.Checked = logged_bits And &H4
        CheckBoxLoggedBit3.Checked = logged_bits And &H8
        CheckBoxLoggedBit4.Checked = logged_bits And &H10
        CheckBoxLoggedBit5.Checked = logged_bits And &H20
        CheckBoxLoggedBit6.Checked = logged_bits And &H40
        CheckBoxLoggedBit7.Checked = logged_bits And &H80
        CheckBoxLoggedBit8.Checked = logged_bits And &H100
        CheckBoxLoggedBit9.Checked = logged_bits And &H200
        CheckBoxLoggedBitA.Checked = logged_bits And &H400
        CheckBoxLoggedBitB.Checked = logged_bits And &H800
        CheckBoxLoggedBitC.Checked = logged_bits And &H1000
        CheckBoxLoggedBitD.Checked = logged_bits And &H2000
        CheckBoxLoggedBitE.Checked = logged_bits And &H4000
        CheckBoxLoggedBitF.Checked = logged_bits And &H8000

    End Sub

    Private Sub DisplayBoardSpecificData(ByVal selected_baord As Byte)

        UpdateButtons()


        Dim selected_board_connected As Boolean = False

        If (selected_baord = MODBUS_COMMANDS.MODBUS_WR_ETHERNET) Then

            selected_board_connected = True

            CheckBoxFaultBit0.Text = "X-Ray Logic"
            CheckBoxFaultBit1.Text = "Drive Up Flt"
            CheckBoxFaultBit2.Text = "HV On Flt"
            CheckBoxFaultBit3.Text = "EEPROM"
            CheckBoxFaultBit4.Text = "Mag Ovr Pwr"
            CheckBoxFaultBit5.Text = "Watchdog"
            CheckBoxFaultBit6.Visible = False
            CheckBoxFaultBit7.Visible = False
            CheckBoxFaultBit8.Text = "HV Lambda"
            CheckBoxFaultBit9.Text = "Ion Pump"
            CheckBoxFaultBitA.Text = "AFC"
            CheckBoxFaultBitB.Text = "Cooling"
            CheckBoxFaultBitC.Text = "Htr/Mag"
            CheckBoxFaultBitD.Text = "Gun Drv"
            CheckBoxFaultBitE.Text = "I pulse"
            CheckBoxFaultBitF.Text = "Pulse Sync"


            CheckBoxLoggedBit0.Text = "Per Loaded"
            CheckBoxLoggedBit1.Text = "Drive up Timeout"
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False


            Dim thyratron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(4)
            Dim magnetron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(5)
            Dim gun_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(6)


            LabelValue1.Text = "Sec Powered = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(9) * 2 ^ 16 +
                                                         ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(8), "###,###,###,##0")
            LabelValue2.Text = "Sec HV On = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(11) * 2 ^ 16 +
                                                       ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(10), "###,###,###,##0")
            LabelValue3.Text = "Sec Xray On = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(13) * 2 ^ 16 +
                                                         ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(12), "###,###,###,##0")
            LabelValue4.Text = "Magnetron Pwr = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(14) / 1000, "0.000") & " kW"
            LabelValue5.Text = "Thyratron Warmup = " & Math.Truncate(thyratron_warmup / 60) & ":" & Format((thyratron_warmup Mod 60), "00")
            LabelValue6.Text = "Magnetron Warmup = " & Math.Truncate(magnetron_warmup / 60) & ":" & Format((magnetron_warmup Mod 60), "00")
            LabelValue7.Text = "Gun Driver Warmup = " & Math.Truncate(gun_warmup / 60) & ":" & Format((gun_warmup Mod 60), "00")
            LabelValue8.Text = "X Ray Time Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(21) * 2 ^ 16 +
                                                         ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(20), "###,###,###,##0")
            LabelValue9.Text = "X Ray Run Time = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(23) * 2 ^ 16 +
                                                         ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(22), "###,###,###,##0")
            LabelValue10.Text = ""
            LabelValue11.Text = ""
            LabelValue12.Text = ""
            LabelValue13.Text = "Power Cycles = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).ecb_local_data(1)
            LabelValue14.Text = "Power Cycles FLT = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).ecb_local_data(0)
            LabelValue15.Text = "Personality = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15)


            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Run Time"
            inputbutton1.max_value = 60000
            inputbutton1.min_value = 0
            inputbutton1.scale = 1
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_NONE
            'inputbutton1.button_index = REGISTER_X_RAY_ON_RUN_TIME



            inputbutton2.enabled = False
            inputbutton3.enabled = False
            inputbutton4.enabled = False
            inputbutton5.enabled = False



        ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H10




            CheckBoxFaultBit0.Text = "Can FLT"
            CheckBoxFaultBit1.Text = "HV ON FLT"
            CheckBoxFaultBit2.Visible = False
            CheckBoxFaultBit3.Visible = False
            CheckBoxFaultBit4.Visible = False
            CheckBoxFaultBit5.Visible = False
            CheckBoxFaultBit6.Visible = False
            CheckBoxFaultBit7.Visible = False
            CheckBoxFaultBit8.Visible = False
            CheckBoxFaultBit9.Visible = False
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "Power OFF"
            CheckBoxLoggedBit1.Text = "HV OFF"
            CheckBoxLoggedBit2.Text = "Phase Loss"
            CheckBoxLoggedBit3.Text = "Over Temp"
            CheckBoxLoggedBit4.Text = "Interlock"
            CheckBoxLoggedBit5.Text = "Load FLT"
            CheckBoxLoggedBit6.Text = "Sum FLT"
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False



            LabelValue1.Text = "High Mode Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(2) / 1000, "0.000") & " kV"
            LabelValue2.Text = "Low Mode Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(1) / 1000, "0.000") & " kV"
            LabelValue3.Text = "EOC Error Count = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(7)
            LabelValue4.Text = "Vmon Pulse = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(0) / 1000, "0.000") & " kV"
            LabelValue5.Text = "Imon = "& ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(5) / 1000 & " A"
            LabelValue6.Text = ""
            LabelValue7.Text = ""
            LabelValue8.Text = ""
            LabelValue9.Text = "Vmon Avg = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(6) / 1000, "0.000") & " kV"
            LabelValue10.Text = ""
            LabelValue11.Text = ""
            LabelValue12.Text = ""
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""

            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set HV High"
            inputbutton1.max_value = 22000
            inputbutton1.min_value = 6000
            inputbutton1.scale = 1000
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_HVPS_SET_POINT_DOSE_0

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Set HV Low"
            inputbutton2.max_value = 22000
            inputbutton2.min_value = 6000
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_HVPS_SET_POINT_DOSE_1


            inputbutton3.enabled = False
            inputbutton4.enabled = False
            inputbutton5.enabled = False

        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H80

            CheckBoxFaultBit0.Text = "HTR OC ABS"
            CheckBoxFaultBit1.Text = "HTR OC REL"
            CheckBoxFaultBit2.Text = "HTR UC REL"
            CheckBoxFaultBit3.Text = "HTR UV REL"
            CheckBoxFaultBit4.Text = "MAG OC ABS"
            CheckBoxFaultBit5.Text = "MAG UC ABS"
            CheckBoxFaultBit6.Text = "MAG UV ABS"
            CheckBoxFaultBit7.Text = "TEMP SW"
            CheckBoxFaultBit8.Text = "COOLANT FLT"
            CheckBoxFaultBit9.Text = "CAN FLT"
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "MAG OK"
            CheckBoxLoggedBit1.Text = "HTR OK"
            CheckBoxLoggedBit2.Text = "HTR OV LATCH"
            CheckBoxLoggedBit3.Text = "RLY OPEN"
            CheckBoxLoggedBit4.Text = "HTR OC"
            CheckBoxLoggedBit5.Text = "OV TEMP"
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False


            LabelValue1.Text = "Magnet Set High = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(2) / 1000, ".000") & " A"
            LabelValue2.Text = "Magnet Set Low = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(3) / 1000, ".000") & " A"
            LabelValue3.Text = "Heater Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(0) / 1000, ".000") & " A"
            LabelValue4.Text = ""
            LabelValue5.Text = "Magnet Set Rdbck= " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(5) / 1000, ".000") & " A"
            LabelValue6.Text = "Mag Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(1) / 1000, ".000") & " A"
            LabelValue7.Text = "Mag Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(0) / 1000, ".000") & " V"
            LabelValue8.Text = ""
            LabelValue9.Text = "Heater Scaled Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(1) / 1000, ".000") & " A"
            LabelValue10.Text = "Heater Set Rdbck = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(7) / 1000, ".000") & " A"
            LabelValue11.Text = "Htr Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(3) / 1000, ".000") & " A"
            LabelValue12.Text = "Htr Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(2) / 1000, ".000") & " V"
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""

            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Magnet High"
            inputbutton1.max_value = 25000
            inputbutton1.min_value = 8000
            inputbutton1.scale = 1000
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_ELECTROMAGNET_CURRENT_DOSE_0

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Set Magnet Low"
            inputbutton2.max_value = 25000
            inputbutton2.min_value = 8000
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_ELECTROMAGNET_CURRENT_DOSE_1

            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "Set Heater"
            inputbutton3.max_value = 12000
            inputbutton3.min_value = 0
            inputbutton3.scale = 1000
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_MAGNETRON_HEATER_CURRENT_DOSE_ALL

            inputbutton4.enabled = False
            inputbutton5.enabled = False


        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H4

            CheckBoxFaultBit0.Text = "Can FLT"
            CheckBoxFaultBit1.Text = "Arc Slow"
            CheckBoxFaultBit2.Text = "Arc Fast"
            CheckBoxFaultBit3.Text = "Arc Cont"
            CheckBoxFaultBit4.Text = "False Trig"
            CheckBoxFaultBit5.Text = "Poor Pulse"
            CheckBoxFaultBit6.Visible = False
            CheckBoxFaultBit7.Visible = False
            CheckBoxFaultBit8.Visible = False
            CheckBoxFaultBit9.Visible = False
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "EEprom"
            CheckBoxLoggedBit1.Visible = False
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False

            LabelValue1.Text = "Pulses Today = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(4), "###,###,###,##0")
            LabelValue2.Text = "Arcs Today = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(12), "###,###,###,##0")
            LabelValue3.Text = "Pulse Total = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(11) * 2 ^ 48 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(10) * 2 ^ 32 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(8), "###,###,###,##0")
            LabelValue4.Text = "Arcs Total = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(7) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(6), "###,###,###,##0")
            LabelValue5.Text = "Imon High Energy = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(0) / 100, "0.00") & " A"
            LabelValue6.Text = "Imon Low Energy = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(2) / 100, "0.00") & " A"
            LabelValue7.Text = "Pulses OOR= " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(13), "###,###,###,##0")
            LabelValue8.Text = ""
            LabelValue9.Text = ""
            LabelValue10.Text = ""
            LabelValue11.Text = ""
            LabelValue12.Text = ""
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""

            inputbutton1.enabled = False
            inputbutton2.enabled = False
            inputbutton3.enabled = False
            inputbutton4.enabled = False
            inputbutton5.enabled = False



        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H2

            CheckBoxFaultBit0.Text = "Can Fault"
            CheckBoxFaultBit1.Text = "Ion Over Current"
            CheckBoxFaultBit2.Visible = False
            CheckBoxFaultBit3.Text = "Ion Under Voltage"
            CheckBoxFaultBit4.Text = "PS Fault"
            CheckBoxFaultBit5.Text = "Linac Guide Arc"
            CheckBoxFaultBit6.Text = "Mag Guide Arc"
            CheckBoxFaultBit7.Visible = False
            CheckBoxFaultBit8.Visible = False
            CheckBoxFaultBit9.Visible = False
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Visible = False
            CheckBoxLoggedBit1.Visible = False
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False



            LabelValue1.Text = "Ion Voltage = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(2) / 1000, "0.000") & " kV"
            LabelValue2.Text = "Ion Current = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) * 10 / 1000, "0.000") & " uA"
            LabelValue3.Text = ""
            LabelValue4.Text = ""
            LabelValue5.Text = ""
            LabelValue6.Text = ""
            LabelValue7.Text = ""
            LabelValue8.Text = ""
            LabelValue9.Text = ""
            LabelValue10.Text = ""
            LabelValue11.Text = ""
            LabelValue12.Text = ""
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""

            inputbutton1.enabled = False
            inputbutton2.enabled = False
            inputbutton3.enabled = False
            inputbutton4.enabled = False
            inputbutton5.enabled = False

        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_AFC) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H20

            Dim afc_manual_mode As Boolean = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).logged_bits And &H1

            CheckBoxFaultBit0.Text = "Can FLT"
            CheckBoxFaultBit1.Visible = False
            CheckBoxFaultBit2.Visible = False
            CheckBoxFaultBit3.Visible = False
            CheckBoxFaultBit4.Visible = False
            CheckBoxFaultBit5.Visible = False
            CheckBoxFaultBit6.Visible = False
            CheckBoxFaultBit7.Visible = False
            CheckBoxFaultBit8.Visible = False
            CheckBoxFaultBit9.Visible = False
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "Manual"
            CheckBoxLoggedBit1.Visible = False
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False



            Dim filtered_error As Long = CLng(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(4))

            If filtered_error > 2 ^ 15 Then
                filtered_error -= 2 ^ 15
                filtered_error = -filtered_error
            End If

            LabelValue1.Text = "Home Position = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(0)
            LabelValue2.Text = "AFT Ctrl V High = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(1) / 1000, "0.000") & " V"
            LabelValue3.Text = "AFT Ctrl V Low = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(2) / 1000, "0.000") & " V"
            LabelValue4.Text = ""
            LabelValue5.Text = "Readback Position = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(2)
            LabelValue6.Text = "Rback Home Pos = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(11)
            LabelValue7.Text = "Filtered Error = " & filtered_error
            LabelValue8.Text = "Previous A Sample = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(6)
            LabelValue9.Text = "Previous B Sample = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(5)
            LabelValue10.Text = "Rback AFT Ctrl V = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(8) / 1000, "0.000") & " V"
            LabelValue11.Text = ""
            LabelValue12.Text = ""
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""


            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Home Position"
            inputbutton1.max_value = 51200
            inputbutton1.min_value = 6400
            inputbutton1.scale = 1
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_AFC_HOME_POSITION_DOSE_0

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "AFT Control V High"
            inputbutton2.max_value = 10000
            inputbutton2.min_value = 1000
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_AFC_AFT_CONTROL_VOLTAGE_DOSE_ALL

            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "AFT Control V Low"
            inputbutton3.max_value = 10000
            inputbutton3.min_value = 1000
            inputbutton3.scale = 1000
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_AFC_AFT_CONTROL_VOLTAGE_DOSE_ALL


            If afc_manual_mode Then
                inputbutton4.enabled = True
            Else
                inputbutton4.enabled = False

            End If

            inputbutton4.button_only = False
            inputbutton4.button_name = "Manual Position"
            inputbutton4.max_value = 64000
            inputbutton4.min_value = 0
            inputbutton4.scale = 1
            inputbutton4.offset = 0
            inputbutton4.button_index = REGISTER_CMD_AFC_MANUAL_TARGET_POSITION

            If afc_manual_mode Then
                inputbutton5.button_name = "AFC Mode"
                inputbutton5.button_index = REGISTER_CMD_AFC_SELECT_AFC_MODE
            Else
                inputbutton5.button_name = "Manual Mode"
                inputbutton5.button_index = REGISTER_CMD_AFC_SELECT_MANUAL_MODE
            End If

            inputbutton5.enabled = True
            inputbutton5.button_only = True
            inputbutton5.max_value = 64000
            inputbutton5.min_value = 0
            inputbutton5.scale = 1
            inputbutton5.offset = 0




        ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H8

            CheckBoxFaultBit0.Text = "X-Ray Timing"
            CheckBoxFaultBit1.Text = "CAN ERROR"
            CheckBoxFaultBit2.Text = "RF Arc"
            CheckBoxFaultBit3.Text = "PFN Fan"
            CheckBoxFaultBit4.Visible = False
            CheckBoxFaultBit5.Text = "Panel Open"
            CheckBoxFaultBit6.Text = "Keylock Open"
            CheckBoxFaultBit7.Text = "Per Read"
            CheckBoxFaultBit8.Text = "Gun Flt"
            CheckBoxFaultBit9.Text = "Trigger"
            CheckBoxFaultBitA.Visible = False
            CheckBoxFaultBitB.Visible = False
            CheckBoxFaultBitC.Visible = False
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "Cust HV OFF"
            CheckBoxLoggedBit1.Text = "Cust X-Ray OFF"
            CheckBoxLoggedBit2.Text = "Low Override"
            CheckBoxLoggedBit3.Text = "High Override"
            CheckBoxLoggedBit4.Text = "Personality Read"
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Text = "Trigger FLT"
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False

           
            LabelValue1.Text = "Grid H = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(0) &
                ", " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(1)

            LabelValue2.Text = "Grid L = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(2) &
                 ", " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(3)

            LabelValue3.Text = "AFC Samp Delay = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(4) &
                 ", " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(5)


            LabelValue4.Text = "HVPS Trigger Delay = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(8)

            LabelValue5.Text = "PFN Trigger Delay = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(9)

            LabelValue6.Text = "Imon Trigger Delay = " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(10)


            LabelValue7.Text = "Grid Start H = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(0) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(0) / 256) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(1) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(1) / 256)


            LabelValue8.Text = "Grid Stop H = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(4) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(4) / 256) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(5) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(5) / 256)


            LabelValue9.Text = "Grid Start L = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(8) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(8) / 256) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(9) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(9) / 256)



            LabelValue10.Text = "Grid Stop L = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(12) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(12) / 256) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(13) And &HFF) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(13) / 256)


            LabelValue11.Text = "PFN Trigger Delay = " &
                Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(2) / 256) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(10) / 256)

            LabelValue12.Text = "Dose Samp Delay = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(2) And &HFF) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(10) And &HFF)

            LabelValue13.Text = "AFC Sample Delay = " &
                Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(6) / 256) &
                ", " & Math.Truncate(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(14) / 256)

            LabelValue14.Text = "Mag Samp Delay = " &
                (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(6) And &HFF) &
                ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(14) And &HFF)

            'LabelValue15.Text = "PRF Set= " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(3) / 10) &
            '  ", " & (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(11) / 10)

            'LabelValue7.Text = "Grid Start L = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) And &HFF)
            'LabelValue8.Text = "Grid Stop L = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) And &HFF)

            'LabelValue3.Text = "PFN Trigger Delay = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) / 256)
            'LabelValue4.Text = "AFC Sample Delay = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) / 256)
            ' LabelValue5.Text = "Mag Samp Delay = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) And &HFF)
            'LabelValue6.Text = ""


            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "GRID START L"
            inputbutton1.max_value = 255
            inputbutton1.min_value = 0
            inputbutton1.scale = 1
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_PULSE_SYNC_GRID_START_MAX_DOSE_1



            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "GRIS STOP L"
            inputbutton2.max_value = 255
            inputbutton2.min_value = 0
            inputbutton2.scale = 1
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_PULSE_SYNC_GRID_STOP_MAX_DOSE_1



            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "GRID START H"
            inputbutton3.max_value = 255
            inputbutton3.min_value = 0
            inputbutton3.scale = 1
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_PULSE_SYNC_GRID_START_MAX_DOSE_0

            inputbutton4.enabled = True
            inputbutton4.button_only = False
            inputbutton4.button_name = "GRID STOP H"
            inputbutton4.max_value = 255
            inputbutton4.min_value = 0
            inputbutton4.scale = 1
            inputbutton4.offset = 0
            inputbutton4.button_index = REGISTER_PULSE_SYNC_GRID_STOP_MAX_DOSE_0

            inputbutton5.enabled = True
            inputbutton5.button_only = False
            inputbutton5.button_name = "AFC TRIG H"
            inputbutton5.max_value = 255
            inputbutton5.min_value = 0
            inputbutton5.scale = 1
            inputbutton5.offset = 0
            inputbutton5.button_index = REGISTER_PULSE_SYNC_AFC_TRIGGER_DOSE_0


        ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H40

            CheckBoxFaultBit0.Text = "CAN Flt"
            CheckBoxFaultBit1.Text = "Magnetron Flow"
            CheckBoxFaultBit2.Text = "Linac FLow"
            CheckBoxFaultBit3.Text = "HV Tank FLow"
            CheckBoxFaultBit4.Text = "Flow 4"
            CheckBoxFaultBit5.Text = "Flow 5"
            CheckBoxFaultBit6.Text = "Flow 6"
            CheckBoxFaultBit7.Text = "Cabinet SW"
            CheckBoxFaultBit8.Text = "Coolant SW"
            CheckBoxFaultBit9.Text = "Cabient Ovr Temp"
            CheckBoxFaultBitA.Text = "Coolant Ovr Temp"
            CheckBoxFaultBitB.Text = "Thermistor 3 over temp"
            CheckBoxFaultBitC.Text = "SF6 Pressure"
            CheckBoxFaultBitD.Text = "SF6 SW"
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Text = "SF6 Relay Closed"
            CheckBoxLoggedBit1.Text = "Coolant Too Cold"
            CheckBoxLoggedBit2.Text = "SF6 To Low To Fill"
            CheckBoxLoggedBit3.Text = "SF6 Fill Required"
            CheckBoxLoggedBit4.Text = "No SF6 Pulses Available"
            CheckBoxLoggedBit5.Text = "SF6 Filling"
            CheckBoxLoggedBit6.Text = "Flow OK"
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False

            LabelValue1.Text = "Pulses Allowed = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(12)
            LabelValue2.Text = "Override Pulses = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(13)
            LabelValue3.Text = "Bottle Pulses = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(14) & " / " &
                ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).ecb_local_data(0)
            LabelValue4.Text = "Magnetron Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(0) / 1000, "0.000") & " LPM"
            LabelValue5.Text = "Linac Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(1) / 1000, "0.000") & " LPM"
            LabelValue6.Text = "HX Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(2) / 1000, "0.000") & " LPM"
            LabelValue7.Text = "HVPS Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(3) / 1000, "0.000") & " LPM"
            LabelValue8.Text = "Circulator Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(4) / 1000, "0.000") & " LPM"
            LabelValue9.Text = "Spare Flow = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(5) / 1000, "0.000") & " LPM"
            LabelValue10.Text = "SF6 Pressure = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(11) / 100, "00.00") & " PSI"
            LabelValue11.Text = "Coolant Temp = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(9) / 10 - 272 & " C"
            LabelValue12.Text = "Cabinent Temp = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(10) / 10 - 272 & " C"
            LabelValue13.Text = "Linac Temp = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(8) / 10 - 272 & " C"
            LabelValue14.Text = ""
            LabelValue15.Text = ""


            inputbutton1.enabled = True
            inputbutton1.button_only = True
            inputbutton1.button_name = "25 SF6 Pulses"
            inputbutton1.max_value = 255
            inputbutton1.min_value = 0
            inputbutton1.scale = 1
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Override Pulses"
            inputbutton2.max_value = 5
            inputbutton2.min_value = 0
            inputbutton2.scale = 1
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT

            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "Set Bottle Pulses"
            inputbutton3.max_value = 1000
            inputbutton3.min_value = 0
            inputbutton3.scale = 1
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE

            inputbutton4.enabled = False
            inputbutton5.enabled = False



        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H100

#Const THEA_MODULATOR = 0

#If THEA_MODULATOR Then



            CheckBoxFaultBit0.Text = "Can Fault"
            CheckBoxFaultBit1.Text = "Bias OV"
            CheckBoxFaultBit2.Text = "Bias UV"
            CheckBoxFaultBit3.Text = "Comm Flt"
            CheckBoxFaultBit4.Text = "Top 1 OV"
            CheckBoxFaultBit5.Text = "Top 1 UV"
            CheckBoxFaultBit6.Text = "Top 2 OV"
            CheckBoxFaultBit7.Text = "Top 2 UV"
            CheckBoxFaultBit8.Text = "HTR OV"
            CheckBoxFaultBit9.Text = "HTR UV"
            CheckBoxFaultBitA.Text = "HTR OC"
            CheckBoxFaultBitB.Text = "HTR UC"
            CheckBoxFaultBitC.Text = "HTR NR"
            CheckBoxFaultBitD.Visible = False
            CheckBoxFaultBitE.Visible = False
            CheckBoxFaultBitF.Visible = False

            CheckBoxLoggedBit0.Visible = False
            CheckBoxLoggedBit1.Visible = False
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False



            LabelValue1.Text = "Top 1 Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(0) / 100, ".00") & " V"
            LabelValue2.Text = "Top 2 Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(1) / 100, ".00") & " V"
            LabelValue3.Text = "Heater Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(2) / 1000, ".000") & " V"
            LabelValue4.Text = "Top 1 Set Rdbck= " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(3) / 100, ".00") & " V"
            LabelValue5.Text = "Top 1 Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(2) / 100, ".00") & " V"
            LabelValue6.Text = "Raw 1 Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(1) / 100, ".00") & " V"
            LabelValue7.Text = "Top 2 Set Rdbck= " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(7) / 100, ".00") & " V"
            LabelValue8.Text = "Top 2 Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(6) / 100, ".00") & " V"
            LabelValue9.Text = "Raw 2 Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(5) / 100, ".00") & " V"
            LabelValue10.Text = "Heater Set Rdbck = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(11) / 1000, ".000") & " V"
            LabelValue11.Text = "Heater Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(10) / 1000, ".000") & " V"
            LabelValue12.Text = "Heater 1 Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(9) / 1000, ".000") & " A"
            LabelValue13.Text = "Heater 2 Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(8) / 1000, ".000") & " A"
            LabelValue14.Text = "Bias Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(4) / 100, ".00") & " V"
            LabelValue15.Text = "Bias Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(0) / 100, ".00") & " V"

            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Top 1"
            inputbutton1.max_value = 20000
            inputbutton1.min_value = 0
            inputbutton1.scale = 100
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Set Top 2"
            inputbutton2.max_value = 20000
            inputbutton2.min_value = 0
            inputbutton2.scale = 100
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE

            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "Set Htr V"
            inputbutton3.max_value = 10000
            inputbutton3.min_value = 0
            inputbutton3.scale = 1000
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_GUN_DRIVER_HEATER_VOLTAGE


            inputbutton4.enabled = False
            inputbutton5.enabled = False
#Else

            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16) And &H100

            CheckBoxFaultBit0.Text = "FPGA Rev Flt"
            CheckBoxFaultBit1.Text = "HV Vmon OV REL"
            CheckBoxFaultBit2.Text = "HV Vmon UV REL"
            CheckBoxFaultBit3.Text = "HTR Vmon OV ABS"
            CheckBoxFaultBit4.Text = "HTR Vmon UV ABS"
            CheckBoxFaultBit5.Text = "HTR Imon OC ABS"
            CheckBoxFaultBit6.Text = "Top Vmon OV REL"
            CheckBoxFaultBit7.Text = "Top Vmon UV REL"
            CheckBoxFaultBit8.Text = "Bias Vmon OV/UV ABS"
            CheckBoxFaultBit9.Text = "ARC Fault"
            CheckBoxFaultBitA.Text = "Over Temp"
            CheckBoxFaultBitB.Text = "CAN Comm"
            CheckBoxFaultBitC.Text = "Grid Flt"
            CheckBoxFaultBitD.Text = "ADC Read Fail"
            CheckBoxFaultBitE.Text = "SPI Comm FLt"
            CheckBoxFaultBitF.Text = "Htr Startup Fail"

            CheckBoxLoggedBit0.Visible = False
            CheckBoxLoggedBit1.Visible = False
            CheckBoxLoggedBit2.Visible = False
            CheckBoxLoggedBit3.Visible = False
            CheckBoxLoggedBit4.Visible = False
            CheckBoxLoggedBit5.Visible = False
            CheckBoxLoggedBit6.Visible = False
            CheckBoxLoggedBit7.Visible = False
            CheckBoxLoggedBit8.Visible = False
            CheckBoxLoggedBit9.Visible = False
            CheckBoxLoggedBitA.Visible = False
            CheckBoxLoggedBitB.Visible = False
            CheckBoxLoggedBitC.Visible = False
            CheckBoxLoggedBitD.Visible = False
            CheckBoxLoggedBitE.Visible = False
            CheckBoxLoggedBitF.Visible = False


            LabelValue1.Text = "Ek Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(8)) * (-0.001), "0.00kV") 'ekset
            LabelValue2.Text = "If Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(9)) * (0.001), "0.00A") 'efset
            LabelValue3.Text = "Eg Set High = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(0)) * 0.01 - 80, "0.0V")  ' egset
            LabelValue4.Text = "Eg Set Low = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(1)) * 0.01 - 80, "0.0V")  ' egset
            LabelValue5.Text = "Ek = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(1)) * (-0.001), "0.00kV") ' GUN_DRIVER_EK_RD_CAL
            LabelValue6.Text = "Ikp = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(0)) * 0.1, "0.0mA") ' GUN_DRIVER_IKP_RD_CAL
            LabelValue7.Text = "Ef = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(7)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_RD_CAL
            LabelValue8.Text = "If = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(6)) * 0.001, "0.00A") 'GUN_DRIVER_IF_RD_CAL
            LabelValue9.Text = "Eg = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(3)) * 0.01 - 80, "0.0V") ' eg rd

            LabelValue10.Text = "Ec = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(12)) * -0.01, "0.0V") ' GUN_DRIVER_EC_RD_CAL
            'LabelValue10.Text = "Temp = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_DRIVER_TEMPERATURE)) * 0.01, "0.0C") 'GUN_DRIVER_TEMP_RD_CAL
            'LabelValue11.Text = ""
            LabelValue11.Text = "Ek SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(3)) * (-0.001), "0.00kV") 'GUN_DRIVER_EK_SET_CAL
            LabelValue12.Text = "Ef SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(2)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_SET_CAL
            LabelValue13.Text = "Eg SetRd = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(0)) * 0.01 - 80, "0.0V") 'GUN_DRIVER_EG_SET_CAL

            LabelValue14.Text = "Ana Flt = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(14) & _
                 ", state = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(13)

            If Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(15)) = 0 Then
                LabelValue15.Text = "Gun Driver Load: Linac Gun"
            ElseIf Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(15)) = 1 Then
                LabelValue15.Text = "Gun Driver Load: Resistive"
            Else
                LabelValue15.Text = "Gun Driver Load: Test Gun"
            End If

            'LabelValue15.Text = "FPGA ASDR = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(15).ToString("x")



            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Ek"
            inputbutton1.max_value = 20000
            inputbutton1.min_value = 6000
            inputbutton1.scale = -1000
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_0

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Set If"
            inputbutton2.max_value = 1600
            inputbutton2.min_value = 0
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_GUN_DRIVER_HEATER_VOLTAGE_DOSE_ALL

            inputbutton3.enabled = True
            inputbutton3.button_only = False
            inputbutton3.button_name = "Set Eg High"
            inputbutton3.max_value = 22000
            inputbutton3.min_value = 0
            inputbutton3.scale = 100
            inputbutton3.offset = 8000
            inputbutton3.button_index = REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_0


            inputbutton4.enabled = True
            inputbutton4.button_only = False
            inputbutton4.button_name = "Set Eg Low"
            inputbutton4.max_value = 22000
            inputbutton4.min_value = 0
            inputbutton4.scale = 100
            inputbutton4.offset = 8000
            inputbutton4.button_index = REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_1

            inputbutton5.enabled = False
#End If




        End If


        If selected_board_connected Then
            LabelBoardStatus.Text = ""
            Me.BackColor = SystemColors.Control
        Else
            LabelBoardStatus.Text = "NOT CONNECTED!!!"
            Me.BackColor = Color.LightCoral
        End If







#If (0) Then




            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
                If (ConnectedBoards And &H10) Then
                    LabelBoardStatus.Text = "NOT CONNECTED!!!"
                    bgcolor = Color.LightCoral
                End If

                CheckBoxStatusBit0.Text = "AT EOC"
                CheckBoxStatusBit1.Text = "HIGH MODE"
                CheckBoxStatusBit2.Text = "HV OFF"
                CheckBoxStatusBit3.Text = "STATE FLT"
                CheckBoxStatusBit4.Text = "PWR OFF"
                CheckBoxStatusBit5.Visible = False
                CheckBoxStatusBit6.Visible = False
                CheckBoxStatusBit7.Visible = False

                CheckBoxFaultBit0.Text = "SUM FLT"
                CheckBoxFaultBit1.Text = "Power OFF"
                CheckBoxFaultBit2.Text = "HV OFF"
                CheckBoxFaultBit3.Text = "Phase Loss"
                CheckBoxFaultBit4.Text = "Over Temp"
                CheckBoxFaultBit5.Text = "Interlock"
                CheckBoxFaultBit6.Text = "Load FLT"
                CheckBoxFaultBit7.Text = "PWR UP"
                CheckBoxFaultBit8.Text = "Can FLT"
                CheckBoxFaultBit9.Visible = False
                CheckBoxFaultBitA.Visible = False
                CheckBoxFaultBitB.Visible = False
                CheckBoxFaultBitC.Visible = False
                CheckBoxFaultBitD.Visible = False
                CheckBoxFaultBitE.Visible = False
                CheckBoxFaultBitF.Visible = False

                LabelDebug0.Text = "Debug 0 = "
                LabelDebug1.Text = "Debug 1 = "
                LabelDebug2.Text = "Debug 2 = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Debug 4 = "
                LabelDebug5.Text = "Debug 5 = "
                LabelDebug6.Text = "Debug 6 = "
                LabelDebug7.Text = "Debug 7 = "
                LabelDebug8.Text = "Debug 8 = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "


                LabelValue1.Text = "High Mode Set = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.ECB_HIGH_SET_POINT) / 1000, "0.000") & " kV"
                LabelValue2.Text = "Low Mode Set = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.ECB_LOW_SET_POINT) / 1000, "0.000") & " kV"
                LabelValue3.Text = "EOC Error Count = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.EOC_NOT_REACHED_COUNT)
                LabelValue4.Text = "Vmon = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_VMON) / 1000, "0.000") & " kV"
                LabelValue5.Text = "Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_IMON) / 1000 & " A"
                'LabelValue6.Text = "Lambda Temperature = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_BASE_PLATE_TEMP) / 100, ".0")
                'LabelValue7.Text = "High Mode Rdbck = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_HIGH_VPROG) / 1000, "0.000") & " kV"
                'LabelValue8.Text = "Low Mode Rdbck = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_LOW_VPROG) / 1000, "0.000") & " kV"
                LabelValue6.Text = ""
                LabelValue7.Text = ""
                LabelValue8.Text = ""
                LabelValue9.Text = "Vmon Pre-Pulse = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_PEAK_LAMBDA_VOLTAGE) / 1000, "0.000") & " kV"
                LabelValue10.Text = ""
                LabelValue11.Text = ""
                LabelValue12.Text = ""
                LabelValue13.Text = ""
                LabelValue14.Text = ""
                LabelValue15.Text = ""


                'inputbutton1.enabled = True
                'inputbutton1.button_only = False
                'inputbutton1.button_name = "Set High"
                'inputbutton1.max_value = 20000
                'inputbutton1.min_value = 5000
                'inputbutton1.scale = 1000
                'inputbutton1.offset = 0
                'inputbutton1.button_index = REGISTER_HIGH_ENERGY_SET_POINT


                'inputbutton2.enabled = True
                'inputbutton2.button_only = False
                'inputbutton2.button_name = "Set Low"
                'inputbutton2.max_value = 20000
                'inputbutton2.min_value = 5000
                'inputbutton2.scale = 1000
                'inputbutton2.offset = 0
                'inputbutton2.button_index = REGISTER_LOW_ENERGY_SET_POINT


                inputbutton1.enabled = True
                inputbutton1.button_only = False
                inputbutton1.button_name = "Set HV"
                inputbutton1.max_value = 17000
                inputbutton1.min_value = 6000
                inputbutton1.scale = 1000
                inputbutton1.offset = 0
                inputbutton1.button_index = REGISTER_SPECIAL_2_5_SET_HV_LAMBDA_VOLTAGE

                inputbutton2.enabled = False



                inputbutton3.enabled = False
                inputbutton4.enabled = False
                inputbutton5.enabled = False



            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) Then
                If (ConnectedBoards And &H8) Then
                    LabelBoardStatus.Text = "NOT CONNECTED!!!"
                    bgcolor = Color.LightCoral
                End If

                CheckBoxStatusBit0.Text = "Cust HV OFF"
                CheckBoxStatusBit1.Text = "Cust X-Ray OFF"
                CheckBoxStatusBit2.Visible = False
                CheckBoxStatusBit3.Visible = False
                CheckBoxStatusBit4.Text = "Over PRF"
                CheckBoxStatusBit5.Text = "Only Low"
                CheckBoxStatusBit6.Text = "Only High"
                CheckBoxStatusBit7.Visible = False

                CheckBoxFaultBit0.Text = "Panel Open"
                CheckBoxFaultBit1.Text = "Keylock"
                CheckBoxFaultBit2.Text = "X-Ray Timing"
                CheckBoxFaultBit3.Text = "Trigger ON"
                CheckBoxFaultBit4.Text = "X-Ray/No HV"
                CheckBoxFaultBit5.Text = "Sync Timeout"
                CheckBoxFaultBit6.Text = "PFN Fan"
                CheckBoxFaultBit7.Text = "RF Arc"
                CheckBoxFaultBit8.Visible = False
                CheckBoxFaultBit9.Visible = False
                CheckBoxFaultBitA.Visible = False
                CheckBoxFaultBitB.Visible = False
                CheckBoxFaultBitC.Visible = False
                CheckBoxFaultBitD.Visible = False
                CheckBoxFaultBitE.Visible = False
                CheckBoxFaultBitF.Visible = False

                LabelDebug0.Text = "Debug 0 = "
                LabelDebug1.Text = "Debug 1 = "
                LabelDebug2.Text = "Debug 2 = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Debug 4 = "
                LabelDebug5.Text = "Debug 5 = "
                LabelDebug6.Text = "Debug 6 = "
                LabelDebug7.Text = "Debug 7 = "
                LabelDebug8.Text = "Debug 8 = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "

                'LabelValue1.Text = "Grid Start H = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) / 256)
                'LabelValue2.Text = "Grid Stop H = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) / 256)

                LabelValue1.Text = "Grid Start H = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) And &HFF)
                LabelValue2.Text = "Grid Stop H = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) And &HFF)

                'LabelValue3.Text = "PFN Trigger Delay High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) / 256)
                'LabelValue4.Text = "AFC Sample Delay High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) / 256)
                'LabelValue5.Text = "Mag Samp Delay High = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) And &HFF)
                'LabelValue6.Text = "Dose Sample Delay High = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) And &HFF)

                'LabelValue7.Text = "Grid Start L = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) / 256)
                'LabelValue8.Text = "Grid Stop L = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) / 256)
                LabelValue7.Text = "Grid Start L = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_10) And &HFF)
                LabelValue8.Text = "Grid Stop L = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_LOW_INTENSITY_10) And &HFF)


                'LabelValue9.Text = "PFN Trigger Delay Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(8) / 256)
                'LabelValue10.Text = "AFC Sample Delay Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(11) / 256)
                'LabelValue11.Text = "Mag Samp Delay Low = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(11) And &HFF)
                'LabelValue12.Text = "Dose Sample Delay Low = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(8) And &HFF)

                'LabelValue1.Text = "Grid Start = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) / 256)
                ' LabelValue2.Text = "Grid Stop = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) / 256)
                LabelValue3.Text = "PFN Trigger Delay = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) / 256)
                LabelValue4.Text = "AFC Sample Delay = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) / 256)
                LabelValue5.Text = "Mag Samp Delay = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) And &HFF)
                LabelValue6.Text = ""
                ' LabelValue7.Text = ""
                ' LabelValue8.Text = ""
                LabelValue9.Text = ""
                LabelValue10.Text = ""
                LabelValue11.Text = ""
                LabelValue12.Text = ""
                LabelValue13.Text = ""
                LabelValue14.Text = ""
                LabelValue15.Text = ""

                inputbutton1.enabled = True
                inputbutton1.button_only = False
                inputbutton1.button_name = "Grid Start"
                inputbutton1.max_value = 255
                inputbutton1.min_value = 0
                inputbutton1.scale = 1
                inputbutton1.offset = 0
                inputbutton1.button_index = REGISTER_SPECIAL_2_5_SET_DOSE_DYNAMIC_START

                inputbutton2.enabled = True
                inputbutton2.button_only = False
                inputbutton2.button_name = "Grid Stop"
                inputbutton2.max_value = 255
                inputbutton2.min_value = 0
                inputbutton2.scale = 1
                inputbutton2.offset = 0
                inputbutton2.button_index = REGISTER_SPECIAL_2_5_SET_DOSE_DYNAMIC_STOP

                inputbutton3.enabled = True
                inputbutton3.button_only = False
                inputbutton3.button_name = "PFN Delay"
                inputbutton3.max_value = 255
                inputbutton3.min_value = 0
                inputbutton3.scale = 1
                inputbutton3.offset = 0
                inputbutton3.button_index = REGISTER_SPECIAL_2_5_SET_PFN_DELAY

                inputbutton4.enabled = True
                inputbutton4.button_only = False
                inputbutton4.button_name = "AFC Delay"
                inputbutton4.max_value = 255
                inputbutton4.min_value = 0
                inputbutton4.scale = 1
                inputbutton4.offset = 0
                inputbutton4.button_index = REGISTER_SPECIAL_2_5_SET_AFC_SAMPLE_DELAY

                inputbutton5.enabled = True
                inputbutton5.button_only = False
                inputbutton5.button_name = "I Samp Delay"
                inputbutton5.max_value = 255
                inputbutton5.min_value = 0
                inputbutton5.scale = 1
                inputbutton5.offset = 0
                inputbutton5.button_index = REGISTER_SPECIAL_2_5_SET_MAGNETRON_CURRENT_SAMPLE_DELAY


            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) Then
                If (ConnectedBoards And &H4) Then
                    LabelBoardStatus.Text = "NOT CONNECTED!!!"
                    bgcolor = Color.LightCoral
                End If

                CheckBoxStatusBit0.Text = "HIGH MODE"
                CheckBoxStatusBit1.Text = "Arc"
                CheckBoxStatusBit2.Visible = False
                CheckBoxStatusBit3.Visible = False
                CheckBoxStatusBit4.Visible = False
                CheckBoxStatusBit5.Visible = False
                CheckBoxStatusBit6.Visible = False
                CheckBoxStatusBit7.Visible = False

                CheckBoxFaultBit0.Text = "Arc Slow"
                CheckBoxFaultBit1.Text = "Arc Fast"
                CheckBoxFaultBit2.Text = "Arc Cont"
                CheckBoxFaultBit3.Text = "Can FLT"
                CheckBoxFaultBit4.Text = "False Trig"
                CheckBoxFaultBit5.Visible = False
                CheckBoxFaultBit6.Visible = False
                CheckBoxFaultBit7.Visible = False
                CheckBoxFaultBit8.Visible = False
                CheckBoxFaultBit9.Visible = False
                CheckBoxFaultBitA.Visible = False
                CheckBoxFaultBitB.Visible = False
                CheckBoxFaultBitC.Visible = False
                CheckBoxFaultBitD.Visible = False
                CheckBoxFaultBitE.Visible = False
                CheckBoxFaultBitF.Visible = False

                LabelDebug0.Text = "Debug 0 = "
                LabelDebug1.Text = "Debug 1 = "
                LabelDebug2.Text = "Debug 2 = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Debug 4 = "
                LabelDebug5.Text = "Debug 5 = "
                LabelDebug6.Text = "Debug 6 = "
                LabelDebug7.Text = "Debug 7 = "
                LabelDebug8.Text = "Debug 8 = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "

                LabelValue1.Text = "Pulses Today = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_THIS_HV_ON_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_THIS_HV_ON_W1), "###,###,###,##0")
                LabelValue2.Text = "Arcs Today = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.READBACK_ARCS_THIS_HV_ON), "###,###,###,##0")
                LabelValue3.Text = "Pulse Total = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_LIFETIME_W4) * 2 ^ 48 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_LIFETIME_W3) * 2 ^ 32 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_LIFETIME_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.PULSES_LIFETIME_W1), "###,###,###,##0")
                LabelValue4.Text = "Arcs Total = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.ARCS_LIFETIME_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.ARCS_LIFETIME_W1), "###,###,###,##0")
                LabelValue5.Text = "Imon High Energy = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.FILTERED_HIGH_ENERGY_PULSE_CURRENT) / 100, "0.00") & " A"
                LabelValue6.Text = "Imon Low Energy = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(CS_MAGNETRON.FILTERED_LOW_ENERGY_PULSE_CURRENT) / 100, "0.00") & " A"
                LabelValue7.Text = ""
                LabelValue8.Text = ""
                LabelValue9.Text = ""
                LabelValue10.Text = ""
                LabelValue11.Text = ""
                LabelValue12.Text = ""
                LabelValue13.Text = ""
                LabelValue14.Text = ""
                LabelValue15.Text = ""

                inputbutton1.enabled = False
                inputbutton2.enabled = False
                inputbutton3.enabled = False
                inputbutton4.enabled = False
                inputbutton5.enabled = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING) Then
                If (ConnectedBoards And &H40) Then
                    LabelBoardStatus.Text = "NOT CONNECTED!!!"
                    bgcolor = Color.LightCoral
                End If

                CheckBoxStatusBit0.Text = "SF6 Relay Closed"
                CheckBoxStatusBit1.Text = "SF6 too Cold"
                CheckBoxStatusBit2.Text = "SF6 too Low"
                CheckBoxStatusBit3.Text = "SF6 Need Fill"
                CheckBoxStatusBit4.Text = "SF6 Limit"
                CheckBoxStatusBit5.Text = "SF6 Filling"
                CheckBoxStatusBit6.Visible = False
                CheckBoxStatusBit7.Visible = False

                CheckBoxFaultBit0.Visible = False
                CheckBoxFaultBit1.Text = "Magnetron Flow"
                CheckBoxFaultBit2.Text = "HVPS Flow"
                CheckBoxFaultBit3.Text = "Circulator Flow"
                CheckBoxFaultBit4.Text = "Linac FLow"
                CheckBoxFaultBit5.Text = "HX Flow"
                CheckBoxFaultBit6.Text = "Cabinet SW"
                CheckBoxFaultBit7.Text = "Cabient Temp"
                CheckBoxFaultBit8.Text = "Coolant Ovr Temp"
                CheckBoxFaultBit9.Text = "Coolant Under Temp"
                CheckBoxFaultBitA.Text = "Linac Temp"
                CheckBoxFaultBitB.Text = "SF6 SW"
                CheckBoxFaultBitC.Text = "SF6 Pressure"
                CheckBoxFaultBitD.Visible = False
                CheckBoxFaultBitE.Visible = False
                CheckBoxFaultBitF.Visible = False

                LabelDebug0.Text = "Debug 0 = "
                LabelDebug1.Text = "Debug 1 = "
                LabelDebug2.Text = "Debug 2 = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Debug 4 = "
                LabelDebug5.Text = "Debug 5 = "
                LabelDebug6.Text = "Debug 6 = "
                LabelDebug7.Text = "Debug 7 = "
                LabelDebug8.Text = "Debug 8 = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "

                LabelValue1.Text = "Pulses Allowed = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.PULSES_AVAILABLE)
                LabelValue2.Text = "Override Pulses = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.LOW_PRESSURE_OVERRIDE_AVAILABLE)
                LabelValue3.Text = "Bottle Pulses = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.BOTTLE_COUNT)
                LabelValue4.Text = "Magnetron Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.MAGNETRON_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                LabelValue5.Text = "Linac Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.LINAC_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                LabelValue6.Text = "HX Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.HX_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                'LabelValue7.Text = "HVPS Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.HVPS_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                LabelValue7.Text = "HVPS Flow = N/A"
                'LabelValue8.Text = "Circulator Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.CIRCULATOR_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                LabelValue8.Text = "Circulator Flow = N/A"
                'LabelValue9.Text = "Spare Flow = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.SPARE_COOLANT_FLOW) / 1000, "0.000") & " LPM"
                LabelValue9.Text = "Spare Flow = N/A"
                LabelValue10.Text = "SF6 Pressure = " & Format(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.SF6_PRESSURE) / 100, "00.00") & " PSI"
                LabelValue11.Text = "Coolant Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.COOLANT_TEMPERATURE) - 272 & " C"
                LabelValue12.Text = "Cabinent Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.CABINET_TEMPERATURE) - 272 & " C"
                'LabelValue13.Text = "Linac Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(CS_COOLING.LINAC_TEMPERATURE) - 272 & " C"
                LabelValue13.Text = "Linac Temp = N/A"
                LabelValue14.Text = ""
                LabelValue15.Text = ""


                inputbutton1.enabled = True
                inputbutton1.button_only = True
                inputbutton1.button_name = "25 SF6 Pulses"
                inputbutton1.max_value = 255
                inputbutton1.min_value = 0
                inputbutton1.scale = 1
                inputbutton1.offset = 0
                inputbutton1.button_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES

                inputbutton2.enabled = True
                inputbutton2.button_only = False
                inputbutton2.button_name = "Override Pulses"
                inputbutton2.max_value = 5
                inputbutton2.min_value = 0
                inputbutton2.scale = 1
                inputbutton2.offset = 0
                inputbutton2.button_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT

                inputbutton3.enabled = True
                inputbutton3.button_only = False
                inputbutton3.button_name = "Set Bottle Pulses"
                inputbutton3.max_value = 1000
                inputbutton3.min_value = 0
                inputbutton3.scale = 1
                inputbutton3.offset = 0
                inputbutton3.button_index = REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE



                inputbutton4.enabled = False
                inputbutton5.enabled = False





            Else
                CheckBoxStatusBit0.Text = "Status 0"
                CheckBoxStatusBit1.Text = "Status 1"
                CheckBoxStatusBit2.Text = "Status 2"
                CheckBoxStatusBit3.Text = "Status 3"
                CheckBoxStatusBit4.Text = "Status 4"
                CheckBoxStatusBit5.Text = "Status 5"
                CheckBoxStatusBit6.Text = "Status 6"
                CheckBoxStatusBit7.Text = "Status 7"

                CheckBoxFaultBit0.Text = "Fault 0"
                CheckBoxFaultBit1.Text = "Fault 1"
                CheckBoxFaultBit2.Text = "Fault 2"
                CheckBoxFaultBit3.Text = "Fault 3"
                CheckBoxFaultBit4.Text = "Fault 4"
                CheckBoxFaultBit5.Text = "Fault 5"
                CheckBoxFaultBit6.Text = "Fault 6"
                CheckBoxFaultBit7.Text = "Fault 7"
                CheckBoxFaultBit8.Text = "Fault 8"
                CheckBoxFaultBit9.Text = "Fault 9"
                CheckBoxFaultBitA.Text = "Fault A"
                CheckBoxFaultBitB.Text = "Fault B"
                CheckBoxFaultBitC.Text = "Fault C"
                CheckBoxFaultBitD.Text = "Fault D"
                CheckBoxFaultBitE.Text = "Fault E"
                CheckBoxFaultBitF.Text = "Fault F"

                LabelDebug0.Text = "Debug 0 = "
                LabelDebug1.Text = "Debug 1 = "
                LabelDebug2.Text = "Debug 2 = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Debug 4 = "
                LabelDebug5.Text = "Debug 5 = "
                LabelDebug6.Text = "Debug 6 = "
                LabelDebug7.Text = "Debug 7 = "
                LabelDebug8.Text = "Debug 8 = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "

                LabelValue1.Text = ""
                LabelValue2.Text = ""
                LabelValue3.Text = ""
                LabelValue4.Text = ""
                LabelValue5.Text = ""
                LabelValue6.Text = ""
                LabelValue7.Text = ""
                LabelValue8.Text = ""
                LabelValue9.Text = ""
                LabelValue10.Text = ""
                LabelValue11.Text = ""
                LabelValue12.Text = ""
                LabelValue13.Text = ""
                LabelValue14.Text = ""
                LabelValue15.Text = ""

                inputbutton1.enabled = False
                inputbutton2.enabled = False
                inputbutton3.enabled = False
                inputbutton4.enabled = False
                inputbutton5.enabled = False

            End If

#End If

    End Sub


    Private Sub UpdateButtons()

        If inputbutton1.enabled Then
            TextBoxInput1.Visible = True
            ButtonUpdateInput1.Visible = True
            If inputbutton1.button_only = True Then
                TextBoxInput1.Visible = False
            End If
        Else
            TextBoxInput1.Visible = False
            ButtonUpdateInput1.Visible = False
        End If

        If inputbutton2.enabled Then
            TextBoxInput2.Visible = True
            ButtonUpdateInput2.Visible = True
            If inputbutton2.button_only = True Then
                TextBoxInput2.Visible = False
            End If
        Else
            TextBoxInput2.Visible = False
            ButtonUpdateInput2.Visible = False
        End If

        If inputbutton3.enabled Then
            TextBoxInput3.Visible = True
            ButtonUpdateInput3.Visible = True
            If inputbutton3.button_only = True Then
                TextBoxInput3.Visible = False
            End If
        Else
            TextBoxInput3.Visible = False
            ButtonUpdateInput3.Visible = False
        End If

        If inputbutton4.enabled Then
            TextBoxInput4.Visible = True
            ButtonUpdateInput4.Visible = True
            If inputbutton4.button_only = True Then
                TextBoxInput4.Visible = False
            End If
        Else
            TextBoxInput4.Visible = False
            ButtonUpdateInput4.Visible = False
        End If

        If inputbutton5.enabled Then
            TextBoxInput5.Visible = True
            ButtonUpdateInput5.Visible = True
            If inputbutton5.button_only = True Then
                TextBoxInput5.Visible = False
            End If
        Else
            TextBoxInput5.Visible = False
            ButtonUpdateInput5.Visible = False
        End If

        ButtonUpdateInput1.Text = inputbutton1.button_name
        ButtonUpdateInput2.Text = inputbutton2.button_name
        ButtonUpdateInput3.Text = inputbutton3.button_name
        ButtonUpdateInput4.Text = inputbutton4.button_name
        ButtonUpdateInput5.Text = inputbutton5.button_name


        If inputbutton1.enabled And (inputbutton1.button_only = False) Then
            LabelRangeInput1.Text = (CLng(inputbutton1.min_value) - CLng(inputbutton1.offset)) / inputbutton1.scale & " to " & (CLng(inputbutton1.max_value) - CLng(inputbutton1.offset)) / inputbutton1.scale
        Else
            LabelRangeInput1.Text = ""
        End If

        If inputbutton2.enabled And (inputbutton2.button_only = False) Then
            LabelRangeInput2.Text = (CLng(inputbutton2.min_value) - CLng(inputbutton2.offset)) / inputbutton2.scale & " to " & (CLng(inputbutton2.max_value) - CLng(inputbutton2.offset)) / inputbutton2.scale
        Else
            LabelRangeInput2.Text = ""
        End If

        If inputbutton3.enabled And (inputbutton3.button_only = False) Then
            LabelRangeInput3.Text = (CLng(inputbutton3.min_value) - CLng(inputbutton3.offset)) / inputbutton3.scale & " to " & (CLng(inputbutton3.max_value) - CLng(inputbutton3.offset)) / inputbutton3.scale
        Else
            LabelRangeInput3.Text = ""
        End If

        If inputbutton4.enabled And (inputbutton4.button_only = False) Then
            LabelRangeInput4.Text = (CLng(inputbutton4.min_value) - CLng(inputbutton4.offset)) / inputbutton4.scale & " to " & (CLng(inputbutton4.max_value) - CLng(inputbutton4.offset)) / inputbutton4.scale
        Else
            LabelRangeInput4.Text = ""
        End If


        If inputbutton5.enabled And (inputbutton5.button_only = False) Then
            LabelRangeInput5.Text = (CLng(inputbutton5.min_value) - CLng(inputbutton5.offset)) / inputbutton5.scale & " to " & (CLng(inputbutton5.max_value) - CLng(inputbutton5.offset)) / inputbutton5.scale
        Else
            LabelRangeInput5.Text = ""
        End If

    End Sub


    Private Sub DisplayLeftPane()

        ' Update the ECB State
        Dim ECBState As String = ""

        Select Case ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(0)
            Case &H10
                ECBState = "Startup"
            Case &H12
                ECBState = "Wait Personality"
            Case &H15
                ECBState = "Wait For Init"
            Case &H20
                ECBState = "Warmup"
            Case &H30
                ECBState = "Standby"
            Case &H40
                ECBState = "Drive Up"
            Case &H50
                ECBState = "Ready"
            Case &H60
                ECBState = "X-Ray On"
            Case &H70
                ECBState = "X-Ray Time Exceeded"
            Case &H80
                ECBState = "Fault Hold"
            Case &H86
                ECBState = "Fault Reset Hold"
            Case &H8A
                ECBState = "Fault Latch Decision"
            Case &H90
                ECBState = "Fault Reset"
            Case &HA0
                ECBState = "System Error"
            Case &HB0
                ECBState = "Warmup Fault"
            Case &HC0
                ECBState = "Standby Fault"
            Case &HD1
                ECBState = "Power Cycle Test"
            Case Else
                ECBState = "Unknown State"
        End Select

        LabelECBState.Text = "ECB State = " & ECBState

        Dim time As UInt32
        Dim year As Integer
        Dim month As Integer
        Dim day As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer

        time = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(2) * 2 ^ 16
        time += ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(1)

        LabelComputerTime.Text = "Computer UTC = 20" & Format(DateTime.UtcNow, "yy/MM/dd HH:mm:ss")

        year = CInt(Math.Truncate(time / YEAR_MULT))
        time = CUInt(time Mod YEAR_MULT)
        month = CInt(Math.Truncate(time / MONTH_MULT))
        time = CUInt(time Mod MONTH_MULT)
        day = CInt(Math.Truncate(time / DAY_MULT))
        time = CUInt(time Mod DAY_MULT)
        hour = CInt(Math.Truncate(time / HOUR_MULT))
        time = CUInt(time Mod HOUR_MULT)
        minute = CInt(Math.Truncate(time / MIN_MULT))
        second = CInt(time Mod MIN_MULT)

        LabelECBTime.Text = "Linac UTC = 20" & Format(year, "00") & "/" & Format(month, "00") & "/" & Format(day, "00") & " " & Format(hour, "00") & ":" & Format(minute, "00") & ":" & Format(second, "00")



        ' Common Display Information
        ' Magnetron Current
        ' Magnet Current
        ' Heater Current
        ' PRF





        ' Figure out the magnetron current (take the max of high and low energy currents)
        Dim magnetron_current As UInt16
        Dim magnetron_current_high_energy As UInt16
        Dim magnetron_current_low_energy As UInt16
        magnetron_current_high_energy = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(0)
        magnetron_current_low_energy = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(2)

        If (magnetron_current_high_energy > magnetron_current_low_energy) Then
            magnetron_current = magnetron_current_high_energy
        Else
            magnetron_current = magnetron_current_low_energy
        End If

        ' Calculate the Max warmuptime remaining of the thyratron, magnetron, gun
        Dim warmuptime As UInt16
        warmuptime = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(4)
        warmuptime = Math.Max(warmuptime, ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(5))
        warmuptime = Math.Max(warmuptime, ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(6))

        ' Calculate the PRF
        Dim prf As UInt16
        prf = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(3)
        If prf <> 0 Then
            ' If the PRF is 0, then no trigger data is sent from the pulse sync board, so the "more accurate value" will store the last trigger sent
            ' If the PRF is not Zero, then triggers are being sent so use the most recent value
            prf = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(3)
        End If

        Dim grid_width As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(11)
        Try
            grid_width = (Math.Truncate(grid_width / 256) - Math.Truncate(grid_width Mod 256)) * 20
        Catch ex As Exception
            grid_width = 0
        End Try


        Dim trigger_width As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(7)
        Try
            trigger_width = Math.Truncate(trigger_width / 256) * 100
        Catch ex As Exception
            trigger_width = 0
        End Try




        LabelDisplay1.Text = "Magnetron Current = " & Format(magnetron_current / 100, ".00") & " A"
        LabelDisplay2.Text = "Magnet Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(1) / 1000, ".000") & " A"
        LabelDisplay3.Text = "Heater Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(3) / 1000, ".000") & " A"
        LabelDisplay4.Text = "Pulses Today = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(4)
        LabelDisplay5.Text = "Arcs Today = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(12)
        LabelDisplay6.Text = "PRF = " & Format(prf / 10, ".0") & " Hz"
        LabelDisplay7.Text = "Trig = " & trigger_width & "nS / " & grid_width & "nS"
        'LabelDisplay7.Text = "Ion Pump Current = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) & " nA"
        'LabelDisplay8.Text = "Warmup Remaining = " & Math.Truncate(warmuptime / 60) & ":" & Format((warmuptime Mod 60), "00")
        LabelDisplay8.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(17)
        LabelSystemSerialNumber.Text = "SN = H" & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(19)

        Label15.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).ecb_local_data(4)

        ' Update the current Sync Bits
        Dim Sync_data As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(7)


        If (Sync_data And &H2) Then
            ' High speed data logging is enabled
            ButtonStopLog.Visible = True
            ButtonStartLog.Visible = False
        Else
            ButtonStopLog.Visible = False
            ButtonStartLog.Visible = True
        End If


        ' Update the connected Boards

        Dim ConnectedBoards As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16)
        ConnectedBoards = Not ConnectedBoards
        CheckBoxIonPumpConnected.Checked = ConnectedBoards And &H2
        CheckBoxPulseCurrentMonitorConnected.Checked = ConnectedBoards And &H4
        CheckBoxPulseSyncConnected.Checked = ConnectedBoards And &H8
        CheckBoxHVLambdaConnected.Checked = ConnectedBoards And &H10
        CheckBoxAFCConnected.Checked = ConnectedBoards And &H20
        CheckBoxCoolingConnected.Checked = ConnectedBoards And &H40
        CheckBoxHtrMagConnected.Checked = ConnectedBoards And &H80
        CheckBoxGunDriverConnected.Checked = ConnectedBoards And &H100

        CheckBoxOperateIonPump.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).fault_bits
        CheckBoxOperateMagnetronCurrentMon.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).fault_bits
        CheckBoxOperatePulseSync.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).fault_bits
        CheckBoxOperateHVLambda.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).fault_bits
        CheckBoxOperateAFC.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).fault_bits
        CheckBoxOperateCooling.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).fault_bits
        CheckBoxOperateHtrMag.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).fault_bits
        CheckBoxOperateGunDriver.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).fault_bits
        CheckBoxOperateEthernet.Checked = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).fault_bits


#If (0) Then

        ' Update the Ready Boards
        'Dim FaultedBoards As UInt16 = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(0)
        CheckBoxOperateIonPump.Checked = (ConnectedBoards And &H2) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).status_data.status_word_1)
        CheckBoxOperateMagnetronCurrentMon.Checked = (ConnectedBoards And &H4) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).status_data.status_word_1)
        CheckBoxOperatePulseSync.Checked = (ConnectedBoards And &H8) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).status_data.status_word_1)
        CheckBoxOperateHVLambda.Checked = (ConnectedBoards And &H10) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).status_data.status_word_1)
        CheckBoxOperateAFC.Checked = (ConnectedBoards And &H20) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).status_data.status_word_1)
        CheckBoxOperateCooling.Checked = (ConnectedBoards And &H40) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).status_data.status_word_1)
        CheckBoxOperateHtrMag.Checked = (ConnectedBoards And &H80) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).status_data.status_word_1)
        CheckBoxOperateGunDriver.Checked = (ConnectedBoards And &H100) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).status_data.status_word_1)
        CheckBoxOperateEthernet.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).status_data.status_word_0 And &H1

        ' Update the Fault Boards
#End If


    End Sub


   


    Private Sub DisplayDebugData()

        LabelValueDebug0.Text = ServerSettings.ETMEthernetDebugData.debug_0
        LabelValueDebug1.Text = ServerSettings.ETMEthernetDebugData.debug_1
        LabelValueDebug2.Text = ServerSettings.ETMEthernetDebugData.debug_2
        LabelValueDebug3.Text = ServerSettings.ETMEthernetDebugData.debug_3
        LabelValueDebug4.Text = ServerSettings.ETMEthernetDebugData.debug_4
        LabelValueDebug5.Text = ServerSettings.ETMEthernetDebugData.debug_5
        LabelValueDebug6.Text = ServerSettings.ETMEthernetDebugData.debug_6
        LabelValueDebug7.Text = ServerSettings.ETMEthernetDebugData.debug_7
        LabelValueDebug8.Text = ServerSettings.ETMEthernetDebugData.debug_8
        LabelValueDebug9.Text = ServerSettings.ETMEthernetDebugData.debug_9
        LabelValueDebugA.Text = ServerSettings.ETMEthernetDebugData.debug_A
        LabelValueDebugB.Text = ServerSettings.ETMEthernetDebugData.debug_B
        LabelValueDebugC.Text = ServerSettings.ETMEthernetDebugData.debug_C
        LabelValueDebugD.Text = ServerSettings.ETMEthernetDebugData.debug_D
        LabelValueDebugE.Text = ServerSettings.ETMEthernetDebugData.debug_E
        LabelValueDebugF.Text = ServerSettings.ETMEthernetDebugData.debug_F


        LabelCanCXECReg.Text = "CXEC Register = 0x" & ServerSettings.ETMEthernetDebugData.CXEC_reg_max.ToString("x")
        LabelCanErrorFlagCount.Text = "Error Flag Cnt = " & ServerSettings.ETMEthernetDebugData.can_error_flag
        LabelCanTX1Count.Text = "TX1 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_1
        LabelCanTX2Count.Text = "TX2 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_2
        LabelCanRX0Filt0Count.Text = "RX0 Filt 0 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_0
        LabelCanRX0Filt1Count.Text = "RX0 Filt 1 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_1
        LabelCanRX1Filt2Count.Text = "RX1 Filt 2 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_1_filt_2
        LabelCanISREnteredCount.Text = "CXINTF = 0x" & ServerSettings.ETMEthernetDebugData.CXINTF_max.ToString("X")
        LabelCanUnknownIdentifierCount.Text = "Unknown ID Cnt = " & ServerSettings.ETMEthernetDebugData.can_unknown_msg_id
        LabelCanInvalidIndexCount.Text = "Invalid Index Cnt = " & ServerSettings.ETMEthernetDebugData.can_invalid_index
        LabelCanAddressErrorCount.Text = "Address Error Cnt = " & ServerSettings.ETMEthernetDebugData.can_address_error
        LabelCanTX0Count.Text = "TX 0 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_0
        LabelCanTXBufOverflowCount.Text = "TX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_buf_overflow
        LabelCanRXBufferOverflowCount.Text = "RX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_buf_overflow
        LabelCAnDataLogRXBufferOVerflowCount.Text = "Log RX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_log_buf_overflow
        LabelCanTimeoutCount.Text = "Can Timeout Cnt = " & ServerSettings.ETMEthernetDebugData.can_timeout


        LabelErrorI2CBusCount.Text = "I2C Bus Errors = " & ServerSettings.ETMEthernetDebugData.i2c_bus_error_count
        LabelErrorSPIBusCount.Text = "SPI Bus Errors = " & ServerSettings.ETMEthernetDebugData.spi_bus_error_count
        'LabelErrorCanBusCount.Text = "Can Bus Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.can_bus_error_count
        LabelErrorScaleCount.Text = "Scale Errors = " & ServerSettings.ETMEthernetDebugData.scale_error_count
        LabelErrorResetCount.Text = "Reset Count = " & ServerSettings.ETMEthernetDebugData.reset_count
        LabelErrorSelfTestResultRegister.Text = "Self Test = 0x" & ServerSettings.ETMEthernetDebugData.self_test_results.ToString("x")
        LabelErrorReserved0.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16).ToString("x") '  "= 0x" & ServerSettings.ETMEthernetDebugData.reserved_0.ToString("x")
        LabelErrorReserved1.Text = "Can Ver = 0x" & ServerSettings.ETMEthernetDebugData.reserved_1.ToString("x")
        LabelRCON.Text = "RCON = " & ServerSettings.ETMEthernetDebugData.RCON_value.ToString("X")

        LabelCommandCount.Text = "Cmd Count = " & ServerSettings.command_rcv_count
        LabelCommandLengthError.Text = "Cmd Lgth Err = " & ServerSettings.command_length_error
    End Sub


    Private Sub cboIndex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIndex.SelectedIndexChanged
        board_index = cboIndex.SelectedIndex + 1
        TextBoxInput1.Text = ""
        TextBoxInput2.Text = ""
        TextBoxInput3.Text = ""
        TextBoxInput4.Text = ""
        TextBoxInput5.Text = ""

        CheckBoxFaultBit0.Visible = True
        CheckBoxFaultBit1.Visible = True
        CheckBoxFaultBit2.Visible = True
        CheckBoxFaultBit3.Visible = True
        CheckBoxFaultBit4.Visible = True
        CheckBoxFaultBit5.Visible = True
        CheckBoxFaultBit6.Visible = True
        CheckBoxFaultBit7.Visible = True
        CheckBoxFaultBit8.Visible = True
        CheckBoxFaultBit9.Visible = True
        CheckBoxFaultBitA.Visible = True
        CheckBoxFaultBitB.Visible = True
        CheckBoxFaultBitC.Visible = True
        CheckBoxFaultBitD.Visible = True
        CheckBoxFaultBitE.Visible = True
        CheckBoxFaultBitF.Visible = True

        CheckBoxLoggedBit0.Visible = True
        CheckBoxLoggedBit1.Visible = True
        CheckBoxLoggedBit2.Visible = True
        CheckBoxLoggedBit3.Visible = True
        CheckBoxLoggedBit4.Visible = True
        CheckBoxLoggedBit5.Visible = True
        CheckBoxLoggedBit6.Visible = True
        CheckBoxLoggedBit7.Visible = True
        CheckBoxLoggedBit8.Visible = True
        CheckBoxLoggedBit9.Visible = True
        CheckBoxLoggedBitA.Visible = True
        CheckBoxLoggedBitB.Visible = True
        CheckBoxLoggedBitC.Visible = True
        CheckBoxLoggedBitD.Visible = True
        CheckBoxLoggedBitE.Visible = True
        CheckBoxLoggedBitF.Visible = True


        LabelDebug0.Text = "Debug 0 = "
        LabelDebug1.Text = "Debug 1 = "
        LabelDebug2.Text = "Debug 2 = "
        LabelDebug3.Text = "Debug 3 = "
        LabelDebug4.Text = "Debug 4 = "
        LabelDebug5.Text = "Debug 5 = "
        LabelDebug6.Text = "Debug 6 = "
        LabelDebug7.Text = "Debug 7 = "
        LabelDebug8.Text = "Debug 8 = "
        LabelDebug9.Text = "Debug 9 = "
        LabelDebugA.Text = "Debug A = "
        LabelDebugB.Text = "Debug B = "
        LabelDebugC.Text = "Debug C = "
        LabelDebugD.Text = "Debug D = "
        LabelDebugE.Text = "Debug E = "
        LabelDebugF.Text = "Debug F = "

    End Sub




    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            TimerUpdate.Enabled = False
            ServerSettings.Close()
        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormClosed  " + ex.ToString)
        End Try

    End Sub




    Private Sub ExecuteButton(ByVal button As ButtonParameters, ByVal input_box As TextBox)
        Dim program_word As UInt16
        Try
            If button.button_only Then
                program_word = 0
            Else
                program_word = CUInt(input_box.Text * button.scale + button.offset)
            End If
            If program_word > button.max_value Then
                program_word = button.max_value
            End If
            If program_word < button.min_value Then
                program_word = button.min_value
            End If
            ServerSettings.put_modbus_commands(button.button_index, program_word, 0, 0)
        Catch ex As Exception
            MsgBox("You must enter valid Number")
        End Try

    End Sub

    Private Sub ButtonUpdateInput1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput1.Click
        ExecuteButton(inputbutton1, TextBoxInput1)
    End Sub


    Private Sub ButtonUpdateInput2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput2.Click
        ExecuteButton(inputbutton2, TextBoxInput2)
    End Sub

    Private Sub ButtonUpdateInput3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateInput3.Click
        ExecuteButton(inputbutton3, TextBoxInput3)
    End Sub

    Private Sub ButtonUpdateInput4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput4.Click
        ExecuteButton(inputbutton4, TextBoxInput4)
    End Sub

    Private Sub ButtonUpdateInput5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput5.Click
        ExecuteButton(inputbutton5, TextBoxInput5)
    End Sub

    Private Sub ButtonToggleResetDebug_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleResetDebug.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_RESET_DEBUG, 0, 0, 0)
    End Sub



    Private Sub ComboBoxEEpromRegister_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim command_index As UInt16
        If board_index = MODBUS_COMMANDS.MODBUS_WR_ETHERNET Then
            command_index = ETM_CAN_ADDR_ETHERNET_BOARD
            selected_board_index = ETM_CAN_ADDR_ETHERNET_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP Then
            command_index = ETM_CAN_ADDR_ION_PUMP_BOARD
            selected_board_index = ETM_CAN_ADDR_ION_PUMP_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT Then
            command_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
            selected_board_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC Then
            command_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
            selected_board_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA Then
            command_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
            selected_board_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_AFC Then
            command_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
            selected_board_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING Then
            command_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
            selected_board_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET Then
            command_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
            selected_board_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER Then
            command_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
            selected_board_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
        End If


        command_index = command_index * 2 ^ 12
        EEProm_index = command_index + EEProm_index + &H100

    End Sub



    Public Const ETM_CAN_ADDR_ETHERNET_BOARD = 14
    Public Const ETM_CAN_ADDR_ION_PUMP_BOARD = 1
    Public Const ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD = 2
    Public Const ETM_CAN_ADDR_PULSE_SYNC_BOARD = 3
    Public Const ETM_CAN_ADDR_HV_LAMBDA_BOARD = 4
    Public Const ETM_CAN_ADDR_AFC_CONTROL_BOARD = 5
    Public Const ETM_CAN_ADDR_COOLING_INTERFACE_BOARD = 6
    Public Const ETM_CAN_ADDR_HEATER_MAGNET_BOARD = 7
    Public Const ETM_CAN_ADDR_GUN_DRIVER_BOARD = 8



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        'ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_SEND_SLAVE_RELOAD_EEPROM_WITH_DEFAULTS, selected_board_index, 0, 0)
    End Sub

    Private Sub ButtonResetSlave_Click(sender As System.Object, e As System.EventArgs)
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_RESET_MCU, selected_board_index, 0, 0)
    End Sub



    Private Sub ButtonStartLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStartLog.Click
        ButtonStartLog.Visible = False
        ServerSettings.put_modbus_commands(REGISTER_SYSTEM_ENABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
        ServerSettings.OpenPulseLogFile()
    End Sub

    Private Sub ButtonStopLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStopLog.Click
        ButtonStopLog.Visible = False
        ServerSettings.ClosePulseLogFile()
        ServerSettings.put_modbus_commands(REGISTER_SYSTEM_DISABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
    End Sub


    Private Sub ButtonSetTime_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetTime.Click
        Dim time_high_word As UInt16
        Dim time_low_word As UInt16
        Dim time_now As Date = DateTime.UtcNow
        Dim time_seconds As UInt32

        time_seconds = (time_now.Year Mod 100) * YEAR_MULT
        time_seconds += (time_now.Month) * MONTH_MULT
        time_seconds += (time_now.Day) * DAY_MULT
        time_seconds += (time_now.Hour) * HOUR_MULT
        time_seconds += (time_now.Minute) * MIN_MULT
        time_seconds += (time_now.Second)

        time_high_word = CUShort(time_seconds >> 16)
        time_low_word = CUShort(time_seconds And &HFFFF)
        'LabelTimeSet.Text = Format(time_now, "yy MM dd HH mm ss")
        'LabelTimeSet2.Text = time_seconds
        Try
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_SET_TIME, time_high_word, time_low_word, 0)
        Catch ex As Exception
            MsgBox("Date Time Type conversion failed")

        End Try
    End Sub

    Private Sub ButtonReloadECBDefaults_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReloadECBDefaults.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroOnTime_Click(sender As System.Object, e As System.EventArgs) Handles ButtonZeroOnTime.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroPulseCounters_Click(sender As System.Object, e As System.EventArgs) Handles ButtonZeroPulseCounters.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT, 0, 0, 0)
    End Sub

    Private Sub ButtonToggleMode_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleMode.Click
        LabelCanCXECReg.Visible = True
        LabelCanErrorFlagCount.Visible = True
        LabelCanTX1Count.Visible = True
        LabelCanTX2Count.Visible = True
        LabelCanRX0Filt0Count.Visible = True
        LabelCanRX0Filt1Count.Visible = True
        LabelCanRX1Filt2Count.Visible = True
        LabelCanISREnteredCount.Visible = True
        LabelCanUnknownIdentifierCount.Visible = True
        LabelCanInvalidIndexCount.Visible = True
        LabelCanAddressErrorCount.Visible = True
        LabelCanTX0Count.Visible = True
        LabelCanTXBufOverflowCount.Visible = True
        LabelCanRXBufferOverflowCount.Visible = True
        LabelCAnDataLogRXBufferOVerflowCount.Visible = True
        LabelCanTimeoutCount.Visible = True
        CheckBoxControlBit0.Visible = True
        CheckBoxControlBit1.Visible = True
        CheckBoxControlBit2.Visible = True
        CheckBoxControlBit3.Visible = True
        CheckBoxControlBit4.Visible = True
        CheckBoxControlBit5.Visible = True
        CheckBoxControlBit6.Visible = True
        CheckBoxControlBit7.Visible = True
        LabelErrorI2CBusCount.Visible = True
        LabelErrorResetCount.Visible = True
        LabelErrorScaleCount.Visible = True
        LabelErrorSelfTestResultRegister.Visible = True
        LabelErrorSPIBusCount.Visible = True
        LabelErrorReserved0.Visible = True
        LabelErrorReserved1.Visible = True
        LabelRCON.Visible = True
        LabelDebug0.Visible = True
        LabelDebug1.Visible = True
        LabelDebug2.Visible = True
        LabelDebug3.Visible = True
        LabelDebug4.Visible = True
        LabelDebug5.Visible = True
        LabelDebug6.Visible = True
        LabelDebug7.Visible = True
        LabelDebug8.Visible = True
        LabelDebug9.Visible = True
        LabelDebugA.Visible = True
        LabelDebugB.Visible = True
        LabelDebugC.Visible = True
        LabelDebugD.Visible = True
        LabelDebugE.Visible = True
        LabelDebugF.Visible = True
        LabelValueDebug0.Visible = True
        LabelValueDebug1.Visible = True
        LabelValueDebug2.Visible = True
        LabelValueDebug3.Visible = True
        LabelValueDebug4.Visible = True
        LabelValueDebug5.Visible = True
        LabelValueDebug6.Visible = True
        LabelValueDebug7.Visible = True
        LabelValueDebug8.Visible = True
        LabelValueDebug9.Visible = True
        LabelValueDebugA.Visible = True
        LabelValueDebugB.Visible = True
        LabelValueDebugC.Visible = True
        LabelValueDebugD.Visible = True
        LabelValueDebugE.Visible = True
        LabelValueDebugF.Visible = True

        LabelComputerTime.Visible = True
        LabelSyncMessageCntrlBits.Visible = True

        ButtonToggleResetDebug.Visible = True
        CheckBoxSyncBitF.Visible = True
        ButtonSetTime.Visible = True

        ButtonReloadECBDefaults.Visible = True
        ButtonZeroOnTime.Visible = True
        ButtonZeroPulseCounters.Visible = True
        Me.Size = New System.Drawing.Size(1280, 780)
        ButtonToggleMode.Visible = False
    End Sub

    Private Sub ButtonSaveFactorySettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveFactorySettings.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_SAVE_CURRENT_SETTINGS_TO_FACTORY_DEFAULT, 0, 0, 0)
    End Sub

    Private Sub ButtonLoadFactorySettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLoadFactorySettings.Click
        ServerSettings.put_modbus_commands(REGISTER_SYSTEM_LOAD_FACTORY_DEFAULTS_AND_REBOOT, 0, 0, 0)
    End Sub

    Private Sub ButtonReset_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReset.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_ECB_RESET_FAULTS, 0, 0, 0)
    End Sub

    Private Sub ButtonResetFPGA_Click(sender As System.Object, e As System.EventArgs)
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_GUN_DRIVER_RESET_FPGA, 0, 0, 0)
    End Sub


    Private Sub ButtonSetIPAddres_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetIPAddres.Click
        Dim ip_address_v4_upper As UInt16
        Dim ip_address_v4_lower As UInt16
        Dim val As UInt16
        Try
            val = TextBoxIP3.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_upper = val * 2 ^ 8

            val = TextBoxIP2.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_upper += val

            val = TextBoxIP1.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_lower += val * 2 ^ 8

            val = TextBoxIP0.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_lower += val


            ServerSettings.put_modbus_commands(REGISTER_IP_ADDRESS, ip_address_v4_upper, ip_address_v4_lower, 0)

        Catch ex As Exception
            MsgBox("Please enter valid data")
        End Try

    End Sub

    Private Sub ButtonSetRemoteIP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetRemoteIP.Click
        Dim ip_address_v4_upper As UInt16
        Dim ip_address_v4_lower As UInt16
        Dim val As UInt16
        Try
            val = TextBoxIP3.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_upper = val * 2 ^ 8

            val = TextBoxIP2.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_upper += val

            val = TextBoxIP1.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_lower += val * 2 ^ 8

            val = TextBoxIP0.Text
            If val >= 256 Then
                val = 0
            End If
            ip_address_v4_lower += val


            ServerSettings.put_modbus_commands(REGISTER_REMOTE_IP_ADDRESS, ip_address_v4_upper, ip_address_v4_lower, 0)
        Catch ex As Exception
            MsgBox("Please enter valid data")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        'ServerSettings.put_modbus_commands(REGISTER_DEBUG_POWER_CYCLE_TEST, 0, 0, 0)
    End Sub


    Private Sub TimerWatchdog_Tick(sender As System.Object, e As System.EventArgs) Handles TimerWatchdog.Tick
        SendAndValidateWatchdog()
    End Sub

    Private Sub ButtonETMMode_Click(sender As System.Object, e As System.EventArgs) Handles ButtonETMMode.Click
        ServerSettings.put_modbus_commands(REGISTER_SET_ACCESS_MODE_ETM, &H117F, 0, 0)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rev As UInt16
        Dim serial_num As UInt16
        Dim command_index As UInt16

        Try
            If board_index = MODBUS_COMMANDS.MODBUS_WR_ETHERNET Then
                command_index = ETM_CAN_ADDR_ETHERNET_BOARD
                selected_board_index = ETM_CAN_ADDR_ETHERNET_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP Then
                command_index = ETM_CAN_ADDR_ION_PUMP_BOARD
                selected_board_index = ETM_CAN_ADDR_ION_PUMP_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT Then
                command_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
                selected_board_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC Then
                command_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
                selected_board_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA Then
                command_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
                selected_board_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_AFC Then
                command_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
                selected_board_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING Then
                command_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
                selected_board_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET Then
                command_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
                selected_board_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
            ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER Then
                command_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
                selected_board_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
            End If


            rev = Asc(TextBoxRev.Text)
            serial_num = TextBoxSN.Text
            ServerSettings.put_modbus_commands(REGISTER_ETM_SET_REVISION_AND_SERIAL_NUMBER, selected_board_index, rev, serial_num)
        Catch ex As Exception
            MsgBox("Please enter valid data")
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h_num As UInt16
        Try
            h_num = TextBoxHNubmber.Text
            ServerSettings.put_modbus_commands(REGISTER_ECB_SYSTEM_SERIAL_NUMBER, h_num, h_num, h_num)
        Catch ex As Exception
            MsgBox("Please enter valid data")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ServerSettings.put_modbus_commands(REGISTER_SYSTEM_SAVE_CURRENT_SETTINGS_TO_CUSTOMER_SAVE, 0, 0, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ServerSettings.put_modbus_commands(REGISTER_SYSTEM_LOAD_CUSTOMER_SETTINGS_SAVE_AND_REBOOT, 0, 0, 0)
    End Sub
End Class