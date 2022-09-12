Public Class Figura
    Implements IArea
    Implements IPerimetro

    Private _alto As Double
    Private _ancho As Double
    Private _numeroLados As Integer
    Private _tamañoLados As Integer



    Public Sub New()
        _alto = 0
        _ancho = 0
        _numeroLados = 0
        _tamañoLados = 0
    End Sub

    Public Sub New(alto As Double, ancho As Double, numeroLados As Integer, tamañoLados As Integer)
        _alto = alto
        _ancho = ancho
        _numeroLados = numeroLados
        _tamañoLados = tamañoLados
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

    Public Property numeroLados As Integer Implements IPerimetro.numeroLados
        Get
            Return _numeroLados
        End Get
        Set(value As Integer)
            _numeroLados = value
        End Set
    End Property

    Public Property tamañoLados As Double Implements IPerimetro.tamañoLados
        Get
            Return _tamañoLados
        End Get
        Set(value As Double)
            _tamañoLados = value

        End Set
    End Property


End Class
