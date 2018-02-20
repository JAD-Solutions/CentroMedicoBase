Imports System.ComponentModel
Imports System.Collections.ObjectModel

Public Class Triage
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_tri As Integer = 0
    Dim _descripcion_tri As String = "triage descripcion"
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal descripcion_tri As String)
        'constructor)
        Me._descripcion_tri = descripcion_tri

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_tri As Integer
        Get
            Return Me._codigo_tri
        End Get
        Set(value As Integer)
            Me._codigo_tri = value
            Me.cambioPropiedad("Codigo_tri")
        End Set
    End Property

    Public Property Descripcion_tri As String
        Get
            Return Me._descripcion_tri
        End Get
        Set(value As String)
            Me._descripcion_tri = value
            Me.cambioPropiedad("Descripcion_tri")
        End Set
    End Property

End Class
