Class WinReceta

    Public receta_Actual As Receta = New Receta()
    Dim control_rec As ControladorReceta = New ControladorReceta()
    Dim ventana_medicina As WinMedicina = New WinMedicina()

    'Dim ventana_linea_receta As WinMedicina = New WinMedicina()

    Private Sub bt_historia_clinica_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_historia_clinica As New WinHistoriaClinica
        ventana_historia_clinica.Show()

    End Sub

    Private Sub bt_agregar_medicina_Click(sender As Object, e As RoutedEventArgs)
        MsgBox(receta_Actual.Descripcion_rec)
        If (in_diagnostico.Text = Nothing) Then
            MsgBox("No se ingresó nada")
        Else
            control_rec.agregarreceta(receta_Actual)
            ventana_medicina.receta1 = receta_Actual
            MsgBox(ventana_medicina.receta1.Descripcion_rec)
            ventana_medicina.Show()
        End If




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

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.DataContext = receta_Actual

    End Sub
End Class
