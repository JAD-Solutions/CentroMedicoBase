Imports System.ComponentModel
Public Class GestorCliente
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
    Public Sub eliminarcliente(ByVal cliente As Cliente)
        Dim condicion As String = cliente.Cedula_per
        _metodos.eliminar("t_cliente", condicion)
    End Sub
    Public Sub agregarcliente(ByVal cliente As Cliente)
        Dim valores(7) As String
        Dim campos(7) As String
        Dim valores2(3) As String
        Dim campos2(3) As String
        campos(1) = "nombre_per"
        valores(1) = "'" + cliente.Nombre_per + "'"
        campos(2) = "apellido_per"
        valores(2) = "'" + cliente.Apellido_per + "'"
        campos(3) = "ci_per"
        valores(3) = "'" + cliente.Cedula_per + "'"
        campos(4) = "fecha_nac_per"
        valores(4) = "'" + cliente.Fecha_nac_per + "'"
        campos(5) = "sexo_per"
        valores(5) = "'" + cliente.Sexo_per + "'"
        campos(6) = "telefono_per"
        valores(6) = "'" + cliente.Telefono_per + "'"
        campos(7) = "direccion_per"
        valores(7) = "'" + cliente.Direccion_per + "'"
        _metodos.insertarDato(campos, valores, "t_persona")
        'cliente
        campos2(1) = "codigo_per"
        valores2(1) = _metodos.Select1dato(campos2(1), campos(3), valores(3), "t_persona").ToString
        campos2(2) = "numero_tarjeta"
        valores2(2) = "'" + cliente.Numero_tarjeta_cli + "'"
        campos2(3) = "banco_cli"
        valores2(3) = "'" + cliente.Banco_cli + "'"
        _metodos.insertarDato(campos2, valores2, "t_cliente")
    End Sub
    Public Sub mostrarcliene(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_cliente", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
