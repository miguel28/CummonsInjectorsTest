Imports System.IO.Ports

Public Class LKGKeyenceSerial
    Implements IDistanceMeter

    Private _Distance(3) As Double
    Private tempBuffer As String
    Private port As SerialPort

    Public Sub New(portName As String, baud As Integer)
        port = New SerialPort(portName, baud)
        port.Open()
        tempBuffer = ""

        AddHandler port.DataReceived, AddressOf DataReceivedHandler
    End Sub

    Public Function ReadValue(channel As Integer) As Double Implements IDistanceMeter.ReadValue
        If channel > 2 Then channel = 2
        ReadValue = _Distance(channel)
    End Function

    Public Sub ReceivedCommand(cmd As String) Implements IDistanceMeter.ReceivedCommand
        If (cmd.Contains("M")) Then ' is a measure
            Dim channel As Integer = Asc(cmd(1))
            Dim index As Integer = cmd.IndexOf("[")
            Dim value As String = cmd.Substring(2, index - 2).Replace(" ", "").Replace("+", "")

            _Distance(channel) = Convert.ToDouble(value)
        End If
    End Sub

    Public Sub SendCommand(cmd As String) Implements IDistanceMeter.SendCommand
        If port.IsOpen Then port.Write(cmd + Chr(13))
    End Sub

    Public Sub Update(channel As Integer) Implements IDistanceMeter.Update
        SendCommand("M" + Chr(channel) + Chr(13))
    End Sub

    Private Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)

        Dim sp As SerialPort = CType(sender, SerialPort)
        tempBuffer += sp.ReadExisting()
        If tempBuffer.Contains(Chr(13)) Then
            ReceivedCommand(tempBuffer)
            tempBuffer = ""
        End If
    End Sub

End Class
