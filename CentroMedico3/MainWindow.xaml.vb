Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)


        'Dim cliente1 As Cliente = New Cliente("cliente", "cliapellido", "1212121212", "6 / 8 / 1998", "m", "0987654321", "Santo Domingo", "345678909", "austro")
        'Dim gesttorcliente1 As GestorCliente = New GestorCliente()
        'gesttorcliente1.agregarcliente(cliente1)

        'Dim recepci1 As Recepcionista = New Recepcionista("rrrrrr", "pppppp", "1324512345", "6 / 8 / 1998", "m", "0987654321", "Santo Domingo", "recepcionista", 1000, "10h00", "20h00", "password")
        'Dim gestorrecep1 As ControladorRecepcionista = New ControladorRecepcionista()
        'gestorrecep1.agregarrecepcionista(recepci1)

        'Dim medicamento1 As Medicina = New Medicina("Ibuprofeno", "200", "nada")
        'Dim cntromedica As ControladorMedicina = New ControladorMedicina()
        'cntromedica.agregarmedicina(medicamento1)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If (txtusuario.Text = "1") Then
            Dim mainrecepcionista As New MainRecepcionista
            mainrecepcionista.Show()
        Else
            Dim maindoctor As New WinConsulta
            maindoctor.Show()
        End If
        Me.Close()
    End Sub
End Class
