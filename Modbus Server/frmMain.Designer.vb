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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCoolingCabinetTemp = New System.Windows.Forms.Label()
        Me.LabelCoolingSF6Pressure = New System.Windows.Forms.Label()
        Me.LabelCoolingCoolantTemp = New System.Windows.Forms.Label()
        Me.LabelCoolingCirculatorFlow = New System.Windows.Forms.Label()
        Me.LabelCoolingLinacFlow = New System.Windows.Forms.Label()
        Me.LabelCoolingMagnetronFlow = New System.Windows.Forms.Label()
        Me.ButtonSF6PulseLimitOverride = New System.Windows.Forms.Button()
        Me.ButtonSF6LeakLimitOverride = New System.Windows.Forms.Button()
        Me.LabelHtrMagMagVolSetPointRback = New System.Windows.Forms.Label()
        Me.ButtonResetAllFaults = New System.Windows.Forms.Button()
        Me.ButtonHtrMagOn = New System.Windows.Forms.Button()
        Me.LabelHtrMagMagSetPointRback = New System.Windows.Forms.Label()
        Me.ButtonLambdaOn = New System.Windows.Forms.Button()
        Me.ButtonHtrMagOff = New System.Windows.Forms.Button()
        Me.ButtonLambdaoff = New System.Windows.Forms.Button()
        Me.LabelHtrMagHtrVolSetPointRback = New System.Windows.Forms.Label()
        Me.LabelHtrMagMagVmon = New System.Windows.Forms.Label()
        Me.LabelHtrMagHtrSetPointRback = New System.Windows.Forms.Label()
        Me.LabelHtrMagMagImon = New System.Windows.Forms.Label()
        Me.LabelHtrMagHtrVmon = New System.Windows.Forms.Label()
        Me.TextBoxHtrCurrent = New System.Windows.Forms.TextBox()
        Me.LabelHtrMagHtrImon = New System.Windows.Forms.Label()
        Me.TextBoxLambdaHigh = New System.Windows.Forms.TextBox()
        Me.ButtonHtrMagSetHtr = New System.Windows.Forms.Button()
        Me.LabelFirmwareVerssion = New System.Windows.Forms.Label()
        Me.LabelHtrMagHtrSetPoint = New System.Windows.Forms.Label()
        Me.LabelAgileInfo = New System.Windows.Forms.Label()
        Me.TextBoxMagCurrent = New System.Windows.Forms.TextBox()
        Me.LabelErrorTBD2 = New System.Windows.Forms.Label()
        Me.LabelHtrMagMagSetPoint = New System.Windows.Forms.Label()
        Me.LabelErrorTBD1 = New System.Windows.Forms.Label()
        Me.ButtonHtrMagSetMag = New System.Windows.Forms.Button()
        Me.LabelErrorSelfTestResultRegister = New System.Windows.Forms.Label()
        Me.LabelErrorResetCount = New System.Windows.Forms.Label()
        Me.LabelErrorScaleCount = New System.Windows.Forms.Label()
        Me.LabelErrorCanBusCount = New System.Windows.Forms.Label()
        Me.LabelErrorSPIBusCount = New System.Windows.Forms.Label()
        Me.LabelErrorI2CBusCount = New System.Windows.Forms.Label()
        Me.LabelDebugF = New System.Windows.Forms.Label()
        Me.LabelDebugE = New System.Windows.Forms.Label()
        Me.LabelDebugD = New System.Windows.Forms.Label()
        Me.LabelDebugC = New System.Windows.Forms.Label()
        Me.LabelDebugB = New System.Windows.Forms.Label()
        Me.LabelDebugA = New System.Windows.Forms.Label()
        Me.LabelDebug9 = New System.Windows.Forms.Label()
        Me.LabelDebug8 = New System.Windows.Forms.Label()
        Me.LabelDebug7 = New System.Windows.Forms.Label()
        Me.LabelDebug6 = New System.Windows.Forms.Label()
        Me.LabelDebug5 = New System.Windows.Forms.Label()
        Me.LabelDebug4 = New System.Windows.Forms.Label()
        Me.LabelDebug3 = New System.Windows.Forms.Label()
        Me.LabelDebug2 = New System.Windows.Forms.Label()
        Me.LabelDebug1 = New System.Windows.Forms.Label()
        Me.LabelDebug0 = New System.Windows.Forms.Label()
        Me.LabelCanTimeoutCount = New System.Windows.Forms.Label()
        Me.LabelCAnDataLogRXBufferOVerflowCount = New System.Windows.Forms.Label()
        Me.LabelCanRXBufferOverflowCount = New System.Windows.Forms.Label()
        Me.LabelCanTXBufOverflowCount = New System.Windows.Forms.Label()
        Me.LabelCanTX0Count = New System.Windows.Forms.Label()
        Me.LabelCanAddressErrorCount = New System.Windows.Forms.Label()
        Me.LabelCanInvalidIndexCount = New System.Windows.Forms.Label()
        Me.LabelCanUnknownIdentifierCount = New System.Windows.Forms.Label()
        Me.LabelCanISREnteredCount = New System.Windows.Forms.Label()
        Me.LabelCanRX1Filt2Count = New System.Windows.Forms.Label()
        Me.LabelCanRX0Filt1Count = New System.Windows.Forms.Label()
        Me.LabelCanRX0Filt0Count = New System.Windows.Forms.Label()
        Me.LabelCanTX2Count = New System.Windows.Forms.Label()
        Me.LabelCanTX1Count = New System.Windows.Forms.Label()
        Me.LabelCanErrorFlagCount = New System.Windows.Forms.Label()
        Me.LabelCanCXECReg = New System.Windows.Forms.Label()
        Me.CheckBoxFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.ButtonSetLambdaLow = New System.Windows.Forms.Button()
        Me.ButtonSetLamdbaHigh = New System.Windows.Forms.Button()
        Me.TextBoxLambdaLow = New System.Windows.Forms.TextBox()
        Me.LabelHVBasePlateTemp = New System.Windows.Forms.Label()
        Me.LabelHVImon = New System.Windows.Forms.Label()
        Me.LabelHVVmon = New System.Windows.Forms.Label()
        Me.LabelHVEOCNotReached = New System.Windows.Forms.Label()
        Me.LabelHVSetLow = New System.Windows.Forms.Label()
        Me.LabelHVSetHigh = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSF6BottleReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSF6BottleReset)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingCabinetTemp)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingSF6Pressure)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingCoolantTemp)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingCirculatorFlow)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingLinacFlow)
        Me.GroupBox1.Controls.Add(Me.LabelCoolingMagnetronFlow)
        Me.GroupBox1.Controls.Add(Me.ButtonSF6PulseLimitOverride)
        Me.GroupBox1.Controls.Add(Me.ButtonSF6LeakLimitOverride)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagMagVolSetPointRback)
        Me.GroupBox1.Controls.Add(Me.ButtonResetAllFaults)
        Me.GroupBox1.Controls.Add(Me.ButtonHtrMagOn)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagMagSetPointRback)
        Me.GroupBox1.Controls.Add(Me.ButtonLambdaOn)
        Me.GroupBox1.Controls.Add(Me.ButtonHtrMagOff)
        Me.GroupBox1.Controls.Add(Me.ButtonLambdaoff)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagHtrVolSetPointRback)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagMagVmon)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagHtrSetPointRback)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagMagImon)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagHtrVmon)
        Me.GroupBox1.Controls.Add(Me.TextBoxHtrCurrent)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagHtrImon)
        Me.GroupBox1.Controls.Add(Me.TextBoxLambdaHigh)
        Me.GroupBox1.Controls.Add(Me.ButtonHtrMagSetHtr)
        Me.GroupBox1.Controls.Add(Me.LabelFirmwareVerssion)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagHtrSetPoint)
        Me.GroupBox1.Controls.Add(Me.LabelAgileInfo)
        Me.GroupBox1.Controls.Add(Me.TextBoxMagCurrent)
        Me.GroupBox1.Controls.Add(Me.LabelErrorTBD2)
        Me.GroupBox1.Controls.Add(Me.LabelHtrMagMagSetPoint)
        Me.GroupBox1.Controls.Add(Me.LabelErrorTBD1)
        Me.GroupBox1.Controls.Add(Me.ButtonHtrMagSetMag)
        Me.GroupBox1.Controls.Add(Me.LabelErrorSelfTestResultRegister)
        Me.GroupBox1.Controls.Add(Me.LabelErrorResetCount)
        Me.GroupBox1.Controls.Add(Me.LabelErrorScaleCount)
        Me.GroupBox1.Controls.Add(Me.LabelErrorCanBusCount)
        Me.GroupBox1.Controls.Add(Me.LabelErrorSPIBusCount)
        Me.GroupBox1.Controls.Add(Me.LabelErrorI2CBusCount)
        Me.GroupBox1.Controls.Add(Me.LabelDebugF)
        Me.GroupBox1.Controls.Add(Me.LabelDebugE)
        Me.GroupBox1.Controls.Add(Me.LabelDebugD)
        Me.GroupBox1.Controls.Add(Me.LabelDebugC)
        Me.GroupBox1.Controls.Add(Me.LabelDebugB)
        Me.GroupBox1.Controls.Add(Me.LabelDebugA)
        Me.GroupBox1.Controls.Add(Me.LabelDebug9)
        Me.GroupBox1.Controls.Add(Me.LabelDebug8)
        Me.GroupBox1.Controls.Add(Me.LabelDebug7)
        Me.GroupBox1.Controls.Add(Me.LabelDebug6)
        Me.GroupBox1.Controls.Add(Me.LabelDebug5)
        Me.GroupBox1.Controls.Add(Me.LabelDebug4)
        Me.GroupBox1.Controls.Add(Me.LabelDebug3)
        Me.GroupBox1.Controls.Add(Me.LabelDebug2)
        Me.GroupBox1.Controls.Add(Me.LabelDebug1)
        Me.GroupBox1.Controls.Add(Me.LabelDebug0)
        Me.GroupBox1.Controls.Add(Me.LabelCanTimeoutCount)
        Me.GroupBox1.Controls.Add(Me.LabelCAnDataLogRXBufferOVerflowCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanRXBufferOverflowCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanTXBufOverflowCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanTX0Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanAddressErrorCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanInvalidIndexCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanUnknownIdentifierCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanISREnteredCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanRX1Filt2Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanRX0Filt1Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanRX0Filt0Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanTX2Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanTX1Count)
        Me.GroupBox1.Controls.Add(Me.LabelCanErrorFlagCount)
        Me.GroupBox1.Controls.Add(Me.LabelCanCXECReg)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit15)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit14)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit13)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit12)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit11)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit10)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit9)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit8)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit7)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit6)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit5)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit4)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBit0)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit15)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit14)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit13)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit12)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit11)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit10)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit9)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit8)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit7)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit6)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit5)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit4)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit0)
        Me.GroupBox1.Controls.Add(Me.ButtonSetLambdaLow)
        Me.GroupBox1.Controls.Add(Me.ButtonSetLamdbaHigh)
        Me.GroupBox1.Controls.Add(Me.TextBoxLambdaLow)
        Me.GroupBox1.Controls.Add(Me.LabelHVBasePlateTemp)
        Me.GroupBox1.Controls.Add(Me.LabelHVImon)
        Me.GroupBox1.Controls.Add(Me.LabelHVVmon)
        Me.GroupBox1.Controls.Add(Me.LabelHVEOCNotReached)
        Me.GroupBox1.Controls.Add(Me.LabelHVSetLow)
        Me.GroupBox1.Controls.Add(Me.LabelHVSetHigh)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 582)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status Data"
        '
        'LabelCoolingCabinetTemp
        '
        Me.LabelCoolingCabinetTemp.AutoSize = True
        Me.LabelCoolingCabinetTemp.Cursor = System.Windows.Forms.Cursors.No
        Me.LabelCoolingCabinetTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingCabinetTemp.Location = New System.Drawing.Point(430, 489)
        Me.LabelCoolingCabinetTemp.Name = "LabelCoolingCabinetTemp"
        Me.LabelCoolingCabinetTemp.Size = New System.Drawing.Size(170, 16)
        Me.LabelCoolingCabinetTemp.TabIndex = 229
        Me.LabelCoolingCabinetTemp.Text = "LabelCoolingCabinetTemp"
        '
        'LabelCoolingSF6Pressure
        '
        Me.LabelCoolingSF6Pressure.AutoSize = True
        Me.LabelCoolingSF6Pressure.Cursor = System.Windows.Forms.Cursors.No
        Me.LabelCoolingSF6Pressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingSF6Pressure.Location = New System.Drawing.Point(430, 473)
        Me.LabelCoolingSF6Pressure.Name = "LabelCoolingSF6Pressure"
        Me.LabelCoolingSF6Pressure.Size = New System.Drawing.Size(166, 16)
        Me.LabelCoolingSF6Pressure.TabIndex = 228
        Me.LabelCoolingSF6Pressure.Text = "LabelCoolingSF6Pressure"
        '
        'LabelCoolingCoolantTemp
        '
        Me.LabelCoolingCoolantTemp.AutoSize = True
        Me.LabelCoolingCoolantTemp.Cursor = System.Windows.Forms.Cursors.No
        Me.LabelCoolingCoolantTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingCoolantTemp.Location = New System.Drawing.Point(430, 457)
        Me.LabelCoolingCoolantTemp.Name = "LabelCoolingCoolantTemp"
        Me.LabelCoolingCoolantTemp.Size = New System.Drawing.Size(170, 16)
        Me.LabelCoolingCoolantTemp.TabIndex = 227
        Me.LabelCoolingCoolantTemp.Text = "LabelCoolingCoolantTemp"
        '
        'LabelCoolingCirculatorFlow
        '
        Me.LabelCoolingCirculatorFlow.AutoSize = True
        Me.LabelCoolingCirculatorFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingCirculatorFlow.Location = New System.Drawing.Point(430, 441)
        Me.LabelCoolingCirculatorFlow.Name = "LabelCoolingCirculatorFlow"
        Me.LabelCoolingCirculatorFlow.Size = New System.Drawing.Size(172, 16)
        Me.LabelCoolingCirculatorFlow.TabIndex = 226
        Me.LabelCoolingCirculatorFlow.Text = "LabelCoolingCirculatorFlow"
        '
        'LabelCoolingLinacFlow
        '
        Me.LabelCoolingLinacFlow.AutoSize = True
        Me.LabelCoolingLinacFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingLinacFlow.Location = New System.Drawing.Point(430, 425)
        Me.LabelCoolingLinacFlow.Name = "LabelCoolingLinacFlow"
        Me.LabelCoolingLinacFlow.Size = New System.Drawing.Size(148, 16)
        Me.LabelCoolingLinacFlow.TabIndex = 225
        Me.LabelCoolingLinacFlow.Text = "LabelCoolingLinacFlow"
        '
        'LabelCoolingMagnetronFlow
        '
        Me.LabelCoolingMagnetronFlow.AutoSize = True
        Me.LabelCoolingMagnetronFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolingMagnetronFlow.Location = New System.Drawing.Point(430, 409)
        Me.LabelCoolingMagnetronFlow.Name = "LabelCoolingMagnetronFlow"
        Me.LabelCoolingMagnetronFlow.Size = New System.Drawing.Size(180, 16)
        Me.LabelCoolingMagnetronFlow.TabIndex = 224
        Me.LabelCoolingMagnetronFlow.Text = "LabelCoolingMagnetronFlow"
        '
        'ButtonSF6PulseLimitOverride
        '
        Me.ButtonSF6PulseLimitOverride.Location = New System.Drawing.Point(539, 375)
        Me.ButtonSF6PulseLimitOverride.Name = "ButtonSF6PulseLimitOverride"
        Me.ButtonSF6PulseLimitOverride.Size = New System.Drawing.Size(147, 23)
        Me.ButtonSF6PulseLimitOverride.TabIndex = 223
        Me.ButtonSF6PulseLimitOverride.Text = "SF6 Pulse Limit Override"
        Me.ButtonSF6PulseLimitOverride.UseMnemonic = False
        Me.ButtonSF6PulseLimitOverride.UseVisualStyleBackColor = True
        '
        'ButtonSF6LeakLimitOverride
        '
        Me.ButtonSF6LeakLimitOverride.Location = New System.Drawing.Point(539, 348)
        Me.ButtonSF6LeakLimitOverride.Name = "ButtonSF6LeakLimitOverride"
        Me.ButtonSF6LeakLimitOverride.Size = New System.Drawing.Size(147, 23)
        Me.ButtonSF6LeakLimitOverride.TabIndex = 222
        Me.ButtonSF6LeakLimitOverride.Text = "SF6 Low Pressure Override"
        Me.ButtonSF6LeakLimitOverride.UseVisualStyleBackColor = True
        '
        'LabelHtrMagMagVolSetPointRback
        '
        Me.LabelHtrMagMagVolSetPointRback.AutoSize = True
        Me.LabelHtrMagMagVolSetPointRback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagMagVolSetPointRback.Location = New System.Drawing.Point(430, 553)
        Me.LabelHtrMagMagVolSetPointRback.Name = "LabelHtrMagMagVolSetPointRback"
        Me.LabelHtrMagMagVolSetPointRback.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagMagVolSetPointRback.TabIndex = 221
        Me.LabelHtrMagMagVolSetPointRback.Text = "LabelHtrMag"
        '
        'ButtonResetAllFaults
        '
        Me.ButtonResetAllFaults.Location = New System.Drawing.Point(266, 394)
        Me.ButtonResetAllFaults.Name = "ButtonResetAllFaults"
        Me.ButtonResetAllFaults.Size = New System.Drawing.Size(100, 23)
        Me.ButtonResetAllFaults.TabIndex = 205
        Me.ButtonResetAllFaults.Text = "Reset All Faults"
        Me.ButtonResetAllFaults.UseVisualStyleBackColor = True
        '
        'ButtonHtrMagOn
        '
        Me.ButtonHtrMagOn.Location = New System.Drawing.Point(539, 293)
        Me.ButtonHtrMagOn.Name = "ButtonHtrMagOn"
        Me.ButtonHtrMagOn.Size = New System.Drawing.Size(100, 23)
        Me.ButtonHtrMagOn.TabIndex = 217
        Me.ButtonHtrMagOn.Text = "Htr Mag On"
        Me.ButtonHtrMagOn.UseVisualStyleBackColor = True
        '
        'LabelHtrMagMagSetPointRback
        '
        Me.LabelHtrMagMagSetPointRback.AutoSize = True
        Me.LabelHtrMagMagSetPointRback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagMagSetPointRback.Location = New System.Drawing.Point(430, 537)
        Me.LabelHtrMagMagSetPointRback.Name = "LabelHtrMagMagSetPointRback"
        Me.LabelHtrMagMagSetPointRback.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagMagSetPointRback.TabIndex = 220
        Me.LabelHtrMagMagSetPointRback.Text = "LabelHtrMag"
        '
        'ButtonLambdaOn
        '
        Me.ButtonLambdaOn.Location = New System.Drawing.Point(539, 293)
        Me.ButtonLambdaOn.Name = "ButtonLambdaOn"
        Me.ButtonLambdaOn.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLambdaOn.TabIndex = 204
        Me.ButtonLambdaOn.Text = "Lambda On"
        Me.ButtonLambdaOn.UseVisualStyleBackColor = True
        Me.ButtonLambdaOn.Visible = False
        '
        'ButtonHtrMagOff
        '
        Me.ButtonHtrMagOff.Location = New System.Drawing.Point(539, 322)
        Me.ButtonHtrMagOff.Name = "ButtonHtrMagOff"
        Me.ButtonHtrMagOff.Size = New System.Drawing.Size(100, 23)
        Me.ButtonHtrMagOff.TabIndex = 216
        Me.ButtonHtrMagOff.Text = "Htr Mag Off"
        Me.ButtonHtrMagOff.UseVisualStyleBackColor = True
        '
        'ButtonLambdaoff
        '
        Me.ButtonLambdaoff.Location = New System.Drawing.Point(539, 322)
        Me.ButtonLambdaoff.Name = "ButtonLambdaoff"
        Me.ButtonLambdaoff.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLambdaoff.TabIndex = 203
        Me.ButtonLambdaoff.Text = "Lambda Off"
        Me.ButtonLambdaoff.UseVisualStyleBackColor = True
        Me.ButtonLambdaoff.Visible = False
        '
        'LabelHtrMagHtrVolSetPointRback
        '
        Me.LabelHtrMagHtrVolSetPointRback.AutoSize = True
        Me.LabelHtrMagHtrVolSetPointRback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagHtrVolSetPointRback.Location = New System.Drawing.Point(430, 521)
        Me.LabelHtrMagHtrVolSetPointRback.Name = "LabelHtrMagHtrVolSetPointRback"
        Me.LabelHtrMagHtrVolSetPointRback.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagHtrVolSetPointRback.TabIndex = 219
        Me.LabelHtrMagHtrVolSetPointRback.Text = "LabelHtrMag"
        '
        'LabelHtrMagMagVmon
        '
        Me.LabelHtrMagMagVmon.AutoSize = True
        Me.LabelHtrMagMagVmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagMagVmon.Location = New System.Drawing.Point(430, 489)
        Me.LabelHtrMagMagVmon.Name = "LabelHtrMagMagVmon"
        Me.LabelHtrMagMagVmon.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagMagVmon.TabIndex = 215
        Me.LabelHtrMagMagVmon.Text = "LabelHtrMag"
        '
        'LabelHtrMagHtrSetPointRback
        '
        Me.LabelHtrMagHtrSetPointRback.AutoSize = True
        Me.LabelHtrMagHtrSetPointRback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagHtrSetPointRback.Location = New System.Drawing.Point(430, 505)
        Me.LabelHtrMagHtrSetPointRback.Name = "LabelHtrMagHtrSetPointRback"
        Me.LabelHtrMagHtrSetPointRback.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagHtrSetPointRback.TabIndex = 218
        Me.LabelHtrMagHtrSetPointRback.Text = "LabelHtrMag"
        '
        'LabelHtrMagMagImon
        '
        Me.LabelHtrMagMagImon.AutoSize = True
        Me.LabelHtrMagMagImon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagMagImon.Location = New System.Drawing.Point(430, 473)
        Me.LabelHtrMagMagImon.Name = "LabelHtrMagMagImon"
        Me.LabelHtrMagMagImon.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagMagImon.TabIndex = 214
        Me.LabelHtrMagMagImon.Text = "LabelHtrMag"
        '
        'LabelHtrMagHtrVmon
        '
        Me.LabelHtrMagHtrVmon.AutoSize = True
        Me.LabelHtrMagHtrVmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagHtrVmon.Location = New System.Drawing.Point(430, 457)
        Me.LabelHtrMagHtrVmon.Name = "LabelHtrMagHtrVmon"
        Me.LabelHtrMagHtrVmon.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagHtrVmon.TabIndex = 213
        Me.LabelHtrMagHtrVmon.Text = "LabelHtrMag"
        '
        'TextBoxHtrCurrent
        '
        Me.TextBoxHtrCurrent.Location = New System.Drawing.Point(433, 351)
        Me.TextBoxHtrCurrent.MaxLength = 5
        Me.TextBoxHtrCurrent.Name = "TextBoxHtrCurrent"
        Me.TextBoxHtrCurrent.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHtrCurrent.TabIndex = 206
        '
        'LabelHtrMagHtrImon
        '
        Me.LabelHtrMagHtrImon.AutoSize = True
        Me.LabelHtrMagHtrImon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagHtrImon.Location = New System.Drawing.Point(430, 441)
        Me.LabelHtrMagHtrImon.Name = "LabelHtrMagHtrImon"
        Me.LabelHtrMagHtrImon.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagHtrImon.TabIndex = 212
        Me.LabelHtrMagHtrImon.Text = "LabelHtrMag"
        '
        'TextBoxLambdaHigh
        '
        Me.TextBoxLambdaHigh.Location = New System.Drawing.Point(433, 351)
        Me.TextBoxLambdaHigh.MaxLength = 5
        Me.TextBoxLambdaHigh.Name = "TextBoxLambdaHigh"
        Me.TextBoxLambdaHigh.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLambdaHigh.TabIndex = 6
        Me.TextBoxLambdaHigh.Visible = False
        '
        'ButtonHtrMagSetHtr
        '
        Me.ButtonHtrMagSetHtr.Location = New System.Drawing.Point(539, 350)
        Me.ButtonHtrMagSetHtr.Name = "ButtonHtrMagSetHtr"
        Me.ButtonHtrMagSetHtr.Size = New System.Drawing.Size(100, 23)
        Me.ButtonHtrMagSetHtr.TabIndex = 207
        Me.ButtonHtrMagSetHtr.Text = "Set Htr Curr"
        Me.ButtonHtrMagSetHtr.UseVisualStyleBackColor = True
        '
        'LabelFirmwareVerssion
        '
        Me.LabelFirmwareVerssion.AutoSize = True
        Me.LabelFirmwareVerssion.Location = New System.Drawing.Point(263, 378)
        Me.LabelFirmwareVerssion.Name = "LabelFirmwareVerssion"
        Me.LabelFirmwareVerssion.Size = New System.Drawing.Size(49, 13)
        Me.LabelFirmwareVerssion.TabIndex = 193
        Me.LabelFirmwareVerssion.Text = "Firmware"
        '
        'LabelHtrMagHtrSetPoint
        '
        Me.LabelHtrMagHtrSetPoint.AutoSize = True
        Me.LabelHtrMagHtrSetPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagHtrSetPoint.Location = New System.Drawing.Point(430, 425)
        Me.LabelHtrMagHtrSetPoint.Name = "LabelHtrMagHtrSetPoint"
        Me.LabelHtrMagHtrSetPoint.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagHtrSetPoint.TabIndex = 211
        Me.LabelHtrMagHtrSetPoint.Text = "LabelHtrMag"
        '
        'LabelAgileInfo
        '
        Me.LabelAgileInfo.AutoSize = True
        Me.LabelAgileInfo.Location = New System.Drawing.Point(263, 358)
        Me.LabelAgileInfo.Name = "LabelAgileInfo"
        Me.LabelAgileInfo.Size = New System.Drawing.Size(51, 13)
        Me.LabelAgileInfo.TabIndex = 192
        Me.LabelAgileInfo.Text = "Agile Info"
        '
        'TextBoxMagCurrent
        '
        Me.TextBoxMagCurrent.Location = New System.Drawing.Point(433, 377)
        Me.TextBoxMagCurrent.MaxLength = 5
        Me.TextBoxMagCurrent.Name = "TextBoxMagCurrent"
        Me.TextBoxMagCurrent.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMagCurrent.TabIndex = 208
        '
        'LabelErrorTBD2
        '
        Me.LabelErrorTBD2.AutoSize = True
        Me.LabelErrorTBD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorTBD2.Location = New System.Drawing.Point(6, 467)
        Me.LabelErrorTBD2.Name = "LabelErrorTBD2"
        Me.LabelErrorTBD2.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorTBD2.TabIndex = 190
        Me.LabelErrorTBD2.Text = "LabelError"
        '
        'LabelHtrMagMagSetPoint
        '
        Me.LabelHtrMagMagSetPoint.AutoSize = True
        Me.LabelHtrMagMagSetPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHtrMagMagSetPoint.Location = New System.Drawing.Point(430, 409)
        Me.LabelHtrMagMagSetPoint.Name = "LabelHtrMagMagSetPoint"
        Me.LabelHtrMagMagSetPoint.Size = New System.Drawing.Size(86, 16)
        Me.LabelHtrMagMagSetPoint.TabIndex = 210
        Me.LabelHtrMagMagSetPoint.Text = "LabelHtrMag"
        '
        'LabelErrorTBD1
        '
        Me.LabelErrorTBD1.AutoSize = True
        Me.LabelErrorTBD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorTBD1.Location = New System.Drawing.Point(6, 451)
        Me.LabelErrorTBD1.Name = "LabelErrorTBD1"
        Me.LabelErrorTBD1.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorTBD1.TabIndex = 189
        Me.LabelErrorTBD1.Text = "LabelError"
        '
        'ButtonHtrMagSetMag
        '
        Me.ButtonHtrMagSetMag.Location = New System.Drawing.Point(539, 374)
        Me.ButtonHtrMagSetMag.Name = "ButtonHtrMagSetMag"
        Me.ButtonHtrMagSetMag.Size = New System.Drawing.Size(100, 23)
        Me.ButtonHtrMagSetMag.TabIndex = 209
        Me.ButtonHtrMagSetMag.Text = "Set Mag Curr"
        Me.ButtonHtrMagSetMag.UseVisualStyleBackColor = True
        '
        'LabelErrorSelfTestResultRegister
        '
        Me.LabelErrorSelfTestResultRegister.AutoSize = True
        Me.LabelErrorSelfTestResultRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorSelfTestResultRegister.Location = New System.Drawing.Point(6, 435)
        Me.LabelErrorSelfTestResultRegister.Name = "LabelErrorSelfTestResultRegister"
        Me.LabelErrorSelfTestResultRegister.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorSelfTestResultRegister.TabIndex = 188
        Me.LabelErrorSelfTestResultRegister.Text = "LabelError"
        '
        'LabelErrorResetCount
        '
        Me.LabelErrorResetCount.AutoSize = True
        Me.LabelErrorResetCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorResetCount.Location = New System.Drawing.Point(6, 419)
        Me.LabelErrorResetCount.Name = "LabelErrorResetCount"
        Me.LabelErrorResetCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorResetCount.TabIndex = 187
        Me.LabelErrorResetCount.Text = "LabelError"
        '
        'LabelErrorScaleCount
        '
        Me.LabelErrorScaleCount.AutoSize = True
        Me.LabelErrorScaleCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorScaleCount.Location = New System.Drawing.Point(6, 403)
        Me.LabelErrorScaleCount.Name = "LabelErrorScaleCount"
        Me.LabelErrorScaleCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorScaleCount.TabIndex = 186
        Me.LabelErrorScaleCount.Text = "LabelError"
        '
        'LabelErrorCanBusCount
        '
        Me.LabelErrorCanBusCount.AutoSize = True
        Me.LabelErrorCanBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorCanBusCount.Location = New System.Drawing.Point(6, 387)
        Me.LabelErrorCanBusCount.Name = "LabelErrorCanBusCount"
        Me.LabelErrorCanBusCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorCanBusCount.TabIndex = 185
        Me.LabelErrorCanBusCount.Text = "LabelError"
        '
        'LabelErrorSPIBusCount
        '
        Me.LabelErrorSPIBusCount.AutoSize = True
        Me.LabelErrorSPIBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorSPIBusCount.Location = New System.Drawing.Point(6, 371)
        Me.LabelErrorSPIBusCount.Name = "LabelErrorSPIBusCount"
        Me.LabelErrorSPIBusCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorSPIBusCount.TabIndex = 184
        Me.LabelErrorSPIBusCount.Text = "LabelError"
        '
        'LabelErrorI2CBusCount
        '
        Me.LabelErrorI2CBusCount.AutoSize = True
        Me.LabelErrorI2CBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorI2CBusCount.Location = New System.Drawing.Point(6, 355)
        Me.LabelErrorI2CBusCount.Name = "LabelErrorI2CBusCount"
        Me.LabelErrorI2CBusCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorI2CBusCount.TabIndex = 183
        Me.LabelErrorI2CBusCount.Text = "LabelError"
        '
        'LabelDebugF
        '
        Me.LabelDebugF.AutoSize = True
        Me.LabelDebugF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugF.Location = New System.Drawing.Point(430, 257)
        Me.LabelDebugF.Name = "LabelDebugF"
        Me.LabelDebugF.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugF.TabIndex = 182
        Me.LabelDebugF.Text = "LabelDebug"
        '
        'LabelDebugE
        '
        Me.LabelDebugE.AutoSize = True
        Me.LabelDebugE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugE.Location = New System.Drawing.Point(430, 241)
        Me.LabelDebugE.Name = "LabelDebugE"
        Me.LabelDebugE.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugE.TabIndex = 181
        Me.LabelDebugE.Text = "LabelDebug"
        '
        'LabelDebugD
        '
        Me.LabelDebugD.AutoSize = True
        Me.LabelDebugD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugD.Location = New System.Drawing.Point(430, 225)
        Me.LabelDebugD.Name = "LabelDebugD"
        Me.LabelDebugD.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugD.TabIndex = 180
        Me.LabelDebugD.Text = "LabelDebug"
        '
        'LabelDebugC
        '
        Me.LabelDebugC.AutoSize = True
        Me.LabelDebugC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugC.Location = New System.Drawing.Point(430, 209)
        Me.LabelDebugC.Name = "LabelDebugC"
        Me.LabelDebugC.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugC.TabIndex = 179
        Me.LabelDebugC.Text = "LabelDebug"
        '
        'LabelDebugB
        '
        Me.LabelDebugB.AutoSize = True
        Me.LabelDebugB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugB.Location = New System.Drawing.Point(430, 193)
        Me.LabelDebugB.Name = "LabelDebugB"
        Me.LabelDebugB.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugB.TabIndex = 178
        Me.LabelDebugB.Text = "LabelDebug"
        '
        'LabelDebugA
        '
        Me.LabelDebugA.AutoSize = True
        Me.LabelDebugA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugA.Location = New System.Drawing.Point(430, 177)
        Me.LabelDebugA.Name = "LabelDebugA"
        Me.LabelDebugA.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebugA.TabIndex = 177
        Me.LabelDebugA.Text = "LabelDebug"
        '
        'LabelDebug9
        '
        Me.LabelDebug9.AutoSize = True
        Me.LabelDebug9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug9.Location = New System.Drawing.Point(430, 161)
        Me.LabelDebug9.Name = "LabelDebug9"
        Me.LabelDebug9.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug9.TabIndex = 176
        Me.LabelDebug9.Text = "LabelDebug"
        '
        'LabelDebug8
        '
        Me.LabelDebug8.AutoSize = True
        Me.LabelDebug8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug8.Location = New System.Drawing.Point(430, 145)
        Me.LabelDebug8.Name = "LabelDebug8"
        Me.LabelDebug8.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug8.TabIndex = 175
        Me.LabelDebug8.Text = "LabelDebug"
        '
        'LabelDebug7
        '
        Me.LabelDebug7.AutoSize = True
        Me.LabelDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug7.Location = New System.Drawing.Point(430, 129)
        Me.LabelDebug7.Name = "LabelDebug7"
        Me.LabelDebug7.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug7.TabIndex = 174
        Me.LabelDebug7.Text = "LabelDebug"
        '
        'LabelDebug6
        '
        Me.LabelDebug6.AutoSize = True
        Me.LabelDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug6.Location = New System.Drawing.Point(430, 113)
        Me.LabelDebug6.Name = "LabelDebug6"
        Me.LabelDebug6.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug6.TabIndex = 173
        Me.LabelDebug6.Text = "LabelDebug"
        '
        'LabelDebug5
        '
        Me.LabelDebug5.AutoSize = True
        Me.LabelDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug5.Location = New System.Drawing.Point(430, 97)
        Me.LabelDebug5.Name = "LabelDebug5"
        Me.LabelDebug5.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug5.TabIndex = 172
        Me.LabelDebug5.Text = "LabelDebug"
        '
        'LabelDebug4
        '
        Me.LabelDebug4.AutoSize = True
        Me.LabelDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug4.Location = New System.Drawing.Point(430, 81)
        Me.LabelDebug4.Name = "LabelDebug4"
        Me.LabelDebug4.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug4.TabIndex = 171
        Me.LabelDebug4.Text = "LabelDebug"
        '
        'LabelDebug3
        '
        Me.LabelDebug3.AutoSize = True
        Me.LabelDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug3.Location = New System.Drawing.Point(430, 65)
        Me.LabelDebug3.Name = "LabelDebug3"
        Me.LabelDebug3.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug3.TabIndex = 170
        Me.LabelDebug3.Text = "LabelDebug"
        '
        'LabelDebug2
        '
        Me.LabelDebug2.AutoSize = True
        Me.LabelDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug2.Location = New System.Drawing.Point(430, 49)
        Me.LabelDebug2.Name = "LabelDebug2"
        Me.LabelDebug2.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug2.TabIndex = 169
        Me.LabelDebug2.Text = "LabelDebug"
        '
        'LabelDebug1
        '
        Me.LabelDebug1.AutoSize = True
        Me.LabelDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug1.Location = New System.Drawing.Point(430, 33)
        Me.LabelDebug1.Name = "LabelDebug1"
        Me.LabelDebug1.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug1.TabIndex = 168
        Me.LabelDebug1.Text = "LabelDebug"
        '
        'LabelDebug0
        '
        Me.LabelDebug0.AutoSize = True
        Me.LabelDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug0.Location = New System.Drawing.Point(430, 17)
        Me.LabelDebug0.Name = "LabelDebug0"
        Me.LabelDebug0.Size = New System.Drawing.Size(83, 16)
        Me.LabelDebug0.TabIndex = 167
        Me.LabelDebug0.Text = "LabelDebug"
        '
        'LabelCanTimeoutCount
        '
        Me.LabelCanTimeoutCount.AutoSize = True
        Me.LabelCanTimeoutCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTimeoutCount.Location = New System.Drawing.Point(263, 257)
        Me.LabelCanTimeoutCount.Name = "LabelCanTimeoutCount"
        Me.LabelCanTimeoutCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTimeoutCount.TabIndex = 166
        Me.LabelCanTimeoutCount.Text = "LabelCan"
        '
        'LabelCAnDataLogRXBufferOVerflowCount
        '
        Me.LabelCAnDataLogRXBufferOVerflowCount.AutoSize = True
        Me.LabelCAnDataLogRXBufferOVerflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCAnDataLogRXBufferOVerflowCount.Location = New System.Drawing.Point(263, 241)
        Me.LabelCAnDataLogRXBufferOVerflowCount.Name = "LabelCAnDataLogRXBufferOVerflowCount"
        Me.LabelCAnDataLogRXBufferOVerflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCAnDataLogRXBufferOVerflowCount.TabIndex = 165
        Me.LabelCAnDataLogRXBufferOVerflowCount.Text = "LabelCan"
        '
        'LabelCanRXBufferOverflowCount
        '
        Me.LabelCanRXBufferOverflowCount.AutoSize = True
        Me.LabelCanRXBufferOverflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRXBufferOverflowCount.Location = New System.Drawing.Point(263, 225)
        Me.LabelCanRXBufferOverflowCount.Name = "LabelCanRXBufferOverflowCount"
        Me.LabelCanRXBufferOverflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRXBufferOverflowCount.TabIndex = 164
        Me.LabelCanRXBufferOverflowCount.Text = "LabelCan"
        '
        'LabelCanTXBufOverflowCount
        '
        Me.LabelCanTXBufOverflowCount.AutoSize = True
        Me.LabelCanTXBufOverflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTXBufOverflowCount.Location = New System.Drawing.Point(263, 209)
        Me.LabelCanTXBufOverflowCount.Name = "LabelCanTXBufOverflowCount"
        Me.LabelCanTXBufOverflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTXBufOverflowCount.TabIndex = 163
        Me.LabelCanTXBufOverflowCount.Text = "LabelCan"
        '
        'LabelCanTX0Count
        '
        Me.LabelCanTX0Count.AutoSize = True
        Me.LabelCanTX0Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX0Count.Location = New System.Drawing.Point(263, 193)
        Me.LabelCanTX0Count.Name = "LabelCanTX0Count"
        Me.LabelCanTX0Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX0Count.TabIndex = 162
        Me.LabelCanTX0Count.Text = "LabelCan"
        '
        'LabelCanAddressErrorCount
        '
        Me.LabelCanAddressErrorCount.AutoSize = True
        Me.LabelCanAddressErrorCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanAddressErrorCount.Location = New System.Drawing.Point(263, 177)
        Me.LabelCanAddressErrorCount.Name = "LabelCanAddressErrorCount"
        Me.LabelCanAddressErrorCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanAddressErrorCount.TabIndex = 161
        Me.LabelCanAddressErrorCount.Text = "LabelCan"
        '
        'LabelCanInvalidIndexCount
        '
        Me.LabelCanInvalidIndexCount.AutoSize = True
        Me.LabelCanInvalidIndexCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanInvalidIndexCount.Location = New System.Drawing.Point(263, 161)
        Me.LabelCanInvalidIndexCount.Name = "LabelCanInvalidIndexCount"
        Me.LabelCanInvalidIndexCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanInvalidIndexCount.TabIndex = 160
        Me.LabelCanInvalidIndexCount.Text = "LabelCan"
        '
        'LabelCanUnknownIdentifierCount
        '
        Me.LabelCanUnknownIdentifierCount.AutoSize = True
        Me.LabelCanUnknownIdentifierCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanUnknownIdentifierCount.Location = New System.Drawing.Point(263, 145)
        Me.LabelCanUnknownIdentifierCount.Name = "LabelCanUnknownIdentifierCount"
        Me.LabelCanUnknownIdentifierCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanUnknownIdentifierCount.TabIndex = 159
        Me.LabelCanUnknownIdentifierCount.Text = "LabelCan"
        '
        'LabelCanISREnteredCount
        '
        Me.LabelCanISREnteredCount.AutoSize = True
        Me.LabelCanISREnteredCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanISREnteredCount.Location = New System.Drawing.Point(263, 129)
        Me.LabelCanISREnteredCount.Name = "LabelCanISREnteredCount"
        Me.LabelCanISREnteredCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanISREnteredCount.TabIndex = 158
        Me.LabelCanISREnteredCount.Text = "LabelCan"
        '
        'LabelCanRX1Filt2Count
        '
        Me.LabelCanRX1Filt2Count.AutoSize = True
        Me.LabelCanRX1Filt2Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX1Filt2Count.Location = New System.Drawing.Point(263, 113)
        Me.LabelCanRX1Filt2Count.Name = "LabelCanRX1Filt2Count"
        Me.LabelCanRX1Filt2Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX1Filt2Count.TabIndex = 157
        Me.LabelCanRX1Filt2Count.Text = "LabelCan"
        '
        'LabelCanRX0Filt1Count
        '
        Me.LabelCanRX0Filt1Count.AutoSize = True
        Me.LabelCanRX0Filt1Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX0Filt1Count.Location = New System.Drawing.Point(263, 97)
        Me.LabelCanRX0Filt1Count.Name = "LabelCanRX0Filt1Count"
        Me.LabelCanRX0Filt1Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX0Filt1Count.TabIndex = 156
        Me.LabelCanRX0Filt1Count.Text = "LabelCan"
        '
        'LabelCanRX0Filt0Count
        '
        Me.LabelCanRX0Filt0Count.AutoSize = True
        Me.LabelCanRX0Filt0Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX0Filt0Count.Location = New System.Drawing.Point(263, 81)
        Me.LabelCanRX0Filt0Count.Name = "LabelCanRX0Filt0Count"
        Me.LabelCanRX0Filt0Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX0Filt0Count.TabIndex = 155
        Me.LabelCanRX0Filt0Count.Text = "LabelCan"
        '
        'LabelCanTX2Count
        '
        Me.LabelCanTX2Count.AutoSize = True
        Me.LabelCanTX2Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX2Count.Location = New System.Drawing.Point(263, 65)
        Me.LabelCanTX2Count.Name = "LabelCanTX2Count"
        Me.LabelCanTX2Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX2Count.TabIndex = 154
        Me.LabelCanTX2Count.Text = "LabelCan"
        '
        'LabelCanTX1Count
        '
        Me.LabelCanTX1Count.AutoSize = True
        Me.LabelCanTX1Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX1Count.Location = New System.Drawing.Point(263, 49)
        Me.LabelCanTX1Count.Name = "LabelCanTX1Count"
        Me.LabelCanTX1Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX1Count.TabIndex = 153
        Me.LabelCanTX1Count.Text = "LabelCan"
        '
        'LabelCanErrorFlagCount
        '
        Me.LabelCanErrorFlagCount.AutoSize = True
        Me.LabelCanErrorFlagCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanErrorFlagCount.Location = New System.Drawing.Point(263, 33)
        Me.LabelCanErrorFlagCount.Name = "LabelCanErrorFlagCount"
        Me.LabelCanErrorFlagCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanErrorFlagCount.TabIndex = 152
        Me.LabelCanErrorFlagCount.Text = "LabelCan"
        '
        'LabelCanCXECReg
        '
        Me.LabelCanCXECReg.AutoSize = True
        Me.LabelCanCXECReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanCXECReg.Location = New System.Drawing.Point(263, 17)
        Me.LabelCanCXECReg.Name = "LabelCanCXECReg"
        Me.LabelCanCXECReg.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanCXECReg.TabIndex = 151
        Me.LabelCanCXECReg.Text = "LabelCan"
        '
        'CheckBoxFaultBit15
        '
        Me.CheckBoxFaultBit15.AutoSize = True
        Me.CheckBoxFaultBit15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit15.Location = New System.Drawing.Point(156, 320)
        Me.CheckBoxFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit15.Name = "CheckBoxFaultBit15"
        Me.CheckBoxFaultBit15.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit15.TabIndex = 142
        Me.CheckBoxFaultBit15.Text = "Fault Bit 15"
        Me.CheckBoxFaultBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit14
        '
        Me.CheckBoxFaultBit14.AutoSize = True
        Me.CheckBoxFaultBit14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit14.Location = New System.Drawing.Point(156, 300)
        Me.CheckBoxFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit14.Name = "CheckBoxFaultBit14"
        Me.CheckBoxFaultBit14.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit14.TabIndex = 141
        Me.CheckBoxFaultBit14.Text = "Fault Bit 14"
        Me.CheckBoxFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit13
        '
        Me.CheckBoxFaultBit13.AutoSize = True
        Me.CheckBoxFaultBit13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit13.Location = New System.Drawing.Point(156, 280)
        Me.CheckBoxFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit13.Name = "CheckBoxFaultBit13"
        Me.CheckBoxFaultBit13.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit13.TabIndex = 140
        Me.CheckBoxFaultBit13.Text = "Fault Bit 13"
        Me.CheckBoxFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit12
        '
        Me.CheckBoxFaultBit12.AutoSize = True
        Me.CheckBoxFaultBit12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit12.Location = New System.Drawing.Point(156, 260)
        Me.CheckBoxFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit12.Name = "CheckBoxFaultBit12"
        Me.CheckBoxFaultBit12.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit12.TabIndex = 139
        Me.CheckBoxFaultBit12.Text = "Fault Bit 12"
        Me.CheckBoxFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit11
        '
        Me.CheckBoxFaultBit11.AutoSize = True
        Me.CheckBoxFaultBit11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit11.Location = New System.Drawing.Point(156, 238)
        Me.CheckBoxFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit11.Name = "CheckBoxFaultBit11"
        Me.CheckBoxFaultBit11.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit11.TabIndex = 138
        Me.CheckBoxFaultBit11.Text = "Fault Bit 11"
        Me.CheckBoxFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit10
        '
        Me.CheckBoxFaultBit10.AutoSize = True
        Me.CheckBoxFaultBit10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit10.Location = New System.Drawing.Point(156, 218)
        Me.CheckBoxFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit10.Name = "CheckBoxFaultBit10"
        Me.CheckBoxFaultBit10.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxFaultBit10.TabIndex = 137
        Me.CheckBoxFaultBit10.Text = "Fault Bit 10"
        Me.CheckBoxFaultBit10.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit9
        '
        Me.CheckBoxFaultBit9.AutoSize = True
        Me.CheckBoxFaultBit9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit9.Location = New System.Drawing.Point(156, 198)
        Me.CheckBoxFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit9.Name = "CheckBoxFaultBit9"
        Me.CheckBoxFaultBit9.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit9.TabIndex = 136
        Me.CheckBoxFaultBit9.Text = "Fault Bit 9"
        Me.CheckBoxFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit8
        '
        Me.CheckBoxFaultBit8.AutoSize = True
        Me.CheckBoxFaultBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit8.Location = New System.Drawing.Point(156, 178)
        Me.CheckBoxFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit8.Name = "CheckBoxFaultBit8"
        Me.CheckBoxFaultBit8.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit8.TabIndex = 135
        Me.CheckBoxFaultBit8.Text = "Fault Bit 8"
        Me.CheckBoxFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit7
        '
        Me.CheckBoxFaultBit7.AutoSize = True
        Me.CheckBoxFaultBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit7.Location = New System.Drawing.Point(156, 158)
        Me.CheckBoxFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit7.Name = "CheckBoxFaultBit7"
        Me.CheckBoxFaultBit7.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit7.TabIndex = 134
        Me.CheckBoxFaultBit7.Text = "Fault Bit 7"
        Me.CheckBoxFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit6
        '
        Me.CheckBoxFaultBit6.AutoSize = True
        Me.CheckBoxFaultBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit6.Location = New System.Drawing.Point(156, 138)
        Me.CheckBoxFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit6.Name = "CheckBoxFaultBit6"
        Me.CheckBoxFaultBit6.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit6.TabIndex = 133
        Me.CheckBoxFaultBit6.Text = "Fault Bit 6"
        Me.CheckBoxFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit5
        '
        Me.CheckBoxFaultBit5.AutoSize = True
        Me.CheckBoxFaultBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit5.Location = New System.Drawing.Point(156, 118)
        Me.CheckBoxFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit5.Name = "CheckBoxFaultBit5"
        Me.CheckBoxFaultBit5.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit5.TabIndex = 132
        Me.CheckBoxFaultBit5.Text = "Fault Bit 5"
        Me.CheckBoxFaultBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit4
        '
        Me.CheckBoxFaultBit4.AutoSize = True
        Me.CheckBoxFaultBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit4.Location = New System.Drawing.Point(156, 98)
        Me.CheckBoxFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit4.Name = "CheckBoxFaultBit4"
        Me.CheckBoxFaultBit4.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit4.TabIndex = 131
        Me.CheckBoxFaultBit4.Text = "Fault Bit 4"
        Me.CheckBoxFaultBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit3
        '
        Me.CheckBoxFaultBit3.AutoSize = True
        Me.CheckBoxFaultBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit3.Location = New System.Drawing.Point(156, 76)
        Me.CheckBoxFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit3.Name = "CheckBoxFaultBit3"
        Me.CheckBoxFaultBit3.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit3.TabIndex = 130
        Me.CheckBoxFaultBit3.Text = "Fault Bit 3"
        Me.CheckBoxFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit2
        '
        Me.CheckBoxFaultBit2.AutoSize = True
        Me.CheckBoxFaultBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit2.Location = New System.Drawing.Point(156, 56)
        Me.CheckBoxFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit2.Name = "CheckBoxFaultBit2"
        Me.CheckBoxFaultBit2.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit2.TabIndex = 129
        Me.CheckBoxFaultBit2.Text = "Fault Bit 2"
        Me.CheckBoxFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit1
        '
        Me.CheckBoxFaultBit1.AutoSize = True
        Me.CheckBoxFaultBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit1.Location = New System.Drawing.Point(156, 36)
        Me.CheckBoxFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit1.Name = "CheckBoxFaultBit1"
        Me.CheckBoxFaultBit1.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit1.TabIndex = 128
        Me.CheckBoxFaultBit1.Text = "Fault Bit 1"
        Me.CheckBoxFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit0
        '
        Me.CheckBoxFaultBit0.AutoSize = True
        Me.CheckBoxFaultBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit0.Location = New System.Drawing.Point(156, 16)
        Me.CheckBoxFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit0.Name = "CheckBoxFaultBit0"
        Me.CheckBoxFaultBit0.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit0.TabIndex = 127
        Me.CheckBoxFaultBit0.Text = "Fault Bit 0"
        Me.CheckBoxFaultBit0.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit15
        '
        Me.CheckBoxStatusBit15.AutoSize = True
        Me.CheckBoxStatusBit15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit15.Location = New System.Drawing.Point(3, 320)
        Me.CheckBoxStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit15.Name = "CheckBoxStatusBit15"
        Me.CheckBoxStatusBit15.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit15.TabIndex = 126
        Me.CheckBoxStatusBit15.Text = "Status Bit 15"
        Me.CheckBoxStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit14
        '
        Me.CheckBoxStatusBit14.AutoSize = True
        Me.CheckBoxStatusBit14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit14.Location = New System.Drawing.Point(3, 300)
        Me.CheckBoxStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit14.Name = "CheckBoxStatusBit14"
        Me.CheckBoxStatusBit14.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit14.TabIndex = 125
        Me.CheckBoxStatusBit14.Text = "Status Bit 14"
        Me.CheckBoxStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit13
        '
        Me.CheckBoxStatusBit13.AutoSize = True
        Me.CheckBoxStatusBit13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit13.Location = New System.Drawing.Point(3, 280)
        Me.CheckBoxStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit13.Name = "CheckBoxStatusBit13"
        Me.CheckBoxStatusBit13.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit13.TabIndex = 124
        Me.CheckBoxStatusBit13.Text = "Status Bit 13"
        Me.CheckBoxStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit12
        '
        Me.CheckBoxStatusBit12.AutoSize = True
        Me.CheckBoxStatusBit12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit12.Location = New System.Drawing.Point(3, 260)
        Me.CheckBoxStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit12.Name = "CheckBoxStatusBit12"
        Me.CheckBoxStatusBit12.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit12.TabIndex = 123
        Me.CheckBoxStatusBit12.Text = "Status Bit 12"
        Me.CheckBoxStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit11
        '
        Me.CheckBoxStatusBit11.AutoSize = True
        Me.CheckBoxStatusBit11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit11.Location = New System.Drawing.Point(3, 238)
        Me.CheckBoxStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit11.Name = "CheckBoxStatusBit11"
        Me.CheckBoxStatusBit11.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit11.TabIndex = 122
        Me.CheckBoxStatusBit11.Text = "Status Bit 11"
        Me.CheckBoxStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit10
        '
        Me.CheckBoxStatusBit10.AutoSize = True
        Me.CheckBoxStatusBit10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit10.Location = New System.Drawing.Point(3, 218)
        Me.CheckBoxStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit10.Name = "CheckBoxStatusBit10"
        Me.CheckBoxStatusBit10.Size = New System.Drawing.Size(99, 20)
        Me.CheckBoxStatusBit10.TabIndex = 121
        Me.CheckBoxStatusBit10.Text = "Status Bit 10"
        Me.CheckBoxStatusBit10.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit9
        '
        Me.CheckBoxStatusBit9.AutoSize = True
        Me.CheckBoxStatusBit9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit9.Location = New System.Drawing.Point(3, 198)
        Me.CheckBoxStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit9.Name = "CheckBoxStatusBit9"
        Me.CheckBoxStatusBit9.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit9.TabIndex = 120
        Me.CheckBoxStatusBit9.Text = "Status Bit 9"
        Me.CheckBoxStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit8
        '
        Me.CheckBoxStatusBit8.AutoSize = True
        Me.CheckBoxStatusBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit8.Location = New System.Drawing.Point(3, 178)
        Me.CheckBoxStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit8.Name = "CheckBoxStatusBit8"
        Me.CheckBoxStatusBit8.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit8.TabIndex = 119
        Me.CheckBoxStatusBit8.Text = "Status Bit 8"
        Me.CheckBoxStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit7
        '
        Me.CheckBoxStatusBit7.AutoSize = True
        Me.CheckBoxStatusBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit7.Location = New System.Drawing.Point(3, 158)
        Me.CheckBoxStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit7.Name = "CheckBoxStatusBit7"
        Me.CheckBoxStatusBit7.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit7.TabIndex = 118
        Me.CheckBoxStatusBit7.Text = "Status Bit 7"
        Me.CheckBoxStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit6
        '
        Me.CheckBoxStatusBit6.AutoSize = True
        Me.CheckBoxStatusBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit6.Location = New System.Drawing.Point(3, 138)
        Me.CheckBoxStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit6.Name = "CheckBoxStatusBit6"
        Me.CheckBoxStatusBit6.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit6.TabIndex = 117
        Me.CheckBoxStatusBit6.Text = "Status Bit 6"
        Me.CheckBoxStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit5
        '
        Me.CheckBoxStatusBit5.AutoSize = True
        Me.CheckBoxStatusBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit5.Location = New System.Drawing.Point(3, 118)
        Me.CheckBoxStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit5.Name = "CheckBoxStatusBit5"
        Me.CheckBoxStatusBit5.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit5.TabIndex = 116
        Me.CheckBoxStatusBit5.Text = "Status Bit 5"
        Me.CheckBoxStatusBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit4
        '
        Me.CheckBoxStatusBit4.AutoSize = True
        Me.CheckBoxStatusBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit4.Location = New System.Drawing.Point(3, 98)
        Me.CheckBoxStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit4.Name = "CheckBoxStatusBit4"
        Me.CheckBoxStatusBit4.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit4.TabIndex = 115
        Me.CheckBoxStatusBit4.Text = "Status Bit 4"
        Me.CheckBoxStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit3
        '
        Me.CheckBoxStatusBit3.AutoSize = True
        Me.CheckBoxStatusBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit3.Location = New System.Drawing.Point(3, 76)
        Me.CheckBoxStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit3.Name = "CheckBoxStatusBit3"
        Me.CheckBoxStatusBit3.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit3.TabIndex = 114
        Me.CheckBoxStatusBit3.Text = "Status Bit 3"
        Me.CheckBoxStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit2
        '
        Me.CheckBoxStatusBit2.AutoSize = True
        Me.CheckBoxStatusBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit2.Location = New System.Drawing.Point(3, 56)
        Me.CheckBoxStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit2.Name = "CheckBoxStatusBit2"
        Me.CheckBoxStatusBit2.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit2.TabIndex = 113
        Me.CheckBoxStatusBit2.Text = "Status Bit 2"
        Me.CheckBoxStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit1
        '
        Me.CheckBoxStatusBit1.AutoSize = True
        Me.CheckBoxStatusBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit1.Location = New System.Drawing.Point(3, 36)
        Me.CheckBoxStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit1.Name = "CheckBoxStatusBit1"
        Me.CheckBoxStatusBit1.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit1.TabIndex = 112
        Me.CheckBoxStatusBit1.Text = "Status Bit 1"
        Me.CheckBoxStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit0
        '
        Me.CheckBoxStatusBit0.AutoSize = True
        Me.CheckBoxStatusBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit0.Location = New System.Drawing.Point(3, 16)
        Me.CheckBoxStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit0.Name = "CheckBoxStatusBit0"
        Me.CheckBoxStatusBit0.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit0.TabIndex = 111
        Me.CheckBoxStatusBit0.Text = "Status Bit 0"
        Me.CheckBoxStatusBit0.UseVisualStyleBackColor = True
        '
        'ButtonSetLambdaLow
        '
        Me.ButtonSetLambdaLow.Location = New System.Drawing.Point(539, 374)
        Me.ButtonSetLambdaLow.Name = "ButtonSetLambdaLow"
        Me.ButtonSetLambdaLow.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSetLambdaLow.TabIndex = 196
        Me.ButtonSetLambdaLow.Text = "Set Lambda Low"
        Me.ButtonSetLambdaLow.UseVisualStyleBackColor = True
        Me.ButtonSetLambdaLow.Visible = False
        '
        'ButtonSetLamdbaHigh
        '
        Me.ButtonSetLamdbaHigh.Location = New System.Drawing.Point(539, 350)
        Me.ButtonSetLamdbaHigh.Name = "ButtonSetLamdbaHigh"
        Me.ButtonSetLamdbaHigh.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSetLamdbaHigh.TabIndex = 194
        Me.ButtonSetLamdbaHigh.Text = "Set Lambda High"
        Me.ButtonSetLamdbaHigh.UseVisualStyleBackColor = True
        Me.ButtonSetLamdbaHigh.Visible = False
        '
        'TextBoxLambdaLow
        '
        Me.TextBoxLambdaLow.Location = New System.Drawing.Point(433, 377)
        Me.TextBoxLambdaLow.MaxLength = 5
        Me.TextBoxLambdaLow.Name = "TextBoxLambdaLow"
        Me.TextBoxLambdaLow.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLambdaLow.TabIndex = 195
        Me.TextBoxLambdaLow.Visible = False
        '
        'LabelHVBasePlateTemp
        '
        Me.LabelHVBasePlateTemp.AutoSize = True
        Me.LabelHVBasePlateTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVBasePlateTemp.Location = New System.Drawing.Point(430, 489)
        Me.LabelHVBasePlateTemp.Name = "LabelHVBasePlateTemp"
        Me.LabelHVBasePlateTemp.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVBasePlateTemp.TabIndex = 202
        Me.LabelHVBasePlateTemp.Text = "LabelHVLambda"
        Me.LabelHVBasePlateTemp.Visible = False
        '
        'LabelHVImon
        '
        Me.LabelHVImon.AutoSize = True
        Me.LabelHVImon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVImon.Location = New System.Drawing.Point(430, 473)
        Me.LabelHVImon.Name = "LabelHVImon"
        Me.LabelHVImon.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVImon.TabIndex = 201
        Me.LabelHVImon.Text = "LabelHVLambda"
        Me.LabelHVImon.Visible = False
        '
        'LabelHVVmon
        '
        Me.LabelHVVmon.AutoSize = True
        Me.LabelHVVmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVVmon.Location = New System.Drawing.Point(430, 457)
        Me.LabelHVVmon.Name = "LabelHVVmon"
        Me.LabelHVVmon.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVVmon.TabIndex = 200
        Me.LabelHVVmon.Text = "LabelHVLambda"
        Me.LabelHVVmon.Visible = False
        '
        'LabelHVEOCNotReached
        '
        Me.LabelHVEOCNotReached.AutoSize = True
        Me.LabelHVEOCNotReached.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVEOCNotReached.Location = New System.Drawing.Point(430, 441)
        Me.LabelHVEOCNotReached.Name = "LabelHVEOCNotReached"
        Me.LabelHVEOCNotReached.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVEOCNotReached.TabIndex = 199
        Me.LabelHVEOCNotReached.Text = "LabelHVLambda"
        Me.LabelHVEOCNotReached.Visible = False
        '
        'LabelHVSetLow
        '
        Me.LabelHVSetLow.AutoSize = True
        Me.LabelHVSetLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVSetLow.Location = New System.Drawing.Point(430, 425)
        Me.LabelHVSetLow.Name = "LabelHVSetLow"
        Me.LabelHVSetLow.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVSetLow.TabIndex = 198
        Me.LabelHVSetLow.Text = "LabelHVLambda"
        Me.LabelHVSetLow.Visible = False
        '
        'LabelHVSetHigh
        '
        Me.LabelHVSetHigh.AutoSize = True
        Me.LabelHVSetHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHVSetHigh.Location = New System.Drawing.Point(430, 409)
        Me.LabelHVSetHigh.Name = "LabelHVSetHigh"
        Me.LabelHVSetHigh.Size = New System.Drawing.Size(111, 16)
        Me.LabelHVSetHigh.TabIndex = 197
        Me.LabelHVSetHigh.Text = "LabelHVLambda"
        Me.LabelHVSetHigh.Visible = False
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
        'ButtonSF6BottleReset
        '
        Me.ButtonSF6BottleReset.Location = New System.Drawing.Point(539, 322)
        Me.ButtonSF6BottleReset.Name = "ButtonSF6BottleReset"
        Me.ButtonSF6BottleReset.Size = New System.Drawing.Size(147, 23)
        Me.ButtonSF6BottleReset.TabIndex = 230
        Me.ButtonSF6BottleReset.Text = "Reset SF6 Bottle Count"
        Me.ButtonSF6BottleReset.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 656)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "A36507 Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorTBD2 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorTBD1 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorSelfTestResultRegister As System.Windows.Forms.Label
    Friend WithEvents LabelErrorResetCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorScaleCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorCanBusCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorSPIBusCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorI2CBusCount As System.Windows.Forms.Label
    Friend WithEvents LabelDebugF As System.Windows.Forms.Label
    Friend WithEvents LabelDebugE As System.Windows.Forms.Label
    Friend WithEvents LabelDebugD As System.Windows.Forms.Label
    Friend WithEvents LabelDebugC As System.Windows.Forms.Label
    Friend WithEvents LabelDebugB As System.Windows.Forms.Label
    Friend WithEvents LabelDebugA As System.Windows.Forms.Label
    Friend WithEvents LabelDebug9 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug8 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug7 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug6 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug5 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug4 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug3 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug2 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug1 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug0 As System.Windows.Forms.Label
    Friend WithEvents LabelCanTimeoutCount As System.Windows.Forms.Label
    Friend WithEvents LabelCAnDataLogRXBufferOVerflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanRXBufferOverflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanTXBufOverflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX0Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanAddressErrorCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanInvalidIndexCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanUnknownIdentifierCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanISREnteredCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX1Filt2Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX0Filt1Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX0Filt0Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX2Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX1Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanErrorFlagCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanCXECReg As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelFirmwareVerssion As System.Windows.Forms.Label
    Friend WithEvents LabelAgileInfo As System.Windows.Forms.Label
    Friend WithEvents TextBoxLambdaHigh As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetLamdbaHigh As System.Windows.Forms.Button
    Friend WithEvents TextBoxLambdaLow As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetLambdaLow As System.Windows.Forms.Button
    Friend WithEvents LabelHVBasePlateTemp As System.Windows.Forms.Label
    Friend WithEvents LabelHVImon As System.Windows.Forms.Label
    Friend WithEvents LabelHVVmon As System.Windows.Forms.Label
    Friend WithEvents LabelHVEOCNotReached As System.Windows.Forms.Label
    Friend WithEvents LabelHVSetLow As System.Windows.Forms.Label
    Friend WithEvents LabelHVSetHigh As System.Windows.Forms.Label
    Friend WithEvents ButtonLambdaOn As System.Windows.Forms.Button
    Friend WithEvents ButtonLambdaoff As System.Windows.Forms.Button
    Friend WithEvents ButtonResetAllFaults As System.Windows.Forms.Button
    Friend WithEvents ButtonHtrMagOn As System.Windows.Forms.Button
    Friend WithEvents ButtonHtrMagOff As System.Windows.Forms.Button
    Friend WithEvents LabelHtrMagMagVmon As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagMagImon As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagHtrVmon As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagHtrImon As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagHtrSetPoint As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagMagSetPoint As System.Windows.Forms.Label
    Friend WithEvents ButtonHtrMagSetMag As System.Windows.Forms.Button
    Friend WithEvents TextBoxMagCurrent As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHtrMagSetHtr As System.Windows.Forms.Button
    Friend WithEvents TextBoxHtrCurrent As System.Windows.Forms.TextBox
    Friend WithEvents LabelHtrMagMagVolSetPointRback As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagMagSetPointRback As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagHtrVolSetPointRback As System.Windows.Forms.Label
    Friend WithEvents LabelHtrMagHtrSetPointRback As System.Windows.Forms.Label
    Friend WithEvents ButtonSF6LeakLimitOverride As System.Windows.Forms.Button
    Friend WithEvents ButtonSF6PulseLimitOverride As System.Windows.Forms.Button
    Friend WithEvents LabelCoolingMagnetronFlow As System.Windows.Forms.Label
    Friend WithEvents LabelCoolingLinacFlow As System.Windows.Forms.Label
    Friend WithEvents LabelCoolingCoolantTemp As System.Windows.Forms.Label
    Friend WithEvents LabelCoolingCirculatorFlow As System.Windows.Forms.Label
    Friend WithEvents LabelCoolingSF6Pressure As System.Windows.Forms.Label
    Friend WithEvents LabelCoolingCabinetTemp As System.Windows.Forms.Label
    Friend WithEvents ButtonSF6BottleReset As System.Windows.Forms.Button
End Class
