Class WinConsulta


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub bt_atender_Click(sender As Object, e As RoutedEventArgs)
        ingresarAtencion()
    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)
        Dim principal As New MainWindow
        principal.Show()
        Me.Close()

    End Sub

    Private Sub lstConsultas_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        ingresarAtencion()
    End Sub

    Public Sub ingresarAtencion()
        Dim descripcion_triage As String
        If (lstConsultas.SelectedItem Is Nothing) Then
            MessageBox.Show("Debe seleccionar una de las citas para continuar.", "Alerta", MessageBoxButton.OK, MessageBoxImage.Error)
        Else
            descripcion_triage = InputBox("¿Cuáles son sus síntomas?", "Síntomas", "malestar general")
            'MsgBox(descripcion_triage)
            If (descripcion_triage = Nothing) Then
                MessageBox.Show("Debe ingresar un motivo para la consulta.", "Alerta", MessageBoxButton.OK, MessageBoxImage.Error)
            Else
                Dim ventana_atencion As New WinAtencionMedica(descripcion_triage)
                ventana_atencion.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
