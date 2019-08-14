﻿Public Class frmMain

    Public Const REGISTER_NONE As UInt16 = &HFF0


    Public Const REGISTER_HVPS_SET_POINT_DOSE_0 As UInt16 = &H400
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_0 As UInt16 = &H401
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_0 As UInt16 = &H402
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_0 As UInt16 = &H403
    Public Const REGISTER_TRIGGER_SPARE_DOSE_0 As UInt16 = &H404
    Public Const REGISTER_TRIGGER_AFC_DOSE_0 As UInt16 = &H405
    Public Const REGISTER_TRIGGER_GRID_START_MIN_DOSE_0 As UInt16 = &H406
    Public Const REGISTER_TRIGGER_GRID_START_MAX_DOSE_0 As UInt16 = &H407
    Public Const REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_0 As UInt16 = &H408
    Public Const REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_0 As UInt16 = &H409
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_0 As UInt16 = &H40A
    Public Const REGISTER_SELF_TRIGGER_PRF_DOSE_0 As UInt16 = &H40B

    Public Const REGISTER_HVPS_SET_POINT_DOSE_1 As UInt16 = &H410
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_1 As UInt16 = &H411
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_1 As UInt16 = &H412
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_1 As UInt16 = &H413
    Public Const REGISTER_TRIGGER_SPARE_DOSE_1 As UInt16 = &H414
    Public Const REGISTER_TRIGGER_AFC_DOSE_1 As UInt16 = &H415
    Public Const REGISTER_TRIGGER_GRID_START_MIN_DOSE_1 As UInt16 = &H416
    Public Const REGISTER_TRIGGER_GRID_START_MAX_DOSE_1 As UInt16 = &H417
    Public Const REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_1 As UInt16 = &H418
    Public Const REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_1 As UInt16 = &H419
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_1 As UInt16 = &H41A
    Public Const REGISTER_SELF_TRIGGER_PRF_DOSE_1 As UInt16 = &H41B

    Public Const REGISTER_HVPS_SET_POINT_DOSE_2 As UInt16 = &H420
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_2 As UInt16 = &H421
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_2 As UInt16 = &H422
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_2 As UInt16 = &H423
    Public Const REGISTER_TRIGGER_SPARE_DOSE_2 As UInt16 = &H424
    Public Const REGISTER_TRIGGER_AFC_DOSE_2 As UInt16 = &H425
    Public Const REGISTER_TRIGGER_GRID_START_MIN_DOSE_2 As UInt16 = &H426
    Public Const REGISTER_TRIGGER_GRID_START_MAX_DOSE_2 As UInt16 = &H427
    Public Const REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_2 As UInt16 = &H428
    Public Const REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_2 As UInt16 = &H429
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_2 As UInt16 = &H42A
    Public Const REGISTER_SELF_TRIGGER_PRF_DOSE_2 As UInt16 = &H42B

    Public Const REGISTER_HVPS_SET_POINT_DOSE_3 As UInt16 = &H430
    Public Const REGISTER_ELECTROMAGNET_CURRENT_DOSE_3 As UInt16 = &H431
    Public Const REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_3 As UInt16 = &H432
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_3 As UInt16 = &H433
    Public Const REGISTER_TRIGGER_SPARE_DOSE_3 As UInt16 = &H434
    Public Const REGISTER_TRIGGER_AFC_DOSE_3 As UInt16 = &H435
    Public Const REGISTER_TRIGGER_GRID_START_MIN_DOSE_3 As UInt16 = &H436
    Public Const REGISTER_TRIGGER_GRID_START_MAX_DOSE_3 As UInt16 = &H437
    Public Const REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_3 As UInt16 = &H438
    Public Const REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_3 As UInt16 = &H439
    Public Const REGISTER_AFC_HOME_POSITION_DOSE_3 As UInt16 = &H43A
    Public Const REGISTER_SELF_TRIGGER_PRF_DOSE_3 As UInt16 = &H43B

    Public Const REGISTER_MAGNETRON_HEATER_CURRENT_DOSE_ALL As UInt16 = &H500
    Public Const REGISTER_GUN_DRIVER_HEATER_VOLTAGE_DOSE_ALL As UInt16 = &H501
    Public Const REGISTER_TRIGGER_HVPS_START_DOSE_ALL As UInt16 = &H502
    Public Const REGISTER_TRIGGER_HVPS_STOP_DOSE_ALL As UInt16 = &H503
    Public Const REGISTER_TRIGGER_PFN_DOSE_ALL As UInt16 = &H504
    Public Const REGISTER_TRIGGER_MAGNETRON_AND_TARGET_CURRENT_START_DOSE_ALL As UInt16 = &H505
    Public Const REGISTER_TRIGGER_MAGNETRON_AND_TARGET_CURRENT_STOP_DOSE_ALL As UInt16 = &H506
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
    Public Const REGISTER_ETM_SYSTEM_SERIAL_NUMBER As UInt16 = &H1202
    Public Const REGISTER_DEBUG_GUN_DRIVER_RESET_FPGA As UInt16 = &H1203
    Public Const REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT As UInt16 = &H1204
    Public Const REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON As UInt16 = &H1205
    Public Const REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT As UInt16 = &H1206
    Public Const REGISTER_ETM_SET_REVISION_AND_SERIAL_NUMBER As UInt16 = &H1207
    Public Const REGISTER_ETM_SAVE_CURRENT_SETTINGS_TO_FACTORY_DEFAULT As UInt16 = &H1208
    Public Const REGISTER_ETM_SLAVE_LOAD_DEFAULT_CALIBRATION As UInt16 = &H1209
    Public Const REGISTER_DEBUG_SET_RAM_DEBUG As UInt16 = &H1210
    Public Const REGISTER_DEBUG_SET_EEPROM_DEBUG As UInt16 = &H1211
    Public Const REGISTER_ETM_SLAVE_SET_CALIBRATION_PAIR As UInt16 = &H1212
    Public Const REGISTER_ETM_CLEAR_DEBUG As UInt16 = &H1213
  
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

    Public board_can_address As Byte


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
        'Splitter1.BackColor = Color.Coral

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version not Available in Debug Mode"
        End If






#If 0 Then

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
            CbxSlaveStatusCntrl0.Visible = False
            CbxSlaveStatusCntrl1.Visible = False
            CbxSlaveStatusCntrl2.Visible = False
            CbxSlaveStatusCntrl3.Visible = False
            CbxSlaveStatusCntrl4.Visible = False
            CbxSlaveStatusCntrl5.Visible = False
            CbxSlaveStatusCntrl6.Visible = False
            CbxSlaveStatusCntrl7.Visible = False
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

