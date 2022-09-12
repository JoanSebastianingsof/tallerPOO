Module Module1

    Sub Main()


        Dim num1, num2 As Double

        Console.WriteLine("Escribir numero 1")
            num1 = Console.ReadLine()

        Console.WriteLine("Escribir numero 2")
        num2 = Console.ReadLine()
        Dim sumas As New Suma(num1, num2)
        Dim restas As New Resta(num1, num2)
        Dim multiplicacion As New Multiplicacion(num1, num2)
        Dim divison As New Division(num1, num2)
        Dim potencia As New Potencia(num1, num2)
        Dim raiz As New Raiz(num1, num2)



        Console.WriteLine("El resultado de la suma es :" & sumas.realizarSuma())
        Console.WriteLine("El resultado de la resta es :" & restas.realizarResta())
        Console.WriteLine("El resultado de la multiplicacion es :" & multiplicacion.realizarMultiplicacion())
        Console.WriteLine("El resultado de la division es :" & divison.realizarDivision())
        Console.WriteLine("El resultado de la Potencia {0} es :", num1)
        Console.WriteLine(potencia.realizarPotencia1())
        Console.WriteLine("El resultado de la Potencia {0} es :", num2)
        Console.WriteLine(potencia.realizarPotencia2())
        Console.WriteLine("El resultado de la Raiz {0} es :", num1)
        Console.WriteLine(raiz.realizarRaiz1())
        Console.WriteLine("El resultado de la Raiz {0} es :", num2)
        Console.WriteLine(raiz.realizarRaiz2())


        Console.ReadLine()

















        'Dim suma, resta, multiplicacion, division, potencia1, potencia2, raiz1, raiz2 As Double


        'suma = num1 + num2
        'multiplicacion = num1 * num2
        'resta = num1 - num2
        'division = num1 / num2
        'potencia1 = num1 * num1
        'potencia2 = num2 * num2
        'raiz1 = num1 ^ (1 / 2)
        'raiz2 = num2 ^ (1 / 2)



        'Console.WriteLine("La suma entre {0} y {1} es :", num1, num2)
        'Console.WriteLine(suma)
        'Console.WriteLine("La resta entre {0} y {1} es :", num1, num2)
        'Console.WriteLine(resta)
        'Console.WriteLine("La multiplicacion entre {0} y {1} es :", num1, num2)
        'Console.WriteLine(multiplicacion)
        'Console.WriteLine("La division entre {0} y {1} es :", num1, num2)
        'Console.WriteLine(division)
        'Console.WriteLine("El numero {0} al cuadrado es :", num1)
        'Console.WriteLine(potencia1)
        'Console.WriteLine("El numero {0} al cuadrado es :", num2)
        'Console.WriteLine(potencia2)
        'Console.WriteLine("La raiz cuadrada de: {0} es :", num1)
        'Console.WriteLine(raiz1)
        'Console.WriteLine("La raiz cuadrada de: {0} es  :", num2)
        'Console.WriteLine(raiz2)
        Console.ReadLine()
    End Sub

End Module
