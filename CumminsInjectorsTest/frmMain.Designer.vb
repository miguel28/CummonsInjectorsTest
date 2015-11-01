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
        Dim ChartLineStyle1 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle2 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle3 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle4 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle5 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle6 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RealTimeChart1 = New HMIControls.RealTimeChart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RealTimeChart2 = New HMIControls.RealTimeChart()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RealTimeChart1
        '
        Me.RealTimeChart1.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle1.Color = System.Drawing.Color.Black
        ChartLineStyle1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle1.Width = 1.0!
        Me.RealTimeChart1.ChartStyle.AverageLineStyle = ChartLineStyle1
        Me.RealTimeChart1.ChartStyle.BottomColorBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.RealTimeChart1.ChartStyle.TimeScale = CType(30UI, UInteger)
        Me.RealTimeChart1.ChartStyle.TopColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RealTimeChart1.ChartStyle.ValueSpacing = 2
        Me.RealTimeChart1.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.RealTimeChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RealTimeChart1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.RealTimeChart1.Location = New System.Drawing.Point(203, 3)
        Me.RealTimeChart1.Name = "RealTimeChart1"
        Me.RealTimeChart1.Size = New System.Drawing.Size(555, 162)
        Me.RealTimeChart1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CumminsInjectorsTest.My.Resources.Resources.cummins
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 472)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMessage, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(761, 94)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.RealTimeChart1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RealTimeChart2, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(761, 336)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'RealTimeChart2
        '
        Me.RealTimeChart2.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle4.Color = System.Drawing.Color.Black
        ChartLineStyle4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle4.Width = 1.0!
        Me.RealTimeChart2.ChartStyle.AverageLineStyle = ChartLineStyle4
        Me.RealTimeChart2.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle5.Color = System.Drawing.Color.Black
        ChartLineStyle5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle5.Width = 1.0!
        Me.RealTimeChart2.ChartStyle.LineStyle = ChartLineStyle5
        Me.RealTimeChart2.ChartStyle.MaxValue = 100
        Me.RealTimeChart2.ChartStyle.MinValue = 0
        Me.RealTimeChart2.ChartStyle.SecondTimeScale = 5
        Me.RealTimeChart2.ChartStyle.ShowAverageLine = False
        Me.RealTimeChart2.ChartStyle.ShowGrid = True
        Me.RealTimeChart2.ChartStyle.ShowSecondScale = False
        Me.RealTimeChart2.ChartStyle.ShowTargetLine = False
        Me.RealTimeChart2.ChartStyle.TargetValue = 50
        ChartLineStyle6.Color = System.Drawing.Color.Black
        ChartLineStyle6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle6.Width = 1.0!
        Me.RealTimeChart2.ChartStyle.TargetValueLineStyle = ChartLineStyle6
        Me.RealTimeChart2.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.RealTimeChart2.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.RealTimeChart2.ChartStyle.ValueSpacing = 2
        Me.RealTimeChart2.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.RealTimeChart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RealTimeChart2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.RealTimeChart2.Location = New System.Drawing.Point(203, 171)
        Me.RealTimeChart2.Name = "RealTimeChart2"
        Me.RealTimeChart2.Size = New System.Drawing.Size(555, 162)
        Me.RealTimeChart2.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMessage.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(103, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(655, 94)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Inicializar Maquina"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(767, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Commins Injector Test"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RealTimeChart1 As HMIControls.RealTimeChart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RealTimeChart2 As HMIControls.RealTimeChart
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
