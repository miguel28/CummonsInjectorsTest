Imports AutomationLib

Public Class frmMaintenance
    Private BtnOutputs(8) As Button
    Private PnlInputs(8) As Panel
    Private virtIO As VirtualIO
    Public Inputs As UInteger
    Public Outputs As UInteger

    Private Sub AddInputsOutputs()
        virtIO = StateMachine.GetInstace().ioPort

        Dim i As Integer
        For i = 0 To 7
            Dim btn As Button
            btn = New Button()
            btn.Size = New Size(30, 30)
            btn.BackColor = Color.Gray
            btn.Location = New Point(10 + (i * 40), 50)
            btn.Name = i.ToString()
            btn.Tag = False
            AddHandler btn.Click, AddressOf InputClicked
            Me.grpIOTest.Controls.Add(btn)

            Dim pnl As Panel
            pnl = New Panel()
            pnl.Size = New Size(30, 30)
            pnl.BackColor = Color.Gray
            pnl.Location = New Point(400 + (i * 40), 50)
            pnl.Tag = i
            Me.grpIOTest.Controls.Add(pnl)

            BtnOutputs(i) = btn
            PnlInputs(i) = pnl
        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.GetInstance().Show()
        Me.Dispose()
    End Sub

    Private Sub InputClicked(sender As Object, e As EventArgs)
        Dim button As Button
        button = CType(sender, Button)

        Dim flag As Boolean
        flag = CType(button.Tag, Boolean)

        If flag = True Then
            button.BackColor = Color.Gray

            button.Tag = False
        Else
            button.BackColor = Color.Green
            button.Tag = True
        End If

        virtIO.SetOutput(Convert.ToInt32(button.Name), CType(button.Tag, Boolean))
    End Sub

    Private Sub tmrUpdateIO_Tick(sender As Object, e As EventArgs) Handles tmrUpdateIO.Tick
        Dim i As Integer
        For i = 0 To 7
            If virtIO.GetInput(i) = True Then
                PnlInputs(i).BackColor = Color.Green
            Else
                PnlInputs(i).BackColor = Color.Gray
            End If

            If virtIO.GetOutput(i) = True Then
                BtnOutputs(i).BackColor = Color.Green
            Else
                BtnOutputs(i).BackColor = Color.Gray
            End If
        Next
        lblInputs.Text = "Inputs: " + Convert.ToString(virtIO.Inputs, 16)
        lblOutputs.Text = "Outputs: " + Convert.ToString(virtIO.Outputs, 16)
    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddInputsOutputs()
    End Sub
End Class