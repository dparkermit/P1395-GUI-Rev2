Public Class frmMain

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
        Dim not_logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).not_logged_bits

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

        LblSlaveLogValue0.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(0)
        LblSlaveLogValue1.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(1)
        LblSlaveLogValue2.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(2)
        LblSlaveLogValue3.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(3)
        LblSlaveLogValue4.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(4)
        LblSlaveLogValue5.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(5)
        LblSlaveLogValue6.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(6)
        LblSlaveLogValue7.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(7)
        LblSlaveLogValue8.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(8)
        LblSlaveLogValue9.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(9)
        LblSlaveLogValue10.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(10)
        LblSlaveLogValue11.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(11)
        LblSlaveLogValue12.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(12)
        LblSlaveLogValue13.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(13)
        LblSlaveLogValue14.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(14)
        LblSlaveLogValue15.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(15)
        LblSlaveLogValue16.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(16)
        LblSlaveLogValue17.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(17)
        LblSlaveLogValue18.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(18)
        LblSlaveLogValue19.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(19)
        LblSlaveLogValue20.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(20)
        LblSlaveLogValue21.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(21)
        LblSlaveLogValue22.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(22)
        LblSlaveLogValue23.Text = ServerSettings.ETMEthernetBoardLoggingData(board_index).log_data(23)

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







    End Sub

    Private Sub DisplayBoardSpecificData(ByVal selected_baord As Byte)

        UpdateButtons()


        Dim selected_board_connected As Boolean = False
#If (0) Then

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
        If selected_board_connected Then
            LabelBoardStatus.Text = ""
            Me.BackColor = SystemColors.Control
        Else
            LabelBoardStatus.Text = "NOT CONNECTED!!!"
            Me.BackColor = Color.LightCoral
        End If







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
        'LabelErrorReserved1.Text = "Can Ver = 0x" & ServerSettings.ETMEthernetDebugData.reserved_1.ToString("x")
        LabelRCON.Text = "RCON = " & ServerSettings.ETMEthernetDebugData.RCON_value.ToString("X")

        LabelCommandCount.Text = "Cmd Count = " & ServerSettings.command_rcv_count
        LabelCommandLengthError.Text = "Cmd Lgth Err = " & ServerSettings.command_length_error
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

    Private Sub cboIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndex.SelectedIndexChanged
        board_index = cboIndex.SelectedIndex + 1
    End Sub


End Class