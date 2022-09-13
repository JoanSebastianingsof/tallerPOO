Public Class Octagono : Inherits Figura

    Dim tamañoLado1 As Double
    Dim tamañoLado2 As Double
    Dim tamañoLado3 As Double
    Dim tamañoLado4 As Double
    Dim tamañoLado5 As Double
    Dim tamañoLado6 As Double
    Dim tamañoLado7 As Double
    Dim tamañoLado8 As Double


    Public Sub New(alto As Double, ancho As Double, area As Double, perimetro As Double, tamañoLado1 As Double, tamañoLado2 As Double, tamañoLado3 As Double, tamañoLado4 As Double, tamañoLado5 As Double, tamañoLado6 As Double, tamañoLado7 As Double, tamañoLado8 As Double)
        MyBase.New(alto, ancho, area, perimetro)
        Me.tamañoLado1 = tamañoLado1
        Me.tamañoLado2 = tamañoLado2
        Me.tamañoLado3 = tamañoLado3
        Me.tamañoLado4 = tamañoLado4
        Me.tamañoLado5 = tamañoLado5
        Me.tamañoLado6 = tamañoLado6
        Me.tamañoLado7 = tamañoLado7
        Me.tamañoLado8 = tamañoLado8


    End Sub


    Public Function calcularArea()
        area = alto * ancho
        Return area
    End Function
    Public Function calcularPerimetro()
        perimetro = tamañoLado1 + tamañoLado2 + tamañoLado3 + tamañoLado4 + tamañoLado5 + tamañoLado6 + tamañoLado7 + tamañoLado8
        Return perimetro
    End Function


End Class
