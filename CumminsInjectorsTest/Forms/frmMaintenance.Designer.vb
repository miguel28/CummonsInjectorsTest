<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Dim ChartLineStyle1 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle2 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle3 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle4 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle5 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle6 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpIOTest = New System.Windows.Forms.GroupBox()
        Me.lblOutputs = New System.Windows.Forms.Label()
        Me.lblInputs = New System.Windows.Forms.Label()
        Me.tmrUpdateIO = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvCurrentProfile = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.chartDistance = New HMIControls.RealTimeChart()
        Me.chartCurrent = New HMIControls.RealTimeChart()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Panel1 = New UI.Glass.Panel()
        Me.cRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCurrent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSlew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTurnONPow = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpDevTest = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New UI.Glass.Panel()
        Me.Panel3 = New UI.Glass.Panel()
        Me.lblGDistance = New System.Windows.Forms.Label()
        Me.lblgCurrent = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpIOTest.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvCurrentProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Location = New System.Drawing.Point(720, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 474)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSaveChanges, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 437)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(837, 34)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'grpIOTest
        '
        Me.grpIOTest.BackColor = System.Drawing.Color.Transparent
        Me.grpIOTest.Controls.Add(Me.lblOutputs)
        Me.grpIOTest.Controls.Add(Me.lblInputs)
        Me.grpIOTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpIOTest.Location = New System.Drawing.Point(3, 3)
        Me.grpIOTest.Name = "grpIOTest"
        Me.grpIOTest.Size = New System.Drawing.Size(817, 94)
        Me.grpIOTest.TabIndex = 4
        Me.grpIOTest.TabStop = False
        Me.grpIOTest.Text = "IO Test"
        '
        'lblOutputs
        '
        Me.lblOutputs.AutoSize = True
        Me.lblOutputs.Location = New System.Drawing.Point(9, 16)
        Me.lblOutputs.Name = "lblOutputs"
        Me.lblOutputs.Size = New System.Drawing.Size(44, 13)
        Me.lblOutputs.TabIndex = 1
        Me.lblOutputs.Text = "Outputs"
        '
        'lblInputs
        '
        Me.lblInputs.AutoSize = True
        Me.lblInputs.Location = New System.Drawing.Point(380, 16)
        Me.lblInputs.Name = "lblInputs"
        Me.lblInputs.Size = New System.Drawing.Size(36, 13)
        Me.lblInputs.TabIndex = 0
        Me.lblInputs.Text = "Inputs"
        '
        'tmrUpdateIO
        '
        Me.tmrUpdateIO.Enabled = True
        Me.tmrUpdateIO.Interval = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(823, 396)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'dgvCurrentProfile
        '
        Me.dgvCurrentProfile.AllowUserToAddRows = False
        Me.dgvCurrentProfile.AllowUserToDeleteRows = False
        Me.dgvCurrentProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentProfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRecord, Me.cCurrent, Me.cSlew, Me.cTime})
        Me.dgvCurrentProfile.Location = New System.Drawing.Point(8, 12)
        Me.dgvCurrentProfile.Name = "dgvCurrentProfile"
        Me.dgvCurrentProfile.Size = New System.Drawing.Size(306, 181)
        Me.dgvCurrentProfile.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(837, 428)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(829, 402)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IO Control"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(829, 402)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Power Source Control"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(829, 402)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sensor Graphs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(326, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(494, 340)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.chartDistance, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chartCurrent, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(823, 396)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'chartDistance
        '
        Me.chartDistance.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle1.Color = System.Drawing.Color.Black
        ChartLineStyle1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle1.Width = 1.0!
        Me.chartDistance.ChartStyle.AverageLineStyle = ChartLineStyle1
        Me.chartDistance.ChartStyle.BottomColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartLineStyle2.Color = System.Drawing.Color.Yellow
        ChartLineStyle2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle2.Width = 2.0!
        Me.chartDistance.ChartStyle.LineStyle = ChartLineStyle2
        Me.chartDistance.ChartStyle.MaxValue = 100
        Me.chartDistance.ChartStyle.MinValue = 0
        Me.chartDistance.ChartStyle.SecondTimeScale = 5
        Me.chartDistance.ChartStyle.ShowAverageLine = False
        Me.chartDistance.ChartStyle.ShowGrid = True
        Me.chartDistance.ChartStyle.ShowSecondScale = False
        Me.chartDistance.ChartStyle.ShowTargetLine = True
        Me.chartDistance.ChartStyle.TargetValue = 50
        ChartLineStyle3.Color = System.Drawing.Color.LightGray
        ChartLineStyle3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle3.Width = 2.0!
        Me.chartDistance.ChartStyle.TargetValueLineStyle = ChartLineStyle3
        Me.chartDistance.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.chartDistance.ChartStyle.TopColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chartDistance.ChartStyle.ValueSpacing = 2
        Me.chartDistance.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartDistance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartDistance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartDistance.Location = New System.Drawing.Point(3, 3)
        Me.chartDistance.Name = "chartDistance"
        Me.chartDistance.Size = New System.Drawing.Size(405, 270)
        Me.chartDistance.TabIndex = 1
        '
        'chartCurrent
        '
        Me.chartCurrent.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle4.Color = System.Drawing.Color.Black
        ChartLineStyle4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle4.Width = 1.0!
        Me.chartCurrent.ChartStyle.AverageLineStyle = ChartLineStyle4
        Me.chartCurrent.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle5.Color = System.Drawing.Color.Yellow
        ChartLineStyle5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle5.Width = 2.0!
        Me.chartCurrent.ChartStyle.LineStyle = ChartLineStyle5
        Me.chartCurrent.ChartStyle.MaxValue = 100
        Me.chartCurrent.ChartStyle.MinValue = 0
        Me.chartCurrent.ChartStyle.SecondTimeScale = 5
        Me.chartCurrent.ChartStyle.ShowAverageLine = False
        Me.chartCurrent.ChartStyle.ShowGrid = True
        Me.chartCurrent.ChartStyle.ShowSecondScale = False
        Me.chartCurrent.ChartStyle.ShowTargetLine = False
        Me.chartCurrent.ChartStyle.TargetValue = 50
        ChartLineStyle6.Color = System.Drawing.Color.Black
        ChartLineStyle6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle6.Width = 1.0!
        Me.chartCurrent.ChartStyle.TargetValueLineStyle = ChartLineStyle6
        Me.chartCurrent.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.chartCurrent.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.chartCurrent.ChartStyle.ValueSpacing = 2
        Me.chartCurrent.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartCurrent.Location = New System.Drawing.Point(414, 3)
        Me.chartCurrent.Name = "chartCurrent"
        Me.chartCurrent.Size = New System.Drawing.Size(406, 270)
        Me.chartCurrent.TabIndex = 2
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveChanges.Location = New System.Drawing.Point(600, 3)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(114, 28)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Guardar"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnTurnONPow)
        Me.Panel1.Controls.Add(Me.dgvCurrentProfile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.MouseReflection = True
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Opacity = 25
        Me.Panel1.Radius = 5.0!
        Me.Panel1.Size = New System.Drawing.Size(317, 340)
        Me.Panel1.TabIndex = 24
        '
        'cRecord
        '
        Me.cRecord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cRecord.HeaderText = ""
        Me.cRecord.Name = "cRecord"
        Me.cRecord.Width = 19
        '
        'cCurrent
        '
        Me.cCurrent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cCurrent.HeaderText = "Current(Amp)"
        Me.cCurrent.Name = "cCurrent"
        Me.cCurrent.Width = 93
        '
        'cSlew
        '
        Me.cSlew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cSlew.HeaderText = "Slew"
        Me.cSlew.Name = "cSlew"
        Me.cSlew.Width = 55
        '
        'cTime
        '
        Me.cTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cTime.HeaderText = "Time(Segs)"
        Me.cTime.Name = "cTime"
        Me.cTime.Width = 85
        '
        'btnTurnONPow
        '
        Me.btnTurnONPow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTurnONPow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTurnONPow.Location = New System.Drawing.Point(74, 227)
        Me.btnTurnONPow.Name = "btnTurnONPow"
        Me.btnTurnONPow.Size = New System.Drawing.Size(137, 82)
        Me.btnTurnONPow.TabIndex = 6
        Me.btnTurnONPow.Text = "Encender Fuente"
        Me.btnTurnONPow.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.grpIOTest, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.grpDevTest, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(823, 396)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'grpDevTest
        '
        Me.grpDevTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDevTest.Location = New System.Drawing.Point(3, 103)
        Me.grpDevTest.Name = "grpDevTest"
        Me.grpDevTest.Size = New System.Drawing.Size(817, 290)
        Me.grpDevTest.TabIndex = 5
        Me.grpDevTest.TabStop = False
        Me.grpDevTest.Text = "Prueba de Dispositivos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblDistance)
        Me.Panel2.Controls.Add(Me.lblGDistance)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(3, 279)
        Me.Panel2.MouseReflection = True
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Opacity = 25
        Me.Panel2.Radius = 5.0!
        Me.Panel2.Size = New System.Drawing.Size(405, 114)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.lblCurrent)
        Me.Panel3.Controls.Add(Me.lblgCurrent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(414, 279)
        Me.Panel3.MouseReflection = True
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Opacity = 25
        Me.Panel3.Radius = 5.0!
        Me.Panel3.Size = New System.Drawing.Size(406, 114)
        Me.Panel3.TabIndex = 4
        '
        'lblGDistance
        '
        Me.lblGDistance.AutoSize = True
        Me.lblGDistance.Location = New System.Drawing.Point(13, 12)
        Me.lblGDistance.Name = "lblGDistance"
        Me.lblGDistance.Size = New System.Drawing.Size(101, 13)
        Me.lblGDistance.TabIndex = 0
        Me.lblGDistance.Text = "Grafica de distancia"
        '
        'lblgCurrent
        '
        Me.lblgCurrent.AutoSize = True
        Me.lblgCurrent.Location = New System.Drawing.Point(14, 12)
        Me.lblgCurrent.Name = "lblgCurrent"
        Me.lblgCurrent.Size = New System.Drawing.Size(100, 13)
        Me.lblgCurrent.TabIndex = 0
        Me.lblgCurrent.Text = "Grafica de corriente"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(159, 12)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(20, 16)
        Me.lblDistance.TabIndex = 1
        Me.lblDistance.Text = "..."
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Location = New System.Drawing.Point(168, 12)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(20, 16)
        Me.lblCurrent.TabIndex = 1
        Me.lblCurrent.Text = "..."
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 474)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla de mantenimiendo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpIOTest.ResumeLayout(False)
        Me.grpIOTest.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dgvCurrentProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpIOTest As System.Windows.Forms.GroupBox
    Friend WithEvents tmrUpdateIO As System.Windows.Forms.Timer
    Friend WithEvents lblOutputs As System.Windows.Forms.Label
    Friend WithEvents lblInputs As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCurrentProfile As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chartDistance As HMIControls.RealTimeChart
    Friend WithEvents chartCurrent As HMIControls.RealTimeChart
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents Panel1 As UI.Glass.Panel
    Friend WithEvents btnTurnONPow As System.Windows.Forms.Button
    Friend WithEvents cRecord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCurrent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSlew As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpDevTest As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As UI.Glass.Panel
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblGDistance As System.Windows.Forms.Label
    Friend WithEvents Panel3 As UI.Glass.Panel
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents lblgCurrent As System.Windows.Forms.Label
End Class
