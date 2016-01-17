Imports System.Windows.Forms
Imports System.Drawing

Public Class frmIOEmulator
    Private Shared instance As frmIOEmulator
    Private BtnInputs(8) As Button
    Private PnlOutputs(8) As Panel
    Private virtIO As VirtualIO
    Private AnalogLabels(4) As Label

    Public Inputs As UInteger
    Public Outputs As UInteger

    Public ActualCurrent As Double
    Public ActualVoltage As Double
    Public OutputVoltage As Double
    Public OutputCurrent As Double
    Public CurrentLimit As Double

    Public AnalogChannels(4) As AnalogChannel

    Public Distance As Double

    Public Shared Function GetInstance() As frmIOEmulator
        GetInstance = instance
    End Function

    Private Sub AddInputsOutputs()
        virtIO = New VirtualIO()

        Dim i As Integer
        For i = 0 To 7
            Dim btn As Button
            btn = New Button()
            btn.Size = New Size(30, 30)
            btn.BackColor = Color.Gray
            btn.Location = New Point(10 + (i * 40), 50)
            btn.Name = i.ToString()
            btn.Tag = False
            AddHandler btn.Click, AddressOf InputClicked
            Me.grpIO.Controls.Add(btn)

            Dim pnl As Panel
            pnl = New Panel()
            pnl.Size = New Size(30, 30)
            pnl.BackColor = Color.Gray
            pnl.Location = New Point(10 + (i * 40), 120)
            pnl.Tag = i
            Me.grpIO.Controls.Add(pnl)

            BtnInputs(i) = btn
            PnlOutputs(i) = pnl
        Next

    End Sub

    Private Sub CreateAnalogIns()
        Dim i As Integer
        For i = 0 To 2
            AnalogChannels(i) = New AnalogChannel()

            Dim label As Label
            label = New Label()
            label.Text = "Channel " + i.ToString()
            label.Location = New Point(10, 20 + (i * 45))
            label.AutoSize = True
            Me.grpAnalogChannels.Controls.Add(label)
            AnalogLabels(i) = label


            Dim tbr As TrackBar
            tbr = New TrackBar
            tbr.Maximum = UShort.MaxValue
            tbr.Location = New Point(90, 20 + (i * 45))
            tbr.Size = New Size(300, 30)
            tbr.Tag = i
            AddHandler tbr.ValueChanged, AddressOf tbrModified
            Me.grpAnalogChannels.Controls.Add(tbr)

        Next
    End Sub

    Private Sub frmIOEmulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        instance = Me
        AddInputsOutputs()
        CreateAnalogIns()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        virtIO.Outputs = Outputs

        Dim i As Integer
        For i = 0 To 7
            If virtIO.GetOutput(i) = True Then
                PnlOutputs(i).BackColor = Color.Green
            Else
                PnlOutputs(i).BackColor = Color.Gray
            End If

            If virtIO.GetInput(i) = True Then
                BtnInputs(i).BackColor = Color.Green
            Else
                BtnInputs(i).BackColor = Color.Gray
            End If
        Next

        Inputs = virtIO.Inputs

        lblInputs.Text = "Inputs: " + Convert.ToString(Inputs, 16)
        lblOutputs.Text = "Outputs: " + Convert.ToString(Outputs, 16)

        lblCurrent.Text = "Current: " + OutputCurrent.ToString()
        lblVoltage.Text = "Voltage: " + OutputVoltage.ToString()
        lblCurrentLimit.Text = "Current Limit: " + CurrentLimit.ToString()

        lblActualVol.Text = ActualVoltage.ToString()
        lblActualCur.Text = ActualCurrent.ToString()


    End Sub

    Private Sub InputClicked(sender As Object, e As EventArgs)
        Dim button As Button
        button = CType(sender, Button)

        Dim flag As Boolean
        flag = CType(button.Tag, Boolean)

        If flag = True Then
            button.BackColor = Color.Gray
            button.Tag = False
        Else
            button.BackColor = Color.Green
            button.Tag = True
        End If

        virtIO.SetInput(Convert.ToInt32(button.Name), CType(button.Tag, Boolean))
    End Sub

    Private Sub tbrModified(sender As Object, e As EventArgs)
        Dim tbr As TrackBar
        tbr = CType(sender, TrackBar)

        Dim channel As Integer
        channel = CType(tbr.Tag, Integer)

        AnalogChannels(channel).Value = tbr.Value

        AnalogLabels(channel).Text = "Channel " + channel.ToString() + ": " + tbr.Value.ToString()

    End Sub

    Private Sub frmIOEmulator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub trbVoltage_Scroll(sender As Object, e As EventArgs) Handles trbVoltage.Scroll
        ActualVoltage = trbVoltage.Value
    End Sub

    Private Sub trbCurrent_Scroll(sender As Object, e As EventArgs) Handles trbCurrent.Scroll
        ActualCurrent = trbCurrent.Value
    End Sub

    Private Sub trbDistance_Scroll(sender As Object, e As EventArgs) Handles trbDistance.Scroll
        Distance = trbDistance.Value / 100000.0
        lblDistanceVal.Text = Distance.ToString()
    End Sub
End Class