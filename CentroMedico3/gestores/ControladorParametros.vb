Imports System.ComponentModel
Public Class ControladorParametros
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
    Public Sub eliminarparametros(ByVal param As ParametrosEvaluacion)
        Dim condicion As String = param.Codigo_par.ToString
        _metodos.eliminar("t_parametroEvaluacion", condicion)
    End Sub
    Public Sub agregarparametros(ByVal param As ParametrosEvaluacion)
        Dim valores(4) As String
        Dim campos(4) As String
        campos(1) = "nombre_par"
        valores(1) = "'" + param.Nombre_par + "'"
        campos(2) = "valor_par"
        valores(2) = param.Valor_par
        campos(3) = "fecha_par"
        valores(3) = "'" + param.Fecha_par + "'"
        campos(4) = "codigo_tri"
        valores(4) = param.Triage_par.Codigo_tri
        _metodos.insertarDato(campos, valores, "t_parametroEvaluacion")
    End Sub
    Public Sub mostrarparametros(ByVal lista As ListView)
        Dim campos(0) As String
        campos(0) = "*"
        _metodos.Selectdato(campos, "t_parametroEvaluacion", lista)
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
