Imports System.Data

Class WinParametro

    Public triage1 As Triage = New Triage()
    Private v As String
    Public codigo_triage As Integer


    Public Sub New(v As String)
        InitializeComponent()
        Me.v = v
    End Sub
    Private Sub bt_agregar_Click(sender As Object, e As RoutedEventArgs)

        'Dim control_lin As ControladorLineaReceta = New ControladorLineaReceta()

        'MsgBox(receta1.Descripcion_rec)
        'codigo_receta = control_rec.obtenerCodigoReceta(receta1.Descripcion_rec)
        ''MsgBox(codigo_receta)
        'receta1.Codigo_rec = codigo_receta
        'linea_receta.Receta_lin = receta1
        'linea_receta.Medicina_lin = medicina1

        'If in_cantidad.Text = Nothing Then
        '    MsgBox("No se ingresó la cantidad")
        'Else
        '    linea_receta.Cantidad_lin = CInt(in_cantidad.Text)
        '    'MsgBox(linea_receta.Cantidad_lin)
        '    control_lin.agregarlinea(linea_receta)
        'End If
        Me.Close()

    End Sub

    Private Sub bt_volver_Click(sender As Object, e As RoutedEventArgs)

        Me.Close()


    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        'Me.DataContext = linea_receta
        'contr.mostrarmedicinaCombo(cb_medicina)
        'MsgBox(receta1.Descripcion_rec)
        MsgBox(triage1.Descripcion_tri)

    End Sub

End Class