#End If

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
        ServerSettings.board_to_monitor = CByte(board_can_address)

        ivalue = ServerSettings.get_modbus_status()
        If (ivalue <= 2) Then
            connected = False
            Me.Text = "A36507 Test GUI(Linac Disconnected)"
            Me.BackColor = Color.LightCoral
            CbxConnect10.Checked = True
            'Splitter1.BackColor = Color.Coral
        Else
            connected = True
            ServerSettings.event_log_enabled = True
            Me.Text = "A36507 Test GUI"
            CbxConnect10.Checked = False
            'Splitter1.BackColor = Color.LightSteelBlue


            ' ------------------------------------------------------------------------------------------------------------'
            ' Display System Data in the left pane
            DisplayLeftPane()

            ' ------------------------------------------------------------------------------------------------------------'
            ' UDisplay the board specific data and buttons in the right plane
            DisplayBoardCommonElements(board_can_address)
            DisplayBoardSpecificData(board_can_address)
            ' DisplayDebugData()

        End If ' connected

        TimerUpdate.Enabled = True

    End Sub


    Private Sub DisplayBoardCommonElements(ByVal selected_baord As Byte)
        Dim control_bits As UInt16
        Dim fault_bits As UInt16
        Dim logged_bits As UInt16
        Dim not_logged_bits As UInt16

        LabelECBState.Text = "0x" & Hex(ServerSettings.ETMEthernetECBLoggingData.control_state)


        CbxReady0.Checked = (ServerSettings.ETMEthernetBoardLoggingData(0).control_notice_bits And &H1)
        CbxConnect0.Checked = (ServerSettings.ETMEthernetBoardLoggingData(0).connection_timeout)
        CbxConnect0.Text = CoBoxSelectedCanBoard.Items.Item(0)

        CbxReady1.Checked = (ServerSettings.ETMEthernetBoardLoggingData(1).control_notice_bits And &H1)
        CbxConnect1.Checked = (ServerSettings.ETMEthernetBoardLoggingData(1).connection_timeout)
        CbxConnect1.Text = CoBoxSelectedCanBoard.Items.Item(1)

        CbxReady2.Checked = (ServerSettings.ETMEthernetBoardLoggingData(2).control_notice_bits And &H1)
        CbxConnect2.Checked = ServerSettings.ETMEthernetBoardLoggingData(2).connection_timeout
        CbxConnect2.Text = CoBoxSelectedCanBoard.Items.Item(2)

        CbxReady3.Checked = (ServerSettings.ETMEthernetBoardLoggingData(3).control_notice_bits And &H1)
        CbxConnect3.Checked = ServerSettings.ETMEthernetBoardLoggingData(3).connection_timeout
        CbxConnect3.Text = CoBoxSelectedCanBoard.Items.Item(3)

        CbxReady4.Checked = (ServerSettings.ETMEthernetBoardLoggingData(4).control_notice_bits And &H1)
        CbxConnect4.Checked = ServerSettings.ETMEthernetBoardLoggingData(4).connection_timeout
        CbxConnect4.Text = CoBoxSelectedCanBoard.Items.Item(4)

        CbxReady5.Checked = (ServerSettings.ETMEthernetBoardLoggingData(5).control_notice_bits And &H1)
        CbxConnect5.Checked = ServerSettings.ETMEthernetBoardLoggingData(5).connection_timeout
        CbxConnect5.Text = CoBoxSelectedCanBoard.Items.Item(5)

        CbxReady6.Checked = (ServerSettings.ETMEthernetBoardLoggingData(6).control_notice_bits And &H1)
        CbxConnect6.Checked = ServerSettings.ETMEthernetBoardLoggingData(6).connection_timeout
        CbxConnect6.Text = CoBoxSelectedCanBoard.Items.Item(6)

        CbxReady7.Checked = (ServerSettings.ETMEthernetBoardLoggingData(7).control_notice_bits And &H1)
        CbxConnect7.Checked = ServerSettings.ETMEthernetBoardLoggingData(7).connection_timeout
        CbxConnect7.Text = CoBoxSelectedCanBoard.Items.Item(7)

        CbxReady8.Checked = (ServerSettings.ETMEthernetBoardLoggingData(8).control_notice_bits And &H1)
        CbxConnect8.Checked = ServerSettings.ETMEthernetBoardLoggingData(8).connection_timeout
        CbxConnect8.Text = CoBoxSelectedCanBoard.Items.Item(8)

        CbxReady9.Checked = (ServerSettings.ETMEthernetBoardLoggingData(9).control_notice_bits And &H1)
        CbxConnect9.Checked = ServerSettings.ETMEthernetBoardLoggingData(9).connection_timeout
        CbxConnect9.Text = CoBoxSelectedCanBoard.Items.Item(9)

        CbxReady10.Checked = (ServerSettings.ETMEthernetECBLoggingData.control_notice_bits And &H1)
        CbxConnect10.Text = CoBoxSelectedCanBoard.Items.Item(10)

        If (board_can_address < 10) Then

            LabelAgileInfo.Text = "A" & ServerSettings.ETMEthernetBoardLoggingData(board_can_address).agile_number & "-" &
                Format(ServerSettings.ETMEthernetBoardLoggingData(board_can_address).agile_dash, "000") & "  Rev-" &
                Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_can_address).agile_rev_ascii >> 8) &
                Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_can_address).agile_rev_ascii Mod 256) &
                "  SN-" &
                ServerSettings.ETMEthernetBoardLoggingData(board_can_address).serial_number 'Dparker need to add in the first Char
            LabelFirmwareVerssion.Text = "Firmware Version " &
                ServerSettings.ETMEthernetBoardLoggingData(board_can_address).firmware_agile_rev & "." &
                ServerSettings.ETMEthernetBoardLoggingData(board_can_address).firmware_branch & "." &
                ServerSettings.ETMEthernetBoardLoggingData(board_can_address).firmware_branch_rev


            control_bits = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).control_notice_bits
            fault_bits = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).fault_bits
            logged_bits = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).logged_bits
            not_logged_bits = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).not_logged_bits


            LblSlaveLogValue0.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(0)
            LblSlaveLogValue1.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(1)
            LblSlaveLogValue2.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(2)
            LblSlaveLogValue3.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(3)
            LblSlaveLogValue4.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(4)
            LblSlaveLogValue5.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(5)
            LblSlaveLogValue6.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(6)
            LblSlaveLogValue7.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(7)
            LblSlaveLogValue8.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(8)
            LblSlaveLogValue9.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(9)
            LblSlaveLogValue10.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(10)
            LblSlaveLogValue11.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(11)
            LblSlaveLogValue12.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(12)
            LblSlaveLogValue13.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(13)
            LblSlaveLogValue14.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(14)
            LblSlaveLogValue15.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(15)
            LblSlaveLogValue16.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(16)
            LblSlaveLogValue17.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(17)
            LblSlaveLogValue18.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(18)
            LblSlaveLogValue19.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(19)
            LblSlaveLogValue20.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(20)
            LblSlaveLogValue21.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(21)
            LblSlaveLogValue22.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(22)
            LblSlaveLogValue23.Text = ServerSettings.ETMEthernetBoardLoggingData(board_can_address).log_data(23)

        Else
            ' Display Ethernet Data
            LabelAgileInfo.Text = "A" & ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_number_low_word & "-" &
                Format(ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_dash_number, "000") & "  Rev-" &
                 Convert.ToChar(ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_rev_ASCII_x2 >> 8) &
                 Convert.ToChar(ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_rev_ASCII_x2 Mod 256) &
                 "  SN-" & (ServerSettings.ETMEthernetECBLoggingData.config.ecb_serial_number_high_word * 2 ^ 16 + ServerSettings.ETMEthernetECBLoggingData.config.ecb_serial_number_low_word) &
                 " SYSTEM Num " & Convert.ToChar(ServerSettings.ETMEthernetECBLoggingData.config.system_serial_letter Mod 256) &
                 (ServerSettings.ETMEthernetECBLoggingData.config.system_serial_number_high_word * 2 ^ 16 + ServerSettings.ETMEthernetECBLoggingData.config.system_serial_number_low_word)

            LabelFirmwareVerssion.Text = "Firmware Version " &
                ServerSettings.ETMEthernetECBLoggingData.config.firmware_agile_rev & "." &
                ServerSettings.ETMEthernetECBLoggingData.config.firmware_branch & "." &
                ServerSettings.ETMEthernetECBLoggingData.config.firmware_branch_rev


            control_bits = ServerSettings.ETMEthernetECBLoggingData.control_notice_bits
            fault_bits = ServerSettings.ETMEthernetECBLoggingData.fault_bits
            logged_bits = ServerSettings.ETMEthernetECBLoggingData.logged_bits
            not_logged_bits = ServerSettings.ETMEthernetECBLoggingData.not_logged_bits

            LblSlaveLogValue0.Text = ServerSettings.ETMEthernetECBLoggingData.system_counter.powered_seconds
            LblSlaveLogValue1.Text = ServerSettings.ETMEthernetECBLoggingData.system_counter.hv_on_seconds
            LblSlaveLogValue2.Text = ServerSettings.ETMEthernetECBLoggingData.system_counter.xray_on_seconds
            LblSlaveLogValue3.Text = ServerSettings.ETMEthernetECBLoggingData.system_counter.arc_counter
            LblSlaveLogValue4.Text = ServerSettings.ETMEthernetECBLoggingData.system_counter.pulse_counter
            LblSlaveLogValue5.Text = ServerSettings.ETMEthernetECBLoggingData.thyraton_warmup
            LblSlaveLogValue6.Text = ServerSettings.ETMEthernetECBLoggingData.gun_heater_warmup
            LblSlaveLogValue7.Text = ServerSettings.ETMEthernetECBLoggingData.magnetron_heater_warmup



            LblSlaveLogValue8.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_number_high_word
            LblSlaveLogValue9.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_number_low_word
            LblSlaveLogValue10.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_dash_number
            LblSlaveLogValue11.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_agile_rev_ASCII_x2
            LblSlaveLogValue12.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_serial_number_high_word
            LblSlaveLogValue13.Text = ServerSettings.ETMEthernetECBLoggingData.config.ecb_serial_number_low_word
            LblSlaveLogValue14.Text = ServerSettings.ETMEthernetECBLoggingData.config.firmware_agile_rev
            LblSlaveLogValue15.Text = ServerSettings.ETMEthernetECBLoggingData.config.firmware_branch
            LblSlaveLogValue16.Text = ServerSettings.ETMEthernetECBLoggingData.config.firmware_branch_rev

        End If

        CbxSlaveStatusCntrl0.Checked = control_bits And &H1
        CbxSlaveStatusCntrl1.Checked = control_bits And &H2
        CbxSlaveStatusCntrl2.Checked = control_bits And &H4
        CbxSlaveStatusCntrl3.Checked = control_bits And &H8
        CbxSlaveStatusCntrl4.Checked = control_bits And &H10
        CbxSlaveStatusCntrl5.Checked = control_bits And &H20
        CbxSlaveStatusCntrl6.Checked = control_bits And &H40
        CbxSlaveStatusCntrl7.Checked = control_bits And &H80
        CbxSlaveStatusNotice0.Checked = control_bits And &H100
        CbxSlaveStatusNotice1.Checked = control_bits And &H200
        CbxSlaveStatusNotice2.Checked = control_bits And &H400
        CbxSlaveStatusNotice3.Checked = control_bits And &H800
        CbxSlaveStatusNotice4.Checked = control_bits And &H1000
        CbxSlaveStatusNotice5.Checked = control_bits And &H2000
        CbxSlaveStatusNotice6.Checked = control_bits And &H4000
        CbxSlaveStatusNotice7.Checked = control_bits And &H8000

        CbxSlaveStatusFault0.Checked = fault_bits And &H1
        CbxSlaveStatusFault1.Checked = fault_bits And &H2
        CbxSlaveStatusFault2.Checked = fault_bits And &H4
        CbxSlaveStatusFault3.Checked = fault_bits And &H8
        CbxSlaveStatusFault4.Checked = fault_bits And &H10
        CbxSlaveStatusFault5.Checked = fault_bits And &H20
        CbxSlaveStatusFault6.Checked = fault_bits And &H40
        CbxSlaveStatusFault7.Checked = fault_bits And &H80
        CbxSlaveStatusFault8.Checked = fault_bits And &H100
        CbxSlaveStatusFault9.Checked = fault_bits And &H200
        CbxSlaveStatusFaultA.Checked = fault_bits And &H400
        CbxSlaveStatusFaultB.Checked = fault_bits And &H800
        CbxSlaveStatusFaultC.Checked = fault_bits And &H1000
        CbxSlaveStatusFaultD.Checked = fault_bits And &H2000
        CbxSlaveStatusFaultE.Checked = fault_bits And &H4000
        CbxSlaveStatusFaultF.Checked = fault_bits And &H8000

        CbxSlaveStatusLogged0.Checked = logged_bits And &H1
        CbxSlaveStatusLogged1.Checked = logged_bits And &H2
        CbxSlaveStatusLogged2.Checked = logged_bits And &H4
        CbxSlaveStatusLogged3.Checked = logged_bits And &H8
        CbxSlaveStatusLogged4.Checked = logged_bits And &H10
        CbxSlaveStatusLogged5.Checked = logged_bits And &H20
        CbxSlaveStatusLogged6.Checked = logged_bits And &H40
        CbxSlaveStatusLogged7.Checked = logged_bits And &H80
        CbxSlaveStatusLogged8.Checked = logged_bits And &H100
        CbxSlaveStatusLogged9.Checked = logged_bits And &H200
        CbxSlaveStatusLoggedA.Checked = logged_bits And &H400
        CbxSlaveStatusLoggedB.Checked = logged_bits And &H800
        CbxSlaveStatusLoggedC.Checked = logged_bits And &H1000
        CbxSlaveStatusLoggedD.Checked = logged_bits And &H2000
        CbxSlaveStatusLoggedE.Checked = logged_bits And &H4000
        CbxSlaveStatusLoggedF.Checked = logged_bits And &H8000


        CbxSlaveStatusNotLogged0.Checked = not_logged_bits And &H1
        CbxSlaveStatusNotLogged1.Checked = not_logged_bits And &H2
        CbxSlaveStatusNotLogged2.Checked = not_logged_bits And &H4
        CbxSlaveStatusNotLogged3.Checked = not_logged_bits And &H8
        CbxSlaveStatusNotLogged4.Checked = not_logged_bits And &H10
        CbxSlaveStatusNotLogged5.Checked = not_logged_bits And &H20
        CbxSlaveStatusNotLogged6.Checked = not_logged_bits And &H40
        CbxSlaveStatusNotLogged7.Checked = not_logged_bits And &H80
        CbxSlaveStatusNotLogged8.Checked = not_logged_bits And &H100
        CbxSlaveStatusNotLogged9.Checked = not_logged_bits And &H200
        CbxSlaveStatusNotLoggedA.Checked = not_logged_bits And &H400
        CbxSlaveStatusNotLoggedB.Checked = not_logged_bits And &H800
        CbxSlaveStatusNotLoggedC.Checked = not_logged_bits And &H1000
        CbxSlaveStatusNotLoggedD.Checked = not_logged_bits And &H2000
        CbxSlaveStatusNotLoggedE.Checked = not_logged_bits And &H4000
        CbxSlaveStatusNotLoggedF.Checked = not_logged_bits And &H8000


        LblDebugReg0.Text = "Debug_0 = " & ServerSettings.ETMEthernetDebugData.debug_0
        LblDebugReg1.Text = "Debug_1 = " & ServerSettings.ETMEthernetDebugData.debug_1
        LblDebugReg2.Text = "Debug_2 = " & ServerSettings.ETMEthernetDebugData.debug_2
        LblDebugReg3.Text = "Debug_3 = " & ServerSettings.ETMEthernetDebugData.debug_3
        LblDebugReg4.Text = "Debug_4 = " & ServerSettings.ETMEthernetDebugData.debug_4
        LblDebugReg5.Text = "Debug_5 = " & ServerSettings.ETMEthernetDebugData.debug_5
        LblDebugReg6.Text = "Debug_6 = " & ServerSettings.ETMEthernetDebugData.debug_6
        LblDebugReg7.Text = "Debug_7 = " & ServerSettings.ETMEthernetDebugData.debug_7
        LblDebugReg8.Text = "Debug_8 = " & ServerSettings.ETMEthernetDebugData.debug_8
        LblDebugReg9.Text = "Debug_9 = " & ServerSettings.ETMEthernetDebugData.debug_9
        LblDebugRegA.Text = "Debug_A = " & ServerSettings.ETMEthernetDebugData.debug_A
        LblDebugRegB.Text = "Debug_B = " & ServerSettings.ETMEthernetDebugData.debug_B
        LblDebugRegC.Text = "Debug_C = " & ServerSettings.ETMEthernetDebugData.debug_C
        LblDebugRegD.Text = "Debug_D = " & ServerSettings.ETMEthernetDebugData.debug_D
        LblDebugRegE.Text = "Debug_E = " & ServerSettings.ETMEthernetDebugData.debug_E
        LblDebugRegF.Text = "Debug_F = " & ServerSettings.ETMEthernetDebugData.debug_F

        LblDebugCan0.Text = "CAN_TX_0 = " & ServerSettings.ETMEthernetDebugData.can_tx_0
        LblDebugCan1.Text = "CAN_TX_1 = " & ServerSettings.ETMEthernetDebugData.can_tx_1
        LblDebugCan2.Text = "CAN_TX_2 = " & ServerSettings.ETMEthernetDebugData.can_tx_2
        LblDebugCan3.Text = "CXEC_MAX = " & ServerSettings.ETMEthernetDebugData.CXEC_reg_max
        LblDebugCan4.Text = "RX 0_FILT_0 = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_0
        LblDebugCan5.Text = "RX_0_FILT_1 = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_1
        LblDebugCan6.Text = "RX_1_FILT_2 = " & ServerSettings.ETMEthernetDebugData.can_rx_1_filt_2
        LblDebugCan7.Text = "CXINTF_MAX = " & ServerSettings.ETMEthernetDebugData.CXINTF_max
        LblDebugCan8.Text = "UNKNOWN_ID = " & ServerSettings.ETMEthernetDebugData.can_unknown_msg_id
        LblDebugCan9.Text = "INVALID_IDX = " & ServerSettings.ETMEthernetDebugData.can_invalid_index
        LblDebugCanA.Text = "ADDR_ERR = " & ServerSettings.ETMEthernetDebugData.can_address_error
        LblDebugCanB.Text = "ERR_FLAG = " & ServerSettings.ETMEthernetDebugData.can_error_flag
        LblDebugCanC.Text = "TX_BUF_OF = " & ServerSettings.ETMEthernetDebugData.can_tx_buf_overflow
        LblDebugCanD.Text = "RX_BUF_OF = " & ServerSettings.ETMEthernetDebugData.can_rx_buf_overflow
        LblDebugCanE.Text = "RX_LOG_OF = " & ServerSettings.ETMEthernetDebugData.can_rx_log_buf_overflow
        LblDebugCanF.Text = "TIMEOUT = " & ServerSettings.ETMEthernetDebugData.can_timeout

        LblDebugEEprom0.Text = "Int Rd Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_internal_read_count
        LblDebugEEprom1.Text = "Int Rd Err = " & ServerSettings.ETMEthernetDebugData.eeprom_internal_read_error
        LblDebugEEprom2.Text = "Int Wr Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_internal_write_count
        LblDebugEEprom3.Text = "Int Wr Err = " & ServerSettings.ETMEthernetDebugData.eeprom_internal_write_error
        LblDebugEEprom4.Text = "I2C Rd Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_i2c_read_count
        LblDebugEEprom5.Text = "I2C Rd Err = " & ServerSettings.ETMEthernetDebugData.eeprom_i2c_read_error
        LblDebugEEprom6.Text = "I2C Wr Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_i2c_write_count
        LblDebugEEprom7.Text = "I2C Wr Err = " & ServerSettings.ETMEthernetDebugData.eeprom_i2c_write_error
        LblDebugEEprom8.Text = "SPI Rd Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_spi_read_count
        LblDebugEEprom9.Text = "SPI Rd Err = " & ServerSettings.ETMEthernetDebugData.eeprom_spi_read_error
        LblDebugEEprom10.Text = "SPI Wr Cnt = " & ServerSettings.ETMEthernetDebugData.eeprom_spi_write_count
        LblDebugEEprom11.Text = "SPI Wr Err = " & ServerSettings.ETMEthernetDebugData.eeprom_spi_write_error
        LblDebugEEprom12.Text = "EEPROM CRC = " & ServerSettings.ETMEthernetDebugData.eeprom_crc_error_count
        LblDebugEEprom13.Text = "CMD Invalid Idx = " & ServerSettings.ETMEthernetDebugData.cmd_data_register_read_invalid_index
        LblDebugEEprom14.Text = "TBD 17 = " & ServerSettings.ETMEthernetDebugData.debugging_tbd_17
        LblDebugEEprom15.Text = "TBD 16 = " & ServerSettings.ETMEthernetDebugData.debugging_tbd_16

        LblDebugSystem0.Text = "Reset Cnt = " & ServerSettings.ETMEthernetDebugData.reset_count
        LblDebugSystem1.Text = "RCON = " & ServerSettings.ETMEthernetDebugData.RCON_value
        LblDebugSystem2.Text = "Can Ver = " & ServerSettings.ETMEthernetDebugData.can_build_version
        LblDebugSystem3.Text = "Lib Ver = " & ServerSettings.ETMEthernetDebugData.library_build_version
        LblDebugSystem4.Text = "I2C Err = " & ServerSettings.ETMEthernetDebugData.i2c_bus_error_count
        LblDebugSystem5.Text = "SPI Err = " & ServerSettings.ETMEthernetDebugData.spi_bus_error_count
        LblDebugSystem6.Text = "Scale Err = " & ServerSettings.ETMEthernetDebugData.scale_error_count
        LblDebugSystem7.Text = "Self Test = " & ServerSettings.ETMEthernetDebugData.self_test_results

        LblDebug0.Text = "RAM A = " & ServerSettings.ETMEthernetDebugData.ram_monitor_a
        LblDebug1.Text = "RAM B = " & ServerSettings.ETMEthernetDebugData.ram_monitor_b
        LblDebug2.Text = "RAM C = " & ServerSettings.ETMEthernetDebugData.ram_monitor_c
        LblDebug3.Text = "EEPROM = 0x" & Hex(ServerSettings.ETMEthernetDebugData.eeprom_read_result)
        LblDebug4.Text = "5V = " & ServerSettings.ETMEthernetDebugData.analog_1_nominal_5V
        LblDebug5.Text = "+15 = " & ServerSettings.ETMEthernetDebugData.analog_2_nominal_pos_15
        LblDebug6.Text = "-15 = " & ServerSettings.ETMEthernetDebugData.analog_3_nominal_neg_15
        LblDebug7.Text = "24 = " & ServerSettings.ETMEthernetDebugData.analog_4_nominal_24


        LblDebugCal0IntGain.Text = "Cal 0 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_0_internal_gain / 2 ^ 15
        LblDebugCal0IntOffset.Text = "Cal 0 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_0_internal_offset
        LblDebugCal0ExtGain.Text = "Cal 0 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_0_external_gain / 2 ^ 15
        LblDebugCal0ExtOffset.Text = "Cal 0 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_0_external_offset

        LblDebugCal1IntGain.Text = "Cal 1 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_1_internal_gain / 2 ^ 15
        LblDebugCal1IntOffset.Text = "Cal 1 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_1_internal_offset
        LblDebugCal1ExtGain.Text = "Cal 1 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_1_external_gain / 2 ^ 15
        LblDebugCal1ExtOffset.Text = "Cal 1 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_1_external_offset

        LblDebugCal2IntGain.Text = "Cal 2 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_2_internal_gain / 2 ^ 15
        LblDebugCal2IntOffset.Text = "Cal 2 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_2_internal_offset
        LblDebugCal2ExtGain.Text = "Cal 2 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_2_external_gain / 2 ^ 15
        LblDebugCal2ExtOffset.Text = "Cal 2 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_2_external_offset

        LblDebugCal3IntGain.Text = "Cal 3 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_3_internal_gain / 2 ^ 15
        LblDebugCal3IntOffset.Text = "Cal 3 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_3_internal_offset
        LblDebugCal3ExtGain.Text = "Cal 3 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_3_external_gain / 2 ^ 15
        LblDebugCal3ExtOffset.Text = "Cal 3 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_3_external_offset

        LblDebugCal4IntGain.Text = "Cal 4 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_4_internal_gain / 2 ^ 15
        LblDebugCal4IntOffset.Text = "Cal 4 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_4_internal_offset
        LblDebugCal4ExtGain.Text = "Cal 4 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_4_external_gain / 2 ^ 15
        LblDebugCal4ExtOffset.Text = "Cal 4 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_4_external_offset

        LblDebugCal5IntGain.Text = "Cal 5 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_5_internal_gain / 2 ^ 15
        LblDebugCal5IntOffset.Text = "Cal 5 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_5_internal_offset
        LblDebugCal5ExtGain.Text = "Cal 5 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_5_external_gain / 2 ^ 15
        LblDebugCal5ExtOffset.Text = "Cal 5 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_5_external_offset

        LblDebugCal6IntGain.Text = "Cal 6 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_6_internal_gain / 2 ^ 15
        LblDebugCal6IntOffset.Text = "Cal 6 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_6_internal_offset
        LblDebugCal6ExtGain.Text = "Cal 6 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_6_external_gain / 2 ^ 15
        LblDebugCal6ExtOffset.Text = "Cal 6 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_6_external_offset

        LblDebugCal7IntGain.Text = "Cal 7 IG = " & ServerSettings.ETMEthernetDebugData.calibartion_7_internal_gain / 2 ^ 15
        LblDebugCal7IntOffset.Text = "Cal 7 IO= " & ServerSettings.ETMEthernetDebugData.calibartion_7_internal_offset
        LblDebugCal7ExtGain.Text = "Cal 7 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_7_external_gain / 2 ^ 15
        LblDebugCal7ExtOffset.Text = "Cal 7 EO = " & ServerSettings.ETMEthernetDebugData.calibartion_7_external_offset
        ' ADD Cal 1-7 once this is working properly

        If ServerSettings.ETMEthernetBoardLoggingData(board_can_address).connection_timeout Then
            LabelBoardStatus.Text = "NOT CONNECTED!!!"
            Me.BackColor = Color.LightCoral
        Else
            LabelBoardStatus.Text = "Connected"
            Me.BackColor = SystemColors.Control
        End If

        BtnHVPSDose0.Text = "HVPS = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.hvps_set_point / 1000 & " KV"
        BtnMagnetCurrentDose0.Text = "Magnet = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.electromagnet_set_point / 1000 & " Amps"
        BtnPulseTopDose0.Text = "Grid = " & ((ServerSettings.ETMEthernetECBLoggingData.dose_level_0.gun_driver_pulse_top_voltage / 100) - 80) & " Volts"
        BtnGunCathodeDose0.Text = "Gun Ek = -" & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.gun_driver_cathode_voltage / 1000 & " KV"
        BtnSpareTriggerDelayDose0.Text = "Spare Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_delay_spare & " nS"
        BtnAFCTriggerDelayDose0.Text = "AFC Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_delay_afc & " nS"
        BtnGrideStartMinDose0.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_grid_start_min_dose & " nS"
        BtnGrideStartMaxDose0.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_grid_start_max_dose & " nS"
        BtnGrideStopMinDose0.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_grid_stop_min_dose & " nS"
        BtnGrideStopMaxDose0.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.trigger_grid_stop_max_dose & " nS"
        BtnAFCHomeDose0.Text = "AFC Home = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.afc_home_poistion
        BtnPRFDose0.Text = "PRF = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.self_trigger_prf / 50 & " Hz"
        BtnUnused2Dose0.Text = "Unused 2 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.unused_2
        BtnUnused1Dose0.Text = "Unused 1 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.unused_1
        BtnUnused0Dose0.Text = "Unused 0 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_0.unused_0

        BtnHVPSDose1.Text = "HVPS = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.hvps_set_point / 1000 & " KV"
        BtnMagnetCurrentDose1.Text = "Magnet = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.electromagnet_set_point / 1000 & " Amps"
        BtnPulseTopDose1.Text = "Grid = " & ((ServerSettings.ETMEthernetECBLoggingData.dose_level_1.gun_driver_pulse_top_voltage / 100) - 80) & " Volts"
        BtnGunCathodeDose1.Text = "Gun Ek = -" & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.gun_driver_cathode_voltage / 1000 & " KV"
        BtnSpareTriggerDelayDose1.Text = "Spare Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_delay_spare & " nS"
        BtnAFCTriggerDelayDose1.Text = "AFC Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_delay_afc & " nS"
        BtnGrideStartMinDose1.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_grid_start_min_dose & " nS"
        BtnGrideStartMaxDose1.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_grid_start_max_dose & " nS"
        BtnGrideStopMinDose1.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_grid_stop_min_dose & " nS"
        BtnGrideStopMaxDose1.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.trigger_grid_stop_max_dose & " nS"
        BtnAFCHomeDose1.Text = "AFC Home = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.afc_home_poistion
        BtnPRFDose1.Text = "PRF = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.self_trigger_prf / 50 & " Hz"
        BtnUnused2Dose1.Text = "Unused 2 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.unused_2
        BtnUnused1Dose1.Text = "Unused 1 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.unused_1
        BtnUnused0Dose1.Text = "Unused 0 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_1.unused_0

        BtnHVPSDose2.Text = "HVPS = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.hvps_set_point / 1000 & " KV"
        BtnMagnetCurrentDose2.Text = "Magnet = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.electromagnet_set_point / 1000 & " Amps"
        BtnPulseTopDose2.Text = "Grid = " & ((ServerSettings.ETMEthernetECBLoggingData.dose_level_2.gun_driver_pulse_top_voltage / 100) - 80) & " Volts"
        BtnGunCathodeDose2.Text = "Gun Ek = -" & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.gun_driver_cathode_voltage / 1000 & " KV"
        BtnSpareTriggerDelayDose2.Text = "Spare Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_delay_spare & " nS"
        BtnAFCTriggerDelayDose2.Text = "AFC Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_delay_afc & " nS"
        BtnGrideStartMinDose2.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_grid_start_min_dose & " nS"
        BtnGrideStartMaxDose2.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_grid_start_max_dose & " nS"
        BtnGrideStopMinDose2.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_grid_stop_min_dose & " nS"
        BtnGrideStopMaxDose2.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.trigger_grid_stop_max_dose & " nS"
        BtnAFCHomeDose2.Text = "AFC Home = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.afc_home_poistion
        BtnPRFDose2.Text = "PRF = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.self_trigger_prf / 50 & " Hz"
        BtnUnused2Dose2.Text = "Unused 2 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.unused_2
        BtnUnused1Dose2.Text = "Unused 1 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.unused_1
        BtnUnused0Dose2.Text = "Unused 0 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_2.unused_0

        BtnHVPSDose3.Text = "HVPS = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.hvps_set_point / 1000 & " KV"
        BtnMagnetCurrentDose3.Text = "Magnet = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.electromagnet_set_point / 1000 & " Amps"
        BtnPulseTopDose3.Text = "Grid = " & ((ServerSettings.ETMEthernetECBLoggingData.dose_level_3.gun_driver_pulse_top_voltage / 100) - 80) & " Volts"
        BtnGunCathodeDose3.Text = "Gun Ek = -" & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.gun_driver_cathode_voltage / 1000 & " KV"
        BtnSpareTriggerDelayDose3.Text = "Spare Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_delay_spare & " nS"
        BtnAFCTriggerDelayDose3.Text = "AFC Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_delay_afc & " nS"
        BtnGrideStartMinDose3.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_grid_start_min_dose & " nS"
        BtnGrideStartMaxDose3.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_grid_start_max_dose & " nS"
        BtnGrideStopMinDose3.Text = "Grid Start Min = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_grid_stop_min_dose & " nS"
        BtnGrideStopMaxDose3.Text = "Grid Start Max = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.trigger_grid_stop_max_dose & " nS"
        BtnAFCHomeDose3.Text = "AFC Home = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.afc_home_poistion
        BtnPRFDose3.Text = "PRF = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.self_trigger_prf / 50 & " Hz"
        BtnUnused2Dose3.Text = "Unused 2 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.unused_2
        BtnUnused1Dose3.Text = "Unused 1 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.unused_1
        BtnUnused0Dose3.Text = "Unused 0 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_3.unused_0


        BtnMagnetronHeater.Text = "Mag Heater = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.magnetron_heater_current_at_standby / 1000 & " Amps"
        BtnGunHeater.Text = "Gun Heater =  " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.gun_driver_heater_voltage / 1000 & " Amps"
        BtnHVPSTrigStart.Text = "HVPS Trig Start = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.trigger_hvps_start & " nS"
        BtnHVPSTrigStop.Text = "HVPS Trig Stop = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.trigger_hvps_stop & " nS"
        BtnPFNTriggerDelay.Text = "PFN Trig Delay = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.trigger_pfn & " nS"
        BtnSampleTriggerStart.Text = "Sample Start = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.trigger_magnetron_and_target_current_start & " nS"
        BtnSampleTriggerStop.Text = "Sample Stop = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.trigger_magnetron_and_target_current_stop & " nS"
        BtnXrayRunTime.Text = "XRay Run Time = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.x_ray_run_time_in_automated_mode & " Seconds"
        BtnGunBias.Text = "Gun Bias = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.gun_driver_bias_voltage / -100 & " Volts"
        BtnAFCAuxControl.Text = "AFC Aux = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.afc_aux_control_or_offset
        BtnAFCManualPostion.Text = "AFC Manual Pos = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.afc_manual_target_position
        BtnUnused3DoseAll.Text = "Unused 3 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.unused_3
        BtnUnused2DoseAll.Text = "Unused 2 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.unused_2
        BtnUnused1DoseAll.Text = "Unused 1 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.unused_1
        BtnUnused0DoseAll.Text = "Unused 0 = " & ServerSettings.ETMEthernetECBLoggingData.dose_level_all.unused_0




    End Sub

    Private Sub DisplayBoardSpecificData(ByVal selected_baord As Byte)



        Dim selected_board_connected As Boolean = False
