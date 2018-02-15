Imports System.ComponentModel
Public Class Consulta
    Implements INotifyPropertyChanged
    'atributos
    Dim _motivo_con As String
    Dim _diagnostico_con As String
    Dim _receta_con As Receta
    Dim _medico_con As Medico
    Dim _cita_con As Cita
    Dim _triage_con As Triage
    Dim _paciente_con As Paciente
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal motivo_con As String, ByVal diagnostico_con As String, ByVal receta_con As Receta, ByVal medico_con As Medico, ByVal cita_con As Cita, ByVal triage_con As Triage, ByVal paciente_con As Paciente)
        Me._motivo_con = motivo_con
        Me._diagnostico_con = diagnostico_con
        Me._medico_con = medico_con
        Me._cita_con = cita_con
        Me._triage_con = triage_con
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Motivo_con As String
        Get
            Return Me._motivo_con
        End Get
        Set(value As String)
            Me._motivo_con = value
            Me.cambioPropiedad("Motivo_con")
        End Set
    End Property
    Public Property Diagnostico_con As String
        Get
            Return Me._diagnostico_con
        End Get
        Set(value As String)
            Me._diagnostico_con = value
            Me.cambioPropiedad("Diagnostico_con")
        End Set
    End Property
    Public Property Medico_con As Medico
        Get
            Return Me._medico_con
        End Get
        Set(value As Medico)
            Me._medico_con = value
            Me.cambioPropiedad("Medico_con")
        End Set
    End Property
    Public Property Cita_con As Cita
        Get
            Return Me._cita_con
        End Get
        Set(value As Cita)
            Me._cita_con = value
            Me.cambioPropiedad("Cita_con")
        End Set
    End Property
    Public Property Triage_con As Triage
        Get
            Return Me._triage_con
        End Get
        Set(value As Triage)
            Me._triage_con = value
            Me.cambioPropiedad("Triage_con")
        End Set
    End Property
    Public Property Paciente_con As Paciente
        Get
            Return Me._paciente_con
        End Get
        Set(value As Paciente)
            Me._paciente_con = value
            Me.cambioPropiedad("Paciente_con")
        End Set
    End Property
    Public Function registrarConsulta()

    End Function

End Class
