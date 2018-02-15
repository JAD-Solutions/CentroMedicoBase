Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)


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
