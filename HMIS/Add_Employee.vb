Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Add_Employee
    Dim currentdate As Integer = DateTime.Now.Year
    Private Sub Add_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "../../Images/default.png"

    End Sub
    Private Sub TextBoxPay_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub TextBoxEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEmpID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Dim opimage As New OpenFileDialog
        opimage.Filter = "Select Image(*.jpg;*.png;*.gif;)|*.jpg;*.png;*.gif;"
        If opimage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opimage.FileName)

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emp As New EmployeeDB
        Dim dbs As New db
        Dim empID As String = TextBoxEmpID.Text
        Dim name As String = TextBoxName.Text
        Dim addr As String = TextBoxAddress.Text
        Dim phone As String = TextBoxPhone.Text
        Dim email As String = TextBoxEmail.Text
        Dim hrdate As Date = DateTimePicker1.Value.Date
        Dim gender As String = ComboBoxGender.Text
        Dim dob As Date = DateTimePicker2.Value.Date
        Dim jobt As String = ComboBoxJobtitle.Text
        Dim stdate As Date = DateTimePicker3.Value.Date
        Dim client As String = TextBoxClientRate.Text
        Dim jobclass As String = TextBoxJobClass.Text
        Dim status As String = ComboBoxStatus.Text
        Dim depart As String = ComboBoxDepartment.Text
        Dim citi As String = TextBoxCitizenship.Text
        Dim reli As String = TextBoxReligion.Text
        Dim age As String = TextBoxAge.Text
        Dim elem As String = TextBoxElem.Text
        Dim high As String = TextBoxHighschool.Text
        Dim col As String = TextBoxCollege.Text
        Dim elemyear As Integer = DateTimePicker4.Value.Year
        Dim highyear As Integer = DateTimePicker5.Value.Year
        Dim collyear As Integer = DateTimePicker6.Value.Year
        Dim hour As Integer = TextBoxHourDay.Text
        Dim work As Integer = TextBoxWorkDay.Text
        Dim pic As New MemoryStream
        Dim hire_date As Date = DateTimePicker1.Value
        Dim start_date As Date = DateTimePicker3.Value
        Dim born_year As Integer = DateTimePicker2.Value.Year
        Dim this_year As Integer = Date.Now.Year
        Dim now_date As Date = Date.Now

        If this_year - born_year < 15 Or this_year - born_year > 100 Or hire_date > now_date Or start_date > now_date Then
            MsgBox("Enter the Date Correctly", MsgBoxStyle.Information, "Date Error")
        Else


            If verf() Then
                Dim query As String
                query = "select Employee_ID from employee where Employee_ID = '" & empID & "'"
                Dim adapter As New MySqlDataAdapter
                Dim table As New DataTable
                Dim command As New MySqlCommand(query, dbs.getconn)

                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    MsgBox("Already Exist Employee_ID", MsgBoxStyle.Information, "Add Employee")
                Else
                    Dim query1 As String
                    query1 = "select Name from employee where Name = '" & name & "'"
                    Dim adapter1 As New MySqlDataAdapter
                    Dim table1 As New DataTable
                    Dim command1 As New MySqlCommand(query1, dbs.getconn)

                    adapter1.SelectCommand = command1
                    adapter1.Fill(table1)

                    If table1.Rows.Count > 0 Then
                        MsgBox("Already Exist Name", MsgBoxStyle.Information, "Add User")
                    Else
                        PictureBox1.Image.Save(pic, PictureBox1.Image.RawFormat)
                        If emp.InsertEmployee(empID, pic, name, addr, phone, email, status, hrdate, gender, dob, jobt, stdate, jobclass, depart, client, citi, reli, age, elem, high, col, elemyear, highyear, collyear, hour, work) Then
                            MsgBox("New Employee Added", MsgBoxStyle.Information, "Add Employee")
                            Staff.TextBoxActName.Text = TextBoxName.Text
                            TextBoxEmpID.Clear()
                            TextBoxName.Clear()
                            TextBoxAddress.Clear()
                            TextBoxPhone.Clear()
                            TextBoxEmail.Clear()
                            TextBoxJobClass.Clear()
                            TextBoxClientRate.Clear()
                            TextBoxCitizenship.Clear()
                            TextBoxReligion.Clear()
                            TextBoxAge.Clear()
                            TextBoxElem.Clear()
                            TextBoxHighschool.Clear()
                            TextBoxCollege.Clear()
                            ComboBoxDepartment.SelectedIndex = -1
                            ComboBoxStatus.SelectedIndex = -1
                            ComboBoxJobtitle.SelectedIndex = -1
                            ComboBoxGender.SelectedIndex = -1
                            PictureBox1.ImageLocation = "../../Images/default.png"

                            Me.Close()





                        Else
                            MsgBox("Error", MsgBoxStyle.Critical, "Add Employee")
                        End If
                    End If
                End If
            Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Employee")
            End If

        End If
    End Sub

    Function verf() As Boolean

        If TextBoxEmpID.Text.Trim = "" Or TextBoxName.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Or TextBoxPhone.Text.Trim() = "" Or ComboBoxStatus.Text.Trim() = "" Or
            ComboBoxGender.Text.Trim() = "" Or ComboBoxDepartment.Text.Trim() = "" Or TextBoxJobClass.Text.Trim() = "" Or ComboBoxDepartment.Text.Trim() = "" Or TextBoxClientRate.Text.Trim() = "" Or TextBoxCitizenship.Text.Trim() = "" Or TextBoxHourDay.Text.Trim() = "" Or TextBoxWorkDay.Text.Trim() = "" Then
            Return False
        Else
            Return True

        End If

    End Function



    Private Sub TextBoxName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub



    Private Sub TextBoxJobClass_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        TextBoxAge.Text = currentdate - DateTimePicker2.Value.Date.Year
    End Sub

    Private Sub TextBoxCitizenship_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxReligion_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxElem_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxHighschool_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxCollege_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxJobClass_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxJobClass.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxAge_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHighYear_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCollegeYear_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCitizenship_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxCitizenship.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxReligion_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxReligion.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxElem_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxElem.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxHighschool_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxHighschool.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxCollege_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TextBoxCollege.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxElemYear_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHighYear_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCollegeYear_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxAge_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBoxAge.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxClientRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxClientRate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        TextBoxAge.Text = currentdate - DateTimePicker2.Value.Year
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHourDay.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxWorkDay.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class