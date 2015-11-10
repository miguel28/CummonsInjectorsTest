Imports System.IO.Ports
Imports AutomationLib
Public Class frmDistanceTest

    Private distanceMeter As IDistanceMeter

    Private Sub frmDistanceTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxComPort.Items.AddRange(SerialPort.GetPortNames())
        If cboxComPort.Items.Count > 0 Then cboxComPort.SelectedIndex = 0
        cboxBaud.SelectedIndex = 0


    End Sub

    Private Sub btnSendADETestCommand_Click(sender As Object, e As EventArgs) Handles btnSendADETestCommand.Click
        distanceMeter = New LK_G_Distance(cboxComPort.Items(cboxComPort.SelectedIndex), _
                                          Convert.ToInt32(cboxBaud.Items(cboxBaud.SelectedIndex)))
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        distanceMeter.Update(0)
        RealTimeChart1.AddValue(distanceMeter.ReadValue(0))
    End Sub
End Class
