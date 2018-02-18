Class WinAtencionMedica

    Dim consulta1 As Consulta = New Consulta()
    Dim triaje_Actual As Triage = New Triage()

    'objetos para la cita
    'Dim cita1 As Cita = New Cita()

    'Dim antecedente1_pac As Antecedente = New Antecedente("rinitis", "alergias", "descripcion rinitis", "observacion rinitis")
    'Dim antecedente2_pac As Antecedente = New Antecedente("diarrea", "malicia", "descripcion diarrea", "observacion diarrea")

    'Dim paciente_cit As Paciente = New Paciente("Anthony", "Cabrera", "1718104027", 6 / 8 / 1998, "m", "Santo Domingo",)
    'Dim recepcionista_cit As Recepcionista = New Recepcionista()
    'Dim medico_cit As Medico = New Medico()

    Private Sub bt_historia_clinica_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana_historia_clinica As New WinHistoriaClinica
        ventana_historia_clinica.Show()

    End Sub

    Private Sub bt_agregar_medicina_Click(sender As Object, e As RoutedEventArgs)



        'abre siguiente ventana
        Dim ventana_medicina As New WinMedicina
        ventana_medicina.Show()

    End Sub

    Private Sub bt_guardar_consulta_Click(sender As Object, e As RoutedEventArgs)
        'toma signos vitales
        Dim fecha_ahora As Date = CDate(DateTime.Now.ToString("yyyy/MM/dd")) 'fecha
        MsgBox(fecha_ahora)
        'Dim peso As Double = CDbl(in_Peso.Text)
        'Dim peso_par As New ParametrosEvaluacion("Peso", peso, fecha_ahora) 'PARAMAETRO PESO

        'Dim estatura As Double = CDbl(in_Estatura.Text)
        'Dim estatura_par As New ParametrosEvaluacion("Estatura", estatura, fecha_ahora) 'PARAMAETRO ESTATURA

        'Dim presion As Double = CDbl(in_Presion.Text)
        'Dim presion_par As New ParametrosEvaluacion("Presion", presion, fecha_ahora) 'PARAMAETRO PRESION

        'Dim temperatura As Double = CDbl(in_Temperatura.Text)
        'Dim temperatura_par As New ParametrosEvaluacion("Temperatura", temperatura, fecha_ahora) 'PARAMAETRO TEMPERATURA

        'triaje_Actual.Parametros_eva_tri.Add(peso_par)
        'triaje_Actual.Parametros_eva_tri.Add(estatura_par)
        'triaje_Actual.Parametros_eva_tri.Add(presion_par)
        'triaje_Actual.Parametros_eva_tri.Add(temperatura_par)

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
