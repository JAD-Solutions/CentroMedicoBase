Public Class VerCitas
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim mainrecepcionista As New MainRecepcionista
        mainrecepcionista.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim creacita As New CreaCita
        creacita.Show()
        Me.Close()
    End Sub

    Private Sub lst_citas_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        MsgBox("cita seleccionada :v")
    End Sub
End Class
