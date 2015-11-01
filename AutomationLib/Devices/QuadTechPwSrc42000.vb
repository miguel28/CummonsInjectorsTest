Imports System.IO.Ports

Public Class QuadTechPwSrc42000
    Implements IProgPowSrc
    Private port As SerialPort
    Private current As Double
    Private voltage As Double

    Public Sub New(Name As String, Baud As Integer)
        port = New SerialPort(Name, Baud)
        AddHandler port.DataReceived, AddressOf DataReceivedHandler
    End Sub

    Public Function GetCurrent() As Double Implements IProgPowSrc.GetCurrent
        GetCurrent = current
    End Function

    Public Function GetVoltage() As Double Implements IProgPowSrc.GetVoltage
        GetVoltage = voltage
    End Function

    Public Sub SetCurrent(a As Double) Implements IProgPowSrc.SetCurrent
        If port.IsOpen Then port.Write("SOUR:CURR " + a.ToString())
    End Sub

    Public Sub SetCurrentLimit(a As Double) Implements IProgPowSrc.SetCurrentLimit
        If port.IsOpen Then port.Write("SOUR:CURR:LIMIT:HIGH " + a.ToString())

    End Sub

    Public Sub SetOnline(online As Boolean) Implements IProgPowSrc.SetOnline
        If online = True Then
            port.Open()
            port.Write("CONF:REM ON")
            port.Write("CONFigure: OUTPut")
        Else
            port.Write("CONFigure: OUTPut OFF")
            port.Write("CONF:REM OFF")
            port.Close()
        End If
    End Sub

    Public Sub SetVoltage(v As Double) Implements IProgPowSrc.SetVoltage
        If port.IsOpen Then port.Write("SOUR:VOLT " + v.ToString())
    End Sub

    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Console.WriteLine("Data Received:")
        Console.Write(indata)
    End Sub

End Class
