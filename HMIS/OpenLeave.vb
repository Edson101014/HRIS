Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class OpenLeave
    Dim emp As New EmployeeDB()
    Dim dbs As New db

    Private Sub OpenLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command1 As New MySqlCommand("SELECT employee.Employee_ID,employee.Name,employee.Jobtitle,employee.Department,payroll.NetSalary FROM employee,payroll where employee.employee_id=payroll.employee_id")
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
    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim command3 As New MySqlCommand("SELECT employee.Employee_ID,employee.Name,employee.Jobtitle,employee.Department,payroll.NetSalary FROM employee,payroll WHERE Name like '%" & TextBoxSearch.Text & "%'")
        fillGrid1(command3)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            With Me
                Admin.TextBoxLeaveId.Text = .DataGridView1.CurrentRow.Cells(0).Value
                Admin.TextBoxLeaveName.Text = .DataGridView1.CurrentRow.Cells(1).Value
                Admin.LeaveDepartment.Text = .DataGridView1.CurrentRow.Cells(2).Value.ToString
                Admin.LeavePosition.Text = .DataGridView1.CurrentRow.Cells(3).Value.ToString
                Admin.LeaveSalary.Text = .DataGridView1.CurrentRow.Cells(4).Value.ToString

            End With

            Me.Close()
        Catch ex As Exception
            MsgBox("Please select employee from the table!")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class