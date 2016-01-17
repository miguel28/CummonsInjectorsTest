Imports HMIControls
Module modGraph

    Public Sub configDisGraph(chart As RealTimeChart, min As Double, max As Double)
        Dim scale As Integer
        scale = 10000

        scale = StateMachine.GetInstace().config.DistanceViewScale

        chart.ChartStyle.MinValue = min * scale
        chart.ChartStyle.MaxValue = max * scale
    End Sub

    Public Sub configCurGraph(chart As RealTimeChart, min As Double, max As Double)
        Dim scale As Integer
        scale = 1

        chart.ChartStyle.MinValue = min * scale
        chart.ChartStyle.MaxValue = max * scale
    End Sub
End Module
