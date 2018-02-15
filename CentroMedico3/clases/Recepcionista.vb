Imports System.ComponentModel

Public Class Recepcionista
    Inherits Empleado
    Implements INotifyPropertyChanged

    'Declaro variables


    'Constructores
    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, cargo_emp As String, sueldo_emp As String, hora_entrada_emp As String, hora_salida_emp As String)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per, cargo_emp, sueldo_emp, hora_entrada_emp, hora_salida_emp)
    End Sub

    Public Sub New()
    End Sub

    'Metodos y Funciones
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad

End Class
