Imports Newtonsoft.Json
Imports System.IO
Imports AutomationLib

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

    Public CHNCurrent As Short
    Public CHNCurrentScale As Double

    Public DISTChannel As Short
    Public NumberSamples As Integer

    Public CurrentProfiles(3) As CurrentProf

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

        CHNCurrent = 0
        CHNCurrentScale = 1 / (UShort.MaxValue / 100)

        DISTChannel = 0

        NumberSamples = 1024

        CurrentProfiles(0) = New CurrentProf("30", "0.0", "1", "0.025")
        CurrentProfiles(1) = New CurrentProf("30", "5.0", "1", "0.025")
        CurrentProfiles(2) = New CurrentProf("30", "5.0", "1", "0.01")
        CurrentProfiles(3) = New CurrentProf("30", "0.0", "1", "0.0")
    End Sub

    Public Shared Function LoadConfg() As ConfigReader
        Dim str As String
        str = File.ReadAllText("config.ini")
        LoadConfg = JsonConvert.DeserializeObject(Of ConfigReader)(str)
    End Function

    Public Sub SaveConfig()
        Dim str As String
        str = JsonConvert.SerializeObject(Me, Formatting.Indented)
        File.WriteAllText("config.ini", str)
    End Sub
End Class
