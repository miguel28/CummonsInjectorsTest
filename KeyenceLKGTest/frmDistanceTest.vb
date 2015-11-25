Imports System.IO.Ports
Imports AutomationLib
Imports KeyenceWrapper

Public Class frmDistanceTest
    Private distanceMeter As IDistanceMeter

    Private Sub frmDistanceTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        distanceMeter = New LKGKeyenceUSB()
    End Sub

    Private Sub btnSendADETestCommand_Click(sender As Object, e As EventArgs) Handles btnSendADETestCommand.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        distanceMeter.Update(0)
        Dim val As Double
        val = distanceMeter.ReadValue(0)
        RealTimeChart1.AddValue(val)
        lblDistance.Text = val.ToString()
    End Sub

    'Private Sub ReadValues(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim CalcData1 As LKIF_FLOATVALUE
    'Dim CalcData2 As LKIF_FLOATVALUE
    'Dim success As Boolean

    '   success = Keyence.LKIF_GetCalcData(CalcData1, CalcData2)

    '    If (success) Then

    '        MeasurementValue1 = CalcData1
    '        MeasurementValue2 = CalcData2
    '        If MeasurementValue1.Value > -0.5 Then
    '            RealTimeChart1.AddValue((MeasurementValue1.Value * 50) + 50)
    '        End If
    '        Label3.Text = MeasurementValue1.Value.ToString()
    '    Else

    '       MessageBox.Show("Unable to get measurment.")
    '   End If

    'End Sub
End Class
