Imports System.ComponentModel
Public Class ControladorReceta
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
    Public Sub eliminarreceta(ByVal receta As Receta)
        Dim condicion As String = receta.Codigo_rec.ToString
        _metodos.eliminar("t_receta", condicion)
    End Sub
    Public Sub agregarreceta(ByVal receta As Receta)
        Dim valores(1) As String
        Dim campos(1) As String
        campos(1) = "descripcion_rec"
        valores(1) = "'" + receta.Descripcion_rec + "'"
        _metodos.insertarDato(campos, valores, "t_receta")
    End Sub
    Public Sub mostrarreceta(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_receta", lista)

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
