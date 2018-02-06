Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim mainrecepcionista As New MainRecepcionista
        mainrecepcionista.Show()
        Me.Close()
    End Sub
End Class
