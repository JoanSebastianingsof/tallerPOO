Public Class Cuadrado : Inherits Figura
    Dim tamañoLados As Integer
    Dim numeroLados As Integer
    Public Sub New(alto As Double, ancho As Double, area As Double, perimetro As Double, tamañoLados As Integer, numeroLados As Integer)
        MyBase.New(alto, ancho, area, perimetro)
        Me.tamañoLados = tamañoLados
        Me.numeroLados = numeroLados
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
