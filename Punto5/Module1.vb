Module Module1

    Sub Main()
        Dim alto, ancho, tamañoLados, area, perimetro As Double
        Dim numeroLados As Integer
        Console.WriteLine("cuadrado")

        alto = 5.2
        ancho = 5.2
        tamañoLados = 5.2
        numeroLados = 4
        Dim cuadrado As New Cuadrado(alto, ancho, area, perimetro, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & cuadrado.calcularArea())
        Console.WriteLine("El perimetro es de :" & cuadrado.calcularPerimetro())


        Dim tamañoLado1 As Double
        Dim tamañoLado2 As Double
        Dim tamañoLado3 As Double
        Dim tamañoLado4 As Double
        Dim tamañoLado5 As Double
        Dim tamañoLado6 As Double
        Dim tamañoLado7 As Double
        Dim tamañoLado8 As Double

        alto = 5
        ancho = 10
        tamañoLado1 = 10 'vertical
        tamañoLado2 = 15 'horizonta

        Dim rectangulo As New Rectangulo(alto, ancho, area, perimetro, tamañoLado1, tamañoLado2)
        Console.WriteLine("El area es de :" & rectangulo.calcularArea())
        Console.WriteLine("El perimetro es de :" & rectangulo.calcularPerimetro())


        alto = 10
        ancho = 10
        tamañoLado1 = 10
        tamañoLado2 = 1
        tamañoLado3 = 2
        tamañoLado4 = 3
        tamañoLado5 = 4
        tamañoLado6 = 5

        Dim hexagono As New Hexagono(alto, ancho, area, perimetro, tamañoLado1, tamañoLado2, tamañoLado3, tamañoLado4, tamañoLado5, tamañoLado6)
        Console.WriteLine("El area es de :" & hexagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & hexagono.calcularPerimetro())

        alto = 10
        ancho = 10
        tamañoLado1 = 10
        tamañoLado2 = 15
        tamañoLado3 = 7
        tamañoLado4 = 5
        tamañoLado5 = 20
        tamañoLado6 = 15
        tamañoLado7 = 3
        tamañoLado8 = 5.2

        Dim octagono As New Octagono(alto, ancho, area, perimetro, tamañoLado1, tamañoLado2, tamañoLado3, tamañoLado4, tamañoLado5, tamañoLado6, tamañoLado7, tamañoLado8)
        Console.WriteLine("El area es de :" & octagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & octagono.calcularPerimetro())

        alto = 10
        ancho = 10
        tamañoLado1 = 10
        tamañoLado2 = 9
        tamañoLado3 = 8
        tamañoLado4 = 7
        tamañoLado5 = 6

        Dim pentagono As New Pentagono(alto, ancho, area, perimetro, tamañoLado1, tamañoLado2, tamañoLado3, tamañoLado4, tamañoLado5)
        Console.WriteLine("El area es de :" & pentagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & pentagono.calcularPerimetro())

        Console.ReadLine()
    End Sub

End Module
