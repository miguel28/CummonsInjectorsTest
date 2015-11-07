<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPwrTest
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnSendADETestCommand = New System.Windows.Forms.Button()
        Me.btnStopADETest = New System.Windows.Forms.Button()
        Me.cboxComPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cCurrent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSlew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM22"
        '
        'btnSendADETestCommand
        '
        Me.btnSendADETestCommand.Location = New System.Drawing.Point(206, 10)
        Me.btnSendADETestCommand.Name = "btnSendADETestCommand"
        Me.btnSendADETestCommand.Size = New System.Drawing.Size(75, 23)
        Me.btnSendADETestCommand.TabIndex = 0
        Me.btnSendADETestCommand.Text = "Start"
        Me.btnSendADETestCommand.UseVisualStyleBackColor = True
        '
        'btnStopADETest
        '
        Me.btnStopADETest.Location = New System.Drawing.Point(287, 10)
        Me.btnStopADETest.Name = "btnStopADETest"
        Me.btnStopADETest.Size = New System.Drawing.Size(75, 23)
        Me.btnStopADETest.TabIndex = 1
        Me.btnStopADETest.Text = "Stop"
        Me.btnStopADETest.UseVisualStyleBackColor = True
        '
        'cboxComPort
        '
        Me.cboxComPort.FormattingEnabled = True
        Me.cboxComPort.Location = New System.Drawing.Point(68, 12)
        Me.cboxComPort.Name = "cboxComPort"
        Me.cboxComPort.Size = New System.Drawing.Size(121, 21)
        Me.cboxComPort.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Com Port"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCurrent, Me.cSlew, Me.cTime})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(350, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'cCurrent
        '
        Me.cCurrent.HeaderText = "Current"
        Me.cCurrent.Name = "cCurrent"
        '
        'cSlew
        '
        Me.cSlew.HeaderText = "Slew"
        Me.cSlew.Name = "cSlew"
        '
        'cTime
        '
        Me.cTime.HeaderText = "Time"
        Me.cTime.Name = "cTime"
        '
        'frmPwrTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 208)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxComPort)
        Me.Controls.Add(Me.btnStopADETest)
        Me.Controls.Add(Me.btnSendADETestCommand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPwrTest"
        Me.Text = "Quad Tech Power Source Test"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnSendADETestCommand As System.Windows.Forms.Button
    Friend WithEvents btnStopADETest As System.Windows.Forms.Button
    Friend WithEvents cboxComPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cCurrent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSlew As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTime As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
