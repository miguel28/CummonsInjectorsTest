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
        Dim ChartLineStyle31 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle32 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle33 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ChartLineStyle34 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle35 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle36 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Me.chartDistance = New HMIControls.RealTimeChart()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chartCurrent = New HMIControls.RealTimeChart()
        Me.btnBeginMeasure = New System.Windows.Forms.Button()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.lblPartNumber = New System.Windows.Forms.Label()
        Me.Panel2 = New UI.Glass.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.Panel3 = New UI.Glass.Panel()
        Me.Panel1 = New UI.Glass.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chartDistance
        '
        Me.chartDistance.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle31.Color = System.Drawing.Color.Black
        ChartLineStyle31.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle31.Width = 1.0!
        Me.chartDistance.ChartStyle.AverageLineStyle = ChartLineStyle31
        Me.chartDistance.ChartStyle.BottomColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartLineStyle32.Color = System.Drawing.Color.Yellow
        ChartLineStyle32.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle32.Width = 2.0!
        Me.chartDistance.ChartStyle.LineStyle = ChartLineStyle32
        Me.chartDistance.ChartStyle.MaxValue = 100
        Me.chartDistance.ChartStyle.MinValue = 0
        Me.chartDistance.ChartStyle.SecondTimeScale = 5
        Me.chartDistance.ChartStyle.ShowAverageLine = False
        Me.chartDistance.ChartStyle.ShowGrid = True
        Me.chartDistance.ChartStyle.ShowSecondScale = False
        Me.chartDistance.ChartStyle.ShowTargetLine = True
        Me.chartDistance.ChartStyle.TargetValue = 50
        ChartLineStyle33.Color = System.Drawing.Color.LightGray
        ChartLineStyle33.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle33.Width = 2.0!
        Me.chartDistance.ChartStyle.TargetValueLineStyle = ChartLineStyle33
        Me.chartDistance.ChartStyle.TimeScale = CType(30UI, UInteger)
        Me.chartDistance.ChartStyle.TopColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chartDistance.ChartStyle.ValueSpacing = 2
        Me.chartDistance.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartDistance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartDistance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartDistance.Location = New System.Drawing.Point(203, 3)
        Me.chartDistance.Name = "chartDistance"
        Me.chartDistance.Size = New System.Drawing.Size(641, 157)
        Me.chartDistance.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 472)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(847, 94)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(3, 3)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(204, 54)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Inicializar Maquina"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.chartDistance, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chartCurrent, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(847, 326)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'chartCurrent
        '
        Me.chartCurrent.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle34.Color = System.Drawing.Color.Black
        ChartLineStyle34.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle34.Width = 1.0!
        Me.chartCurrent.ChartStyle.AverageLineStyle = ChartLineStyle34
        Me.chartCurrent.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle35.Color = System.Drawing.Color.Yellow
        ChartLineStyle35.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle35.Width = 2.0!
        Me.chartCurrent.ChartStyle.LineStyle = ChartLineStyle35
        Me.chartCurrent.ChartStyle.MaxValue = 100
        Me.chartCurrent.ChartStyle.MinValue = 0
        Me.chartCurrent.ChartStyle.SecondTimeScale = 5
        Me.chartCurrent.ChartStyle.ShowAverageLine = False
        Me.chartCurrent.ChartStyle.ShowGrid = True
        Me.chartCurrent.ChartStyle.ShowSecondScale = False
        Me.chartCurrent.ChartStyle.ShowTargetLine = False
        Me.chartCurrent.ChartStyle.TargetValue = 50
        ChartLineStyle36.Color = System.Drawing.Color.Black
        ChartLineStyle36.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle36.Width = 1.0!
        Me.chartCurrent.ChartStyle.TargetValueLineStyle = ChartLineStyle36
        Me.chartCurrent.ChartStyle.TimeScale = CType(30UI, UInteger)
        Me.chartCurrent.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.chartCurrent.ChartStyle.ValueSpacing = 2
        Me.chartCurrent.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartCurrent.Location = New System.Drawing.Point(203, 166)
        Me.chartCurrent.Name = "chartCurrent"
        Me.chartCurrent.Size = New System.Drawing.Size(641, 157)
        Me.chartCurrent.TabIndex = 1
        '
        'btnBeginMeasure
        '
        Me.btnBeginMeasure.Enabled = False
        Me.btnBeginMeasure.Location = New System.Drawing.Point(10, 55)
        Me.btnBeginMeasure.Name = "btnBeginMeasure"
        Me.btnBeginMeasure.Size = New System.Drawing.Size(108, 44)
        Me.btnBeginMeasure.TabIndex = 2
        Me.btnBeginMeasure.Text = "Empezar a Medir"
        Me.btnBeginMeasure.UseVisualStyleBackColor = True
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Location = New System.Drawing.Point(10, 29)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(108, 20)
        Me.txtPartNumber.TabIndex = 1
        Me.txtPartNumber.Text = "1002345678"
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Location = New System.Drawing.Point(7, 13)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblPartNumber.TabIndex = 0
        Me.lblPartNumber.Text = "Numero de Parte"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblMessage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(103, 3)
        Me.Panel2.MouseReflection = True
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Opacity = 25
        Me.Panel2.Radius = 5.0!
        Me.Panel2.Size = New System.Drawing.Size(741, 88)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnMaintenance, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 435)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(847, 34)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaintenance.Location = New System.Drawing.Point(730, 3)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(114, 28)
        Me.btnMaintenance.TabIndex = 0
        Me.btnMaintenance.Text = "Mantenimiento"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnBeginMeasure)
        Me.Panel3.Controls.Add(Me.lblPartNumber)
        Me.Panel3.Controls.Add(Me.txtPartNumber)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.MouseReflection = True
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Opacity = 25
        Me.Panel3.Radius = 5.0!
        Me.Panel3.Size = New System.Drawing.Size(194, 157)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(3, 166)
        Me.Panel1.MouseReflection = True
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Opacity = 25
        Me.Panel1.Radius = 5.0!
        Me.Panel1.Size = New System.Drawing.Size(194, 157)
        Me.Panel1.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(853, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commins Injector Test"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chartDistance As HMIControls.RealTimeChart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chartCurrent As HMIControls.RealTimeChart
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPartNumber As System.Windows.Forms.Label
    Friend WithEvents btnBeginMeasure As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As UI.Glass.Panel
    Friend WithEvents Panel3 As UI.Glass.Panel
    Friend WithEvents Panel1 As UI.Glass.Panel

End Class
