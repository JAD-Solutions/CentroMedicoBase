Imports System.ComponentModel

Public Class LineaReceta
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _codigo_lin As Integer = 0
    Dim _cantidad_lin As Integer
    Dim _medicina_lin As Medicina
    Dim _receta_lin As Receta


    'Constructores
    Public Sub New(cantidad_lin As Integer, medicina_lin As Medicina, receta_lin As Receta)
        _cantidad_lin = cantidad_lin
        _medicina_lin = medicina_lin
        _receta_lin = receta_lin
    End Sub

    Public Sub New()
    End Sub

    'Metodos y Funciones
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Codigo_lin As Integer
        Get
            Return _codigo_lin
        End Get
        Set(value As Integer)
            _codigo_lin = value
            cambioPropiedad("Codigo_lin")
        End Set
    End Property
    Public Property Cantidad_lin As Integer
        Get
            Return _cantidad_lin
        End Get
        Set(value As Integer)
            _cantidad_lin = value
            cambioPropiedad("Cantidad_lin")
        End Set
    End Property
    Public Property Medicina_lin As Medicina
        Get
            Return _medicina_lin
        End Get
        Set(value As Medicina)
            _medicina_lin = value
            cambioPropiedad("Medicina_lin")
        End Set
    End Property
    Public Property Receta_lin As Receta
        Get
            Return _receta_lin
        End Get
        Set(value As Receta)
            _receta_lin = value
            cambioPropiedad("Receta_lin")
        End Set
    End Property
End Class
