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
    Public Const REGISTER_DEBUG_TOGGLE_RESET As UInt16 = &HEF00
    Public Const REGISTER_DEBUG_TOGGLE_HIGH_SPEED_LOGGING As UInt16 = &HEF01
    Public Const REGISTER_DEBUG_TOGGLE_HV_ENABLE As UInt16 = &HEF02
    Public Const REGISTER_DEBUG_TOGGLE_XRAY_ENABLE As UInt16 = &HEF03
    Public Const REGISTER_DEBUG_TOGGLE_COOLING_FAULT As UInt16 = &HEF04
    Public Const REGISTER_DEBUG_TOGGLE_RESET_DEBUG As UInt16 = &HEF05
    Public Const REGISTER_DEBUG_ENABLE_HIGH_SPEED_LOGGING As UInt16 = &HEF06
    Public Const REGISTER_DEBUG_DISABLE_HIGH_SPEED_LOGGING As UInt16 = &HEF07

    Public Const REGISTER_SPECIAL_SET_TIME As UInt16 = &HEF08











    ' Public Const ETHERNET_CMD_HEATER_MAGNET_HEATER_SET_POINT As UInt16 = 0
    ' Public Const ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT As UInt16 = 1
    ' Public Const ETHERNET_CMD_HV_LAMBDA_HIGH_SET_POINT As UInt16 = 2
    '  Public Const ETHERNET_CMD_HV_LAMBDA_LOW_SET_POINT As UInt16 = 3
    '  Public Const PULSE_SYNC_SEND_DEFAULT_CMD As UInt16 = 4


    '  Public Const ETHERNET_TOGGLE_RESET As UInt16 = 20
    '  Public Const ETHERNET_TOGGLE_HIGH_SPEED_LOGGING As UInt16 = 21
    ' Public Const PULSE_SYNC_TOGGLE_HV_ENABLE As UInt16 = 22
    '   Public Const PULSE_SYNC_TOGGLE_XRAY_ENABLE As UInt16 = 23
    '  Public Const ETHERNET_CMD_TOGGLE_COOLANT_FAULT_BIT As UInt16 = 24

    ' Public Const ETHERNET_CMD_UNKNOWN As UInt16 = 255

    Public update_1_cmd_index As UInt16
    Public update_2_cmd_index As UInt16
    Public update_3_cmd_index As UInt16

    Public board_command_index As UInt16

    Public EEProm_index As UInt16

#If DEBUG_MODBUS Then
    Public modbus_recv_buffer(255, 1024) As Byte
    Public modbus_recv_bytecount(255) As UInt16
    Public modbus_recv_index As Byte
