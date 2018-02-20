Class WinAtencionMedica

    'TRIAGE
    Dim triage_actual As Triage = New Triage()
    Dim control_tri As ControladorTriage = New ControladorTriage()
    Dim codigo_triage As Integer
    'PARAMETRO
    Dim control_par As ControladorParametros = New ControladorParametros()
    Dim hoy As DateTime = DateTime.Today

    Dim peso_parametro As ParametrosEvaluacion
    Dim estatuta_parametro As ParametrosEvaluacion
    Dim presion_parametro As ParametrosEvaluacion
    Dim temperatura_parametro As ParametrosEvaluacion

    'CONSULTA
    Dim consulta_actual As Consulta
    Dim control_con As ControladorConsulta = New ControladorConsulta()
    'CITA
    Dim cita_actual As Cita = New Cita()
    Dim codigo_cita As Integer

    'RECETAR MEDICINA
    Public receta_Actual As Receta = New Receta()
    Dim control_rec As ControladorReceta = New ControladorReceta()
    Dim contador As Integer = 1
    Dim control_lin As ControladorLineaReceta = New ControladorLineaReceta()
    Private descripcion_triage As String

    Public Sub New(descripcion_triage As String)

        InitializeComponent()
        Me.descripcion_triage = descripcion_triage
        triage_actual.Descripcion_tri = descripcion_triage
        control_tri.agregartriage(triage_actual)
    End Sub



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
        'Try
        If ((in_peso.Text = "") Or (in_estatura.Text = "") Or (in_presion.Text = "") Or (in_temperatura.Text = "") Or (in_diagnostico.Text = "")) Then
            MessageBox.Show("Llene todos los campos de toma de signos vitales y diagnóstico.", "Signos Vitales", MessageBoxButton.OK, MessageBoxImage.Error)
        Else
            If (CInt(in_peso.Text) < 0 Or CInt(in_estatura.Text) < 0 Or CInt(in_presion.Text) < 0 Or CInt(in_temperatura.Text) < 0) Then
                    MessageBox.Show("Dato incorrecto", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
                Else
                    triage_actual.Codigo_tri = control_tri.obtenerCodigoTriage(triage_actual.Descripcion_tri)
                    peso_parametro = New ParametrosEvaluacion("Peso", CDbl(in_peso.Text), hoy.ToString("d"), triage_actual)
                    estatuta_parametro = New ParametrosEvaluacion("Estatura", CDbl(in_estatura.Text), hoy.ToString("d"), triage_actual)
                    presion_parametro = New ParametrosEvaluacion("Presion", CDbl(in_presion.Text), hoy.ToString("d"), triage_actual)
                    temperatura_parametro = New ParametrosEvaluacion("Temperatura", CDbl(in_temperatura.Text), hoy.ToString("d"), triage_actual)
                    control_par.agregarparametros(peso_parametro)
                    control_par.agregarparametros(estatuta_parametro)
                    control_par.agregarparametros(presion_parametro)
                    control_par.agregarparametros(temperatura_parametro)

                cita_actual.Codigo_cit = 6
                consulta_actual = New Consulta(triage_actual.Descripcion_tri, in_diagnostico.Text, cita_actual, triage_actual)
                control_con.agregarconsulta(consulta_actual)
                Dim ventana_consulta As New WinConsulta
                    ventana_consulta.Show()
                    Me.Close()
                End If
            End If
        'Catch ex As Exception
        'MessageBox.Show("Error al ingreso " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        'End Try
    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)
        Dim volver As New WinConsulta
        volver.Show()
        Me.Close()


    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.DataContext = receta_Actual
        MsgBox(hoy.ToString("d"))

    End Sub

    Private Sub bt_peso_Click(sender As Object, e As RoutedEventArgs)
        Dim ven_peso_par As WinParametro = New WinParametro("Peso")
        ven_peso_par.triage1 = triage_actual 'ENVIO EL TRIAGE AL NUEVO PARÁMETRO
        ven_peso_par.Owner = Me
        ven_peso_par.Show()

    End Sub

    Private Sub bt_estatura_Click(sender As Object, e As RoutedEventArgs)
        Dim ven_estatura_par As WinParametro = New WinParametro("Estatura")
        ven_estatura_par.Owner = Me
        ven_estatura_par.Show()
    End Sub

    Private Sub bt_presion_Click(sender As Object, e As RoutedEventArgs)
        Dim ven_presion_par As WinParametro = New WinParametro("Presión")
        ven_presion_par.Owner = Me
        ven_presion_par.Show()
    End Sub

    Private Sub bt_temperatura_Click(sender As Object, e As RoutedEventArgs)
        Dim ven_temperatura_par As WinParametro = New WinParametro("Temperatura")
        ven_temperatura_par.Owner = Me
        ven_temperatura_par.Show()
    End Sub
End Class
