<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIOEmulator
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
        Me.lblInputs = New System.Windows.Forms.Label()
        Me.lblOutputs = New System.Windows.Forms.Label()
        Me.trbVoltage = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trbCurrent = New System.Windows.Forms.TrackBar()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblCurrentLimit = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpPowerSrc = New System.Windows.Forms.GroupBox()
        Me.lblActualCur = New System.Windows.Forms.Label()
        Me.lblActualVol = New System.Windows.Forms.Label()
        Me.grpIO = New System.Windows.Forms.GroupBox()
        Me.grpAnalogChannels = New System.Windows.Forms.GroupBox()
        CType(Me.trbVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPowerSrc.SuspendLayout()
        Me.grpIO.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInputs
        '
        Me.lblInputs.AutoSize = True
        Me.lblInputs.Location = New System.Drawing.Point(6, 25)
        Me.lblInputs.Name = "lblInputs"
        Me.lblInputs.Size = New System.Drawing.Size(36, 13)
        Me.lblInputs.TabIndex = 0
        Me.lblInputs.Text = "Inputs"
        '
        'lblOutputs
        '
        Me.lblOutputs.AutoSize = True
        Me.lblOutputs.Location = New System.Drawing.Point(6, 95)
        Me.lblOutputs.Name = "lblOutputs"
        Me.lblOutputs.Size = New System.Drawing.Size(44, 13)
        Me.lblOutputs.TabIndex = 1
        Me.lblOutputs.Text = "Outputs"
        '
        'trbVoltage
        '
        Me.trbVoltage.Location = New System.Drawing.Point(84, 29)
        Me.trbVoltage.Maximum = 100
        Me.trbVoltage.Name = "trbVoltage"
        Me.trbVoltage.Size = New System.Drawing.Size(270, 45)
        Me.trbVoltage.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Actual Voltaje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Actual Current"
        '
        'trbCurrent
        '
        Me.trbCurrent.Location = New System.Drawing.Point(84, 80)
        Me.trbCurrent.Maximum = 50
        Me.trbCurrent.Name = "trbCurrent"
        Me.trbCurrent.Size = New System.Drawing.Size(270, 45)
        Me.trbCurrent.TabIndex = 5
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(6, 122)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(39, 13)
        Me.lblVoltage.TabIndex = 6
        Me.lblVoltage.Text = "Voltaje"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(6, 145)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(41, 13)
        Me.lblCurrent.TabIndex = 7
        Me.lblCurrent.Text = "Current"
        '
        'lblCurrentLimit
        '
        Me.lblCurrentLimit.AutoSize = True
        Me.lblCurrentLimit.Location = New System.Drawing.Point(6, 169)
        Me.lblCurrentLimit.Name = "lblCurrentLimit"
        Me.lblCurrentLimit.Size = New System.Drawing.Size(65, 13)
        Me.lblCurrentLimit.TabIndex = 8
        Me.lblCurrentLimit.Text = "Current Limit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'grpPowerSrc
        '
        Me.grpPowerSrc.Controls.Add(Me.lblActualCur)
        Me.grpPowerSrc.Controls.Add(Me.lblActualVol)
        Me.grpPowerSrc.Controls.Add(Me.Label3)
        Me.grpPowerSrc.Controls.Add(Me.lblCurrentLimit)
        Me.grpPowerSrc.Controls.Add(Me.trbVoltage)
        Me.grpPowerSrc.Controls.Add(Me.lblCurrent)
        Me.grpPowerSrc.Controls.Add(Me.Label4)
        Me.grpPowerSrc.Controls.Add(Me.lblVoltage)
        Me.grpPowerSrc.Controls.Add(Me.trbCurrent)
        Me.grpPowerSrc.Location = New System.Drawing.Point(16, 187)
        Me.grpPowerSrc.Name = "grpPowerSrc"
        Me.grpPowerSrc.Size = New System.Drawing.Size(402, 195)
        Me.grpPowerSrc.TabIndex = 9
        Me.grpPowerSrc.TabStop = False
        Me.grpPowerSrc.Text = "Power Source"
        '
        'lblActualCur
        '
        Me.lblActualCur.AutoSize = True
        Me.lblActualCur.Location = New System.Drawing.Point(357, 80)
        Me.lblActualCur.Name = "lblActualCur"
        Me.lblActualCur.Size = New System.Drawing.Size(13, 13)
        Me.lblActualCur.TabIndex = 10
        Me.lblActualCur.Text = "0"
        '
        'lblActualVol
        '
        Me.lblActualVol.AutoSize = True
        Me.lblActualVol.Location = New System.Drawing.Point(357, 29)
        Me.lblActualVol.Name = "lblActualVol"
        Me.lblActualVol.Size = New System.Drawing.Size(13, 13)
        Me.lblActualVol.TabIndex = 9
        Me.lblActualVol.Text = "0"
        '
        'grpIO
        '
        Me.grpIO.Controls.Add(Me.lblInputs)
        Me.grpIO.Controls.Add(Me.lblOutputs)
        Me.grpIO.Location = New System.Drawing.Point(16, 12)
        Me.grpIO.Name = "grpIO"
        Me.grpIO.Size = New System.Drawing.Size(402, 169)
        Me.grpIO.TabIndex = 10
        Me.grpIO.TabStop = False
        Me.grpIO.Text = "Discrete Inputs Outputs"
        '
        'grpAnalogChannels
        '
        Me.grpAnalogChannels.Location = New System.Drawing.Point(16, 388)
        Me.grpAnalogChannels.Name = "grpAnalogChannels"
        Me.grpAnalogChannels.Size = New System.Drawing.Size(402, 220)
        Me.grpAnalogChannels.TabIndex = 11
        Me.grpAnalogChannels.TabStop = False
        Me.grpAnalogChannels.Text = "Analog"
        '
        'frmIOEmulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 623)
        Me.Controls.Add(Me.grpAnalogChannels)
        Me.Controls.Add(Me.grpIO)
        Me.Controls.Add(Me.grpPowerSrc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIOEmulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmIOEmulator"
        CType(Me.trbVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPowerSrc.ResumeLayout(False)
        Me.grpPowerSrc.PerformLayout()
        Me.grpIO.ResumeLayout(False)
        Me.grpIO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInputs As System.Windows.Forms.Label
    Friend WithEvents lblOutputs As System.Windows.Forms.Label
    Friend WithEvents trbVoltage As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trbCurrent As System.Windows.Forms.TrackBar
    Friend WithEvents lblVoltage As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents lblCurrentLimit As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpPowerSrc As System.Windows.Forms.GroupBox
    Friend WithEvents grpIO As System.Windows.Forms.GroupBox
    Friend WithEvents grpAnalogChannels As System.Windows.Forms.GroupBox
    Friend WithEvents lblActualCur As System.Windows.Forms.Label
    Friend WithEvents lblActualVol As System.Windows.Forms.Label
End Class
