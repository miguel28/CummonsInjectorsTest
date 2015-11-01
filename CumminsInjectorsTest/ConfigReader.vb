Imports Newtonsoft.Json
Imports System.IO

Public Class ConfigReader
    Public UseEmulator As Boolean
    Public PowerSourceComPortName As String
    Public PowerSourceComPortBaud As Integer

    ' Inputs Configurations
    Public INPeasureSwitch As Short
    Public INAntiTieDown As Short
    Public INPistonRetracted As Short
    Public INPistonExtended As Short

    ' Outpus Configurations
    Public OUTRetractPiston As Short
    Public OUTExtendPiston As Short
    Public Sub New()
        ' Loads Default Configuration
        UseEmulator = True
        PowerSourceComPortName = "COM1"
        PowerSourceComPortBaud = 9600

        INPeasureSwitch = 5
        INAntiTieDown = 0
        INPistonRetracted = 1
        INPistonExtended = 2

        OUTRetractPiston = 0
        OUTExtendPiston = 1
    End Sub

    Public Shared Function LoadConfg() As ConfigReader
        Dim str As String
        str = File.ReadAllText("config.ini")
        LoadConfg = JsonConvert.DeserializeObject(Of ConfigReader)(str)
    End Function

    Public Sub SaveConfig()
        Dim str As String
        str = JsonConvert.SerializeObject(Me)
        File.WriteAllText("config.ini", str)
    End Sub

End Class
