Public Class Figura
    Implements IArea
    Implements ICalculo

    Private _alto As Double
    Private _ancho As Double
    Private _area As Double
    Private _perimetro As Double



    Public Sub New()
        _alto = 0
        _ancho = 0
        _area = 0
        _perimetro = 0
    End Sub

    Public Sub New(alto As Double, ancho As Double, area As Double, perimetro As Double)
        _alto = alto
        _ancho = ancho
        _area = area
        _perimetro = perimetro

    End Sub

    Public Property alto As Double Implements IArea.alto
        Get
            Return _alto
        End Get
        Set(value As Double)
            _alto = value
        End Set
    End Property

    Public Property ancho As Double Implements IArea.ancho
        Get
            Return _ancho
        End Get
        Set(value As Double)
            _ancho = value

        End Set
    End Property

    Public Property area As Double Implements ICalculo.area
        Get
            Return _area
        End Get
        Set(value As Double)
            _area = value
        End Set
    End Property

    Public Property perimetro As Double Implements ICalculo.perimetro
        Get
            Return _perimetro
        End Get
        Set(value As Double)
            _perimetro = value
        End Set
    End Property
End Class
