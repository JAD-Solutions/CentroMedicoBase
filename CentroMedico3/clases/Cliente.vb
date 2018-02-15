Imports System.ComponentModel

Public Class Cliente
    Inherits Persona
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _numero_tarjeta_cli As String
    Dim _banco_cli As String

    'Constructores
    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, numero_tarjeta_cli As String, banco_cli As String)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per)
        _numero_tarjeta_cli = numero_tarjeta_cli
        _banco_cli = banco_cli
    End Sub

    Public Sub New()
    End Sub

    'Metodos y Funciones
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Numero_tarjeta_cli As String
        Get
            Return _numero_tarjeta_cli
        End Get
        Set(value As String)
            _numero_tarjeta_cli = value
            cambioPropiedad("Numero_tarjeta_cli")
        End Set
    End Property
    Public Property Banco_cli As String
        Get
            Return _banco_cli
        End Get
        Set(value As String)
            _banco_cli = value
            cambioPropiedad("Banco_cli")
        End Set
    End Property
End Class
