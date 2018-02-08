Imports System.ComponentModel
Public Class Paciente
    Inherits Persona
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim intolerancias_pac As String
    Dim observacion_pac As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, intolerancias_pac As String, observacion_pac As String)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per)
        Me.intolerancias_pac = intolerancias_pac
        Me.observacion_pac = observacion_pac
    End Sub

    'Metodos y Funciones
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property nombre_per As String
        Get
            Return nombre_per
        End Get
        Set(value As String)
            '  MyBase.nombre_per = value
            cambioPropiedad("nombre_per")
        End Set
    End Property


End Class
