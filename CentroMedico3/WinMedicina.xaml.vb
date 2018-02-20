Imports System.Data

Class WinMedicina
    Dim contr As ControladorMedicina = New ControladorMedicina()
    Dim medicina1 As Medicina
    Public receta1 As Receta = New Receta()
    Public linea_receta As LineaReceta = New LineaReceta()
    'Dim ventana_receta As WinReceta = New WinReceta()
    Dim control_rec As ControladorReceta = New ControladorReceta()
    Public codigo_receta As Integer
    Dim control_lin As ControladorLineaReceta = New ControladorLineaReceta()

    Private Sub ComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)


    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As RoutedEventArgs)

        'Dim control_lin As ControladorLineaReceta = New ControladorLineaReceta()

        'MsgBox(receta1.Descripcion_rec)
        codigo_receta = control_rec.obtenerCodigoReceta(receta1.Descripcion_rec)
        'MsgBox(codigo_receta)
        receta1.Codigo_rec = codigo_receta
        linea_receta.Receta_lin = receta1
        linea_receta.Medicina_lin = medicina1

        If in_cantidad.Text = Nothing Then
            MsgBox("No se ingresó la cantidad")
        Else
            linea_receta.Cantidad_lin = CInt(in_cantidad.Text)
            'MsgBox(linea_receta.Cantidad_lin)
            control_lin.agregarlinea(linea_receta)
        End If
        Me.Close()

    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)

        Me.Close()


    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'Me.DataContext = linea_receta
        contr.mostrarmedicinaCombo(cb_medicina)
        'MsgBox(receta1.Descripcion_rec)

    End Sub

    Private Sub cb_medicina_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim row_Actual As DataRowView = DirectCast(cb_medicina.SelectedValue, DataRowView)
        medicina1 = New Medicina(CStr(row_Actual("nombre_mec")), CStr(row_Actual("contenido_mec")), CStr(row_Actual("descripcion_mec")))
        'MsgBox(cb_medicina.SelectedValue.ToString)
        medicina1.Codigo_mec = (CInt(row_Actual("codigo_mec")))

        Me.DataContext = medicina1

        'MsgBox(medicina1.Contenido_mec + " " + medicina1.Descripcion_mec + " " + medicina1.Nombre_mec)
    End Sub

End Class
