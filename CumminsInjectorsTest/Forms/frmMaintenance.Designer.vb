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
        Dim ChartLineStyle7 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle8 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle9 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle10 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle11 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Dim ChartLineStyle12 As HMIControls.ChartLineStyle = New HMIControls.ChartLineStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpIOTest = New System.Windows.Forms.GroupBox()
        Me.lblOutputs = New System.Windows.Forms.Label()
        Me.lblInputs = New System.Windows.Forms.Label()
        Me.grpDevTest = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New UI.Glass.Panel()
        Me.btnTurnONPow = New System.Windows.Forms.Button()
        Me.grpConfigPowsrc = New System.Windows.Forms.GroupBox()
        Me.cboxBaudRate = New System.Windows.Forms.ComboBox()
        Me.cboxComPorts = New System.Windows.Forms.ComboBox()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.lblCOMPort = New System.Windows.Forms.Label()
        Me.dgvCurrentProfile = New System.Windows.Forms.DataGridView()
        Me.cRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCurrent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSlew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.chartDistance = New HMIControls.RealTimeChart()
        Me.chartCurrent = New HMIControls.RealTimeChart()
        Me.Panel2 = New UI.Glass.Panel()
        Me.btnDisScaleApply = New System.Windows.Forms.Button()
        Me.numDisMax = New System.Windows.Forms.NumericUpDown()
        Me.numDisMin = New System.Windows.Forms.NumericUpDown()
        Me.lblDisMax = New System.Windows.Forms.Label()
        Me.lblMinValue = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblGDistance = New System.Windows.Forms.Label()
        Me.Panel3 = New UI.Glass.Panel()
        Me.btnCurrentApply = New System.Windows.Forms.Button()
        Me.numCurMax = New System.Windows.Forms.NumericUpDown()
        Me.numAmpPerCount = New System.Windows.Forms.NumericUpDown()
        Me.lblAmpByCount = New System.Windows.Forms.Label()
        Me.numCurMin = New System.Windows.Forms.NumericUpDown()
        Me.lblCurrentMax = New System.Windows.Forms.Label()
        Me.lblCurrentMin = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblgCurrent = New System.Windows.Forms.Label()
        Me.tmrUpdateIO = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grpIOTest.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpConfigPowsrc.SuspendLayout()
        CType(Me.dgvCurrentProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.numDisMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDisMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.numCurMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmpPerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCurMin, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(823, 396)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'grpIOTest
        '
        Me.grpIOTest.BackColor = System.Drawing.Color.Transparent
        Me.grpIOTest.Controls.Add(Me.lblOutputs)
        Me.grpIOTest.Controls.Add(Me.lblInputs)
        Me.grpIOTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpIOTest.Location = New System.Drawing.Point(3, 3)
        Me.grpIOTest.Name = "grpIOTest"
        Me.grpIOTest.Size = New System.Drawing.Size(817, 194)
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
        Me.lblInputs.Location = New System.Drawing.Point(9, 92)
        Me.lblInputs.Name = "lblInputs"
        Me.lblInputs.Size = New System.Drawing.Size(36, 13)
        Me.lblInputs.TabIndex = 0
        Me.lblInputs.Text = "Inputs"
        '
        'grpDevTest
        '
        Me.grpDevTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDevTest.Location = New System.Drawing.Point(3, 203)
        Me.grpDevTest.Name = "grpDevTest"
        Me.grpDevTest.Size = New System.Drawing.Size(817, 190)
        Me.grpDevTest.TabIndex = 5
        Me.grpDevTest.TabStop = False
        Me.grpDevTest.Text = "Prueba de Dispositivos"
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnTurnONPow)
        Me.Panel1.Controls.Add(Me.grpConfigPowsrc)
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
        'btnTurnONPow
        '
        Me.btnTurnONPow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTurnONPow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTurnONPow.Location = New System.Drawing.Point(95, 181)
        Me.btnTurnONPow.Name = "btnTurnONPow"
        Me.btnTurnONPow.Size = New System.Drawing.Size(121, 40)
        Me.btnTurnONPow.TabIndex = 6
        Me.btnTurnONPow.Text = "Encender Fuente"
        Me.btnTurnONPow.UseVisualStyleBackColor = False
        '
        'grpConfigPowsrc
        '
        Me.grpConfigPowsrc.Controls.Add(Me.cboxBaudRate)
        Me.grpConfigPowsrc.Controls.Add(Me.cboxComPorts)
        Me.grpConfigPowsrc.Controls.Add(Me.lblBaud)
        Me.grpConfigPowsrc.Controls.Add(Me.lblCOMPort)
        Me.grpConfigPowsrc.Location = New System.Drawing.Point(35, 236)
        Me.grpConfigPowsrc.Name = "grpConfigPowsrc"
        Me.grpConfigPowsrc.Size = New System.Drawing.Size(241, 81)
        Me.grpConfigPowsrc.TabIndex = 10
        Me.grpConfigPowsrc.TabStop = False
        Me.grpConfigPowsrc.Text = "Configuracion de Puerto COM"
        '
        'cboxBaudRate
        '
        Me.cboxBaudRate.FormattingEnabled = True
        Me.cboxBaudRate.Items.AddRange(New Object() {"9600", "19200", "57600", "115200"})
        Me.cboxBaudRate.Location = New System.Drawing.Point(98, 50)
        Me.cboxBaudRate.Name = "cboxBaudRate"
        Me.cboxBaudRate.Size = New System.Drawing.Size(137, 21)
        Me.cboxBaudRate.TabIndex = 10
        '
        'cboxComPorts
        '
        Me.cboxComPorts.FormattingEnabled = True
        Me.cboxComPorts.Location = New System.Drawing.Point(98, 19)
        Me.cboxComPorts.Name = "cboxComPorts"
        Me.cboxComPorts.Size = New System.Drawing.Size(137, 21)
        Me.cboxComPorts.TabIndex = 8
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Location = New System.Drawing.Point(6, 50)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(58, 13)
        Me.lblBaud.TabIndex = 9
        Me.lblBaud.Text = "Baud Rate"
        '
        'lblCOMPort
        '
        Me.lblCOMPort.AutoSize = True
        Me.lblCOMPort.Location = New System.Drawing.Point(6, 22)
        Me.lblCOMPort.Name = "lblCOMPort"
        Me.lblCOMPort.Size = New System.Drawing.Size(38, 13)
        Me.lblCOMPort.TabIndex = 7
        Me.lblCOMPort.Text = "Puerto"
        '
        'dgvCurrentProfile
        '
        Me.dgvCurrentProfile.AllowUserToAddRows = False
        Me.dgvCurrentProfile.AllowUserToDeleteRows = False
        Me.dgvCurrentProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentProfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRecord, Me.cCurrent, Me.cSlew, Me.cTime})
        Me.dgvCurrentProfile.Location = New System.Drawing.Point(8, 12)
        Me.dgvCurrentProfile.Name = "dgvCurrentProfile"
        Me.dgvCurrentProfile.Size = New System.Drawing.Size(306, 152)
        Me.dgvCurrentProfile.TabIndex = 5
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
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(823, 396)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'chartDistance
        '
        Me.chartDistance.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle7.Color = System.Drawing.Color.Black
        ChartLineStyle7.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle7.Width = 1.0!
        Me.chartDistance.ChartStyle.AverageLineStyle = ChartLineStyle7
        Me.chartDistance.ChartStyle.BottomColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartLineStyle8.Color = System.Drawing.Color.Yellow
        ChartLineStyle8.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle8.Width = 2.0!
        Me.chartDistance.ChartStyle.LineStyle = ChartLineStyle8
        Me.chartDistance.ChartStyle.MaxValue = 100
        Me.chartDistance.ChartStyle.MinValue = 0
        Me.chartDistance.ChartStyle.SecondTimeScale = 5
        Me.chartDistance.ChartStyle.ShowAverageLine = False
        Me.chartDistance.ChartStyle.ShowGrid = True
        Me.chartDistance.ChartStyle.ShowSecondScale = False
        Me.chartDistance.ChartStyle.ShowTargetLine = False
        Me.chartDistance.ChartStyle.TargetValue = 15
        ChartLineStyle9.Color = System.Drawing.Color.LightGray
        ChartLineStyle9.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle9.Width = 2.0!
        Me.chartDistance.ChartStyle.TargetValueLineStyle = ChartLineStyle9
        Me.chartDistance.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.chartDistance.ChartStyle.TopColorBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chartDistance.ChartStyle.ValueSpacing = 6
        Me.chartDistance.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartDistance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartDistance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartDistance.Location = New System.Drawing.Point(3, 3)
        Me.chartDistance.Name = "chartDistance"
        Me.chartDistance.Size = New System.Drawing.Size(405, 240)
        Me.chartDistance.TabIndex = 1
        '
        'chartCurrent
        '
        Me.chartCurrent.BackColor = System.Drawing.Color.Transparent
        ChartLineStyle10.Color = System.Drawing.Color.Black
        ChartLineStyle10.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle10.Width = 1.0!
        Me.chartCurrent.ChartStyle.AverageLineStyle = ChartLineStyle10
        Me.chartCurrent.ChartStyle.BottomColorBackground = System.Drawing.Color.LightGreen
        ChartLineStyle11.Color = System.Drawing.Color.Yellow
        ChartLineStyle11.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle11.Width = 2.0!
        Me.chartCurrent.ChartStyle.LineStyle = ChartLineStyle11
        Me.chartCurrent.ChartStyle.MaxValue = 100
        Me.chartCurrent.ChartStyle.MinValue = 0
        Me.chartCurrent.ChartStyle.SecondTimeScale = 5
        Me.chartCurrent.ChartStyle.ShowAverageLine = False
        Me.chartCurrent.ChartStyle.ShowGrid = True
        Me.chartCurrent.ChartStyle.ShowSecondScale = False
        Me.chartCurrent.ChartStyle.ShowTargetLine = False
        Me.chartCurrent.ChartStyle.TargetValue = 50
        ChartLineStyle12.Color = System.Drawing.Color.Black
        ChartLineStyle12.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartLineStyle12.Width = 1.0!
        Me.chartCurrent.ChartStyle.TargetValueLineStyle = ChartLineStyle12
        Me.chartCurrent.ChartStyle.TimeScale = CType(15UI, UInteger)
        Me.chartCurrent.ChartStyle.TopColorBackground = System.Drawing.Color.DarkGreen
        Me.chartCurrent.ChartStyle.ValueSpacing = 6
        Me.chartCurrent.ChartStyle.VerticalScale = CType(10UI, UInteger)
        Me.chartCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chartCurrent.Location = New System.Drawing.Point(414, 3)
        Me.chartCurrent.Name = "chartCurrent"
        Me.chartCurrent.Size = New System.Drawing.Size(406, 240)
        Me.chartCurrent.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDisScaleApply)
        Me.Panel2.Controls.Add(Me.numDisMax)
        Me.Panel2.Controls.Add(Me.numDisMin)
        Me.Panel2.Controls.Add(Me.lblDisMax)
        Me.Panel2.Controls.Add(Me.lblMinValue)
        Me.Panel2.Controls.Add(Me.lblDistance)
        Me.Panel2.Controls.Add(Me.lblGDistance)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(3, 249)
        Me.Panel2.MouseReflection = True
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Opacity = 25
        Me.Panel2.Radius = 5.0!
        Me.Panel2.Size = New System.Drawing.Size(405, 144)
        Me.Panel2.TabIndex = 3
        '
        'btnDisScaleApply
        '
        Me.btnDisScaleApply.Location = New System.Drawing.Point(271, 45)
        Me.btnDisScaleApply.Name = "btnDisScaleApply"
        Me.btnDisScaleApply.Size = New System.Drawing.Size(75, 48)
        Me.btnDisScaleApply.TabIndex = 7
        Me.btnDisScaleApply.Text = "Aplicar"
        Me.btnDisScaleApply.UseVisualStyleBackColor = True
        '
        'numDisMax
        '
        Me.numDisMax.DecimalPlaces = 6
        Me.numDisMax.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.numDisMax.Location = New System.Drawing.Point(118, 73)
        Me.numDisMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 196608})
        Me.numDisMax.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147287040})
        Me.numDisMax.Name = "numDisMax"
        Me.numDisMax.Size = New System.Drawing.Size(120, 20)
        Me.numDisMax.TabIndex = 6
        Me.numDisMax.Value = New Decimal(New Integer() {5, 0, 0, 196608})
        '
        'numDisMin
        '
        Me.numDisMin.DecimalPlaces = 6
        Me.numDisMin.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.numDisMin.Location = New System.Drawing.Point(118, 45)
        Me.numDisMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 131072})
        Me.numDisMin.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147287040})
        Me.numDisMin.Name = "numDisMin"
        Me.numDisMin.Size = New System.Drawing.Size(120, 20)
        Me.numDisMin.TabIndex = 5
        Me.numDisMin.Value = New Decimal(New Integer() {5, 0, 0, -2147287040})
        '
        'lblDisMax
        '
        Me.lblDisMax.AutoSize = True
        Me.lblDisMax.Location = New System.Drawing.Point(16, 73)
        Me.lblDisMax.Name = "lblDisMax"
        Me.lblDisMax.Size = New System.Drawing.Size(70, 13)
        Me.lblDisMax.TabIndex = 3
        Me.lblDisMax.Text = "Valor Maximo"
        '
        'lblMinValue
        '
        Me.lblMinValue.AutoSize = True
        Me.lblMinValue.Location = New System.Drawing.Point(16, 45)
        Me.lblMinValue.Name = "lblMinValue"
        Me.lblMinValue.Size = New System.Drawing.Size(67, 13)
        Me.lblMinValue.TabIndex = 2
        Me.lblMinValue.Text = "Valor Minimo"
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
        'lblGDistance
        '
        Me.lblGDistance.AutoSize = True
        Me.lblGDistance.Location = New System.Drawing.Point(13, 12)
        Me.lblGDistance.Name = "lblGDistance"
        Me.lblGDistance.Size = New System.Drawing.Size(101, 13)
        Me.lblGDistance.TabIndex = 0
        Me.lblGDistance.Text = "Grafica de distancia"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnCurrentApply)
        Me.Panel3.Controls.Add(Me.numCurMax)
        Me.Panel3.Controls.Add(Me.numAmpPerCount)
        Me.Panel3.Controls.Add(Me.lblAmpByCount)
        Me.Panel3.Controls.Add(Me.numCurMin)
        Me.Panel3.Controls.Add(Me.lblCurrentMax)
        Me.Panel3.Controls.Add(Me.lblCurrentMin)
        Me.Panel3.Controls.Add(Me.lblCurrent)
        Me.Panel3.Controls.Add(Me.lblgCurrent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(414, 249)
        Me.Panel3.MouseReflection = True
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Opacity = 25
        Me.Panel3.Radius = 5.0!
        Me.Panel3.Size = New System.Drawing.Size(406, 144)
        Me.Panel3.TabIndex = 4
        '
        'btnCurrentApply
        '
        Me.btnCurrentApply.Location = New System.Drawing.Point(314, 38)
        Me.btnCurrentApply.Name = "btnCurrentApply"
        Me.btnCurrentApply.Size = New System.Drawing.Size(75, 48)
        Me.btnCurrentApply.TabIndex = 8
        Me.btnCurrentApply.Text = "Aplicar"
        Me.btnCurrentApply.UseVisualStyleBackColor = True
        '
        'numCurMax
        '
        Me.numCurMax.DecimalPlaces = 3
        Me.numCurMax.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numCurMax.Location = New System.Drawing.Point(179, 71)
        Me.numCurMax.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numCurMax.Name = "numCurMax"
        Me.numCurMax.Size = New System.Drawing.Size(120, 20)
        Me.numCurMax.TabIndex = 13
        Me.numCurMax.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numAmpPerCount
        '
        Me.numAmpPerCount.DecimalPlaces = 6
        Me.numAmpPerCount.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.numAmpPerCount.Location = New System.Drawing.Point(179, 102)
        Me.numAmpPerCount.Maximum = New Decimal(New Integer() {10, 0, 0, 196608})
        Me.numAmpPerCount.Minimum = New Decimal(New Integer() {10, 0, 0, -2147287040})
        Me.numAmpPerCount.Name = "numAmpPerCount"
        Me.numAmpPerCount.Size = New System.Drawing.Size(120, 20)
        Me.numAmpPerCount.TabIndex = 12
        Me.numAmpPerCount.Value = New Decimal(New Integer() {-2067592143, 1608041384, 258143, 1835008})
        '
        'lblAmpByCount
        '
        Me.lblAmpByCount.AutoSize = True
        Me.lblAmpByCount.Location = New System.Drawing.Point(14, 104)
        Me.lblAmpByCount.Name = "lblAmpByCount"
        Me.lblAmpByCount.Size = New System.Drawing.Size(168, 13)
        Me.lblAmpByCount.TabIndex = 11
        Me.lblAmpByCount.Text = "Factor de Conversion de Corriente"
        '
        'numCurMin
        '
        Me.numCurMin.DecimalPlaces = 3
        Me.numCurMin.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numCurMin.Location = New System.Drawing.Point(180, 43)
        Me.numCurMin.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numCurMin.Name = "numCurMin"
        Me.numCurMin.Size = New System.Drawing.Size(120, 20)
        Me.numCurMin.TabIndex = 9
        '
        'lblCurrentMax
        '
        Me.lblCurrentMax.AutoSize = True
        Me.lblCurrentMax.Location = New System.Drawing.Point(14, 73)
        Me.lblCurrentMax.Name = "lblCurrentMax"
        Me.lblCurrentMax.Size = New System.Drawing.Size(70, 13)
        Me.lblCurrentMax.TabIndex = 8
        Me.lblCurrentMax.Text = "Valor Maximo"
        '
        'lblCurrentMin
        '
        Me.lblCurrentMin.AutoSize = True
        Me.lblCurrentMin.Location = New System.Drawing.Point(14, 45)
        Me.lblCurrentMin.Name = "lblCurrentMin"
        Me.lblCurrentMin.Size = New System.Drawing.Size(67, 13)
        Me.lblCurrentMin.TabIndex = 7
        Me.lblCurrentMin.Text = "Valor Minimo"
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
        'lblgCurrent
        '
        Me.lblgCurrent.AutoSize = True
        Me.lblgCurrent.Location = New System.Drawing.Point(14, 12)
        Me.lblgCurrent.Name = "lblgCurrent"
        Me.lblgCurrent.Size = New System.Drawing.Size(100, 13)
        Me.lblgCurrent.TabIndex = 0
        Me.lblgCurrent.Text = "Grafica de corriente"
        '
        'tmrUpdateIO
        '
        Me.tmrUpdateIO.Interval = 10
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.grpIOTest.ResumeLayout(False)
        Me.grpIOTest.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.grpConfigPowsrc.ResumeLayout(False)
        Me.grpConfigPowsrc.PerformLayout()
        CType(Me.dgvCurrentProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numDisMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDisMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.numCurMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmpPerCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCurMin, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboxComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents lblCOMPort As System.Windows.Forms.Label
    Friend WithEvents grpConfigPowsrc As System.Windows.Forms.GroupBox
    Friend WithEvents cboxBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblBaud As System.Windows.Forms.Label
    Friend WithEvents lblDisMax As System.Windows.Forms.Label
    Friend WithEvents lblMinValue As System.Windows.Forms.Label
    Friend WithEvents numDisMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDisMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnDisScaleApply As System.Windows.Forms.Button
    Friend WithEvents numAmpPerCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAmpByCount As System.Windows.Forms.Label
    Friend WithEvents numCurMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCurrentMax As System.Windows.Forms.Label
    Friend WithEvents lblCurrentMin As System.Windows.Forms.Label
    Friend WithEvents numCurMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCurrentApply As System.Windows.Forms.Button
End Class