#If (0) Then

        ElseIf (board_can_address = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
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
            LabelValue5.Text = "Imon = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(5) / 1000 & " A"
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


#End If








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


#If 0 Then
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

#End If
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



    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            TimerUpdate.Enabled = False
            ServerSettings.Close()
        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormClosed  " + ex.ToString)
        End Try

    End Sub



#If 0 Then



    Public Const ETM_CAN_ADDR_ETHERNET_BOARD = 14
    Public Const ETM_CAN_ADDR_ION_PUMP_BOARD = 1
    Public Const ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD = 2
    Public Const ETM_CAN_ADDR_PULSE_SYNC_BOARD = 3
    Public Const ETM_CAN_ADDR_HV_LAMBDA_BOARD = 4
    Public Const ETM_CAN_ADDR_AFC_CONTROL_BOARD = 5
    Public Const ETM_CAN_ADDR_COOLING_INTERFACE_BOARD = 6
    Public Const ETM_CAN_ADDR_HEATER_MAGNET_BOARD = 7
    Public Const ETM_CAN_ADDR_GUN_DRIVER_BOARD = 8
#End If




    Private Sub ButtonSetTime_Click(sender As System.Object, e As System.EventArgs)
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
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_SET_TIME, time_high_word, time_low_word, 0, 0)
        Catch ex As Exception
            MsgBox("Date Time Type conversion failed")

        End Try
    End Sub

    Private Sub ButtonReloadECBDefaults_Click(sender As System.Object, e As System.EventArgs)
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT, 0, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroOnTime_Click(sender As System.Object, e As System.EventArgs)
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON, 0, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroPulseCounters_Click(sender As System.Object, e As System.EventArgs)
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT, 0, 0, 0, 0)
    End Sub

