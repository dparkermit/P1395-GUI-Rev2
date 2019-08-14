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
        Me.LabelECBTime = New System.Windows.Forms.Label()
        Me.LabelComputerTime = New System.Windows.Forms.Label()
        Me.LabelECBState = New System.Windows.Forms.Label()
        Me.LabelGuiVersion = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.SerialPortETM = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerWatchdog = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ComboBoxComPorts = New System.Windows.Forms.ComboBox()
        Me.LabelWatchDogResponse = New System.Windows.Forms.Label()
        Me.TextBoxRev = New System.Windows.Forms.TextBox()
        Me.TextBoxSN = New System.Windows.Forms.TextBox()
        Me.TextBoxIP3 = New System.Windows.Forms.TextBox()
        Me.TextBoxIP2 = New System.Windows.Forms.TextBox()
        Me.TextBoxHNubmber = New System.Windows.Forms.TextBox()
        Me.TextBoxIP1 = New System.Windows.Forms.TextBox()
        Me.TextBoxIP0 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelCommandCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCommandLengthError = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSetIPAddres = New System.Windows.Forms.Button()
        Me.ButtonSetRemoteIP = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BntECBEEPromConfigure = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnUnused0DoseAll = New System.Windows.Forms.Button()
        Me.BtnUnused1DoseAll = New System.Windows.Forms.Button()
        Me.BtnUnused2DoseAll = New System.Windows.Forms.Button()
        Me.BtnUnused3DoseAll = New System.Windows.Forms.Button()
        Me.BtnGunHeater = New System.Windows.Forms.Button()
        Me.BtnAFCManualPostion = New System.Windows.Forms.Button()
        Me.BtnGunBias = New System.Windows.Forms.Button()
        Me.BtnAFCAuxControl = New System.Windows.Forms.Button()
        Me.BtnXrayRunTime = New System.Windows.Forms.Button()
        Me.BtnSampleTriggerStop = New System.Windows.Forms.Button()
        Me.BtnSampleTriggerStart = New System.Windows.Forms.Button()
        Me.BtnPFNTriggerDelay = New System.Windows.Forms.Button()
        Me.BtnHVPSTrigStop = New System.Windows.Forms.Button()
        Me.BtnHVPSTrigStart = New System.Windows.Forms.Button()
        Me.BtnMagnetronHeater = New System.Windows.Forms.Button()
        Me.LblDose3 = New System.Windows.Forms.Label()
        Me.LblDose2 = New System.Windows.Forms.Label()
        Me.LblDose1 = New System.Windows.Forms.Label()
        Me.LblDose0 = New System.Windows.Forms.Label()
        Me.BtnUnused0Dose3 = New System.Windows.Forms.Button()
        Me.BtnUnused1Dose3 = New System.Windows.Forms.Button()
        Me.BtnUnused2Dose3 = New System.Windows.Forms.Button()
        Me.BtnPRFDose3 = New System.Windows.Forms.Button()
        Me.BtnAFCHomeDose3 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMaxDose3 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMaxDose3 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMinDose3 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMinDose3 = New System.Windows.Forms.Button()
        Me.BtnAFCTriggerDelayDose3 = New System.Windows.Forms.Button()
        Me.BtnSpareTriggerDelayDose3 = New System.Windows.Forms.Button()
        Me.BtnGunCathodeDose3 = New System.Windows.Forms.Button()
        Me.BtnPulseTopDose3 = New System.Windows.Forms.Button()
        Me.BtnMagnetCurrentDose3 = New System.Windows.Forms.Button()
        Me.BtnHVPSDose3 = New System.Windows.Forms.Button()
        Me.BtnUnused0Dose2 = New System.Windows.Forms.Button()
        Me.BtnUnused1Dose2 = New System.Windows.Forms.Button()
        Me.BtnUnused2Dose2 = New System.Windows.Forms.Button()
        Me.BtnPRFDose2 = New System.Windows.Forms.Button()
        Me.BtnAFCHomeDose2 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMaxDose2 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMaxDose2 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMinDose2 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMinDose2 = New System.Windows.Forms.Button()
        Me.BtnAFCTriggerDelayDose2 = New System.Windows.Forms.Button()
        Me.BtnSpareTriggerDelayDose2 = New System.Windows.Forms.Button()
        Me.BtnGunCathodeDose2 = New System.Windows.Forms.Button()
        Me.BtnPulseTopDose2 = New System.Windows.Forms.Button()
        Me.BtnMagnetCurrentDose2 = New System.Windows.Forms.Button()
        Me.BtnHVPSDose2 = New System.Windows.Forms.Button()
        Me.BtnUnused0Dose1 = New System.Windows.Forms.Button()
        Me.BtnUnused1Dose1 = New System.Windows.Forms.Button()
        Me.BtnUnused2Dose1 = New System.Windows.Forms.Button()
        Me.BtnPRFDose1 = New System.Windows.Forms.Button()
        Me.BtnAFCHomeDose1 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMaxDose1 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMaxDose1 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMinDose1 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMinDose1 = New System.Windows.Forms.Button()
        Me.BtnAFCTriggerDelayDose1 = New System.Windows.Forms.Button()
        Me.BtnSpareTriggerDelayDose1 = New System.Windows.Forms.Button()
        Me.BtnGunCathodeDose1 = New System.Windows.Forms.Button()
        Me.BtnPulseTopDose1 = New System.Windows.Forms.Button()
        Me.BtnMagnetCurrentDose1 = New System.Windows.Forms.Button()
        Me.BtnHVPSDose1 = New System.Windows.Forms.Button()
        Me.BtnUnused0Dose0 = New System.Windows.Forms.Button()
        Me.BtnUnused1Dose0 = New System.Windows.Forms.Button()
        Me.BtnUnused2Dose0 = New System.Windows.Forms.Button()
        Me.BtnPRFDose0 = New System.Windows.Forms.Button()
        Me.BtnAFCHomeDose0 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMaxDose0 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMaxDose0 = New System.Windows.Forms.Button()
        Me.BtnGrideStopMinDose0 = New System.Windows.Forms.Button()
        Me.BtnGrideStartMinDose0 = New System.Windows.Forms.Button()
        Me.BtnAFCTriggerDelayDose0 = New System.Windows.Forms.Button()
        Me.BtnSpareTriggerDelayDose0 = New System.Windows.Forms.Button()
        Me.BtnGunCathodeDose0 = New System.Windows.Forms.Button()
        Me.BtnPulseTopDose0 = New System.Windows.Forms.Button()
        Me.BtnMagnetCurrentDose0 = New System.Windows.Forms.Button()
        Me.BtnHVPSDose0 = New System.Windows.Forms.Button()
        Me.TabPage2Slave = New System.Windows.Forms.TabPage()
        Me.BtnMCUReset = New System.Windows.Forms.Button()
        Me.CoBoxSelectedCanBoard = New System.Windows.Forms.ComboBox()
        Me.BtnSetCalPair = New System.Windows.Forms.Button()
        Me.BtnEEPromDebug = New System.Windows.Forms.Button()
        Me.LblDebug7 = New System.Windows.Forms.Label()
        Me.LblDebug6 = New System.Windows.Forms.Label()
        Me.LblDebug5 = New System.Windows.Forms.Label()
        Me.LblDebug4 = New System.Windows.Forms.Label()
        Me.LblDebug3 = New System.Windows.Forms.Label()
        Me.LblDebug2 = New System.Windows.Forms.Label()
        Me.LblDebug1 = New System.Windows.Forms.Label()
        Me.LblDebug0 = New System.Windows.Forms.Label()
        Me.BtnRamDebug = New System.Windows.Forms.Button()
        Me.BtnSlaveDefaultEEProm = New System.Windows.Forms.Button()
        Me.BtnSetRevSN = New System.Windows.Forms.Button()
        Me.LblDebugSystem7 = New System.Windows.Forms.Label()
        Me.LblDebugSystem6 = New System.Windows.Forms.Label()
        Me.LblDebugSystem5 = New System.Windows.Forms.Label()
        Me.LblDebugSystem4 = New System.Windows.Forms.Label()
        Me.LblDebugSystem3 = New System.Windows.Forms.Label()
        Me.LblDebugSystem2 = New System.Windows.Forms.Label()
        Me.LblDebugSystem1 = New System.Windows.Forms.Label()
        Me.LblDebugSystem0 = New System.Windows.Forms.Label()
        Me.LblDebugTBD15 = New System.Windows.Forms.Label()
        Me.LblDebugTBD14 = New System.Windows.Forms.Label()
        Me.LblDebugTBD13 = New System.Windows.Forms.Label()
        Me.LblDebugTBD12 = New System.Windows.Forms.Label()
        Me.LblDebugTBD11 = New System.Windows.Forms.Label()
        Me.LblDebugTBD10 = New System.Windows.Forms.Label()
        Me.LblDebugTBD9 = New System.Windows.Forms.Label()
        Me.LblDebugTBD8 = New System.Windows.Forms.Label()
        Me.LblDebugTBD7 = New System.Windows.Forms.Label()
        Me.LblDebugTBD6 = New System.Windows.Forms.Label()
        Me.LblDebugTBD5 = New System.Windows.Forms.Label()
        Me.LblDebugTBD4 = New System.Windows.Forms.Label()
        Me.LblDebugTBD3 = New System.Windows.Forms.Label()
        Me.LblDebugTBD2 = New System.Windows.Forms.Label()
        Me.LblDebugTBD1 = New System.Windows.Forms.Label()
        Me.LblDebugTBD0 = New System.Windows.Forms.Label()
        Me.LblDebugCal3ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal3ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal3IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal3IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal2ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal2ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal2IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal2IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal1ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal1ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal1IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal1IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal0ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal0ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal0IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal0IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal7ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal7ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal7IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal7IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal6ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal6ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal6IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal6IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal5ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal5ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal5IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal5IntGain = New System.Windows.Forms.Label()
        Me.LblDebugCal4ExtOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal4ExtGain = New System.Windows.Forms.Label()
        Me.LblDebugCal4IntOffset = New System.Windows.Forms.Label()
        Me.LblDebugCal4IntGain = New System.Windows.Forms.Label()
        Me.LblDebugEEprom15 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom14 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom13 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom12 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom11 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom10 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom9 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom8 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom7 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom6 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom5 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom4 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom3 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom2 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom1 = New System.Windows.Forms.Label()
        Me.LblDebugEEprom0 = New System.Windows.Forms.Label()
        Me.LblDebugCanF = New System.Windows.Forms.Label()
        Me.LblDebugCanE = New System.Windows.Forms.Label()
        Me.LblDebugCanD = New System.Windows.Forms.Label()
        Me.LblDebugCanC = New System.Windows.Forms.Label()
        Me.LblDebugCanB = New System.Windows.Forms.Label()
        Me.LblDebugCanA = New System.Windows.Forms.Label()
        Me.LblDebugCan9 = New System.Windows.Forms.Label()
        Me.LblDebugCan8 = New System.Windows.Forms.Label()
        Me.LblDebugCan7 = New System.Windows.Forms.Label()
        Me.LblDebugCan6 = New System.Windows.Forms.Label()
        Me.LblDebugCan5 = New System.Windows.Forms.Label()
        Me.LblDebugCan4 = New System.Windows.Forms.Label()
        Me.LblDebugCan3 = New System.Windows.Forms.Label()
        Me.LblDebugCan2 = New System.Windows.Forms.Label()
        Me.LblDebugCan1 = New System.Windows.Forms.Label()
        Me.LblDebugCan0 = New System.Windows.Forms.Label()
        Me.LblDebugRegF = New System.Windows.Forms.Label()
        Me.LblDebugRegE = New System.Windows.Forms.Label()
        Me.LblDebugRegD = New System.Windows.Forms.Label()
        Me.LblDebugRegC = New System.Windows.Forms.Label()
        Me.LblDebugRegB = New System.Windows.Forms.Label()
        Me.LblDebugRegA = New System.Windows.Forms.Label()
        Me.LblDebugReg9 = New System.Windows.Forms.Label()
        Me.LblDebugReg8 = New System.Windows.Forms.Label()
        Me.LblDebugReg7 = New System.Windows.Forms.Label()
        Me.LblDebugReg6 = New System.Windows.Forms.Label()
        Me.LblDebugReg5 = New System.Windows.Forms.Label()
        Me.LblDebugReg4 = New System.Windows.Forms.Label()
        Me.LblDebugReg3 = New System.Windows.Forms.Label()
        Me.LblDebugReg2 = New System.Windows.Forms.Label()
        Me.LblDebugReg1 = New System.Windows.Forms.Label()
        Me.LblDebugReg0 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue23 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue15 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue16 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue17 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue18 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue19 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue20 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue21 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue22 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue0 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue1 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue2 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue3 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue4 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue5 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue6 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue7 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue8 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue9 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue10 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue11 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue12 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue13 = New System.Windows.Forms.Label()
        Me.LblSlaveLogValue14 = New System.Windows.Forms.Label()
        Me.LblSlaveLog23 = New System.Windows.Forms.Label()
        Me.LblSlaveLog15 = New System.Windows.Forms.Label()
        Me.LblSlaveLog16 = New System.Windows.Forms.Label()
        Me.LblSlaveLog17 = New System.Windows.Forms.Label()
        Me.LblSlaveLog18 = New System.Windows.Forms.Label()
        Me.LblSlaveLog19 = New System.Windows.Forms.Label()
        Me.LblSlaveLog20 = New System.Windows.Forms.Label()
        Me.LblSlaveLog21 = New System.Windows.Forms.Label()
        Me.LblSlaveLog22 = New System.Windows.Forms.Label()
        Me.CbxSlaveStatusNotLoggedF = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLoggedE = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLoggedD = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLoggedC = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLoggedB = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLoggedA = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged9 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged8 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged0 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged7 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged6 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged5 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged4 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged3 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged2 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotLogged1 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedF = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedE = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedD = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedC = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedB = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLoggedA = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged9 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged8 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged0 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged7 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged6 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged5 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged4 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged3 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged2 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusLogged1 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultF = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultE = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultD = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultC = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultB = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFaultA = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault9 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault8 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault0 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault7 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault6 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault5 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault4 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault3 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault2 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusFault1 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice7 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice6 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice5 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice4 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice3 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice2 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice1 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusNotice0 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl0 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl7 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl6 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl5 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl4 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl3 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl2 = New System.Windows.Forms.CheckBox()
        Me.CbxSlaveStatusCntrl1 = New System.Windows.Forms.CheckBox()
        Me.LblSlaveLog0 = New System.Windows.Forms.Label()
        Me.LblSlaveLog1 = New System.Windows.Forms.Label()
        Me.LblSlaveLog2 = New System.Windows.Forms.Label()
        Me.LblSlaveLog3 = New System.Windows.Forms.Label()
        Me.LblSlaveLog4 = New System.Windows.Forms.Label()
        Me.LblSlaveLog5 = New System.Windows.Forms.Label()
        Me.LblSlaveLog6 = New System.Windows.Forms.Label()
        Me.LblSlaveLog7 = New System.Windows.Forms.Label()
        Me.LabelFirmwareVerssion = New System.Windows.Forms.Label()
        Me.LblSlaveLog8 = New System.Windows.Forms.Label()
        Me.LabelAgileInfo = New System.Windows.Forms.Label()
        Me.LblSlaveLog9 = New System.Windows.Forms.Label()
        Me.LabelBoardStatus = New System.Windows.Forms.Label()
        Me.LblSlaveLog10 = New System.Windows.Forms.Label()
        Me.LblSlaveLog11 = New System.Windows.Forms.Label()
        Me.LblSlaveLog12 = New System.Windows.Forms.Label()
        Me.LblSlaveLog13 = New System.Windows.Forms.Label()
        Me.LblSlaveLog14 = New System.Windows.Forms.Label()
        Me.BtnClearDebug = New System.Windows.Forms.Button()
        Me.BtnAFCAuto = New System.Windows.Forms.Button()
        Me.TabPage1ECB = New System.Windows.Forms.TabPage()
        Me.BtnSystemSerialNumber = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnAFCManual = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.BtnZeroOnTimeCounter = New System.Windows.Forms.Button()
        Me.BtnZeroArcPulseCounter = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BtnEEpromWriteStatusClear = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabPage4Dose = New System.Windows.Forms.TabControl()
        Me.CbxConnect0 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect1 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect3 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect2 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect7 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect6 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect5 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect4 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect9 = New System.Windows.Forms.CheckBox()
        Me.CbxConnect8 = New System.Windows.Forms.CheckBox()
        Me.CbxReady9 = New System.Windows.Forms.CheckBox()
        Me.CbxReady8 = New System.Windows.Forms.CheckBox()
        Me.CbxReady7 = New System.Windows.Forms.CheckBox()
        Me.CbxReady6 = New System.Windows.Forms.CheckBox()
        Me.CbxReady5 = New System.Windows.Forms.CheckBox()
        Me.CbxReady4 = New System.Windows.Forms.CheckBox()
        Me.CbxReady3 = New System.Windows.Forms.CheckBox()
        Me.CbxReady2 = New System.Windows.Forms.CheckBox()
        Me.CbxReady1 = New System.Windows.Forms.CheckBox()
        Me.CbxReady0 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CbxConnect10 = New System.Windows.Forms.CheckBox()
        Me.CbxReady10 = New System.Windows.Forms.CheckBox()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2Slave.SuspendLayout()
        Me.TabPage1ECB.SuspendLayout()
        Me.TabPage4Dose.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'LabelECBTime
        '
        Me.LabelECBTime.AutoSize = True
        Me.LabelECBTime.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelECBTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBTime.Location = New System.Drawing.Point(12, 402)
        Me.LabelECBTime.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelECBTime.Name = "LabelECBTime"
        Me.LabelECBTime.Size = New System.Drawing.Size(69, 16)
        Me.LabelECBTime.TabIndex = 364
        Me.LabelECBTime.Text = "ECB Time"
        '
        'LabelComputerTime
        '
        Me.LabelComputerTime.AutoSize = True
        Me.LabelComputerTime.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelComputerTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComputerTime.Location = New System.Drawing.Point(12, 431)
        Me.LabelComputerTime.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelComputerTime.Name = "LabelComputerTime"
        Me.LabelComputerTime.Size = New System.Drawing.Size(100, 16)
        Me.LabelComputerTime.TabIndex = 363
        Me.LabelComputerTime.Text = "Computer Time"
        '
        'LabelECBState
        '
        Me.LabelECBState.AutoSize = True
        Me.LabelECBState.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelECBState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBState.Location = New System.Drawing.Point(12, 9)
        Me.LabelECBState.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelECBState.Name = "LabelECBState"
        Me.LabelECBState.Size = New System.Drawing.Size(69, 16)
        Me.LabelECBState.TabIndex = 359
        Me.LabelECBState.Text = "ECB State"
        '
        'LabelGuiVersion
        '
        Me.LabelGuiVersion.AutoSize = True
        Me.LabelGuiVersion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelGuiVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuiVersion.Location = New System.Drawing.Point(12, 376)
        Me.LabelGuiVersion.Name = "LabelGuiVersion"
        Me.LabelGuiVersion.Size = New System.Drawing.Size(78, 16)
        Me.LabelGuiVersion.TabIndex = 390
        Me.LabelGuiVersion.Text = "GUI version"
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Lavender
        Me.ButtonReset.FlatAppearance.BorderSize = 0
        Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReset.Location = New System.Drawing.Point(170, 6)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(100, 23)
        Me.ButtonReset.TabIndex = 422
        Me.ButtonReset.Text = "Reset Fault"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'SerialPortETM
        '
        Me.SerialPortETM.BaudRate = 113000
        '
        'TimerWatchdog
        '
        Me.TimerWatchdog.Enabled = True
        Me.TimerWatchdog.Interval = 20
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ComboBoxComPorts)
        Me.TabPage5.Controls.Add(Me.LabelWatchDogResponse)
        Me.TabPage5.Controls.Add(Me.TextBoxRev)
        Me.TabPage5.Controls.Add(Me.TextBoxSN)
        Me.TabPage5.Controls.Add(Me.TextBoxIP3)
        Me.TabPage5.Controls.Add(Me.TextBoxIP2)
        Me.TabPage5.Controls.Add(Me.TextBoxHNubmber)
        Me.TabPage5.Controls.Add(Me.TextBoxIP1)
        Me.TabPage5.Controls.Add(Me.TextBoxIP0)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.LabelCommandCount)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.LabelCommandLengthError)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.ButtonSetIPAddres)
        Me.TabPage5.Controls.Add(Me.ButtonSetRemoteIP)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1415, 935)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ComboBoxComPorts
        '
        Me.ComboBoxComPorts.FormattingEnabled = True
        Me.ComboBoxComPorts.Location = New System.Drawing.Point(274, 345)
        Me.ComboBoxComPorts.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxComPorts.Name = "ComboBoxComPorts"
        Me.ComboBoxComPorts.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxComPorts.TabIndex = 446
        '
        'LabelWatchDogResponse
        '
        Me.LabelWatchDogResponse.AutoSize = True
        Me.LabelWatchDogResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWatchDogResponse.Location = New System.Drawing.Point(378, 347)
        Me.LabelWatchDogResponse.Name = "LabelWatchDogResponse"
        Me.LabelWatchDogResponse.Size = New System.Drawing.Size(37, 16)
        Me.LabelWatchDogResponse.TabIndex = 447
        Me.LabelWatchDogResponse.Text = "Error"
        '
        'TextBoxRev
        '
        Me.TextBoxRev.Location = New System.Drawing.Point(177, 428)
        Me.TextBoxRev.MaxLength = 7
        Me.TextBoxRev.Name = "TextBoxRev"
        Me.TextBoxRev.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxRev.TabIndex = 449
        '
        'TextBoxSN
        '
        Me.TextBoxSN.Location = New System.Drawing.Point(177, 460)
        Me.TextBoxSN.MaxLength = 7
        Me.TextBoxSN.Name = "TextBoxSN"
        Me.TextBoxSN.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxSN.TabIndex = 450
        '
        'TextBoxIP3
        '
        Me.TextBoxIP3.Location = New System.Drawing.Point(211, 174)
        Me.TextBoxIP3.MaxLength = 7
        Me.TextBoxIP3.Name = "TextBoxIP3"
        Me.TextBoxIP3.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxIP3.TabIndex = 440
        '
        'TextBoxIP2
        '
        Me.TextBoxIP2.Location = New System.Drawing.Point(152, 174)
        Me.TextBoxIP2.MaxLength = 7
        Me.TextBoxIP2.Name = "TextBoxIP2"
        Me.TextBoxIP2.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxIP2.TabIndex = 439
        '
        'TextBoxHNubmber
        '
        Me.TextBoxHNubmber.Location = New System.Drawing.Point(177, 534)
        Me.TextBoxHNubmber.MaxLength = 7
        Me.TextBoxHNubmber.Name = "TextBoxHNubmber"
        Me.TextBoxHNubmber.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxHNubmber.TabIndex = 454
        '
        'TextBoxIP1
        '
        Me.TextBoxIP1.Location = New System.Drawing.Point(94, 174)
        Me.TextBoxIP1.MaxLength = 7
        Me.TextBoxIP1.Name = "TextBoxIP1"
        Me.TextBoxIP1.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxIP1.TabIndex = 438
        '
        'TextBoxIP0
        '
        Me.TextBoxIP0.Location = New System.Drawing.Point(35, 174)
        Me.TextBoxIP0.MaxLength = 7
        Me.TextBoxIP0.Name = "TextBoxIP0"
        Me.TextBoxIP0.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxIP0.TabIndex = 437
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 456
        Me.Button2.Text = "Set H Num"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelCommandCount
        '
        Me.LabelCommandCount.AutoSize = True
        Me.LabelCommandCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCommandCount.Location = New System.Drawing.Point(402, 195)
        Me.LabelCommandCount.Name = "LabelCommandCount"
        Me.LabelCommandCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCommandCount.TabIndex = 445
        Me.LabelCommandCount.Text = "LabelCan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 451
        Me.Label1.Text = "Rev"
        '
        'LabelCommandLengthError
        '
        Me.LabelCommandLengthError.AutoSize = True
        Me.LabelCommandLengthError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCommandLengthError.Location = New System.Drawing.Point(402, 211)
        Me.LabelCommandLengthError.Name = "LabelCommandLengthError"
        Me.LabelCommandLengthError.Size = New System.Drawing.Size(66, 16)
        Me.LabelCommandLengthError.TabIndex = 444
        Me.LabelCommandLengthError.Text = "LabelCan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(237, 538)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 455
        Me.Label14.Text = "H Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 452
        Me.Label3.Text = "SN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 453
        Me.Button1.Text = "Set Rev/SN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSetIPAddres
        '
        Me.ButtonSetIPAddres.Location = New System.Drawing.Point(284, 174)
        Me.ButtonSetIPAddres.Name = "ButtonSetIPAddres"
        Me.ButtonSetIPAddres.Size = New System.Drawing.Size(103, 23)
        Me.ButtonSetIPAddres.TabIndex = 435
        Me.ButtonSetIPAddres.Text = "Set IP"
        Me.ButtonSetIPAddres.UseVisualStyleBackColor = True
        '
        'ButtonSetRemoteIP
        '
        Me.ButtonSetRemoteIP.Location = New System.Drawing.Point(284, 203)
        Me.ButtonSetRemoteIP.Name = "ButtonSetRemoteIP"
        Me.ButtonSetRemoteIP.Size = New System.Drawing.Size(103, 23)
        Me.ButtonSetRemoteIP.TabIndex = 436
        Me.ButtonSetRemoteIP.Text = "Set Remote IP"
        Me.ButtonSetRemoteIP.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BntECBEEPromConfigure)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.BtnUnused0DoseAll)
        Me.TabPage4.Controls.Add(Me.BtnUnused1DoseAll)
        Me.TabPage4.Controls.Add(Me.BtnUnused2DoseAll)
        Me.TabPage4.Controls.Add(Me.BtnUnused3DoseAll)
        Me.TabPage4.Controls.Add(Me.BtnGunHeater)
        Me.TabPage4.Controls.Add(Me.BtnAFCManualPostion)
        Me.TabPage4.Controls.Add(Me.BtnGunBias)
        Me.TabPage4.Controls.Add(Me.BtnAFCAuxControl)
        Me.TabPage4.Controls.Add(Me.BtnXrayRunTime)
        Me.TabPage4.Controls.Add(Me.BtnSampleTriggerStop)
        Me.TabPage4.Controls.Add(Me.BtnSampleTriggerStart)
        Me.TabPage4.Controls.Add(Me.BtnPFNTriggerDelay)
        Me.TabPage4.Controls.Add(Me.BtnHVPSTrigStop)
        Me.TabPage4.Controls.Add(Me.BtnHVPSTrigStart)
        Me.TabPage4.Controls.Add(Me.BtnMagnetronHeater)
        Me.TabPage4.Controls.Add(Me.LblDose3)
        Me.TabPage4.Controls.Add(Me.LblDose2)
        Me.TabPage4.Controls.Add(Me.LblDose1)
        Me.TabPage4.Controls.Add(Me.LblDose0)
        Me.TabPage4.Controls.Add(Me.BtnUnused0Dose3)
        Me.TabPage4.Controls.Add(Me.BtnUnused1Dose3)
        Me.TabPage4.Controls.Add(Me.BtnUnused2Dose3)
        Me.TabPage4.Controls.Add(Me.BtnPRFDose3)
        Me.TabPage4.Controls.Add(Me.BtnAFCHomeDose3)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMaxDose3)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMaxDose3)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMinDose3)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMinDose3)
        Me.TabPage4.Controls.Add(Me.BtnAFCTriggerDelayDose3)
        Me.TabPage4.Controls.Add(Me.BtnSpareTriggerDelayDose3)
        Me.TabPage4.Controls.Add(Me.BtnGunCathodeDose3)
        Me.TabPage4.Controls.Add(Me.BtnPulseTopDose3)
        Me.TabPage4.Controls.Add(Me.BtnMagnetCurrentDose3)
        Me.TabPage4.Controls.Add(Me.BtnHVPSDose3)
        Me.TabPage4.Controls.Add(Me.BtnUnused0Dose2)
        Me.TabPage4.Controls.Add(Me.BtnUnused1Dose2)
        Me.TabPage4.Controls.Add(Me.BtnUnused2Dose2)
        Me.TabPage4.Controls.Add(Me.BtnPRFDose2)
        Me.TabPage4.Controls.Add(Me.BtnAFCHomeDose2)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMaxDose2)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMaxDose2)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMinDose2)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMinDose2)
        Me.TabPage4.Controls.Add(Me.BtnAFCTriggerDelayDose2)
        Me.TabPage4.Controls.Add(Me.BtnSpareTriggerDelayDose2)
        Me.TabPage4.Controls.Add(Me.BtnGunCathodeDose2)
        Me.TabPage4.Controls.Add(Me.BtnPulseTopDose2)
        Me.TabPage4.Controls.Add(Me.BtnMagnetCurrentDose2)
        Me.TabPage4.Controls.Add(Me.BtnHVPSDose2)
        Me.TabPage4.Controls.Add(Me.BtnUnused0Dose1)
        Me.TabPage4.Controls.Add(Me.BtnUnused1Dose1)
        Me.TabPage4.Controls.Add(Me.BtnUnused2Dose1)
        Me.TabPage4.Controls.Add(Me.BtnPRFDose1)
        Me.TabPage4.Controls.Add(Me.BtnAFCHomeDose1)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMaxDose1)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMaxDose1)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMinDose1)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMinDose1)
        Me.TabPage4.Controls.Add(Me.BtnAFCTriggerDelayDose1)
        Me.TabPage4.Controls.Add(Me.BtnSpareTriggerDelayDose1)
        Me.TabPage4.Controls.Add(Me.BtnGunCathodeDose1)
        Me.TabPage4.Controls.Add(Me.BtnPulseTopDose1)
        Me.TabPage4.Controls.Add(Me.BtnMagnetCurrentDose1)
        Me.TabPage4.Controls.Add(Me.BtnHVPSDose1)
        Me.TabPage4.Controls.Add(Me.BtnUnused0Dose0)
        Me.TabPage4.Controls.Add(Me.BtnUnused1Dose0)
        Me.TabPage4.Controls.Add(Me.BtnUnused2Dose0)
        Me.TabPage4.Controls.Add(Me.BtnPRFDose0)
        Me.TabPage4.Controls.Add(Me.BtnAFCHomeDose0)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMaxDose0)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMaxDose0)
        Me.TabPage4.Controls.Add(Me.BtnGrideStopMinDose0)
        Me.TabPage4.Controls.Add(Me.BtnGrideStartMinDose0)
        Me.TabPage4.Controls.Add(Me.BtnAFCTriggerDelayDose0)
        Me.TabPage4.Controls.Add(Me.BtnSpareTriggerDelayDose0)
        Me.TabPage4.Controls.Add(Me.BtnGunCathodeDose0)
        Me.TabPage4.Controls.Add(Me.BtnPulseTopDose0)
        Me.TabPage4.Controls.Add(Me.BtnMagnetCurrentDose0)
        Me.TabPage4.Controls.Add(Me.BtnHVPSDose0)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1415, 935)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Dose"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BntECBEEPromConfigure
        '
        Me.BntECBEEPromConfigure.BackColor = System.Drawing.Color.Lavender
        Me.BntECBEEPromConfigure.FlatAppearance.BorderSize = 0
        Me.BntECBEEPromConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntECBEEPromConfigure.Location = New System.Drawing.Point(6, 669)
        Me.BntECBEEPromConfigure.Name = "BntECBEEPromConfigure"
        Me.BntECBEEPromConfigure.Size = New System.Drawing.Size(175, 23)
        Me.BntECBEEPromConfigure.TabIndex = 556
        Me.BntECBEEPromConfigure.Text = "Default EEProm Configure"
        Me.BntECBEEPromConfigure.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(904, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 26)
        Me.Label17.TabIndex = 555
        Me.Label17.Text = "All Settings All"
        '
        'BtnUnused0DoseAll
        '
        Me.BtnUnused0DoseAll.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused0DoseAll.FlatAppearance.BorderSize = 0
        Me.BtnUnused0DoseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused0DoseAll.Location = New System.Drawing.Point(907, 467)
        Me.BtnUnused0DoseAll.Name = "BtnUnused0DoseAll"
        Me.BtnUnused0DoseAll.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused0DoseAll.TabIndex = 539
        Me.BtnUnused0DoseAll.Text = "Unused0"
        Me.BtnUnused0DoseAll.UseVisualStyleBackColor = False
        '
        'BtnUnused1DoseAll
        '
        Me.BtnUnused1DoseAll.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused1DoseAll.FlatAppearance.BorderSize = 0
        Me.BtnUnused1DoseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused1DoseAll.Location = New System.Drawing.Point(907, 438)
        Me.BtnUnused1DoseAll.Name = "BtnUnused1DoseAll"
        Me.BtnUnused1DoseAll.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused1DoseAll.TabIndex = 538
        Me.BtnUnused1DoseAll.Text = "Unused1"
        Me.BtnUnused1DoseAll.UseVisualStyleBackColor = False
        '
        'BtnUnused2DoseAll
        '
        Me.BtnUnused2DoseAll.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused2DoseAll.FlatAppearance.BorderSize = 0
        Me.BtnUnused2DoseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused2DoseAll.Location = New System.Drawing.Point(907, 409)
        Me.BtnUnused2DoseAll.Name = "BtnUnused2DoseAll"
        Me.BtnUnused2DoseAll.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused2DoseAll.TabIndex = 537
        Me.BtnUnused2DoseAll.Text = "Unused2"
        Me.BtnUnused2DoseAll.UseVisualStyleBackColor = False
        '
        'BtnUnused3DoseAll
        '
        Me.BtnUnused3DoseAll.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused3DoseAll.FlatAppearance.BorderSize = 0
        Me.BtnUnused3DoseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused3DoseAll.Location = New System.Drawing.Point(907, 380)
        Me.BtnUnused3DoseAll.Name = "BtnUnused3DoseAll"
        Me.BtnUnused3DoseAll.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused3DoseAll.TabIndex = 536
        Me.BtnUnused3DoseAll.Text = "Unused3"
        Me.BtnUnused3DoseAll.UseVisualStyleBackColor = False
        '
        'BtnGunHeater
        '
        Me.BtnGunHeater.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunHeater.FlatAppearance.BorderSize = 0
        Me.BtnGunHeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunHeater.Location = New System.Drawing.Point(907, 90)
        Me.BtnGunHeater.Name = "BtnGunHeater"
        Me.BtnGunHeater.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunHeater.TabIndex = 535
        Me.BtnGunHeater.Text = "Gun Heater"
        Me.BtnGunHeater.UseVisualStyleBackColor = False
        '
        'BtnAFCManualPostion
        '
        Me.BtnAFCManualPostion.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCManualPostion.FlatAppearance.BorderSize = 0
        Me.BtnAFCManualPostion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCManualPostion.Location = New System.Drawing.Point(907, 351)
        Me.BtnAFCManualPostion.Name = "BtnAFCManualPostion"
        Me.BtnAFCManualPostion.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCManualPostion.TabIndex = 534
        Me.BtnAFCManualPostion.Text = "AFC Manual Position"
        Me.BtnAFCManualPostion.UseVisualStyleBackColor = False
        '
        'BtnGunBias
        '
        Me.BtnGunBias.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunBias.FlatAppearance.BorderSize = 0
        Me.BtnGunBias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunBias.Location = New System.Drawing.Point(907, 293)
        Me.BtnGunBias.Name = "BtnGunBias"
        Me.BtnGunBias.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunBias.TabIndex = 533
        Me.BtnGunBias.Text = "Gun Bias"
        Me.BtnGunBias.UseVisualStyleBackColor = False
        '
        'BtnAFCAuxControl
        '
        Me.BtnAFCAuxControl.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCAuxControl.FlatAppearance.BorderSize = 0
        Me.BtnAFCAuxControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCAuxControl.Location = New System.Drawing.Point(907, 322)
        Me.BtnAFCAuxControl.Name = "BtnAFCAuxControl"
        Me.BtnAFCAuxControl.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCAuxControl.TabIndex = 532
        Me.BtnAFCAuxControl.Text = "AFC Aux Control"
        Me.BtnAFCAuxControl.UseVisualStyleBackColor = False
        '
        'BtnXrayRunTime
        '
        Me.BtnXrayRunTime.BackColor = System.Drawing.Color.Lavender
        Me.BtnXrayRunTime.FlatAppearance.BorderSize = 0
        Me.BtnXrayRunTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnXrayRunTime.Location = New System.Drawing.Point(907, 264)
        Me.BtnXrayRunTime.Name = "BtnXrayRunTime"
        Me.BtnXrayRunTime.Size = New System.Drawing.Size(175, 23)
        Me.BtnXrayRunTime.TabIndex = 531
        Me.BtnXrayRunTime.Text = "X-Ray Run Time"
        Me.BtnXrayRunTime.UseVisualStyleBackColor = False
        '
        'BtnSampleTriggerStop
        '
        Me.BtnSampleTriggerStop.BackColor = System.Drawing.Color.Lavender
        Me.BtnSampleTriggerStop.FlatAppearance.BorderSize = 0
        Me.BtnSampleTriggerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSampleTriggerStop.Location = New System.Drawing.Point(907, 235)
        Me.BtnSampleTriggerStop.Name = "BtnSampleTriggerStop"
        Me.BtnSampleTriggerStop.Size = New System.Drawing.Size(175, 23)
        Me.BtnSampleTriggerStop.TabIndex = 530
        Me.BtnSampleTriggerStop.Text = "Sample Trigger Stop"
        Me.BtnSampleTriggerStop.UseVisualStyleBackColor = False
        '
        'BtnSampleTriggerStart
        '
        Me.BtnSampleTriggerStart.BackColor = System.Drawing.Color.Lavender
        Me.BtnSampleTriggerStart.FlatAppearance.BorderSize = 0
        Me.BtnSampleTriggerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSampleTriggerStart.Location = New System.Drawing.Point(907, 206)
        Me.BtnSampleTriggerStart.Name = "BtnSampleTriggerStart"
        Me.BtnSampleTriggerStart.Size = New System.Drawing.Size(175, 23)
        Me.BtnSampleTriggerStart.TabIndex = 529
        Me.BtnSampleTriggerStart.Text = "Sample Trigger Start"
        Me.BtnSampleTriggerStart.UseVisualStyleBackColor = False
        '
        'BtnPFNTriggerDelay
        '
        Me.BtnPFNTriggerDelay.BackColor = System.Drawing.Color.Lavender
        Me.BtnPFNTriggerDelay.FlatAppearance.BorderSize = 0
        Me.BtnPFNTriggerDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPFNTriggerDelay.Location = New System.Drawing.Point(907, 177)
        Me.BtnPFNTriggerDelay.Name = "BtnPFNTriggerDelay"
        Me.BtnPFNTriggerDelay.Size = New System.Drawing.Size(175, 23)
        Me.BtnPFNTriggerDelay.TabIndex = 528
        Me.BtnPFNTriggerDelay.Text = "PFN Trigger Delay"
        Me.BtnPFNTriggerDelay.UseVisualStyleBackColor = False
        '
        'BtnHVPSTrigStop
        '
        Me.BtnHVPSTrigStop.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSTrigStop.FlatAppearance.BorderSize = 0
        Me.BtnHVPSTrigStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSTrigStop.Location = New System.Drawing.Point(907, 148)
        Me.BtnHVPSTrigStop.Name = "BtnHVPSTrigStop"
        Me.BtnHVPSTrigStop.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSTrigStop.TabIndex = 527
        Me.BtnHVPSTrigStop.Text = "HVPS Trig Stop"
        Me.BtnHVPSTrigStop.UseVisualStyleBackColor = False
        '
        'BtnHVPSTrigStart
        '
        Me.BtnHVPSTrigStart.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSTrigStart.FlatAppearance.BorderSize = 0
        Me.BtnHVPSTrigStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSTrigStart.Location = New System.Drawing.Point(907, 119)
        Me.BtnHVPSTrigStart.Name = "BtnHVPSTrigStart"
        Me.BtnHVPSTrigStart.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSTrigStart.TabIndex = 526
        Me.BtnHVPSTrigStart.Text = "HVPS Trig Start"
        Me.BtnHVPSTrigStart.UseVisualStyleBackColor = False
        '
        'BtnMagnetronHeater
        '
        Me.BtnMagnetronHeater.BackColor = System.Drawing.Color.Lavender
        Me.BtnMagnetronHeater.FlatAppearance.BorderSize = 0
        Me.BtnMagnetronHeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMagnetronHeater.Location = New System.Drawing.Point(907, 61)
        Me.BtnMagnetronHeater.Name = "BtnMagnetronHeater"
        Me.BtnMagnetronHeater.Size = New System.Drawing.Size(175, 23)
        Me.BtnMagnetronHeater.TabIndex = 525
        Me.BtnMagnetronHeater.Text = "Magnetron Heater"
        Me.BtnMagnetronHeater.UseVisualStyleBackColor = False
        '
        'LblDose3
        '
        Me.LblDose3.AutoSize = True
        Me.LblDose3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDose3.Location = New System.Drawing.Point(683, 29)
        Me.LblDose3.Name = "LblDose3"
        Me.LblDose3.Size = New System.Drawing.Size(166, 26)
        Me.LblDose3.TabIndex = 524
        Me.LblDose3.Text = "Dose 3 Settings"
        '
        'LblDose2
        '
        Me.LblDose2.AutoSize = True
        Me.LblDose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDose2.Location = New System.Drawing.Point(457, 29)
        Me.LblDose2.Name = "LblDose2"
        Me.LblDose2.Size = New System.Drawing.Size(166, 26)
        Me.LblDose2.TabIndex = 523
        Me.LblDose2.Text = "Dose 2 Settings"
        '
        'LblDose1
        '
        Me.LblDose1.AutoSize = True
        Me.LblDose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDose1.Location = New System.Drawing.Point(229, 29)
        Me.LblDose1.Name = "LblDose1"
        Me.LblDose1.Size = New System.Drawing.Size(166, 26)
        Me.LblDose1.TabIndex = 522
        Me.LblDose1.Text = "Dose 1 Settings"
        '
        'LblDose0
        '
        Me.LblDose0.AutoSize = True
        Me.LblDose0.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDose0.Location = New System.Drawing.Point(6, 29)
        Me.LblDose0.Name = "LblDose0"
        Me.LblDose0.Size = New System.Drawing.Size(166, 26)
        Me.LblDose0.TabIndex = 521
        Me.LblDose0.Text = "Dose 0 Settings"
        '
        'BtnUnused0Dose3
        '
        Me.BtnUnused0Dose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused0Dose3.FlatAppearance.BorderSize = 0
        Me.BtnUnused0Dose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused0Dose3.Location = New System.Drawing.Point(686, 467)
        Me.BtnUnused0Dose3.Name = "BtnUnused0Dose3"
        Me.BtnUnused0Dose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused0Dose3.TabIndex = 520
        Me.BtnUnused0Dose3.Text = "Unused0"
        Me.BtnUnused0Dose3.UseVisualStyleBackColor = False
        '
        'BtnUnused1Dose3
        '
        Me.BtnUnused1Dose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused1Dose3.FlatAppearance.BorderSize = 0
        Me.BtnUnused1Dose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused1Dose3.Location = New System.Drawing.Point(686, 438)
        Me.BtnUnused1Dose3.Name = "BtnUnused1Dose3"
        Me.BtnUnused1Dose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused1Dose3.TabIndex = 519
        Me.BtnUnused1Dose3.Text = "Unused1"
        Me.BtnUnused1Dose3.UseVisualStyleBackColor = False
        '
        'BtnUnused2Dose3
        '
        Me.BtnUnused2Dose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused2Dose3.FlatAppearance.BorderSize = 0
        Me.BtnUnused2Dose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused2Dose3.Location = New System.Drawing.Point(686, 409)
        Me.BtnUnused2Dose3.Name = "BtnUnused2Dose3"
        Me.BtnUnused2Dose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused2Dose3.TabIndex = 518
        Me.BtnUnused2Dose3.Text = "Unused2"
        Me.BtnUnused2Dose3.UseVisualStyleBackColor = False
        '
        'BtnPRFDose3
        '
        Me.BtnPRFDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnPRFDose3.FlatAppearance.BorderSize = 0
        Me.BtnPRFDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPRFDose3.Location = New System.Drawing.Point(686, 380)
        Me.BtnPRFDose3.Name = "BtnPRFDose3"
        Me.BtnPRFDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnPRFDose3.TabIndex = 517
        Me.BtnPRFDose3.Text = "PRF"
        Me.BtnPRFDose3.UseVisualStyleBackColor = False
        '
        'BtnAFCHomeDose3
        '
        Me.BtnAFCHomeDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCHomeDose3.FlatAppearance.BorderSize = 0
        Me.BtnAFCHomeDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCHomeDose3.Location = New System.Drawing.Point(686, 351)
        Me.BtnAFCHomeDose3.Name = "BtnAFCHomeDose3"
        Me.BtnAFCHomeDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCHomeDose3.TabIndex = 516
        Me.BtnAFCHomeDose3.Text = "AFC Home"
        Me.BtnAFCHomeDose3.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMaxDose3
        '
        Me.BtnGrideStopMaxDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMaxDose3.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMaxDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMaxDose3.Location = New System.Drawing.Point(686, 322)
        Me.BtnGrideStopMaxDose3.Name = "BtnGrideStopMaxDose3"
        Me.BtnGrideStopMaxDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMaxDose3.TabIndex = 515
        Me.BtnGrideStopMaxDose3.Text = "GRID Stop Max"
        Me.BtnGrideStopMaxDose3.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMaxDose3
        '
        Me.BtnGrideStartMaxDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMaxDose3.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMaxDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMaxDose3.Location = New System.Drawing.Point(686, 264)
        Me.BtnGrideStartMaxDose3.Name = "BtnGrideStartMaxDose3"
        Me.BtnGrideStartMaxDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMaxDose3.TabIndex = 514
        Me.BtnGrideStartMaxDose3.Text = "GRID Start Max"
        Me.BtnGrideStartMaxDose3.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMinDose3
        '
        Me.BtnGrideStopMinDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMinDose3.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMinDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMinDose3.Location = New System.Drawing.Point(686, 293)
        Me.BtnGrideStopMinDose3.Name = "BtnGrideStopMinDose3"
        Me.BtnGrideStopMinDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMinDose3.TabIndex = 513
        Me.BtnGrideStopMinDose3.Text = "GRID Stop Min"
        Me.BtnGrideStopMinDose3.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMinDose3
        '
        Me.BtnGrideStartMinDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMinDose3.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMinDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMinDose3.Location = New System.Drawing.Point(686, 235)
        Me.BtnGrideStartMinDose3.Name = "BtnGrideStartMinDose3"
        Me.BtnGrideStartMinDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMinDose3.TabIndex = 512
        Me.BtnGrideStartMinDose3.Text = "GRID Start Min"
        Me.BtnGrideStartMinDose3.UseVisualStyleBackColor = False
        '
        'BtnAFCTriggerDelayDose3
        '
        Me.BtnAFCTriggerDelayDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCTriggerDelayDose3.FlatAppearance.BorderSize = 0
        Me.BtnAFCTriggerDelayDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCTriggerDelayDose3.Location = New System.Drawing.Point(686, 206)
        Me.BtnAFCTriggerDelayDose3.Name = "BtnAFCTriggerDelayDose3"
        Me.BtnAFCTriggerDelayDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCTriggerDelayDose3.TabIndex = 511
        Me.BtnAFCTriggerDelayDose3.Text = "AFC Trigger Delay"
        Me.BtnAFCTriggerDelayDose3.UseVisualStyleBackColor = False
        '
        'BtnSpareTriggerDelayDose3
        '
        Me.BtnSpareTriggerDelayDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnSpareTriggerDelayDose3.FlatAppearance.BorderSize = 0
        Me.BtnSpareTriggerDelayDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSpareTriggerDelayDose3.Location = New System.Drawing.Point(686, 177)
        Me.BtnSpareTriggerDelayDose3.Name = "BtnSpareTriggerDelayDose3"
        Me.BtnSpareTriggerDelayDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnSpareTriggerDelayDose3.TabIndex = 510
        Me.BtnSpareTriggerDelayDose3.Text = "Spare Trigger Delay"
        Me.BtnSpareTriggerDelayDose3.UseVisualStyleBackColor = False
        '
        'BtnGunCathodeDose3
        '
        Me.BtnGunCathodeDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunCathodeDose3.FlatAppearance.BorderSize = 0
        Me.BtnGunCathodeDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunCathodeDose3.Location = New System.Drawing.Point(686, 148)
        Me.BtnGunCathodeDose3.Name = "BtnGunCathodeDose3"
        Me.BtnGunCathodeDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunCathodeDose3.TabIndex = 509
        Me.BtnGunCathodeDose3.Text = "Gun Cathode"
        Me.BtnGunCathodeDose3.UseVisualStyleBackColor = False
        '
        'BtnPulseTopDose3
        '
        Me.BtnPulseTopDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnPulseTopDose3.FlatAppearance.BorderSize = 0
        Me.BtnPulseTopDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPulseTopDose3.Location = New System.Drawing.Point(686, 119)
        Me.BtnPulseTopDose3.Name = "BtnPulseTopDose3"
        Me.BtnPulseTopDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnPulseTopDose3.TabIndex = 508
        Me.BtnPulseTopDose3.Text = "Gun Pulse Top"
        Me.BtnPulseTopDose3.UseVisualStyleBackColor = False
        '
        'BtnMagnetCurrentDose3
        '
        Me.BtnMagnetCurrentDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnMagnetCurrentDose3.FlatAppearance.BorderSize = 0
        Me.BtnMagnetCurrentDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMagnetCurrentDose3.Location = New System.Drawing.Point(686, 90)
        Me.BtnMagnetCurrentDose3.Name = "BtnMagnetCurrentDose3"
        Me.BtnMagnetCurrentDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnMagnetCurrentDose3.TabIndex = 507
        Me.BtnMagnetCurrentDose3.Text = "Magnet Current"
        Me.BtnMagnetCurrentDose3.UseVisualStyleBackColor = False
        '
        'BtnHVPSDose3
        '
        Me.BtnHVPSDose3.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSDose3.FlatAppearance.BorderSize = 0
        Me.BtnHVPSDose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSDose3.Location = New System.Drawing.Point(686, 61)
        Me.BtnHVPSDose3.Name = "BtnHVPSDose3"
        Me.BtnHVPSDose3.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSDose3.TabIndex = 506
        Me.BtnHVPSDose3.Text = "HVPS Set"
        Me.BtnHVPSDose3.UseVisualStyleBackColor = False
        '
        'BtnUnused0Dose2
        '
        Me.BtnUnused0Dose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused0Dose2.FlatAppearance.BorderSize = 0
        Me.BtnUnused0Dose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused0Dose2.Location = New System.Drawing.Point(460, 467)
        Me.BtnUnused0Dose2.Name = "BtnUnused0Dose2"
        Me.BtnUnused0Dose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused0Dose2.TabIndex = 505
        Me.BtnUnused0Dose2.Text = "Unused0"
        Me.BtnUnused0Dose2.UseVisualStyleBackColor = False
        '
        'BtnUnused1Dose2
        '
        Me.BtnUnused1Dose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused1Dose2.FlatAppearance.BorderSize = 0
        Me.BtnUnused1Dose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused1Dose2.Location = New System.Drawing.Point(460, 438)
        Me.BtnUnused1Dose2.Name = "BtnUnused1Dose2"
        Me.BtnUnused1Dose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused1Dose2.TabIndex = 504
        Me.BtnUnused1Dose2.Text = "Unused1"
        Me.BtnUnused1Dose2.UseVisualStyleBackColor = False
        '
        'BtnUnused2Dose2
        '
        Me.BtnUnused2Dose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused2Dose2.FlatAppearance.BorderSize = 0
        Me.BtnUnused2Dose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused2Dose2.Location = New System.Drawing.Point(460, 409)
        Me.BtnUnused2Dose2.Name = "BtnUnused2Dose2"
        Me.BtnUnused2Dose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused2Dose2.TabIndex = 503
        Me.BtnUnused2Dose2.Text = "Unused2"
        Me.BtnUnused2Dose2.UseVisualStyleBackColor = False
        '
        'BtnPRFDose2
        '
        Me.BtnPRFDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnPRFDose2.FlatAppearance.BorderSize = 0
        Me.BtnPRFDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPRFDose2.Location = New System.Drawing.Point(460, 380)
        Me.BtnPRFDose2.Name = "BtnPRFDose2"
        Me.BtnPRFDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnPRFDose2.TabIndex = 502
        Me.BtnPRFDose2.Text = "PRF"
        Me.BtnPRFDose2.UseVisualStyleBackColor = False
        '
        'BtnAFCHomeDose2
        '
        Me.BtnAFCHomeDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCHomeDose2.FlatAppearance.BorderSize = 0
        Me.BtnAFCHomeDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCHomeDose2.Location = New System.Drawing.Point(460, 351)
        Me.BtnAFCHomeDose2.Name = "BtnAFCHomeDose2"
        Me.BtnAFCHomeDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCHomeDose2.TabIndex = 501
        Me.BtnAFCHomeDose2.Text = "AFC Home"
        Me.BtnAFCHomeDose2.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMaxDose2
        '
        Me.BtnGrideStopMaxDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMaxDose2.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMaxDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMaxDose2.Location = New System.Drawing.Point(460, 322)
        Me.BtnGrideStopMaxDose2.Name = "BtnGrideStopMaxDose2"
        Me.BtnGrideStopMaxDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMaxDose2.TabIndex = 500
        Me.BtnGrideStopMaxDose2.Text = "GRID Stop Max"
        Me.BtnGrideStopMaxDose2.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMaxDose2
        '
        Me.BtnGrideStartMaxDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMaxDose2.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMaxDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMaxDose2.Location = New System.Drawing.Point(460, 264)
        Me.BtnGrideStartMaxDose2.Name = "BtnGrideStartMaxDose2"
        Me.BtnGrideStartMaxDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMaxDose2.TabIndex = 499
        Me.BtnGrideStartMaxDose2.Text = "GRID Start Max"
        Me.BtnGrideStartMaxDose2.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMinDose2
        '
        Me.BtnGrideStopMinDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMinDose2.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMinDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMinDose2.Location = New System.Drawing.Point(460, 293)
        Me.BtnGrideStopMinDose2.Name = "BtnGrideStopMinDose2"
        Me.BtnGrideStopMinDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMinDose2.TabIndex = 498
        Me.BtnGrideStopMinDose2.Text = "GRID Stop Min"
        Me.BtnGrideStopMinDose2.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMinDose2
        '
        Me.BtnGrideStartMinDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMinDose2.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMinDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMinDose2.Location = New System.Drawing.Point(460, 235)
        Me.BtnGrideStartMinDose2.Name = "BtnGrideStartMinDose2"
        Me.BtnGrideStartMinDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMinDose2.TabIndex = 497
        Me.BtnGrideStartMinDose2.Text = "GRID Start Min"
        Me.BtnGrideStartMinDose2.UseVisualStyleBackColor = False
        '
        'BtnAFCTriggerDelayDose2
        '
        Me.BtnAFCTriggerDelayDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCTriggerDelayDose2.FlatAppearance.BorderSize = 0
        Me.BtnAFCTriggerDelayDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCTriggerDelayDose2.Location = New System.Drawing.Point(460, 206)
        Me.BtnAFCTriggerDelayDose2.Name = "BtnAFCTriggerDelayDose2"
        Me.BtnAFCTriggerDelayDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCTriggerDelayDose2.TabIndex = 496
        Me.BtnAFCTriggerDelayDose2.Text = "AFC Trigger Delay"
        Me.BtnAFCTriggerDelayDose2.UseVisualStyleBackColor = False
        '
        'BtnSpareTriggerDelayDose2
        '
        Me.BtnSpareTriggerDelayDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnSpareTriggerDelayDose2.FlatAppearance.BorderSize = 0
        Me.BtnSpareTriggerDelayDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSpareTriggerDelayDose2.Location = New System.Drawing.Point(460, 177)
        Me.BtnSpareTriggerDelayDose2.Name = "BtnSpareTriggerDelayDose2"
        Me.BtnSpareTriggerDelayDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnSpareTriggerDelayDose2.TabIndex = 495
        Me.BtnSpareTriggerDelayDose2.Text = "Spare Trigger Delay"
        Me.BtnSpareTriggerDelayDose2.UseVisualStyleBackColor = False
        '
        'BtnGunCathodeDose2
        '
        Me.BtnGunCathodeDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunCathodeDose2.FlatAppearance.BorderSize = 0
        Me.BtnGunCathodeDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunCathodeDose2.Location = New System.Drawing.Point(460, 148)
        Me.BtnGunCathodeDose2.Name = "BtnGunCathodeDose2"
        Me.BtnGunCathodeDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunCathodeDose2.TabIndex = 494
        Me.BtnGunCathodeDose2.Text = "Gun Cathode"
        Me.BtnGunCathodeDose2.UseVisualStyleBackColor = False
        '
        'BtnPulseTopDose2
        '
        Me.BtnPulseTopDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnPulseTopDose2.FlatAppearance.BorderSize = 0
        Me.BtnPulseTopDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPulseTopDose2.Location = New System.Drawing.Point(460, 119)
        Me.BtnPulseTopDose2.Name = "BtnPulseTopDose2"
        Me.BtnPulseTopDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnPulseTopDose2.TabIndex = 493
        Me.BtnPulseTopDose2.Text = "Gun Pulse Top"
        Me.BtnPulseTopDose2.UseVisualStyleBackColor = False
        '
        'BtnMagnetCurrentDose2
        '
        Me.BtnMagnetCurrentDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnMagnetCurrentDose2.FlatAppearance.BorderSize = 0
        Me.BtnMagnetCurrentDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMagnetCurrentDose2.Location = New System.Drawing.Point(460, 90)
        Me.BtnMagnetCurrentDose2.Name = "BtnMagnetCurrentDose2"
        Me.BtnMagnetCurrentDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnMagnetCurrentDose2.TabIndex = 492
        Me.BtnMagnetCurrentDose2.Text = "Magnet Current"
        Me.BtnMagnetCurrentDose2.UseVisualStyleBackColor = False
        '
        'BtnHVPSDose2
        '
        Me.BtnHVPSDose2.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSDose2.FlatAppearance.BorderSize = 0
        Me.BtnHVPSDose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSDose2.Location = New System.Drawing.Point(460, 61)
        Me.BtnHVPSDose2.Name = "BtnHVPSDose2"
        Me.BtnHVPSDose2.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSDose2.TabIndex = 491
        Me.BtnHVPSDose2.Text = "HVPS Set"
        Me.BtnHVPSDose2.UseVisualStyleBackColor = False
        '
        'BtnUnused0Dose1
        '
        Me.BtnUnused0Dose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused0Dose1.FlatAppearance.BorderSize = 0
        Me.BtnUnused0Dose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused0Dose1.Location = New System.Drawing.Point(232, 467)
        Me.BtnUnused0Dose1.Name = "BtnUnused0Dose1"
        Me.BtnUnused0Dose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused0Dose1.TabIndex = 490
        Me.BtnUnused0Dose1.Text = "Unused0"
        Me.BtnUnused0Dose1.UseVisualStyleBackColor = False
        '
        'BtnUnused1Dose1
        '
        Me.BtnUnused1Dose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused1Dose1.FlatAppearance.BorderSize = 0
        Me.BtnUnused1Dose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused1Dose1.Location = New System.Drawing.Point(232, 438)
        Me.BtnUnused1Dose1.Name = "BtnUnused1Dose1"
        Me.BtnUnused1Dose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused1Dose1.TabIndex = 489
        Me.BtnUnused1Dose1.Text = "Unused1"
        Me.BtnUnused1Dose1.UseVisualStyleBackColor = False
        '
        'BtnUnused2Dose1
        '
        Me.BtnUnused2Dose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused2Dose1.FlatAppearance.BorderSize = 0
        Me.BtnUnused2Dose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused2Dose1.Location = New System.Drawing.Point(232, 409)
        Me.BtnUnused2Dose1.Name = "BtnUnused2Dose1"
        Me.BtnUnused2Dose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused2Dose1.TabIndex = 488
        Me.BtnUnused2Dose1.Text = "Unused2"
        Me.BtnUnused2Dose1.UseVisualStyleBackColor = False
        '
        'BtnPRFDose1
        '
        Me.BtnPRFDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnPRFDose1.FlatAppearance.BorderSize = 0
        Me.BtnPRFDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPRFDose1.Location = New System.Drawing.Point(232, 380)
        Me.BtnPRFDose1.Name = "BtnPRFDose1"
        Me.BtnPRFDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnPRFDose1.TabIndex = 487
        Me.BtnPRFDose1.Text = "PRF"
        Me.BtnPRFDose1.UseVisualStyleBackColor = False
        '
        'BtnAFCHomeDose1
        '
        Me.BtnAFCHomeDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCHomeDose1.FlatAppearance.BorderSize = 0
        Me.BtnAFCHomeDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCHomeDose1.Location = New System.Drawing.Point(232, 351)
        Me.BtnAFCHomeDose1.Name = "BtnAFCHomeDose1"
        Me.BtnAFCHomeDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCHomeDose1.TabIndex = 486
        Me.BtnAFCHomeDose1.Text = "AFC Home"
        Me.BtnAFCHomeDose1.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMaxDose1
        '
        Me.BtnGrideStopMaxDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMaxDose1.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMaxDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMaxDose1.Location = New System.Drawing.Point(232, 322)
        Me.BtnGrideStopMaxDose1.Name = "BtnGrideStopMaxDose1"
        Me.BtnGrideStopMaxDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMaxDose1.TabIndex = 485
        Me.BtnGrideStopMaxDose1.Text = "GRID Stop Max"
        Me.BtnGrideStopMaxDose1.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMaxDose1
        '
        Me.BtnGrideStartMaxDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMaxDose1.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMaxDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMaxDose1.Location = New System.Drawing.Point(232, 264)
        Me.BtnGrideStartMaxDose1.Name = "BtnGrideStartMaxDose1"
        Me.BtnGrideStartMaxDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMaxDose1.TabIndex = 484
        Me.BtnGrideStartMaxDose1.Text = "GRID Start Max"
        Me.BtnGrideStartMaxDose1.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMinDose1
        '
        Me.BtnGrideStopMinDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMinDose1.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMinDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMinDose1.Location = New System.Drawing.Point(232, 293)
        Me.BtnGrideStopMinDose1.Name = "BtnGrideStopMinDose1"
        Me.BtnGrideStopMinDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMinDose1.TabIndex = 483
        Me.BtnGrideStopMinDose1.Text = "GRID Stop Min"
        Me.BtnGrideStopMinDose1.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMinDose1
        '
        Me.BtnGrideStartMinDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMinDose1.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMinDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMinDose1.Location = New System.Drawing.Point(232, 235)
        Me.BtnGrideStartMinDose1.Name = "BtnGrideStartMinDose1"
        Me.BtnGrideStartMinDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMinDose1.TabIndex = 482
        Me.BtnGrideStartMinDose1.Text = "GRID Start Min"
        Me.BtnGrideStartMinDose1.UseVisualStyleBackColor = False
        '
        'BtnAFCTriggerDelayDose1
        '
        Me.BtnAFCTriggerDelayDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCTriggerDelayDose1.FlatAppearance.BorderSize = 0
        Me.BtnAFCTriggerDelayDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCTriggerDelayDose1.Location = New System.Drawing.Point(232, 206)
        Me.BtnAFCTriggerDelayDose1.Name = "BtnAFCTriggerDelayDose1"
        Me.BtnAFCTriggerDelayDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCTriggerDelayDose1.TabIndex = 481
        Me.BtnAFCTriggerDelayDose1.Text = "AFC Trigger Delay"
        Me.BtnAFCTriggerDelayDose1.UseVisualStyleBackColor = False
        '
        'BtnSpareTriggerDelayDose1
        '
        Me.BtnSpareTriggerDelayDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnSpareTriggerDelayDose1.FlatAppearance.BorderSize = 0
        Me.BtnSpareTriggerDelayDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSpareTriggerDelayDose1.Location = New System.Drawing.Point(232, 177)
        Me.BtnSpareTriggerDelayDose1.Name = "BtnSpareTriggerDelayDose1"
        Me.BtnSpareTriggerDelayDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnSpareTriggerDelayDose1.TabIndex = 480
        Me.BtnSpareTriggerDelayDose1.Text = "Spare Trigger Delay"
        Me.BtnSpareTriggerDelayDose1.UseVisualStyleBackColor = False
        '
        'BtnGunCathodeDose1
        '
        Me.BtnGunCathodeDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunCathodeDose1.FlatAppearance.BorderSize = 0
        Me.BtnGunCathodeDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunCathodeDose1.Location = New System.Drawing.Point(232, 148)
        Me.BtnGunCathodeDose1.Name = "BtnGunCathodeDose1"
        Me.BtnGunCathodeDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunCathodeDose1.TabIndex = 479
        Me.BtnGunCathodeDose1.Text = "Gun Cathode"
        Me.BtnGunCathodeDose1.UseVisualStyleBackColor = False
        '
        'BtnPulseTopDose1
        '
        Me.BtnPulseTopDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnPulseTopDose1.FlatAppearance.BorderSize = 0
        Me.BtnPulseTopDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPulseTopDose1.Location = New System.Drawing.Point(232, 119)
        Me.BtnPulseTopDose1.Name = "BtnPulseTopDose1"
        Me.BtnPulseTopDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnPulseTopDose1.TabIndex = 478
        Me.BtnPulseTopDose1.Text = "Gun Pulse Top"
        Me.BtnPulseTopDose1.UseVisualStyleBackColor = False
        '
        'BtnMagnetCurrentDose1
        '
        Me.BtnMagnetCurrentDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnMagnetCurrentDose1.FlatAppearance.BorderSize = 0
        Me.BtnMagnetCurrentDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMagnetCurrentDose1.Location = New System.Drawing.Point(232, 90)
        Me.BtnMagnetCurrentDose1.Name = "BtnMagnetCurrentDose1"
        Me.BtnMagnetCurrentDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnMagnetCurrentDose1.TabIndex = 477
        Me.BtnMagnetCurrentDose1.Text = "Magnet Current"
        Me.BtnMagnetCurrentDose1.UseVisualStyleBackColor = False
        '
        'BtnHVPSDose1
        '
        Me.BtnHVPSDose1.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSDose1.FlatAppearance.BorderSize = 0
        Me.BtnHVPSDose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSDose1.Location = New System.Drawing.Point(232, 61)
        Me.BtnHVPSDose1.Name = "BtnHVPSDose1"
        Me.BtnHVPSDose1.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSDose1.TabIndex = 476
        Me.BtnHVPSDose1.Text = "HVPS Set"
        Me.BtnHVPSDose1.UseVisualStyleBackColor = False
        '
        'BtnUnused0Dose0
        '
        Me.BtnUnused0Dose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused0Dose0.FlatAppearance.BorderSize = 0
        Me.BtnUnused0Dose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused0Dose0.Location = New System.Drawing.Point(6, 467)
        Me.BtnUnused0Dose0.Name = "BtnUnused0Dose0"
        Me.BtnUnused0Dose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused0Dose0.TabIndex = 475
        Me.BtnUnused0Dose0.Text = "Unused0"
        Me.BtnUnused0Dose0.UseVisualStyleBackColor = False
        '
        'BtnUnused1Dose0
        '
        Me.BtnUnused1Dose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused1Dose0.FlatAppearance.BorderSize = 0
        Me.BtnUnused1Dose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused1Dose0.Location = New System.Drawing.Point(6, 438)
        Me.BtnUnused1Dose0.Name = "BtnUnused1Dose0"
        Me.BtnUnused1Dose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused1Dose0.TabIndex = 474
        Me.BtnUnused1Dose0.Text = "Unused1"
        Me.BtnUnused1Dose0.UseVisualStyleBackColor = False
        '
        'BtnUnused2Dose0
        '
        Me.BtnUnused2Dose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnUnused2Dose0.FlatAppearance.BorderSize = 0
        Me.BtnUnused2Dose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnused2Dose0.Location = New System.Drawing.Point(6, 409)
        Me.BtnUnused2Dose0.Name = "BtnUnused2Dose0"
        Me.BtnUnused2Dose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnUnused2Dose0.TabIndex = 473
        Me.BtnUnused2Dose0.Text = "Unused2"
        Me.BtnUnused2Dose0.UseVisualStyleBackColor = False
        '
        'BtnPRFDose0
        '
        Me.BtnPRFDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnPRFDose0.FlatAppearance.BorderSize = 0
        Me.BtnPRFDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPRFDose0.Location = New System.Drawing.Point(6, 380)
        Me.BtnPRFDose0.Name = "BtnPRFDose0"
        Me.BtnPRFDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnPRFDose0.TabIndex = 472
        Me.BtnPRFDose0.Text = "PRF"
        Me.BtnPRFDose0.UseVisualStyleBackColor = False
        '
        'BtnAFCHomeDose0
        '
        Me.BtnAFCHomeDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCHomeDose0.FlatAppearance.BorderSize = 0
        Me.BtnAFCHomeDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCHomeDose0.Location = New System.Drawing.Point(6, 351)
        Me.BtnAFCHomeDose0.Name = "BtnAFCHomeDose0"
        Me.BtnAFCHomeDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCHomeDose0.TabIndex = 471
        Me.BtnAFCHomeDose0.Text = "AFC Home"
        Me.BtnAFCHomeDose0.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMaxDose0
        '
        Me.BtnGrideStopMaxDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMaxDose0.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMaxDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMaxDose0.Location = New System.Drawing.Point(6, 322)
        Me.BtnGrideStopMaxDose0.Name = "BtnGrideStopMaxDose0"
        Me.BtnGrideStopMaxDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMaxDose0.TabIndex = 470
        Me.BtnGrideStopMaxDose0.Text = "GRID Stop Max"
        Me.BtnGrideStopMaxDose0.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMaxDose0
        '
        Me.BtnGrideStartMaxDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMaxDose0.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMaxDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMaxDose0.Location = New System.Drawing.Point(6, 264)
        Me.BtnGrideStartMaxDose0.Name = "BtnGrideStartMaxDose0"
        Me.BtnGrideStartMaxDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMaxDose0.TabIndex = 469
        Me.BtnGrideStartMaxDose0.Text = "GRID Start Max"
        Me.BtnGrideStartMaxDose0.UseVisualStyleBackColor = False
        '
        'BtnGrideStopMinDose0
        '
        Me.BtnGrideStopMinDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStopMinDose0.FlatAppearance.BorderSize = 0
        Me.BtnGrideStopMinDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStopMinDose0.Location = New System.Drawing.Point(6, 293)
        Me.BtnGrideStopMinDose0.Name = "BtnGrideStopMinDose0"
        Me.BtnGrideStopMinDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStopMinDose0.TabIndex = 468
        Me.BtnGrideStopMinDose0.Text = "GRID Stop Min"
        Me.BtnGrideStopMinDose0.UseVisualStyleBackColor = False
        '
        'BtnGrideStartMinDose0
        '
        Me.BtnGrideStartMinDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnGrideStartMinDose0.FlatAppearance.BorderSize = 0
        Me.BtnGrideStartMinDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrideStartMinDose0.Location = New System.Drawing.Point(6, 235)
        Me.BtnGrideStartMinDose0.Name = "BtnGrideStartMinDose0"
        Me.BtnGrideStartMinDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnGrideStartMinDose0.TabIndex = 467
        Me.BtnGrideStartMinDose0.Text = "GRID Start Min"
        Me.BtnGrideStartMinDose0.UseVisualStyleBackColor = False
        '
        'BtnAFCTriggerDelayDose0
        '
        Me.BtnAFCTriggerDelayDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnAFCTriggerDelayDose0.FlatAppearance.BorderSize = 0
        Me.BtnAFCTriggerDelayDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAFCTriggerDelayDose0.Location = New System.Drawing.Point(6, 206)
        Me.BtnAFCTriggerDelayDose0.Name = "BtnAFCTriggerDelayDose0"
        Me.BtnAFCTriggerDelayDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnAFCTriggerDelayDose0.TabIndex = 466
        Me.BtnAFCTriggerDelayDose0.Text = "AFC Trigger Delay"
        Me.BtnAFCTriggerDelayDose0.UseVisualStyleBackColor = False
        '
        'BtnSpareTriggerDelayDose0
        '
        Me.BtnSpareTriggerDelayDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnSpareTriggerDelayDose0.FlatAppearance.BorderSize = 0
        Me.BtnSpareTriggerDelayDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSpareTriggerDelayDose0.Location = New System.Drawing.Point(6, 177)
        Me.BtnSpareTriggerDelayDose0.Name = "BtnSpareTriggerDelayDose0"
        Me.BtnSpareTriggerDelayDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnSpareTriggerDelayDose0.TabIndex = 465
        Me.BtnSpareTriggerDelayDose0.Text = "Spare Trigger Delay"
        Me.BtnSpareTriggerDelayDose0.UseVisualStyleBackColor = False
        '
        'BtnGunCathodeDose0
        '
        Me.BtnGunCathodeDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnGunCathodeDose0.FlatAppearance.BorderSize = 0
        Me.BtnGunCathodeDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGunCathodeDose0.Location = New System.Drawing.Point(6, 148)
        Me.BtnGunCathodeDose0.Name = "BtnGunCathodeDose0"
        Me.BtnGunCathodeDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnGunCathodeDose0.TabIndex = 464
        Me.BtnGunCathodeDose0.Text = "Gun Cathode"
        Me.BtnGunCathodeDose0.UseVisualStyleBackColor = False
        '
        'BtnPulseTopDose0
        '
        Me.BtnPulseTopDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnPulseTopDose0.FlatAppearance.BorderSize = 0
        Me.BtnPulseTopDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPulseTopDose0.Location = New System.Drawing.Point(6, 119)
        Me.BtnPulseTopDose0.Name = "BtnPulseTopDose0"
        Me.BtnPulseTopDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnPulseTopDose0.TabIndex = 463
        Me.BtnPulseTopDose0.Text = "Gun Pulse Top"
        Me.BtnPulseTopDose0.UseVisualStyleBackColor = False
        '
        'BtnMagnetCurrentDose0
        '
        Me.BtnMagnetCurrentDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnMagnetCurrentDose0.FlatAppearance.BorderSize = 0
        Me.BtnMagnetCurrentDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMagnetCurrentDose0.Location = New System.Drawing.Point(6, 90)
        Me.BtnMagnetCurrentDose0.Name = "BtnMagnetCurrentDose0"
        Me.BtnMagnetCurrentDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnMagnetCurrentDose0.TabIndex = 462
        Me.BtnMagnetCurrentDose0.Text = "Magnet Current"
        Me.BtnMagnetCurrentDose0.UseVisualStyleBackColor = False
        '
        'BtnHVPSDose0
        '
        Me.BtnHVPSDose0.BackColor = System.Drawing.Color.Lavender
        Me.BtnHVPSDose0.FlatAppearance.BorderSize = 0
        Me.BtnHVPSDose0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHVPSDose0.Location = New System.Drawing.Point(6, 61)
        Me.BtnHVPSDose0.Name = "BtnHVPSDose0"
        Me.BtnHVPSDose0.Size = New System.Drawing.Size(175, 23)
        Me.BtnHVPSDose0.TabIndex = 461
        Me.BtnHVPSDose0.Text = "HVPS Set"
        Me.BtnHVPSDose0.UseVisualStyleBackColor = False
        '
        'TabPage2Slave
        '
        Me.TabPage2Slave.Controls.Add(Me.BtnMCUReset)
        Me.TabPage2Slave.Controls.Add(Me.CoBoxSelectedCanBoard)
        Me.TabPage2Slave.Controls.Add(Me.BtnSetCalPair)
        Me.TabPage2Slave.Controls.Add(Me.BtnEEPromDebug)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebug0)
        Me.TabPage2Slave.Controls.Add(Me.BtnRamDebug)
        Me.TabPage2Slave.Controls.Add(Me.BtnSlaveDefaultEEProm)
        Me.TabPage2Slave.Controls.Add(Me.BtnSetRevSN)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugSystem0)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD15)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD14)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD13)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD12)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD11)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD10)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD9)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD8)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugTBD0)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal3ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal3ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal3IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal3IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal2ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal2ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal2IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal2IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal1ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal1ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal1IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal1IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal0ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal0ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal0IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal0IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal7ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal7ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal7IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal7IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal6ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal6ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal6IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal6IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal5ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal5ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal5IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal5IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal4ExtOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal4ExtGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal4IntOffset)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCal4IntGain)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom15)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom14)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom13)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom12)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom11)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom10)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom9)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom8)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugEEprom0)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanF)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanE)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanD)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanC)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanB)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCanA)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan9)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan8)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugCan0)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegF)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegE)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegD)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegC)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegB)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugRegA)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg9)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg8)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg7)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg6)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg5)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg4)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg3)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg2)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg1)
        Me.TabPage2Slave.Controls.Add(Me.LblDebugReg0)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue23)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue15)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue16)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue17)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue18)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue19)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue20)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue21)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue22)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue0)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue1)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue2)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue3)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue4)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue5)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue6)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue7)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue8)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue9)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue10)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue11)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue12)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue13)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLogValue14)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog23)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog15)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog16)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog17)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog18)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog19)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog20)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog21)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog22)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedF)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedE)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedD)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedC)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedB)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLoggedA)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged9)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged8)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged0)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged7)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged6)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged5)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged4)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged3)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged2)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotLogged1)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedF)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedE)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedD)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedC)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedB)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLoggedA)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged9)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged8)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged0)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged7)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged6)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged5)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged4)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged3)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged2)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusLogged1)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultF)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultE)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultD)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultC)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultB)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFaultA)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault9)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault8)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault0)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault7)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault6)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault5)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault4)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault3)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault2)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusFault1)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice7)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice6)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice5)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice4)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice3)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice2)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice1)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusNotice0)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl0)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl7)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl6)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl5)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl4)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl3)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl2)
        Me.TabPage2Slave.Controls.Add(Me.CbxSlaveStatusCntrl1)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog0)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog1)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog2)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog3)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog4)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog5)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog6)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog7)
        Me.TabPage2Slave.Controls.Add(Me.LabelFirmwareVerssion)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog8)
        Me.TabPage2Slave.Controls.Add(Me.LabelAgileInfo)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog9)
        Me.TabPage2Slave.Controls.Add(Me.LabelBoardStatus)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog10)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog11)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog12)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog13)
        Me.TabPage2Slave.Controls.Add(Me.LblSlaveLog14)
        Me.TabPage2Slave.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2Slave.Name = "TabPage2Slave"
        Me.TabPage2Slave.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2Slave.Size = New System.Drawing.Size(1415, 935)
        Me.TabPage2Slave.TabIndex = 0
        Me.TabPage2Slave.Text = "Slave"
        Me.TabPage2Slave.UseVisualStyleBackColor = True
        '
        'BtnMCUReset
        '
        Me.BtnMCUReset.Location = New System.Drawing.Point(105, 809)
        Me.BtnMCUReset.Name = "BtnMCUReset"
        Me.BtnMCUReset.Size = New System.Drawing.Size(93, 23)
        Me.BtnMCUReset.TabIndex = 629
        Me.BtnMCUReset.Text = "Reset MCU"
        Me.BtnMCUReset.UseVisualStyleBackColor = True
        '
        'CoBoxSelectedCanBoard
        '
        Me.CoBoxSelectedCanBoard.FormattingEnabled = True
        Me.CoBoxSelectedCanBoard.Items.AddRange(New Object() {"HVPS Interface", "Ion Pump Interface", "AFC Interface", "Cooling / SF6 Interface", "Magnetron Heater/Magnet", "Gun Driver", "Magnetron Current Monitor", "Target Current Monitor", "Dose Monitor", "PFN Interfacce", "System Control Board"})
        Me.CoBoxSelectedCanBoard.Location = New System.Drawing.Point(6, 12)
        Me.CoBoxSelectedCanBoard.Name = "CoBoxSelectedCanBoard"
        Me.CoBoxSelectedCanBoard.Size = New System.Drawing.Size(204, 21)
        Me.CoBoxSelectedCanBoard.TabIndex = 628
        Me.CoBoxSelectedCanBoard.Text = "System Control Board"
        '
        'BtnSetCalPair
        '
        Me.BtnSetCalPair.Location = New System.Drawing.Point(6, 838)
        Me.BtnSetCalPair.Name = "BtnSetCalPair"
        Me.BtnSetCalPair.Size = New System.Drawing.Size(93, 23)
        Me.BtnSetCalPair.TabIndex = 624
        Me.BtnSetCalPair.Text = "Set Cal Pair"
        Me.BtnSetCalPair.UseVisualStyleBackColor = True
        '
        'BtnEEPromDebug
        '
        Me.BtnEEPromDebug.Location = New System.Drawing.Point(105, 867)
        Me.BtnEEPromDebug.Name = "BtnEEPromDebug"
        Me.BtnEEPromDebug.Size = New System.Drawing.Size(93, 23)
        Me.BtnEEPromDebug.TabIndex = 622
        Me.BtnEEPromDebug.Text = "EEProm Debug"
        Me.BtnEEPromDebug.UseVisualStyleBackColor = True
        '
        'LblDebug7
        '
        Me.LblDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug7.Location = New System.Drawing.Point(1174, 889)
        Me.LblDebug7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug7.Name = "LblDebug7"
        Me.LblDebug7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug7.TabIndex = 621
        Me.LblDebug7.Text = "Debuging"
        Me.LblDebug7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug6
        '
        Me.LblDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug6.Location = New System.Drawing.Point(1174, 869)
        Me.LblDebug6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug6.Name = "LblDebug6"
        Me.LblDebug6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug6.TabIndex = 620
        Me.LblDebug6.Text = "Debuging"
        Me.LblDebug6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug5
        '
        Me.LblDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug5.Location = New System.Drawing.Point(1174, 849)
        Me.LblDebug5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug5.Name = "LblDebug5"
        Me.LblDebug5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug5.TabIndex = 619
        Me.LblDebug5.Text = "Debuging"
        Me.LblDebug5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug4
        '
        Me.LblDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug4.Location = New System.Drawing.Point(1174, 829)
        Me.LblDebug4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug4.Name = "LblDebug4"
        Me.LblDebug4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug4.TabIndex = 618
        Me.LblDebug4.Text = "Debuging"
        Me.LblDebug4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug3
        '
        Me.LblDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug3.Location = New System.Drawing.Point(1174, 809)
        Me.LblDebug3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug3.Name = "LblDebug3"
        Me.LblDebug3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug3.TabIndex = 617
        Me.LblDebug3.Text = "Debuging"
        Me.LblDebug3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug2
        '
        Me.LblDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug2.Location = New System.Drawing.Point(1174, 789)
        Me.LblDebug2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug2.Name = "LblDebug2"
        Me.LblDebug2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug2.TabIndex = 616
        Me.LblDebug2.Text = "Debuging"
        Me.LblDebug2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug1
        '
        Me.LblDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug1.Location = New System.Drawing.Point(1174, 769)
        Me.LblDebug1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug1.Name = "LblDebug1"
        Me.LblDebug1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug1.TabIndex = 615
        Me.LblDebug1.Text = "Debuging"
        Me.LblDebug1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebug0
        '
        Me.LblDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug0.Location = New System.Drawing.Point(1174, 749)
        Me.LblDebug0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebug0.Name = "LblDebug0"
        Me.LblDebug0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebug0.TabIndex = 614
        Me.LblDebug0.Text = "Debuging"
        Me.LblDebug0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnRamDebug
        '
        Me.BtnRamDebug.Location = New System.Drawing.Point(105, 838)
        Me.BtnRamDebug.Name = "BtnRamDebug"
        Me.BtnRamDebug.Size = New System.Drawing.Size(93, 23)
        Me.BtnRamDebug.TabIndex = 613
        Me.BtnRamDebug.Text = "RAM Debug"
        Me.BtnRamDebug.UseVisualStyleBackColor = True
        '
        'BtnSlaveDefaultEEProm
        '
        Me.BtnSlaveDefaultEEProm.Location = New System.Drawing.Point(6, 867)
        Me.BtnSlaveDefaultEEProm.Name = "BtnSlaveDefaultEEProm"
        Me.BtnSlaveDefaultEEProm.Size = New System.Drawing.Size(93, 23)
        Me.BtnSlaveDefaultEEProm.TabIndex = 612
        Me.BtnSlaveDefaultEEProm.Text = "EEProm Default"
        Me.BtnSlaveDefaultEEProm.UseVisualStyleBackColor = True
        '
        'BtnSetRevSN
        '
        Me.BtnSetRevSN.Location = New System.Drawing.Point(6, 809)
        Me.BtnSetRevSN.Name = "BtnSetRevSN"
        Me.BtnSetRevSN.Size = New System.Drawing.Size(93, 23)
        Me.BtnSetRevSN.TabIndex = 611
        Me.BtnSetRevSN.Text = "Set Rev/SN"
        Me.BtnSetRevSN.UseVisualStyleBackColor = True
        '
        'LblDebugSystem7
        '
        Me.LblDebugSystem7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem7.Location = New System.Drawing.Point(950, 889)
        Me.LblDebugSystem7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem7.Name = "LblDebugSystem7"
        Me.LblDebugSystem7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem7.TabIndex = 610
        Me.LblDebugSystem7.Text = "System Debug"
        Me.LblDebugSystem7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem6
        '
        Me.LblDebugSystem6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem6.Location = New System.Drawing.Point(950, 869)
        Me.LblDebugSystem6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem6.Name = "LblDebugSystem6"
        Me.LblDebugSystem6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem6.TabIndex = 609
        Me.LblDebugSystem6.Text = "System Debug"
        Me.LblDebugSystem6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem5
        '
        Me.LblDebugSystem5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem5.Location = New System.Drawing.Point(950, 849)
        Me.LblDebugSystem5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem5.Name = "LblDebugSystem5"
        Me.LblDebugSystem5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem5.TabIndex = 608
        Me.LblDebugSystem5.Text = "System Debug"
        Me.LblDebugSystem5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem4
        '
        Me.LblDebugSystem4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem4.Location = New System.Drawing.Point(950, 829)
        Me.LblDebugSystem4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem4.Name = "LblDebugSystem4"
        Me.LblDebugSystem4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem4.TabIndex = 607
        Me.LblDebugSystem4.Text = "System Debug"
        Me.LblDebugSystem4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem3
        '
        Me.LblDebugSystem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem3.Location = New System.Drawing.Point(950, 809)
        Me.LblDebugSystem3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem3.Name = "LblDebugSystem3"
        Me.LblDebugSystem3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem3.TabIndex = 606
        Me.LblDebugSystem3.Text = "System Debug"
        Me.LblDebugSystem3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem2
        '
        Me.LblDebugSystem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem2.Location = New System.Drawing.Point(950, 789)
        Me.LblDebugSystem2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem2.Name = "LblDebugSystem2"
        Me.LblDebugSystem2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem2.TabIndex = 605
        Me.LblDebugSystem2.Text = "System Debug"
        Me.LblDebugSystem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem1
        '
        Me.LblDebugSystem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem1.Location = New System.Drawing.Point(950, 769)
        Me.LblDebugSystem1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem1.Name = "LblDebugSystem1"
        Me.LblDebugSystem1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem1.TabIndex = 604
        Me.LblDebugSystem1.Text = "System Debug"
        Me.LblDebugSystem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugSystem0
        '
        Me.LblDebugSystem0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugSystem0.Location = New System.Drawing.Point(950, 749)
        Me.LblDebugSystem0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugSystem0.Name = "LblDebugSystem0"
        Me.LblDebugSystem0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugSystem0.TabIndex = 603
        Me.LblDebugSystem0.Text = "System Debug"
        Me.LblDebugSystem0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD15
        '
        Me.LblDebugTBD15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD15.Location = New System.Drawing.Point(950, 722)
        Me.LblDebugTBD15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD15.Name = "LblDebugTBD15"
        Me.LblDebugTBD15.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD15.TabIndex = 602
        Me.LblDebugTBD15.Text = "TBD Debug"
        Me.LblDebugTBD15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD14
        '
        Me.LblDebugTBD14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD14.Location = New System.Drawing.Point(950, 702)
        Me.LblDebugTBD14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD14.Name = "LblDebugTBD14"
        Me.LblDebugTBD14.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD14.TabIndex = 601
        Me.LblDebugTBD14.Text = "TBD Debug"
        Me.LblDebugTBD14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD13
        '
        Me.LblDebugTBD13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD13.Location = New System.Drawing.Point(950, 682)
        Me.LblDebugTBD13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD13.Name = "LblDebugTBD13"
        Me.LblDebugTBD13.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD13.TabIndex = 600
        Me.LblDebugTBD13.Text = "TBD Debug"
        Me.LblDebugTBD13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD12
        '
        Me.LblDebugTBD12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD12.Location = New System.Drawing.Point(950, 662)
        Me.LblDebugTBD12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD12.Name = "LblDebugTBD12"
        Me.LblDebugTBD12.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD12.TabIndex = 599
        Me.LblDebugTBD12.Text = "TBD Debug"
        Me.LblDebugTBD12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD11
        '
        Me.LblDebugTBD11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD11.Location = New System.Drawing.Point(950, 642)
        Me.LblDebugTBD11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD11.Name = "LblDebugTBD11"
        Me.LblDebugTBD11.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD11.TabIndex = 598
        Me.LblDebugTBD11.Text = "TBD Debug"
        Me.LblDebugTBD11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD10
        '
        Me.LblDebugTBD10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD10.Location = New System.Drawing.Point(950, 622)
        Me.LblDebugTBD10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD10.Name = "LblDebugTBD10"
        Me.LblDebugTBD10.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD10.TabIndex = 597
        Me.LblDebugTBD10.Text = "TBD Debug"
        Me.LblDebugTBD10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD9
        '
        Me.LblDebugTBD9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD9.Location = New System.Drawing.Point(950, 602)
        Me.LblDebugTBD9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD9.Name = "LblDebugTBD9"
        Me.LblDebugTBD9.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD9.TabIndex = 596
        Me.LblDebugTBD9.Text = "TBD Debug"
        Me.LblDebugTBD9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD8
        '
        Me.LblDebugTBD8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD8.Location = New System.Drawing.Point(950, 582)
        Me.LblDebugTBD8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD8.Name = "LblDebugTBD8"
        Me.LblDebugTBD8.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD8.TabIndex = 595
        Me.LblDebugTBD8.Text = "TBD Debug"
        Me.LblDebugTBD8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD7
        '
        Me.LblDebugTBD7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD7.Location = New System.Drawing.Point(950, 562)
        Me.LblDebugTBD7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD7.Name = "LblDebugTBD7"
        Me.LblDebugTBD7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD7.TabIndex = 594
        Me.LblDebugTBD7.Text = "TBD Debug"
        Me.LblDebugTBD7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD6
        '
        Me.LblDebugTBD6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD6.Location = New System.Drawing.Point(950, 542)
        Me.LblDebugTBD6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD6.Name = "LblDebugTBD6"
        Me.LblDebugTBD6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD6.TabIndex = 593
        Me.LblDebugTBD6.Text = "TBD Debug"
        Me.LblDebugTBD6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD5
        '
        Me.LblDebugTBD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD5.Location = New System.Drawing.Point(950, 522)
        Me.LblDebugTBD5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD5.Name = "LblDebugTBD5"
        Me.LblDebugTBD5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD5.TabIndex = 592
        Me.LblDebugTBD5.Text = "TBD Debug"
        Me.LblDebugTBD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD4
        '
        Me.LblDebugTBD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD4.Location = New System.Drawing.Point(950, 502)
        Me.LblDebugTBD4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD4.Name = "LblDebugTBD4"
        Me.LblDebugTBD4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD4.TabIndex = 591
        Me.LblDebugTBD4.Text = "TBD Debug"
        Me.LblDebugTBD4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD3
        '
        Me.LblDebugTBD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD3.Location = New System.Drawing.Point(950, 482)
        Me.LblDebugTBD3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD3.Name = "LblDebugTBD3"
        Me.LblDebugTBD3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD3.TabIndex = 590
        Me.LblDebugTBD3.Text = "TBD Debug"
        Me.LblDebugTBD3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD2
        '
        Me.LblDebugTBD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD2.Location = New System.Drawing.Point(950, 462)
        Me.LblDebugTBD2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD2.Name = "LblDebugTBD2"
        Me.LblDebugTBD2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD2.TabIndex = 589
        Me.LblDebugTBD2.Text = "TBD Debug"
        Me.LblDebugTBD2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD1
        '
        Me.LblDebugTBD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD1.Location = New System.Drawing.Point(950, 442)
        Me.LblDebugTBD1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD1.Name = "LblDebugTBD1"
        Me.LblDebugTBD1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD1.TabIndex = 588
        Me.LblDebugTBD1.Text = "TBD Debug"
        Me.LblDebugTBD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugTBD0
        '
        Me.LblDebugTBD0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugTBD0.Location = New System.Drawing.Point(950, 422)
        Me.LblDebugTBD0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugTBD0.Name = "LblDebugTBD0"
        Me.LblDebugTBD0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugTBD0.TabIndex = 587
        Me.LblDebugTBD0.Text = "TBD Debug"
        Me.LblDebugTBD0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal3ExtOffset
        '
        Me.LblDebugCal3ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal3ExtOffset.Location = New System.Drawing.Point(1174, 384)
        Me.LblDebugCal3ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal3ExtOffset.Name = "LblDebugCal3ExtOffset"
        Me.LblDebugCal3ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal3ExtOffset.TabIndex = 586
        Me.LblDebugCal3ExtOffset.Text = "Cal Data"
        Me.LblDebugCal3ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal3ExtGain
        '
        Me.LblDebugCal3ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal3ExtGain.Location = New System.Drawing.Point(1174, 364)
        Me.LblDebugCal3ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal3ExtGain.Name = "LblDebugCal3ExtGain"
        Me.LblDebugCal3ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal3ExtGain.TabIndex = 585
        Me.LblDebugCal3ExtGain.Text = "Cal Data"
        Me.LblDebugCal3ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal3IntOffset
        '
        Me.LblDebugCal3IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal3IntOffset.Location = New System.Drawing.Point(1174, 344)
        Me.LblDebugCal3IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal3IntOffset.Name = "LblDebugCal3IntOffset"
        Me.LblDebugCal3IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal3IntOffset.TabIndex = 584
        Me.LblDebugCal3IntOffset.Text = "Cal Data"
        Me.LblDebugCal3IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal3IntGain
        '
        Me.LblDebugCal3IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal3IntGain.Location = New System.Drawing.Point(1174, 324)
        Me.LblDebugCal3IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal3IntGain.Name = "LblDebugCal3IntGain"
        Me.LblDebugCal3IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal3IntGain.TabIndex = 583
        Me.LblDebugCal3IntGain.Text = "Cal Data"
        Me.LblDebugCal3IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal2ExtOffset
        '
        Me.LblDebugCal2ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal2ExtOffset.Location = New System.Drawing.Point(1174, 304)
        Me.LblDebugCal2ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal2ExtOffset.Name = "LblDebugCal2ExtOffset"
        Me.LblDebugCal2ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal2ExtOffset.TabIndex = 582
        Me.LblDebugCal2ExtOffset.Text = "Cal Data"
        Me.LblDebugCal2ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal2ExtGain
        '
        Me.LblDebugCal2ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal2ExtGain.Location = New System.Drawing.Point(1174, 284)
        Me.LblDebugCal2ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal2ExtGain.Name = "LblDebugCal2ExtGain"
        Me.LblDebugCal2ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal2ExtGain.TabIndex = 581
        Me.LblDebugCal2ExtGain.Text = "Cal Data"
        Me.LblDebugCal2ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal2IntOffset
        '
        Me.LblDebugCal2IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal2IntOffset.Location = New System.Drawing.Point(1174, 264)
        Me.LblDebugCal2IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal2IntOffset.Name = "LblDebugCal2IntOffset"
        Me.LblDebugCal2IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal2IntOffset.TabIndex = 580
        Me.LblDebugCal2IntOffset.Text = "Cal Data"
        Me.LblDebugCal2IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal2IntGain
        '
        Me.LblDebugCal2IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal2IntGain.Location = New System.Drawing.Point(1174, 244)
        Me.LblDebugCal2IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal2IntGain.Name = "LblDebugCal2IntGain"
        Me.LblDebugCal2IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal2IntGain.TabIndex = 579
        Me.LblDebugCal2IntGain.Text = "Cal Data"
        Me.LblDebugCal2IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal1ExtOffset
        '
        Me.LblDebugCal1ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal1ExtOffset.Location = New System.Drawing.Point(1174, 224)
        Me.LblDebugCal1ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal1ExtOffset.Name = "LblDebugCal1ExtOffset"
        Me.LblDebugCal1ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal1ExtOffset.TabIndex = 578
        Me.LblDebugCal1ExtOffset.Text = "Cal Data"
        Me.LblDebugCal1ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal1ExtGain
        '
        Me.LblDebugCal1ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal1ExtGain.Location = New System.Drawing.Point(1174, 204)
        Me.LblDebugCal1ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal1ExtGain.Name = "LblDebugCal1ExtGain"
        Me.LblDebugCal1ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal1ExtGain.TabIndex = 577
        Me.LblDebugCal1ExtGain.Text = "Cal Data"
        Me.LblDebugCal1ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal1IntOffset
        '
        Me.LblDebugCal1IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal1IntOffset.Location = New System.Drawing.Point(1174, 184)
        Me.LblDebugCal1IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal1IntOffset.Name = "LblDebugCal1IntOffset"
        Me.LblDebugCal1IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal1IntOffset.TabIndex = 576
        Me.LblDebugCal1IntOffset.Text = "Cal Data"
        Me.LblDebugCal1IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal1IntGain
        '
        Me.LblDebugCal1IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal1IntGain.Location = New System.Drawing.Point(1174, 164)
        Me.LblDebugCal1IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal1IntGain.Name = "LblDebugCal1IntGain"
        Me.LblDebugCal1IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal1IntGain.TabIndex = 575
        Me.LblDebugCal1IntGain.Text = "Cal Data"
        Me.LblDebugCal1IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal0ExtOffset
        '
        Me.LblDebugCal0ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal0ExtOffset.Location = New System.Drawing.Point(1174, 144)
        Me.LblDebugCal0ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal0ExtOffset.Name = "LblDebugCal0ExtOffset"
        Me.LblDebugCal0ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal0ExtOffset.TabIndex = 574
        Me.LblDebugCal0ExtOffset.Text = "Cal Data"
        Me.LblDebugCal0ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal0ExtGain
        '
        Me.LblDebugCal0ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal0ExtGain.Location = New System.Drawing.Point(1174, 124)
        Me.LblDebugCal0ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal0ExtGain.Name = "LblDebugCal0ExtGain"
        Me.LblDebugCal0ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal0ExtGain.TabIndex = 573
        Me.LblDebugCal0ExtGain.Text = "Cal Data"
        Me.LblDebugCal0ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal0IntOffset
        '
        Me.LblDebugCal0IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal0IntOffset.Location = New System.Drawing.Point(1174, 104)
        Me.LblDebugCal0IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal0IntOffset.Name = "LblDebugCal0IntOffset"
        Me.LblDebugCal0IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal0IntOffset.TabIndex = 572
        Me.LblDebugCal0IntOffset.Text = "Cal Data"
        Me.LblDebugCal0IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal0IntGain
        '
        Me.LblDebugCal0IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal0IntGain.Location = New System.Drawing.Point(1174, 84)
        Me.LblDebugCal0IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal0IntGain.Name = "LblDebugCal0IntGain"
        Me.LblDebugCal0IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal0IntGain.TabIndex = 571
        Me.LblDebugCal0IntGain.Text = "Cal Data"
        Me.LblDebugCal0IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal7ExtOffset
        '
        Me.LblDebugCal7ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal7ExtOffset.Location = New System.Drawing.Point(1174, 722)
        Me.LblDebugCal7ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal7ExtOffset.Name = "LblDebugCal7ExtOffset"
        Me.LblDebugCal7ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal7ExtOffset.TabIndex = 570
        Me.LblDebugCal7ExtOffset.Text = "Cal Data"
        Me.LblDebugCal7ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal7ExtGain
        '
        Me.LblDebugCal7ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal7ExtGain.Location = New System.Drawing.Point(1174, 702)
        Me.LblDebugCal7ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal7ExtGain.Name = "LblDebugCal7ExtGain"
        Me.LblDebugCal7ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal7ExtGain.TabIndex = 569
        Me.LblDebugCal7ExtGain.Text = "Cal Data"
        Me.LblDebugCal7ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal7IntOffset
        '
        Me.LblDebugCal7IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal7IntOffset.Location = New System.Drawing.Point(1174, 682)
        Me.LblDebugCal7IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal7IntOffset.Name = "LblDebugCal7IntOffset"
        Me.LblDebugCal7IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal7IntOffset.TabIndex = 568
        Me.LblDebugCal7IntOffset.Text = "Cal Data"
        Me.LblDebugCal7IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal7IntGain
        '
        Me.LblDebugCal7IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal7IntGain.Location = New System.Drawing.Point(1174, 662)
        Me.LblDebugCal7IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal7IntGain.Name = "LblDebugCal7IntGain"
        Me.LblDebugCal7IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal7IntGain.TabIndex = 567
        Me.LblDebugCal7IntGain.Text = "Cal Data"
        Me.LblDebugCal7IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal6ExtOffset
        '
        Me.LblDebugCal6ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal6ExtOffset.Location = New System.Drawing.Point(1174, 642)
        Me.LblDebugCal6ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal6ExtOffset.Name = "LblDebugCal6ExtOffset"
        Me.LblDebugCal6ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal6ExtOffset.TabIndex = 566
        Me.LblDebugCal6ExtOffset.Text = "Cal Data"
        Me.LblDebugCal6ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal6ExtGain
        '
        Me.LblDebugCal6ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal6ExtGain.Location = New System.Drawing.Point(1174, 622)
        Me.LblDebugCal6ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal6ExtGain.Name = "LblDebugCal6ExtGain"
        Me.LblDebugCal6ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal6ExtGain.TabIndex = 565
        Me.LblDebugCal6ExtGain.Text = "Cal Data"
        Me.LblDebugCal6ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal6IntOffset
        '
        Me.LblDebugCal6IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal6IntOffset.Location = New System.Drawing.Point(1174, 602)
        Me.LblDebugCal6IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal6IntOffset.Name = "LblDebugCal6IntOffset"
        Me.LblDebugCal6IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal6IntOffset.TabIndex = 564
        Me.LblDebugCal6IntOffset.Text = "Cal Data"
        Me.LblDebugCal6IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal6IntGain
        '
        Me.LblDebugCal6IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal6IntGain.Location = New System.Drawing.Point(1174, 582)
        Me.LblDebugCal6IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal6IntGain.Name = "LblDebugCal6IntGain"
        Me.LblDebugCal6IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal6IntGain.TabIndex = 563
        Me.LblDebugCal6IntGain.Text = "Cal Data"
        Me.LblDebugCal6IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal5ExtOffset
        '
        Me.LblDebugCal5ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal5ExtOffset.Location = New System.Drawing.Point(1174, 562)
        Me.LblDebugCal5ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal5ExtOffset.Name = "LblDebugCal5ExtOffset"
        Me.LblDebugCal5ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal5ExtOffset.TabIndex = 562
        Me.LblDebugCal5ExtOffset.Text = "Cal Data"
        Me.LblDebugCal5ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal5ExtGain
        '
        Me.LblDebugCal5ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal5ExtGain.Location = New System.Drawing.Point(1174, 542)
        Me.LblDebugCal5ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal5ExtGain.Name = "LblDebugCal5ExtGain"
        Me.LblDebugCal5ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal5ExtGain.TabIndex = 561
        Me.LblDebugCal5ExtGain.Text = "Cal Data"
        Me.LblDebugCal5ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal5IntOffset
        '
        Me.LblDebugCal5IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal5IntOffset.Location = New System.Drawing.Point(1174, 522)
        Me.LblDebugCal5IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal5IntOffset.Name = "LblDebugCal5IntOffset"
        Me.LblDebugCal5IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal5IntOffset.TabIndex = 560
        Me.LblDebugCal5IntOffset.Text = "Cal Data"
        Me.LblDebugCal5IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal5IntGain
        '
        Me.LblDebugCal5IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal5IntGain.Location = New System.Drawing.Point(1174, 502)
        Me.LblDebugCal5IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal5IntGain.Name = "LblDebugCal5IntGain"
        Me.LblDebugCal5IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal5IntGain.TabIndex = 559
        Me.LblDebugCal5IntGain.Text = "Cal Data"
        Me.LblDebugCal5IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal4ExtOffset
        '
        Me.LblDebugCal4ExtOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal4ExtOffset.Location = New System.Drawing.Point(1174, 482)
        Me.LblDebugCal4ExtOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal4ExtOffset.Name = "LblDebugCal4ExtOffset"
        Me.LblDebugCal4ExtOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal4ExtOffset.TabIndex = 558
        Me.LblDebugCal4ExtOffset.Text = "Cal Data"
        Me.LblDebugCal4ExtOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal4ExtGain
        '
        Me.LblDebugCal4ExtGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal4ExtGain.Location = New System.Drawing.Point(1174, 462)
        Me.LblDebugCal4ExtGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal4ExtGain.Name = "LblDebugCal4ExtGain"
        Me.LblDebugCal4ExtGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal4ExtGain.TabIndex = 557
        Me.LblDebugCal4ExtGain.Text = "Cal Data"
        Me.LblDebugCal4ExtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal4IntOffset
        '
        Me.LblDebugCal4IntOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal4IntOffset.Location = New System.Drawing.Point(1174, 442)
        Me.LblDebugCal4IntOffset.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal4IntOffset.Name = "LblDebugCal4IntOffset"
        Me.LblDebugCal4IntOffset.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal4IntOffset.TabIndex = 556
        Me.LblDebugCal4IntOffset.Text = "Cal Data"
        Me.LblDebugCal4IntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCal4IntGain
        '
        Me.LblDebugCal4IntGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCal4IntGain.Location = New System.Drawing.Point(1174, 422)
        Me.LblDebugCal4IntGain.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCal4IntGain.Name = "LblDebugCal4IntGain"
        Me.LblDebugCal4IntGain.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCal4IntGain.TabIndex = 555
        Me.LblDebugCal4IntGain.Text = "Cal Data"
        Me.LblDebugCal4IntGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom15
        '
        Me.LblDebugEEprom15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom15.Location = New System.Drawing.Point(950, 384)
        Me.LblDebugEEprom15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom15.Name = "LblDebugEEprom15"
        Me.LblDebugEEprom15.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom15.TabIndex = 554
        Me.LblDebugEEprom15.Text = "EEprom Debug"
        Me.LblDebugEEprom15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom14
        '
        Me.LblDebugEEprom14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom14.Location = New System.Drawing.Point(950, 364)
        Me.LblDebugEEprom14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom14.Name = "LblDebugEEprom14"
        Me.LblDebugEEprom14.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom14.TabIndex = 553
        Me.LblDebugEEprom14.Text = "EEprom Debug"
        Me.LblDebugEEprom14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom13
        '
        Me.LblDebugEEprom13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom13.Location = New System.Drawing.Point(950, 344)
        Me.LblDebugEEprom13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom13.Name = "LblDebugEEprom13"
        Me.LblDebugEEprom13.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom13.TabIndex = 552
        Me.LblDebugEEprom13.Text = "EEprom Debug"
        Me.LblDebugEEprom13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom12
        '
        Me.LblDebugEEprom12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom12.Location = New System.Drawing.Point(950, 324)
        Me.LblDebugEEprom12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom12.Name = "LblDebugEEprom12"
        Me.LblDebugEEprom12.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom12.TabIndex = 551
        Me.LblDebugEEprom12.Text = "EEprom Debug"
        Me.LblDebugEEprom12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom11
        '
        Me.LblDebugEEprom11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom11.Location = New System.Drawing.Point(950, 304)
        Me.LblDebugEEprom11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom11.Name = "LblDebugEEprom11"
        Me.LblDebugEEprom11.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom11.TabIndex = 550
        Me.LblDebugEEprom11.Text = "EEprom Debug"
        Me.LblDebugEEprom11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom10
        '
        Me.LblDebugEEprom10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom10.Location = New System.Drawing.Point(950, 284)
        Me.LblDebugEEprom10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom10.Name = "LblDebugEEprom10"
        Me.LblDebugEEprom10.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom10.TabIndex = 549
        Me.LblDebugEEprom10.Text = "EEprom Debug"
        Me.LblDebugEEprom10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom9
        '
        Me.LblDebugEEprom9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom9.Location = New System.Drawing.Point(950, 264)
        Me.LblDebugEEprom9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom9.Name = "LblDebugEEprom9"
        Me.LblDebugEEprom9.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom9.TabIndex = 548
        Me.LblDebugEEprom9.Text = "EEprom Debug"
        Me.LblDebugEEprom9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom8
        '
        Me.LblDebugEEprom8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom8.Location = New System.Drawing.Point(950, 244)
        Me.LblDebugEEprom8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom8.Name = "LblDebugEEprom8"
        Me.LblDebugEEprom8.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom8.TabIndex = 547
        Me.LblDebugEEprom8.Text = "EEprom Debug"
        Me.LblDebugEEprom8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom7
        '
        Me.LblDebugEEprom7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom7.Location = New System.Drawing.Point(950, 224)
        Me.LblDebugEEprom7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom7.Name = "LblDebugEEprom7"
        Me.LblDebugEEprom7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom7.TabIndex = 546
        Me.LblDebugEEprom7.Text = "EEprom Debug"
        Me.LblDebugEEprom7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom6
        '
        Me.LblDebugEEprom6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom6.Location = New System.Drawing.Point(950, 204)
        Me.LblDebugEEprom6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom6.Name = "LblDebugEEprom6"
        Me.LblDebugEEprom6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom6.TabIndex = 545
        Me.LblDebugEEprom6.Text = "EEprom Debug"
        Me.LblDebugEEprom6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom5
        '
        Me.LblDebugEEprom5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom5.Location = New System.Drawing.Point(950, 184)
        Me.LblDebugEEprom5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom5.Name = "LblDebugEEprom5"
        Me.LblDebugEEprom5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom5.TabIndex = 544
        Me.LblDebugEEprom5.Text = "EEprom Debug"
        Me.LblDebugEEprom5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom4
        '
        Me.LblDebugEEprom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom4.Location = New System.Drawing.Point(950, 164)
        Me.LblDebugEEprom4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom4.Name = "LblDebugEEprom4"
        Me.LblDebugEEprom4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom4.TabIndex = 543
        Me.LblDebugEEprom4.Text = "EEprom Debug"
        Me.LblDebugEEprom4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom3
        '
        Me.LblDebugEEprom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom3.Location = New System.Drawing.Point(950, 144)
        Me.LblDebugEEprom3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom3.Name = "LblDebugEEprom3"
        Me.LblDebugEEprom3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom3.TabIndex = 542
        Me.LblDebugEEprom3.Text = "EEprom Debug"
        Me.LblDebugEEprom3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom2
        '
        Me.LblDebugEEprom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom2.Location = New System.Drawing.Point(950, 124)
        Me.LblDebugEEprom2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom2.Name = "LblDebugEEprom2"
        Me.LblDebugEEprom2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom2.TabIndex = 541
        Me.LblDebugEEprom2.Text = "EEprom Debug"
        Me.LblDebugEEprom2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom1
        '
        Me.LblDebugEEprom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom1.Location = New System.Drawing.Point(950, 104)
        Me.LblDebugEEprom1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom1.Name = "LblDebugEEprom1"
        Me.LblDebugEEprom1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom1.TabIndex = 540
        Me.LblDebugEEprom1.Text = "EEprom Debug"
        Me.LblDebugEEprom1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugEEprom0
        '
        Me.LblDebugEEprom0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugEEprom0.Location = New System.Drawing.Point(950, 84)
        Me.LblDebugEEprom0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugEEprom0.Name = "LblDebugEEprom0"
        Me.LblDebugEEprom0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugEEprom0.TabIndex = 539
        Me.LblDebugEEprom0.Text = "EEprom Debug"
        Me.LblDebugEEprom0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanF
        '
        Me.LblDebugCanF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanF.Location = New System.Drawing.Point(726, 722)
        Me.LblDebugCanF.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanF.Name = "LblDebugCanF"
        Me.LblDebugCanF.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanF.TabIndex = 538
        Me.LblDebugCanF.Text = "Can Debug"
        Me.LblDebugCanF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanE
        '
        Me.LblDebugCanE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanE.Location = New System.Drawing.Point(726, 702)
        Me.LblDebugCanE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanE.Name = "LblDebugCanE"
        Me.LblDebugCanE.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanE.TabIndex = 537
        Me.LblDebugCanE.Text = "Can Debug"
        Me.LblDebugCanE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanD
        '
        Me.LblDebugCanD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanD.Location = New System.Drawing.Point(726, 682)
        Me.LblDebugCanD.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanD.Name = "LblDebugCanD"
        Me.LblDebugCanD.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanD.TabIndex = 536
        Me.LblDebugCanD.Text = "Can Debug"
        Me.LblDebugCanD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanC
        '
        Me.LblDebugCanC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanC.Location = New System.Drawing.Point(726, 662)
        Me.LblDebugCanC.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanC.Name = "LblDebugCanC"
        Me.LblDebugCanC.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanC.TabIndex = 535
        Me.LblDebugCanC.Text = "Can Debug"
        Me.LblDebugCanC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanB
        '
        Me.LblDebugCanB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanB.Location = New System.Drawing.Point(726, 642)
        Me.LblDebugCanB.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanB.Name = "LblDebugCanB"
        Me.LblDebugCanB.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanB.TabIndex = 534
        Me.LblDebugCanB.Text = "Can Debug"
        Me.LblDebugCanB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCanA
        '
        Me.LblDebugCanA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCanA.Location = New System.Drawing.Point(726, 622)
        Me.LblDebugCanA.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCanA.Name = "LblDebugCanA"
        Me.LblDebugCanA.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCanA.TabIndex = 533
        Me.LblDebugCanA.Text = "Can Debug"
        Me.LblDebugCanA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan9
        '
        Me.LblDebugCan9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan9.Location = New System.Drawing.Point(726, 602)
        Me.LblDebugCan9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan9.Name = "LblDebugCan9"
        Me.LblDebugCan9.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan9.TabIndex = 532
        Me.LblDebugCan9.Text = "Can Debug"
        Me.LblDebugCan9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan8
        '
        Me.LblDebugCan8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan8.Location = New System.Drawing.Point(726, 582)
        Me.LblDebugCan8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan8.Name = "LblDebugCan8"
        Me.LblDebugCan8.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan8.TabIndex = 531
        Me.LblDebugCan8.Text = "Can Debug"
        Me.LblDebugCan8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan7
        '
        Me.LblDebugCan7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan7.Location = New System.Drawing.Point(726, 562)
        Me.LblDebugCan7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan7.Name = "LblDebugCan7"
        Me.LblDebugCan7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan7.TabIndex = 530
        Me.LblDebugCan7.Text = "Can Debug"
        Me.LblDebugCan7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan6
        '
        Me.LblDebugCan6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan6.Location = New System.Drawing.Point(726, 542)
        Me.LblDebugCan6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan6.Name = "LblDebugCan6"
        Me.LblDebugCan6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan6.TabIndex = 529
        Me.LblDebugCan6.Text = "Can Debug"
        Me.LblDebugCan6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan5
        '
        Me.LblDebugCan5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan5.Location = New System.Drawing.Point(726, 522)
        Me.LblDebugCan5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan5.Name = "LblDebugCan5"
        Me.LblDebugCan5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan5.TabIndex = 528
        Me.LblDebugCan5.Text = "Can Debug"
        Me.LblDebugCan5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan4
        '
        Me.LblDebugCan4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan4.Location = New System.Drawing.Point(726, 502)
        Me.LblDebugCan4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan4.Name = "LblDebugCan4"
        Me.LblDebugCan4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan4.TabIndex = 527
        Me.LblDebugCan4.Text = "Can Debug"
        Me.LblDebugCan4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan3
        '
        Me.LblDebugCan3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan3.Location = New System.Drawing.Point(726, 482)
        Me.LblDebugCan3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan3.Name = "LblDebugCan3"
        Me.LblDebugCan3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan3.TabIndex = 526
        Me.LblDebugCan3.Text = "Can Debug"
        Me.LblDebugCan3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan2
        '
        Me.LblDebugCan2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan2.Location = New System.Drawing.Point(726, 462)
        Me.LblDebugCan2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan2.Name = "LblDebugCan2"
        Me.LblDebugCan2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan2.TabIndex = 525
        Me.LblDebugCan2.Text = "Can Debug"
        Me.LblDebugCan2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan1
        '
        Me.LblDebugCan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan1.Location = New System.Drawing.Point(726, 442)
        Me.LblDebugCan1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan1.Name = "LblDebugCan1"
        Me.LblDebugCan1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan1.TabIndex = 524
        Me.LblDebugCan1.Text = "Can Debug"
        Me.LblDebugCan1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugCan0
        '
        Me.LblDebugCan0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugCan0.Location = New System.Drawing.Point(726, 422)
        Me.LblDebugCan0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugCan0.Name = "LblDebugCan0"
        Me.LblDebugCan0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugCan0.TabIndex = 523
        Me.LblDebugCan0.Text = "Can Debug"
        Me.LblDebugCan0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegF
        '
        Me.LblDebugRegF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegF.Location = New System.Drawing.Point(726, 384)
        Me.LblDebugRegF.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegF.Name = "LblDebugRegF"
        Me.LblDebugRegF.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegF.TabIndex = 522
        Me.LblDebugRegF.Text = "Debug Reg"
        Me.LblDebugRegF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegE
        '
        Me.LblDebugRegE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegE.Location = New System.Drawing.Point(726, 364)
        Me.LblDebugRegE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegE.Name = "LblDebugRegE"
        Me.LblDebugRegE.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegE.TabIndex = 521
        Me.LblDebugRegE.Text = "Debug Reg"
        Me.LblDebugRegE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegD
        '
        Me.LblDebugRegD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegD.Location = New System.Drawing.Point(726, 344)
        Me.LblDebugRegD.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegD.Name = "LblDebugRegD"
        Me.LblDebugRegD.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegD.TabIndex = 520
        Me.LblDebugRegD.Text = "Debug Reg"
        Me.LblDebugRegD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegC
        '
        Me.LblDebugRegC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegC.Location = New System.Drawing.Point(726, 324)
        Me.LblDebugRegC.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegC.Name = "LblDebugRegC"
        Me.LblDebugRegC.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegC.TabIndex = 519
        Me.LblDebugRegC.Text = "Debug Reg"
        Me.LblDebugRegC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegB
        '
        Me.LblDebugRegB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegB.Location = New System.Drawing.Point(726, 304)
        Me.LblDebugRegB.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegB.Name = "LblDebugRegB"
        Me.LblDebugRegB.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegB.TabIndex = 518
        Me.LblDebugRegB.Text = "Debug Reg"
        Me.LblDebugRegB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugRegA
        '
        Me.LblDebugRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugRegA.Location = New System.Drawing.Point(726, 284)
        Me.LblDebugRegA.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugRegA.Name = "LblDebugRegA"
        Me.LblDebugRegA.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugRegA.TabIndex = 517
        Me.LblDebugRegA.Text = "Debug Reg"
        Me.LblDebugRegA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg9
        '
        Me.LblDebugReg9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg9.Location = New System.Drawing.Point(726, 264)
        Me.LblDebugReg9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg9.Name = "LblDebugReg9"
        Me.LblDebugReg9.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg9.TabIndex = 516
        Me.LblDebugReg9.Text = "Debug Reg"
        Me.LblDebugReg9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg8
        '
        Me.LblDebugReg8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg8.Location = New System.Drawing.Point(726, 244)
        Me.LblDebugReg8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg8.Name = "LblDebugReg8"
        Me.LblDebugReg8.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg8.TabIndex = 515
        Me.LblDebugReg8.Text = "Debug Reg"
        Me.LblDebugReg8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg7
        '
        Me.LblDebugReg7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg7.Location = New System.Drawing.Point(726, 224)
        Me.LblDebugReg7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg7.Name = "LblDebugReg7"
        Me.LblDebugReg7.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg7.TabIndex = 514
        Me.LblDebugReg7.Text = "Debug Reg"
        Me.LblDebugReg7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg6
        '
        Me.LblDebugReg6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg6.Location = New System.Drawing.Point(726, 204)
        Me.LblDebugReg6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg6.Name = "LblDebugReg6"
        Me.LblDebugReg6.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg6.TabIndex = 513
        Me.LblDebugReg6.Text = "Debug Reg"
        Me.LblDebugReg6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg5
        '
        Me.LblDebugReg5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg5.Location = New System.Drawing.Point(726, 184)
        Me.LblDebugReg5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg5.Name = "LblDebugReg5"
        Me.LblDebugReg5.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg5.TabIndex = 512
        Me.LblDebugReg5.Text = "Debug Reg"
        Me.LblDebugReg5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg4
        '
        Me.LblDebugReg4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg4.Location = New System.Drawing.Point(726, 164)
        Me.LblDebugReg4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg4.Name = "LblDebugReg4"
        Me.LblDebugReg4.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg4.TabIndex = 511
        Me.LblDebugReg4.Text = "Debug Reg"
        Me.LblDebugReg4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg3
        '
        Me.LblDebugReg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg3.Location = New System.Drawing.Point(726, 144)
        Me.LblDebugReg3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg3.Name = "LblDebugReg3"
        Me.LblDebugReg3.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg3.TabIndex = 510
        Me.LblDebugReg3.Text = "Debug Reg"
        Me.LblDebugReg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg2
        '
        Me.LblDebugReg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg2.Location = New System.Drawing.Point(726, 124)
        Me.LblDebugReg2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg2.Name = "LblDebugReg2"
        Me.LblDebugReg2.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg2.TabIndex = 509
        Me.LblDebugReg2.Text = "Debug Reg"
        Me.LblDebugReg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg1
        '
        Me.LblDebugReg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg1.Location = New System.Drawing.Point(726, 104)
        Me.LblDebugReg1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg1.Name = "LblDebugReg1"
        Me.LblDebugReg1.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg1.TabIndex = 508
        Me.LblDebugReg1.Text = "Debug Reg"
        Me.LblDebugReg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDebugReg0
        '
        Me.LblDebugReg0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugReg0.Location = New System.Drawing.Point(726, 84)
        Me.LblDebugReg0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblDebugReg0.Name = "LblDebugReg0"
        Me.LblDebugReg0.Size = New System.Drawing.Size(218, 16)
        Me.LblDebugReg0.TabIndex = 507
        Me.LblDebugReg0.Text = "Debug Reg"
        Me.LblDebugReg0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue23
        '
        Me.LblSlaveLogValue23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue23.Location = New System.Drawing.Point(591, 682)
        Me.LblSlaveLogValue23.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue23.Name = "LblSlaveLogValue23"
        Me.LblSlaveLogValue23.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue23.TabIndex = 506
        Me.LblSlaveLogValue23.Text = "Value = ???"
        Me.LblSlaveLogValue23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue15
        '
        Me.LblSlaveLogValue15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue15.Location = New System.Drawing.Point(591, 474)
        Me.LblSlaveLogValue15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue15.Name = "LblSlaveLogValue15"
        Me.LblSlaveLogValue15.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue15.TabIndex = 498
        Me.LblSlaveLogValue15.Text = "Value = ???"
        Me.LblSlaveLogValue15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue16
        '
        Me.LblSlaveLogValue16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue16.Location = New System.Drawing.Point(591, 500)
        Me.LblSlaveLogValue16.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue16.Name = "LblSlaveLogValue16"
        Me.LblSlaveLogValue16.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue16.TabIndex = 499
        Me.LblSlaveLogValue16.Text = "Value = ???"
        Me.LblSlaveLogValue16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue17
        '
        Me.LblSlaveLogValue17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue17.Location = New System.Drawing.Point(591, 526)
        Me.LblSlaveLogValue17.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue17.Name = "LblSlaveLogValue17"
        Me.LblSlaveLogValue17.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue17.TabIndex = 500
        Me.LblSlaveLogValue17.Text = "Value = ???"
        Me.LblSlaveLogValue17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue18
        '
        Me.LblSlaveLogValue18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue18.Location = New System.Drawing.Point(591, 552)
        Me.LblSlaveLogValue18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue18.Name = "LblSlaveLogValue18"
        Me.LblSlaveLogValue18.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue18.TabIndex = 501
        Me.LblSlaveLogValue18.Text = "Value = ???"
        Me.LblSlaveLogValue18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue19
        '
        Me.LblSlaveLogValue19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue19.Location = New System.Drawing.Point(591, 578)
        Me.LblSlaveLogValue19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue19.Name = "LblSlaveLogValue19"
        Me.LblSlaveLogValue19.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue19.TabIndex = 502
        Me.LblSlaveLogValue19.Text = "Value = ???"
        Me.LblSlaveLogValue19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue20
        '
        Me.LblSlaveLogValue20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue20.Location = New System.Drawing.Point(591, 604)
        Me.LblSlaveLogValue20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue20.Name = "LblSlaveLogValue20"
        Me.LblSlaveLogValue20.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue20.TabIndex = 503
        Me.LblSlaveLogValue20.Text = "Value = ???"
        Me.LblSlaveLogValue20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue21
        '
        Me.LblSlaveLogValue21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue21.Location = New System.Drawing.Point(591, 630)
        Me.LblSlaveLogValue21.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue21.Name = "LblSlaveLogValue21"
        Me.LblSlaveLogValue21.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue21.TabIndex = 504
        Me.LblSlaveLogValue21.Text = "Value = ???"
        Me.LblSlaveLogValue21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue22
        '
        Me.LblSlaveLogValue22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue22.Location = New System.Drawing.Point(591, 656)
        Me.LblSlaveLogValue22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue22.Name = "LblSlaveLogValue22"
        Me.LblSlaveLogValue22.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue22.TabIndex = 505
        Me.LblSlaveLogValue22.Text = "Value = ???"
        Me.LblSlaveLogValue22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue0
        '
        Me.LblSlaveLogValue0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue0.Location = New System.Drawing.Point(591, 84)
        Me.LblSlaveLogValue0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue0.Name = "LblSlaveLogValue0"
        Me.LblSlaveLogValue0.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue0.TabIndex = 483
        Me.LblSlaveLogValue0.Text = "Value = ???"
        Me.LblSlaveLogValue0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue1
        '
        Me.LblSlaveLogValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue1.Location = New System.Drawing.Point(591, 110)
        Me.LblSlaveLogValue1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue1.Name = "LblSlaveLogValue1"
        Me.LblSlaveLogValue1.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue1.TabIndex = 484
        Me.LblSlaveLogValue1.Text = "Value = ???"
        Me.LblSlaveLogValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue2
        '
        Me.LblSlaveLogValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue2.Location = New System.Drawing.Point(591, 136)
        Me.LblSlaveLogValue2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue2.Name = "LblSlaveLogValue2"
        Me.LblSlaveLogValue2.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue2.TabIndex = 485
        Me.LblSlaveLogValue2.Text = "Value = ???"
        Me.LblSlaveLogValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue3
        '
        Me.LblSlaveLogValue3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue3.Location = New System.Drawing.Point(591, 162)
        Me.LblSlaveLogValue3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue3.Name = "LblSlaveLogValue3"
        Me.LblSlaveLogValue3.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue3.TabIndex = 486
        Me.LblSlaveLogValue3.Text = "Value = ???"
        Me.LblSlaveLogValue3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue4
        '
        Me.LblSlaveLogValue4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue4.Location = New System.Drawing.Point(591, 188)
        Me.LblSlaveLogValue4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue4.Name = "LblSlaveLogValue4"
        Me.LblSlaveLogValue4.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue4.TabIndex = 487
        Me.LblSlaveLogValue4.Text = "Value = ???"
        Me.LblSlaveLogValue4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue5
        '
        Me.LblSlaveLogValue5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue5.Location = New System.Drawing.Point(591, 214)
        Me.LblSlaveLogValue5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue5.Name = "LblSlaveLogValue5"
        Me.LblSlaveLogValue5.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue5.TabIndex = 488
        Me.LblSlaveLogValue5.Text = "Value = ???"
        Me.LblSlaveLogValue5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue6
        '
        Me.LblSlaveLogValue6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue6.Location = New System.Drawing.Point(591, 240)
        Me.LblSlaveLogValue6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue6.Name = "LblSlaveLogValue6"
        Me.LblSlaveLogValue6.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue6.TabIndex = 489
        Me.LblSlaveLogValue6.Text = "Value = ???"
        Me.LblSlaveLogValue6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue7
        '
        Me.LblSlaveLogValue7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue7.Location = New System.Drawing.Point(591, 266)
        Me.LblSlaveLogValue7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue7.Name = "LblSlaveLogValue7"
        Me.LblSlaveLogValue7.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue7.TabIndex = 490
        Me.LblSlaveLogValue7.Text = "Value = ???"
        Me.LblSlaveLogValue7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue8
        '
        Me.LblSlaveLogValue8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue8.Location = New System.Drawing.Point(591, 292)
        Me.LblSlaveLogValue8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue8.Name = "LblSlaveLogValue8"
        Me.LblSlaveLogValue8.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue8.TabIndex = 491
        Me.LblSlaveLogValue8.Text = "Value = ???"
        Me.LblSlaveLogValue8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue9
        '
        Me.LblSlaveLogValue9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue9.Location = New System.Drawing.Point(591, 318)
        Me.LblSlaveLogValue9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue9.Name = "LblSlaveLogValue9"
        Me.LblSlaveLogValue9.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue9.TabIndex = 492
        Me.LblSlaveLogValue9.Text = "Value = ???"
        Me.LblSlaveLogValue9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue10
        '
        Me.LblSlaveLogValue10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue10.Location = New System.Drawing.Point(591, 344)
        Me.LblSlaveLogValue10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue10.Name = "LblSlaveLogValue10"
        Me.LblSlaveLogValue10.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue10.TabIndex = 493
        Me.LblSlaveLogValue10.Text = "Value = ???"
        Me.LblSlaveLogValue10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue11
        '
        Me.LblSlaveLogValue11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue11.Location = New System.Drawing.Point(591, 370)
        Me.LblSlaveLogValue11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue11.Name = "LblSlaveLogValue11"
        Me.LblSlaveLogValue11.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue11.TabIndex = 494
        Me.LblSlaveLogValue11.Text = "Value = ???"
        Me.LblSlaveLogValue11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue12
        '
        Me.LblSlaveLogValue12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue12.Location = New System.Drawing.Point(591, 396)
        Me.LblSlaveLogValue12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue12.Name = "LblSlaveLogValue12"
        Me.LblSlaveLogValue12.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue12.TabIndex = 495
        Me.LblSlaveLogValue12.Text = "Value = ???"
        Me.LblSlaveLogValue12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue13
        '
        Me.LblSlaveLogValue13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue13.Location = New System.Drawing.Point(591, 422)
        Me.LblSlaveLogValue13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue13.Name = "LblSlaveLogValue13"
        Me.LblSlaveLogValue13.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue13.TabIndex = 496
        Me.LblSlaveLogValue13.Text = "Value = ???"
        Me.LblSlaveLogValue13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLogValue14
        '
        Me.LblSlaveLogValue14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLogValue14.Location = New System.Drawing.Point(591, 448)
        Me.LblSlaveLogValue14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLogValue14.Name = "LblSlaveLogValue14"
        Me.LblSlaveLogValue14.Size = New System.Drawing.Size(103, 16)
        Me.LblSlaveLogValue14.TabIndex = 497
        Me.LblSlaveLogValue14.Text = "Value = ???"
        Me.LblSlaveLogValue14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog23
        '
        Me.LblSlaveLog23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog23.Location = New System.Drawing.Point(385, 682)
        Me.LblSlaveLog23.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog23.Name = "LblSlaveLog23"
        Me.LblSlaveLog23.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog23.TabIndex = 482
        Me.LblSlaveLog23.Text = "Log Data 23"
        Me.LblSlaveLog23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog15
        '
        Me.LblSlaveLog15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog15.Location = New System.Drawing.Point(385, 474)
        Me.LblSlaveLog15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog15.Name = "LblSlaveLog15"
        Me.LblSlaveLog15.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog15.TabIndex = 474
        Me.LblSlaveLog15.Text = "Log Data 15"
        Me.LblSlaveLog15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog16
        '
        Me.LblSlaveLog16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog16.Location = New System.Drawing.Point(385, 500)
        Me.LblSlaveLog16.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog16.Name = "LblSlaveLog16"
        Me.LblSlaveLog16.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog16.TabIndex = 475
        Me.LblSlaveLog16.Text = "Log Data 16"
        Me.LblSlaveLog16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog17
        '
        Me.LblSlaveLog17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog17.Location = New System.Drawing.Point(385, 526)
        Me.LblSlaveLog17.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog17.Name = "LblSlaveLog17"
        Me.LblSlaveLog17.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog17.TabIndex = 476
        Me.LblSlaveLog17.Text = "Log Data 17"
        Me.LblSlaveLog17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog18
        '
        Me.LblSlaveLog18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog18.Location = New System.Drawing.Point(385, 552)
        Me.LblSlaveLog18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog18.Name = "LblSlaveLog18"
        Me.LblSlaveLog18.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog18.TabIndex = 477
        Me.LblSlaveLog18.Text = "Log Data 18"
        Me.LblSlaveLog18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog19
        '
        Me.LblSlaveLog19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog19.Location = New System.Drawing.Point(385, 578)
        Me.LblSlaveLog19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog19.Name = "LblSlaveLog19"
        Me.LblSlaveLog19.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog19.TabIndex = 478
        Me.LblSlaveLog19.Text = "Log Data 19"
        Me.LblSlaveLog19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog20
        '
        Me.LblSlaveLog20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog20.Location = New System.Drawing.Point(385, 604)
        Me.LblSlaveLog20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog20.Name = "LblSlaveLog20"
        Me.LblSlaveLog20.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog20.TabIndex = 479
        Me.LblSlaveLog20.Text = "Log Data 20"
        Me.LblSlaveLog20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog21
        '
        Me.LblSlaveLog21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog21.Location = New System.Drawing.Point(385, 630)
        Me.LblSlaveLog21.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog21.Name = "LblSlaveLog21"
        Me.LblSlaveLog21.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog21.TabIndex = 480
        Me.LblSlaveLog21.Text = "Log Data 21"
        Me.LblSlaveLog21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog22
        '
        Me.LblSlaveLog22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog22.Location = New System.Drawing.Point(385, 656)
        Me.LblSlaveLog22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog22.Name = "LblSlaveLog22"
        Me.LblSlaveLog22.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog22.TabIndex = 481
        Me.LblSlaveLog22.Text = "Log Data 22"
        Me.LblSlaveLog22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxSlaveStatusNotLoggedF
        '
        Me.CbxSlaveStatusNotLoggedF.AutoSize = True
        Me.CbxSlaveStatusNotLoggedF.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedF.Location = New System.Drawing.Point(189, 738)
        Me.CbxSlaveStatusNotLoggedF.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedF.Name = "CbxSlaveStatusNotLoggedF"
        Me.CbxSlaveStatusNotLoggedF.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedF.TabIndex = 473
        Me.CbxSlaveStatusNotLoggedF.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedF.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLoggedE
        '
        Me.CbxSlaveStatusNotLoggedE.AutoSize = True
        Me.CbxSlaveStatusNotLoggedE.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedE.Location = New System.Drawing.Point(189, 718)
        Me.CbxSlaveStatusNotLoggedE.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedE.Name = "CbxSlaveStatusNotLoggedE"
        Me.CbxSlaveStatusNotLoggedE.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedE.TabIndex = 472
        Me.CbxSlaveStatusNotLoggedE.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedE.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLoggedD
        '
        Me.CbxSlaveStatusNotLoggedD.AutoSize = True
        Me.CbxSlaveStatusNotLoggedD.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedD.Location = New System.Drawing.Point(189, 698)
        Me.CbxSlaveStatusNotLoggedD.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedD.Name = "CbxSlaveStatusNotLoggedD"
        Me.CbxSlaveStatusNotLoggedD.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedD.TabIndex = 471
        Me.CbxSlaveStatusNotLoggedD.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedD.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLoggedC
        '
        Me.CbxSlaveStatusNotLoggedC.AutoSize = True
        Me.CbxSlaveStatusNotLoggedC.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedC.Location = New System.Drawing.Point(189, 678)
        Me.CbxSlaveStatusNotLoggedC.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedC.Name = "CbxSlaveStatusNotLoggedC"
        Me.CbxSlaveStatusNotLoggedC.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedC.TabIndex = 470
        Me.CbxSlaveStatusNotLoggedC.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedC.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLoggedB
        '
        Me.CbxSlaveStatusNotLoggedB.AutoSize = True
        Me.CbxSlaveStatusNotLoggedB.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedB.Location = New System.Drawing.Point(189, 658)
        Me.CbxSlaveStatusNotLoggedB.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedB.Name = "CbxSlaveStatusNotLoggedB"
        Me.CbxSlaveStatusNotLoggedB.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedB.TabIndex = 469
        Me.CbxSlaveStatusNotLoggedB.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedB.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLoggedA
        '
        Me.CbxSlaveStatusNotLoggedA.AutoSize = True
        Me.CbxSlaveStatusNotLoggedA.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLoggedA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLoggedA.Location = New System.Drawing.Point(189, 638)
        Me.CbxSlaveStatusNotLoggedA.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLoggedA.Name = "CbxSlaveStatusNotLoggedA"
        Me.CbxSlaveStatusNotLoggedA.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLoggedA.TabIndex = 468
        Me.CbxSlaveStatusNotLoggedA.Text = "Not Log"
        Me.CbxSlaveStatusNotLoggedA.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged9
        '
        Me.CbxSlaveStatusNotLogged9.AutoSize = True
        Me.CbxSlaveStatusNotLogged9.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged9.Location = New System.Drawing.Point(189, 618)
        Me.CbxSlaveStatusNotLogged9.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged9.Name = "CbxSlaveStatusNotLogged9"
        Me.CbxSlaveStatusNotLogged9.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged9.TabIndex = 467
        Me.CbxSlaveStatusNotLogged9.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged9.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged8
        '
        Me.CbxSlaveStatusNotLogged8.AutoSize = True
        Me.CbxSlaveStatusNotLogged8.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged8.Location = New System.Drawing.Point(189, 598)
        Me.CbxSlaveStatusNotLogged8.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged8.Name = "CbxSlaveStatusNotLogged8"
        Me.CbxSlaveStatusNotLogged8.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged8.TabIndex = 466
        Me.CbxSlaveStatusNotLogged8.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged8.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged0
        '
        Me.CbxSlaveStatusNotLogged0.AutoSize = True
        Me.CbxSlaveStatusNotLogged0.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged0.Location = New System.Drawing.Point(189, 438)
        Me.CbxSlaveStatusNotLogged0.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged0.Name = "CbxSlaveStatusNotLogged0"
        Me.CbxSlaveStatusNotLogged0.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged0.TabIndex = 458
        Me.CbxSlaveStatusNotLogged0.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged0.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged7
        '
        Me.CbxSlaveStatusNotLogged7.AutoSize = True
        Me.CbxSlaveStatusNotLogged7.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged7.Location = New System.Drawing.Point(189, 578)
        Me.CbxSlaveStatusNotLogged7.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged7.Name = "CbxSlaveStatusNotLogged7"
        Me.CbxSlaveStatusNotLogged7.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged7.TabIndex = 465
        Me.CbxSlaveStatusNotLogged7.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged7.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged6
        '
        Me.CbxSlaveStatusNotLogged6.AutoSize = True
        Me.CbxSlaveStatusNotLogged6.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged6.Location = New System.Drawing.Point(189, 558)
        Me.CbxSlaveStatusNotLogged6.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged6.Name = "CbxSlaveStatusNotLogged6"
        Me.CbxSlaveStatusNotLogged6.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged6.TabIndex = 464
        Me.CbxSlaveStatusNotLogged6.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged6.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged5
        '
        Me.CbxSlaveStatusNotLogged5.AutoSize = True
        Me.CbxSlaveStatusNotLogged5.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged5.Location = New System.Drawing.Point(189, 538)
        Me.CbxSlaveStatusNotLogged5.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged5.Name = "CbxSlaveStatusNotLogged5"
        Me.CbxSlaveStatusNotLogged5.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged5.TabIndex = 463
        Me.CbxSlaveStatusNotLogged5.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged5.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged4
        '
        Me.CbxSlaveStatusNotLogged4.AutoSize = True
        Me.CbxSlaveStatusNotLogged4.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged4.Location = New System.Drawing.Point(189, 518)
        Me.CbxSlaveStatusNotLogged4.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged4.Name = "CbxSlaveStatusNotLogged4"
        Me.CbxSlaveStatusNotLogged4.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged4.TabIndex = 462
        Me.CbxSlaveStatusNotLogged4.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged4.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged3
        '
        Me.CbxSlaveStatusNotLogged3.AutoSize = True
        Me.CbxSlaveStatusNotLogged3.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged3.Location = New System.Drawing.Point(189, 498)
        Me.CbxSlaveStatusNotLogged3.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged3.Name = "CbxSlaveStatusNotLogged3"
        Me.CbxSlaveStatusNotLogged3.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged3.TabIndex = 461
        Me.CbxSlaveStatusNotLogged3.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged3.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged2
        '
        Me.CbxSlaveStatusNotLogged2.AutoSize = True
        Me.CbxSlaveStatusNotLogged2.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged2.Location = New System.Drawing.Point(189, 478)
        Me.CbxSlaveStatusNotLogged2.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged2.Name = "CbxSlaveStatusNotLogged2"
        Me.CbxSlaveStatusNotLogged2.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged2.TabIndex = 460
        Me.CbxSlaveStatusNotLogged2.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged2.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotLogged1
        '
        Me.CbxSlaveStatusNotLogged1.AutoSize = True
        Me.CbxSlaveStatusNotLogged1.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotLogged1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotLogged1.Location = New System.Drawing.Point(189, 458)
        Me.CbxSlaveStatusNotLogged1.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotLogged1.Name = "CbxSlaveStatusNotLogged1"
        Me.CbxSlaveStatusNotLogged1.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusNotLogged1.TabIndex = 459
        Me.CbxSlaveStatusNotLogged1.Text = "Not Log"
        Me.CbxSlaveStatusNotLogged1.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedF
        '
        Me.CbxSlaveStatusLoggedF.AutoSize = True
        Me.CbxSlaveStatusLoggedF.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedF.Location = New System.Drawing.Point(3, 738)
        Me.CbxSlaveStatusLoggedF.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedF.Name = "CbxSlaveStatusLoggedF"
        Me.CbxSlaveStatusLoggedF.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedF.TabIndex = 457
        Me.CbxSlaveStatusLoggedF.Text = "Logged"
        Me.CbxSlaveStatusLoggedF.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedE
        '
        Me.CbxSlaveStatusLoggedE.AutoSize = True
        Me.CbxSlaveStatusLoggedE.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedE.Location = New System.Drawing.Point(3, 718)
        Me.CbxSlaveStatusLoggedE.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedE.Name = "CbxSlaveStatusLoggedE"
        Me.CbxSlaveStatusLoggedE.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedE.TabIndex = 456
        Me.CbxSlaveStatusLoggedE.Text = "Logged"
        Me.CbxSlaveStatusLoggedE.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedD
        '
        Me.CbxSlaveStatusLoggedD.AutoSize = True
        Me.CbxSlaveStatusLoggedD.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedD.Location = New System.Drawing.Point(3, 698)
        Me.CbxSlaveStatusLoggedD.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedD.Name = "CbxSlaveStatusLoggedD"
        Me.CbxSlaveStatusLoggedD.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedD.TabIndex = 455
        Me.CbxSlaveStatusLoggedD.Text = "Logged"
        Me.CbxSlaveStatusLoggedD.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedC
        '
        Me.CbxSlaveStatusLoggedC.AutoSize = True
        Me.CbxSlaveStatusLoggedC.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedC.Location = New System.Drawing.Point(3, 678)
        Me.CbxSlaveStatusLoggedC.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedC.Name = "CbxSlaveStatusLoggedC"
        Me.CbxSlaveStatusLoggedC.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedC.TabIndex = 454
        Me.CbxSlaveStatusLoggedC.Text = "Logged"
        Me.CbxSlaveStatusLoggedC.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedB
        '
        Me.CbxSlaveStatusLoggedB.AutoSize = True
        Me.CbxSlaveStatusLoggedB.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedB.Location = New System.Drawing.Point(3, 658)
        Me.CbxSlaveStatusLoggedB.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedB.Name = "CbxSlaveStatusLoggedB"
        Me.CbxSlaveStatusLoggedB.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedB.TabIndex = 453
        Me.CbxSlaveStatusLoggedB.Text = "Logged"
        Me.CbxSlaveStatusLoggedB.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLoggedA
        '
        Me.CbxSlaveStatusLoggedA.AutoSize = True
        Me.CbxSlaveStatusLoggedA.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLoggedA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLoggedA.Location = New System.Drawing.Point(3, 638)
        Me.CbxSlaveStatusLoggedA.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLoggedA.Name = "CbxSlaveStatusLoggedA"
        Me.CbxSlaveStatusLoggedA.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLoggedA.TabIndex = 452
        Me.CbxSlaveStatusLoggedA.Text = "Logged"
        Me.CbxSlaveStatusLoggedA.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged9
        '
        Me.CbxSlaveStatusLogged9.AutoSize = True
        Me.CbxSlaveStatusLogged9.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged9.Location = New System.Drawing.Point(3, 618)
        Me.CbxSlaveStatusLogged9.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged9.Name = "CbxSlaveStatusLogged9"
        Me.CbxSlaveStatusLogged9.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged9.TabIndex = 451
        Me.CbxSlaveStatusLogged9.Text = "Logged"
        Me.CbxSlaveStatusLogged9.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged8
        '
        Me.CbxSlaveStatusLogged8.AutoSize = True
        Me.CbxSlaveStatusLogged8.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged8.Location = New System.Drawing.Point(3, 598)
        Me.CbxSlaveStatusLogged8.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged8.Name = "CbxSlaveStatusLogged8"
        Me.CbxSlaveStatusLogged8.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged8.TabIndex = 450
        Me.CbxSlaveStatusLogged8.Text = "Logged"
        Me.CbxSlaveStatusLogged8.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged0
        '
        Me.CbxSlaveStatusLogged0.AutoSize = True
        Me.CbxSlaveStatusLogged0.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged0.Location = New System.Drawing.Point(3, 438)
        Me.CbxSlaveStatusLogged0.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged0.Name = "CbxSlaveStatusLogged0"
        Me.CbxSlaveStatusLogged0.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged0.TabIndex = 442
        Me.CbxSlaveStatusLogged0.Text = "Logged"
        Me.CbxSlaveStatusLogged0.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged7
        '
        Me.CbxSlaveStatusLogged7.AutoSize = True
        Me.CbxSlaveStatusLogged7.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged7.Location = New System.Drawing.Point(3, 578)
        Me.CbxSlaveStatusLogged7.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged7.Name = "CbxSlaveStatusLogged7"
        Me.CbxSlaveStatusLogged7.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged7.TabIndex = 449
        Me.CbxSlaveStatusLogged7.Text = "Logged"
        Me.CbxSlaveStatusLogged7.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged6
        '
        Me.CbxSlaveStatusLogged6.AutoSize = True
        Me.CbxSlaveStatusLogged6.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged6.Location = New System.Drawing.Point(3, 558)
        Me.CbxSlaveStatusLogged6.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged6.Name = "CbxSlaveStatusLogged6"
        Me.CbxSlaveStatusLogged6.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged6.TabIndex = 448
        Me.CbxSlaveStatusLogged6.Text = "Logged"
        Me.CbxSlaveStatusLogged6.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged5
        '
        Me.CbxSlaveStatusLogged5.AutoSize = True
        Me.CbxSlaveStatusLogged5.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged5.Location = New System.Drawing.Point(3, 538)
        Me.CbxSlaveStatusLogged5.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged5.Name = "CbxSlaveStatusLogged5"
        Me.CbxSlaveStatusLogged5.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged5.TabIndex = 447
        Me.CbxSlaveStatusLogged5.Text = "Logged"
        Me.CbxSlaveStatusLogged5.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged4
        '
        Me.CbxSlaveStatusLogged4.AutoSize = True
        Me.CbxSlaveStatusLogged4.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged4.Location = New System.Drawing.Point(3, 518)
        Me.CbxSlaveStatusLogged4.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged4.Name = "CbxSlaveStatusLogged4"
        Me.CbxSlaveStatusLogged4.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged4.TabIndex = 446
        Me.CbxSlaveStatusLogged4.Text = "Logged"
        Me.CbxSlaveStatusLogged4.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged3
        '
        Me.CbxSlaveStatusLogged3.AutoSize = True
        Me.CbxSlaveStatusLogged3.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged3.Location = New System.Drawing.Point(3, 498)
        Me.CbxSlaveStatusLogged3.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged3.Name = "CbxSlaveStatusLogged3"
        Me.CbxSlaveStatusLogged3.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged3.TabIndex = 445
        Me.CbxSlaveStatusLogged3.Text = "Logged"
        Me.CbxSlaveStatusLogged3.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged2
        '
        Me.CbxSlaveStatusLogged2.AutoSize = True
        Me.CbxSlaveStatusLogged2.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged2.Location = New System.Drawing.Point(3, 478)
        Me.CbxSlaveStatusLogged2.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged2.Name = "CbxSlaveStatusLogged2"
        Me.CbxSlaveStatusLogged2.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged2.TabIndex = 444
        Me.CbxSlaveStatusLogged2.Text = "Logged"
        Me.CbxSlaveStatusLogged2.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusLogged1
        '
        Me.CbxSlaveStatusLogged1.AutoSize = True
        Me.CbxSlaveStatusLogged1.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusLogged1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusLogged1.Location = New System.Drawing.Point(3, 458)
        Me.CbxSlaveStatusLogged1.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusLogged1.Name = "CbxSlaveStatusLogged1"
        Me.CbxSlaveStatusLogged1.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusLogged1.TabIndex = 443
        Me.CbxSlaveStatusLogged1.Text = "Logged"
        Me.CbxSlaveStatusLogged1.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultF
        '
        Me.CbxSlaveStatusFaultF.AutoSize = True
        Me.CbxSlaveStatusFaultF.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultF.Location = New System.Drawing.Point(189, 383)
        Me.CbxSlaveStatusFaultF.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultF.Name = "CbxSlaveStatusFaultF"
        Me.CbxSlaveStatusFaultF.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultF.TabIndex = 441
        Me.CbxSlaveStatusFaultF.Text = "Fault"
        Me.CbxSlaveStatusFaultF.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultE
        '
        Me.CbxSlaveStatusFaultE.AutoSize = True
        Me.CbxSlaveStatusFaultE.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultE.Location = New System.Drawing.Point(189, 363)
        Me.CbxSlaveStatusFaultE.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultE.Name = "CbxSlaveStatusFaultE"
        Me.CbxSlaveStatusFaultE.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultE.TabIndex = 440
        Me.CbxSlaveStatusFaultE.Text = "Fault"
        Me.CbxSlaveStatusFaultE.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultD
        '
        Me.CbxSlaveStatusFaultD.AutoSize = True
        Me.CbxSlaveStatusFaultD.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultD.Location = New System.Drawing.Point(189, 343)
        Me.CbxSlaveStatusFaultD.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultD.Name = "CbxSlaveStatusFaultD"
        Me.CbxSlaveStatusFaultD.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultD.TabIndex = 439
        Me.CbxSlaveStatusFaultD.Text = "Fault"
        Me.CbxSlaveStatusFaultD.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultC
        '
        Me.CbxSlaveStatusFaultC.AutoSize = True
        Me.CbxSlaveStatusFaultC.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultC.Location = New System.Drawing.Point(189, 323)
        Me.CbxSlaveStatusFaultC.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultC.Name = "CbxSlaveStatusFaultC"
        Me.CbxSlaveStatusFaultC.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultC.TabIndex = 438
        Me.CbxSlaveStatusFaultC.Text = "Fault"
        Me.CbxSlaveStatusFaultC.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultB
        '
        Me.CbxSlaveStatusFaultB.AutoSize = True
        Me.CbxSlaveStatusFaultB.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultB.Location = New System.Drawing.Point(189, 303)
        Me.CbxSlaveStatusFaultB.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultB.Name = "CbxSlaveStatusFaultB"
        Me.CbxSlaveStatusFaultB.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultB.TabIndex = 437
        Me.CbxSlaveStatusFaultB.Text = "Fault"
        Me.CbxSlaveStatusFaultB.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFaultA
        '
        Me.CbxSlaveStatusFaultA.AutoSize = True
        Me.CbxSlaveStatusFaultA.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFaultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFaultA.Location = New System.Drawing.Point(189, 283)
        Me.CbxSlaveStatusFaultA.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFaultA.Name = "CbxSlaveStatusFaultA"
        Me.CbxSlaveStatusFaultA.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFaultA.TabIndex = 436
        Me.CbxSlaveStatusFaultA.Text = "Fault"
        Me.CbxSlaveStatusFaultA.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault9
        '
        Me.CbxSlaveStatusFault9.AutoSize = True
        Me.CbxSlaveStatusFault9.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault9.Location = New System.Drawing.Point(189, 263)
        Me.CbxSlaveStatusFault9.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault9.Name = "CbxSlaveStatusFault9"
        Me.CbxSlaveStatusFault9.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault9.TabIndex = 435
        Me.CbxSlaveStatusFault9.Text = "Fault"
        Me.CbxSlaveStatusFault9.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault8
        '
        Me.CbxSlaveStatusFault8.AutoSize = True
        Me.CbxSlaveStatusFault8.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault8.Location = New System.Drawing.Point(189, 243)
        Me.CbxSlaveStatusFault8.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault8.Name = "CbxSlaveStatusFault8"
        Me.CbxSlaveStatusFault8.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault8.TabIndex = 434
        Me.CbxSlaveStatusFault8.Text = "Fault"
        Me.CbxSlaveStatusFault8.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault0
        '
        Me.CbxSlaveStatusFault0.AutoSize = True
        Me.CbxSlaveStatusFault0.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault0.Location = New System.Drawing.Point(189, 83)
        Me.CbxSlaveStatusFault0.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault0.Name = "CbxSlaveStatusFault0"
        Me.CbxSlaveStatusFault0.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault0.TabIndex = 426
        Me.CbxSlaveStatusFault0.Text = "Fault"
        Me.CbxSlaveStatusFault0.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault7
        '
        Me.CbxSlaveStatusFault7.AutoSize = True
        Me.CbxSlaveStatusFault7.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault7.Location = New System.Drawing.Point(189, 223)
        Me.CbxSlaveStatusFault7.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault7.Name = "CbxSlaveStatusFault7"
        Me.CbxSlaveStatusFault7.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault7.TabIndex = 433
        Me.CbxSlaveStatusFault7.Text = "Fault"
        Me.CbxSlaveStatusFault7.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault6
        '
        Me.CbxSlaveStatusFault6.AutoSize = True
        Me.CbxSlaveStatusFault6.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault6.Location = New System.Drawing.Point(189, 203)
        Me.CbxSlaveStatusFault6.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault6.Name = "CbxSlaveStatusFault6"
        Me.CbxSlaveStatusFault6.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault6.TabIndex = 432
        Me.CbxSlaveStatusFault6.Text = "Fault"
        Me.CbxSlaveStatusFault6.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault5
        '
        Me.CbxSlaveStatusFault5.AutoSize = True
        Me.CbxSlaveStatusFault5.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault5.Location = New System.Drawing.Point(189, 183)
        Me.CbxSlaveStatusFault5.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault5.Name = "CbxSlaveStatusFault5"
        Me.CbxSlaveStatusFault5.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault5.TabIndex = 431
        Me.CbxSlaveStatusFault5.Text = "Fault"
        Me.CbxSlaveStatusFault5.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault4
        '
        Me.CbxSlaveStatusFault4.AutoSize = True
        Me.CbxSlaveStatusFault4.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault4.Location = New System.Drawing.Point(189, 163)
        Me.CbxSlaveStatusFault4.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault4.Name = "CbxSlaveStatusFault4"
        Me.CbxSlaveStatusFault4.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault4.TabIndex = 430
        Me.CbxSlaveStatusFault4.Text = "Fault"
        Me.CbxSlaveStatusFault4.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault3
        '
        Me.CbxSlaveStatusFault3.AutoSize = True
        Me.CbxSlaveStatusFault3.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault3.Location = New System.Drawing.Point(189, 143)
        Me.CbxSlaveStatusFault3.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault3.Name = "CbxSlaveStatusFault3"
        Me.CbxSlaveStatusFault3.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault3.TabIndex = 429
        Me.CbxSlaveStatusFault3.Text = "Fault"
        Me.CbxSlaveStatusFault3.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault2
        '
        Me.CbxSlaveStatusFault2.AutoSize = True
        Me.CbxSlaveStatusFault2.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault2.Location = New System.Drawing.Point(189, 123)
        Me.CbxSlaveStatusFault2.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault2.Name = "CbxSlaveStatusFault2"
        Me.CbxSlaveStatusFault2.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault2.TabIndex = 428
        Me.CbxSlaveStatusFault2.Text = "Fault"
        Me.CbxSlaveStatusFault2.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusFault1
        '
        Me.CbxSlaveStatusFault1.AutoSize = True
        Me.CbxSlaveStatusFault1.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusFault1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusFault1.Location = New System.Drawing.Point(189, 103)
        Me.CbxSlaveStatusFault1.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusFault1.Name = "CbxSlaveStatusFault1"
        Me.CbxSlaveStatusFault1.Size = New System.Drawing.Size(56, 20)
        Me.CbxSlaveStatusFault1.TabIndex = 427
        Me.CbxSlaveStatusFault1.Text = "Fault"
        Me.CbxSlaveStatusFault1.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice7
        '
        Me.CbxSlaveStatusNotice7.AutoSize = True
        Me.CbxSlaveStatusNotice7.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice7.Location = New System.Drawing.Point(3, 383)
        Me.CbxSlaveStatusNotice7.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice7.Name = "CbxSlaveStatusNotice7"
        Me.CbxSlaveStatusNotice7.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice7.TabIndex = 425
        Me.CbxSlaveStatusNotice7.Text = "Notice"
        Me.CbxSlaveStatusNotice7.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice6
        '
        Me.CbxSlaveStatusNotice6.AutoSize = True
        Me.CbxSlaveStatusNotice6.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice6.Location = New System.Drawing.Point(3, 363)
        Me.CbxSlaveStatusNotice6.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice6.Name = "CbxSlaveStatusNotice6"
        Me.CbxSlaveStatusNotice6.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice6.TabIndex = 424
        Me.CbxSlaveStatusNotice6.Text = "Notice"
        Me.CbxSlaveStatusNotice6.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice5
        '
        Me.CbxSlaveStatusNotice5.AutoSize = True
        Me.CbxSlaveStatusNotice5.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice5.Location = New System.Drawing.Point(3, 343)
        Me.CbxSlaveStatusNotice5.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice5.Name = "CbxSlaveStatusNotice5"
        Me.CbxSlaveStatusNotice5.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice5.TabIndex = 423
        Me.CbxSlaveStatusNotice5.Text = "Notice"
        Me.CbxSlaveStatusNotice5.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice4
        '
        Me.CbxSlaveStatusNotice4.AutoSize = True
        Me.CbxSlaveStatusNotice4.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice4.Location = New System.Drawing.Point(3, 323)
        Me.CbxSlaveStatusNotice4.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice4.Name = "CbxSlaveStatusNotice4"
        Me.CbxSlaveStatusNotice4.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice4.TabIndex = 422
        Me.CbxSlaveStatusNotice4.Text = "Notice"
        Me.CbxSlaveStatusNotice4.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice3
        '
        Me.CbxSlaveStatusNotice3.AutoSize = True
        Me.CbxSlaveStatusNotice3.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice3.Location = New System.Drawing.Point(3, 303)
        Me.CbxSlaveStatusNotice3.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice3.Name = "CbxSlaveStatusNotice3"
        Me.CbxSlaveStatusNotice3.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice3.TabIndex = 421
        Me.CbxSlaveStatusNotice3.Text = "Notice"
        Me.CbxSlaveStatusNotice3.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice2
        '
        Me.CbxSlaveStatusNotice2.AutoSize = True
        Me.CbxSlaveStatusNotice2.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice2.Location = New System.Drawing.Point(3, 283)
        Me.CbxSlaveStatusNotice2.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice2.Name = "CbxSlaveStatusNotice2"
        Me.CbxSlaveStatusNotice2.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice2.TabIndex = 420
        Me.CbxSlaveStatusNotice2.Text = "Notice"
        Me.CbxSlaveStatusNotice2.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice1
        '
        Me.CbxSlaveStatusNotice1.AutoSize = True
        Me.CbxSlaveStatusNotice1.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice1.Location = New System.Drawing.Point(3, 263)
        Me.CbxSlaveStatusNotice1.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice1.Name = "CbxSlaveStatusNotice1"
        Me.CbxSlaveStatusNotice1.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice1.TabIndex = 419
        Me.CbxSlaveStatusNotice1.Text = "Notice"
        Me.CbxSlaveStatusNotice1.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusNotice0
        '
        Me.CbxSlaveStatusNotice0.AutoSize = True
        Me.CbxSlaveStatusNotice0.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusNotice0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusNotice0.Location = New System.Drawing.Point(3, 243)
        Me.CbxSlaveStatusNotice0.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusNotice0.Name = "CbxSlaveStatusNotice0"
        Me.CbxSlaveStatusNotice0.Size = New System.Drawing.Size(66, 20)
        Me.CbxSlaveStatusNotice0.TabIndex = 418
        Me.CbxSlaveStatusNotice0.Text = "Notice"
        Me.CbxSlaveStatusNotice0.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl0
        '
        Me.CbxSlaveStatusCntrl0.AutoSize = True
        Me.CbxSlaveStatusCntrl0.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl0.Location = New System.Drawing.Point(3, 83)
        Me.CbxSlaveStatusCntrl0.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl0.Name = "CbxSlaveStatusCntrl0"
        Me.CbxSlaveStatusCntrl0.Size = New System.Drawing.Size(92, 20)
        Me.CbxSlaveStatusCntrl0.TabIndex = 365
        Me.CbxSlaveStatusCntrl0.Text = "Not Ready"
        Me.CbxSlaveStatusCntrl0.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl7
        '
        Me.CbxSlaveStatusCntrl7.AutoSize = True
        Me.CbxSlaveStatusCntrl7.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl7.Location = New System.Drawing.Point(3, 223)
        Me.CbxSlaveStatusCntrl7.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl7.Name = "CbxSlaveStatusCntrl7"
        Me.CbxSlaveStatusCntrl7.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusCntrl7.TabIndex = 372
        Me.CbxSlaveStatusCntrl7.Text = "Unused"
        Me.CbxSlaveStatusCntrl7.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl6
        '
        Me.CbxSlaveStatusCntrl6.AutoSize = True
        Me.CbxSlaveStatusCntrl6.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl6.Location = New System.Drawing.Point(3, 203)
        Me.CbxSlaveStatusCntrl6.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl6.Name = "CbxSlaveStatusCntrl6"
        Me.CbxSlaveStatusCntrl6.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusCntrl6.TabIndex = 371
        Me.CbxSlaveStatusCntrl6.Text = "Unused"
        Me.CbxSlaveStatusCntrl6.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl5
        '
        Me.CbxSlaveStatusCntrl5.AutoSize = True
        Me.CbxSlaveStatusCntrl5.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl5.Location = New System.Drawing.Point(3, 183)
        Me.CbxSlaveStatusCntrl5.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl5.Name = "CbxSlaveStatusCntrl5"
        Me.CbxSlaveStatusCntrl5.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusCntrl5.TabIndex = 370
        Me.CbxSlaveStatusCntrl5.Text = "Unused"
        Me.CbxSlaveStatusCntrl5.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl4
        '
        Me.CbxSlaveStatusCntrl4.AutoSize = True
        Me.CbxSlaveStatusCntrl4.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl4.Location = New System.Drawing.Point(3, 163)
        Me.CbxSlaveStatusCntrl4.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl4.Name = "CbxSlaveStatusCntrl4"
        Me.CbxSlaveStatusCntrl4.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusCntrl4.TabIndex = 369
        Me.CbxSlaveStatusCntrl4.Text = "Unused"
        Me.CbxSlaveStatusCntrl4.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl3
        '
        Me.CbxSlaveStatusCntrl3.AutoSize = True
        Me.CbxSlaveStatusCntrl3.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl3.Location = New System.Drawing.Point(3, 143)
        Me.CbxSlaveStatusCntrl3.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl3.Name = "CbxSlaveStatusCntrl3"
        Me.CbxSlaveStatusCntrl3.Size = New System.Drawing.Size(74, 20)
        Me.CbxSlaveStatusCntrl3.TabIndex = 368
        Me.CbxSlaveStatusCntrl3.Text = "Unused"
        Me.CbxSlaveStatusCntrl3.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl2
        '
        Me.CbxSlaveStatusCntrl2.AutoSize = True
        Me.CbxSlaveStatusCntrl2.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl2.Location = New System.Drawing.Point(3, 123)
        Me.CbxSlaveStatusCntrl2.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl2.Name = "CbxSlaveStatusCntrl2"
        Me.CbxSlaveStatusCntrl2.Size = New System.Drawing.Size(123, 20)
        Me.CbxSlaveStatusCntrl2.TabIndex = 367
        Me.CbxSlaveStatusCntrl2.Text = "Self Check Error"
        Me.CbxSlaveStatusCntrl2.UseVisualStyleBackColor = False
        '
        'CbxSlaveStatusCntrl1
        '
        Me.CbxSlaveStatusCntrl1.AutoSize = True
        Me.CbxSlaveStatusCntrl1.BackColor = System.Drawing.SystemColors.Control
        Me.CbxSlaveStatusCntrl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSlaveStatusCntrl1.Location = New System.Drawing.Point(3, 103)
        Me.CbxSlaveStatusCntrl1.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxSlaveStatusCntrl1.Name = "CbxSlaveStatusCntrl1"
        Me.CbxSlaveStatusCntrl1.Size = New System.Drawing.Size(116, 20)
        Me.CbxSlaveStatusCntrl1.TabIndex = 366
        Me.CbxSlaveStatusCntrl1.Text = "Not Configured"
        Me.CbxSlaveStatusCntrl1.UseVisualStyleBackColor = False
        '
        'LblSlaveLog0
        '
        Me.LblSlaveLog0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog0.Location = New System.Drawing.Point(385, 84)
        Me.LblSlaveLog0.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog0.Name = "LblSlaveLog0"
        Me.LblSlaveLog0.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog0.TabIndex = 222
        Me.LblSlaveLog0.Text = "Log Data 0"
        Me.LblSlaveLog0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog1
        '
        Me.LblSlaveLog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog1.Location = New System.Drawing.Point(385, 110)
        Me.LblSlaveLog1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog1.Name = "LblSlaveLog1"
        Me.LblSlaveLog1.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog1.TabIndex = 226
        Me.LblSlaveLog1.Text = "Log Data 1"
        Me.LblSlaveLog1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog2
        '
        Me.LblSlaveLog2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog2.Location = New System.Drawing.Point(385, 136)
        Me.LblSlaveLog2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog2.Name = "LblSlaveLog2"
        Me.LblSlaveLog2.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog2.TabIndex = 227
        Me.LblSlaveLog2.Text = "Log Data 2"
        Me.LblSlaveLog2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog3
        '
        Me.LblSlaveLog3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog3.Location = New System.Drawing.Point(385, 162)
        Me.LblSlaveLog3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog3.Name = "LblSlaveLog3"
        Me.LblSlaveLog3.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog3.TabIndex = 228
        Me.LblSlaveLog3.Text = "Log Data 3"
        Me.LblSlaveLog3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog4
        '
        Me.LblSlaveLog4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog4.Location = New System.Drawing.Point(385, 188)
        Me.LblSlaveLog4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog4.Name = "LblSlaveLog4"
        Me.LblSlaveLog4.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog4.TabIndex = 229
        Me.LblSlaveLog4.Text = "Log Data 4"
        Me.LblSlaveLog4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog5
        '
        Me.LblSlaveLog5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog5.Location = New System.Drawing.Point(385, 214)
        Me.LblSlaveLog5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog5.Name = "LblSlaveLog5"
        Me.LblSlaveLog5.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog5.TabIndex = 230
        Me.LblSlaveLog5.Text = "Log Data 5"
        Me.LblSlaveLog5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog6
        '
        Me.LblSlaveLog6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog6.Location = New System.Drawing.Point(385, 240)
        Me.LblSlaveLog6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog6.Name = "LblSlaveLog6"
        Me.LblSlaveLog6.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog6.TabIndex = 231
        Me.LblSlaveLog6.Text = "Log Data 6"
        Me.LblSlaveLog6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog7
        '
        Me.LblSlaveLog7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog7.Location = New System.Drawing.Point(385, 266)
        Me.LblSlaveLog7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog7.Name = "LblSlaveLog7"
        Me.LblSlaveLog7.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog7.TabIndex = 232
        Me.LblSlaveLog7.Text = "Log Data 7"
        Me.LblSlaveLog7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelFirmwareVerssion
        '
        Me.LabelFirmwareVerssion.AutoSize = True
        Me.LabelFirmwareVerssion.Location = New System.Drawing.Point(226, 49)
        Me.LabelFirmwareVerssion.Name = "LabelFirmwareVerssion"
        Me.LabelFirmwareVerssion.Size = New System.Drawing.Size(49, 13)
        Me.LabelFirmwareVerssion.TabIndex = 193
        Me.LabelFirmwareVerssion.Text = "Firmware"
        '
        'LblSlaveLog8
        '
        Me.LblSlaveLog8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog8.Location = New System.Drawing.Point(385, 292)
        Me.LblSlaveLog8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog8.Name = "LblSlaveLog8"
        Me.LblSlaveLog8.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog8.TabIndex = 233
        Me.LblSlaveLog8.Text = "Log Data 8"
        Me.LblSlaveLog8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAgileInfo
        '
        Me.LabelAgileInfo.AutoSize = True
        Me.LabelAgileInfo.Location = New System.Drawing.Point(226, 34)
        Me.LabelAgileInfo.Name = "LabelAgileInfo"
        Me.LabelAgileInfo.Size = New System.Drawing.Size(51, 13)
        Me.LabelAgileInfo.TabIndex = 192
        Me.LabelAgileInfo.Text = "Agile Info"
        '
        'LblSlaveLog9
        '
        Me.LblSlaveLog9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog9.Location = New System.Drawing.Point(385, 318)
        Me.LblSlaveLog9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog9.Name = "LblSlaveLog9"
        Me.LblSlaveLog9.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog9.TabIndex = 234
        Me.LblSlaveLog9.Text = "Log Data 9"
        Me.LblSlaveLog9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelBoardStatus
        '
        Me.LabelBoardStatus.AutoSize = True
        Me.LabelBoardStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBoardStatus.Location = New System.Drawing.Point(226, 18)
        Me.LabelBoardStatus.Name = "LabelBoardStatus"
        Me.LabelBoardStatus.Size = New System.Drawing.Size(115, 16)
        Me.LabelBoardStatus.TabIndex = 152
        Me.LabelBoardStatus.Text = "Connection Status"
        '
        'LblSlaveLog10
        '
        Me.LblSlaveLog10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog10.Location = New System.Drawing.Point(385, 344)
        Me.LblSlaveLog10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog10.Name = "LblSlaveLog10"
        Me.LblSlaveLog10.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog10.TabIndex = 277
        Me.LblSlaveLog10.Text = "Log Data 10"
        Me.LblSlaveLog10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog11
        '
        Me.LblSlaveLog11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog11.Location = New System.Drawing.Point(385, 370)
        Me.LblSlaveLog11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog11.Name = "LblSlaveLog11"
        Me.LblSlaveLog11.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog11.TabIndex = 297
        Me.LblSlaveLog11.Text = "Log Data 11"
        Me.LblSlaveLog11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog12
        '
        Me.LblSlaveLog12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog12.Location = New System.Drawing.Point(385, 396)
        Me.LblSlaveLog12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog12.Name = "LblSlaveLog12"
        Me.LblSlaveLog12.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog12.TabIndex = 298
        Me.LblSlaveLog12.Text = "Log Data 12"
        Me.LblSlaveLog12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog13
        '
        Me.LblSlaveLog13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog13.Location = New System.Drawing.Point(385, 422)
        Me.LblSlaveLog13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog13.Name = "LblSlaveLog13"
        Me.LblSlaveLog13.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog13.TabIndex = 299
        Me.LblSlaveLog13.Text = "Log Data 13"
        Me.LblSlaveLog13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSlaveLog14
        '
        Me.LblSlaveLog14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlaveLog14.Location = New System.Drawing.Point(385, 448)
        Me.LblSlaveLog14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LblSlaveLog14.Name = "LblSlaveLog14"
        Me.LblSlaveLog14.Size = New System.Drawing.Size(200, 16)
        Me.LblSlaveLog14.TabIndex = 300
        Me.LblSlaveLog14.Text = "Log Data 14"
        Me.LblSlaveLog14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnClearDebug
        '
        Me.BtnClearDebug.Location = New System.Drawing.Point(816, 170)
        Me.BtnClearDebug.Name = "BtnClearDebug"
        Me.BtnClearDebug.Size = New System.Drawing.Size(219, 23)
        Me.BtnClearDebug.TabIndex = 627
        Me.BtnClearDebug.Text = "Clear Debug"
        Me.BtnClearDebug.UseVisualStyleBackColor = True
        '
        'BtnAFCAuto
        '
        Me.BtnAFCAuto.Location = New System.Drawing.Point(469, 141)
        Me.BtnAFCAuto.Name = "BtnAFCAuto"
        Me.BtnAFCAuto.Size = New System.Drawing.Size(219, 23)
        Me.BtnAFCAuto.TabIndex = 625
        Me.BtnAFCAuto.Text = "AFC AUTO"
        Me.BtnAFCAuto.UseVisualStyleBackColor = True
        '
        'TabPage1ECB
        '
        Me.TabPage1ECB.Controls.Add(Me.BtnSystemSerialNumber)
        Me.TabPage1ECB.Controls.Add(Me.BtnClearDebug)
        Me.TabPage1ECB.Controls.Add(Me.Label19)
        Me.TabPage1ECB.Controls.Add(Me.BtnAFCAuto)
        Me.TabPage1ECB.Controls.Add(Me.Label18)
        Me.TabPage1ECB.Controls.Add(Me.BtnAFCManual)
        Me.TabPage1ECB.Controls.Add(Me.Label16)
        Me.TabPage1ECB.Controls.Add(Me.Button16)
        Me.TabPage1ECB.Controls.Add(Me.BtnZeroOnTimeCounter)
        Me.TabPage1ECB.Controls.Add(Me.BtnZeroArcPulseCounter)
        Me.TabPage1ECB.Controls.Add(Me.Button13)
        Me.TabPage1ECB.Controls.Add(Me.Button12)
        Me.TabPage1ECB.Controls.Add(Me.Button11)
        Me.TabPage1ECB.Controls.Add(Me.Button10)
        Me.TabPage1ECB.Controls.Add(Me.Button9)
        Me.TabPage1ECB.Controls.Add(Me.BtnEEpromWriteStatusClear)
        Me.TabPage1ECB.Controls.Add(Me.Button7)
        Me.TabPage1ECB.Controls.Add(Me.Button6)
        Me.TabPage1ECB.Controls.Add(Me.Button5)
        Me.TabPage1ECB.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1ECB.Name = "TabPage1ECB"
        Me.TabPage1ECB.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1ECB.Size = New System.Drawing.Size(1415, 935)
        Me.TabPage1ECB.TabIndex = 1
        Me.TabPage1ECB.Text = "Commands"
        Me.TabPage1ECB.UseVisualStyleBackColor = True
        '
        'BtnSystemSerialNumber
        '
        Me.BtnSystemSerialNumber.Location = New System.Drawing.Point(816, 141)
        Me.BtnSystemSerialNumber.Name = "BtnSystemSerialNumber"
        Me.BtnSystemSerialNumber.Size = New System.Drawing.Size(219, 23)
        Me.BtnSystemSerialNumber.TabIndex = 638
        Me.BtnSystemSerialNumber.Text = "Set System Serial Number"
        Me.BtnSystemSerialNumber.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(49, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 26)
        Me.Label19.TabIndex = 637
        Me.Label19.Text = "Commands"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(811, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 26)
        Me.Label18.TabIndex = 636
        Me.Label18.Text = "ETM Commands"
        '
        'BtnAFCManual
        '
        Me.BtnAFCManual.Location = New System.Drawing.Point(469, 112)
        Me.BtnAFCManual.Name = "BtnAFCManual"
        Me.BtnAFCManual.Size = New System.Drawing.Size(219, 23)
        Me.BtnAFCManual.TabIndex = 626
        Me.BtnAFCManual.Text = "AFC Manual"
        Me.BtnAFCManual.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(484, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(204, 26)
        Me.Label16.TabIndex = 635
        Me.Label16.Text = "Service Commands"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(816, 112)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(219, 23)
        Me.Button16.TabIndex = 634
        Me.Button16.Text = "Save Settings to Factory Default"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'BtnZeroOnTimeCounter
        '
        Me.BtnZeroOnTimeCounter.Location = New System.Drawing.Point(816, 83)
        Me.BtnZeroOnTimeCounter.Name = "BtnZeroOnTimeCounter"
        Me.BtnZeroOnTimeCounter.Size = New System.Drawing.Size(219, 23)
        Me.BtnZeroOnTimeCounter.TabIndex = 633
        Me.BtnZeroOnTimeCounter.Text = "Zero On Time Counters"
        Me.BtnZeroOnTimeCounter.UseVisualStyleBackColor = True
        '
        'BtnZeroArcPulseCounter
        '
        Me.BtnZeroArcPulseCounter.Location = New System.Drawing.Point(816, 54)
        Me.BtnZeroArcPulseCounter.Name = "BtnZeroArcPulseCounter"
        Me.BtnZeroArcPulseCounter.Size = New System.Drawing.Size(219, 23)
        Me.BtnZeroArcPulseCounter.TabIndex = 632
        Me.BtnZeroArcPulseCounter.Text = "Zero Pulse and Arc Count"
        Me.BtnZeroArcPulseCounter.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(469, 315)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(219, 23)
        Me.Button13.TabIndex = 631
        Me.Button13.Text = "Load Custom Settings From EEProm"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(469, 286)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(219, 23)
        Me.Button12.TabIndex = 630
        Me.Button12.Text = "Save Custom Settings to EEProm"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(469, 257)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(219, 23)
        Me.Button11.TabIndex = 629
        Me.Button11.Text = "Load Factory Defaults"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(469, 83)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(219, 23)
        Me.Button10.TabIndex = 628
        Me.Button10.Text = "Stop Pulse Log"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(469, 54)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(219, 23)
        Me.Button9.TabIndex = 627
        Me.Button9.Text = "Start Pulse Log"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'BtnEEpromWriteStatusClear
        '
        Me.BtnEEpromWriteStatusClear.Location = New System.Drawing.Point(6, 140)
        Me.BtnEEpromWriteStatusClear.Name = "BtnEEpromWriteStatusClear"
        Me.BtnEEpromWriteStatusClear.Size = New System.Drawing.Size(219, 23)
        Me.BtnEEpromWriteStatusClear.TabIndex = 626
        Me.BtnEEpromWriteStatusClear.Text = "Clear EEProm Write Status"
        Me.BtnEEpromWriteStatusClear.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 112)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(219, 23)
        Me.Button7.TabIndex = 625
        Me.Button7.Text = "Access Mode ETM"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 83)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(219, 23)
        Me.Button6.TabIndex = 624
        Me.Button6.Text = "Access Mode Service"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(219, 23)
        Me.Button5.TabIndex = 623
        Me.Button5.Text = "Access Mode Default"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabPage4Dose
        '
        Me.TabPage4Dose.Controls.Add(Me.TabPage1ECB)
        Me.TabPage4Dose.Controls.Add(Me.TabPage2Slave)
        Me.TabPage4Dose.Controls.Add(Me.TabPage4)
        Me.TabPage4Dose.Controls.Add(Me.TabPage5)
        Me.TabPage4Dose.Location = New System.Drawing.Point(370, 0)
        Me.TabPage4Dose.Name = "TabPage4Dose"
        Me.TabPage4Dose.SelectedIndex = 0
        Me.TabPage4Dose.Size = New System.Drawing.Size(1423, 961)
        Me.TabPage4Dose.TabIndex = 460
        '
        'CbxConnect0
        '
        Me.CbxConnect0.AutoSize = True
        Me.CbxConnect0.Location = New System.Drawing.Point(61, 505)
        Me.CbxConnect0.Name = "CbxConnect0"
        Me.CbxConnect0.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect0.TabIndex = 461
        Me.CbxConnect0.Text = "Connection"
        Me.CbxConnect0.UseVisualStyleBackColor = True
        '
        'CbxConnect1
        '
        Me.CbxConnect1.AutoSize = True
        Me.CbxConnect1.Location = New System.Drawing.Point(61, 525)
        Me.CbxConnect1.Name = "CbxConnect1"
        Me.CbxConnect1.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect1.TabIndex = 462
        Me.CbxConnect1.Text = "Connection"
        Me.CbxConnect1.UseVisualStyleBackColor = True
        '
        'CbxConnect3
        '
        Me.CbxConnect3.AutoSize = True
        Me.CbxConnect3.Location = New System.Drawing.Point(61, 565)
        Me.CbxConnect3.Name = "CbxConnect3"
        Me.CbxConnect3.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect3.TabIndex = 631
        Me.CbxConnect3.Text = "Connection"
        Me.CbxConnect3.UseVisualStyleBackColor = True
        '
        'CbxConnect2
        '
        Me.CbxConnect2.AutoSize = True
        Me.CbxConnect2.Location = New System.Drawing.Point(61, 545)
        Me.CbxConnect2.Name = "CbxConnect2"
        Me.CbxConnect2.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect2.TabIndex = 630
        Me.CbxConnect2.Text = "Connection"
        Me.CbxConnect2.UseVisualStyleBackColor = True
        '
        'CbxConnect7
        '
        Me.CbxConnect7.AutoSize = True
        Me.CbxConnect7.Location = New System.Drawing.Point(61, 645)
        Me.CbxConnect7.Name = "CbxConnect7"
        Me.CbxConnect7.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect7.TabIndex = 635
        Me.CbxConnect7.Text = "Connection"
        Me.CbxConnect7.UseVisualStyleBackColor = True
        '
        'CbxConnect6
        '
        Me.CbxConnect6.AutoSize = True
        Me.CbxConnect6.Location = New System.Drawing.Point(61, 625)
        Me.CbxConnect6.Name = "CbxConnect6"
        Me.CbxConnect6.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect6.TabIndex = 634
        Me.CbxConnect6.Text = "Connection"
        Me.CbxConnect6.UseVisualStyleBackColor = True
        '
        'CbxConnect5
        '
        Me.CbxConnect5.AutoSize = True
        Me.CbxConnect5.Location = New System.Drawing.Point(61, 605)
        Me.CbxConnect5.Name = "CbxConnect5"
        Me.CbxConnect5.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect5.TabIndex = 633
        Me.CbxConnect5.Text = "Connection"
        Me.CbxConnect5.UseVisualStyleBackColor = True
        '
        'CbxConnect4
        '
        Me.CbxConnect4.AutoSize = True
        Me.CbxConnect4.Location = New System.Drawing.Point(61, 585)
        Me.CbxConnect4.Name = "CbxConnect4"
        Me.CbxConnect4.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect4.TabIndex = 632
        Me.CbxConnect4.Text = "Connection"
        Me.CbxConnect4.UseVisualStyleBackColor = True
        '
        'CbxConnect9
        '
        Me.CbxConnect9.AutoSize = True
        Me.CbxConnect9.Location = New System.Drawing.Point(61, 685)
        Me.CbxConnect9.Name = "CbxConnect9"
        Me.CbxConnect9.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect9.TabIndex = 637
        Me.CbxConnect9.Text = "Connection"
        Me.CbxConnect9.UseVisualStyleBackColor = True
        '
        'CbxConnect8
        '
        Me.CbxConnect8.AutoSize = True
        Me.CbxConnect8.Location = New System.Drawing.Point(61, 665)
        Me.CbxConnect8.Name = "CbxConnect8"
        Me.CbxConnect8.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect8.TabIndex = 636
        Me.CbxConnect8.Text = "Connection"
        Me.CbxConnect8.UseVisualStyleBackColor = True
        '
        'CbxReady9
        '
        Me.CbxReady9.AutoSize = True
        Me.CbxReady9.Location = New System.Drawing.Point(22, 686)
        Me.CbxReady9.Name = "CbxReady9"
        Me.CbxReady9.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady9.TabIndex = 647
        Me.CbxReady9.UseVisualStyleBackColor = True
        '
        'CbxReady8
        '
        Me.CbxReady8.AutoSize = True
        Me.CbxReady8.Location = New System.Drawing.Point(22, 666)
        Me.CbxReady8.Name = "CbxReady8"
        Me.CbxReady8.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady8.TabIndex = 646
        Me.CbxReady8.UseVisualStyleBackColor = True
        '
        'CbxReady7
        '
        Me.CbxReady7.AutoSize = True
        Me.CbxReady7.Location = New System.Drawing.Point(22, 646)
        Me.CbxReady7.Name = "CbxReady7"
        Me.CbxReady7.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady7.TabIndex = 645
        Me.CbxReady7.UseVisualStyleBackColor = True
        '
        'CbxReady6
        '
        Me.CbxReady6.AutoSize = True
        Me.CbxReady6.Location = New System.Drawing.Point(22, 626)
        Me.CbxReady6.Name = "CbxReady6"
        Me.CbxReady6.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady6.TabIndex = 644
        Me.CbxReady6.UseVisualStyleBackColor = True
        '
        'CbxReady5
        '
        Me.CbxReady5.AutoSize = True
        Me.CbxReady5.Location = New System.Drawing.Point(22, 606)
        Me.CbxReady5.Name = "CbxReady5"
        Me.CbxReady5.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady5.TabIndex = 643
        Me.CbxReady5.UseVisualStyleBackColor = True
        '
        'CbxReady4
        '
        Me.CbxReady4.AutoSize = True
        Me.CbxReady4.Location = New System.Drawing.Point(22, 586)
        Me.CbxReady4.Name = "CbxReady4"
        Me.CbxReady4.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady4.TabIndex = 642
        Me.CbxReady4.UseVisualStyleBackColor = True
        '
        'CbxReady3
        '
        Me.CbxReady3.AutoSize = True
        Me.CbxReady3.Location = New System.Drawing.Point(22, 566)
        Me.CbxReady3.Name = "CbxReady3"
        Me.CbxReady3.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady3.TabIndex = 641
        Me.CbxReady3.UseVisualStyleBackColor = True
        '
        'CbxReady2
        '
        Me.CbxReady2.AutoSize = True
        Me.CbxReady2.Location = New System.Drawing.Point(22, 546)
        Me.CbxReady2.Name = "CbxReady2"
        Me.CbxReady2.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady2.TabIndex = 640
        Me.CbxReady2.UseVisualStyleBackColor = True
        '
        'CbxReady1
        '
        Me.CbxReady1.AutoSize = True
        Me.CbxReady1.Location = New System.Drawing.Point(22, 526)
        Me.CbxReady1.Name = "CbxReady1"
        Me.CbxReady1.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady1.TabIndex = 639
        Me.CbxReady1.UseVisualStyleBackColor = True
        '
        'CbxReady0
        '
        Me.CbxReady0.AutoSize = True
        Me.CbxReady0.Location = New System.Drawing.Point(22, 506)
        Me.CbxReady0.Name = "CbxReady0"
        Me.CbxReady0.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady0.TabIndex = 638
        Me.CbxReady0.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 648
        Me.Label15.Text = "Not"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 490)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 649
        Me.Label20.Text = "Ready"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(51, 490)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 651
        Me.Label21.Text = "Connected"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(52, 476)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 13)
        Me.Label22.TabIndex = 650
        Me.Label22.Text = "Not"
        '
        'CbxConnect10
        '
        Me.CbxConnect10.AutoSize = True
        Me.CbxConnect10.Location = New System.Drawing.Point(61, 704)
        Me.CbxConnect10.Name = "CbxConnect10"
        Me.CbxConnect10.Size = New System.Drawing.Size(80, 17)
        Me.CbxConnect10.TabIndex = 652
        Me.CbxConnect10.Text = "Connection"
        Me.CbxConnect10.UseVisualStyleBackColor = True
        '
        'CbxReady10
        '
        Me.CbxReady10.AutoSize = True
        Me.CbxReady10.Location = New System.Drawing.Point(22, 705)
        Me.CbxReady10.Name = "CbxReady10"
        Me.CbxReady10.Size = New System.Drawing.Size(15, 14)
        Me.CbxReady10.TabIndex = 653
        Me.CbxReady10.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1784, 961)
        Me.Controls.Add(Me.CbxReady10)
        Me.Controls.Add(Me.CbxConnect10)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CbxReady9)
        Me.Controls.Add(Me.CbxReady8)
        Me.Controls.Add(Me.CbxReady7)
        Me.Controls.Add(Me.CbxReady6)
        Me.Controls.Add(Me.CbxReady5)
        Me.Controls.Add(Me.CbxReady4)
        Me.Controls.Add(Me.CbxReady3)
        Me.Controls.Add(Me.CbxReady2)
        Me.Controls.Add(Me.CbxReady1)
        Me.Controls.Add(Me.CbxReady0)
        Me.Controls.Add(Me.CbxConnect9)
        Me.Controls.Add(Me.TabPage4Dose)
        Me.Controls.Add(Me.CbxConnect8)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.CbxConnect7)
        Me.Controls.Add(Me.LabelGuiVersion)
        Me.Controls.Add(Me.CbxConnect6)
        Me.Controls.Add(Me.LabelECBTime)
        Me.Controls.Add(Me.CbxConnect5)
        Me.Controls.Add(Me.LabelComputerTime)
        Me.Controls.Add(Me.CbxConnect4)
        Me.Controls.Add(Me.LabelECBState)
        Me.Controls.Add(Me.CbxConnect3)
        Me.Controls.Add(Me.CbxConnect2)
        Me.Controls.Add(Me.CbxConnect1)
        Me.Controls.Add(Me.CbxConnect0)
        Me.Name = "frmMain"
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2Slave.ResumeLayout(False)
        Me.TabPage2Slave.PerformLayout()
        Me.TabPage1ECB.ResumeLayout(False)
        Me.TabPage1ECB.PerformLayout()
        Me.TabPage4Dose.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents LabelECBTime As System.Windows.Forms.Label
    Friend WithEvents LabelComputerTime As System.Windows.Forms.Label
    Friend WithEvents LabelECBState As System.Windows.Forms.Label
    Friend WithEvents LabelGuiVersion As System.Windows.Forms.Label
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents SerialPortETM As System.IO.Ports.SerialPort
    Friend WithEvents TimerWatchdog As System.Windows.Forms.Timer
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBoxComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents LabelWatchDogResponse As System.Windows.Forms.Label
    Friend WithEvents TextBoxRev As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIP3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIP2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHNubmber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIP1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIP0 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelCommandCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelCommandLengthError As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonSetIPAddres As System.Windows.Forms.Button
    Friend WithEvents ButtonSetRemoteIP As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2Slave As System.Windows.Forms.TabPage
    Friend WithEvents BtnClearDebug As System.Windows.Forms.Button
    Friend WithEvents BtnAFCAuto As System.Windows.Forms.Button
    Friend WithEvents BtnSetCalPair As System.Windows.Forms.Button
    Friend WithEvents BtnEEPromDebug As System.Windows.Forms.Button
    Friend WithEvents LblDebug7 As System.Windows.Forms.Label
    Friend WithEvents LblDebug6 As System.Windows.Forms.Label
    Friend WithEvents LblDebug5 As System.Windows.Forms.Label
    Friend WithEvents LblDebug4 As System.Windows.Forms.Label
    Friend WithEvents LblDebug3 As System.Windows.Forms.Label
    Friend WithEvents LblDebug2 As System.Windows.Forms.Label
    Friend WithEvents LblDebug1 As System.Windows.Forms.Label
    Friend WithEvents LblDebug0 As System.Windows.Forms.Label
    Friend WithEvents BtnRamDebug As System.Windows.Forms.Button
    Friend WithEvents BtnSlaveDefaultEEProm As System.Windows.Forms.Button
    Friend WithEvents BtnSetRevSN As System.Windows.Forms.Button
    Friend WithEvents LblDebugSystem7 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem6 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem5 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem4 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem3 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem2 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem1 As System.Windows.Forms.Label
    Friend WithEvents LblDebugSystem0 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD15 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD14 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD13 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD12 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD11 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD10 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD9 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD8 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD7 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD6 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD5 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD4 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD3 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD2 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD1 As System.Windows.Forms.Label
    Friend WithEvents LblDebugTBD0 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal3ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal3ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal3IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal3IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal2ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal2ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal2IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal2IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal1ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal1ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal1IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal1IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal0ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal0ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal0IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal0IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal7ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal7ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal7IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal7IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal6ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal6ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal6IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal6IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal5ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal5ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal5IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal5IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal4ExtOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal4ExtGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal4IntOffset As System.Windows.Forms.Label
    Friend WithEvents LblDebugCal4IntGain As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom15 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom14 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom13 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom12 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom11 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom10 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom9 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom8 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom7 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom6 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom5 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom4 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom3 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom2 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom1 As System.Windows.Forms.Label
    Friend WithEvents LblDebugEEprom0 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanF As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanE As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanD As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanC As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanB As System.Windows.Forms.Label
    Friend WithEvents LblDebugCanA As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan9 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan8 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan7 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan6 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan5 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan4 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan3 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan2 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan1 As System.Windows.Forms.Label
    Friend WithEvents LblDebugCan0 As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegF As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegE As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegD As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegC As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegB As System.Windows.Forms.Label
    Friend WithEvents LblDebugRegA As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg9 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg8 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg7 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg6 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg5 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg4 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg3 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg2 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg1 As System.Windows.Forms.Label
    Friend WithEvents LblDebugReg0 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue23 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue15 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue16 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue17 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue18 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue19 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue20 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue21 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue22 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue0 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue1 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue2 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue3 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue4 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue5 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue6 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue7 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue8 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue9 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue10 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue11 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue12 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue13 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLogValue14 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog23 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog15 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog16 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog17 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog18 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog19 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog20 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog21 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog22 As System.Windows.Forms.Label
    Friend WithEvents CbxSlaveStatusNotLoggedF As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLoggedE As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLoggedD As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLoggedC As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLoggedB As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLoggedA As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged9 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged8 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotLogged1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedF As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedE As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedD As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedC As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedB As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLoggedA As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged9 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged8 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusLogged1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultF As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultE As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultD As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultC As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultB As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFaultA As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault9 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault8 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusFault1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusNotice0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxSlaveStatusCntrl1 As System.Windows.Forms.CheckBox
    Friend WithEvents LblSlaveLog0 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog1 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog2 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog3 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog4 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog5 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog6 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog7 As System.Windows.Forms.Label
    Friend WithEvents LabelFirmwareVerssion As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog8 As System.Windows.Forms.Label
    Friend WithEvents LabelAgileInfo As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog9 As System.Windows.Forms.Label
    Friend WithEvents LabelBoardStatus As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog10 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog11 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog12 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog13 As System.Windows.Forms.Label
    Friend WithEvents LblSlaveLog14 As System.Windows.Forms.Label
    Friend WithEvents TabPage1ECB As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4Dose As System.Windows.Forms.TabControl
    Friend WithEvents LblDose3 As System.Windows.Forms.Label
    Friend WithEvents LblDose2 As System.Windows.Forms.Label
    Friend WithEvents LblDose1 As System.Windows.Forms.Label
    Friend WithEvents LblDose0 As System.Windows.Forms.Label
    Friend WithEvents BtnUnused0Dose3 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused1Dose3 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused2Dose3 As System.Windows.Forms.Button
    Friend WithEvents BtnPRFDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCHomeDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMaxDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMaxDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMinDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMinDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCTriggerDelayDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnSpareTriggerDelayDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnGunCathodeDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnPulseTopDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnMagnetCurrentDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSDose3 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused0Dose2 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused1Dose2 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused2Dose2 As System.Windows.Forms.Button
    Friend WithEvents BtnPRFDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCHomeDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMaxDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMaxDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMinDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMinDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCTriggerDelayDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnSpareTriggerDelayDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnGunCathodeDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnPulseTopDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnMagnetCurrentDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSDose2 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused0Dose1 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused1Dose1 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused2Dose1 As System.Windows.Forms.Button
    Friend WithEvents BtnPRFDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCHomeDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMaxDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMaxDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMinDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMinDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCTriggerDelayDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnSpareTriggerDelayDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnGunCathodeDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnPulseTopDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnMagnetCurrentDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSDose1 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused0Dose0 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused1Dose0 As System.Windows.Forms.Button
    Friend WithEvents BtnUnused2Dose0 As System.Windows.Forms.Button
    Friend WithEvents BtnPRFDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCHomeDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMaxDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMaxDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStopMinDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnGrideStartMinDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCTriggerDelayDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnSpareTriggerDelayDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnGunCathodeDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnPulseTopDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnMagnetCurrentDose0 As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSDose0 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnUnused0DoseAll As System.Windows.Forms.Button
    Friend WithEvents BtnUnused1DoseAll As System.Windows.Forms.Button
    Friend WithEvents BtnUnused2DoseAll As System.Windows.Forms.Button
    Friend WithEvents BtnUnused3DoseAll As System.Windows.Forms.Button
    Friend WithEvents BtnGunHeater As System.Windows.Forms.Button
    Friend WithEvents BtnAFCManualPostion As System.Windows.Forms.Button
    Friend WithEvents BtnGunBias As System.Windows.Forms.Button
    Friend WithEvents BtnAFCAuxControl As System.Windows.Forms.Button
    Friend WithEvents BtnXrayRunTime As System.Windows.Forms.Button
    Friend WithEvents BtnSampleTriggerStop As System.Windows.Forms.Button
    Friend WithEvents BtnSampleTriggerStart As System.Windows.Forms.Button
    Friend WithEvents BtnPFNTriggerDelay As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSTrigStop As System.Windows.Forms.Button
    Friend WithEvents BtnHVPSTrigStart As System.Windows.Forms.Button
    Friend WithEvents BtnMagnetronHeater As System.Windows.Forms.Button
    Friend WithEvents BntECBEEPromConfigure As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents BtnEEpromWriteStatusClear As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BtnZeroOnTimeCounter As System.Windows.Forms.Button
    Friend WithEvents BtnZeroArcPulseCounter As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents BtnAFCManual As System.Windows.Forms.Button
    Friend WithEvents CoBoxSelectedCanBoard As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSystemSerialNumber As System.Windows.Forms.Button
    Friend WithEvents BtnMCUReset As System.Windows.Forms.Button
    Friend WithEvents CbxConnect0 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect9 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxConnect8 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady9 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady8 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady7 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady6 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady5 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady4 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady3 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady1 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CbxConnect10 As System.Windows.Forms.CheckBox
    Friend WithEvents CbxReady10 As System.Windows.Forms.CheckBox
End Class
