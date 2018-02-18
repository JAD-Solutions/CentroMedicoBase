Public Class VerPacientes
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim creapaciente As New CreaPaciente
        creapaciente.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim mainrecepcionista As New MainRecepcionista
        mainrecepcionista.Show()
        Me.Close()

    End Sub

    Private Sub lst_paciente_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lst_paciente.SelectionChanged
        Dim consultapaciente As New ConsultaPaciente
        consultapaciente.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
