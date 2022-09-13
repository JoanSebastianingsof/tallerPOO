Public Class Rectangulo : Inherits Figura

    Dim tamañoLado1 As Double
    Dim tamañoLado2 As Double


    Public Sub New(alto As Double, ancho As Double, area As Double, perimetro As Double, tamañoLado1 As Double, tamañoLado2 As Double)
        MyBase.New(alto, ancho, area, perimetro)
        Me.tamañoLado1 = tamañoLado1
        Me.tamañoLado2 = tamañoLado2



    End Sub


    Public Function calcularArea()
        area = alto * ancho
        Return area
    End Function
    Public Function calcularPerimetro()
        perimetro = tamañoLado1 + tamañoLado2
        Return perimetro
    End Function


End Class
