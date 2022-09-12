Module Module1

    Sub Main()
        Dim alto, ancho, tamañoLados As Double
        Dim numeroLados As Integer
        Console.WriteLine("cuadrado")
        'Console.WriteLine("alto")
        'alto = Console.ReadLine()
        'Console.WriteLine("ancho")
        'ancho = Console.ReadLine()
        'Console.WriteLine("Cuando mide cada lado")
        'tamañoLados = Console.ReadLine()
        alto = 5.2
        ancho = 5.2
        tamañoLados = 5.2
        numeroLados = 4
        Dim cuadrado As New Cuadrado(alto, ancho, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & cuadrado.calcularArea())
        Console.WriteLine("El perimetro es de :" & cuadrado.calcularPerimetro())



        alto = 5
        ancho = 10
        tamañoLados = 5.2
        numeroLados = 4

        Dim rectangulo As New Rectangulo(alto, ancho, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & rectangulo.calcularArea())
        Console.WriteLine("El perimetro es de :" & rectangulo.calcularPerimetro())


        alto = 10
        ancho = 10
        tamañoLados = 20
        numeroLados = 4

        Dim hexagono As New Hexagono(alto, ancho, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & hexagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & hexagono.calcularPerimetro())

        alto = 10
        ancho = 10
        tamañoLados = 50
        numeroLados = 4

        Dim octagono As New Octagono(alto, ancho, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & octagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & octagono.calcularPerimetro())

        alto = 10
        ancho = 10
        tamañoLados = 30
        numeroLados = 4

        Dim pentagono As New Pentagono(alto, ancho, numeroLados, tamañoLados)
        Console.WriteLine("El area es de :" & pentagono.calcularArea())
        Console.WriteLine("El perimetro es de :" & pentagono.calcularPerimetro())

        Console.ReadLine()
    End Sub

End Module
