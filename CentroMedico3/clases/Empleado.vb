Imports System.ComponentModel
Public MustInherit Class Empleado
    Inherits Persona
    Implements INotifyPropertyChanged

    'Declaro variables
    Dim _contrasena_emp As String
    Dim _cargo_emp As String
    Dim _sueldo_emp As Double
    Dim _hora_entrada_emp As String
    Dim _hora_salida_emp As String

    'Constructores
    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String, cargo_emp As String, sueldo_emp As Double, hora_entrada_emp As String, hora_salida_emp As String, contrasena_emp As String)
        MyBase.New(nombre_per, apellido_per, ci_per, fecha_nac_per, sexo_per, telefono_per, direccion_per)
        _cargo_emp = cargo_emp
        _sueldo_emp = sueldo_emp
        _hora_entrada_emp = hora_entrada_emp
        _hora_salida_emp = hora_salida_emp
        _contrasena_emp = contrasena_emp
    End Sub

    Public Sub New()
    End Sub

    'Metodos y Funciones
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    'Propiedad
    Public Property Cargo_emp As String
        Get
            Return _cargo_emp
        End Get
        Set(value As String)
            _cargo_emp = value
            cambioPropiedad("Cargo_emp")
        End Set
    End Property
    Public Property Sueldo_emp As Double
        Get
            Return _sueldo_emp
        End Get
        Set(value As Double)
            _sueldo_emp = value
            cambioPropiedad("Sueldo_emp")
        End Set
    End Property
    Public Property Hora_entrada_emp As String
        Get
            Return _hora_entrada_emp
        End Get
        Set(value As String)
            _hora_entrada_emp = value
            cambioPropiedad("Hora_entrada_emp")
        End Set
    End Property
    Public Property Hora_salida_emp As String
        Get
            Return _hora_salida_emp
        End Get
        Set(value As String)
            _hora_salida_emp = value
            cambioPropiedad("Hora_salida_Emp")
        End Set
    End Property
    Public Property Contrasena_emp As String
        Get
            Return _contrasena_emp
        End Get
        Set(value As String)
            _contrasena_emp = value
            cambioPropiedad("Contrasena_emp")
        End Set
    End Property

End Class
