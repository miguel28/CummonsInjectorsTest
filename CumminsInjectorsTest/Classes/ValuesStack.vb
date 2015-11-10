Imports System.Collections
Imports System.IO

Public Class ValuesStack
    Private values As Stack(Of Double)

    Public Sub New(size As Integer)
        values = New Stack(Of Double)(size)
    End Sub

    Public Sub Push(value As Double)
        values.Push(value)
    End Sub

    Public Sub Save(name As String)
        If Directory.Exists("TestResult") Then
            Directory.CreateDirectory("TestResult")
        End If

        Dim temp As String = ""

        For Each value In values
            temp += value.ToString() + Chr(13)
        Next

        File.WriteAllText("TestResult\" + name, temp)
    End Sub

End Class
