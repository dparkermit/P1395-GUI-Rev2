﻿Public Class frmMain


    Public Const REGISTER_HEATER_CURRENT_AT_STANDBY As UInt16 = &H0
    Public Const REGISTER_ELECTROMAGNET_CURRENT As UInt16 = &H1
    Public Const REGISTER_HOME_POSITION As UInt16 = &H5
    Public Const REGISTER_AFC_OFFSET As UInt16 = &H9
    Public Const REGISTER_AFC_AFT_CONTROL_VOLTAGE As UInt16 = &HA
    Public Const REGISTER_HIGH_ENERGY_SET_POINT As UInt16 = &H10
    Public Const REGISTER_LOW_ENERGY_SET_POINT As UInt16 = &H11
    Public Const REGISTER_GUN_DRIVER_HEATER_VOLTAGE As UInt16 = &H20
    Public Const REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE As UInt16 = &H21
    Public Const REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE As UInt16 = &H22
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE As UInt16 = &H23
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B As UInt16 = &H30
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D As UInt16 = &H31
    Public Const REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY As UInt16 = &H32
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B As UInt16 = &H33
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D As UInt16 = &H34
    Public Const REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY As UInt16 = &H35
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B As UInt16 = &H36
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D As UInt16 = &H37
    Public Const REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY As UInt16 = &H38
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B As UInt16 = &H39
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D As UInt16 = &H3A
    Public Const REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY As UInt16 = &H3B


    Public Const REGISTER_CMD_AFC_SELECT_AFC_MODE As UInt16 = &H5081
    Public Const REGISTER_CMD_AFC_SELECT_MANUAL_MODE As UInt16 = &H5082
    Public Const REGISTER_CMD_AFC_MANUAL_TARGET_POSITION As UInt16 = &H5083
    Public Const REGISTER_CMD_AFC_MANUAL_MOVE As UInt16 = &H5084

    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES As UInt16 = &H6082
    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT As UInt16 = &H6083
    Public Const REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE As UInt16 = &H6084
    Public Const REGISTER_SPECIAL_ECB_LOAD_DEFAULT_SETTINGS_TO_EEPROM_AND_REBOOT As UInt16 = &HE080
    Public Const REGISTER_SPECIAL_ECB_REST_ARC_AND_PULSE_COUNT As UInt16 = &HE081
    Public Const REGISTER_SPECIAL_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON As UInt16 = &HE082
    Public Const REGISTER_SPECIAL_ECB_RESET_SLAVE As UInt16 = &HE083
    Public Const REGISTER_SPECIAL_ECB_SEND_SLAVE_RELOAD_EEPROM_WITH_DEFAULTS As UInt16 = &HE084

    Public Const REGISTER_DEBUG_TOGGLE_RESET As UInt16 = &HEF00
    Public Const REGISTER_DEBUG_TOGGLE_HIGH_SPEED_LOGGING As UInt16 = &HEF01
    Public Const REGISTER_DEBUG_TOGGLE_HV_ENABLE As UInt16 = &HEF02
    Public Const REGISTER_DEBUG_TOGGLE_XRAY_ENABLE As UInt16 = &HEF03
    Public Const REGISTER_DEBUG_TOGGLE_COOLING_FAULT As UInt16 = &HEF04
    Public Const REGISTER_DEBUG_TOGGLE_RESET_DEBUG As UInt16 = &HEF05
    Public Const REGISTER_DEBUG_ENABLE_HIGH_SPEED_LOGGING As UInt16 = &HEF06
    Public Const REGISTER_DEBUG_DISABLE_HIGH_SPEED_LOGGING As UInt16 = &HEF07

    Public Const REGISTER_SPECIAL_SET_TIME As UInt16 = &HEF08




    Public Const REGISTER_SPECIAL_2_5_SET_GRID_START As UInt16 = &HEF40
    Public Const REGISTER_SPECIAL_2_5_SET_GRID_STOP As UInt16 = &HEF41
    Public Const REGISTER_SPECIAL_2_5_SET_PFN_DELAY As UInt16 = &HEF42
    Public Const REGISTER_SPECIAL_2_5_SET_DOSE_SAMPLE_DELAY As UInt16 = &HEF43  'Unused for the 2.5 - NOT IMPLIMENTED
    Public Const REGISTER_SPECIAL_2_5_SET_AFC_SAMPLE_DELAY As UInt16 = &HEF44
    Public Const REGISTER_SPECIAL_2_5_SET_MAGNETRON_CURRENT_SAMPLE_DELAY As UInt16 = &HEF45
    Public Const REGISTER_SPECIAL_2_5_SET_HV_LAMBDA_VOLTAGE As UInt16 = &HEF46
    Public Const REGISTER_SPECIAL_2_5_SET_DOSE_DYNAMIC_START As UInt16 = &HEF47
    Public Const REGISTER_SPECIAL_2_5_SET_DOSE_DYNAMIC_STOP As UInt16 = &HEF48




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

        LoadLogRegisterText()


        


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
        LabelErrorCanBusCount.Visible = False
        LabelErrorI2CBusCount.Visible = False
        LabelErrorResetCount.Visible = False
        LabelErrorScaleCount.Visible = False
        LabelErrorSelfTestResultRegister.Visible = False
        LabelErrorSPIBusCount.Visible = False
        LabelErrorStatusDataA.Visible = False
        LabelErrorStatusDataB.Visible = False
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
        CheckBoxResetBOR.Visible = False
        CheckBoxResetExt.Visible = False
        CheckBoxResetIdle.Visible = False
        CheckBoxResetIllegal.Visible = False
        CheckBoxResetPOR.Visible = False
        CheckBoxResetSleep.Visible = False
        CheckBoxResetSoftware.Visible = False
        CheckBoxResetTrap.Visible = False
        CheckBoxResetWDT.Visible = False

        ComboBoxEEpromRegister.Visible = False
        LabelEEpromIndex.Visible = False
        TextBoxEEpromOffSet.Visible = False
        TextBoxEEpromScale.Visible = False
        LabelScale.Visible = False
        LabelOffset.Visible = False
        ButtonReadEEprom.Visible = False
        ButtonWriteEEprom.Visible = False
        ButtonResetSlave.Visible = False
        Button1.Visible = False

        LabelComputerTime.Visible = False
        LabelSyncMessageCntrlBits.Visible = False
        ButtonToggleCoolantFault.Visible = False
        ButtonToggleHighSpeedDataLogging.Visible = False
        ButtonTogglePulseSyncHV.Visible = False
        ButtonTogglePulseSyncXray.Visible = False
        ButtonToggleReset.Visible = False
        ButtonToggleResetDebug.Visible = False
        CheckBoxSyncBit0.Visible = False
        CheckBoxSyncBit1.Visible = False
        CheckBoxSyncBit2.Visible = False
        CheckBoxSyncBit3.Visible = False
        CheckBoxSyncBit4.Visible = False
        CheckBoxSyncBit5.Visible = False
        CheckBoxSyncBit6.Visible = False
        CheckBoxSyncBit7.Visible = False
        CheckBoxSyncBit8.Visible = False
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

        LabelAgileInfo.Text = "A" & ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_number & "-" & ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_dash & "  Rev-" & Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_rev_ascii) & "  SN-" & ServerSettings.ETMEthernetBoardLoggingData(board_index).serial_number 'Dparker need to add in the first Char
        LabelFirmwareVerssion.Text = "Firmware Version " & ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_agile_rev & "." & ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch & "." & ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch_rev


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

            CheckBoxFaultBit0.Text = "Drive Up Flt"
            CheckBoxFaultBit1.Text = "Cool Com"
            CheckBoxFaultBit2.Text = "Cool !Rdy"
            CheckBoxFaultBit3.Visible = False
            CheckBoxFaultBit4.Visible = False
            CheckBoxFaultBit5.Visible = False
            CheckBoxFaultBit6.Visible = False
            CheckBoxFaultBit7.Text = "Gun Htr Off"
            CheckBoxFaultBit8.Text = "HV Lambda"
            CheckBoxFaultBit9.Text = "Ion Pimp"
            CheckBoxFaultBitA.Text = "AFC"
            CheckBoxFaultBitB.Text = "Cooling"
            CheckBoxFaultBitC.Text = "Htr/Mag"
            CheckBoxFaultBitD.Text = "Gun Drv"
            CheckBoxFaultBitE.Text = "I pulse"
            CheckBoxFaultBitF.Text = "Pulse Sync"


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


            Dim thyratron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(4)
            Dim magnetron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(5)
            Dim gun_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(6)


            LabelValue1.Text = "Sec Powered = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(8), "###,###,###,##0")
            LabelValue2.Text = "Sec HV On = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(11) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(10), "###,###,###,##0")
            LabelValue3.Text = "Sec Xray On = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(13) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(12), "###,###,###,##0")
            LabelValue4.Text = "Magnetron Pwr = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(14) / 1000, "0.000") & " kW"
            LabelValue5.Text = "Thyratron Warmup = " & Math.Truncate(thyratron_warmup / 60) & ":" & Format((thyratron_warmup Mod 60), "00")
            LabelValue6.Text = "Magnetron Warmup = " & Math.Truncate(magnetron_warmup / 60) & ":" & Format((magnetron_warmup Mod 60), "00")
            LabelValue7.Text = "Gun Driver Warmup = " & Math.Truncate(gun_warmup / 60) & ":" & Format((gun_warmup Mod 60), "00")
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


        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H80

            CheckBoxFaultBit0.Text = "HTR OC ABS"
            CheckBoxFaultBit1.Text = "HTR UC ABS"
            CheckBoxFaultBit2.Text = "HTR OC REL"
            CheckBoxFaultBit3.Text = "HTR UC REL"
            CheckBoxFaultBit4.Text = "HTR OV ABS"
            CheckBoxFaultBit5.Text = "HTR UV REL"
            CheckBoxFaultBit6.Text = "MAG OC ABS"
            CheckBoxFaultBit7.Text = "MAG UC ABS"
            CheckBoxFaultBit8.Text = "MAG OC REL"
            CheckBoxFaultBit9.Text = "MAG UC REL"
            CheckBoxFaultBitA.Text = "MAG OV ABS"
            CheckBoxFaultBitB.Text = "MAG UV REL"
            CheckBoxFaultBitC.Text = "HW HTR OV"
            CheckBoxFaultBitD.Text = "HW TEMP SW"
            CheckBoxFaultBitE.Text = "COOLANT FLT"
            CheckBoxFaultBitF.Text = "CAN FLT"

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


            LabelValue1.Text = "Magnet Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(0) / 1000, ".000") & " A"
            LabelValue2.Text = "Heater Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(1) / 1000, ".000") & " A"
            LabelValue3.Text = ""
            LabelValue4.Text = "Magnet Set Rdbck= " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(5) / 1000, ".000") & " A"
            LabelValue5.Text = "Mag Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(1) / 1000, ".000") & " A"
            LabelValue6.Text = "Mag Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(0) / 1000, ".000") & " V"
            LabelValue6.Text = ""
            LabelValue7.Text = ""
            LabelValue8.Text = "Heater Scaled Set = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(3) / 1000, ".000") & " A"
            LabelValue9.Text = "Heater Set Rdbck = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(6) / 1000, ".000") & " A"
            LabelValue10.Text = "Htr Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(3) / 1000, ".000") & " A"
            LabelValue11.Text = "Htr Vmon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(2) / 1000, ".000") & " V"
            LabelValue12.Text = ""
            LabelValue13.Text = ""
            LabelValue14.Text = ""
            LabelValue15.Text = ""

            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Magnet"
            inputbutton1.max_value = 21000
            inputbutton1.min_value = 8000
            inputbutton1.scale = 1000
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_ELECTROMAGNET_CURRENT

            inputbutton2.enabled = True
            inputbutton1.button_only = False
            inputbutton2.button_name = "Set Heater"
            inputbutton2.max_value = 10000
            inputbutton2.min_value = 0
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_HEATER_CURRENT_AT_STANDBY

            inputbutton3.enabled = False
            inputbutton4.enabled = False
            inputbutton5.enabled = False


        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H2

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

            LabelValue1.Text = "Pulses Today = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(4), "###,###,###,##0")
            LabelValue2.Text = "Arcs Today = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(12), "###,###,###,##0")
            LabelValue3.Text = "Pulse Total = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(11) * 2 ^ 48 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(10) * 2 ^ 32 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(8), "###,###,###,##0")
            LabelValue4.Text = "Arcs Total = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(7) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(6), "###,###,###,##0")
            LabelValue5.Text = "Imon High Energy = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(0) / 100, "0.00") & " A"
            LabelValue6.Text = "Imon Low Energy = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(2) / 100, "0.00") & " A"
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



        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H1

            CheckBoxFaultBit1.Text = "Can Fault"
            CheckBoxFaultBit1.Text = "Ion Over Current"
            CheckBoxFaultBit2.Text = "Ion Over Voltage"
            CheckBoxFaultBit3.Text = "Ion Under Voltage"
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
            LabelValue2.Text = "Ion Current = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) / 1000, "0.000") & " uA"
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

            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H10

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
            LabelValue2.Text = "AFT Ctrl V = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(1) / 1000, "0.000") & " V"
            LabelValue3.Text = "Readback Position = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(2)
            LabelValue4.Text = ""
            LabelValue5.Text = "Rback Home Pos = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(11)
            LabelValue6.Text = "Filtered Error = " & filtered_error
            LabelValue7.Text = "Previous A Sample = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(6)
            LabelValue8.Text = "Previous B Sample = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(5)
            LabelValue9.Text = ""
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
            inputbutton1.button_index = REGISTER_HOME_POSITION

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "AFT Control Voltage"
            inputbutton2.max_value = 10000
            inputbutton2.min_value = 1000
            inputbutton2.scale = 1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_AFC_AFT_CONTROL_VOLTAGE


            If afc_manual_mode Then
                inputbutton3.enabled = True
            Else
                inputbutton3.enabled = False

            End If

            inputbutton3.button_only = False
            inputbutton3.button_name = "Manual Position"
            inputbutton3.max_value = 64000
            inputbutton3.min_value = 0
            inputbutton3.scale = 1
            inputbutton3.offset = 0
            inputbutton3.button_index = REGISTER_CMD_AFC_MANUAL_TARGET_POSITION

            If afc_manual_mode Then
                inputbutton4.button_name = "AFC Mode"
                inputbutton4.button_index = REGISTER_CMD_AFC_SELECT_AFC_MODE
            Else
                inputbutton4.button_name = "Manual Mode"
                inputbutton4.button_index = REGISTER_CMD_AFC_SELECT_MANUAL_MODE
            End If

            inputbutton4.enabled = True
            inputbutton4.button_only = True
            inputbutton4.max_value = 64000
            inputbutton4.min_value = 0
            inputbutton4.scale = 1
            inputbutton4.offset = 0

            inputbutton5.enabled = False



        ElseIf (selected_baord = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) Then
