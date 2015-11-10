Imports AutomationLib
Public Class Form1
    Private analog As IAnalogIn
    Private scalew As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RealTimeChart1.AddValue(analog.GetAnalogIn(0) * scalew)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        analog = New NIAnalog6210Nat()
        scalew = 1 / (UShort.MaxValue / 100)

        Timer1.Start()
    End Sub
End Class
