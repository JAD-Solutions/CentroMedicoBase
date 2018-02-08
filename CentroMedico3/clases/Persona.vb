Imports System.ComponentModel
Public MustInherit Class Persona  'para que sea la clase padre debo pooner mustinherit NO INTANCIAAR********
    Implements INotifyPropertyChanged
    Dim codigo_per As Integer
    Dim nombre_per As String
    Dim apellido_per As String
    Dim ci_per As String
    Dim fecha_nac_per As Date
    Dim sexo_per As String
    Dim telefono_per As String
    Dim direccion_per As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New()
    End Sub

    Public Sub New(nombre_per As String, apellido_per As String, ci_per As String, fecha_nac_per As Date, sexo_per As String, telefono_per As String, direccion_per As String)
        Me.nombre_per = nombre_per
        Me.apellido_per = apellido_per
        Me.ci_per = ci_per
        Me.fecha_nac_per = fecha_nac_per
        Me.sexo_per = sexo_per
        Me.telefono_per = telefono_per
        Me.direccion_per = direccion_per
    End Sub

    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub

    Public Property cedula As String
        Get
            Return ci_per
        End Get
        Set(value As String)
            ci_per = cedula
            cambioPropiedad("cedula")
        End Set
    End Property
    Public Property nombre As String
        Get
            Return nombre_per
        End Get
        Set(value As String)
            nombre_per = value
            cambioPropiedad("cedula")
        End Set
    End Property

    'Public Property apellido As String
    'Get
    'Return _apellido
    'End Get
    'Set(value As String)
    '       _apellido = value
    '      cambioPropiedad("apellido")
    'End Set
    'End Property

End Class
