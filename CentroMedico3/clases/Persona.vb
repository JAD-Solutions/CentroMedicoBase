Imports System.ComponentModel
Public MustInherit Class Persona  'para que sea la clase padre debo pooner mustinherit NO INTANCIAAR********
    Implements INotifyPropertyChanged
    Dim _codigo_per As Integer
    Dim _nombre_per As String
    Dim _apellido_per As String
    Dim _ci_per As String
    Dim _fecha_nac_per As Date
    Dim _sexo_per As String
    Dim _telefono_per As String
    Dim _direccion_per As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New()
    End Sub

    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String)
        Me._nombre_per = nombre_per
        Me._apellido_per = apellido_per
        Me._ci_per = ci_per
        Me._fecha_nac_per = fecha_nac_per
        Me._sexo_per = sexo_per
        Me._telefono_per = telefono_per
        Me._direccion_per = direccion_per
    End Sub

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    Public Property Codigo_per As Integer
        Get
            Return _codigo_per
        End Get
        Set(value As Integer)
            _codigo_per = value
            cambioPropiedad("Codigo_per")
        End Set
    End Property

    Public Property Cedula_per As String
        Get
            Return _ci_per
        End Get
        Set(value As String)
            _ci_per = value
            cambioPropiedad("Cedula_per")
        End Set
    End Property
    Public Property Nombre_per As String
        Get
            Return _nombre_per
        End Get
        Set(value As String)
            _nombre_per = value
            cambioPropiedad("Nombre_per")
        End Set
    End Property

    Public Property Apellido_per As String
        Get
            Return _apellido_per
        End Get
        Set(value As String)
            _apellido_per = value
            cambioPropiedad("Apellido_per")
        End Set
    End Property

    Public Property Fecha_nac_per As Date
        Get
            Return _fecha_nac_per
        End Get
        Set(value As Date)
            _fecha_nac_per = value
            cambioPropiedad("Fecha_nac_per")
        End Set
    End Property

    Public Property Sexo_per As String
        Get
            Return _sexo_per
        End Get
        Set(value As String)
            _sexo_per = value
            cambioPropiedad("Sexo_per")
        End Set
    End Property

    Public Property Telefono_per As String
        Get
            Return _telefono_per
        End Get
        Set(value As String)
            _telefono_per = value
            cambioPropiedad("Telefono_per")
        End Set
    End Property

    Public Property Direccion_per As String
        Get
            Return _direccion_per
        End Get
        Set(value As String)
            _direccion_per = value
            cambioPropiedad("Direccion_per")
        End Set
    End Property


End Class
