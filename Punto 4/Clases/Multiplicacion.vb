Public Class Multiplicacion : Inherits Operacion

    Dim resultadoMultiplicacion As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarMultiplicacion() As Double
        resultadoMultiplicacion = num1 * num2
        Return resultadoMultiplicacion

    End Function
End Class
