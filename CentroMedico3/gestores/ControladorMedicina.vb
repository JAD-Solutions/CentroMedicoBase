Imports System.ComponentModel
Public Class ControladorMedicina
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
    Public Sub eliminarmedicina(ByVal medicina As Medicina)
        Dim condicion As String = medicina.Codigo_mec.ToString
        _metodos.eliminar("t_medicina", condicion)
    End Sub
    Public Sub agregarmedicina(ByVal medicina As Medicina)
        Dim valores(3) As String
        Dim campos(3) As String
        campos(1) = "nombre_mec"
        valores(1) = "'" + medicina.Nombre_mec + "'"
        campos(2) = "contenido_mec"
        valores(2) = medicina.Contenido_mec
        campos(3) = "descripcion_mec"
        valores(3) = "'" + medicina.Descripcion_mec + "'"
        _metodos.insertarDato(campos, valores, "t_medicina")
    End Sub
    Public Sub mostrarmedicina(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_medicina", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
