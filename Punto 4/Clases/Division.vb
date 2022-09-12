Public Class Division : Inherits Operacion
    Dim resultadoDivision As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarDivision() As Double
        resultadoDivision = num1 / num2
        Return resultadoDivision

    End Function
End Class