#End If

    Dim board_index As Byte = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim status_data As ETM_CAN_STATUS_REGISTER = New ETM_CAN_STATUS_REGISTER
        Dim debug_data As ETM_CAN_SYSTEM_DEBUG_DATA = New ETM_CAN_SYSTEM_DEBUG_DATA

        Try
            Application.DoEvents()


            '     TextBoxIPAddress.Text = ServerSettings.txtIPAddr.Text
            '     ModBusPort = 502      'Modbus = 502 , Explicit Ethernet/IP = 44818 (TCP) , Implicit Ethernet/IP = 2222 (UDP)
            TimerUpdate.Enabled = True


        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormMainLoad  " + ex.ToString)
        End Try



    End Sub

    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick

        Dim ivalue As Integer
        Static connected As Boolean = False
        Static admin_param_checked As Boolean = False

        TimerUpdate.Enabled = False

        ivalue = ServerSettings.get_modbus_status()
        If (ivalue <= 2) Then
            '  lblState.Text = "Linac Disconnected" '"NO LAN COMM"
            If connected Then 'Or (TabControl1.SelectedIndex > 0) Then
                ' lblState.ForeColor = Color.Red
                If connected Then
                    '   lstBoxEvents.Items.Insert(0, Now & " #" & Trim(Str(EVENTDISCONNECTED + 1)) & " " & EventNames(EVENTDISCONNECTED))
                End If
                connected = False
                Me.Text = "A36507 Test GUI(Linac Disconnected)"
                '   TabControl1.SelectedIndex = 0

                '  Call sys_init()
            End If
        Else
            If (connected = False) Then
                connected = True
                Me.Text = "A36507 Test GUI"

                ' lstBoxEvents.Items.Insert(0, Now & " #" & Trim(Str(EVENTCONNECTED + 1)) & " " & EventNames(EVENTCONNECTED))
            End If
            LabelAgileInfo.Text = "A" & (ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.agile_number_high_word * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.agile_number_low_word) & "-" & ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.agile_dash & "  Rev-" & Convert.ToChar(ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.agile_rev_ascii) & "  SN-" & ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.serial_number 'Dparker need to add in the first Char
            LabelFirmwareVerssion.Text = "Firmware Version " & ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.firmware_major_rev & "." & ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.firmware_branch & "." & ServerSettings.ETMEthernetTXDataStructure(board_index).configuration.firmware_minor_rev




            Dim status_word_0 As UInt16 = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_0
            Dim status_word_1 As UInt16 = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_1


            If (status_word_0 And &H80) Then
                ' This board is not connected
                LabelBoardStatus.Text = "WARNING!!!! NOT CONNECTED"
            Else
                LabelBoardStatus.Text = ""
            End If
            ' this board is connected


            CheckBoxControlBit0.Checked = status_word_0 And &H1
            CheckBoxControlBit1.Checked = status_word_0 And &H2
            CheckBoxControlBit2.Checked = status_word_0 And &H4
            CheckBoxControlBit3.Checked = status_word_0 And &H8
            CheckBoxControlBit4.Checked = status_word_0 And &H10
            CheckBoxControlBit5.Checked = status_word_0 And &H20
            CheckBoxControlBit6.Checked = status_word_0 And &H40
            CheckBoxControlBit7.Checked = status_word_0 And &H80
            CheckBoxStatusBit0.Checked = status_word_0 And &H100
            CheckBoxStatusBit1.Checked = status_word_0 And &H200
            CheckBoxStatusBit2.Checked = status_word_0 And &H400
            CheckBoxStatusBit3.Checked = status_word_0 And &H800
            CheckBoxStatusBit4.Checked = status_word_0 And &H1000
            CheckBoxStatusBit5.Checked = status_word_0 And &H2000
            CheckBoxStatusBit6.Checked = status_word_0 And &H4000
            CheckBoxStatusBit7.Checked = status_word_0 And &H8000

            CheckBoxFaultBit0.Checked = status_word_1 And &H1
            CheckBoxFaultBit1.Checked = status_word_1 And &H2
            CheckBoxFaultBit2.Checked = status_word_1 And &H4
            CheckBoxFaultBit3.Checked = status_word_1 And &H8
            CheckBoxFaultBit4.Checked = status_word_1 And &H10
            CheckBoxFaultBit5.Checked = status_word_1 And &H20
            CheckBoxFaultBit6.Checked = status_word_1 And &H40
            CheckBoxFaultBit7.Checked = status_word_1 And &H80
            CheckBoxFaultBit8.Checked = status_word_1 And &H100
            CheckBoxFaultBit9.Checked = status_word_1 And &H200
            CheckBoxFaultBitA.Checked = status_word_1 And &H400
            CheckBoxFaultBitB.Checked = status_word_1 And &H800
            CheckBoxFaultBitC.Checked = status_word_1 And &H1000
            CheckBoxFaultBitD.Checked = status_word_1 And &H2000
            CheckBoxFaultBitE.Checked = status_word_1 And &H4000
            CheckBoxFaultBitF.Checked = status_word_1 And &H8000

            LabelCanCXECReg.Text = "CXEC Register = 0x" & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_CXEC_reg.ToString("x")
            LabelCanErrorFlagCount.Text = "Error Flag Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_error_flag
            LabelCanTX1Count.Text = "TX1 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_tx_1
            LabelCanTX2Count.Text = "TX2 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_tx_2
            LabelCanRX0Filt0Count.Text = "RX0 Filt 0 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_rx_0_filt_0
            LabelCanRX0Filt1Count.Text = "RX0 Filt 1 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_rx_0_filt_1
            LabelCanRX1Filt2Count.Text = "RX1 Filt 2 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_rx_1_filt_2
            LabelCanISREnteredCount.Text = "CXINTF = 0x" & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_isr_entered.ToString("X")
            LabelCanUnknownIdentifierCount.Text = "Unknown ID Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_unknown_message_identifier
            LabelCanInvalidIndexCount.Text = "Invalid Index Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_invalid_index
            LabelCanAddressErrorCount.Text = "Address Error Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_address_error
            LabelCanTX0Count.Text = "TX 0 Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_tx_0
            LabelCanTXBufOverflowCount.Text = "TX Ovrfl Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_message_tx_buffer_overflow
            LabelCanRXBufferOverflowCount.Text = "RX Ovrfl Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_message_rx_buffer_overflow
            LabelCAnDataLogRXBufferOVerflowCount.Text = "Log RX Ovrfl Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_data_log_rx_buffer_overflow
            LabelCanTimeoutCount.Text = "Can Timeout Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_timeout


            LabelErrorI2CBusCount.Text = "I2C Bus Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.i2c_bus_error_count
            LabelErrorSPIBusCount.Text = "SPI Bus Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.spi_bus_error_count
            LabelErrorCanBusCount.Text = "Can Bus Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.can_bus_error_count
            LabelErrorScaleCount.Text = "Scale Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.scale_error_count
            LabelErrorResetCount.Text = "Reset Count = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.reset_count
            LabelErrorSelfTestResultRegister.Text = "Self Test = 0x" & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.self_test_result_register.ToString("x")
            LabelErrorStatusDataA.Text = "Data A = " & ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_A
            LabelErrorStatusDataB.Text = "Data B = " & ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_B
            LabelRCON.Text = "RCON = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.i2c_bus_error_count.ToString("X")

            Dim rcon_value As UInt16 = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.i2c_bus_error_count

            CheckBoxResetTrap.Checked = rcon_value And &H8000
            CheckBoxResetIllegal.Checked = rcon_value And &H4000
            CheckBoxResetExt.Checked = rcon_value And &H80
            CheckBoxResetSoftware.Checked = rcon_value And &H40
            CheckBoxResetWDT.Checked = rcon_value And &H10
            CheckBoxResetSleep.Checked = rcon_value And &H8
            CheckBoxResetIdle.Checked = rcon_value And &H4
            CheckBoxResetBOR.Checked = rcon_value And &H2
            CheckBoxResetPOR.Checked = rcon_value And &H1



            LabelValueDebug0.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_0
            LabelValueDebug1.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_1
            LabelValueDebug2.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_2
            LabelValueDebug3.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_3
            LabelValueDebug4.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_4
            LabelValueDebug5.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_5
            LabelValueDebug6.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_6
            LabelValueDebug7.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_7
            LabelValueDebug8.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_8
            LabelValueDebug9.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_9
            LabelValueDebugA.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_A
            LabelValueDebugB.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_B
            LabelValueDebugC.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_C
            LabelValueDebugD.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_D
            LabelValueDebugE.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_E
            LabelValueDebugF.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_F

            ' Update the current Sync Bits
            Dim Sync_data As UInt16 = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYNC_0_CONTROL_WORD)
            CheckBoxSyncBit0.Checked = Sync_data And &H1
            CheckBoxSyncBit1.Checked = Sync_data And &H2
            CheckBoxSyncBit2.Checked = Sync_data And &H4
            CheckBoxSyncBit3.Checked = Sync_data And &H8
            CheckBoxSyncBit4.Checked = Sync_data And &H10
            CheckBoxSyncBit5.Checked = Sync_data And &H20
            CheckBoxSyncBit6.Checked = Sync_data And &H40
            CheckBoxSyncBit7.Checked = Sync_data And &H80
            CheckBoxSyncBitF.Checked = Sync_data And &H8000

            ' Update the connected Boards
            'Dim ConnectedBoards As UInt16 = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(4)
            CheckBoxIonPumpConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).status_data.status_word_0 And &H80
            CheckBoxPulseCurrentMonitorConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).status_data.status_word_0 And &H80
            CheckBoxPulseSyncConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).status_data.status_word_0 And &H80
            CheckBoxHVLambdaConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).status_data.status_word_0 And &H80
            CheckBoxAFCConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).status_data.status_word_0 And &H80
            CheckBoxCoolingConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).status_data.status_word_0 And &H80
            CheckBoxHtrMagConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).status_data.status_word_0 And &H80
            CheckBoxGunDriverConnected.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).status_data.status_word_0 And &H80

            ' Update the Faulted Boards
            'Dim FaultedBoards As UInt16 = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(0)
            CheckBoxOperateIonPump.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).status_data.status_word_0 And &H1
            CheckBoxOperateMagnetronCurrentMon.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).status_data.status_word_0 And &H1
            CheckBoxOperatePulseSync.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).status_data.status_word_0 And &H1
            CheckBoxOperateHVLambda.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).status_data.status_word_0 And &H1
            CheckBoxOperateAFC.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).status_data.status_word_0 And &H1
            CheckBoxOperateCooling.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).status_data.status_word_0 And &H1
            CheckBoxOperateHtrMag.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).status_data.status_word_0 And &H1
            CheckBoxOperateGunDriver.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).status_data.status_word_0 And &H1
            CheckBoxOperateEthernet.Checked = ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).status_data.status_word_0 And &H1

            'Update the ECB State
            Dim ECBState As String = ""
            Select Case ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.CONTROL_STATE)
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


            'Heater Mag Specific Data

            If (board_index = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET) Then
                CheckBoxStatusBit0.Text = "MAG OFF"
                CheckBoxStatusBit1.Text = "HTR OFF"
                CheckBoxStatusBit2.Text = "Relay Open"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

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

                update_1_cmd_index = REGISTER_HEATER_CURRENT_AT_STANDBY
                ButtonUpdateInput1.Text = "Set Heater"

                update_2_cmd_index = REGISTER_ELECTROMAGNET_CURRENT
                ButtonUpdateInput2.Text = "Set Magnet"

                LabelValue1.Text = "Magnet Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.MAGNET_CURRENT_SET_POINT)
                LabelValue2.Text = "Magnet Set Readback= " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_MAGNET_CURRENT_SET_POINT)
                LabelValue3.Text = "Mag Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_MAGNET_CURRENT)
                LabelValue4.Text = "Mag Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_MAGNET_VOLTAGE)

                LabelValue6.Text = "Heater Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.HEATER_CURRENT_SET_POINT)
                LabelValue7.Text = "Heater Scaled Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.HEATER_CURRENT_SET_POINT_SCALED)
                LabelValue8.Text = "Heater Set Readback = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_HEATER_CURRENT_SET_POINT)
                LabelValue9.Text = "Htr Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_HEATER_CURRENT)
                LabelValue10.Text = "Htr Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(CS_HTRMAG.READBACK_HEATER_VOLTAGE)







                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = False
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = True
                LabelValue10.Visible = True


                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False


            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_ETHERNET) Then
                CheckBoxStatusBit0.Text = "X-Ray Dis"
                CheckBoxStatusBit1.Text = "Personality Set"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Drive Up Flt"
                CheckBoxFaultBit1.Text = "Unused"
                CheckBoxFaultBit2.Text = "Unused"
                CheckBoxFaultBit3.Text = "Unused"
                CheckBoxFaultBit4.Text = "Unused"
                CheckBoxFaultBit5.Text = "Unused"
                CheckBoxFaultBit6.Text = "Unused"
                CheckBoxFaultBit7.Text = "Gun Htr Off"
                CheckBoxFaultBit8.Text = "HV Lambda"
                CheckBoxFaultBit9.Text = "Ion Pimp"
                CheckBoxFaultBitA.Text = "AFC"
                CheckBoxFaultBitB.Text = "Cooling"
                CheckBoxFaultBitC.Text = "Htr/Mag"
                CheckBoxFaultBitD.Text = "Gun Drv"
                CheckBoxFaultBitE.Text = "I pulse"
                CheckBoxFaultBitF.Text = "Pulse Sync"

                LabelDebug0.Text = "State = "
                LabelDebug1.Text = "Event Log Count = "
                LabelDebug2.Text = "Max RX Err = "
                LabelDebug3.Text = "Debug 3 = "
                LabelDebug4.Text = "Ion Pump = "
                LabelDebug5.Text = "Mag Current = "
                LabelDebug6.Text = "Pulse Sync = "
                LabelDebug7.Text = "HV Lambda = "
                LabelDebug8.Text = "AFC = "
                LabelDebug9.Text = "Cooling = "
                LabelDebugA.Text = "Htr Mag = "
                LabelDebugB.Text = "Gun Drv = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Debug D = "
                LabelDebugE.Text = "Debug E = "
                LabelDebugF.Text = "Debug F = "



                LabelValue1.Text = "Seconds Powered = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_POWERED_SECONDS_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_POWERED_SECONDS_W1)
                LabelValue2.Text = "Seconds HV On = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_HV_ON_SECONDS_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_HV_ON_SECONDS_W1)
                LabelValue3.Text = "Seconds Xray On = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_XRAY_ON_SECONDS_W2) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.SYSTEM_XRAY_ON_SECONDS_W1)
                LabelValue4.Text = "Magnetron Pwr = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.AVERAGE_OUTPUT_POWER_WATTS)
                LabelValue5.Text = "Thyratron Warmup = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.THYRATRON_WARMUP_COUNTER_SECONDS)
                LabelValue6.Text = "Magnetron Warmup = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.MAGNETRON_HEATER_WARMUP_COUNTER_SECONDS)
                LabelValue7.Text = "Gun Driver Warmup = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).custom_data(CS_ETHER.GUN_DRIVER_HEATER_WARMUP_COUNTER_SECONDS)

                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = False
                LabelValue9.Visible = False
                LabelValue10.Visible = False

                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
                CheckBoxStatusBit0.Text = "AT EOC"
                CheckBoxStatusBit1.Text = "HIGH MODE"
                CheckBoxStatusBit2.Text = "HV OFF"
                CheckBoxStatusBit3.Text = "STATE FLT"
                CheckBoxStatusBit4.Text = "PWR OFF"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "SUM FLT"
                CheckBoxFaultBit1.Text = "Power OFF"
                CheckBoxFaultBit2.Text = "HV OFF"
                CheckBoxFaultBit3.Text = "Phase Loss"
                CheckBoxFaultBit4.Text = "Over Temp"
                CheckBoxFaultBit5.Text = "Interlock"
                CheckBoxFaultBit6.Text = "Load FLT"
                CheckBoxFaultBit7.Text = "PWR UP"
                CheckBoxFaultBit8.Text = "Can FLT"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                update_1_cmd_index = REGISTER_HIGH_ENERGY_SET_POINT
                ButtonUpdateInput1.Text = "Set High"

                update_2_cmd_index = REGISTER_LOW_ENERGY_SET_POINT
                ButtonUpdateInput2.Text = "Set Low"

                LabelValue1.Text = "HVLambda High Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.ECB_HIGH_SET_POINT)
                LabelValue2.Text = "HVLambda Low Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.ECB_LOW_SET_POINT)
                LabelValue3.Text = "EOC Error Count = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.EOC_NOT_REACHED_COUNT)
                LabelValue4.Text = "Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_VMON)
                LabelValue5.Text = "Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_IMON)
                LabelValue6.Text = "Lambda Temperature = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_BASE_PLATE_TEMP)
                LabelValue7.Text = "Readback High Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_HIGH_VPROG)
                LabelValue8.Text = "Readback Low Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(CS_HVLAMBDA.READBACK_LOW_VPROG)

                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = False
                LabelValue10.Visible = False

                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) Then
                CheckBoxStatusBit0.Text = "Cust HV OFF"
                CheckBoxStatusBit1.Text = "Cust X-Ray OFF"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Over PRF"
                CheckBoxStatusBit5.Text = "Only Low"
                CheckBoxStatusBit6.Text = "Only High"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Panel Open"
                CheckBoxFaultBit1.Text = "Keylock"
                CheckBoxFaultBit2.Text = "X-Ray Timing"
                CheckBoxFaultBit3.Text = "Trigger ON"
                CheckBoxFaultBit4.Text = "X-Ray/No HV"
                CheckBoxFaultBit5.Text = "Sync Timeout"
                CheckBoxFaultBit6.Text = "Unused"
                CheckBoxFaultBit7.Text = "Unused"
                CheckBoxFaultBit8.Text = "Unused"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                LabelValue1.Text = "Grid Delay High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_HIGH_INTENSITY_10) And &HFF)
                LabelValue2.Text = "PFN Trigger Delay High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) / 256)
                LabelValue3.Text = "Dose Sample Delay High = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.PFN_DELAY_HIGH_AND_DOSE_SAMPLE_DELAY_HIGH) And &HFF)

                LabelValue4.Text = "Grid Width High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_32) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_WIDTH_HIGH_INTENSITY_10) And &HFF)
                LabelValue5.Text = "AFC Sample Delay High = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) / 256)
                LabelValue6.Text = "Magnetron Sample Delay High = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.AFC_DELAY_HIGH_AND_MAGNETRON_CURRENT_SAMPLE_DELAY_HIGH) And &HFF)

                LabelValue7.Text = "Grid Delay Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(CS_PULSESYNC.GRID_DELAY_LOW_INTENSITY_32) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(6) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(7) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(7) And &HFF)
                LabelValue8.Text = "PFN Trigger Delay Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(8) / 256)
                LabelValue9.Text = "Dose Sample Delay Low = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(8) And &HFF)

                LabelValue10.Text = "Grid Width Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(9) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(9) And &HFF) & ", " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(10) / 256) & ", " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(10) And &HFF)
                LabelValue11.Text = "AFC Sample Delay Low = " & Math.Truncate(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(11) / 256)
                LabelValue12.Text = "Magnetron Sample Delay Low = " & (ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).custom_data(11) And &HFF)



              


                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = True
                LabelValue10.Visible = True

                LabelValue11.Visible = True
                LabelValue12.Visible = True
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = True
                TextBoxPulseSyncValueHighByte.Visible = True
                TextBoxPulseSyncValueLowByte.Visible = True
                ButtonSetPulseSyncRegister.Visible = True


            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT) Then
                CheckBoxStatusBit0.Text = "HIGH MODE"
                CheckBoxStatusBit1.Text = "Arc"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Arc Slow"
                CheckBoxFaultBit1.Text = "Arc Fast"
                CheckBoxFaultBit2.Text = "Arc Cont"
                CheckBoxFaultBit3.Text = "Can FLT"
                CheckBoxFaultBit4.Text = "False Trig"
                CheckBoxFaultBit5.Text = "Unused"
                CheckBoxFaultBit6.Text = "Unused"
                CheckBoxFaultBit7.Text = "Unused"
                CheckBoxFaultBit8.Text = "Unused"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                LabelValue1.Text = "Arcs Today = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(1)
                LabelValue2.Text = "Imon High = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(2)
                LabelValue3.Text = "Imon Low = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(3)
                LabelValue4.Text = "Arcs Total = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(4)
                LabelValue5.Text = "Pulses Today = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(7) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(6)
                LabelValue6.Text = "Pulse Total = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(11) * 2 ^ 48 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(10) * 2 ^ 32 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).custom_data(8)

                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = False
                LabelValue8.Visible = False
                LabelValue9.Visible = False
                LabelValue10.Visible = False

                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False


                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING) Then
                CheckBoxStatusBit0.Text = "SF6 Relay Closed"
                CheckBoxStatusBit1.Text = "SF6 too Cold"
                CheckBoxStatusBit2.Text = "SF6 too Low"
                CheckBoxStatusBit3.Text = "SF6 Need Fill"
                CheckBoxStatusBit4.Text = "SF6 Limit"
                CheckBoxStatusBit5.Text = "SF6 Filling"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Unused"
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
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                LabelValue1.Text = "HVPS Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(0)
                LabelValue2.Text = "Magnetron Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(1)
                LabelValue3.Text = "Linac Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(2)
                LabelValue4.Text = "Circulator Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(3)
                LabelValue5.Text = "HX Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(4)
                LabelValue6.Text = "Spare Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(5)
                LabelValue7.Text = "Coolant Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(6)
                LabelValue8.Text = "SF6 Pressure = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(7)
                LabelValue9.Text = "Cabinent Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(8)
                LabelValue10.Text = "Linac Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(9)


                update_1_cmd_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT
                ButtonUpdateInput1.Text = "Override Pulses"

                update_2_cmd_index = REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE
                ButtonUpdateInput2.Text = "Set Bottle Pulses"

                board_command_index = REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES
                ButtonBoardCommand.Text = "25 SF6 Pulses"


                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = True

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = True
                LabelValue10.Visible = True
                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_AFC) Then
                CheckBoxStatusBit0.Text = "Startup"
                CheckBoxStatusBit1.Text = "Manual"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Can FLT"
                CheckBoxFaultBit1.Text = "Unused"
                CheckBoxFaultBit2.Text = "Unused"
                CheckBoxFaultBit3.Text = "Unused"
                CheckBoxFaultBit4.Text = "Unused"
                CheckBoxFaultBit5.Text = "Unused"
                CheckBoxFaultBit6.Text = "Unused"
                CheckBoxFaultBit7.Text = "Unused"
                CheckBoxFaultBit8.Text = "Unused"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                update_1_cmd_index = REGISTER_CMD_AFC_MANUAL_TARGET_POSITION
                ButtonUpdateInput1.Text = "Manual Position"

                update_2_cmd_index = REGISTER_AFC_AFT_CONTROL_VOLTAGE
                ButtonUpdateInput2.Text = "AFT Control Voltage"

                LabelValue1.Text = "Home Position = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(0)
                LabelValue2.Text = "AFC Offset = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(1)
                LabelValue3.Text = "Readback Home Position = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(2)
                LabelValue4.Text = "Readback Offset = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(3)
                LabelValue5.Text = "Readback Position = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(4)
                LabelValue6.Text = "Previous Error = " & (CInt(ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_D) - CInt(ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_E))
                LabelValue7.Text = "Previous A Sample = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(5)
                LabelValue8.Text = "Previous B Sample = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(6)
                LabelValue9.Text = "AFT Control Voltage = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(9)
                LabelValue10.Text = "Readback AFT Control Voltage = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_AFC).custom_data(10)


                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False


                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = True
                LabelValue10.Visible = True
                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER) Then
                CheckBoxStatusBit0.Text = "HV Disabled"
                CheckBoxStatusBit1.Text = "HTR Off"
                CheckBoxStatusBit2.Text = "Trig Off"
                CheckBoxStatusBit3.Text = "Top Off"
                CheckBoxStatusBit4.Text = "HV Off"
                CheckBoxStatusBit5.Text = "NA"
                CheckBoxStatusBit6.Text = "NA"
                CheckBoxStatusBit7.Text = "NA"

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
                CheckBoxFaultBitF.Text = "NA"

                LabelDebug0.Text = "Ek = "
                LabelDebug1.Text = "Ika = "
                LabelDebug2.Text = "Ikp = "
                LabelDebug3.Text = "Ef = "
                LabelDebug4.Text = "If = "
                LabelDebug5.Text = "Eg = "
                LabelDebug6.Text = "Ec = "
                LabelDebug7.Text = "Temp = "

                LabelDebug8.Text = "State = "
                LabelDebug9.Text = "Debug 9 = "
                LabelDebugA.Text = "Debug A = "
                LabelDebugB.Text = "Debug B = "
                LabelDebugC.Text = "Debug C = "
                LabelDebugD.Text = "Ek Set = "
                LabelDebugE.Text = "Ef Set = "
                LabelDebugF.Text = "Eg Set = "

                update_1_cmd_index = REGISTER_GUN_DRIVER_CATHODE_VOLTAGE
                ButtonUpdateInput1.Text = "Set Ek (0,-20V)"

                update_2_cmd_index = REGISTER_GUN_DRIVER_HEATER_VOLTAGE
                ButtonUpdateInput2.Text = "Set Ef (0,-7V)"

                update_3_cmd_index = REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE
                ButtonUpdateInput3.Text = "Set Eg (-80,140)"

                ' LabelValue2.Text = "NA(Eg Set Lo) = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(1)) * 0.1 'GUN_DRIVER_EG_SET_CAL
                LabelValue1.Text = "Ek Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.CATHODE_VOLTAGE_SET_POINT)) * (-0.001), "0.00kV") 'ekset
                LabelValue2.Text = "Ef Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.HEATER_VOLTAGE_SET_POINT)) * (-0.001), "0.00V") 'efset
                LabelValue3.Text = "Eg Set = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.HIGH_ENERGY_PULSE_TOP_VOLTAGE_SET_POINT)) * 0.1 - 80, "0.0V")  ' egset
                LabelValue4.Text = "Ek = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_CATHODE_VOLTAGE_MONITOR)) * (-0.001), "0.00kV") ' GUN_DRIVER_EK_RD_CAL
                LabelValue5.Text = "Ikp = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_PEAK_BEAM_CURRENT)) * 0.1, "0.0V") ' GUN_DRIVER_IKP_RD_CAL
                LabelValue6.Text = "Ef = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_HEATER_VOLTAGE_MONITOR)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_RD_CAL
                LabelValue7.Text = "If = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_HEATER_CURRENT_MONITOR)) * 0.001, "0.00A") 'GUN_DRIVER_IF_RD_CAL
                LabelValue8.Text = "Eg = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_HIGH_ENERGY_PULSE_TOP_VOLTAGE_MONITOR)) * 0.1 - 80, "0.0V") ' eg rd

                LabelValue9.Text = "Ec = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_BIAS_VOLTAGE_MON)) * 0.1, "0.0V") ' GUN_DRIVER_EC_RD_CAL
                LabelValue10.Text = "Temp = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_DRIVER_TEMPERATURE)) * 0.01, "0.0C") 'GUN_DRIVER_TEMP_RD_CAL
                LabelValue11.Text = "Ek SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_CATHODE_VOLTAGE_SET_POINT)) * (-0.001), "0.00kV") 'GUN_DRIVER_EK_SET_CAL
                LabelValue12.Text = "Ef SetRd = " & Format(Convert.ToUInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_HEATER_VOLTAGE_SET_POINT)) * (-0.001), "0.00V") 'GUN_DRIVER_EF_SET_CAL
                LabelValue13.Text = "Eg SetRd = " & Format(Convert.ToInt16(ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_LOW_ENERGY_PULSE_TOP_SET_POINT)) * 0.1 - 80, "0.0V") 'GUN_DRIVER_EG_SET_CAL

                LabelValue14.Text = "Ana Flt = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_ANALOG_FAULT_STATUS) & _
                     ", state = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_SYSTEM_LOGIC_STATE)
                LabelValue15.Text = "FPGA ASDR = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).custom_data(CS_GD.READBACK_FPGA_ASDR_REGISTER).ToString("x")


                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
                TextBoxInput3.Visible = True
                ButtonUpdateInput3.Visible = True
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = True
                LabelValue4.Visible = True
                LabelValue5.Visible = True
                LabelValue6.Visible = True
                LabelValue7.Visible = True
                LabelValue8.Visible = True
                LabelValue9.Visible = True
                LabelValue10.Visible = True
                LabelValue11.Visible = True
                LabelValue12.Visible = True
                LabelValue13.Visible = True
                LabelValue14.Visible = True
                LabelValue15.Visible = True

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP) Then
                CheckBoxStatusBit0.Text = "Unused"
                CheckBoxStatusBit1.Text = "Unused"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
                CheckBoxStatusBit5.Text = "Unused"
                CheckBoxStatusBit6.Text = "Unused"
                CheckBoxStatusBit7.Text = "Unused"

                CheckBoxFaultBit0.Text = "Unused"
                CheckBoxFaultBit1.Text = "Unused"
                CheckBoxFaultBit2.Text = "Unused"
                CheckBoxFaultBit3.Text = "Unused"
                CheckBoxFaultBit4.Text = "Unused"
                CheckBoxFaultBit5.Text = "Unused"
                CheckBoxFaultBit6.Text = "Unused"
                CheckBoxFaultBit7.Text = "Unused"
                CheckBoxFaultBit8.Text = "Unused"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"

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

                'update_1_cmd_index = REGISTER_CMD_AFC_MANUAL_TARGET_POSITION
                'ButtonUpdateInput1.Text = "Manual Position"

                'update_2_cmd_index = REGISTER_LOW_ENERGY_SET_POINT
                'ButtonUpdateInput2.Text = "Set Low"

                LabelValue1.Text = "Ion Voltage = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).custom_data(0)
                LabelValue2.Text = "Ion Current = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).custom_data(1)

                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = True
                LabelValue2.Visible = True
                LabelValue3.Visible = False
                LabelValue4.Visible = False
                LabelValue5.Visible = False
                LabelValue6.Visible = False
                LabelValue7.Visible = False
                LabelValue8.Visible = False
                LabelValue9.Visible = False
                LabelValue10.Visible = False
                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

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

                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                TextBoxInput3.Visible = False
                ButtonUpdateInput3.Visible = False
                ButtonBoardCommand.Visible = False

                LabelValue1.Visible = False
                LabelValue2.Visible = False
                LabelValue3.Visible = False
                LabelValue4.Visible = False
                LabelValue5.Visible = False
                LabelValue6.Visible = False
                LabelValue7.Visible = False
                LabelValue8.Visible = False
                LabelValue9.Visible = False
                LabelValue10.Visible = False

                LabelValue11.Visible = False
                LabelValue12.Visible = False
                LabelValue13.Visible = False
                LabelValue14.Visible = False
                LabelValue15.Visible = False

                ComboBoxSelectPulseSyncRegister.Visible = False
                TextBoxPulseSyncValueHighByte.Visible = False
                TextBoxPulseSyncValueLowByte.Visible = False
                ButtonSetPulseSyncRegister.Visible = False

            End If

        End If ' connected

        TimerUpdate.Enabled = True

    End Sub


    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            TimerUpdate.Enabled = False
            '     My.Settings.Interval = CUShort(txtInterval.Text)
            '     My.Settings.SerialNumber = CULng(txtSN.Text)
            ServerSettings.Close()
            '  End
        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormClosed  " + ex.ToString)
        End Try

    End Sub

    Private Sub cboIndex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIndex.SelectedIndexChanged
        board_index = cboIndex.SelectedIndex + 1
        TextBoxInput1.Text = ""
        TextBoxInput2.Text = ""
    End Sub


    Public command_count As UInt16


    Private Sub ButtonUpdateInput1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput1.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput1.Text
            ServerSettings.put_modbus_commands(update_1_cmd_index, program_word, 0, 0)
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub


    Private Sub ButtonUpdateInput2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput2.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput2.Text
            ServerSettings.put_modbus_commands(update_2_cmd_index, program_word, 0, 0)
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub

    Private Sub ButtonUpdateInput3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateInput3.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput3.Text
            ServerSettings.put_modbus_commands(update_3_cmd_index, program_word, 0, 0)
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
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


    Private Sub ButtonBoardCommand_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBoardCommand.Click
        ServerSettings.put_modbus_commands(board_command_index, 0, 0, 0)
    End Sub


    Public selected_board_index As UInt16

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
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_LOAD_DEFAULT_SETTINGS_TO_EEPROM_AND_REBOOT, selected_board_index, 0, 0)
    End Sub

    Private Sub ButtonResetSlave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonResetSlave.Click
        ServerSettings.put_modbus_commands(REGISTER_SPECIAL_ECB_RESET_SLAVE, selected_board_index, 0, 0)
    End Sub



    Private Sub ButtonStartLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStartLog.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_ENABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
        ServerSettings.OpenPulseLogFile()
    End Sub

    Private Sub ButtonStopLog_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStopLog.Click
        ServerSettings.ClosePulseLogFile()
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_DISABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
    End Sub

    Private Sub ButtonSetPulseSyncRegister_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetPulseSyncRegister.Click
        Dim program_word As UInt16
        Dim byte_input As Byte
        Try
            byte_input = TextBoxPulseSyncValueLowByte.Text
            program_word = byte_input
            program_word *= 256
            byte_input = TextBoxPulseSyncValueHighByte.Text
            program_word += byte_input

            ServerSettings.put_modbus_commands((ComboBoxSelectPulseSyncRegister.SelectedIndex + REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B), program_word, 0, 0)
        Catch ex As Exception
            MsgBox("You must enter valid Byte data")

        End Try
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
        LabelTimeSet.Text = Format(time_now, "yy MM dd HH mm ss")
        Try
            ServerSettings.put_modbus_commands(REGISTER_SPECIAL_SET_TIME, time_high_word, time_low_word, 0)
        Catch ex As Exception
            MsgBox("Date Time Type conversion failed")

        End Try
    End Sub
End Class