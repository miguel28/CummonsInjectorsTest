Imports System.IO.Ports

Public Class QuadTechPwSrc42000
    Implements IProgPowSrc

    Private port As SerialPort
    Private current As Double
    Private voltage As Double
    Private CurrentProfiles(4) As CurrentProf

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
        'If port.IsOpen Then port.Write("SOUR:CURR " + a.ToString())
    End Sub

    Public Sub SetCurrentLimit(a As Double) Implements IProgPowSrc.SetCurrentLimit
        'If port.IsOpen Then port.Write("SOUR:CURR:LIMIT:HIGH " + a.ToString())
    End Sub

    Public Sub SetOnline(online As Boolean) Implements IProgPowSrc.SetOnline
        'If online = True Then
        'port.Open()
        'port.Write("CONF:REM ON")
        'port.Write("CONFigure: OUTPut")
        'Else
        'port.Write("CONFigure: OUTPut OFF")
        'port.Write("CONF:REM OFF")
        'port.Close()
        'End If

        If online = True Then
            With Me.port
                If Not .IsOpen Then
                    .Open()
                End If
                .Write("*CLS" & Chr(13) & Chr(10))
                .Write("*RST" & Chr(13) & Chr(10))
                .Write("*ESE" & Chr(13) & Chr(10))
                .Write("*SRE" & Chr(13) & Chr(10))
                .Write("PROG:MODE LIST" & Chr(13) & Chr(10))
                .Write("PROG:SEL 1" & Chr(13) & Chr(10))
                .Write("PROG:LINK 1" & Chr(13) & Chr(10))
                .Write("PROG:COUNT 1" & Chr(13) & Chr(10))

                .Write("PROG:SEQ:SEL 1" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TYPE 0" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:VOLT 30" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR " & GetVal(0, 0) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR:SLEW " & GetVal(1, 0) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TIME " & GetVal(2, 0) & Chr(13) & Chr(10))

                .Write("PROG:SEQ:SEL 2" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TYPE 0" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:VOLT 30" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR " & GetVal(0, 1) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR:SLEW " & GetVal(1, 1) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TIME " & GetVal(2, 1) & Chr(13) & Chr(10))

                .Write("PROG:SEQ:SEL 3" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TYPE 0" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:VOLT 30" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR " & GetVal(0, 2) & Chr(13) & Chr(10))
                '.Write("PROG:SEQ:CURR:SLEW " & GetVal(1,2) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TIME " & GetVal(2, 2) & Chr(13) & Chr(10))

                .Write("PROG:SEQ:SEL 4" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TYPE 0" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:VOLT 30" & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR " & GetVal(0, 3) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:CURR:SLEW " & GetVal(1, 3) & Chr(13) & Chr(10))
                .Write("PROG:SEQ:TIME " & GetVal(2, 3) & Chr(13) & Chr(10))

                .Write("PROG:RUN ON" & Chr(13) & Chr(10))
                .Close()
            End With
        Else
            Me.port.Open()
            Me.port.Write("PROG:RUN OFF" & Chr(13) & Chr(10))
            Me.port.Close()
        End If
    End Sub

    Public Sub SetVoltage(v As Double) Implements IProgPowSrc.SetVoltage
        If port.IsOpen Then port.Write("SOUR:VOLT " + v.ToString())
    End Sub

    Private Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Console.WriteLine("Data Received:")
        Console.Write(indata)
    End Sub

    Public Sub SetValues(values() As CurrentProf) Implements IProgPowSrc.SetValues
        CurrentProfiles = values
    End Sub

    Private Function GetVal(c As Integer, r As Integer) As String
        GetVal = CurrentProfiles(r).GetValue(c)
    End Function
End Class
