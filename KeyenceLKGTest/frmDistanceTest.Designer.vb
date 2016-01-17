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
        Dim ChartLineStyle4 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle5 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle6 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Me.btnSendADETestCommand = New System.Windows.Forms.Button()
        Me.RealTimeChart1 = New HMIControls.RealTimeChart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendADETestCommand
        '
        Me.btnSendADETestCommand.Location = New System.Drawing.Point(12, 12)
        Me.btnSendADETestCommand.Name = "btnSendADETestCommand"
        Me.btnSendADETestCommand.Size = New System.Drawing.Size(75, 23)
        Me.btnSendADETestCommand.TabIndex = 4
        Me.btnSendADETestCommand.Text = "Start / Stop"
        Me.btnSendADETestCommand.UseVisualStyleBackColor = True
        '
        'RealTimeChart1
        '
        Me.RealTimeChart1.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle4.Color = System.Drawing.Color.Black
        ChartLineStyle4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle4.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.AverageLineStyle = ChartLineStyle4
        Me.RealTimeChart1.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle5.Color = System.Drawing.Color.Yellow
        ChartLineStyle5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle5.Width = 2.0!
        Me.RealTimeChart1.ChartStyle.LineStyle = ChartLineStyle5
        Me.RealTimeChart1.ChartStyle.MaxValue = 100
        Me.RealTimeChart1.ChartStyle.MinValue = 0
        Me.RealTimeChart1.ChartStyle.SecondTimeScale = 5
        Me.RealTimeChart1.ChartStyle.ShowAverageLine = False
        Me.RealTimeChart1.ChartStyle.ShowGrid = True
        Me.RealTimeChart1.ChartStyle.ShowSecondScale = False
        Me.RealTimeChart1.ChartStyle.ShowTargetLine = False
        Me.RealTimeChart1.ChartStyle.TargetValue = 50
        ChartLineStyle6.Color = System.Drawing.Color.Black
        ChartLineStyle6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle6.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.TargetValueLineStyle = ChartLineStyle6
        Me.RealTimeChart1.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.RealTimeChart1.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.RealTimeChart1.ChartStyle.ValueSpacing = 2
        Me.RealTimeChart1.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.RealTimeChart1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.RealTimeChart1.Location = New System.Drawing.Point(12, 41)
        Me.RealTimeChart1.Name = "RealTimeChart1"
        Me.RealTimeChart1.Size = New System.Drawing.Size(646, 271)
        Me.RealTimeChart1.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(226, 9)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(25, 24)
        Me.lblDistance.TabIndex = 12
        Me.lblDistance.Text = "..."
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(100, 12)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 13
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'frmDistanceTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 324)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.RealTimeChart1)
        Me.Controls.Add(Me.btnSendADETestCommand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDistanceTest"
        Me.Text = "Keyence LKG Test"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendADETestCommand As System.Windows.Forms.Button
    Friend WithEvents RealTimeChart1 As HMIControls.RealTimeChart
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown

End Class
