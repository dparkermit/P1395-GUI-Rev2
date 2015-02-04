Public Class frmMain



    Public Const ETHERNET_CMD_HEATER_MAGNET_HEATER_SET_POINT As UInt16 = 0
    Public Const ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT As UInt16 = 1
    Public Const ETHERNET_CMD_HV_LAMBDA_HIGH_SET_POINT As UInt16 = 2
    Public Const ETHERNET_CMD_HV_LAMBDA_LOW_SET_POINT As UInt16 = 3
    Public Const ETHERNET_CMD_HEATER_MAGNET_ON As UInt16 = 4
    Public Const ETHERNET_CMD_HEATER_MAGNET_OFF As UInt16 = 5
    Public Const ETHERNET_CMD_HV_LAMBDA_ON As UInt16 = 6
    Public Const ETHERNET_CMD_HV_LAMBDA_OFF As UInt16 = 7
    Public Const ETHERNET_CMD_RESET_FAULTS As UInt16 = 8
    Public Const ETHERNET_CMD_COOLING_SF6_PULSE_LIMIT_OVERRIDE As UInt16 = 9
    Public Const ETHERNET_CMD_COOLING_SF6_LEAK_LIMIT_OVERRIDE As UInt16 = 10
    Public Const ETHERNET_CMD_COOLING_RESET_BOTTLE_COUNT As UInt16 = 11



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
            CheckBoxStatusBit0.Checked = status_word_0 And &H1
            CheckBoxStatusBit1.Checked = status_word_0 And &H2
            CheckBoxStatusBit2.Checked = status_word_0 And &H4
            CheckBoxStatusBit3.Checked = status_word_0 And &H8
            CheckBoxStatusBit4.Checked = status_word_0 And &H10
            CheckBoxStatusBit5.Checked = status_word_0 And &H20
            CheckBoxStatusBit6.Checked = status_word_0 And &H40
            CheckBoxStatusBit7.Checked = status_word_0 And &H80
            CheckBoxStatusBit8.Checked = status_word_0 And &H100
            CheckBoxStatusBit9.Checked = status_word_0 And &H200
            CheckBoxStatusBit10.Checked = status_word_0 And &H400
            CheckBoxStatusBit11.Checked = status_word_0 And &H800
            CheckBoxStatusBit12.Checked = status_word_0 And &H1000
            CheckBoxStatusBit13.Checked = status_word_0 And &H2000
            CheckBoxStatusBit14.Checked = status_word_0 And &H4000
            CheckBoxStatusBit15.Checked = status_word_0 And &H8000

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
            CheckBoxFaultBit10.Checked = status_word_1 And &H400
            CheckBoxFaultBit11.Checked = status_word_1 And &H800
            CheckBoxFaultBit12.Checked = status_word_1 And &H1000
            CheckBoxFaultBit13.Checked = status_word_1 And &H2000
            CheckBoxFaultBit14.Checked = status_word_1 And &H4000
            CheckBoxFaultBit15.Checked = status_word_1 And &H8000

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
                LabelHtrMagHtrSetPoint.Visible = True
                LabelHtrMagMagSetPoint.Visible = True
                LabelHtrMagHtrImon.Visible = True
                LabelHtrMagHtrVmon.Visible = True
                LabelHtrMagMagImon.Visible = True
                LabelHtrMagMagVmon.Visible = True
                LabelHtrMagHtrSetPointRback.Visible = True
                LabelHtrMagHtrVolSetPointRback.Visible = True
                LabelHtrMagMagSetPointRback.Visible = True
                LabelHtrMagMagVolSetPointRback.Visible = True
                ButtonHtrMagOn.Visible = True
                ButtonHtrMagOff.Visible = True
                TextBoxHtrCurrent.Visible = True
                TextBoxMagCurrent.Visible = True
                ButtonHtrMagSetHtr.Visible = True
                ButtonHtrMagSetMag.Visible = True
            Else
                LabelHtrMagHtrSetPoint.Visible = False
                LabelHtrMagMagSetPoint.Visible = False
                LabelHtrMagHtrImon.Visible = False
                LabelHtrMagHtrVmon.Visible = False
                LabelHtrMagMagImon.Visible = False
                LabelHtrMagMagVmon.Visible = False
                LabelHtrMagHtrSetPointRback.Visible = False
                LabelHtrMagHtrVolSetPointRback.Visible = False
                LabelHtrMagMagSetPointRback.Visible = False
                LabelHtrMagMagVolSetPointRback.Visible = False
                ButtonHtrMagOn.Visible = False
                ButtonHtrMagOff.Visible = False
                TextBoxHtrCurrent.Visible = False
                TextBoxMagCurrent.Visible = False
                ButtonHtrMagSetHtr.Visible = False
                ButtonHtrMagSetMag.Visible = False
            End If

            LabelHtrMagMagSetPoint.Text = "Magnet Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(0)
            LabelHtrMagHtrSetPoint.Text = "Heater Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(1)
            LabelHtrMagHtrImon.Text = "Htr Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(2)
            LabelHtrMagHtrVmon.Text = "Htr Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(3)
            LabelHtrMagMagImon.Text = "Mag Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(4)
            LabelHtrMagMagVmon.Text = "Mag Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(5)
            LabelHtrMagHtrSetPointRback.Text = "Heater Set Readback = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(6)
            LabelHtrMagHtrVolSetPointRback.Text = "Heater Vol Set Readback = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(7)
            LabelHtrMagMagSetPointRback.Text = "Magnet Set Readback= " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(8)
            LabelHtrMagMagVolSetPointRback.Text = "Magnet Vol Set Readback= " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).custom_data(9)




            ' HV Lambda Specific Data
            If (board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) Then
                LabelHVSetHigh.Visible = True
                LabelHVSetLow.Visible = True
                LabelHVEOCNotReached.Visible = True
                LabelHVVmon.Visible = True
                LabelHVImon.Visible = True
                LabelHVBasePlateTemp.Visible = True
                ButtonSetLambdaLow.Visible = True
                ButtonSetLamdbaHigh.Visible = True
                TextBoxLambdaHigh.Visible = True
                TextBoxLambdaLow.Visible = True
                ButtonLambdaOn.Visible = True
                ButtonLambdaoff.Visible = True
            Else
                LabelHVSetHigh.Visible = False
                LabelHVSetLow.Visible = False
                LabelHVEOCNotReached.Visible = False
                LabelHVVmon.Visible = False
                LabelHVImon.Visible = False
                LabelHVBasePlateTemp.Visible = False
                ButtonSetLambdaLow.Visible = False
                ButtonSetLamdbaHigh.Visible = False
                TextBoxLambdaHigh.Visible = False
                TextBoxLambdaLow.Visible = False
                ButtonLambdaOn.Visible = False
                ButtonLambdaoff.Visible = False
            End If
            LabelHVSetHigh.Text = "HVLambda High Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(0)
            LabelHVSetLow.Text = "HVLambda Low Set = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(1)
            LabelHVEOCNotReached.Text = "EOC Error Count = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(2)
            LabelHVVmon.Text = "Vmon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(3)
            LabelHVImon.Text = "Imon = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(4)
            LabelHVBasePlateTemp.Text = "Temp = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).custom_data(5)


            If (board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING) Then
                ButtonSF6PulseLimitOverride.Visible = True
                ButtonSF6LeakLimitOverride.Visible = True
                ButtonSF6BottleReset.Visible = True
                LabelCoolingCabinetTemp.Visible = True
                LabelCoolingCirculatorFlow.Visible = True
                LabelCoolingCoolantTemp.Visible = True
                LabelCoolingLinacFlow.Visible = True
                LabelCoolingMagnetronFlow.Visible = True
                LabelCoolingSF6Pressure.Visible = True
            Else
                ButtonSF6PulseLimitOverride.Visible = False
                ButtonSF6LeakLimitOverride.Visible = False
                ButtonSF6BottleReset.Visible = False
                LabelCoolingCabinetTemp.Visible = False
                LabelCoolingCirculatorFlow.Visible = False
                LabelCoolingCoolantTemp.Visible = False
                LabelCoolingLinacFlow.Visible = False
                LabelCoolingMagnetronFlow.Visible = False
                LabelCoolingSF6Pressure.Visible = False
            End If

            LabelCoolingCabinetTemp.Text = "Cabinet Temperature = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(10) / 100 - 273
            LabelCoolingCirculatorFlow.Text = "Circulator Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(3) / 100
            LabelCoolingCoolantTemp.Text = "Coolant Temperature = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(8) / 100 - 273
            LabelCoolingLinacFlow.Text = "Linac Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(0) / 100
            LabelCoolingMagnetronFlow.Text = "Magnetron Flow = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(1) / 1000
            LabelCoolingSF6Pressure.Text = "SF6 Pressure = " & ServerSettings.ETMEthernetTXDataStructure(MODBUS_COMMANDS.MODBUS_WR_COOLING).custom_data(9) / 100



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

    Private Sub ButtonSetLamdbaHigh_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetLamdbaHigh.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxLambdaHigh.Text
            ServerSettings.command_index = ETHERNET_CMD_HV_LAMBDA_HIGH_SET_POINT
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try

    End Sub

    Private Sub ButtonSetLambdaLow_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetLambdaLow.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxLambdaLow.Text
            ServerSettings.command_index = ETHERNET_CMD_HV_LAMBDA_LOW_SET_POINT
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub

    Private Sub ButtonLambdaOn_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLambdaOn.Click
        ServerSettings.command_index = ETHERNET_CMD_HV_LAMBDA_ON
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonLambdaoff_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLambdaoff.Click
        ServerSettings.command_index = ETHERNET_CMD_HV_LAMBDA_OFF
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonResetAllFaults_Click(sender As System.Object, e As System.EventArgs) Handles ButtonResetAllFaults.Click
        ServerSettings.command_index = ETHERNET_CMD_RESET_FAULTS
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonHtrMagOn_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHtrMagOn.Click
        ServerSettings.command_index = ETHERNET_CMD_HEATER_MAGNET_ON
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonHtrMagOff_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHtrMagOff.Click
        ServerSettings.command_index = ETHERNET_CMD_HEATER_MAGNET_OFF
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonHtrMagSetHtr_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHtrMagSetHtr.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxHtrCurrent.Text
            ServerSettings.command_index = ETHERNET_CMD_HEATER_MAGNET_HEATER_SET_POINT
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub

    Private Sub ButtonHtrMagSetMag_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHtrMagSetMag.Click
        Dim program_word As UInt16
        Try
            program_word = TextBoxMagCurrent.Text
            ServerSettings.command_index = ETHERNET_CMD_HEATER_MAGNET_MAGNET_SET_POINT
            ServerSettings.command_data = program_word
            command_count = command_count + 1
            ServerSettings.command_ready = command_count
        Catch ex As Exception
            MsgBox("You must enter valid Integer data")

        End Try
    End Sub

    Private Sub ButtonSF6Open_Click(sender As System.Object, e As EventArgs) Handles ButtonSF6LeakLimitOverride.Click
        ServerSettings.command_index = ETHERNET_CMD_COOLING_SF6_LEAK_LIMIT_OVERRIDE
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub

    Private Sub ButtonSF6Close_Click(sender As System.Object, e As EventArgs) Handles ButtonSF6PulseLimitOverride.Click
        ServerSettings.command_index = ETHERNET_CMD_COOLING_SF6_PULSE_LIMIT_OVERRIDE
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSF6BottleReset.Click
        ServerSettings.command_index = ETHERNET_CMD_COOLING_RESET_BOTTLE_COUNT
        ServerSettings.command_data = 0
        command_count = command_count + 1
        ServerSettings.command_ready = command_count
    End Sub
End Class