Class MainMedico
    Private Sub bt_citas_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_consulta As New WinConsulta
        ventana_consulta.Show()
        Me.Close()


    End Sub

    Private Sub bt_salir_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_main As New MainMedico
        ventana_main.Show()
        Me.Close()



    End Sub
End Class
