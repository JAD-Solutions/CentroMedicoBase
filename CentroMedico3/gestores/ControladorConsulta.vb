Imports System.ComponentModel
Public Class ControladorConsulta
    Implements INotifyPropertyChanged
    'Atributos
    Public _metodos As Plantillasql = New Plantillasql()
    'Constructor
    Public Sub New()
    End Sub

    'Metodos
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    Public Sub eliminarconsulta(ByVal consula As Consulta)
        Dim condicion As String = consula.Codigo_con.ToString
        _metodos.eliminar("t_consula", condicion)
    End Sub
    Public Sub agregarconsulta(ByVal consulta As Consulta)
        Dim valores(4) As String
        Dim campos(4) As String
        campos(1) = "motivo_con"
        valores(1) = "'" + consulta.Motivo_con + "'"
        campos(2) = "diagnostico_con"
        valores(2) = "'" + consulta.Diagnostico_con + "'"
        campos(3) = "codigo_cit"
        valores(3) = consulta.Cita_con.Codigo_cit
        campos(4) = "codigo_tri"
        valores(4) = consulta.Triage_con.Codigo_tri
        _metodos.insertarDato(campos, valores, "t_consulta")

    End Sub
    Public Sub mostrarconsulta(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_consulta", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
