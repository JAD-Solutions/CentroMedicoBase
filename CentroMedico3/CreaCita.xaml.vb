Public Class CreaCita
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim creapaciente As New CreaPaciente
        creapaciente.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim vercitas As New VerCitas
        vercitas.Show()
        Me.Close()

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        'aqui se hace una validacion de la existencia del paciente y la fecha disponible
        MsgBox("nueva cita guardada")
        Dim vercitas As New VerCitas
        vercitas.Show()
        Me.Close()
    End Sub
End Class
