Public Class Potencia : Inherits Operacion
    Dim resultadoPotencia1 As Double
    Dim resultadoPotencia2 As Double
    Public Sub New(num1 As Double, num2 As Double)
        MyBase.New(num1, num2)
    End Sub
    Public Function realizarPotencia1() As Double
        resultadoPotencia1 = num1 ^ 2
        Return resultadoPotencia1

    End Function
    Public Function realizarPotencia2() As Double

        resultadoPotencia2 = num2 ^ 2
        Return resultadoPotencia2

    End Function

End Class
