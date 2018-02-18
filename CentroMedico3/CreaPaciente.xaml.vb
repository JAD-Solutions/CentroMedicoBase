Public Class CreaPaciente



    Dim paciente As Paciente = New Paciente()
    Dim antecedente As Antecedente = New Antecedente()

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        paciente.Antecedentes_pac = antecedente
        Me.DataContext = paciente

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim metodoBdd As ControladorAntecedentes = New ControladorAntecedentes()
        Dim gestorPac As ControladorPaciente = New ControladorPaciente()
        metodoBdd.agregarantecedente(antecedente)
        antecedente.Codigo_ant = metodoBdd.obtenerCodigoAntecedentes(antecedente.Descripcion_ant)
        gestorPac.agregarpaciente(paciente)



        'Dim creacita As New CreaCita
        'creacita.Show()
        'Me.Close()
        ' MsgBox(paciente.Apellido_per + paciente.Fecha_nac_per)
        ' MsgBox(paciente.Antecedentes_pac.Descripcion_ant)

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim verpacientes As New VerPacientes
        verpacientes.Show()
        Me.Close()

    End Sub

    '   Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
    '   Dim antecedente As New Antecedentes
    '   antecedente.Owner = Me
    '   antecedente.Show()
    '   End Sub
End Class
