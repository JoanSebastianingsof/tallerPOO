Public Class Rectangulo : Inherits Figura
    Dim area As Double
    Dim perimetro As Double
    Public Sub New(alto As Double, ancho As Double, numeroLados As Integer, tamañoLados As Integer)
        MyBase.New(alto, ancho, numeroLados, tamañoLados)
    End Sub


    Public Function calcularArea()
        area = alto * ancho
        Return area
    End Function
    Public Function calcularPerimetro()
        perimetro = numeroLados * tamañoLados
        Return perimetro
    End Function

End Class
