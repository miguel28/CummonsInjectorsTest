<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistanceTest
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
        Dim ChartLineStyle1 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle2 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle3 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxComPort = New System.Windows.Forms.ComboBox()
        Me.btnSendADETestCommand = New System.Windows.Forms.Button()
        Me.cboxBaud = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RealTimeChart1 = New HMIControls.RealTimeChart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Com Port"
        '
        'cboxComPort
        '
        Me.cboxComPort.FormattingEnabled = True
        Me.cboxComPort.Location = New System.Drawing.Point(73, 12)
        Me.cboxComPort.Name = "cboxComPort"
        Me.cboxComPort.Size = New System.Drawing.Size(121, 21)
        Me.cboxComPort.TabIndex = 6
        '
        'btnSendADETestCommand
        '
        Me.btnSendADETestCommand.Location = New System.Drawing.Point(209, 10)
        Me.btnSendADETestCommand.Name = "btnSendADETestCommand"
        Me.btnSendADETestCommand.Size = New System.Drawing.Size(75, 23)
        Me.btnSendADETestCommand.TabIndex = 4
        Me.btnSendADETestCommand.Text = "Start"
        Me.btnSendADETestCommand.UseVisualStyleBackColor = True
        '
        'cboxBaud
        '
        Me.cboxBaud.FormattingEnabled = True
        Me.cboxBaud.Items.AddRange(New Object() {"9600", "19200", "115200"})
        Me.cboxBaud.Location = New System.Drawing.Point(73, 39)
        Me.cboxBaud.Name = "cboxBaud"
        Me.cboxBaud.Size = New System.Drawing.Size(121, 21)
        Me.cboxBaud.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Badu Rate"
        '
        'RealTimeChart1
        '
        Me.RealTimeChart1.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle1.Color = System.Drawing.Color.Black
        ChartLineStyle1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle1.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.AverageLineStyle = ChartLineStyle1
        Me.RealTimeChart1.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle2.Color = System.Drawing.Color.Yellow
        ChartLineStyle2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle2.Width = 2.0!
        Me.RealTimeChart1.ChartStyle.LineStyle = ChartLineStyle2
        Me.RealTimeChart1.ChartStyle.MaxValue = 100
        Me.RealTimeChart1.ChartStyle.MinValue = 0
        Me.RealTimeChart1.ChartStyle.SecondTimeScale = 5
        Me.RealTimeChart1.ChartStyle.ShowAverageLine = False
        Me.RealTimeChart1.ChartStyle.ShowGrid = True
        Me.RealTimeChart1.ChartStyle.ShowSecondScale = False
        Me.RealTimeChart1.ChartStyle.ShowTargetLine = False
        Me.RealTimeChart1.ChartStyle.TargetValue = 50
        ChartLineStyle3.Color = System.Drawing.Color.Black
        ChartLineStyle3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle3.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.TargetValueLineStyle = ChartLineStyle3
        Me.RealTimeChart1.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.RealTimeChart1.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.RealTimeChart1.ChartStyle.ValueSpacing = 2
        Me.RealTimeChart1.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.RealTimeChart1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.RealTimeChart1.Location = New System.Drawing.Point(12, 84)
        Me.RealTimeChart1.Name = "RealTimeChart1"
        Me.RealTimeChart1.Size = New System.Drawing.Size(407, 228)
        Me.RealTimeChart1.TabIndex = 10
        '
        'Timer1
        '
        '
        'frmDistanceTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 324)
        Me.Controls.Add(Me.RealTimeChart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxBaud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxComPort)
        Me.Controls.Add(Me.btnSendADETestCommand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDistanceTest"
        Me.Text = "Keyence LKG Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxComPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendADETestCommand As System.Windows.Forms.Button
    Friend WithEvents cboxBaud As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RealTimeChart1 As HMIControls.RealTimeChart
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
