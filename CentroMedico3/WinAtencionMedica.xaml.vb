Class WinAtencionMedica


    Private Sub bt_historia_clinica_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_historia_clinica As New WinHistoriaClinica
        ventana_historia_clinica.Show()

    End Sub

    Private Sub bt_agregar_medicina_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_medicina As New WinMedicina
        ventana_medicina.Show()

    End Sub

    Private Sub bt_guardar_consulta_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_consulta As New WinConsulta
        ventana_consulta.Show()
        Me.Close()

    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)
        Dim volver As New WinConsulta
        volver.Show()
        Me.Close()


    End Sub
End Class
