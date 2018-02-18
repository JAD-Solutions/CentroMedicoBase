Imports System.ComponentModel
Public Class ControladorPaciente
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
    Public Sub eliminarpaciente(ByVal paciente As Paciente)
        Dim condicion As String = paciente.Cedula_per
        _metodos.eliminar("t_paciente", condicion)
    End Sub
    Public Sub agregarpaciente(ByVal paciente As Paciente)
        Dim valores(7) As String
        Dim campos(7) As String
        Dim valores2(2) As String
        Dim campos2(2) As String
        campos(1) = "nombre_per"
        valores(1) = "'" + paciente.Nombre_per + "'"
        campos(2) = "apellido_per"
        valores(2) = "'" + paciente.Apellido_per + "'"
        campos(3) = "ci_per"
        valores(3) = "'" + paciente.Cedula_per + "'"
        campos(4) = "fecha_nac_per"
        valores(4) = "'" + paciente.Fecha_nac_per + "'"
        campos(5) = "sexo_per"
        valores(5) = "'" + paciente.Sexo_per + "'"
        campos(6) = "telefono_per"
        valores(6) = "'" + paciente.Telefono_per + "'"
        campos(7) = "direccion_per"
        valores(7) = "'" + paciente.Direccion_per + "'"
        _metodos.insertarDato(campos, valores, "t_persona")
        'p
        campos2(1) = "codigo_per"
        valores2(1) = _metodos.Select1dato(campos2(1), campos(3), valores(3), "t_persona").ToString
        campos2(2) = "codigo_ant"
        valores2(2) = paciente.Antecedentes_pac.Codigo_ant
        _metodos.insertarDato(campos2, valores2, "t_paciente")
    End Sub
    Public Sub mostrarpaciente(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_paciente", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
