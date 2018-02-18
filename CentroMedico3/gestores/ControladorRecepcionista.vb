Imports System.ComponentModel
Public Class ControladorRecepcionista
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
    Public Sub eliminarrecepcionista(ByVal recepcionista As Recepcionista)
        Dim condicion As String = recepcionista.Cedula_per
        _metodos.eliminar("t_recepcionista", condicion)
    End Sub
    Public Sub agregarrecepcionista(ByVal recepcionista As Recepcionista)
        Dim valores(7) As String
        Dim campos(7) As String
        Dim valores2(6) As String
        Dim campos2(6) As String
        Dim valores3(1) As String
        Dim campos3(1) As String
        campos(1) = "nombre_per"
        valores(1) = "'" + recepcionista.Nombre_per + "'"
        campos(2) = "apellido_per"
        valores(2) = "'" + recepcionista.Apellido_per + "'"
        campos(3) = "ci_per"
        valores(3) = "'" + recepcionista.Cedula_per + "'"
        campos(4) = "fecha_nac_per"
        valores(4) = "'" + recepcionista.Fecha_nac_per + "'"
        campos(5) = "sexo_per"
        valores(5) = "'" + recepcionista.Sexo_per + "'"
        campos(6) = "telefono_per"
        valores(6) = "'" + recepcionista.Telefono_per + "'"
        campos(7) = "direccion_per"
        valores(7) = "'" + recepcionista.Direccion_per + "'"
        _metodos.insertarDato(campos, valores, "t_persona")

        'empleado
        campos2(1) = "codigo_per"
        valores2(1) = _metodos.Select1dato(campos2(1), campos(3), valores(3), "t_persona").ToString
        campos2(2) = "cargo_emp"
        valores2(2) = "'" + recepcionista.Cargo_emp + "'"
        campos2(3) = "sueldo_emp"
        valores2(3) = recepcionista.Sueldo_emp.ToString
        campos2(4) = "hora_entrada_emp"
        valores2(4) = "'" + recepcionista.Hora_entrada_emp + "'"
        campos2(5) = "hora_salida_emp"
        valores2(5) = "'" + recepcionista.Hora_salida_emp + "'"
        _metodos.insertarDato(campos2, valores2, "t_empleado")
        campos2(6) = "contrasena_emp"
        valores2(6) = "'" + recepcionista.Contrasena_emp + "'"
        _metodos.insertarDato(campos2, valores2, "t_empleado")

        'recepcionista
        campos3(1) = "codigo_rec"
        valores3(1) = valores2(1)
        _metodos.insertarDato(campos3, valores3, "t_recepcionista")
    End Sub
    Public Sub mostrarrecepcionista(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_recepcionista", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
