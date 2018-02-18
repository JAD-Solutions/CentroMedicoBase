Imports System.Data
Imports System.Data.SqlClient
Public Class Plantillasql
    Inherits Coneccion
    Public Function eliminar(ByVal tabla As String, ByVal condicion As String) As Boolean
        Try
            Dim sql As String
            sql = "DELETE FROM" + tabla + "WHERE" + condicion
            transaccionSQL(sql)
            Return True
        Catch ex As Exception
            Throw (New Exception("Error en la Base de datos"))
        End Try

    End Function

    'Public Function insertarDato(ByVal campos() As String, ByVal valores() As String, ByVal tabla As String)
    '    Try
    '        Dim sql As String
    '        sql = "INSERT INTO " + tabla + " "

    '        'transaccionSQL(sql)
    '        sql = sql + " VALUES ("
    '        For Each valor In valores
    '            If i = 0 Then
    '                sql = sql + "'" + valor + "'"
    '            Else
    '                sql = sql + ",'" + valor + "'"
    '            End If
    '            i = i + 1
    '        Next
    '        sql = sql + ")"
    '        transaccionSQL(sql)
    '        Return True
    '    Catch ex As Exception
    '        Throw (New Exception("Error en la Base de datos"))
    '    End Try
    'End Function
    Public Function insertarDato(ByVal campos() As String, ByVal valores() As String, ByVal tabla As String) As Boolean

        Try
            Dim sql As String
            sql = "INSERT INTO " + tabla + " "
            Dim i As Integer

            sql = sql + " VALUES ("
            For index = 1 To valores.Length - 1
                If index = 1 Then
                    sql = sql + "" + valores(index) + ""
                Else
                    sql = sql + "," + valores(index) + ""
                End If
                i = i + 1
            Next
            sql = sql + ")"

            MsgBox(sql)
            transaccionSQL(sql)
            Return True
        Catch ex As Exception
            Throw (New Exception("Error en la base de datos"))
        End Try
    End Function
    Public Function Selectdato(ByVal campos() As String, ByVal tabla As String, ByVal lista As ListView)
        Try
            Dim sql As String = "Select "
            Dim i As Integer
            i = 0
            For Each campo In campos
                If i = 0 Then
                    sql = sql + "" + campo
                Else
                    sql = sql + "," + campo
                End If
                i = i + 1
            Next
            sql = sql + " from " + tabla
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, tabla)
            lista.ItemsSource = ds.Tables(tabla).DefaultView
            cnn.Close()
            Return True
        Catch ex As Exception
            Throw (New Exception("Error en la Base de datos"))
        End Try

    End Function
    Public Function Select1dato(ByVal campo0 As String, ByVal campo As String, ByVal valor As String, ByVal tabla As String) As Integer
        Try
            Dim sql As String
            Dim SelecID As Integer
            sql = "Select " + campo0 + " from " + tabla + " where " + campo + "=" + valor + ""
            MsgBox(sql)
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            SelecID = cmd.ExecuteScalar
            cnn.Close()
            Return SelecID
        Catch ex As Exception
            Throw (New Exception("Error en la Base de datos"))
        End Try

    End Function
End Class