#If 0 Then


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
        CbxSlaveStatusCntrl0.Visible = True
        CbxSlaveStatusCntrl1.Visible = True
        CbxSlaveStatusCntrl2.Visible = True
        CbxSlaveStatusCntrl3.Visible = True
        CbxSlaveStatusCntrl4.Visible = True
        CbxSlaveStatusCntrl5.Visible = True
        CbxSlaveStatusCntrl6.Visible = True
        CbxSlaveStatusCntrl7.Visible = True
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

        ButtonToggleMode.Visible = False
    End Sub
#End If



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


            ServerSettings.put_modbus_commands(REGISTER_IP_ADDRESS, ip_address_v4_upper, ip_address_v4_lower, 0, 0)

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


            ServerSettings.put_modbus_commands(REGISTER_REMOTE_IP_ADDRESS, ip_address_v4_upper, ip_address_v4_lower, 0, 0)
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


    Private Sub BtnMCUReset_Click(sender As Object, e As EventArgs) Handles BtnMCUReset.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_RESET_MCU, board_can_address, 0, 0, 0)
    End Sub

    Private Sub BtnSetRevSN_Click(sender As Object, e As EventArgs) Handles BtnSetRevSN.Click
        Dim rev As Double
        Dim serial_number As Double
        Dim data_valid = get_set_rev("Input Revision Number", "Rev", rev)
        If data_valid Then
            data_valid = get_set_data("SN", "More Text", 0, 2 ^ 16 - 1, "Reg", serial_number)
        End If
        If data_valid Then
            ServerSettings.put_modbus_commands(REGISTER_ETM_SET_REVISION_AND_SERIAL_NUMBER, board_can_address, serial_number, rev, 0)
        End If

        'ServerSettings.put_modbus_commands(REGISTER_ETM_SET_REVISION_AND_SERIAL_NUMBER, 0, 27, &H4332, 0)
    End Sub

    Private Sub BtnSlaveDefaultEEProm_Click(sender As Object, e As EventArgs) Handles BtnSlaveDefaultEEProm.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_SLAVE_LOAD_DEFAULT_CALIBRATION, board_can_address, 0, 0, 0)
    End Sub


    Private Sub BtnRamDebug_Click(sender As Object, e As EventArgs) Handles BtnRamDebug.Click
        Dim ram_a As Double
        Dim ram_b As Double
        Dim ram_c As Double
        Dim data_valid = get_set_data("Ram Debug A", "More Text", 0, 4095, "Reg", ram_a)
        If data_valid Then
            data_valid = get_set_data("Ram Debug B", "More Text", 0, 4095, "Reg", ram_b)
        End If
        If data_valid Then
            data_valid = get_set_data("Ram Debug C", "More Text", 0, 4095, "Reg", ram_c)
        End If

        If data_valid Then
            ServerSettings.put_modbus_commands(REGISTER_DEBUG_SET_RAM_DEBUG, board_can_address, CUShort(ram_a), CUShort(ram_b), CUShort(ram_c))
        End If

        'ServerSettings.put_modbus_commands(REGISTER_DEBUG_SET_RAM_DEBUG, 0, 110, &HB6C, &HB6C + 2)
    End Sub

    Private Sub BtnEEPromDebug_Click(sender As Object, e As EventArgs) Handles BtnEEPromDebug.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("EEPROM DEBUG", "More Text", 0, 10000, "Reg", input_data)

        If data_valid Then
            ServerSettings.put_modbus_commands(REGISTER_DEBUG_SET_EEPROM_DEBUG, board_can_address, CUShort(input_data), CUShort(input_data), CUShort(input_data))
        End If

        'ServerSettings.put_modbus_commands(REGISTER_DEBUG_SET_EEPROM_DEBUG, 0, CUShort(TbEEPromDebug.Text), CUShort(TbEEPromDebug.Text), CUShort(TbEEPromDebug.Text))
    End Sub

    Private Sub BtnSetCalPair_Click(sender As Object, e As EventArgs) Handles BtnSetCalPair.Click
        Dim location As Double
        Dim gain As Double
        Dim offset As Double
        Dim data_valid = get_set_data("Location", "More Text", 0, 31, "Reg", location)
        If data_valid Then
            data_valid = get_set_data("Gain", "More Text", 0, 2, "Reg", gain)
        End If
        If data_valid Then
            data_valid = get_set_data("Offset", "More Text", 0, 30000, "Reg", offset)
        End If

        If data_valid Then
            gain = gain * 2 ^ 15
            ServerSettings.put_modbus_commands(REGISTER_ETM_SLAVE_SET_CALIBRATION_PAIR, board_can_address, CUShort(location), CUShort(offset), CUShort(gain))
        End If

        'ServerSettings.put_modbus_commands(REGISTER_ETM_SLAVE_SET_CALIBRATION_PAIR, 0, &H7, 200, 0.75 * 2 ^ 15)
    End Sub

    Private Sub BtnAFCAuto_Click(sender As Object, e As EventArgs) Handles BtnAFCAuto.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_SELECT_AFC_MODE, 0, 0, 0, 0)
    End Sub

    Private Sub BtnAFCManual_Click(sender As Object, e As EventArgs) Handles BtnAFCManual.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_SELECT_MANUAL_MODE, 0, 0, 0, 0)
    End Sub

    Private Sub BtnClearDebug_Click(sender As Object, e As EventArgs) Handles BtnClearDebug.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_CLEAR_DEBUG, 0, 0, 0, 0)
    End Sub


    Function get_set_rev(ByVal prompt As String, ByVal title As String, ByRef data As Double) As Boolean
        ' return true if got valid data
        Dim strvalue As String

        strvalue = InputBox(prompt, title)

        get_set_rev = False
        Try
            If (strvalue <> "") Then
                Select Case strvalue.Length
                    Case 1
                        data = (Asc(strvalue(0)) << 8) + &H20
                        get_set_rev = True
                    Case 2
                        data = (Asc(strvalue(0)) << 8) + Asc(strvalue(1))
                        get_set_rev = True
                    Case Else
                        MsgBox("The maximum revision length is 2", MsgBoxStyle.Exclamation)
                End Select

            End If
        Catch
            MsgBox("Invalid input, data discarded", MsgBoxStyle.Exclamation)
        End Try

    End Function


    Function get_set_data(ByVal prompt As String, ByVal title As String, ByVal min As Double, ByVal max As Double, ByVal unit As String, ByRef data As Double) As Boolean
        ' return true if got valid data
        Dim strvalue As String
        Dim prompt_range As String

        If (max < 0 And min < 0) Then
            prompt_range = prompt & " ( " & max & " " & unit & "  to  " & min & " " & unit & " )"
        Else
            prompt_range = prompt & " ( " & min & " " & unit & "  to  " & max & " " & unit & " )"
        End If
        strvalue = InputBox(prompt_range, title)
        Dim dval As Double

        get_set_data = False
        Try
            If (strvalue <> "") Then
                dval = CDbl(strvalue)
                If (dval > max Or dval < min) Then
                    MsgBox("Input data is out of range, data discarded", MsgBoxStyle.Exclamation)
                Else
                    data = dval
                    get_set_data = True
                End If
            End If
        Catch
            MsgBox("Invalid input, data discarded", MsgBoxStyle.Exclamation)
        End Try

    End Function
    Private Sub BntECBEEPromConfigure_Click(sender As Object, e As EventArgs) Handles BntECBEEPromConfigure.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT, 0, 0, 0, 0)
    End Sub

    Private Sub BtnHVPSDose0_Click(sender As Object, e As EventArgs) Handles BtnHVPSDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Dose 0", "HV Power Supply", 6, 22, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HVPS_SET_POINT_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnHVPSDose1_Click(sender As Object, e As EventArgs) Handles BtnHVPSDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Dose 1", "HV Power Supply", 6, 22, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HVPS_SET_POINT_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnHVPSDose2_Click(sender As Object, e As EventArgs) Handles BtnHVPSDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Dose 2", "HV Power Supply", 6, 22, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HVPS_SET_POINT_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnHVPSDose3_Click(sender As Object, e As EventArgs) Handles BtnHVPSDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Dose 3", "HV Power Supply", 6, 22, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HVPS_SET_POINT_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnMagnetCurrentDose0_Click(sender As Object, e As EventArgs) Handles BtnMagnetCurrentDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Dose 0", "Magnet and Heater", 8, 25, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnMagnetCurrentDose1_Click(sender As Object, e As EventArgs) Handles BtnMagnetCurrentDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Dose 1", "Magnet and Heater", 8, 25, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnMagnetCurrentDose2_Click(sender As Object, e As EventArgs) Handles BtnMagnetCurrentDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Dose 2", "Magnet and Heater", 8, 25, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnMagnetCurrentDose3_Click(sender As Object, e As EventArgs) Handles BtnMagnetCurrentDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Dose 3", "Magnet and Heater", 8, 25, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPulseTopDose0_Click(sender As Object, e As EventArgs) Handles BtnPulseTopDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Dose 0", "Gun Driver", -80, 250, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPulseTopDose1_Click(sender As Object, e As EventArgs) Handles BtnPulseTopDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Dose 1", "Gun Driver", -80, 250, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPulseTopDose2_Click(sender As Object, e As EventArgs) Handles BtnPulseTopDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Dose 2", "Gun Driver", -80, 250, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPulseTopDose3_Click(sender As Object, e As EventArgs) Handles BtnPulseTopDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Dose 3", "Gun Driver", -80, 250, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_PULSE_TOP_VOLTAGE_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunCathodeDose0_Click(sender As Object, e As EventArgs) Handles BtnGunCathodeDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Ek for Dose 0", "Gun Driver", -20, -6, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunCathodeDose1_Click(sender As Object, e As EventArgs) Handles BtnGunCathodeDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Ek for Dose 1", "Gun Driver", -20, -6, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunCathodeDose2_Click(sender As Object, e As EventArgs) Handles BtnGunCathodeDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Ek for Dose 2", "Gun Driver", -20, -6, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunCathodeDose3_Click(sender As Object, e As EventArgs) Handles BtnGunCathodeDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Ek for Dose 3", "Gun Driver", -20, -6, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSpareTriggerDelayDose0_Click(sender As Object, e As EventArgs) Handles BtnSpareTriggerDelayDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Spare Trigger Delay for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_SPARE_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSpareTriggerDelayDose1_Click(sender As Object, e As EventArgs) Handles BtnSpareTriggerDelayDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Spare Trigger Delay for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_SPARE_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSpareTriggerDelayDose2_Click(sender As Object, e As EventArgs) Handles BtnSpareTriggerDelayDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Spare Trigger Delay for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_SPARE_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSpareTriggerDelayDose3_Click(sender As Object, e As EventArgs) Handles BtnSpareTriggerDelayDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Spare Trigger Delay for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_SPARE_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCTriggerDelayDose0_Click(sender As Object, e As EventArgs) Handles BtnAFCTriggerDelayDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set AFC Trigger Delay for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_AFC_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCTriggerDelayDose1_Click(sender As Object, e As EventArgs) Handles BtnAFCTriggerDelayDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set AFC Trigger Delay for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_AFC_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCTriggerDelayDose2_Click(sender As Object, e As EventArgs) Handles BtnAFCTriggerDelayDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set AFC Trigger Delay for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_AFC_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCTriggerDelayDose3_Click(sender As Object, e As EventArgs) Handles BtnAFCTriggerDelayDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set AFC Trigger Delay for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_AFC_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMinDose0_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMinDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Min for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MIN_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMinDose1_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMinDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Min for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MIN_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMinDose2_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMinDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Min for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MIN_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMinDose3_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMinDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Min for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MIN_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMaxDose0_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMaxDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Max for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MAX_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMaxDose1_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMaxDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Max for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MAX_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMaxDose2_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMaxDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Max for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MAX_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStartMaxDose3_Click(sender As Object, e As EventArgs) Handles BtnGrideStartMaxDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Start Max for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_START_MAX_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMinDose0_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMinDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMinDose1_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMinDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMinDose2_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMinDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMinDose3_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMinDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MIN_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMaxDose0_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMaxDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 0", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMaxDose1_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMaxDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 1", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMaxDose2_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMaxDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 2", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGrideStopMaxDose3_Click(sender As Object, e As EventArgs) Handles BtnGrideStopMaxDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Grid Stop Min for Dose 3", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_GRID_STOP_MAX_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCHomeDose0_Click(sender As Object, e As EventArgs) Handles BtnAFCHomeDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Home Position Dose 0", "AFC", 6400, 51200, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_AFC_HOME_POSITION_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCHomeDose1_Click(sender As Object, e As EventArgs) Handles BtnAFCHomeDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Home Position Dose 1", "AFC", 6400, 51200, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_AFC_HOME_POSITION_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCHomeDose2_Click(sender As Object, e As EventArgs) Handles BtnAFCHomeDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Home Position Dose 2", "AFC", 6400, 51200, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_AFC_HOME_POSITION_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCHomeDose3_Click(sender As Object, e As EventArgs) Handles BtnAFCHomeDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Home Position Dose 3", "AFC", 6400, 51200, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_AFC_HOME_POSITION_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPRFDose0_Click(sender As Object, e As EventArgs) Handles BtnPRFDose0.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set PRF Dose 0", "Trigger", 0, 800, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 50
            ServerSettings.put_modbus_commands(REGISTER_SELF_TRIGGER_PRF_DOSE_0, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPRFDose1_Click(sender As Object, e As EventArgs) Handles BtnPRFDose1.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set PRF Dose 1", "Trigger", 0, 800, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 50
            ServerSettings.put_modbus_commands(REGISTER_SELF_TRIGGER_PRF_DOSE_1, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPRFDose2_Click(sender As Object, e As EventArgs) Handles BtnPRFDose2.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set PRF Dose 2", "Trigger", 0, 800, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 50
            ServerSettings.put_modbus_commands(REGISTER_SELF_TRIGGER_PRF_DOSE_2, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPRFDose3_Click(sender As Object, e As EventArgs) Handles BtnPRFDose3.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set PRF Dose 3", "Trigger", 0, 800, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 50
            ServerSettings.put_modbus_commands(REGISTER_SELF_TRIGGER_PRF_DOSE_3, program_word, 0, 0, 0)
        End If
    End Sub


    Private Sub BtnMagnetronHeater_Click(sender As Object, e As EventArgs) Handles BtnMagnetronHeater.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Heater Current", "Magnet and Heater", 0, 12, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_MAGNETRON_HEATER_CURRENT_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunHeater_Click(sender As Object, e As EventArgs) Handles BtnGunHeater.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set If", "Gun Driver", 0, 1.6, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_HEATER_VOLTAGE_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnHVPSTrigStart_Click(sender As Object, e As EventArgs) Handles BtnHVPSTrigStart.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set HVPS Start", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_HVPS_START_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnHVPSTrigStop_Click(sender As Object, e As EventArgs) Handles BtnHVPSTrigStop.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set HVPS Stop", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_HVPS_STOP_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnPFNTriggerDelay_Click(sender As Object, e As EventArgs) Handles BtnPFNTriggerDelay.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set PFN Delay", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_PFN_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSampleTriggerStart_Click(sender As Object, e As EventArgs) Handles BtnSampleTriggerStart.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Sample Start", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_MAGNETRON_AND_TARGET_CURRENT_START_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnSampleTriggerStop_Click(sender As Object, e As EventArgs) Handles BtnSampleTriggerStop.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Sample Stop", "Trigger", 0, 60000, "nS", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_TRIGGER_MAGNETRON_AND_TARGET_CURRENT_STOP_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnXrayRunTime_Click(sender As Object, e As EventArgs) Handles BtnXrayRunTime.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Xray On Time", "Trigger", 0, 60000, "S", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_X_RAY_ON_TIME_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnGunBias_Click(sender As Object, e As EventArgs) Handles BtnGunBias.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Bias", "Gun Driver", -600, -300, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -100
            ServerSettings.put_modbus_commands(REGISTER_GUN_BIAS_VOLTAGE_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCAuxControl_Click(sender As Object, e As EventArgs) Handles BtnAFCAuxControl.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Aux Control", "AFC", 0, 60000, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_AFC_AFT_CONTROL_VOLTAGE_DOSE_ALL, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub BtnAFCManualPostion_Click(sender As Object, e As EventArgs) Handles BtnAFCManualPostion.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Manual Position", "AFC", 0, 64000, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_MANUAL_TARGET_POSITION, program_word, 0, 0, 0)
        End If
    End Sub

    Private Sub CoBoxSelectedCanBoard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxSelectedCanBoard.SelectedIndexChanged
        Try
            board_can_address = CByte(CoBoxSelectedCanBoard.SelectedIndex)
            If board_can_address = 10 Then
                board_can_address = &HF
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Board Index")
        End Try
    End Sub


    Private Sub BtnZeroOnTimeCounter_Click(sender As Object, e As EventArgs) Handles BtnZeroOnTimeCounter.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON, 0, 0, 0, 0)
    End Sub

    Private Sub BtnZeroArcPulseCounter_Click(sender As Object, e As EventArgs) Handles BtnZeroArcPulseCounter.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT, 0, 0, 0, 0)
    End Sub

    Private Sub BtnEEpromWriteStatusClear_Click(sender As Object, e As EventArgs) Handles BtnEEpromWriteStatusClear.Click
        ServerSettings.put_modbus_commands(REGISTER_CLEAR_EEPROM_WRITE_STATUS, 0, 0, 0, 0)
    End Sub

    Private Sub BtnSystemSerialNumber_Click(sender As Object, e As EventArgs) Handles BtnSystemSerialNumber.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set System Serial Number", "ECB", 0, 64000, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_ETM_SYSTEM_SERIAL_NUMBER, &H48, 0, program_word, 0)
        End If
    End Sub


End Class