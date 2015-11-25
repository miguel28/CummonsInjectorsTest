Public Class frmPassword

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.Text <> "adesecretpass" Then
            frmMain.GetInstance().Hide()
            StateMachine.GetInstace().EnterMaintenanceMode(True)

            Dim maintenanceWin As frmMaintenance
            maintenanceWin = New frmMaintenance()
            maintenanceWin.Show()

            Me.Dispose()
        Else
            MessageBox.Show("El password que ingreso es incorrecto", _
                            "Password Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub
End Class