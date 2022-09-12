Public Class Resta : Inherits Operacion
    Dim resultadoResta As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarResta() As Double
        resultadoResta = num1 - num2
        Return resultadoResta

    End Function
End Class
