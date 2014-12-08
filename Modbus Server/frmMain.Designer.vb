<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatusWord0 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLastCustomData = New System.Windows.Forms.Label()
        Me.lblStatusWord1Mask = New System.Windows.Forms.Label()
        Me.lblfStatusWord0Mask = New System.Windows.Forms.Label()
        Me.lblStatusWordB = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStatusWordA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatusWord1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCmdReady = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCmdIndex = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCmdData = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status Word0"
        '
        'lblStatusWord0
        '
        Me.lblStatusWord0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatusWord0.Location = New System.Drawing.Point(92, 33)
        Me.lblStatusWord0.Name = "lblStatusWord0"
        Me.lblStatusWord0.Size = New System.Drawing.Size(75, 13)
        Me.lblStatusWord0.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLastCustomData)
        Me.GroupBox1.Controls.Add(Me.lblStatusWord1Mask)
        Me.GroupBox1.Controls.Add(Me.lblfStatusWord0Mask)
        Me.GroupBox1.Controls.Add(Me.lblStatusWordB)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblStatusWordA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblStatusWord1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblStatusWord0)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status Data"
        '
        'lblLastCustomData
        '
        Me.lblLastCustomData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastCustomData.Location = New System.Drawing.Point(343, 121)
        Me.lblLastCustomData.Name = "lblLastCustomData"
        Me.lblLastCustomData.Size = New System.Drawing.Size(75, 13)
        Me.lblLastCustomData.TabIndex = 0
        '
        'lblStatusWord1Mask
        '
        Me.lblStatusWord1Mask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatusWord1Mask.Location = New System.Drawing.Point(343, 62)
        Me.lblStatusWord1Mask.Name = "lblStatusWord1Mask"
        Me.lblStatusWord1Mask.Size = New System.Drawing.Size(75, 13)
        Me.lblStatusWord1Mask.TabIndex = 0
        '
        'lblfStatusWord0Mask
        '
        Me.lblfStatusWord0Mask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfStatusWord0Mask.Location = New System.Drawing.Point(343, 35)
        Me.lblfStatusWord0Mask.Name = "lblfStatusWord0Mask"
        Me.lblfStatusWord0Mask.Size = New System.Drawing.Size(75, 13)
        Me.lblfStatusWord0Mask.TabIndex = 0
        '
        'lblStatusWordB
        '
        Me.lblStatusWordB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatusWordB.Location = New System.Drawing.Point(92, 128)
        Me.lblStatusWordB.Name = "lblStatusWordB"
        Me.lblStatusWordB.Size = New System.Drawing.Size(75, 13)
        Me.lblStatusWordB.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Last Word Of Custom Data"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Status Word1 Fault Mask"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Status Word0 Inh Mask"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Status WordB"
        '
        'lblStatusWordA
        '
        Me.lblStatusWordA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatusWordA.Location = New System.Drawing.Point(92, 95)
        Me.lblStatusWordA.Name = "lblStatusWordA"
        Me.lblStatusWordA.Size = New System.Drawing.Size(75, 13)
        Me.lblStatusWordA.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Status WordA"
        '
        'lblStatusWord1
        '
        Me.lblStatusWord1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatusWord1.Location = New System.Drawing.Point(92, 63)
        Me.lblStatusWord1.Name = "lblStatusWord1"
        Me.lblStatusWord1.Size = New System.Drawing.Size(75, 13)
        Me.lblStatusWord1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status Word1"
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Items.AddRange(New Object() {"MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9), "MODBUS_WR_ION_PUMP", "MODBUS_WR_AFC", "MODBUS_WR_COOLING", "MODBUS_WR_HTR_MAGNET", "MODBUS_WR_GUN_DRIVER", "MODBUS_WR_MAGNETRON_CURRENT", "MODBUS_WR_PULSE_SYNC", "MODBUS_WR_ETHERNET"})
        Me.cboIndex.Location = New System.Drawing.Point(794, 149)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(171, 21)
        Me.cboIndex.TabIndex = 2
        Me.cboIndex.Text = "MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(794, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Choose a board:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Command Ready"
        '
        'txtCmdReady
        '
        Me.txtCmdReady.Location = New System.Drawing.Point(81, 279)
        Me.txtCmdReady.MaxLength = 5
        Me.txtCmdReady.Name = "txtCmdReady"
        Me.txtCmdReady.Size = New System.Drawing.Size(100, 20)
        Me.txtCmdReady.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Command Index"
        '
        'txtCmdIndex
        '
        Me.txtCmdIndex.Location = New System.Drawing.Point(81, 329)
        Me.txtCmdIndex.MaxLength = 5
        Me.txtCmdIndex.Name = "txtCmdIndex"
        Me.txtCmdIndex.Size = New System.Drawing.Size(100, 20)
        Me.txtCmdIndex.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Command Data"
        '
        'txtCmdData
        '
        Me.txtCmdData.Location = New System.Drawing.Point(81, 378)
        Me.txtCmdData.MaxLength = 5
        Me.txtCmdData.Name = "txtCmdData"
        Me.txtCmdData.Size = New System.Drawing.Size(100, 20)
        Me.txtCmdData.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 435)
        Me.Controls.Add(Me.txtCmdData)
        Me.Controls.Add(Me.txtCmdIndex)
        Me.Controls.Add(Me.txtCmdReady)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmMain"
        Me.Text = "A36507 Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatusWord0 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatusWordB As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblStatusWordA As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStatusWord1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStatusWord1Mask As System.Windows.Forms.Label
    Friend WithEvents lblfStatusWord0Mask As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCmdReady As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCmdIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCmdData As System.Windows.Forms.TextBox
    Friend WithEvents lblLastCustomData As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
