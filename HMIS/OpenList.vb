Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class OpenList
    Dim emp As New EmployeeDB()
    Dim dbs As New db
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim command3 As New MySqlCommand("SELECT `Employee_ID`,`Name`,`ClientRate`,`HourPerDay`,`WorkDay` FROM `employee` WHERE Name like '%" & TextBoxSearch.Text & "%'")
        fillGrid1(command3)
    End Sub
    Sub fillGrid1(ByVal command As MySqlCommand)
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = emp.getemployee(command)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    End Sub
    Sub fillGrid(ByVal command As MySqlCommand)
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = emp.getemployee(command)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With Me
                Admin.TextBoxPayID.Text = .DataGridView1.CurrentRow.Cells(0).Value
                Admin.TextBoxPayName.Text = .DataGridView1.CurrentRow.Cells(1).Value
                Admin.TextBoxPayrate.Text = .DataGridView1.CurrentRow.Cells(2).Value.ToString
                Admin.TextBoxPayHour.Text = .DataGridView1.CurrentRow.Cells(3).Value.ToString
                Admin.TextBoxPayWork.Text = .DataGridView1.CurrentRow.Cells(4).Value.ToString

            End With

            Me.Close()
        Catch ex As Exception
            MsgBox("Please select employee from the table!")
        End Try
    End Sub

    Private Sub OpenList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command1 As New MySqlCommand("SELECT `Employee_ID`,`Name`,`ClientRate`,`HourPerDay`,`WorkDay` FROM `employee`")
        fillGrid(command1)
    End Sub
End Class