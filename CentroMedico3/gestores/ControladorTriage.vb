Imports System.ComponentModel
Public Class ControladorTriage
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
    Public Sub eliminartriage(ByVal triage As Triage)
        Dim condicion As String = triage.Codigo_tri.ToString
        _metodos.eliminar("t_triage", condicion)
    End Sub
    Public Sub agregartriage(ByVal triage As Triage)
        Dim valores(1) As String
        Dim campos(1) As String
        campos(1) = "descripcion_tri"
        valores(1) = "'" + triage.Descripcion_tri + "'"
        _metodos.insertarDato(campos, valores, "t_triage")
    End Sub
    Public Sub mostrartriage(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_triage", lista)

    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
