Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMain
    Public Property Network As Simple
    Public Property Buffer As List(Of Double)
    Public Property Multiplier As Integer = 100
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Initialize()
        Me.btnQuery.PerformClick()
    End Sub
    Private Sub btnTrain_Click(sender As Object, e As EventArgs) Handles btnTrain.Click
        Call New Threading.Thread(AddressOf Me.StartTraining) With {.IsBackground = True}.Start()
    End Sub
    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        Me.Network.Abort()
        Me.Network.SaveAs(".\Network.bin")
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Network.Reset()
    End Sub
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Me.RandomizeSamples()
        Me.Network.Resolve(Me.StringToDoubles(Me.tbSampleSetA.Text), Me.StringToDoubles(Me.tbSampleSetB.Text))
    End Sub
    Private Sub RandomizeSamples()
        If (Me.InvokeRequired) Then
            Me.Invoke(Sub() Me.RandomizeSamples())
        Else
            Static rnd As New Random(Me.GetHashCode)
            Dim a As New List(Of Integer), b As New List(Of Integer), r As New List(Of Integer)
            Me.tbSampleSetA.Clear()
            Me.tbSampleSetB.Clear()
            Me.tbResult.Clear()
            For i As Integer = 0 To 9
                a.Add(rnd.Next(0, 10))
                b.Add(rnd.Next(0, 10))
                r.Add(a.Last + b.Last)
            Next
            Me.tbSampleSetA.Text = String.Join(" ", a)
            Me.tbSampleSetB.Text = String.Join(" ", b)
            Me.tbResult.Text = String.Join(" ", r)
            Me.CreateCharts(r)
        End If
    End Sub
    Private Sub CreateCharts(data As List(Of Integer))
        Me.Buffer.Clear()
        Me.Chart.Series.Clear()
        Me.Chart.Series.Add("Input")
        Me.Chart.Series("Input").Color = Color.Cyan
        Me.Chart.Series("Input").XValueType = ChartValueType.Double
        Me.Chart.Series("Input").ChartType = SeriesChartType.Column
        Me.Chart.Series.Add("Output")
        Me.Chart.Series("Output").Color = Color.Blue
        Me.Chart.Series("Output").XValueType = ChartValueType.Double
        Me.Chart.Series("Output").ChartType = SeriesChartType.Spline
        Me.Chart.Series("Output").MarkerStyle = MarkerStyle.Circle
        Me.Chart.Series("Output").MarkerSize = 5
        Me.Chart.Series("Output").MarkerBorderWidth = 1
        For j As Integer = 0 To data.Count - 1
            Me.Chart.Series("Input").Points.AddXY(j, data(j))
            Me.Buffer.Add(0)
        Next
    End Sub
    Private Function StringToDoubles(value As String) As Double()
        If (value.Contains(" ")) Then
            Dim values As New List(Of Double), current As Double
            For Each str As String In value.Split(" "c)
                If (Not Double.TryParse(str, current)) Then
                    Throw New Exception("sample data contains invalid values")
                End If
                values.Add(current / Me.Multiplier)
            Next
            Return values.ToArray
        End If
        Return New Double() {}
    End Function
    Private Sub Initialize()
        Me.Buffer = New List(Of Double)
        If (Not File.Exists(".\Network.bin")) Then
            Me.Network = New Simple
        Else
            Me.Network = File.ReadAllBytes(".\Network.bin").Deserialize(Of Simple)()
        End If
        AddHandler Network.TrainingStarted, AddressOf Me.TrainingStarted
        AddHandler Network.TrainingStopped, AddressOf Me.TrainingStopped
        AddHandler Network.TrainingCycle, AddressOf Me.TrainingCycle
    End Sub
    Private Sub StartTraining()
        Me.RandomizeSamples()
        Me.Network.Train(Me.StringToDoubles(Me.tbSampleSetA.Text), Me.StringToDoubles(Me.tbSampleSetB.Text), Me.StringToDoubles(Me.tbResult.Text))
    End Sub
    Private Sub TrainingStarted()
        If (Me.InvokeRequired) Then
            Me.Invoke(Sub() Me.TrainingStarted())
        Else
            Me.btnTrain.Enabled = False
            Me.btnQuery.Enabled = False
            Me.btnReset.Enabled = False
        End If
    End Sub
    Private Sub TrainingStopped()
        If (Me.InvokeRequired) Then
            Me.Invoke(Sub() Me.TrainingStopped())
        Else
            Me.btnTrain.Enabled = True
            Me.btnQuery.Enabled = True
            Me.btnReset.Enabled = True
        End If
    End Sub
    Private Sub TrainingCycle(index As Integer, x As Double, y As Double, output As Double)
        If (Me.InvokeRequired) Then
            Me.Invoke(Sub() Me.TrainingCycle(index, x, y, output))
        Else
            Me.Buffer(index) = Math.Round(output * 100, 1)
            If (index = 9) Then
                Me.Chart.Series("Output").Points.Clear()
                For i As Integer = 0 To 9
                    Me.Chart.Series("Output").Points.AddXY(i, Me.Buffer(i))
                Next
                Me.tbNetValues.Text = String.Join(" ", Me.Buffer.Select(Function(v) Math.Round(v, 1)))
                Me.Chart.Refresh()
            End If
        End If
    End Sub
    
End Class
