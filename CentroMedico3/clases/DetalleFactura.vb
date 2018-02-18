Imports System.ComponentModel
Public Class DetalleFactura
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_det As Integer
    Dim _consulta_det As Consulta
    Dim _receta_det As Receta
    Dim _cantidad_det As Integer
    Dim _subtotal_det As Double
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo As Integer, ByVal consulta_det As Consulta, ByVal receta_det As Receta, ByVal cantidad As Integer, ByVal subtotal As Double)
        Me._codigo_det = codigo
        Me._consulta_det = consulta_det
        _receta_det = receta_det
        Me._cantidad_det = cantidad
        Me._subtotal_det = subtotal
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_det As Integer
        Get
            Return Me._codigo_det
        End Get
        Set(value As Integer)
            Me._codigo_det = value
            Me.cambioPropiedad("Codigo_det")
        End Set
    End Property
    Public Property Receta_det As Receta
        Get
            Return _receta_det
        End Get
        Set(value As Receta)
            _receta_det = value
            cambioPropiedad("Receta_det")
        End Set
    End Property
    Public Property Consulta_det As Consulta
        Get
            Return Me._consulta_det
        End Get
        Set(value As Consulta)
            Me._consulta_det = value
            Me.cambioPropiedad("Consulta_det")
        End Set
    End Property
    Public Property Cantidad_det As Integer
        Get
            Return Me._cantidad_det
        End Get
        Set(value As Integer)
            Me._cantidad_det = value
            Me.cambioPropiedad("Cantidad_det")
        End Set
    End Property
    Public Property Subtotal_det As Double
        Get
            Return Me._subtotal_det
        End Get
        Set(value As Double)
            Me._subtotal_det = value
            Me.cambioPropiedad("Subtotal_det")
        End Set
    End Property
End Class
