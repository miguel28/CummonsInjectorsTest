Imports AutomationLib
Public Class frmIO
    Dim io As MCDaqUSB
    Dim a As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        io.Outputs = Val(TextBox1.Text)
        io.Update()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        io = New MCDaqUSB()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = io.Inputs.ToString()
        io.Update()
    End Sub
End Class
