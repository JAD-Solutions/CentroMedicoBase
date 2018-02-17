Public Class MainRecepcionista
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim vercitas As New VerCitas
        vercitas.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim verpacientes As New VerPacientes
        verpacientes.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim verfacturas As New VerFacturas
        verfacturas.Show()
        Me.Close()

    End Sub
<<<<<<< HEAD

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim principal As New MainWindow
        principal.Show()
        Me.Close()
    End Sub
=======
>>>>>>> 2cb7a89fe315b5b13cf267ebc6a1c84b90317923
End Class
