Imports System.IO.Ports
Imports System.Windows.Forms
Imports KeyenceWrapper

Public Class LKGKeyenceUSB
    Implements IDistanceMeter

    Private MeasurementValue1 As LKIF_FLOATVALUE
    Private MeasurementValue2 As LKIF_FLOATVALUE
    'Private timer As Timer

    Public Sub New()
        'timer = New Timer()
        'timer.Interval = 10
        'AddHandler timer.Tick, AddressOf Timer_Update
        'timer.Enabled = True
    End Sub

    Public Function ReadValue(channel As Integer) As Double Implements IDistanceMeter.ReadValue
        If channel = 0 Then
            ReadValue = CType(MeasurementValue1.Value, Double)
        Else
            ReadValue = CType(MeasurementValue2.Value, Double)
        End If
    End Function

    Public Sub ReceivedCommand(cmd As String) Implements IDistanceMeter.ReceivedCommand

    End Sub

    Public Sub SendCommand(cmd As String) Implements IDistanceMeter.SendCommand

    End Sub

    Public Sub Update(channel As Integer) Implements IDistanceMeter.Update
        UpdateValues()
    End Sub

    Private Sub UpdateValues()
        Dim CalcData1 As LKIF_FLOATVALUE
        Dim CalcData2 As LKIF_FLOATVALUE
        Dim success As Boolean

        success = Keyence.LKIF_GetCalcData(CalcData1, CalcData2)

        If (success) Then
            MeasurementValue1 = CalcData1
            MeasurementValue2 = CalcData2
        Else
            Throw New Exception("Error Could not Read with the Keyence LKG3000")
        End If
    End Sub

    Private Sub Timer_Update(sender As Object, e As EventArgs)
        UpdateValues()
    End Sub
End Class
