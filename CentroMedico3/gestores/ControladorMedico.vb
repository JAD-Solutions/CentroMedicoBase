Imports System.ComponentModel
Public Class ControladorMedico
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
    Public Sub eliminarmedico(ByVal medico As Medico)
        Dim condicion As String = medico.Cedula_per
        _metodos.eliminar("t_medico", condicion)
    End Sub
    Public Sub agregarmedico(ByVal medico As Medico)
        Dim valores(7) As String
        Dim campos(7) As String
        Dim valores2(5) As String
        Dim campos2(5) As String
        Dim valores3(3) As String
        Dim campos3(3) As String
        campos(1) = "nombre_per"
        valores(1) = "'" + medico.Nombre_per + "'"
        campos(2) = "apellido_per"
        valores(2) = "'" + medico.Apellido_per + "'"
        campos(3) = "ci_per"
        valores(3) = "'" + medico.Cedula_per + "'"
        campos(4) = "fecha_nac_per"
        valores(4) = "'" + medico.Fecha_nac_per + "'"
        campos(5) = "sexo_per"
        valores(5) = "'" + medico.Sexo_per + "'"
        campos(6) = "telefono_per"
        valores(6) = "'" + medico.Telefono_per + "'"
        campos(7) = "direccion_per"
        valores(7) = "'" + medico.Direccion_per + "'"
        _metodos.insertarDato(campos, valores, "t_persona")

        'empleado
        campos2(1) = "codigo_per"
        valores2(1) = _metodos.Select1dato(campos2(1), campos(3), valores(3), "t_persona").ToString
        campos2(2) = "cargo_emp"
        valores2(2) = "'" + medico.Cargo_emp + "'"
        campos2(3) = "sueldo_emp"
        valores2(3) = medico.Sueldo_emp.ToString
        campos2(4) = "hora_entrada_emp"
        valores2(4) = "'" + medico.Hora_entrada_emp + "'"
        campos2(5) = "hora_salida_emp"
        valores2(5) = "'" + medico.Hora_salida_emp + "'"
        _metodos.insertarDato(campos2, valores2, "t_empleado")
        'medico
        campos3(1) = "codigo_med"
        valores3(1) = valores2(1)
        campos3(2) = "especialidad_med"
        valores3(2) = "'" + medico.Especialidad_med + "'"
        campos3(3) = "universidad_med"
        valores3(3) = "'" + medico.Universidad_med + "'"
        _metodos.insertarDato(campos3, valores3, "t_medico")
    End Sub
    Public Sub mostrarmedico(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_medico", lista)

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
