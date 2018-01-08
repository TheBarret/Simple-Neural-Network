<Serializable>
Public Class Sigmoid
    Public Shared Function Output(value As Double) As Double
        Return 1 / (1 + Math.Exp(-value))
    End Function
    Public Shared Function F(value As Double) As Double
        Return value * (1 - value)
    End Function
End Class
