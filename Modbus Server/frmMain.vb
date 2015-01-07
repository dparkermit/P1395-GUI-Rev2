Public Class frmMain



    Public Const ETHERNET_CMD_HEATER_MAGNET_HEATER_SET_POINT As UInt16 = 0
    Public Const ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT As UInt16 = 1
    Public Const ETHERNET_CMD_HV_LAMBDA_HIGH_SET_POINT As UInt16 = 2
    Public Const ETHERNET_CMD_HV_LAMBDA_LOW_SET_POINT As UInt16 = 3
    Public Const PULSE_SYNC_SEND_DEFAULT_CMD As UInt16 = 4


    Public Const ETHERNET_TOGGLE_RESET As UInt16 = 20
    Public Const ETHERNET_TOGGLE_HIGH_SPEED_LOGGING As UInt16 = 21
    Public Const PULSE_SYNC_TOGGLE_HV_ENABLE As UInt16 = 22
    Public Const PULSE_SYNC_TOGGLE_XRAY_ENABLE As UInt16 = 23
    Public Const ETHERNET_CMD_TOGGLE_COOLANT_FAULT_BIT As UInt16 = 24

    Public Const ETHERNET_CMD_UNKNOWN As UInt16 = 255

    Public update_1_cmd_index As UInt16
    Public update_2_cmd_index As UInt16

    Public board_command_index As UInt16



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
            LabelCanISREnteredCount.Text = "ISR Entered Cnt = " & ServerSettings.ETMEthernetTXDataStructure(board_index).can_status.can_status_isr_entered
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
            LabelErrorTBD1.Text = "N/A"
            LabelErrorTBD2.Text = "N/A"

            LabelDebug0.Text = "Debug 0 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_0
            LabelDebug1.Text = "Debug 1 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_1
            LabelDebug2.Text = "Debug 2 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_2
            LabelDebug3.Text = "Debug 3 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_3
            LabelDebug4.Text = "Debug 4 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_4
            LabelDebug5.Text = "Debug 5 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_5
            LabelDebug6.Text = "Debug 6 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_6
            LabelDebug7.Text = "Debug 7 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_7

            LabelDebug8.Text = "Debug 8 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_8
            LabelDebug9.Text = "Debug 9 = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_9
            LabelDebugA.Text = "Debug A = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_A
            LabelDebugB.Text = "Debug B = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_B
            LabelDebugC.Text = "Debug C = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_C
            LabelDebugD.Text = "Debug D = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_D
            LabelDebugE.Text = "Debug E = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_E
            LabelDebugF.Text = "Debug F = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.debug_F


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

                update_1_cmd_index = ETHERNET_CMD_HEATER_MAGNET_HEATER_SET_POINT
                ButtonUpdateInput1.Text = "Set Heater"

                update_2_cmd_index = ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT
                ButtonUpdateInput2.Text = "Set Magnet"

                LabelValue1.Text = "Magnet Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(0)
                LabelValue2.Text = "Heater Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(1)
                LabelValue3.Text = "Htr Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(2)
                LabelValue4.Text = "Htr Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(3)
                LabelValue5.Text = "Mag Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(4)
                LabelValue6.Text = "Mag Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(5)
                LabelValue7.Text = "Heater Set Readback = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(6)
                LabelValue8.Text = "Heater Vol Set Readback = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(7)
                LabelValue9.Text = "Magnet Set Readback= " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(8)
                LabelValue10.Text = "Magnet Vol Set Readback= " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(9)


                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
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

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
                CheckBoxStatusBit0.Text = "AT EOC"
                CheckBoxStatusBit1.Text = "HIGH MODE"
                CheckBoxStatusBit2.Text = "Unused"
                CheckBoxStatusBit3.Text = "Unused"
                CheckBoxStatusBit4.Text = "Unused"
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
                CheckBoxFaultBit7.Text = "Can FLT"
                CheckBoxFaultBit8.Text = "Unused"
                CheckBoxFaultBit9.Text = "Unused"
                CheckBoxFaultBitA.Text = "Unused"
                CheckBoxFaultBitB.Text = "Unused"
                CheckBoxFaultBitC.Text = "Unused"
                CheckBoxFaultBitD.Text = "Unused"
                CheckBoxFaultBitE.Text = "Unused"
                CheckBoxFaultBitF.Text = "Unused"



                update_1_cmd_index = ETHERNET_CMD_HV_LAMBDA_HIGH_SET_POINT
                ButtonUpdateInput1.Text = "Set High"

                update_2_cmd_index = ETHERNET_CMD_HV_LAMBDA_LOW_SET_POINT
                ButtonUpdateInput2.Text = "Set Low"

                LabelValue1.Text = "HVLambda High Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(0)
                LabelValue2.Text = "HVLambda Low Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(1)
                LabelValue3.Text = "EOC Error Count = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(2)
                LabelValue4.Text = "Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(3)
                LabelValue5.Text = "Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(4)
                LabelValue6.Text = "Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(5)

                TextBoxInput1.Visible = True
                ButtonUpdateInput1.Visible = True
                TextBoxInput2.Visible = True
                ButtonUpdateInput2.Visible = True
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

            ElseIf (board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC) Then
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

                ButtonBoardCommand.Text = "Send Config"
                board_command_index = PULSE_SYNC_SEND_DEFAULT_CMD

                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
                ButtonBoardCommand.Visible = True

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


                TextBoxInput1.Visible = False
                ButtonUpdateInput1.Visible = False
                TextBoxInput2.Visible = False
                ButtonUpdateInput2.Visible = False
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
    End Sub


    Public command_count As UInt16




    Private Sub ButtonHtrMagSetMag_Click(sender As System.Object, e As System.EventArgs)
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput2.Text
            ServerSettings.command_index = ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub


    Private Sub ButtonUpdateInput1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput1.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput1.Text
            ServerSettings.command_index = update_1_cmd_index
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub

    Private Sub ButtonUpdateInput2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdateInput2.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxInput2.Text
            ServerSettings.command_index = update_2_cmd_index
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub



    Private Sub ButtonToggleReset_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleReset.Click
        ServerSettings.command_index = ETHERNET_TOGGLE_RESET
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonToggleHighSpeedDataLogging_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleHighSpeedDataLogging.Click
        ServerSettings.command_index = ETHERNET_TOGGLE_HIGH_SPEED_LOGGING
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub


    Private Sub ButtonTogglePulseSyncHV_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTogglePulseSyncHV.Click
        ServerSettings.command_index = PULSE_SYNC_TOGGLE_HV_ENABLE
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonTogglePulseSyncXray_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTogglePulseSyncXray.Click
        ServerSettings.command_index = PULSE_SYNC_TOGGLE_XRAY_ENABLE
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonToggleCoolantFault_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToggleCoolantFault.Click
        ServerSettings.command_index = ETHERNET_CMD_TOGGLE_COOLANT_FAULT_BIT
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonBoardCommand_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBoardCommand.Click
        ServerSettings.command_index = board_command_index
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub
End Class