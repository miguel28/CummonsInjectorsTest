Imports AutomationLib

Public Class frmMaintenance
    Private BtnOutputs(8) As Button
    Private PnlInputs(8) As Panel
    Private virtIO As VirtualIO
    Private configReader As ConfigReader
    Private profCurrent(3) As CurrentProf

    Private TestPowerSource As Boolean

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

    Private Sub LoadCurrentProfile()
        Dim i As Integer
        Dim arr(3) As String

        configReader = StateMachine.GetInstace().config

        For i = 0 To 3
            arr(0) = "T" + (i + 1).ToString()
            arr(1) = configReader.CurrentProfiles(i).GetValue(0)
            arr(2) = configReader.CurrentProfiles(i).GetValue(1)
            arr(3) = configReader.CurrentProfiles(i).GetValue(2)
            dgvCurrentProfile.Rows.Add(arr)

            profCurrent(i) = configReader.CurrentProfiles(i).Copy()
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.GetInstance().Show()
        StateMachine.GetInstace().EnterMaintenanceMode(False)

        StateMachine.GetInstace().pwrSrc.SetValues(configReader.CurrentProfiles)
        StateMachine.GetInstace().pwrSrc.SetOnline(False)
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

        Dim current As Double = StateMachine.GetInstace().analogIn.GetAnalogIn(configReader.CHNCurrent)
        Dim distance As Double = StateMachine.GetInstace().distanceMeter.ReadValue(configReader.DISTChannel)
        chartDistance.AddValue(distance)
        chartCurrent.AddValue(current)

        lblCurrent.Text = current.ToString()
        lblDistance.Text = distance.ToString()

    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddInputsOutputs()
        LoadCurrentProfile()
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim i As Integer

        CovertProfile()
        For i = 0 To 3
            configReader.CurrentProfiles(i) = profCurrent(i).Copy()
        Next

        configReader.SaveConfig()
        MessageBox.Show("La configuracion de la maquina ha sido guardada", "Information", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CovertProfile()
        Dim i As Integer
        For i = 0 To 3
            profCurrent(i) = New CurrentProf("30", GetVal(0, i), GetVal(1, i), GetVal(2, i))
        Next
    End Sub
    Private Function GetVal(c As Integer, r As Integer) As String
        Dim val = CType(dgvCurrentProfile.Rows(r).Cells(c + 1).Value, String)
        GetVal = val
    End Function

    Private Sub btnTurnONPow_Click(sender As Object, e As EventArgs) Handles btnTurnONPow.Click
        If TestPowerSource = True Then
            StateMachine.GetInstace().pwrSrc.SetOnline(False)
            btnTurnONPow.Text = "Encender Fuente"
            btnTurnONPow.BackColor = Color.DarkGreen
        Else
            CovertProfile()
            StateMachine.GetInstace().pwrSrc.SetValues(profCurrent)
            StateMachine.GetInstace().pwrSrc.SetOnline(True)
            btnTurnONPow.Text = "Apagar Fuente"
            btnTurnONPow.BackColor = Color.Red
        End If
        TestPowerSource = Not TestPowerSource
    End Sub

    Private Sub frmMaintenance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class