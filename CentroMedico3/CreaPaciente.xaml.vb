Public Class CreaPaciente
    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim creacita As New CreaCita
        creacita.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim verpacientes As New VerPacientes
        verpacientes.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim antecedente As New Antecedentes
        antecedente.Owner = Me
        antecedente.Show()
    End Sub
End Class
