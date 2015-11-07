Imports System.IO.Ports

Public Class frmPwrTest

    Private Sub btnSendADETestCommand_Click(sender As Object, e As EventArgs) Handles btnSendADETestCommand.Click
        If cboxComPort.Items.Count = 0 Then Exit Sub

        With Me.SerialPort1
            .PortName = cboxComPort.Items(cboxComPort.SelectedIndex)
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

    End Sub

    Private Sub btnStopADETest_Click(sender As Object, e As EventArgs) Handles btnStopADETest.Click
        Me.SerialPort1.Open()
        Me.SerialPort1.Write("PROG:RUN OFF" & Chr(13) & Chr(10))
        Me.SerialPort1.Close()
    End Sub

    Private Sub frmPwrTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxComPort.Items.AddRange(SerialPort.GetPortNames())
        If cboxComPort.Items.Count > 0 Then cboxComPort.SelectedIndex = 0

        DataGridView1.Rows.Add({"1.0", "1", "0.025"})
        DataGridView1.Rows.Add({"2.0", "1", "0.025"})
        DataGridView1.Rows.Add({"0.5", "1", "0.01"})
        DataGridView1.Rows.Add({"0.0", "1", "0.0"})

    End Sub

    Private Function GetVal(c As Integer, r As Integer) As String
        Dim val = CType(DataGridView1.Rows(r).Cells(c).Value, String)
        GetVal = val
    End Function
End Class
