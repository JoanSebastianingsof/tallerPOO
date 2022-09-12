Public Class Suma : Inherits Operacion
    Dim resultadoSuma As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarSuma() As Double
        resultadoSuma = num1 + num2
        Return resultadoSuma

    End Function
End Class
