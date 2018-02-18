Public Class ConsultaFactura
    'detallefactura_fac As ObservableCollection(Of DetalleFactura), ByVal total_fac As Double, ByVal fecha_fac As Date)

    'Dim nacimientoCliente As New System.DateTime(1993, 5, 31, 12, 14, 0)
    'Public cliente As Cliente = New Cliente("raul", "perez", "1805140348", nacimientoCliente, "Masculino", "0995568684", "Latacunga", "812821732", "Pichincha")
    'Public detallefactura As ColeccionDetalleFactura = New ColeccionDetalleFactura()
    'Public factura As Factura = New Factura(1, cliente, detallefactura, 22.5, nacimientoCliente)

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        MsgBox("La Receta ha sido impresa correctamente")
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim verfacturas As New VerFacturas
        verfacturas.Show()
        Me.Close()

    End Sub

    Private Sub lst_medicina_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub ListView_SelectionChanged(sender As Object, e As System.Windows.Controls.SelectionChangedEventArgs)

    End Sub
End Class
