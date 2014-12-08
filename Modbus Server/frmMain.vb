Public Class frmMain


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


            '   If (ServerSettings.update_loop_count > 0) Then
            '  Call datalog()
            lblStatusWord0.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_0.ToString("x")
            lblStatusWord1.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_1.ToString("x")
            lblStatusWordA.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_A.ToString("x")
            lblStatusWordB.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.data_word_B.ToString("x")

            lblfStatusWord0Mask.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_0_inhbit_mask.ToString("x")
            lblStatusWord1Mask.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).status_data.status_word_1_fault_mask.ToString("x")

            ivalue = ServerSettings.ETMEthernetTXDataStructure(board_index).custom_data_word_count
            lblLastCustomData.Text = ServerSettings.ETMEthernetTXDataStructure(board_index).custom_data(ivalue - 1).ToString("x")

            'End If ' loop count > 0, data valid


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

    Private Sub txtCmdReady_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCmdReady.TextChanged
        ServerSettings.command_ready = Val(txtCmdReady.Text)
    End Sub

    Private Sub txtCmdIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCmdIndex.TextChanged
        ServerSettings.command_index = Val(txtCmdIndex.Text)
    End Sub

    Private Sub txtCmdData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCmdData.TextChanged
        ServerSettings.command_data = Val(txtCmdData.Text)
    End Sub
End Class