Imports System.Collections.ObjectModel
Imports System.ComponentModel
Public Class Paciente
    Inherits Persona
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _antecedentes_pac As Antecedente
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, antecedente_pac As Antecedente)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per)
        Me._antecedentes_pac = antecedente_pac
    End Sub

    'Metodos y Funciones
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Antecedentes_pac As Antecedente
        Get
            Return _antecedentes_pac
        End Get
        Set(value As Antecedente)
            _antecedentes_pac = value
            cambioPropiedad("Antecedentes_pac")
        End Set
    End Property

End Class
