<Serializable>
Public Class Neuron
    Public Property ID As String
    Public Property Type As NeuronType
    Public Property Inputs As Double()
    Public Property Weights As Double()
    Public Property BiasWeight As Double
    Public Property [Error] As Double
    Sub New()
        Me.ID = Guid.NewGuid().ToString
    End Sub
    Sub New(Type As NeuronType)
        Me.Type = Type
        Me.Inputs = New Double(2) {}
        Me.Weights = New Double(2) {}
        Me.ID = Guid.NewGuid().ToString
    End Sub
    Public Sub Randomize()
        Me.Weights(0) = Me.Random.NextDouble()
        Me.Weights(1) = Me.Random.NextDouble()
        Me.BiasWeight = Me.Random.NextDouble()
    End Sub
    Public Sub Cycle()
        Me.Weights(0) += Me.Error * Inputs(0)
        Me.Weights(1) += Me.Error * Inputs(1)
        Me.BiasWeight += Me.Error
    End Sub
    Public ReadOnly Property Output As Double
        Get
            Return Sigmoid.Output(Me.Weights(0) * Me.Inputs(0) + Me.Weights(1) * Me.Inputs(1) + Me.BiasWeight)
        End Get
    End Property
    Public Function Random() As Random
        Static rnd As New Random(Me.GetHashCode)
        Return rnd
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("[{0}] Output: {1} Bias: {2} Error: {3}", Me.Type, Me.Output, Me.BiasWeight, Me.Error)
    End Function
End Class
