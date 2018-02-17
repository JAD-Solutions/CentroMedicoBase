Imports System.ComponentModel
Public Class ParametrosEvaluacion
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_par As Integer
    Dim _nombre_par As String
    Dim _valor_par As Double
    Dim _fecha_par As Date
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo As Integer, ByVal nombre_par As String, ByVal valor_par As Double, ByVal fecha_par As Date)
        Me._codigo_par = codigo
        Me._nombre_par = nombre_par
        Me._valor_par = valor_par
        Me._fecha_par = fecha_par

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_par As Integer
        Get
            Return _codigo_par
        End Get
        Set(value As Integer)
            _codigo_par = value
            cambioPropiedad("Codigo_par")
        End Set
    End Property
    Public Property Nombre_par As String
        Get
            Return Me._nombre_par
        End Get
        Set(value As String)
            Me._nombre_par = value
            Me.cambioPropiedad("Nombre_par")
        End Set
    End Property

    Public Property Valor_par As Double
        Get
            Return Me._valor_par
        End Get
        Set(value As Double)
            Me._valor_par = value
            Me.cambioPropiedad("Valor_par")
        End Set
    End Property
    Public Property Fecha_par As Date
        Get
            Return Me._fecha_par
        End Get
        Set(value As Date)
            Me._fecha_par = value
            Me.cambioPropiedad("Fecha_par")
        End Set
    End Property
    Public Function IngresarParametros()

    End Function
    Public Function ModificarParametros()

    End Function
    Public Function ConsultarParametros()
    End Function
End Class
