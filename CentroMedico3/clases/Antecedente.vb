Imports System.ComponentModel
Public Class Antecedente
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_ant As Integer
    Dim _descripcion_ant As String
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal descripcion_ant As String)
        Me._descripcion_ant = descripcion_ant
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_ant As Integer
        Get
            Return _codigo_ant
        End Get
        Set(value As Integer)
            _codigo_ant = value
            cambioPropiedad("Codigo_ant")
        End Set
    End Property
    Public Property Descripcion_ant As String
        Get
            Return Me._descripcion_ant
        End Get
        Set(value As String)
            Me._descripcion_ant = value
            Me.cambioPropiedad("Descripcion_ant")
        End Set
    End Property

    Public Function IngresarAntesedente()

    End Function
    Public Function ModificarAntesedente()

    End Function
    Public Function ConsultarAntesedente()
    End Function
End Class
