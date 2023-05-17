Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim emp As New EmployeeDB
    Dim dbs As New db
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim emp As New EmployeeDB
        Dim userids As String = TextBoxUserID.Text
        Dim names As String = TextBoxName.Text
        Dim user As String = TextBoxUser.Text
        Dim pass As String = TextBoxPass.Text
        Dim auth As String = ComboBox1.Text
        If verf() Then
            Dim query As String
            query = "select UserID from info where UserID = '" & userids & "'"
            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable
            Dim command As New MySqlCommand(query, dbs.getconn)

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                MsgBox("Already Exist User ID", MsgBoxStyle.Information, "Add User")
            Else
                Dim query1 As String
                query1 = "select USERNAME from info where USERNAME = '" & user & "'"
                Dim adapter1 As New MySqlDataAdapter
                Dim table1 As New DataTable
                Dim command1 As New MySqlCommand(query1, dbs.getconn)

                adapter1.SelectCommand = command1
                adapter1.Fill(table1)

                If table1.Rows.Count > 0 Then
                    MsgBox("Already Exist Username", MsgBoxStyle.Information, "Add User")
                Else

                    If emp.Insertuser(userids, names, user, pass, auth) Then
                        MsgBox("New User Added", MsgBoxStyle.Information, "Add User")
                        TextBoxUserID.Clear()
                        TextBoxName.Clear()
                        TextBoxUser.Clear()
                        TextBoxPass.Clear()
                        ComboBox1.SelectedIndex = -1



                    Else
                        MsgBox("Error", MsgBoxStyle.Critical, "Add User")
                    End If
                End If
            End If

        Else
            MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add User")
        End If
    End Sub
    Function verf() As Boolean

        If TextBoxUser.Text.Trim = "" Or TextBoxPass.Text.Trim() = "" Or ComboBox1.Text.Trim() = "" Then
            Return False
        Else
            Return True

        End If

    End Function

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()

    End Sub


    Private Sub TextBoxUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub TextBoxUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUser.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub TextBoxPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPass.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub
  
    Private Sub TextBoxName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True
        End Select
    End Sub
End Class