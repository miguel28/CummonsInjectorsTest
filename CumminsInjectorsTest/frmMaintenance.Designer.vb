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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpIOTest = New System.Windows.Forms.GroupBox()
        Me.tmrUpdateIO = New System.Windows.Forms.Timer()
        Me.lblInputs = New System.Windows.Forms.Label()
        Me.lblOutputs = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpIOTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Location = New System.Drawing.Point(661, 3)
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.grpIOTest, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 562)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 525)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(778, 34)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'grpIOTest
        '
        Me.grpIOTest.Controls.Add(Me.lblOutputs)
        Me.grpIOTest.Controls.Add(Me.lblInputs)
        Me.grpIOTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpIOTest.Location = New System.Drawing.Point(3, 3)
        Me.grpIOTest.Name = "grpIOTest"
        Me.grpIOTest.Size = New System.Drawing.Size(778, 94)
        Me.grpIOTest.TabIndex = 4
        Me.grpIOTest.TabStop = False
        Me.grpIOTest.Text = "IO Test"
        '
        'tmrUpdateIO
        '
        Me.tmrUpdateIO.Enabled = True
        Me.tmrUpdateIO.Interval = 10
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
        'lblOutputs
        '
        Me.lblOutputs.AutoSize = True
        Me.lblOutputs.Location = New System.Drawing.Point(9, 16)
        Me.lblOutputs.Name = "lblOutputs"
        Me.lblOutputs.Size = New System.Drawing.Size(44, 13)
        Me.lblOutputs.TabIndex = 1
        Me.lblOutputs.Text = "Outputs"
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla de mantenimiendo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpIOTest.ResumeLayout(False)
        Me.grpIOTest.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpIOTest As System.Windows.Forms.GroupBox
    Friend WithEvents tmrUpdateIO As System.Windows.Forms.Timer
    Friend WithEvents lblOutputs As System.Windows.Forms.Label
    Friend WithEvents lblInputs As System.Windows.Forms.Label
End Class
