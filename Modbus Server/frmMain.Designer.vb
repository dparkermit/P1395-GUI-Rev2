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
        Me.CheckBoxResetPOR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetBOR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetIdle = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetSleep = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetWDT = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetSoftware = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetExt = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetIllegal = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetTrap = New System.Windows.Forms.CheckBox()
        Me.LabelRCON = New System.Windows.Forms.Label()
        Me.ButtonResetSlave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelEEpromIndex = New System.Windows.Forms.Label()
        Me.ComboBoxEEpromRegister = New System.Windows.Forms.ComboBox()
        Me.TextBoxEEpromOffSet = New System.Windows.Forms.TextBox()
        Me.TextBoxEEpromScale = New System.Windows.Forms.TextBox()
        Me.ButtonWriteEEprom = New System.Windows.Forms.Button()
        Me.ButtonReadEEprom = New System.Windows.Forms.Button()
        Me.LabelValueDebugF = New System.Windows.Forms.Label()
        Me.LabelValueDebugE = New System.Windows.Forms.Label()
        Me.LabelValueDebugD = New System.Windows.Forms.Label()
        Me.LabelValueDebugC = New System.Windows.Forms.Label()
        Me.LabelValueDebugB = New System.Windows.Forms.Label()
        Me.LabelValueDebugA = New System.Windows.Forms.Label()
        Me.LabelValueDebug9 = New System.Windows.Forms.Label()
        Me.LabelValueDebug8 = New System.Windows.Forms.Label()
        Me.LabelValueDebug7 = New System.Windows.Forms.Label()
        Me.LabelValueDebug6 = New System.Windows.Forms.Label()
        Me.LabelValueDebug5 = New System.Windows.Forms.Label()
        Me.LabelValueDebug4 = New System.Windows.Forms.Label()
        Me.LabelValueDebug3 = New System.Windows.Forms.Label()
        Me.LabelValueDebug2 = New System.Windows.Forms.Label()
        Me.LabelValueDebug1 = New System.Windows.Forms.Label()
        Me.LabelValueDebug0 = New System.Windows.Forms.Label()
        Me.ButtonBoardCommand = New System.Windows.Forms.Button()
        Me.LabelValue10 = New System.Windows.Forms.Label()
        Me.LabelValue9 = New System.Windows.Forms.Label()
        Me.LabelFirmwareVerssion = New System.Windows.Forms.Label()
        Me.LabelValue8 = New System.Windows.Forms.Label()
        Me.LabelAgileInfo = New System.Windows.Forms.Label()
        Me.LabelValue7 = New System.Windows.Forms.Label()
        Me.LabelErrorStatusDataB = New System.Windows.Forms.Label()
        Me.LabelValue6 = New System.Windows.Forms.Label()
        Me.LabelErrorStatusDataA = New System.Windows.Forms.Label()
        Me.LabelValue5 = New System.Windows.Forms.Label()
        Me.LabelErrorSelfTestResultRegister = New System.Windows.Forms.Label()
        Me.LabelValue4 = New System.Windows.Forms.Label()
        Me.LabelErrorResetCount = New System.Windows.Forms.Label()
        Me.LabelValue3 = New System.Windows.Forms.Label()
        Me.LabelErrorScaleCount = New System.Windows.Forms.Label()
        Me.LabelValue2 = New System.Windows.Forms.Label()
        Me.LabelErrorCanBusCount = New System.Windows.Forms.Label()
        Me.LabelValue1 = New System.Windows.Forms.Label()
        Me.LabelErrorSPIBusCount = New System.Windows.Forms.Label()
        Me.ButtonUpdateInput2 = New System.Windows.Forms.Button()
        Me.LabelErrorI2CBusCount = New System.Windows.Forms.Label()
        Me.ButtonUpdateInput1 = New System.Windows.Forms.Button()
        Me.LabelDebugF = New System.Windows.Forms.Label()
        Me.LabelDebugE = New System.Windows.Forms.Label()
        Me.LabelDebugD = New System.Windows.Forms.Label()
        Me.LabelDebugC = New System.Windows.Forms.Label()
        Me.LabelDebugB = New System.Windows.Forms.Label()
        Me.LabelDebugA = New System.Windows.Forms.Label()
        Me.TextBoxInput1 = New System.Windows.Forms.TextBox()
        Me.LabelDebug9 = New System.Windows.Forms.Label()
        Me.TextBoxInput2 = New System.Windows.Forms.TextBox()
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
        Me.CheckBoxFaultBitF = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitE = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitB = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitA = New System.Windows.Forms.CheckBox()
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
        Me.CheckBoxStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit0 = New System.Windows.Forms.CheckBox()
        Me.ButtonToggleCoolantFault = New System.Windows.Forms.Button()
        Me.ButtonToggleReset = New System.Windows.Forms.Button()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelBoardStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonToggleHighSpeedDataLogging = New System.Windows.Forms.Button()
        Me.ButtonTogglePulseSyncHV = New System.Windows.Forms.Button()
        Me.ButtonTogglePulseSyncXray = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPulseSyncConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPulseCurrentMonitorConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGunDriverConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHtrMagConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCoolingConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAFCConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIonPumpConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVLambdaConnected = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBoxOperatePulseSync = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateMagnetronCurrentMon = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateGunDriver = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateHtrMag = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateCooling = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateAFC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateIonPump = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateHVLambda = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxOperateEthernet = New System.Windows.Forms.CheckBox()
        Me.LabelECBState = New System.Windows.Forms.Label()
        Me.ButtonToggleResetDebug = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBitF = New System.Windows.Forms.CheckBox()
        Me.LabelValue11 = New System.Windows.Forms.Label()
        Me.LabelValue12 = New System.Windows.Forms.Label()
        Me.LabelValue13 = New System.Windows.Forms.Label()
        Me.LabelValue14 = New System.Windows.Forms.Label()
        Me.LabelValue15 = New System.Windows.Forms.Label()
        Me.ButtonUpdateInput3 = New System.Windows.Forms.Button()
        Me.TextBoxInput3 = New System.Windows.Forms.TextBox()
        Me.ButtonStartLog = New System.Windows.Forms.Button()
        Me.ButtonStopLog = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetPOR)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetBOR)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdateInput3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetIdle)
        Me.GroupBox1.Controls.Add(Me.TextBoxInput3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetSleep)
        Me.GroupBox1.Controls.Add(Me.LabelValue15)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetWDT)
        Me.GroupBox1.Controls.Add(Me.LabelValue14)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetSoftware)
        Me.GroupBox1.Controls.Add(Me.LabelValue13)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetExt)
        Me.GroupBox1.Controls.Add(Me.LabelValue12)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetIllegal)
        Me.GroupBox1.Controls.Add(Me.LabelValue11)
        Me.GroupBox1.Controls.Add(Me.CheckBoxResetTrap)
        Me.GroupBox1.Controls.Add(Me.LabelRCON)
        Me.GroupBox1.Controls.Add(Me.ButtonResetSlave)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LabelEEpromIndex)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEEpromRegister)
        Me.GroupBox1.Controls.Add(Me.TextBoxEEpromOffSet)
        Me.GroupBox1.Controls.Add(Me.TextBoxEEpromScale)
        Me.GroupBox1.Controls.Add(Me.ButtonWriteEEprom)
        Me.GroupBox1.Controls.Add(Me.ButtonReadEEprom)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugF)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugE)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugD)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugC)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugB)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebugA)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug9)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug8)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug7)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug6)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug5)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug4)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug3)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug2)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug1)
        Me.GroupBox1.Controls.Add(Me.LabelValueDebug0)
        Me.GroupBox1.Controls.Add(Me.ButtonBoardCommand)
        Me.GroupBox1.Controls.Add(Me.LabelValue10)
        Me.GroupBox1.Controls.Add(Me.LabelValue9)
        Me.GroupBox1.Controls.Add(Me.LabelFirmwareVerssion)
        Me.GroupBox1.Controls.Add(Me.LabelValue8)
        Me.GroupBox1.Controls.Add(Me.LabelAgileInfo)
        Me.GroupBox1.Controls.Add(Me.LabelValue7)
        Me.GroupBox1.Controls.Add(Me.LabelErrorStatusDataB)
        Me.GroupBox1.Controls.Add(Me.LabelValue6)
        Me.GroupBox1.Controls.Add(Me.LabelErrorStatusDataA)
        Me.GroupBox1.Controls.Add(Me.LabelValue5)
        Me.GroupBox1.Controls.Add(Me.LabelErrorSelfTestResultRegister)
        Me.GroupBox1.Controls.Add(Me.LabelValue4)
        Me.GroupBox1.Controls.Add(Me.LabelErrorResetCount)
        Me.GroupBox1.Controls.Add(Me.LabelValue3)
        Me.GroupBox1.Controls.Add(Me.LabelErrorScaleCount)
        Me.GroupBox1.Controls.Add(Me.LabelValue2)
        Me.GroupBox1.Controls.Add(Me.LabelErrorCanBusCount)
        Me.GroupBox1.Controls.Add(Me.LabelValue1)
        Me.GroupBox1.Controls.Add(Me.LabelErrorSPIBusCount)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdateInput2)
        Me.GroupBox1.Controls.Add(Me.LabelErrorI2CBusCount)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdateInput1)
        Me.GroupBox1.Controls.Add(Me.LabelDebugF)
        Me.GroupBox1.Controls.Add(Me.LabelDebugE)
        Me.GroupBox1.Controls.Add(Me.LabelDebugD)
        Me.GroupBox1.Controls.Add(Me.LabelDebugC)
        Me.GroupBox1.Controls.Add(Me.LabelDebugB)
        Me.GroupBox1.Controls.Add(Me.LabelDebugA)
        Me.GroupBox1.Controls.Add(Me.TextBoxInput1)
        Me.GroupBox1.Controls.Add(Me.LabelDebug9)
        Me.GroupBox1.Controls.Add(Me.TextBoxInput2)
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
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitF)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitE)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitD)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitC)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitB)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFaultBitA)
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
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit7)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit6)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit5)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit4)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStatusBit0)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit7)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit6)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit5)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit4)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxControlBit0)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 620)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status Data"
        '
        'CheckBoxResetPOR
        '
        Me.CheckBoxResetPOR.AutoSize = True
        Me.CheckBoxResetPOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetPOR.Location = New System.Drawing.Point(337, 459)
        Me.CheckBoxResetPOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetPOR.Name = "CheckBoxResetPOR"
        Me.CheckBoxResetPOR.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetPOR.TabIndex = 276
        Me.CheckBoxResetPOR.Text = "POR"
        Me.CheckBoxResetPOR.UseVisualStyleBackColor = True
        '
        'CheckBoxResetBOR
        '
        Me.CheckBoxResetBOR.AutoSize = True
        Me.CheckBoxResetBOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetBOR.Location = New System.Drawing.Point(337, 439)
        Me.CheckBoxResetBOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetBOR.Name = "CheckBoxResetBOR"
        Me.CheckBoxResetBOR.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetBOR.TabIndex = 275
        Me.CheckBoxResetBOR.Text = "BOR"
        Me.CheckBoxResetBOR.UseVisualStyleBackColor = True
        '
        'CheckBoxResetIdle
        '
        Me.CheckBoxResetIdle.AutoSize = True
        Me.CheckBoxResetIdle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetIdle.Location = New System.Drawing.Point(337, 419)
        Me.CheckBoxResetIdle.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetIdle.Name = "CheckBoxResetIdle"
        Me.CheckBoxResetIdle.Size = New System.Drawing.Size(49, 20)
        Me.CheckBoxResetIdle.TabIndex = 274
        Me.CheckBoxResetIdle.Text = "Idle"
        Me.CheckBoxResetIdle.UseVisualStyleBackColor = True
        '
        'CheckBoxResetSleep
        '
        Me.CheckBoxResetSleep.AutoSize = True
        Me.CheckBoxResetSleep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetSleep.Location = New System.Drawing.Point(337, 399)
        Me.CheckBoxResetSleep.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetSleep.Name = "CheckBoxResetSleep"
        Me.CheckBoxResetSleep.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxResetSleep.TabIndex = 273
        Me.CheckBoxResetSleep.Text = "Sleep"
        Me.CheckBoxResetSleep.UseVisualStyleBackColor = True
        '
        'CheckBoxResetWDT
        '
        Me.CheckBoxResetWDT.AutoSize = True
        Me.CheckBoxResetWDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetWDT.Location = New System.Drawing.Point(266, 479)
        Me.CheckBoxResetWDT.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetWDT.Name = "CheckBoxResetWDT"
        Me.CheckBoxResetWDT.Size = New System.Drawing.Size(59, 20)
        Me.CheckBoxResetWDT.TabIndex = 272
        Me.CheckBoxResetWDT.Text = "WDT"
        Me.CheckBoxResetWDT.UseVisualStyleBackColor = True
        '
        'CheckBoxResetSoftware
        '
        Me.CheckBoxResetSoftware.AutoSize = True
        Me.CheckBoxResetSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetSoftware.Location = New System.Drawing.Point(266, 459)
        Me.CheckBoxResetSoftware.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetSoftware.Name = "CheckBoxResetSoftware"
        Me.CheckBoxResetSoftware.Size = New System.Drawing.Size(49, 20)
        Me.CheckBoxResetSoftware.TabIndex = 271
        Me.CheckBoxResetSoftware.Text = "SW"
        Me.CheckBoxResetSoftware.UseVisualStyleBackColor = True
        '
        'CheckBoxResetExt
        '
        Me.CheckBoxResetExt.AutoSize = True
        Me.CheckBoxResetExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetExt.Location = New System.Drawing.Point(266, 439)
        Me.CheckBoxResetExt.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetExt.Name = "CheckBoxResetExt"
        Me.CheckBoxResetExt.Size = New System.Drawing.Size(45, 20)
        Me.CheckBoxResetExt.TabIndex = 270
        Me.CheckBoxResetExt.Text = "Ext"
        Me.CheckBoxResetExt.UseVisualStyleBackColor = True
        '
        'CheckBoxResetIllegal
        '
        Me.CheckBoxResetIllegal.AutoSize = True
        Me.CheckBoxResetIllegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetIllegal.Location = New System.Drawing.Point(266, 419)
        Me.CheckBoxResetIllegal.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetIllegal.Name = "CheckBoxResetIllegal"
        Me.CheckBoxResetIllegal.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxResetIllegal.TabIndex = 269
        Me.CheckBoxResetIllegal.Text = "Illegal"
        Me.CheckBoxResetIllegal.UseVisualStyleBackColor = True
        '
        'CheckBoxResetTrap
        '
        Me.CheckBoxResetTrap.AutoSize = True
        Me.CheckBoxResetTrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetTrap.Location = New System.Drawing.Point(266, 399)
        Me.CheckBoxResetTrap.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetTrap.Name = "CheckBoxResetTrap"
        Me.CheckBoxResetTrap.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetTrap.TabIndex = 268
        Me.CheckBoxResetTrap.Text = "Trap"
        Me.CheckBoxResetTrap.UseVisualStyleBackColor = True
        '
        'LabelRCON
        '
        Me.LabelRCON.AutoSize = True
        Me.LabelRCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRCON.Location = New System.Drawing.Point(6, 483)
        Me.LabelRCON.Name = "LabelRCON"
        Me.LabelRCON.Size = New System.Drawing.Size(71, 16)
        Me.LabelRCON.TabIndex = 267
        Me.LabelRCON.Text = "LabelError"
        '
        'ButtonResetSlave
        '
        Me.ButtonResetSlave.Location = New System.Drawing.Point(283, 593)
        Me.ButtonResetSlave.Name = "ButtonResetSlave"
        Me.ButtonResetSlave.Size = New System.Drawing.Size(103, 23)
        Me.ButtonResetSlave.TabIndex = 266
        Me.ButtonResetSlave.Text = "Reset Slave"
        Me.ButtonResetSlave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 265
        Me.Button1.Text = "Reload Defaults"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(112, 567)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 264
        Me.Label15.Text = "Scale"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(112, 596)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 263
        Me.Label14.Text = "Offset"
        '
        'LabelEEpromIndex
        '
        Me.LabelEEpromIndex.AutoSize = True
        Me.LabelEEpromIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEEpromIndex.Location = New System.Drawing.Point(183, 531)
        Me.LabelEEpromIndex.Name = "LabelEEpromIndex"
        Me.LabelEEpromIndex.Size = New System.Drawing.Size(53, 16)
        Me.LabelEEpromIndex.TabIndex = 262
        Me.LabelEEpromIndex.Text = "Index = "
        '
        'ComboBoxEEpromRegister
        '
        Me.ComboBoxEEpromRegister.FormattingEnabled = True
        Me.ComboBoxEEpromRegister.Items.AddRange(New Object() {"ADC AN0 ", "ADC AN0 - External", "ADC AN1 ", "ADC AN1 - External", "ADC AN2 ", "ADC AN2 - External", "ADC AN3 ", "ADC AN3 - External", "ADC AN4 ", "ADC AN4 - External", "ADC AN5 ", "ADC AN5 - External", "ADC AN6 ", "ADC AN6 - External", "ADC AN7 ", "ADC AN7 - External", "ADC AN8 ", "ADC AN8 - External", "ADC AN9 ", "ADC AN9 - External", "ADC AN10 ", "ADC AN10 - External", "ADC AN11 ", "ADC AN11 - External", "ADC AN12 ", "ADC AN12 - External", "ADC AN13 ", "ADC AN13 - External", "ADC AN14 ", "ADC AN14 - External", "ADC AN15 ", "ADC AN15 - External", "DAC CH0", "DAC CH0 - External", "DAC CH1", "DAC CH1 - External", "DAC CH2", "DAC CH2 - External", "DAC CH3", "DAC CH3 - External", "DAC CH4", "DAC CH4 - External", "DAC CH5", "DAC CH5 - External", "DAC CH6", "DAC CH6 - External", "DAC CH7", "DAC CH7 - External"})
        Me.ComboBoxEEpromRegister.Location = New System.Drawing.Point(6, 526)
        Me.ComboBoxEEpromRegister.Name = "ComboBoxEEpromRegister"
        Me.ComboBoxEEpromRegister.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxEEpromRegister.TabIndex = 261
        Me.ComboBoxEEpromRegister.Text = "Select Register"
        '
        'TextBoxEEpromOffSet
        '
        Me.TextBoxEEpromOffSet.Location = New System.Drawing.Point(6, 592)
        Me.TextBoxEEpromOffSet.MaxLength = 7
        Me.TextBoxEEpromOffSet.Name = "TextBoxEEpromOffSet"
        Me.TextBoxEEpromOffSet.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEEpromOffSet.TabIndex = 260
        '
        'TextBoxEEpromScale
        '
        Me.TextBoxEEpromScale.Location = New System.Drawing.Point(6, 563)
        Me.TextBoxEEpromScale.MaxLength = 7
        Me.TextBoxEEpromScale.Name = "TextBoxEEpromScale"
        Me.TextBoxEEpromScale.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEEpromScale.TabIndex = 259
        '
        'ButtonWriteEEprom
        '
        Me.ButtonWriteEEprom.Location = New System.Drawing.Point(161, 593)
        Me.ButtonWriteEEprom.Name = "ButtonWriteEEprom"
        Me.ButtonWriteEEprom.Size = New System.Drawing.Size(103, 23)
        Me.ButtonWriteEEprom.TabIndex = 258
        Me.ButtonWriteEEprom.Text = "Write EEProm"
        Me.ButtonWriteEEprom.UseVisualStyleBackColor = True
        '
        'ButtonReadEEprom
        '
        Me.ButtonReadEEprom.Location = New System.Drawing.Point(161, 564)
        Me.ButtonReadEEprom.Name = "ButtonReadEEprom"
        Me.ButtonReadEEprom.Size = New System.Drawing.Size(103, 23)
        Me.ButtonReadEEprom.TabIndex = 257
        Me.ButtonReadEEprom.Text = "Read EEProm"
        Me.ButtonReadEEprom.UseVisualStyleBackColor = True
        '
        'LabelValueDebugF
        '
        Me.LabelValueDebugF.AutoSize = True
        Me.LabelValueDebugF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugF.Location = New System.Drawing.Point(675, 257)
        Me.LabelValueDebugF.Name = "LabelValueDebugF"
        Me.LabelValueDebugF.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugF.TabIndex = 256
        Me.LabelValueDebugF.Text = "ValueDebug"
        '
        'LabelValueDebugE
        '
        Me.LabelValueDebugE.AutoSize = True
        Me.LabelValueDebugE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugE.Location = New System.Drawing.Point(675, 241)
        Me.LabelValueDebugE.Name = "LabelValueDebugE"
        Me.LabelValueDebugE.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugE.TabIndex = 255
        Me.LabelValueDebugE.Text = "ValueDebug"
        '
        'LabelValueDebugD
        '
        Me.LabelValueDebugD.AutoSize = True
        Me.LabelValueDebugD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugD.Location = New System.Drawing.Point(675, 225)
        Me.LabelValueDebugD.Name = "LabelValueDebugD"
        Me.LabelValueDebugD.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugD.TabIndex = 254
        Me.LabelValueDebugD.Text = "ValueDebug"
        '
        'LabelValueDebugC
        '
        Me.LabelValueDebugC.AutoSize = True
        Me.LabelValueDebugC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugC.Location = New System.Drawing.Point(675, 209)
        Me.LabelValueDebugC.Name = "LabelValueDebugC"
        Me.LabelValueDebugC.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugC.TabIndex = 253
        Me.LabelValueDebugC.Text = "ValueDebug"
        '
        'LabelValueDebugB
        '
        Me.LabelValueDebugB.AutoSize = True
        Me.LabelValueDebugB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugB.Location = New System.Drawing.Point(675, 193)
        Me.LabelValueDebugB.Name = "LabelValueDebugB"
        Me.LabelValueDebugB.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugB.TabIndex = 252
        Me.LabelValueDebugB.Text = "ValueDebug"
        '
        'LabelValueDebugA
        '
        Me.LabelValueDebugA.AutoSize = True
        Me.LabelValueDebugA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugA.Location = New System.Drawing.Point(675, 177)
        Me.LabelValueDebugA.Name = "LabelValueDebugA"
        Me.LabelValueDebugA.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugA.TabIndex = 251
        Me.LabelValueDebugA.Text = "ValueDebug"
        '
        'LabelValueDebug9
        '
        Me.LabelValueDebug9.AutoSize = True
        Me.LabelValueDebug9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug9.Location = New System.Drawing.Point(675, 161)
        Me.LabelValueDebug9.Name = "LabelValueDebug9"
        Me.LabelValueDebug9.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug9.TabIndex = 250
        Me.LabelValueDebug9.Text = "ValueDebug"
        '
        'LabelValueDebug8
        '
        Me.LabelValueDebug8.AutoSize = True
        Me.LabelValueDebug8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug8.Location = New System.Drawing.Point(675, 145)
        Me.LabelValueDebug8.Name = "LabelValueDebug8"
        Me.LabelValueDebug8.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug8.TabIndex = 249
        Me.LabelValueDebug8.Text = "ValueDebug"
        '
        'LabelValueDebug7
        '
        Me.LabelValueDebug7.AutoSize = True
        Me.LabelValueDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug7.Location = New System.Drawing.Point(675, 129)
        Me.LabelValueDebug7.Name = "LabelValueDebug7"
        Me.LabelValueDebug7.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug7.TabIndex = 248
        Me.LabelValueDebug7.Text = "ValueDebug"
        '
        'LabelValueDebug6
        '
        Me.LabelValueDebug6.AutoSize = True
        Me.LabelValueDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug6.Location = New System.Drawing.Point(675, 113)
        Me.LabelValueDebug6.Name = "LabelValueDebug6"
        Me.LabelValueDebug6.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug6.TabIndex = 247
        Me.LabelValueDebug6.Text = "ValueDebug"
        '
        'LabelValueDebug5
        '
        Me.LabelValueDebug5.AutoSize = True
        Me.LabelValueDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug5.Location = New System.Drawing.Point(675, 97)
        Me.LabelValueDebug5.Name = "LabelValueDebug5"
        Me.LabelValueDebug5.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug5.TabIndex = 246
        Me.LabelValueDebug5.Text = "ValueDebug"
        '
        'LabelValueDebug4
        '
        Me.LabelValueDebug4.AutoSize = True
        Me.LabelValueDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug4.Location = New System.Drawing.Point(675, 81)
        Me.LabelValueDebug4.Name = "LabelValueDebug4"
        Me.LabelValueDebug4.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug4.TabIndex = 245
        Me.LabelValueDebug4.Text = "ValueDebug"
        '
        'LabelValueDebug3
        '
        Me.LabelValueDebug3.AutoSize = True
        Me.LabelValueDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug3.Location = New System.Drawing.Point(675, 65)
        Me.LabelValueDebug3.Name = "LabelValueDebug3"
        Me.LabelValueDebug3.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug3.TabIndex = 244
        Me.LabelValueDebug3.Text = "ValueDebug"
        '
        'LabelValueDebug2
        '
        Me.LabelValueDebug2.AutoSize = True
        Me.LabelValueDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug2.Location = New System.Drawing.Point(675, 49)
        Me.LabelValueDebug2.Name = "LabelValueDebug2"
        Me.LabelValueDebug2.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug2.TabIndex = 243
        Me.LabelValueDebug2.Text = "ValueDebug"
        '
        'LabelValueDebug1
        '
        Me.LabelValueDebug1.AutoSize = True
        Me.LabelValueDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug1.Location = New System.Drawing.Point(675, 33)
        Me.LabelValueDebug1.Name = "LabelValueDebug1"
        Me.LabelValueDebug1.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug1.TabIndex = 242
        Me.LabelValueDebug1.Text = "ValueDebug"
        '
        'LabelValueDebug0
        '
        Me.LabelValueDebug0.AutoSize = True
        Me.LabelValueDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug0.Location = New System.Drawing.Point(675, 17)
        Me.LabelValueDebug0.Name = "LabelValueDebug0"
        Me.LabelValueDebug0.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug0.TabIndex = 241
        Me.LabelValueDebug0.Text = "ValueDebug"
        '
        'ButtonBoardCommand
        '
        Me.ButtonBoardCommand.Location = New System.Drawing.Point(432, 331)
        Me.ButtonBoardCommand.Name = "ButtonBoardCommand"
        Me.ButtonBoardCommand.Size = New System.Drawing.Size(103, 23)
        Me.ButtonBoardCommand.TabIndex = 240
        Me.ButtonBoardCommand.Text = "Board Command"
        Me.ButtonBoardCommand.UseVisualStyleBackColor = True
        '
        'LabelValue10
        '
        Me.LabelValue10.AutoSize = True
        Me.LabelValue10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue10.Location = New System.Drawing.Point(469, 515)
        Me.LabelValue10.Name = "LabelValue10"
        Me.LabelValue10.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue10.TabIndex = 234
        Me.LabelValue10.Text = "Label Value 10"
        '
        'LabelValue9
        '
        Me.LabelValue9.AutoSize = True
        Me.LabelValue9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue9.Location = New System.Drawing.Point(469, 499)
        Me.LabelValue9.Name = "LabelValue9"
        Me.LabelValue9.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue9.TabIndex = 233
        Me.LabelValue9.Text = "Label Value 9"
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
        'LabelValue8
        '
        Me.LabelValue8.AutoSize = True
        Me.LabelValue8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue8.Location = New System.Drawing.Point(469, 484)
        Me.LabelValue8.Name = "LabelValue8"
        Me.LabelValue8.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue8.TabIndex = 232
        Me.LabelValue8.Text = "Label Value 8"
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
        'LabelValue7
        '
        Me.LabelValue7.AutoSize = True
        Me.LabelValue7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue7.Location = New System.Drawing.Point(469, 468)
        Me.LabelValue7.Name = "LabelValue7"
        Me.LabelValue7.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue7.TabIndex = 231
        Me.LabelValue7.Text = "Label Value 7"
        '
        'LabelErrorStatusDataB
        '
        Me.LabelErrorStatusDataB.AutoSize = True
        Me.LabelErrorStatusDataB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorStatusDataB.Location = New System.Drawing.Point(6, 467)
        Me.LabelErrorStatusDataB.Name = "LabelErrorStatusDataB"
        Me.LabelErrorStatusDataB.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorStatusDataB.TabIndex = 190
        Me.LabelErrorStatusDataB.Text = "LabelError"
        '
        'LabelValue6
        '
        Me.LabelValue6.AutoSize = True
        Me.LabelValue6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue6.Location = New System.Drawing.Point(469, 452)
        Me.LabelValue6.Name = "LabelValue6"
        Me.LabelValue6.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue6.TabIndex = 230
        Me.LabelValue6.Text = "Label Value 6"
        '
        'LabelErrorStatusDataA
        '
        Me.LabelErrorStatusDataA.AutoSize = True
        Me.LabelErrorStatusDataA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorStatusDataA.Location = New System.Drawing.Point(6, 451)
        Me.LabelErrorStatusDataA.Name = "LabelErrorStatusDataA"
        Me.LabelErrorStatusDataA.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorStatusDataA.TabIndex = 189
        Me.LabelErrorStatusDataA.Text = "LabelError"
        '
        'LabelValue5
        '
        Me.LabelValue5.AutoSize = True
        Me.LabelValue5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue5.Location = New System.Drawing.Point(469, 436)
        Me.LabelValue5.Name = "LabelValue5"
        Me.LabelValue5.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue5.TabIndex = 229
        Me.LabelValue5.Text = "Label Value 5"
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
        'LabelValue4
        '
        Me.LabelValue4.AutoSize = True
        Me.LabelValue4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue4.Location = New System.Drawing.Point(469, 420)
        Me.LabelValue4.Name = "LabelValue4"
        Me.LabelValue4.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue4.TabIndex = 228
        Me.LabelValue4.Text = "Label Value 4"
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
        'LabelValue3
        '
        Me.LabelValue3.AutoSize = True
        Me.LabelValue3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue3.Location = New System.Drawing.Point(469, 404)
        Me.LabelValue3.Name = "LabelValue3"
        Me.LabelValue3.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue3.TabIndex = 227
        Me.LabelValue3.Text = "Label Value 3"
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
        'LabelValue2
        '
        Me.LabelValue2.AutoSize = True
        Me.LabelValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue2.Location = New System.Drawing.Point(469, 388)
        Me.LabelValue2.Name = "LabelValue2"
        Me.LabelValue2.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue2.TabIndex = 226
        Me.LabelValue2.Text = "Label Value 2"
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
        'LabelValue1
        '
        Me.LabelValue1.AutoSize = True
        Me.LabelValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue1.Location = New System.Drawing.Point(469, 372)
        Me.LabelValue1.Name = "LabelValue1"
        Me.LabelValue1.Size = New System.Drawing.Size(90, 16)
        Me.LabelValue1.TabIndex = 222
        Me.LabelValue1.Text = "Label Value 1"
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
        'ButtonUpdateInput2
        '
        Me.ButtonUpdateInput2.Location = New System.Drawing.Point(659, 306)
        Me.ButtonUpdateInput2.Name = "ButtonUpdateInput2"
        Me.ButtonUpdateInput2.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput2.TabIndex = 225
        Me.ButtonUpdateInput2.Text = "Update Input 2"
        Me.ButtonUpdateInput2.UseVisualStyleBackColor = True
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
        'ButtonUpdateInput1
        '
        Me.ButtonUpdateInput1.Location = New System.Drawing.Point(659, 280)
        Me.ButtonUpdateInput1.Name = "ButtonUpdateInput1"
        Me.ButtonUpdateInput1.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput1.TabIndex = 224
        Me.ButtonUpdateInput1.Text = "Update Input 1"
        Me.ButtonUpdateInput1.UseVisualStyleBackColor = True
        '
        'LabelDebugF
        '
        Me.LabelDebugF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugF.Location = New System.Drawing.Point(469, 257)
        Me.LabelDebugF.Name = "LabelDebugF"
        Me.LabelDebugF.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugF.TabIndex = 182
        Me.LabelDebugF.Text = "lbldebug"
        Me.LabelDebugF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugE
        '
        Me.LabelDebugE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugE.Location = New System.Drawing.Point(469, 241)
        Me.LabelDebugE.Name = "LabelDebugE"
        Me.LabelDebugE.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugE.TabIndex = 181
        Me.LabelDebugE.Text = "lbldebug"
        Me.LabelDebugE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugD
        '
        Me.LabelDebugD.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugD.Location = New System.Drawing.Point(469, 225)
        Me.LabelDebugD.Name = "LabelDebugD"
        Me.LabelDebugD.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugD.TabIndex = 180
        Me.LabelDebugD.Text = "lbldebug"
        Me.LabelDebugD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugC
        '
        Me.LabelDebugC.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugC.Location = New System.Drawing.Point(469, 209)
        Me.LabelDebugC.Name = "LabelDebugC"
        Me.LabelDebugC.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugC.TabIndex = 179
        Me.LabelDebugC.Text = "lbldebug"
        Me.LabelDebugC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugB
        '
        Me.LabelDebugB.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugB.Location = New System.Drawing.Point(469, 193)
        Me.LabelDebugB.Name = "LabelDebugB"
        Me.LabelDebugB.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugB.TabIndex = 178
        Me.LabelDebugB.Text = "lbldebug"
        Me.LabelDebugB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugA
        '
        Me.LabelDebugA.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebugA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugA.Location = New System.Drawing.Point(469, 177)
        Me.LabelDebugA.Name = "LabelDebugA"
        Me.LabelDebugA.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugA.TabIndex = 177
        Me.LabelDebugA.Text = "lbldebug"
        Me.LabelDebugA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInput1
        '
        Me.TextBoxInput1.Location = New System.Drawing.Point(553, 282)
        Me.TextBoxInput1.MaxLength = 5
        Me.TextBoxInput1.Name = "TextBoxInput1"
        Me.TextBoxInput1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput1.TabIndex = 206
        '
        'LabelDebug9
        '
        Me.LabelDebug9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug9.Location = New System.Drawing.Point(469, 161)
        Me.LabelDebug9.Name = "LabelDebug9"
        Me.LabelDebug9.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug9.TabIndex = 176
        Me.LabelDebug9.Text = "lbldebug"
        Me.LabelDebug9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInput2
        '
        Me.TextBoxInput2.Location = New System.Drawing.Point(553, 308)
        Me.TextBoxInput2.MaxLength = 5
        Me.TextBoxInput2.Name = "TextBoxInput2"
        Me.TextBoxInput2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput2.TabIndex = 208
        '
        'LabelDebug8
        '
        Me.LabelDebug8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug8.Location = New System.Drawing.Point(469, 145)
        Me.LabelDebug8.Name = "LabelDebug8"
        Me.LabelDebug8.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug8.TabIndex = 175
        Me.LabelDebug8.Text = "lbldebug"
        Me.LabelDebug8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug7
        '
        Me.LabelDebug7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug7.Location = New System.Drawing.Point(469, 129)
        Me.LabelDebug7.Name = "LabelDebug7"
        Me.LabelDebug7.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug7.TabIndex = 174
        Me.LabelDebug7.Text = "lbldebug"
        Me.LabelDebug7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug6
        '
        Me.LabelDebug6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug6.Location = New System.Drawing.Point(469, 113)
        Me.LabelDebug6.Name = "LabelDebug6"
        Me.LabelDebug6.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug6.TabIndex = 173
        Me.LabelDebug6.Text = "lbldebug"
        Me.LabelDebug6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug5
        '
        Me.LabelDebug5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug5.Location = New System.Drawing.Point(469, 97)
        Me.LabelDebug5.Name = "LabelDebug5"
        Me.LabelDebug5.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug5.TabIndex = 172
        Me.LabelDebug5.Text = "lbldebug"
        Me.LabelDebug5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug4
        '
        Me.LabelDebug4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug4.Location = New System.Drawing.Point(469, 81)
        Me.LabelDebug4.Name = "LabelDebug4"
        Me.LabelDebug4.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug4.TabIndex = 171
        Me.LabelDebug4.Text = "lbldebug"
        Me.LabelDebug4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug3
        '
        Me.LabelDebug3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug3.Location = New System.Drawing.Point(469, 65)
        Me.LabelDebug3.Name = "LabelDebug3"
        Me.LabelDebug3.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug3.TabIndex = 170
        Me.LabelDebug3.Text = "lbldebug"
        Me.LabelDebug3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug2
        '
        Me.LabelDebug2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug2.Location = New System.Drawing.Point(469, 49)
        Me.LabelDebug2.Name = "LabelDebug2"
        Me.LabelDebug2.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug2.TabIndex = 169
        Me.LabelDebug2.Text = "lbldebug"
        Me.LabelDebug2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug1
        '
        Me.LabelDebug1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug1.Location = New System.Drawing.Point(469, 33)
        Me.LabelDebug1.Name = "LabelDebug1"
        Me.LabelDebug1.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug1.TabIndex = 168
        Me.LabelDebug1.Text = "lbldebug"
        Me.LabelDebug1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug0
        '
        Me.LabelDebug0.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug0.Location = New System.Drawing.Point(469, 16)
        Me.LabelDebug0.Name = "LabelDebug0"
        Me.LabelDebug0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDebug0.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug0.TabIndex = 167
        Me.LabelDebug0.Text = "lbldebug"
        Me.LabelDebug0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'CheckBoxFaultBitF
        '
        Me.CheckBoxFaultBitF.AutoSize = True
        Me.CheckBoxFaultBitF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitF.Location = New System.Drawing.Point(156, 320)
        Me.CheckBoxFaultBitF.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitF.Name = "CheckBoxFaultBitF"
        Me.CheckBoxFaultBitF.Size = New System.Drawing.Size(85, 20)
        Me.CheckBoxFaultBitF.TabIndex = 142
        Me.CheckBoxFaultBitF.Text = "Fault Bit F"
        Me.CheckBoxFaultBitF.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitE
        '
        Me.CheckBoxFaultBitE.AutoSize = True
        Me.CheckBoxFaultBitE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitE.Location = New System.Drawing.Point(156, 300)
        Me.CheckBoxFaultBitE.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitE.Name = "CheckBoxFaultBitE"
        Me.CheckBoxFaultBitE.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitE.TabIndex = 141
        Me.CheckBoxFaultBitE.Text = "Fault Bit E"
        Me.CheckBoxFaultBitE.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitD
        '
        Me.CheckBoxFaultBitD.AutoSize = True
        Me.CheckBoxFaultBitD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitD.Location = New System.Drawing.Point(156, 280)
        Me.CheckBoxFaultBitD.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitD.Name = "CheckBoxFaultBitD"
        Me.CheckBoxFaultBitD.Size = New System.Drawing.Size(87, 20)
        Me.CheckBoxFaultBitD.TabIndex = 140
        Me.CheckBoxFaultBitD.Text = "Fault Bit D"
        Me.CheckBoxFaultBitD.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitC
        '
        Me.CheckBoxFaultBitC.AutoSize = True
        Me.CheckBoxFaultBitC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitC.Location = New System.Drawing.Point(156, 260)
        Me.CheckBoxFaultBitC.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitC.Name = "CheckBoxFaultBitC"
        Me.CheckBoxFaultBitC.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitC.TabIndex = 139
        Me.CheckBoxFaultBitC.Text = "Fault Bit C"
        Me.CheckBoxFaultBitC.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitB
        '
        Me.CheckBoxFaultBitB.AutoSize = True
        Me.CheckBoxFaultBitB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitB.Location = New System.Drawing.Point(156, 238)
        Me.CheckBoxFaultBitB.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitB.Name = "CheckBoxFaultBitB"
        Me.CheckBoxFaultBitB.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitB.TabIndex = 138
        Me.CheckBoxFaultBitB.Text = "Fault Bit B"
        Me.CheckBoxFaultBitB.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitA
        '
        Me.CheckBoxFaultBitA.AutoSize = True
        Me.CheckBoxFaultBitA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitA.Location = New System.Drawing.Point(156, 218)
        Me.CheckBoxFaultBitA.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitA.Name = "CheckBoxFaultBitA"
        Me.CheckBoxFaultBitA.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitA.TabIndex = 137
        Me.CheckBoxFaultBitA.Text = "Fault Bit A"
        Me.CheckBoxFaultBitA.UseVisualStyleBackColor = True
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
        'CheckBoxStatusBit7
        '
        Me.CheckBoxStatusBit7.AutoSize = True
        Me.CheckBoxStatusBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit7.Location = New System.Drawing.Point(3, 320)
        Me.CheckBoxStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit7.Name = "CheckBoxStatusBit7"
        Me.CheckBoxStatusBit7.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit7.TabIndex = 126
        Me.CheckBoxStatusBit7.Text = "Status Bit 7"
        Me.CheckBoxStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit6
        '
        Me.CheckBoxStatusBit6.AutoSize = True
        Me.CheckBoxStatusBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit6.Location = New System.Drawing.Point(3, 300)
        Me.CheckBoxStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit6.Name = "CheckBoxStatusBit6"
        Me.CheckBoxStatusBit6.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit6.TabIndex = 125
        Me.CheckBoxStatusBit6.Text = "Status Bit 6"
        Me.CheckBoxStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit5
        '
        Me.CheckBoxStatusBit5.AutoSize = True
        Me.CheckBoxStatusBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit5.Location = New System.Drawing.Point(3, 280)
        Me.CheckBoxStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit5.Name = "CheckBoxStatusBit5"
        Me.CheckBoxStatusBit5.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit5.TabIndex = 124
        Me.CheckBoxStatusBit5.Text = "Status Bit 5"
        Me.CheckBoxStatusBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit4
        '
        Me.CheckBoxStatusBit4.AutoSize = True
        Me.CheckBoxStatusBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit4.Location = New System.Drawing.Point(3, 260)
        Me.CheckBoxStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit4.Name = "CheckBoxStatusBit4"
        Me.CheckBoxStatusBit4.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit4.TabIndex = 123
        Me.CheckBoxStatusBit4.Text = "Status Bit 4"
        Me.CheckBoxStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit3
        '
        Me.CheckBoxStatusBit3.AutoSize = True
        Me.CheckBoxStatusBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit3.Location = New System.Drawing.Point(3, 238)
        Me.CheckBoxStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit3.Name = "CheckBoxStatusBit3"
        Me.CheckBoxStatusBit3.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit3.TabIndex = 122
        Me.CheckBoxStatusBit3.Text = "Status Bit 3"
        Me.CheckBoxStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit2
        '
        Me.CheckBoxStatusBit2.AutoSize = True
        Me.CheckBoxStatusBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit2.Location = New System.Drawing.Point(3, 218)
        Me.CheckBoxStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit2.Name = "CheckBoxStatusBit2"
        Me.CheckBoxStatusBit2.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit2.TabIndex = 121
        Me.CheckBoxStatusBit2.Text = "Status Bit 2"
        Me.CheckBoxStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit1
        '
        Me.CheckBoxStatusBit1.AutoSize = True
        Me.CheckBoxStatusBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit1.Location = New System.Drawing.Point(3, 198)
        Me.CheckBoxStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit1.Name = "CheckBoxStatusBit1"
        Me.CheckBoxStatusBit1.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit1.TabIndex = 120
        Me.CheckBoxStatusBit1.Text = "Status Bit 1"
        Me.CheckBoxStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxStatusBit0
        '
        Me.CheckBoxStatusBit0.AutoSize = True
        Me.CheckBoxStatusBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStatusBit0.Location = New System.Drawing.Point(3, 178)
        Me.CheckBoxStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStatusBit0.Name = "CheckBoxStatusBit0"
        Me.CheckBoxStatusBit0.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxStatusBit0.TabIndex = 119
        Me.CheckBoxStatusBit0.Text = "Status Bit 0"
        Me.CheckBoxStatusBit0.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit7
        '
        Me.CheckBoxControlBit7.AutoSize = True
        Me.CheckBoxControlBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit7.Location = New System.Drawing.Point(3, 158)
        Me.CheckBoxControlBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit7.Name = "CheckBoxControlBit7"
        Me.CheckBoxControlBit7.Size = New System.Drawing.Size(116, 20)
        Me.CheckBoxControlBit7.TabIndex = 118
        Me.CheckBoxControlBit7.Text = "Not Connected"
        Me.CheckBoxControlBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit6
        '
        Me.CheckBoxControlBit6.AutoSize = True
        Me.CheckBoxControlBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit6.Location = New System.Drawing.Point(3, 138)
        Me.CheckBoxControlBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit6.Name = "CheckBoxControlBit6"
        Me.CheckBoxControlBit6.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit6.TabIndex = 117
        Me.CheckBoxControlBit6.Text = "Unused"
        Me.CheckBoxControlBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit5
        '
        Me.CheckBoxControlBit5.AutoSize = True
        Me.CheckBoxControlBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit5.Location = New System.Drawing.Point(3, 118)
        Me.CheckBoxControlBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit5.Name = "CheckBoxControlBit5"
        Me.CheckBoxControlBit5.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit5.TabIndex = 116
        Me.CheckBoxControlBit5.Text = "Unused"
        Me.CheckBoxControlBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit4
        '
        Me.CheckBoxControlBit4.AutoSize = True
        Me.CheckBoxControlBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit4.Location = New System.Drawing.Point(3, 98)
        Me.CheckBoxControlBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit4.Name = "CheckBoxControlBit4"
        Me.CheckBoxControlBit4.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit4.TabIndex = 115
        Me.CheckBoxControlBit4.Text = "Unused"
        Me.CheckBoxControlBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit3
        '
        Me.CheckBoxControlBit3.AutoSize = True
        Me.CheckBoxControlBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit3.Location = New System.Drawing.Point(3, 76)
        Me.CheckBoxControlBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit3.Name = "CheckBoxControlBit3"
        Me.CheckBoxControlBit3.Size = New System.Drawing.Size(123, 20)
        Me.CheckBoxControlBit3.TabIndex = 114
        Me.CheckBoxControlBit3.Text = "Self Check Error"
        Me.CheckBoxControlBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit2
        '
        Me.CheckBoxControlBit2.AutoSize = True
        Me.CheckBoxControlBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit2.Location = New System.Drawing.Point(3, 56)
        Me.CheckBoxControlBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit2.Name = "CheckBoxControlBit2"
        Me.CheckBoxControlBit2.Size = New System.Drawing.Size(116, 20)
        Me.CheckBoxControlBit2.TabIndex = 113
        Me.CheckBoxControlBit2.Text = "Not Configured"
        Me.CheckBoxControlBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit1
        '
        Me.CheckBoxControlBit1.AutoSize = True
        Me.CheckBoxControlBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit1.Location = New System.Drawing.Point(3, 36)
        Me.CheckBoxControlBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit1.Name = "CheckBoxControlBit1"
        Me.CheckBoxControlBit1.Size = New System.Drawing.Size(91, 20)
        Me.CheckBoxControlBit1.TabIndex = 112
        Me.CheckBoxControlBit1.Text = "Can Status"
        Me.CheckBoxControlBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBit0
        '
        Me.CheckBoxControlBit0.AutoSize = True
        Me.CheckBoxControlBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit0.Location = New System.Drawing.Point(3, 16)
        Me.CheckBoxControlBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit0.Name = "CheckBoxControlBit0"
        Me.CheckBoxControlBit0.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxControlBit0.TabIndex = 111
        Me.CheckBoxControlBit0.Text = "Not Ready"
        Me.CheckBoxControlBit0.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit4
        '
        Me.CheckBoxSyncBit4.AutoSize = True
        Me.CheckBoxSyncBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit4.Location = New System.Drawing.Point(952, 522)
        Me.CheckBoxSyncBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit4.Name = "CheckBoxSyncBit4"
        Me.CheckBoxSyncBit4.Size = New System.Drawing.Size(100, 20)
        Me.CheckBoxSyncBit4.TabIndex = 261
        Me.CheckBoxSyncBit4.Text = "Cool FLT Bit"
        Me.CheckBoxSyncBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit3
        '
        Me.CheckBoxSyncBit3.AutoSize = True
        Me.CheckBoxSyncBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit3.Location = New System.Drawing.Point(952, 493)
        Me.CheckBoxSyncBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit3.Name = "CheckBoxSyncBit3"
        Me.CheckBoxSyncBit3.Size = New System.Drawing.Size(110, 20)
        Me.CheckBoxSyncBit3.TabIndex = 260
        Me.CheckBoxSyncBit3.Text = "XRAY OFF Bit"
        Me.CheckBoxSyncBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit2
        '
        Me.CheckBoxSyncBit2.AutoSize = True
        Me.CheckBoxSyncBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit2.Location = New System.Drawing.Point(952, 463)
        Me.CheckBoxSyncBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit2.Name = "CheckBoxSyncBit2"
        Me.CheckBoxSyncBit2.Size = New System.Drawing.Size(93, 20)
        Me.CheckBoxSyncBit2.TabIndex = 259
        Me.CheckBoxSyncBit2.Text = "HV OFF Bit"
        Me.CheckBoxSyncBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit1
        '
        Me.CheckBoxSyncBit1.AutoSize = True
        Me.CheckBoxSyncBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit1.Location = New System.Drawing.Point(952, 434)
        Me.CheckBoxSyncBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit1.Name = "CheckBoxSyncBit1"
        Me.CheckBoxSyncBit1.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxSyncBit1.TabIndex = 258
        Me.CheckBoxSyncBit1.Text = "HS Log Bit"
        Me.CheckBoxSyncBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit0
        '
        Me.CheckBoxSyncBit0.AutoSize = True
        Me.CheckBoxSyncBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit0.Location = New System.Drawing.Point(952, 405)
        Me.CheckBoxSyncBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit0.Name = "CheckBoxSyncBit0"
        Me.CheckBoxSyncBit0.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxSyncBit0.TabIndex = 257
        Me.CheckBoxSyncBit0.Text = "Reset Bit"
        Me.CheckBoxSyncBit0.UseVisualStyleBackColor = True
        '
        'ButtonToggleCoolantFault
        '
        Me.ButtonToggleCoolantFault.Location = New System.Drawing.Point(779, 520)
        Me.ButtonToggleCoolantFault.Name = "ButtonToggleCoolantFault"
        Me.ButtonToggleCoolantFault.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleCoolantFault.TabIndex = 236
        Me.ButtonToggleCoolantFault.Text = "Toggle Coolant Fault Bit"
        Me.ButtonToggleCoolantFault.UseVisualStyleBackColor = True
        '
        'ButtonToggleReset
        '
        Me.ButtonToggleReset.Location = New System.Drawing.Point(779, 402)
        Me.ButtonToggleReset.Name = "ButtonToggleReset"
        Me.ButtonToggleReset.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleReset.TabIndex = 205
        Me.ButtonToggleReset.Text = "Toggle Reset Enable Bit"
        Me.ButtonToggleReset.UseVisualStyleBackColor = True
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Items.AddRange(New Object() {"MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9), "MODBUS_WR_ION_PUMP", "MODBUS_WR_AFC", "MODBUS_WR_COOLING", "MODBUS_WR_HTR_MAGNET", "MODBUS_WR_GUN_DRIVER", "MODBUS_WR_MAGNETRON_CURRENT", "MODBUS_WR_PULSE_SYNC", "MODBUS_WR_ETHERNET"})
        Me.cboIndex.Location = New System.Drawing.Point(782, 31)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(171, 21)
        Me.cboIndex.TabIndex = 2
        Me.cboIndex.Text = "MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(782, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Choose a board:"
        '
        'LabelBoardStatus
        '
        Me.LabelBoardStatus.AutoSize = True
        Me.LabelBoardStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBoardStatus.Location = New System.Drawing.Point(782, 55)
        Me.LabelBoardStatus.Name = "LabelBoardStatus"
        Me.LabelBoardStatus.Size = New System.Drawing.Size(66, 16)
        Me.LabelBoardStatus.TabIndex = 152
        Me.LabelBoardStatus.Text = "LabelCan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(779, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Sync Message Cntrl Bits"
        '
        'ButtonToggleHighSpeedDataLogging
        '
        Me.ButtonToggleHighSpeedDataLogging.Location = New System.Drawing.Point(779, 431)
        Me.ButtonToggleHighSpeedDataLogging.Name = "ButtonToggleHighSpeedDataLogging"
        Me.ButtonToggleHighSpeedDataLogging.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleHighSpeedDataLogging.TabIndex = 237
        Me.ButtonToggleHighSpeedDataLogging.Text = "Toggle High Speed Logging"
        Me.ButtonToggleHighSpeedDataLogging.UseVisualStyleBackColor = True
        '
        'ButtonTogglePulseSyncHV
        '
        Me.ButtonTogglePulseSyncHV.Location = New System.Drawing.Point(779, 460)
        Me.ButtonTogglePulseSyncHV.Name = "ButtonTogglePulseSyncHV"
        Me.ButtonTogglePulseSyncHV.Size = New System.Drawing.Size(152, 23)
        Me.ButtonTogglePulseSyncHV.TabIndex = 238
        Me.ButtonTogglePulseSyncHV.Text = "Toggle Pulse Sync HV bit"
        Me.ButtonTogglePulseSyncHV.UseVisualStyleBackColor = True
        '
        'ButtonTogglePulseSyncXray
        '
        Me.ButtonTogglePulseSyncXray.Location = New System.Drawing.Point(779, 491)
        Me.ButtonTogglePulseSyncXray.Name = "ButtonTogglePulseSyncXray"
        Me.ButtonTogglePulseSyncXray.Size = New System.Drawing.Size(152, 23)
        Me.ButtonTogglePulseSyncXray.TabIndex = 239
        Me.ButtonTogglePulseSyncXray.Text = "Toggle Pulse Sync XRAY bit"
        Me.ButtonTogglePulseSyncXray.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit5
        '
        Me.CheckBoxSyncBit5.AutoSize = True
        Me.CheckBoxSyncBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit5.Location = New System.Drawing.Point(952, 319)
        Me.CheckBoxSyncBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit5.Name = "CheckBoxSyncBit5"
        Me.CheckBoxSyncBit5.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit5.TabIndex = 262
        Me.CheckBoxSyncBit5.Text = "Unused"
        Me.CheckBoxSyncBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit8
        '
        Me.CheckBoxSyncBit8.AutoSize = True
        Me.CheckBoxSyncBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit8.Location = New System.Drawing.Point(952, 367)
        Me.CheckBoxSyncBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit8.Name = "CheckBoxSyncBit8"
        Me.CheckBoxSyncBit8.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit8.TabIndex = 265
        Me.CheckBoxSyncBit8.Text = "Unused"
        Me.CheckBoxSyncBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit7
        '
        Me.CheckBoxSyncBit7.AutoSize = True
        Me.CheckBoxSyncBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit7.Location = New System.Drawing.Point(952, 351)
        Me.CheckBoxSyncBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit7.Name = "CheckBoxSyncBit7"
        Me.CheckBoxSyncBit7.Size = New System.Drawing.Size(88, 20)
        Me.CheckBoxSyncBit7.TabIndex = 264
        Me.CheckBoxSyncBit7.Text = "Gun Off Bit"
        Me.CheckBoxSyncBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBit6
        '
        Me.CheckBoxSyncBit6.AutoSize = True
        Me.CheckBoxSyncBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit6.Location = New System.Drawing.Point(952, 335)
        Me.CheckBoxSyncBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit6.Name = "CheckBoxSyncBit6"
        Me.CheckBoxSyncBit6.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit6.TabIndex = 263
        Me.CheckBoxSyncBit6.Text = "Unused"
        Me.CheckBoxSyncBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxPulseSyncConnected
        '
        Me.CheckBoxPulseSyncConnected.AutoSize = True
        Me.CheckBoxPulseSyncConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPulseSyncConnected.Location = New System.Drawing.Point(876, 211)
        Me.CheckBoxPulseSyncConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPulseSyncConnected.Name = "CheckBoxPulseSyncConnected"
        Me.CheckBoxPulseSyncConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxPulseSyncConnected.TabIndex = 273
        Me.CheckBoxPulseSyncConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxPulseCurrentMonitorConnected
        '
        Me.CheckBoxPulseCurrentMonitorConnected.AutoSize = True
        Me.CheckBoxPulseCurrentMonitorConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPulseCurrentMonitorConnected.Location = New System.Drawing.Point(876, 195)
        Me.CheckBoxPulseCurrentMonitorConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPulseCurrentMonitorConnected.Name = "CheckBoxPulseCurrentMonitorConnected"
        Me.CheckBoxPulseCurrentMonitorConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxPulseCurrentMonitorConnected.TabIndex = 272
        Me.CheckBoxPulseCurrentMonitorConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxGunDriverConnected
        '
        Me.CheckBoxGunDriverConnected.AutoSize = True
        Me.CheckBoxGunDriverConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxGunDriverConnected.Location = New System.Drawing.Point(876, 179)
        Me.CheckBoxGunDriverConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxGunDriverConnected.Name = "CheckBoxGunDriverConnected"
        Me.CheckBoxGunDriverConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxGunDriverConnected.TabIndex = 271
        Me.CheckBoxGunDriverConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxHtrMagConnected
        '
        Me.CheckBoxHtrMagConnected.AutoSize = True
        Me.CheckBoxHtrMagConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHtrMagConnected.Location = New System.Drawing.Point(876, 163)
        Me.CheckBoxHtrMagConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHtrMagConnected.Name = "CheckBoxHtrMagConnected"
        Me.CheckBoxHtrMagConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHtrMagConnected.TabIndex = 270
        Me.CheckBoxHtrMagConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxCoolingConnected
        '
        Me.CheckBoxCoolingConnected.AutoSize = True
        Me.CheckBoxCoolingConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCoolingConnected.Location = New System.Drawing.Point(876, 147)
        Me.CheckBoxCoolingConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxCoolingConnected.Name = "CheckBoxCoolingConnected"
        Me.CheckBoxCoolingConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxCoolingConnected.TabIndex = 269
        Me.CheckBoxCoolingConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxAFCConnected
        '
        Me.CheckBoxAFCConnected.AutoSize = True
        Me.CheckBoxAFCConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAFCConnected.Location = New System.Drawing.Point(876, 131)
        Me.CheckBoxAFCConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxAFCConnected.Name = "CheckBoxAFCConnected"
        Me.CheckBoxAFCConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxAFCConnected.TabIndex = 268
        Me.CheckBoxAFCConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxIonPumpConnected
        '
        Me.CheckBoxIonPumpConnected.AutoSize = True
        Me.CheckBoxIonPumpConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIonPumpConnected.Location = New System.Drawing.Point(876, 115)
        Me.CheckBoxIonPumpConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxIonPumpConnected.Name = "CheckBoxIonPumpConnected"
        Me.CheckBoxIonPumpConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxIonPumpConnected.TabIndex = 267
        Me.CheckBoxIonPumpConnected.UseVisualStyleBackColor = True
        '
        'CheckBoxHVLambdaConnected
        '
        Me.CheckBoxHVLambdaConnected.AutoSize = True
        Me.CheckBoxHVLambdaConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHVLambdaConnected.Location = New System.Drawing.Point(876, 99)
        Me.CheckBoxHVLambdaConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVLambdaConnected.Name = "CheckBoxHVLambdaConnected"
        Me.CheckBoxHVLambdaConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVLambdaConnected.TabIndex = 266
        Me.CheckBoxHVLambdaConnected.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(782, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 281
        Me.Label4.Text = "Pulse Sync"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(782, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 280
        Me.Label5.Text = "I Pulse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(782, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Gun Dvr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(782, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 278
        Me.Label7.Text = "Htr/Mag"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(782, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 277
        Me.Label8.Text = "Cooling"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(782, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "AFC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(782, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 275
        Me.Label10.Text = "Ion Pump"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(782, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 274
        Me.Label11.Text = "HV Lambda"
        '
        'CheckBoxOperatePulseSync
        '
        Me.CheckBoxOperatePulseSync.AutoSize = True
        Me.CheckBoxOperatePulseSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperatePulseSync.Location = New System.Drawing.Point(918, 211)
        Me.CheckBoxOperatePulseSync.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperatePulseSync.Name = "CheckBoxOperatePulseSync"
        Me.CheckBoxOperatePulseSync.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperatePulseSync.TabIndex = 289
        Me.CheckBoxOperatePulseSync.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateMagnetronCurrentMon
        '
        Me.CheckBoxOperateMagnetronCurrentMon.AutoSize = True
        Me.CheckBoxOperateMagnetronCurrentMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateMagnetronCurrentMon.Location = New System.Drawing.Point(918, 195)
        Me.CheckBoxOperateMagnetronCurrentMon.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateMagnetronCurrentMon.Name = "CheckBoxOperateMagnetronCurrentMon"
        Me.CheckBoxOperateMagnetronCurrentMon.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateMagnetronCurrentMon.TabIndex = 288
        Me.CheckBoxOperateMagnetronCurrentMon.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateGunDriver
        '
        Me.CheckBoxOperateGunDriver.AutoSize = True
        Me.CheckBoxOperateGunDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateGunDriver.Location = New System.Drawing.Point(918, 179)
        Me.CheckBoxOperateGunDriver.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateGunDriver.Name = "CheckBoxOperateGunDriver"
        Me.CheckBoxOperateGunDriver.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateGunDriver.TabIndex = 287
        Me.CheckBoxOperateGunDriver.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateHtrMag
        '
        Me.CheckBoxOperateHtrMag.AutoSize = True
        Me.CheckBoxOperateHtrMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateHtrMag.Location = New System.Drawing.Point(918, 163)
        Me.CheckBoxOperateHtrMag.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateHtrMag.Name = "CheckBoxOperateHtrMag"
        Me.CheckBoxOperateHtrMag.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateHtrMag.TabIndex = 286
        Me.CheckBoxOperateHtrMag.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateCooling
        '
        Me.CheckBoxOperateCooling.AutoSize = True
        Me.CheckBoxOperateCooling.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateCooling.Location = New System.Drawing.Point(918, 147)
        Me.CheckBoxOperateCooling.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateCooling.Name = "CheckBoxOperateCooling"
        Me.CheckBoxOperateCooling.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateCooling.TabIndex = 285
        Me.CheckBoxOperateCooling.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateAFC
        '
        Me.CheckBoxOperateAFC.AutoSize = True
        Me.CheckBoxOperateAFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateAFC.Location = New System.Drawing.Point(918, 131)
        Me.CheckBoxOperateAFC.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateAFC.Name = "CheckBoxOperateAFC"
        Me.CheckBoxOperateAFC.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateAFC.TabIndex = 284
        Me.CheckBoxOperateAFC.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateIonPump
        '
        Me.CheckBoxOperateIonPump.AutoSize = True
        Me.CheckBoxOperateIonPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateIonPump.Location = New System.Drawing.Point(918, 115)
        Me.CheckBoxOperateIonPump.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateIonPump.Name = "CheckBoxOperateIonPump"
        Me.CheckBoxOperateIonPump.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateIonPump.TabIndex = 283
        Me.CheckBoxOperateIonPump.UseVisualStyleBackColor = True
        '
        'CheckBoxOperateHVLambda
        '
        Me.CheckBoxOperateHVLambda.AutoSize = True
        Me.CheckBoxOperateHVLambda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateHVLambda.Location = New System.Drawing.Point(918, 99)
        Me.CheckBoxOperateHVLambda.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateHVLambda.Name = "CheckBoxOperateHVLambda"
        Me.CheckBoxOperateHVLambda.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateHVLambda.TabIndex = 282
        Me.CheckBoxOperateHVLambda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(873, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 290
        Me.Label2.Text = "Com"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(915, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 291
        Me.Label12.Text = "FLT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(782, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 292
        Me.Label13.Text = "Ethernet"
        '
        'CheckBoxOperateEthernet
        '
        Me.CheckBoxOperateEthernet.AutoSize = True
        Me.CheckBoxOperateEthernet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateEthernet.Location = New System.Drawing.Point(918, 227)
        Me.CheckBoxOperateEthernet.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateEthernet.Name = "CheckBoxOperateEthernet"
        Me.CheckBoxOperateEthernet.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateEthernet.TabIndex = 293
        Me.CheckBoxOperateEthernet.UseVisualStyleBackColor = True
        '
        'LabelECBState
        '
        Me.LabelECBState.AutoSize = True
        Me.LabelECBState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBState.Location = New System.Drawing.Point(782, 264)
        Me.LabelECBState.Name = "LabelECBState"
        Me.LabelECBState.Size = New System.Drawing.Size(69, 16)
        Me.LabelECBState.TabIndex = 294
        Me.LabelECBState.Text = "ECB State"
        '
        'ButtonToggleResetDebug
        '
        Me.ButtonToggleResetDebug.Location = New System.Drawing.Point(779, 549)
        Me.ButtonToggleResetDebug.Name = "ButtonToggleResetDebug"
        Me.ButtonToggleResetDebug.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleResetDebug.TabIndex = 295
        Me.ButtonToggleResetDebug.Text = "Toggle Reset Debug"
        Me.ButtonToggleResetDebug.UseVisualStyleBackColor = True
        '
        'CheckBoxSyncBitF
        '
        Me.CheckBoxSyncBitF.AutoSize = True
        Me.CheckBoxSyncBitF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBitF.Location = New System.Drawing.Point(952, 551)
        Me.CheckBoxSyncBitF.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBitF.Name = "CheckBoxSyncBitF"
        Me.CheckBoxSyncBitF.Size = New System.Drawing.Size(121, 20)
        Me.CheckBoxSyncBitF.TabIndex = 296
        Me.CheckBoxSyncBitF.Text = "Clear Debug Bit"
        Me.CheckBoxSyncBitF.UseVisualStyleBackColor = True
        '
        'LabelValue11
        '
        Me.LabelValue11.AutoSize = True
        Me.LabelValue11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue11.Location = New System.Drawing.Point(469, 532)
        Me.LabelValue11.Name = "LabelValue11"
        Me.LabelValue11.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue11.TabIndex = 277
        Me.LabelValue11.Text = "Label Value 11"
        '
        'LabelValue12
        '
        Me.LabelValue12.AutoSize = True
        Me.LabelValue12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue12.Location = New System.Drawing.Point(469, 548)
        Me.LabelValue12.Name = "LabelValue12"
        Me.LabelValue12.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue12.TabIndex = 297
        Me.LabelValue12.Text = "Label Value 12"
        '
        'LabelValue13
        '
        Me.LabelValue13.AutoSize = True
        Me.LabelValue13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue13.Location = New System.Drawing.Point(469, 564)
        Me.LabelValue13.Name = "LabelValue13"
        Me.LabelValue13.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue13.TabIndex = 298
        Me.LabelValue13.Text = "Label Value 13"
        '
        'LabelValue14
        '
        Me.LabelValue14.AutoSize = True
        Me.LabelValue14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue14.Location = New System.Drawing.Point(469, 580)
        Me.LabelValue14.Name = "LabelValue14"
        Me.LabelValue14.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue14.TabIndex = 299
        Me.LabelValue14.Text = "Label Value 14"
        '
        'LabelValue15
        '
        Me.LabelValue15.AutoSize = True
        Me.LabelValue15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue15.Location = New System.Drawing.Point(469, 596)
        Me.LabelValue15.Name = "LabelValue15"
        Me.LabelValue15.Size = New System.Drawing.Size(97, 16)
        Me.LabelValue15.TabIndex = 300
        Me.LabelValue15.Text = "Label Value 15"
        '
        'ButtonUpdateInput3
        '
        Me.ButtonUpdateInput3.Location = New System.Drawing.Point(659, 332)
        Me.ButtonUpdateInput3.Name = "ButtonUpdateInput3"
        Me.ButtonUpdateInput3.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput3.TabIndex = 302
        Me.ButtonUpdateInput3.Text = "Update Input 3"
        Me.ButtonUpdateInput3.UseVisualStyleBackColor = True
        '
        'TextBoxInput3
        '
        Me.TextBoxInput3.Location = New System.Drawing.Point(553, 334)
        Me.TextBoxInput3.MaxLength = 5
        Me.TextBoxInput3.Name = "TextBoxInput3"
        Me.TextBoxInput3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput3.TabIndex = 301
        '
        'ButtonStartLog
        '
        Me.ButtonStartLog.Location = New System.Drawing.Point(973, 206)
        Me.ButtonStartLog.Name = "ButtonStartLog"
        Me.ButtonStartLog.Size = New System.Drawing.Size(100, 23)
        Me.ButtonStartLog.TabIndex = 303
        Me.ButtonStartLog.Text = "Start Logging"
        Me.ButtonStartLog.UseVisualStyleBackColor = True
        '
        'ButtonStopLog
        '
        Me.ButtonStopLog.Location = New System.Drawing.Point(973, 236)
        Me.ButtonStopLog.Name = "ButtonStopLog"
        Me.ButtonStopLog.Size = New System.Drawing.Size(100, 23)
        Me.ButtonStopLog.TabIndex = 304
        Me.ButtonStopLog.Text = "Stop Logging"
        Me.ButtonStopLog.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 700)
        Me.Controls.Add(Me.ButtonStopLog)
        Me.Controls.Add(Me.ButtonStartLog)
        Me.Controls.Add(Me.CheckBoxSyncBitF)
        Me.Controls.Add(Me.ButtonToggleResetDebug)
        Me.Controls.Add(Me.LabelECBState)
        Me.Controls.Add(Me.CheckBoxOperateEthernet)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxOperatePulseSync)
        Me.Controls.Add(Me.CheckBoxOperateMagnetronCurrentMon)
        Me.Controls.Add(Me.CheckBoxOperateGunDriver)
        Me.Controls.Add(Me.CheckBoxOperateHtrMag)
        Me.Controls.Add(Me.CheckBoxOperateCooling)
        Me.Controls.Add(Me.CheckBoxOperateAFC)
        Me.Controls.Add(Me.CheckBoxOperateIonPump)
        Me.Controls.Add(Me.CheckBoxOperateHVLambda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CheckBoxPulseSyncConnected)
        Me.Controls.Add(Me.CheckBoxSyncBit8)
        Me.Controls.Add(Me.CheckBoxPulseCurrentMonitorConnected)
        Me.Controls.Add(Me.CheckBoxGunDriverConnected)
        Me.Controls.Add(Me.CheckBoxSyncBit7)
        Me.Controls.Add(Me.CheckBoxHtrMagConnected)
        Me.Controls.Add(Me.CheckBoxCoolingConnected)
        Me.Controls.Add(Me.CheckBoxSyncBit6)
        Me.Controls.Add(Me.CheckBoxAFCConnected)
        Me.Controls.Add(Me.ButtonTogglePulseSyncXray)
        Me.Controls.Add(Me.CheckBoxIonPumpConnected)
        Me.Controls.Add(Me.CheckBoxSyncBit5)
        Me.Controls.Add(Me.CheckBoxHVLambdaConnected)
        Me.Controls.Add(Me.ButtonTogglePulseSyncHV)
        Me.Controls.Add(Me.CheckBoxSyncBit4)
        Me.Controls.Add(Me.ButtonToggleHighSpeedDataLogging)
        Me.Controls.Add(Me.CheckBoxSyncBit3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxSyncBit2)
        Me.Controls.Add(Me.ButtonToggleCoolantFault)
        Me.Controls.Add(Me.CheckBoxSyncBit1)
        Me.Controls.Add(Me.LabelBoardStatus)
        Me.Controls.Add(Me.CheckBoxSyncBit0)
        Me.Controls.Add(Me.ButtonToggleReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "5555555555"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorStatusDataB As System.Windows.Forms.Label
    Friend WithEvents LabelErrorStatusDataA As System.Windows.Forms.Label
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
    Friend WithEvents CheckBoxFaultBitF As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitD As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitA As System.Windows.Forms.CheckBox
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
    Friend WithEvents CheckBoxStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelFirmwareVerssion As System.Windows.Forms.Label
    Friend WithEvents LabelAgileInfo As System.Windows.Forms.Label
    Friend WithEvents ButtonToggleReset As System.Windows.Forms.Button
    Friend WithEvents TextBoxInput2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInput1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdateInput1 As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdateInput2 As System.Windows.Forms.Button
    Friend WithEvents LabelValue1 As System.Windows.Forms.Label
    Friend WithEvents LabelValue2 As System.Windows.Forms.Label
    Friend WithEvents LabelValue3 As System.Windows.Forms.Label
    Friend WithEvents LabelValue4 As System.Windows.Forms.Label
    Friend WithEvents LabelValue5 As System.Windows.Forms.Label
    Friend WithEvents LabelValue6 As System.Windows.Forms.Label
    Friend WithEvents LabelValue7 As System.Windows.Forms.Label
    Friend WithEvents LabelValue8 As System.Windows.Forms.Label
    Friend WithEvents LabelValue9 As System.Windows.Forms.Label
    Friend WithEvents LabelValue10 As System.Windows.Forms.Label
    Friend WithEvents LabelBoardStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonToggleCoolantFault As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonToggleHighSpeedDataLogging As System.Windows.Forms.Button
    Friend WithEvents ButtonTogglePulseSyncHV As System.Windows.Forms.Button
    Friend WithEvents ButtonTogglePulseSyncXray As System.Windows.Forms.Button
    Friend WithEvents ButtonBoardCommand As System.Windows.Forms.Button
    Friend WithEvents LabelValueDebugF As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugE As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugD As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugC As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugB As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugA As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug9 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug8 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug7 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug6 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug5 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug4 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug3 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug2 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug1 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug0 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSyncBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPulseSyncConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPulseCurrentMonitorConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxGunDriverConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHtrMagConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCoolingConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAFCConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIonPumpConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVLambdaConnected As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOperatePulseSync As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateMagnetronCurrentMon As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateGunDriver As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateHtrMag As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateCooling As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateAFC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateIonPump As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateHVLambda As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOperateEthernet As System.Windows.Forms.CheckBox
    Friend WithEvents LabelECBState As System.Windows.Forms.Label
    Friend WithEvents TextBoxEEpromOffSet As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEEpromScale As System.Windows.Forms.TextBox
    Friend WithEvents ButtonWriteEEprom As System.Windows.Forms.Button
    Friend WithEvents ButtonReadEEprom As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEEpromRegister As System.Windows.Forms.ComboBox
    Friend WithEvents LabelEEpromIndex As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonResetSlave As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleResetDebug As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBitF As System.Windows.Forms.CheckBox
    Friend WithEvents LabelRCON As System.Windows.Forms.Label
    Friend WithEvents CheckBoxResetBOR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetIdle As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetSleep As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetWDT As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetSoftware As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetExt As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetIllegal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetTrap As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetPOR As System.Windows.Forms.CheckBox
    Friend WithEvents LabelValue11 As System.Windows.Forms.Label
    Friend WithEvents LabelValue12 As System.Windows.Forms.Label
    Friend WithEvents LabelValue13 As System.Windows.Forms.Label
    Friend WithEvents LabelValue14 As System.Windows.Forms.Label
    Friend WithEvents LabelValue15 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdateInput3 As System.Windows.Forms.Button
    Friend WithEvents TextBoxInput3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonStartLog As System.Windows.Forms.Button
    Friend WithEvents ButtonStopLog As System.Windows.Forms.Button
End Class
