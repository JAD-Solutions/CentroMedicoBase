Imports System.ComponentModel
Public Class Paciente
    Inherits Persona
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _lista_antecedentes_pac As List(Of Antecedente)
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, lista_antecedente_pac As List(Of Antecedente))
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per)
        Me._lista_antecedentes_pac = lista_antecedente_pac
    End Sub

    'Metodos y Funciones
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Lista_antecedentes_pac As List(Of Antecedente)
        Get
            Return _lista_antecedentes_pac
        End Get
        Set(value As List(Of Antecedente))
            _lista_antecedentes_pac = value
            cambioPropiedad("Lista_antecedentes_pac")
        End Set
    End Property

End Class
