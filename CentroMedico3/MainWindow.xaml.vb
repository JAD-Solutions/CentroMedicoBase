Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim metodoBdd As ControladorAntecedentes = New ControladorAntecedentes()


        'Dim antecedente1 As Antecedente = New Antecedente("tenia diarrea")
        'metodoBdd.agregarantecedente(antecedente1)
        'antecedente1.Codigo_ant = 4
        'Dim paciente1 As Paciente = New Paciente("Anthony", "Cabrera", "111111111", "6 / 8 / 1998", "m", "0987654321", "Santo Domingo", antecedente1)

        'Dim gestorPac As ControladorPaciente = New ControladorPaciente()
        'gestorPac.agregarpaciente(paciente1)

        'Dim cliente1 As Cliente = New Cliente("cliente", "cliapellido", "1212121212", "6 / 8 / 1998", "m", "0987654321", "Santo Domingo", "345678909", "austro")
        'Dim gesttorcliente1 As GestorCliente = New GestorCliente()
        'gesttorcliente1.agregarcliente(cliente1)

        Dim recepci1 As Recepcionista = New Recepcionista("rrrrrr", "pppppp", "1324512345", "6 / 8 / 1998", "m", "0987654321", "Santo Domingo", "recepcionista", 1000, "10h00", "20h00")
        Dim gestorrecep1 As ControladorRecepcionista = New ControladorRecepcionista()
        gestorrecep1.agregarrecepcionista(recepci1)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If (txtusuario.Text = "1") Then
            Dim mainrecepcionista As New MainRecepcionista
            mainrecepcionista.Show()
        Else
            Dim maindoctor As New MainMedico
            maindoctor.Show()
        End If
        Me.Close()
    End Sub
End Class