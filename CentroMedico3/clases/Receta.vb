Imports System.ComponentModel
Public Class Receta
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_rec As Integer
    Dim _descripcion_rec As String
    Dim _lista_medicinas_rec As List(Of Medicina)

    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo_re As Integer, ByVal descripcion_re As String, ByVal lista_medicinas As List(Of Medicina))
        Me._codigo_rec = codigo_re
        Me._descripcion_rec = descripcion_re
        Me._lista_medicinas_rec = lista_medicinas
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
    Public Property Lista_medicinas_rec As List(Of Medicina)
        Get
            Return Me._lista_medicinas_rec
        End Get
        Set(value As List(Of Medicina))
            Me._lista_medicinas_rec = value
            Me.cambioPropiedad("Lista_medicinas_rec ")
        End Set
    End Property
    Public Function RegistrarReceta()

    End Function
    Public Function ModificarReceta()

    End Function
    Public Function EliminarReceta()

    End Function
End Class
