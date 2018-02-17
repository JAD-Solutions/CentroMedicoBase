Imports System.ComponentModel

Public Class Medico
    Inherits Empleado

    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _especialidad_med As String
    Dim _universidad_med As String


    'Constructores
    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, cargo_emp As String, sueldo_emp As Double, hora_entrada_emp As String, hora_salida_emp As String, especialidad_med As String, universidad_med As String)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per, cargo_emp, sueldo_emp, hora_entrada_emp, hora_salida_emp)
        _especialidad_med = especialidad_med
        _universidad_med = universidad_med
    End Sub

    Public Sub New()
    End Sub

    'Metodos y Funciones
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Especialidad_med As String
        Get
            Return _especialidad_med
        End Get
        Set(value As String)
            _especialidad_med = value
            cambioPropiedad("Especialidad_med")
        End Set
    End Property

    Public Property Universidad_med As String
        Get
            Return _universidad_med
        End Get
        Set(value As String)
            _universidad_med = value
            cambioPropiedad("Universidad_med")
        End Set
    End Property

End Class
