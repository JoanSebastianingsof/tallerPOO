Public Class Raiz : Inherits Operacion
    Dim resultadoRaiz1 As Double
    Dim resultadoRaiz2 As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarRaiz1() As Double
        resultadoRaiz1 = num1 ^ (1 / 2)


        Return resultadoRaiz1

    End Function
    Public Function realizarRaiz2() As Double
        resultadoRaiz2 = num2 ^ (1 / 2)

        Return resultadoRaiz2

    End Function
End Class
