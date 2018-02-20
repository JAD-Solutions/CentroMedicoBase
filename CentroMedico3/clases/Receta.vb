Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Class Receta
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_rec As Integer = 0
    Dim _descripcion_rec As String = ""

    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal descripcion_re As String)
        Me._descripcion_rec = descripcion_re
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_rec As Integer
        Get
            Return Me._codigo_rec
        End Get
        Set(value As Integer)
            Me._codigo_rec = value
            Me.cambioPropiedad("Codigo_rec")
        End Set
    End Property

    Public Property Descripcion_rec As String
        Get
            Return Me._descripcion_rec
        End Get
        Set(value As String)
            Me._descripcion_rec = value
            Me.cambioPropiedad("Descripcion_rec")
        End Set
    End Property

    Public Function RegistrarReceta()

    End Function
    Public Function ModificarReceta()

    End Function
    Public Function EliminarReceta()

    End Function
End Class
