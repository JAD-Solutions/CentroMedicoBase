Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)


    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If (txtusuario.Text = "1") Then
            Dim mainrecepcionista As New MainRecepcionista
            mainrecepcionista.Show()
        Else
<<<<<<< HEAD
            Dim maindoctor As New WinConsulta
=======
            Dim maindoctor As New MainMedico
>>>>>>> 2cb7a89fe315b5b13cf267ebc6a1c84b90317923
            maindoctor.Show()
        End If
        Me.Close()
    End Sub
End Class
