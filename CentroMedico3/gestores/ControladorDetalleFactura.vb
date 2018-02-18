Imports System.ComponentModel
Public Class ControladorDetalleFactura
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
    Public Sub eliminardetallefac(ByVal detallef As DetalleFactura)
        Dim condicion As String = detallef.Codigo_det.ToString
        _metodos.eliminar("t_detalleFactura", condicion)
    End Sub
    Public Sub agregardetallefac(ByVal detallef As DetalleFactura)
        Dim valores(5) As String
        Dim campos(5) As String
        campos(1) = "cantidad_det"
        valores(1) = detallef.Cantidad_det
        campos(2) = "subtotal_det"
        valores(2) = detallef.Subtotal_det
        campos(3) = "codigo_con"
        valores(3) = detallef.Consulta_det.Codigo_con
        campos(4) = "codigo_rec"
        valores(4) = detallef.Receta_det.Codigo_rec
        campos(5) = "codigo_fac"
        valores(5) = detallef.Factura_det.Codigo_fac
        _metodos.insertarDato(campos, valores, "t_detalleFactura")
    End Sub
    Public Sub mostrardetallefac(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_detalleFactura", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
