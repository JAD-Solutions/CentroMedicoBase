Imports System.ComponentModel
Public Class ControladorLineaReceta
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
    Public Sub eliminarlinea(ByVal linea As LineaReceta)
        Dim condicion As String = linea.Codigo_lin
        _metodos.eliminar("t_lineaReceta", condicion)
    End Sub
    Public Sub agregarfact(ByVal linea As LineaReceta)
        Dim valores(3) As String
        Dim campos(3) As String
        campos(1) = "cantidad_lin"
        valores(1) = linea.Cantidad_lin
        campos(2) = "codigo_mec"
        valores(2) = linea.Medicina_lin.Codigo_mec
        campos(3) = "codigo_rec"
        valores(3) = linea.Receta_lin.Codigo_rec
        _metodos.insertarDato(campos, valores, "t_lineaReceta")
    End Sub
    Public Sub mostrarfactura(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_lineaReceta", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
