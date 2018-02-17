Class WinConsulta
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub bt_atender_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_atencion As New WinAtencionMedica
        ventana_atencion.Show()
        Me.Close()



    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)
<<<<<<< HEAD
        Dim principal As New MainWindow
        principal.Show()
        Me.Close()

    End Sub

    Private Sub lstConsultas_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Dim ventana_atencion As New WinAtencionMedica
        ventana_atencion.Show()
        Me.Close()
    End Sub
=======
        Dim volver As New MainMedico
        volver.Show()
        Me.Close()

    End Sub
>>>>>>> 2cb7a89fe315b5b13cf267ebc6a1c84b90317923
End Class
