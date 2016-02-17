Imports System.Collections
Imports System.IO

Public Class ValuesStack
    Private values As List(Of Double)
    Private reference As Double
    Private size As Integer

    Public Sub New(s As Integer)
        values = New List(Of Double)(s)
        size = s
    End Sub

    Public Sub SetReference(val As Double)
        reference = val
    End Sub

    Public Sub Push(value As Double)
        If values.Count >= size Then
            values.RemoveAt(0)
        End If
        values.Add(value)
    End Sub

    Public Sub PushRange(vals() As Double)
        Dim i As Integer
        For i = 0 To vals.Length - 1
            Push(vals(i))
        Next
    End Sub

    Public Sub Save(name As String)
        If Not Directory.Exists("TestResult") Then
            Directory.CreateDirectory("TestResult")
        End If

        Dim temp As String = ""
        temp += "Reference=," + reference.ToString() + Chr(13) & Chr(10)

        For Each value In values
            temp += value.ToString() + Chr(13) & Chr(10)
        Next

        File.WriteAllText("TestResult\" + name, temp)
    End Sub

End Class
