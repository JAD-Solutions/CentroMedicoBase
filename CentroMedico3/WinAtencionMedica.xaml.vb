Class WinAtencionMedica

    'TRIAGE

    Dim peso_parametro As ParametrosEvaluacion = New ParametrosEvaluacion()
    Dim estatuta_parametro As ParametrosEvaluacion = New ParametrosEvaluacion()
    Dim presion_parametro As ParametrosEvaluacion = New ParametrosEvaluacion()
    Dim temperatura_parametro As ParametrosEvaluacion = New ParametrosEvaluacion()

    'CONSULTA

    'RECETAR MEDICINA
    Public receta_Actual As Receta = New Receta()
    Dim control_rec As ControladorReceta = New ControladorReceta()
    Dim contador As Integer = 1
    Dim control_lin As ControladorLineaReceta = New ControladorLineaReceta()

    Private Sub bt_historia_clinica_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_historia_clinica As New WinHistoriaClinica
        ventana_historia_clinica.Show()

    End Sub

    Private Sub bt_agregar_medicina_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_medicina As WinMedicina = New WinMedicina()

        MsgBox(receta_Actual.Descripcion_rec)

        If (contador = 1) Then
            control_rec.agregarreceta(receta_Actual)
        End If
        ventana_medicina.receta1 = receta_Actual
            MsgBox(ventana_medicina.receta1.Descripcion_rec)
            ventana_medicina.Owner = Me
            ventana_medicina.ShowDialog()
            Dim codigo_rec As Integer = ventana_medicina.codigo_receta
            ' MsgBox(codigo_rec)
            Dim condicion As String
            condicion = "codigo_rec = " + codigo_rec.ToString + " and t_medicina.codigo_mec=t_lineaReceta.codigo_mec"

            control_lin.mostrarLineaRecetaEspecifica(condicion, lv_linea_receta)
        contador = contador + 1


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

    Private Sub bt_parametro_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_par As WinParametro = New WinParametro()
        ventana_par.Show()
        Me.Close()

    End Sub
End Class
