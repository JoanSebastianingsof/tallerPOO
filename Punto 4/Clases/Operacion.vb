Public Class Operacion

    Private _num1 As Double
    Private _num2 As Double

    Public Sub New(num1 As Double, num2 As Double)
        _num1 = num1
        _num2 = num2
    End Sub

    Public Sub New()
        _num1 = 0
        _num2 = 0

    End Sub
    Public Property num1 As Double
        Get
            Return _num1
        End Get
        Set(value As Double)
            _num1 = value
        End Set
    End Property

    Public Property num2 As Double
        Get
            Return _num2
        End Get
        Set(value As Double)
            _num2 = value
        End Set
    End Property


End Class
