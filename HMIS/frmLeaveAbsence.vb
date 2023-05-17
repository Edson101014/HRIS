Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmLeaveAbsence
    Dim emp As New EmployeeDB()
    Dim dbs As New db
    Private Sub frmLeaveAbsence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command1 As New MySqlCommand("SELECT `Employee_ID`, `Name`, `Status`, `Reason`, `Time From`, `Time To`, `Other Reason` FROM `leavesystem`")
        fillGrid(command1)
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

    Private Sub txtapprovesearch_TextChanged(sender As Object, e As EventArgs) Handles Textboxsearch.TextChanged
        Dim command3 As New MySqlCommand("SELECT `Employee_ID`, `Name`, `Status`, `Reason`, `Time From`, `Time To`, `Other Reason` FROM `leavesystem` WHERE Name like '%" & TextBoxSearch.Text & "%'")
        fillGrid1(command3)
    End Sub
End Class