Imports System.ComponentModel
Public Class Medicina
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_mec As Integer = 0
    Dim _nombre_mec As String
    Dim _contenido_mec As String
    Dim _descripcion_mec As String

    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal nombre As String, ByVal contenido As String, ByVal descripcion As String)
        Me._nombre_mec = nombre
        Me._contenido_mec = contenido
        Me._descripcion_mec = descripcion
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_mec As Integer
        Get
            Return _codigo_mec
        End Get
        Set(value As Integer)
            _codigo_mec = value
        End Set
    End Property

    Public Property Nombre_mec As String
        Get
            Return Me._nombre_mec
        End Get
        Set(value As String)
            Me._nombre_mec = value
            Me.cambioPropiedad("Nombre_mec")
        End Set
    End Property

    Public Property Descripcion_mec As String
        Get
            Return Me._descripcion_mec
        End Get
        Set(value As String)
            Me._descripcion_mec = value
            Me.cambioPropiedad("Descripcion_mec")
        End Set
    End Property
    Public Property Contenido_mec As String
        Get
            Return Me._contenido_mec
        End Get
        Set(value As String)
            Me._contenido_mec = value
            Me.cambioPropiedad("Contenido_mec")
        End Set
    End Property
    Public Function ConsultarStock()

    End Function
    Public Function ActualizarStock()

    End Function

End Class
