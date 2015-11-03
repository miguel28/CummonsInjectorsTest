Public Class VirtualPowSrc
    Implements IProgPowSrc

    Public Sub New()

    End Sub

    Public Function GetCurrent() As Double Implements IProgPowSrc.GetCurrent
        GetCurrent = frmIOEmulator.GetInstance().ActualCurrent
    End Function

    Public Function GetVoltage() As Double Implements IProgPowSrc.GetVoltage
        GetVoltage = frmIOEmulator.GetInstance().ActualVoltage
    End Function

    Public Sub SetCurrent(a As Double) Implements IProgPowSrc.SetCurrent
        frmIOEmulator.GetInstance().OutputCurrent = a
    End Sub

    Public Sub SetCurrentLimit(a As Double) Implements IProgPowSrc.SetCurrentLimit
        frmIOEmulator.GetInstance().CurrentLimit = a
    End Sub

    Public Sub SetOnline(online As Boolean) Implements IProgPowSrc.SetOnline

    End Sub

    Public Sub SetVoltage(v As Double) Implements IProgPowSrc.SetVoltage
        frmIOEmulator.GetInstance().OutputVoltage = v
    End Sub
End Class
