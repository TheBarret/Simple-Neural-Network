Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class Simple
    Public Property Training As Boolean
    Public Property Neurons As List(Of Neuron)
    <NonSerialized> Public Event TrainingStarted()
    <NonSerialized> Public Event TrainingStopped()
    <NonSerialized> Public Event TrainingCycle(index As Integer, x As Double, y As Double, output As Double)
    Sub New()
        Me.Neurons = New List(Of Neuron)
        Me.Reset()
    End Sub
    Public Sub Reset()
        Me.Neurons.Clear()
        Me.Neurons.Add(New Neuron(NeuronType.Hidden))
        Me.Neurons.Add(New Neuron(NeuronType.Hidden))
        Me.Neurons.Add(New Neuron(NeuronType.Hidden))
        Me.Neurons.Add(New Neuron(NeuronType.Hidden))
        Me.Neurons.Add(New Neuron(NeuronType.Output))
        Me.Randomize()
    End Sub
    Public Sub Abort()
        Me.Training = False
    End Sub
    Public Sub Resolve(x As Double(), y As Double())
        If (x.Length = y.Length) Then
            Dim NH1 As Neuron = Me.GetNeuron(NeuronType.Hidden, 0)
            Dim NH2 As Neuron = Me.GetNeuron(NeuronType.Hidden, 1)
            Dim NH3 As Neuron = Me.GetNeuron(NeuronType.Hidden, 2)
            Dim NH4 As Neuron = Me.GetNeuron(NeuronType.Hidden, 3)
            Dim NOUT As Neuron = Me.GetNeuron(NeuronType.Output)
            For i As Integer = 0 To x.Length - 1
                NH1.Inputs = New Double() {x(i), y(i)}
                NH2.Inputs = New Double() {x(i), y(i)}
                NH3.Inputs = New Double() {x(i), y(i)}
                NH4.Inputs = New Double() {x(i), y(i)}
                NOUT.Inputs = New Double() {NH1.Output, NH2.Output, NH3.Output, NH4.Output}
                RaiseEvent TrainingCycle(i, x(i), y(i), NOUT.Output)
            Next
        End If
    End Sub
    Public Sub Train(x As Double(), y As Double(), Results As Double())
        Try
            Dim epoch As Integer = 0

            Dim NH1 As Neuron = Me.GetNeuron(NeuronType.Hidden, 0)
            Dim NH2 As Neuron = Me.GetNeuron(NeuronType.Hidden, 1)
            Dim NH3 As Neuron = Me.GetNeuron(NeuronType.Hidden, 2)
            Dim NH4 As Neuron = Me.GetNeuron(NeuronType.Hidden, 3)
            Dim NOUT As Neuron = Me.GetNeuron(NeuronType.Output)

            Me.Training = True
            RaiseEvent TrainingStarted()

            Do
                epoch += 1
                For i As Integer = 0 To Results.Length - 1
                    NH1.Inputs = New Double() {x(i), y(i)}
                    NH2.Inputs = New Double() {x(i), y(i)}
                    NH3.Inputs = New Double() {x(i), y(i)}
                    NH4.Inputs = New Double() {x(i), y(i)}
                    NOUT.Inputs = New Double() {NH1.Output, NH2.Output, NH3.Output, NH4.Output}

                    If (epoch Mod 100 = 0 And epoch <> 0) Then
                        RaiseEvent TrainingCycle(i, x(i), y(i), NOUT.Output)
                    End If

                    NOUT.Error = Sigmoid.F(NOUT.Output) * (Results(i) - NOUT.Output)
                    NOUT.Cycle()

                    NH1.Error = Sigmoid.F(NH1.Output) * NOUT.Error * NOUT.Weights(0)
                    NH2.Error = Sigmoid.F(NH2.Output) * NOUT.Error * NOUT.Weights(1)
                    NH3.Error = Sigmoid.F(NH3.Output) * NOUT.Error * NOUT.Weights(0)
                    NH4.Error = Sigmoid.F(NH4.Output) * NOUT.Error * NOUT.Weights(1)

                    NH1.Cycle()
                    NH2.Cycle()
                    NH3.Cycle()
                    NH4.Cycle()
                Next
            Loop Until Not Me.Training
        Catch ex As Exception
            Debugger.Break()
        Finally
            RaiseEvent TrainingStopped()
        End Try

    End Sub
    Public Sub SaveAs(filename As String)
        Me.Serialize().SaveAs(filename)
    End Sub
    Private Sub Randomize()
        If (Me.Neurons.Any) Then Me.Neurons.ForEach(Sub(n) n.Randomize())
    End Sub
    Private Function GetNeuron(Type As NeuronType) As Neuron
        Return (From n As Neuron In Me.Neurons Where n.Type = Type).FirstOrDefault
    End Function
    Private Function GetNeuron(Type As NeuronType, Index As Integer) As Neuron
        Return (From n As Neuron In Me.Neurons Where n.Type = Type Select Me.Neurons.ElementAt(Index)).FirstOrDefault
    End Function
End Class