#Const THEA_MODULATOR = 0


#If THEA_MODULATOR Then
            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H100


            CheckBoxFaultBit0.Text = "Can Fault"
            CheckBoxFaultBit1.Text = "Bias OV"
            CheckBoxFaultBit2.Text = "Bias UV"
            CheckBoxFaultBit3.Text = "Comm Flt"
            CheckBoxFaultBit4.Text = "Top 1 OV"
            CheckBoxFaultBit5.Text = "Top 1 UV"
            CheckBoxFaultBit6.Text = "Top 2 OV"
            CheckBoxFaultBit7.Text = "Top 2 UV"
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
            LabelValue15.Text = ""

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

            selected_board_connected = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(15) And &H100

            CheckBoxFaultBit0.Text = "Sum Fault"
            CheckBoxFaultBit1.Text = "FPGA Comm Lost"
            CheckBoxFaultBit2.Text = "SW Htr OV/OC"
            CheckBoxFaultBit3.Text = "SW Bias UV"
            CheckBoxFaultBit4.Text = "SW Cath OV"
            CheckBoxFaultBit5.Text = "SW Cath UV"
            CheckBoxFaultBit6.Text = "SW Grid OV"
            CheckBoxFaultBit7.Text = "FPGA T>75C"
            CheckBoxFaultBit8.Text = "CAN COMM Fault"
            CheckBoxFaultBit9.Text = "FPGA ARC Fault"
            CheckBoxFaultBitA.Text = "FPGA Pulse Fault"
            CheckBoxFaultBitB.Text = "FPGA Grid Fault"
            CheckBoxFaultBitC.Text = "SW Htr UV"
            CheckBoxFaultBitD.Text = "SW 24V Fault"
            CheckBoxFaultBitE.Text = "System Fault"
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


            LabelValue1.Text = "Ek Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(8)) * (-0.001), "0.00kV") 'ekset
            LabelValue2.Text = "Ef Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(9)) * (-0.001), "0.00V") 'efset
            LabelValue3.Text = "Eg Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(11)) * 0.1 - 80, "0.0V")  ' egset
            LabelValue4.Text = "Ek = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(1)) * (-0.001), "0.00kV") ' GUN_DRIVER_EK_RD_CAL
            LabelValue5.Text = "Ikp = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(0)) * 0.1, "0.0V") ' GUN_DRIVER_IKP_RD_CAL
            LabelValue6.Text = "Ef = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(7)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_RD_CAL
            LabelValue7.Text = "If = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(6)) * 0.001, "0.00A") 'GUN_DRIVER_IF_RD_CAL
            LabelValue8.Text = "Eg = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(3)) * 0.1 - 80, "0.0V") ' eg rd

            LabelValue9.Text = "Ec = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(12)) * 0.1, "0.0V") ' GUN_DRIVER_EC_RD_CAL
            'LabelValue10.Text = "Temp = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_DRIVER_TEMPERATURE)) * 0.01, "0.0C") 'GUN_DRIVER_TEMP_RD_CAL
            LabelValue10.Text = ""
            LabelValue11.Text = "Ek SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(0)) * (-0.001), "0.00kV") 'GUN_DRIVER_EK_SET_CAL
            LabelValue12.Text = "Ef SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(1)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_SET_CAL
            LabelValue13.Text = "Eg SetRd = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(2)) * 0.1 - 80, "0.0V") 'GUN_DRIVER_EG_SET_CAL

            LabelValue14.Text = "Ana Flt = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(14) & _
                 ", state = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(13)
            LabelValue15.Text = "FPGA ASDR = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(15).ToString("x")


            inputbutton1.enabled = True
            inputbutton1.button_only = False
            inputbutton1.button_name = "Set Ek"
            inputbutton1.max_value = 20000
            inputbutton1.min_value = 6000
            inputbutton1.scale = -1000
            inputbutton1.offset = 0
            inputbutton1.button_index = REGISTER_GUN_DRIVER_CATHODE_VOLTAGE

            inputbutton2.enabled = True
            inputbutton2.button_only = False
            inputbutton2.button_name = "Set Ef"
            inputbutton2.max_value = 5500
            inputbutton2.min_value = 0
            inputbutton2.scale = -1000
            inputbutton2.offset = 0
            inputbutton2.button_index = REGISTER_GUN_DRIVER_HEATER_VOLTAGE

            inputbutton3.enabled = True

            inputbutton3.button_only = False
            inputbutton3.button_name = "Set Eg"
            inputbutton3.max_value = 2200
            inputbutton3.min_value = 0
            inputbutton3.scale = 10
            inputbutton3.offset = 800
            inputbutton3.button_index = REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE


            inputbutton4.enabled = False
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
            Case &H80
                ECBState = "Fault Hold"
            Case &H90
                ECBState = "Fault Reset"
            Case &HA0
                ECBState = "System Error"
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


        LabelDisplay1.Text = "Magnetron Current = " & Format(magnetron_current / 100, ".00") & " A"
        LabelDisplay2.Text = "Magnet Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(1) / 1000, ".000") & " A"
        LabelDisplay3.Text = "Heater Imon = " & Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(3) / 1000, ".000") & " A"
        LabelDisplay4.Text = "Pulses Today = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(4)
        LabelDisplay5.Text = "Arcs Today = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(12)
        LabelDisplay6.Text = "PRF = " & Format((ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(3)) / 10, ".0") & " Hz"
        LabelDisplay7.Text = "Ion Pump Current = " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(2) & " nA"
        LabelDisplay8.Text = "Warmup Remaining = " & Math.Truncate(warmuptime / 60) & ":" & Format((warmuptime Mod 60), "00")

        ' Update the current Sync Bits
        Dim Sync_data As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(7)
        CheckBoxSyncBit0.Checked = Sync_data And &H1
        CheckBoxSyncBit1.Checked = Sync_data And &H2
        CheckBoxSyncBit2.Checked = Sync_data And &H4
        CheckBoxSyncBit3.Checked = Sync_data And &H8
        CheckBoxSyncBit4.Checked = Sync_data And &H10
        CheckBoxSyncBit5.Checked = Sync_data And &H20
        CheckBoxSyncBit6.Checked = Sync_data And &H40
        CheckBoxSyncBit7.Checked = Sync_data And &H80
        CheckBoxSyncBitF.Checked = Sync_data And &H8000

        If CheckBoxSyncBit1.Checked Then
            ' High speed data logging is enabled
            ButtonStopLog.Visible = True
            ButtonStartLog.Visible = False
        Else
            ButtonStopLog.Visible = False
            ButtonStartLog.Visible = True
        End If


        ' Update the connected Boards
