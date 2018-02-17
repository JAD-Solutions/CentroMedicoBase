Imports System.ComponentModel

Public Class LineaReceta
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _codigo_lin As Integer = 0
    Dim _medicina_lin As Medicina


    'Constructores
    Public Sub New(medicina_lin As Medicina)
        _medicina_lin = medicina_lin
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
    Public Property Medicina_lin As Medicina
        Get
            Return _medicina_lin
        End Get
        Set(value As Medicina)
            _medicina_lin = value
            cambioPropiedad("Medicina_lin")
        End Set
    End Property
End Class
