Imports System.ComponentModel
Imports System.Collections.ObjectModel

Public Class Factura
    Implements INotifyPropertyChanged
    'atributos
    Dim _codigo_fac As Integer
    Dim _cliente_fac As Cliente
    Dim _detallefactura_fac As ObservableCollection(Of DetalleFactura)
    Dim _total_fac As Double
    Dim _fecha_fac As Date
    'constructor
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo_fac As Integer, ByVal cliente_fac As Cliente, ByVal detallefactura_fac As ObservableCollection(Of DetalleFactura), ByVal total_fac As Double, ByVal fecha_fac As Date)
        Me._codigo_fac = codigo_fac
        Me._cliente_fac = cliente_fac
        Me._detallefactura_fac = detallefactura_fac
        Me._fecha_fac = fecha_fac
        Me._total_fac = total_fac
    End Sub
    'Eventos
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub cambioPropiedad(ByVal propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propiedad))
    End Sub
    'propiedades
    Public Property Codigo_fac As Integer
        Get
            Return Me._codigo_fac
        End Get
        Set(value As Integer)
            Me._codigo_fac = value
            Me.cambioPropiedad("Codigo_fac")
        End Set
    End Property
    Public Property Cliente_fac As Cliente
        Get
            Return Me._cliente_fac
        End Get
        Set(value As Cliente)
            Me._cliente_fac = value
            Me.cambioPropiedad("Cliente_fac")
        End Set
    End Property
    Public Property Detallefactura_fac As ObservableCollection(Of DetalleFactura)
        Get
            Return Me._detallefactura_fac
        End Get
        Set(value As ObservableCollection(Of DetalleFactura))
            Me._detallefactura_fac = value
            Me.cambioPropiedad("Detallefactura_fac")
        End Set
    End Property
    Public Property Total_fac As Double
        Get
            Return Me._total_fac
        End Get
        Set(value As Double)
            Me._total_fac = value
            Me.cambioPropiedad("Total_fac")
        End Set
    End Property
    Public Property Fecha_fac As Date
        Get
            Return Me._fecha_fac
        End Get
        Set(value As Date)
            Me._fecha_fac = value
            Me.cambioPropiedad("Fecha_fac")
        End Set
    End Property
    Public Function RegistrarFactura()
    End Function
End Class
