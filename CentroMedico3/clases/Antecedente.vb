Imports System.ComponentModel
Public Class Antecedente
    Implements INotifyPropertyChanged
    'atributos
    Dim _nombre_ant As String
    Dim _tipo_ant As String
    Dim _descripcion_ant As String
    Dim _observaciones_ant As String
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal nombre_ant As String, ByVal tipo_ant As String, ByVal descripcion_ant As String, ByVal observaciones_ant As String)
        Me._nombre_ant = nombre_ant
        Me._tipo_ant = tipo_ant
        Me._descripcion_ant = descripcion_ant
        Me._observaciones_ant = observaciones_ant
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Nombre_ant As String
        Get
            Return Me._nombre_ant
        End Get
        Set(value As String)
            Me._nombre_ant = value
            Me.cambioPropiedad("Nombre_ant")
        End Set
    End Property

    Public Property Tipo_ant As String
        Get
            Return Me._tipo_ant
        End Get
        Set(value As String)
            Me._tipo_ant = value
            Me.cambioPropiedad("Tipo_ant")
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
    Public Property Observaciones_ant As String
        Get
            Return Me._observaciones_ant
        End Get
        Set(value As String)
            Me._observaciones_ant = value
            Me.cambioPropiedad("Observaciones_ant")
        End Set
    End Property
    Public Function IngresarAntesedente()

    End Function
    Public Function ModificarAntesedente()

    End Function
    Public Function ConsultarAntesedente()
    End Function
End Class
