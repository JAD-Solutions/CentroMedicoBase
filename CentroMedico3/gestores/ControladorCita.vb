Imports System.ComponentModel
Public Class ControladorCita
    Implements INotifyPropertyChanged
    'Atributos
    Private _metodos As Plantillasql = New Plantillasql
    'Constructor
    Public Sub New()
    End Sub

    'Metodos
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    Public Sub eliminarcita(ByVal cita As Cita)
        Dim condicion As String = CType(cita.Codigo_cit, String)
        _metodos.eliminar("t_cita", condicion)
    End Sub
    Public Sub agregarcita(ByVal cita As Cita)
        Dim valores(4) As String
        Dim campos(4) As String
        campos(1) = "fecha_cit"
        valores(1) = "'" + cita.Fecha_cit + "'"
        campos(2) = "codigo_pac"
        valores(2) = cita.Paciente_cit.Codigo_per
        campos(3) = "codigo_rec"
        valores(3) = cita.Recepcionista_cit.Codigo_per
        campos(4) = "codigo_med"
        valores(4) = cita.Medico_cit.Codigo_per
        _metodos.insertarDato(campos, valores, "t_cita")
    End Sub
    Public Sub mostrarcita(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_cita", lista)

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
