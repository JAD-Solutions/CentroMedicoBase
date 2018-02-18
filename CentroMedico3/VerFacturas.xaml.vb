Public Class VerFacturas
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim mainrecepcionista As New MainRecepcionista
        mainrecepcionista.Show()
        Me.Close()


    End Sub

    Private Sub lst_facturas_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lst_factura.SelectionChanged
        Dim consultafactura As New ConsultaFactura
        consultafactura.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As System.Windows.RoutedEventArgs)

    End Sub
End Class
