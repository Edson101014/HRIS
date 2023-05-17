Imports MySql.Data.MySqlClient

Public Class db
    Private con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=admin")
    ReadOnly Property getconn() As MySqlConnection
        Get
            Return con
        End Get
    End Property

    Sub opencon()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
    End Sub
    Sub closecon()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub
End Class
