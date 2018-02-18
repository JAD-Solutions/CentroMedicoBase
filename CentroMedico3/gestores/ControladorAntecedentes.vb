Imports System.ComponentModel
Public Class ControladorAntecedentes
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
    Public Sub eliminarantecedente(ByVal antecedente As Antecedente)
        Dim condicion As String = antecedente.Codigo_ant.ToString
        _metodos.eliminar("t_antecedente", condicion)
    End Sub
    Public Sub agregarantecedente(ByVal antecedente As Antecedente)
        Dim valores(1) As String
        Dim campos(1) As String
        campos(1) = "descripcion_ant"
        valores(1) = "'" + antecedente.Descripcion_ant + "'"
        _metodos.insertarDato(campos, valores, "t_antecedente")
    End Sub
    Public Sub mostrarantecedentes(ByVal lista As ListView)
        Dim campos(1) As String
        campos(1) = "*"
        _metodos.Selectdato(campos, "t_antecedente", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
