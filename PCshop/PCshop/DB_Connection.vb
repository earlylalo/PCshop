Imports MySql.Data.MySqlClient

Public Module DB_Connection

    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectString As String

    Public Sub DB_CONNECT()
        myConnectString = "server=localhost; userid=root; password='julytwenty52001'; database=pcshop"
        conn.ConnectionString = myConnectString

        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

End Module