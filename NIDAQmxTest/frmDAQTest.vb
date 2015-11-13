Imports AutomationLib

Public Class Form1
    Private analog As IAnalogIn
    Private scalew As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim val As Double
        val = analog.GetAnalogIn(0) * 20.0
        RealTimeChart1.AddValue(val)
        Label1.Text = analog.GetAnalogIn(0).ToString() + " , " + val.ToString()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        analog = New NIAnalog6210()
        scalew = 1 / (UShort.MaxValue / 100)

        Timer1.Start()
    End Sub
End Class
