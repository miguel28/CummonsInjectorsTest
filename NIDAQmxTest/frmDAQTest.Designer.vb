<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.RealTimeChart1 = New HMIControls.RealTimeChart()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(13, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'RealTimeChart1
        '
        Me.RealTimeChart1.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle4.Color = System.Drawing.Color.Black
        ChartLineStyle4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle4.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.AverageLineStyle = ChartLineStyle4
        Me.RealTimeChart1.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle5.Color = System.Drawing.Color.Black
        ChartLineStyle5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle5.Width = 1.0!
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
        Me.RealTimeChart1.Location = New System.Drawing.Point(13, 43)
        Me.RealTimeChart1.Name = "RealTimeChart1"
        Me.RealTimeChart1.Size = New System.Drawing.Size(448, 277)
        Me.RealTimeChart1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 332)
        Me.Controls.Add(Me.RealTimeChart1)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "NIDAQmx Test"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents RealTimeChart1 As HMIControls.RealTimeChart

End Class
