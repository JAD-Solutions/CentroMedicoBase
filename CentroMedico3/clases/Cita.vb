Imports System.ComponentModel
Public Class Cita
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_cit As Integer
    Dim _fecha_cit As Date
    Dim _mredico_cit As String
    Dim _paciente_cit As Paciente
    Dim _recepcionista_cit As Recepcionista
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo_cit As Integer, ByVal fecha_cit As Date, ByVal mredico_cit As String, ByVal paciente As Paciente, ByVal recepcionista As Recepcionista)
        Me._codigo_cit = codigo_cit
        Me._fecha_cit = fecha_cit
        Me._mredico_cit = mredico_cit
        Me._paciente_cit = paciente
        Me._recepcionista_cit = recepcionista
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_cit As Integer
        Get
            Return Me._codigo_cit
        End Get
        Set(value As Integer)
            Me._codigo_cit = value
            Me.cambioPropiedad("Codigo_cit")
        End Set
    End Property
    Public Property Fecha_cit As Date
        Get
            Return Me._fecha_cit
        End Get
        Set(value As Date)
            Me._fecha_cit = value
            Me.cambioPropiedad("Fecha_cit")
        End Set
    End Property
    Public Property Mredico_cit As String
        Get
            Return Me._mredico_cit
        End Get
        Set(value As String)
            Me._mredico_cit = value
            Me.cambioPropiedad("Mredico_cit")
        End Set
    End Property
    Public Property Paciente_cit As Paciente
        Get
            Return Me._paciente_cit
        End Get
        Set(value As Paciente)
            Me._paciente_cit = value
            Me.cambioPropiedad("Paciente_cit")
        End Set
    End Property
    Public Property Recepcionista_cit As Recepcionista
        Get
            Return Me._recepcionista_cit
        End Get
        Set(value As Recepcionista)
            Me._recepcionista_cit = value
            Me.cambioPropiedad("Recepcionista_cit")
        End Set
    End Property

End Class
