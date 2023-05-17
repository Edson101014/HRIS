Imports MySql.Data.MySqlClient
Public Class StartUp
    Private count = 0
    Dim emp As New EmployeeDB
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim query As String
        query = "select *from info where username='" & username.Text & "' and password='" & password.Text & "'"
        Dim dbs As New db
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim command As New MySqlCommand(query, dbs.getconn)
        
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim query1 As String
            Dim reader As MySqlDataReader
            query1 = "INSERT INTO logs(`TIME_IN`, `DATE`, `USERNAME`) VALUES ('" & LabelTime.Text & "', '" & LabelDate.Text & "', '" & username.Text & "') "
            Dim cmd As New MySqlCommand(query1, dbs.getconn)
            dbs.opencon()
            cmd.ExecuteNonQuery()


            reader = command.ExecuteReader
            reader.Read()
            Dim usertype = reader.GetString("AUTH_LEVEL")

            If usertype = "Administrator" Then

                MsgBox("Welcome ADMIN")
                dbs.closecon()
                Me.Hide()
                Admin.Show()
                username.Clear()
                password.Clear()
            Else
                MsgBox("Welcome Staff")
                dbs.closecon()


                Staff.TextBoxuseername.Text = username.Text
                Staff.Show()
                Me.Hide()

                username.Clear()
                password.Clear()

            End If

        Else
            count = count + 1
            If count < 3 Then
                MsgBox("USERNAME OR PASSWORD INCORRECT", MsgBoxStyle.Critical, "Login Error")
            End If
            If count = 3 Then
                MsgBox("You exceed try again, app is now close", MsgBoxStyle.Critical)
                Me.Close()
            End If
        End If
       
    End Sub
    


    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LabelDate.Text = DateTime.Now.ToLongDateString



    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub StartUp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub



    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call login_Click(sender, e)
        End If

    End Sub




 
End Class
