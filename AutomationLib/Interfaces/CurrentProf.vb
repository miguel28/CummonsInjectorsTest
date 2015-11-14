Public Class CurrentProf

    Public Voltage As String
    Public Current As String
    Public Slew As String
    Public Time As String

    Public Sub New(v As String, c As String, s As String, t As String)
        Voltage = v
        Current = c
        Slew = s
        Time = t
    End Sub

    Public Function GetValue(Val As Integer) As String
        Select Case Val
            Case 0
                GetValue = Current
            Case 1
                GetValue = Slew
            Case 2
                GetValue = Time
            Case Else
                GetValue = ""
        End Select
    End Function

    Public Function Copy() As CurrentProf
        Dim neww As CurrentProf = New CurrentProf(Me.Voltage, Me.Current, Me.Slew, Me.Time)
        Copy = neww
    End Function
End Class
