Imports System.ComponentModel
Public Class ControladorFactura
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
    Public Sub eliminarfactura(ByVal factura As Factura)
        Dim condicion As String = factura.Codigo_fac.ToString
        _metodos.eliminar("t_factura", condicion)
    End Sub
    Public Sub agregarfact(ByVal factura As Factura)
        Dim valores(3) As String
        Dim campos(3) As String
        campos(1) = "total_fac"
        valores(1) = factura.Total_fac
        campos(2) = "fecha_fac"
        valores(2) = "'" + factura.Fecha_fac + "'"
        campos(3) = "codigo_cli"
        valores(3) = factura.Cliente_fac.Codigo_per
        _metodos.insertarDato(campos, valores, "t_factura")
    End Sub
    Public Sub mostrarfactura(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_factura", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
