Public Class ConsultaFactura
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
End Class
