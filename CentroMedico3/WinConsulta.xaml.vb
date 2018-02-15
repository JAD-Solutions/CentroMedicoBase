Class WinConsulta
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub bt_atender_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_atencion As New WinAtencionMedica
        ventana_atencion.Show()
        Me.Close()



    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)
        Dim volver As New MainMedico
        volver.Show()
        Me.Close()

    End Sub
End Class
