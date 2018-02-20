Imports System.Data
Imports System.Data.SqlClient
Public Class Coneccion

    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Dim cnnString As String


    Public Sub New()
        Try
            cnnString = "Data Source=DESKTOP-NNQ0KS1;Initial Catalog=Sistema_Medico_HL7V2 ;Integrated Security=SSPI;Connection Timeout=50"

            cnn = New SqlConnection(cnnString)
        Catch exbd As SqlException
            Dim msgError As String = exbd.Message
        Catch ex As Exception

        End Try
    End Sub
    Public Sub transaccionSQL(ByVal sql As String)
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
        Catch exbd As SqlException
            Dim msgError As String = exbd.Message
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub
    Public Sub mostrarEnCombo()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM Categories"

        Dim sqlDa As SqlDataAdapter = New SqlDataAdapter()
        sqlDa.SelectCommand = cmd

        Dim ds As DataSet = New DataSet()

        Try
            sqlDa.Fill(ds, "nombre_mec")


        Catch ex As Exception

        End Try


    End Sub

End Class