#If (0) Then
        Dim ConnectedBoards As UInt16 = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.BOARD_COM_FAULT)
        CheckBoxIonPumpConnected.Checked = (ConnectedBoards And &H2) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).status_data.status_word_1)
        CheckBoxPulseCurrentMonitorConnected.Checked = (ConnectedBoards And &H4) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).status_data.status_word_1)
        CheckBoxPulseSyncConnected.Checked = (ConnectedBoards And &H8) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).status_data.status_word_1)
        CheckBoxHVLambdaConnected.Checked = (ConnectedBoards And &H10) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).status_data.status_word_1)
        CheckBoxAFCConnected.Checked = (ConnectedBoards And &H20) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).status_data.status_word_1)
        CheckBoxCoolingConnected.Checked = (ConnectedBoards And &H40) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).status_data.status_word_1)
        CheckBoxHtrMagConnected.Checked = (ConnectedBoards And &H80) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).status_data.status_word_1)
        CheckBoxGunDriverConnected.Checked = (ConnectedBoards And &H100) Or (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).status_data.status_word_1)

        Label2.Visible = False
        CheckBoxIonPumpConnected.Visible = False
        CheckBoxPulseCurrentMonitorConnected.Visible = False
        CheckBoxPulseSyncConnected.Visible = False
        CheckBoxHVLambdaConnected.Visible = False
        CheckBoxAFCConnected.Visible = False
        CheckBoxCoolingConnected.Visible = False
        CheckBoxHtrMagConnected.Visible = False
        CheckBoxGunDriverConnected.Visible = False


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


    Private Sub LoadLogRegisterText()
        ServerSettings.EventLogMessages.Add(&H10, "	State - Entered State Startup	")
        ServerSettings.EventLogMessages.Add(&H11, "	State - Entered State Wait for Personality from Pulse Sync	")
        ServerSettings.EventLogMessages.Add(&H12, "	State - Entered State Personality Received	")
        ServerSettings.EventLogMessages.Add(&H13, "	Error - Personality not valid 6/4 MeV	")
        ServerSettings.EventLogMessages.Add(&H14, "	Error - Personality not valid 2.5 MeV	")
        ServerSettings.EventLogMessages.Add(&H15, "	Entered State Waiting for Initialization	")
        ServerSettings.EventLogMessages.Add(&H16, "	Notice - All Modules Configured	")
        ServerSettings.EventLogMessages.Add(&H17, "	State - Entered State warmup	")
        ServerSettings.EventLogMessages.Add(&H18, "	Notice - Warmup Done	")
        ServerSettings.EventLogMessages.Add(&H19, "	State - Entered State Standby	")
        ServerSettings.EventLogMessages.Add(&H1A, "	Input - HV ON	")
        ServerSettings.EventLogMessages.Add(&H1B, "	State - Entered State Drive Up	")
        ServerSettings.EventLogMessages.Add(&H1C, "	Notice - Drive up Complete	")
        ServerSettings.EventLogMessages.Add(&H1D, "	Input - HV OFF	")
        ServerSettings.EventLogMessages.Add(&H1E, "	Fault - Drive Up Timeout 	")
        ServerSettings.EventLogMessages.Add(&H1F, "	State - Entered State Ready	")
        ServerSettings.EventLogMessages.Add(&H20, "	Input - XRAY ON	")
        ServerSettings.EventLogMessages.Add(&H22, "	State - Entered State XRAY On	")
        ServerSettings.EventLogMessages.Add(&H23, "	Input - XRAY OFF	")
        ServerSettings.EventLogMessages.Add(&H25, "	State - Entered State Fault Hold	")
        ServerSettings.EventLogMessages.Add(&H27, "	State - Entered State Fault Reset	")
        ServerSettings.EventLogMessages.Add(&H28, "	State - Entered State HV Off Faults Clear	")
        ServerSettings.EventLogMessages.Add(&H29, "	State - Entered State System Fault	")

        ServerSettings.EventLogMessages.Add(&H1110, "	Status - Ion Pump Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1111, "	Status - Ion Pump Read	")
        ServerSettings.EventLogMessages.Add(&H1112, "	Status - Ion Pump not Configured	")
        ServerSettings.EventLogMessages.Add(&H1113, "	Status - Ion Pump Configured	")
        ServerSettings.EventLogMessages.Add(&H1114, "	Fault - Ion Pump Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1115, "	Status - Ion Pump Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1010, "	Fault - Ion Pump 1	")
        ServerSettings.EventLogMessages.Add(&H1011, "	Fault - Ion Pump 2	")
        ServerSettings.EventLogMessages.Add(&H1012, "	Fault - Ion Pump 3	")
        ServerSettings.EventLogMessages.Add(&H1013, "	Fault - Ion Pump 4	")
        ServerSettings.EventLogMessages.Add(&H1014, "	Fault - Ion Pump 5	")
        ServerSettings.EventLogMessages.Add(&H1015, "	Fault - Ion Pump 6	")
        ServerSettings.EventLogMessages.Add(&H1016, "	Fault - Ion Pump 7	")
        ServerSettings.EventLogMessages.Add(&H1017, "	Fault - Ion Pump 8	")
        ServerSettings.EventLogMessages.Add(&H1018, "	Fault - Ion Pump 9	")
        ServerSettings.EventLogMessages.Add(&H1019, "	Fault - Ion Pump 10	")
        ServerSettings.EventLogMessages.Add(&H101A, "	Fault - Ion Pump 11	")
        ServerSettings.EventLogMessages.Add(&H101B, "	Fault - Ion Pump 12	")
        ServerSettings.EventLogMessages.Add(&H101C, "	Fault - Ion Pump 13	")
        ServerSettings.EventLogMessages.Add(&H101D, "	Fault - Ion Pump 14	")
        ServerSettings.EventLogMessages.Add(&H101E, "	Fault - Ion Pump 15	")
        ServerSettings.EventLogMessages.Add(&H101F, "	Fault - Ion Pump 16	")

        ServerSettings.EventLogMessages.Add(&H1120, "	Status - Pulse Current Monitor Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1121, "	Status - Pulse Current Monitor Read	")
        ServerSettings.EventLogMessages.Add(&H1122, "	Status - Pulse Current Monitor not Configured	")
        ServerSettings.EventLogMessages.Add(&H1123, "	Status - Pulse Current Monitor Configured	")
        ServerSettings.EventLogMessages.Add(&H1124, "	Fault - Pulse Current Monitor Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1125, "	Status - Pulse Current Monitor Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1020, "	Fault - Pulse Current Monitor 1	")
        ServerSettings.EventLogMessages.Add(&H1021, "	Fault - Pulse Current Monitor 2	")
        ServerSettings.EventLogMessages.Add(&H1022, "	Fault - Pulse Current Monitor 3	")
        ServerSettings.EventLogMessages.Add(&H1023, "	Fault - Pulse Current Monitor 4	")
        ServerSettings.EventLogMessages.Add(&H1024, "	Fault - Pulse Current Monitor 5	")
        ServerSettings.EventLogMessages.Add(&H1025, "	Fault - Pulse Current Monitor 6	")
        ServerSettings.EventLogMessages.Add(&H1026, "	Fault - Pulse Current Monitor 7	")
        ServerSettings.EventLogMessages.Add(&H1027, "	Fault - Pulse Current Monitor 8	")
        ServerSettings.EventLogMessages.Add(&H1028, "	Fault - Pulse Current Monitor 9	")
        ServerSettings.EventLogMessages.Add(&H1029, "	Fault - Pulse Current Monitor 10	")
        ServerSettings.EventLogMessages.Add(&H102A, "	Fault - Pulse Current Monitor 11	")
        ServerSettings.EventLogMessages.Add(&H102B, "	Fault - Pulse Current Monitor 12	")
        ServerSettings.EventLogMessages.Add(&H102C, "	Fault - Pulse Current Monitor 13	")
        ServerSettings.EventLogMessages.Add(&H102D, "	Fault - Pulse Current Monitor 14	")
        ServerSettings.EventLogMessages.Add(&H102E, "	Fault - Pulse Current Monitor 15	")
        ServerSettings.EventLogMessages.Add(&H102F, "	Fault - Pulse Current Monitor 16	")

        ServerSettings.EventLogMessages.Add(&H1130, "	Status - Pulse Sync Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1131, "	Status - Pulse Sync Read	")
        ServerSettings.EventLogMessages.Add(&H1132, "	Status - Pulse Sync not Configured	")
        ServerSettings.EventLogMessages.Add(&H1133, "	Status - Pulse Sync Configured	")
        ServerSettings.EventLogMessages.Add(&H1134, "	Fault - Pulse Sync Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1135, "	Status - Pulse Sync Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1030, "	Fault - Pulse Sync 1	")
        ServerSettings.EventLogMessages.Add(&H1031, "	Fault - Pulse Sync 2	")
        ServerSettings.EventLogMessages.Add(&H1032, "	Fault - Pulse Sync 3	")
        ServerSettings.EventLogMessages.Add(&H1033, "	Fault - Pulse Sync 4	")
        ServerSettings.EventLogMessages.Add(&H1034, "	Fault - Pulse Sync 5	")
        ServerSettings.EventLogMessages.Add(&H1035, "	Fault - Pulse Sync 6	")
        ServerSettings.EventLogMessages.Add(&H1036, "	Fault - Pulse Sync 7	")
        ServerSettings.EventLogMessages.Add(&H1037, "	Fault - Pulse Sync 8	")
        ServerSettings.EventLogMessages.Add(&H1038, "	Fault - Pulse Sync 9	")
        ServerSettings.EventLogMessages.Add(&H1039, "	Fault - Pulse Sync 10	")
        ServerSettings.EventLogMessages.Add(&H103A, "	Fault - Pulse Sync 11	")
        ServerSettings.EventLogMessages.Add(&H103B, "	Fault - Pulse Sync 12	")
        ServerSettings.EventLogMessages.Add(&H103C, "	Fault - Pulse Sync 13	")
        ServerSettings.EventLogMessages.Add(&H103D, "	Fault - Pulse Sync 14	")
        ServerSettings.EventLogMessages.Add(&H103E, "	Fault - Pulse Sync 15	")
        ServerSettings.EventLogMessages.Add(&H103F, "	Fault - Pulse Sync 16	")

        ServerSettings.EventLogMessages.Add(&H1140, "	Status - HV Lambda Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1141, "	Status - HV Lambda Read	")
        ServerSettings.EventLogMessages.Add(&H1142, "	Status - HV Lambda not Configured	")
        ServerSettings.EventLogMessages.Add(&H1143, "	Status - HV Lambda Configured	")
        ServerSettings.EventLogMessages.Add(&H1144, "	Fault - HV Lambda Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1145, "	Status - HV Lambda Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1040, "	Fault - HV Lambda 1	")
        ServerSettings.EventLogMessages.Add(&H1041, "	Fault - HV Lambda 2	")
        ServerSettings.EventLogMessages.Add(&H1042, "	Fault - HV Lambda 3	")
        ServerSettings.EventLogMessages.Add(&H1043, "	Fault - HV Lambda 4	")
        ServerSettings.EventLogMessages.Add(&H1044, "	Fault - HV Lambda 5	")
        ServerSettings.EventLogMessages.Add(&H1045, "	Fault - HV Lambda 6	")
        ServerSettings.EventLogMessages.Add(&H1046, "	Fault - HV Lambda 7	")
        ServerSettings.EventLogMessages.Add(&H1047, "	Fault - HV Lambda 8	")
        ServerSettings.EventLogMessages.Add(&H1048, "	Fault - HV Lambda 9	")
        ServerSettings.EventLogMessages.Add(&H1049, "	Fault - HV Lambda 10	")
        ServerSettings.EventLogMessages.Add(&H104A, "	Fault - HV Lambda 11	")
        ServerSettings.EventLogMessages.Add(&H104B, "	Fault - HV Lambda 12	")
        ServerSettings.EventLogMessages.Add(&H104C, "	Fault - HV Lambda 13	")
        ServerSettings.EventLogMessages.Add(&H104D, "	Fault - HV Lambda 14	")
        ServerSettings.EventLogMessages.Add(&H104E, "	Fault - HV Lambda 15	")
        ServerSettings.EventLogMessages.Add(&H104F, "	Fault - HV Lambda 16	")

        ServerSettings.EventLogMessages.Add(&H1150, "	Status - AFC Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1151, "	Status - AFC Read	")
        ServerSettings.EventLogMessages.Add(&H1152, "	Status - AFC not Configured	")
        ServerSettings.EventLogMessages.Add(&H1153, "	Status - AFC Configured	")
        ServerSettings.EventLogMessages.Add(&H1154, "	Fault - AFC Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1155, "	Status - AFC Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1050, "	Fault - AFC 1	")
        ServerSettings.EventLogMessages.Add(&H1051, "	Fault - AFC 2	")
        ServerSettings.EventLogMessages.Add(&H1052, "	Fault - AFC 3	")
        ServerSettings.EventLogMessages.Add(&H1053, "	Fault - AFC 4	")
        ServerSettings.EventLogMessages.Add(&H1054, "	Fault - AFC 5	")
        ServerSettings.EventLogMessages.Add(&H1055, "	Fault - AFC 6	")
        ServerSettings.EventLogMessages.Add(&H1056, "	Fault - AFC 7	")
        ServerSettings.EventLogMessages.Add(&H1057, "	Fault - AFC 8	")
        ServerSettings.EventLogMessages.Add(&H1058, "	Fault - AFC 9	")
        ServerSettings.EventLogMessages.Add(&H1059, "	Fault - AFC 10	")
        ServerSettings.EventLogMessages.Add(&H105A, "	Fault - AFC 11	")
        ServerSettings.EventLogMessages.Add(&H105B, "	Fault - AFC 12	")
        ServerSettings.EventLogMessages.Add(&H105C, "	Fault - AFC 13	")
        ServerSettings.EventLogMessages.Add(&H105D, "	Fault - AFC 14	")
        ServerSettings.EventLogMessages.Add(&H105E, "	Fault - AFC 15	")
        ServerSettings.EventLogMessages.Add(&H105F, "	Fault - AFC 16	")

        ServerSettings.EventLogMessages.Add(&H1160, "	Status - Cooling Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1161, "	Status - Cooling Read	")
        ServerSettings.EventLogMessages.Add(&H1162, "	Status - Cooling not Configured	")
        ServerSettings.EventLogMessages.Add(&H1163, "	Status - Cooling Configured	")
        ServerSettings.EventLogMessages.Add(&H1164, "	Fault - Cooling Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1165, "	Status - Cooling Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1060, "	Fault - Cooling 1	")
        ServerSettings.EventLogMessages.Add(&H1061, "	Fault - Cooling 2	")
        ServerSettings.EventLogMessages.Add(&H1062, "	Fault - Cooling 3	")
        ServerSettings.EventLogMessages.Add(&H1063, "	Fault - Cooling 4	")
        ServerSettings.EventLogMessages.Add(&H1064, "	Fault - Cooling 5	")
        ServerSettings.EventLogMessages.Add(&H1065, "	Fault - Cooling 6	")
        ServerSettings.EventLogMessages.Add(&H1066, "	Fault - Cooling 7	")
        ServerSettings.EventLogMessages.Add(&H1067, "	Fault - Cooling 8	")
        ServerSettings.EventLogMessages.Add(&H1068, "	Fault - Cooling 9	")
        ServerSettings.EventLogMessages.Add(&H1069, "	Fault - Cooling 10	")
        ServerSettings.EventLogMessages.Add(&H106A, "	Fault - Cooling 11	")
        ServerSettings.EventLogMessages.Add(&H106B, "	Fault - Cooling 12	")
        ServerSettings.EventLogMessages.Add(&H106C, "	Fault - Cooling 13	")
        ServerSettings.EventLogMessages.Add(&H106D, "	Fault - Cooling 14	")
        ServerSettings.EventLogMessages.Add(&H106E, "	Fault - Cooling 15	")
        ServerSettings.EventLogMessages.Add(&H106F, "	Fault - Cooling 16	")

        ServerSettings.EventLogMessages.Add(&H1170, "	Status - Heater Magnet Interface Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1171, "	Status - Heater Magnet Interface Read	")
        ServerSettings.EventLogMessages.Add(&H1172, "	Status - Heater Magnet Interface not Configured	")
        ServerSettings.EventLogMessages.Add(&H1173, "	Status - Heater Magnet Interface Configured	")
        ServerSettings.EventLogMessages.Add(&H1174, "	Fault - Heater Magnet Interface Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1175, "	Status - Heater Magnet Interface Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1070, "	Fault - HTR-MAG Heater over current absolute	")
        ServerSettings.EventLogMessages.Add(&H1071, "	Fault - HTR-MAG Heater under current absolute	")
        ServerSettings.EventLogMessages.Add(&H1072, "	Fault - HTR-MAG Heater over current relative	")
        ServerSettings.EventLogMessages.Add(&H1073, "	Fault - HTR-MAG Heater under current relative	")
        ServerSettings.EventLogMessages.Add(&H1074, "	Fault - HTR-MAG Heater over voltage absolute	")
        ServerSettings.EventLogMessages.Add(&H1075, "	Fault - HTR-MAG Heater under voltage relative	")
        ServerSettings.EventLogMessages.Add(&H1076, "	Fault - HTR-MAG Magnet over current absolute	")
        ServerSettings.EventLogMessages.Add(&H1077, "	Fault - HTR-MAG Magnet under current absolute	")
        ServerSettings.EventLogMessages.Add(&H1078, "	Fault - HTR-MAG Magnet over current relative	")
        ServerSettings.EventLogMessages.Add(&H1079, "	Fault - HTR-MAG Magnet under current relative	")
        ServerSettings.EventLogMessages.Add(&H107A, "	Fault - HTR-MAG Magnet over voltage absolute	")
        ServerSettings.EventLogMessages.Add(&H107B, "	Fault - HTR-MAG Magnet under voltage relative	")
        ServerSettings.EventLogMessages.Add(&H107C, "	Fault - HTR-MAG Heater Hardware over voltage	")
        ServerSettings.EventLogMessages.Add(&H107D, "	Fault - HTR-MAG Hardware temperature switch	")
        ServerSettings.EventLogMessages.Add(&H107E, "	Fault - HTR-MAG coolant fault	")
        ServerSettings.EventLogMessages.Add(&H107F, "	Fault - HTR-MAG can fault	")

        ServerSettings.EventLogMessages.Add(&H1180, "	Status - Gun Driver Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1181, "	Status - Gun Driver Read	")
        ServerSettings.EventLogMessages.Add(&H1182, "	Status - Gun Driver not Configured	")
        ServerSettings.EventLogMessages.Add(&H1183, "	Status - Gun Driver Configured	")
        ServerSettings.EventLogMessages.Add(&H1184, "	Fault - Gun Driver Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1185, "	Status - Gun Driver Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1186, "	Fault - Gun Driver Heater Off	")
        ServerSettings.EventLogMessages.Add(&H1187, "	Status - Gun Driver Heater On	")
        ServerSettings.EventLogMessages.Add(&H1080, "	Fault - Gun Driver 1	")
        ServerSettings.EventLogMessages.Add(&H1081, "	Fault - Gun Driver 2	")
        ServerSettings.EventLogMessages.Add(&H1082, "	Fault - Gun Driver 3	")
        ServerSettings.EventLogMessages.Add(&H1083, "	Fault - Gun Driver 4	")
        ServerSettings.EventLogMessages.Add(&H1084, "	Fault - Gun Driver 5	")
        ServerSettings.EventLogMessages.Add(&H1085, "	Fault - Gun Driver 6	")
        ServerSettings.EventLogMessages.Add(&H1086, "	Fault - Gun Driver 7	")
        ServerSettings.EventLogMessages.Add(&H1087, "	Fault - Gun Driver 8	")
        ServerSettings.EventLogMessages.Add(&H1088, "	Fault - Gun Driver 9	")
        ServerSettings.EventLogMessages.Add(&H1089, "	Fault - Gun Driver 10	")
        ServerSettings.EventLogMessages.Add(&H108A, "	Fault - Gun Driver 11	")
        ServerSettings.EventLogMessages.Add(&H108B, "	Fault - Gun Driver 12	")
        ServerSettings.EventLogMessages.Add(&H108C, "	Fault - Gun Driver 13	")
        ServerSettings.EventLogMessages.Add(&H108D, "	Fault - Gun Driver 14	")
        ServerSettings.EventLogMessages.Add(&H108E, "	Fault - Gun Driver 15	")
        ServerSettings.EventLogMessages.Add(&H108F, "	Fault - Gun Driver 16	")
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
        'LabelErrorStatusDataA.Text = "Data A = " & ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_A
        'LabelErrorStatusDataB.Text = "Data B = " & ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_B
        LabelRCON.Text = "RCON = " & ServerSettings.ETMEthernetDebugData.RCON_value.ToString("X")
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

    Private Sub ButtonTest_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTest.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES, 0, 0, 0)
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

    Private Sub ButtonToggleReset_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleReset.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_RESET, 0, 0, 0)
    End Sub

    Private Sub ButtonToggleHighSpeedDataLogging_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleHighSpeedDataLogging.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_HIGH_SPEED_LOGGING, 0, 0, 0)
    End Sub


    Private Sub ButtonTogglePulseSyncHV_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTogglePulseSyncHV.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_HV_ENABLE, 0, 0, 0)
    End Sub


    Private Sub ButtonTogglePulseSyncXray_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTogglePulseSyncXray.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_XRAY_ENABLE, 0, 0, 0)
    End Sub


    Private Sub ButtonToggleCoolantFault_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleCoolantFault.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_COOLING_FAULT, 0, 0, 0)
    End Sub

    Private Sub ButtonToggleResetDebug_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleResetDebug.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_RESET_DEBUG, 0, 0, 0)
    End Sub




    Private Sub ComboBoxEEpromRegister_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEEpromRegister.SelectedIndexChanged
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

        EEProm_index = ComboBoxEEpromRegister.SelectedIndex * 2
        command_index = command_index * 2 ^ 12
        EEProm_index = command_index + EEProm_index + &H100
        LabelEEpromIndex.Text = "Index = " & EEProm_index.ToString("x")
    End Sub

    Private Sub ButtonReadEEprom_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReadEEprom.Click
        Dim offset As Double
        TextBoxEEpromScale.Text = Math.Round((ServerSettings.ETMEthernetCalStructure(EEProm_index).scale / 2 ^ 15), 5)
        offset = ServerSettings.ETMEthernetCalStructure(EEProm_index).offset
        If offset > 32767 Then
            offset = offset - 2 ^ 16
        End If
        TextBoxEEpromOffSet.Text = offset
        ServerSettings.put_modbus_commands((&H800 + EEProm_index), 0, 0, 0)
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


    Private Sub ButtonWriteEEprom_Click(sender As System.Object, e As System.EventArgs) Handles ButtonWriteEEprom.Click
        Dim eeprom_scale_float As Double
        Dim eeprom_offset_float As Double
        Dim eeprom_scale As UInt16
        Dim eeprom_offset As UInt16

        eeprom_scale_float = TextBoxEEpromScale.Text
        eeprom_scale_float = eeprom_scale_float * 2 ^ 15
        If eeprom_scale_float < 0 Then
            eeprom_scale_float = 0
        End If
        If eeprom_scale_float > 65535 Then
            eeprom_scale_float = 65535
        End If

        eeprom_offset_float = TextBoxEEpromOffSet.Text
        If eeprom_offset_float > 32767 Then
            eeprom_offset_float = 32767
        End If
        If eeprom_offset_float < -32768 Then
            eeprom_offset_float = -32768
        End If
        If eeprom_offset_float < 0 Then
            eeprom_offset_float = eeprom_offset_float + 2 ^ 16
        End If


        eeprom_scale = CUShort(eeprom_scale_float)
        eeprom_offset = CUShort(eeprom_offset_float)


        'eeprom_scale = eeprom_scale_float
        'eeprom_offset = eeprom_offset_float
        ServerSettings.put_modbus_commands(EEProm_index, 0, eeprom_scale, eeprom_offset)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_SEND_SLAVE_RELOAD_EEPROM_WITH_DEFAULTS, selected_board_index, 0, 0)
    End Sub

    Private Sub ButtonResetSlave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonResetSlave.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_RESET_SLAVE, selected_board_index, 0, 0)
    End Sub



    Private Sub ButtonStartLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStartLog.Click
        ButtonStartLog.Visible = False
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_ENABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
        ServerSettings.OpenPulseLogFile()
    End Sub

    Private Sub ButtonStopLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStopLog.Click
        ButtonStopLog.Visible = False
        ServerSettings.ClosePulseLogFile()
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_DISABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
    End Sub


    Private Sub ButtonSetTime_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetTime.Click
        Dim time_high_word As UInt16
        Dim time_low_word As UInt16
        Dim time_now As Date = DateTime.UtcNow
        Dim time_seconds As UInt32

        time_seconds = (time_now.Year Mod 100) * 31622400
        time_seconds += (time_now.Month) * 2678400
        time_seconds += (time_now.Day) * 86400
        time_seconds += (time_now.Hour) * 3600
        time_seconds += (time_now.Minute) * 60
        time_seconds += (time_now.Second)

        time_high_word = CUShort(time_seconds >> 16)
        time_low_word = CUShort(time_seconds And &HFFFF)
        'LabelTimeSet.Text = Format(time_now, "yy MM dd HH mm ss")
        'LabelTimeSet2.Text = time_seconds
        Try
            ServerSettings.put_modbus_commands(REGISTER_SPECIAL_SET_TIME, time_high_word, time_low_word, 0)
        Catch ex As Exception
            MsgBox("Date Time Type conversion failed")

        End Try
    End Sub

    Private Sub ButtonReloadECBDefaults_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReloadECBDefaults.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_LOAD_DEFAULT_SETTINGS_TO_EEPROM_AND_REBOOT, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroOnTime_Click(sender As System.Object, e As System.EventArgs) Handles ButtonZeroOnTime.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON, 0, 0, 0)
    End Sub

    Private Sub ButtonZeroPulseCounters_Click(sender As System.Object, e As System.EventArgs) Handles ButtonZeroPulseCounters.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_REST_ARC_AND_PULSE_COUNT, 0, 0, 0)
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
        LabelErrorCanBusCount.Visible = True
        LabelErrorI2CBusCount.Visible = True
        LabelErrorResetCount.Visible = True
        LabelErrorScaleCount.Visible = True
        LabelErrorSelfTestResultRegister.Visible = True
        LabelErrorSPIBusCount.Visible = True
        LabelErrorStatusDataA.Visible = True
        LabelErrorStatusDataB.Visible = True
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
        CheckBoxResetBOR.Visible = True
        CheckBoxResetExt.Visible = True
        CheckBoxResetIdle.Visible = True
        CheckBoxResetIllegal.Visible = True
        CheckBoxResetPOR.Visible = True
        CheckBoxResetSleep.Visible = True
        CheckBoxResetSoftware.Visible = True
        CheckBoxResetTrap.Visible = True
        CheckBoxResetWDT.Visible = True

        ComboBoxEEpromRegister.Visible = True
        LabelEEpromIndex.Visible = True
        TextBoxEEpromOffSet.Visible = True
        TextBoxEEpromScale.Visible = True
        LabelScale.Visible = True
        LabelOffset.Visible = True
        ButtonReadEEprom.Visible = True
        ButtonWriteEEprom.Visible = True
        ButtonResetSlave.Visible = True
        Button1.Visible = True

        LabelComputerTime.Visible = True
        LabelSyncMessageCntrlBits.Visible = True
        ButtonToggleCoolantFault.Visible = True
        ButtonToggleHighSpeedDataLogging.Visible = True
        ButtonTogglePulseSyncHV.Visible = True
        ButtonTogglePulseSyncXray.Visible = True
        ButtonToggleReset.Visible = True
        ButtonToggleResetDebug.Visible = True
        CheckBoxSyncBit0.Visible = True
        CheckBoxSyncBit1.Visible = True
        CheckBoxSyncBit2.Visible = True
        CheckBoxSyncBit3.Visible = True
        CheckBoxSyncBit4.Visible = True
        CheckBoxSyncBit5.Visible = True
        CheckBoxSyncBit6.Visible = True
        CheckBoxSyncBit7.Visible = True
        CheckBoxSyncBit8.Visible = True
        CheckBoxSyncBitF.Visible = True
        ButtonSetTime.Visible = True

        ButtonReloadECBDefaults.Visible = True
        ButtonZeroOnTime.Visible = True
        ButtonZeroPulseCounters.Visible = True
        Me.Size = New System.Drawing.Size(1280, 780)
        ButtonToggleMode.Visible = False
    End Sub

End Class