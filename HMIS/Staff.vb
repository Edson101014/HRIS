Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Staff
    Const txtflag = 0
    'Employee Management
    Dim emp As New EmployeeDB()
    Dim dbs As New db
    Dim nub As String
    Dim bin As String

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
        fillGrid(command)
        TextBoxEmpID.Enabled = False
        TextBoxName.Enabled = False
        TextBoxAddress.Enabled = False
        TextBoxPhone.Enabled = False
        TextBoxEmail.Enabled = False
        ComboBoxStatus.Enabled = False
        ComboBoxDept.Enabled = False
        ComboBoxGender.Enabled = False
        TextBoxJobClass.Enabled = False
        ComboBoxJobTitle.Enabled = False
        DateTimePickerBirth.Enabled = False
        DateTimePickerHire.Enabled = False
        DateTimePickerStart.Enabled = False
        ButtonUpload.Enabled = False
       
        TextBoxCitizenship.Enabled = False
        TextBoxReligion.Enabled = False
        TextBoxElem.Enabled = False
        TextBoxElemYear.Enabled = False
        TextBoxHighschool.Enabled = False
        TextBoxHighYear.Enabled = False
        TextBoxCollege.Enabled = False
        TextBoxCollegeYear.Enabled = False
        TextBoxClientRate.Enabled = False
        TextBoxWorkDay.Enabled = False
        ButtonEdit.Enabled = False
        ButtonRemove.Enabled = False
        TextBoxHourDay.Enabled = False

        Timer1.Start()
        LabelDate.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub Staff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim query1 As String

        If MsgBox("Are You Sure? You Want To Exit", MsgBoxStyle.YesNo, "Log Out") <> DialogResult.No Then

            query1 = "INSERT INTO logs2(`TIME_OUT`) VALUES ('" & LabelTime.Text & "') "
            Dim cmd As New MySqlCommand(query1, dbs.getconn)
            dbs.opencon()
            cmd.ExecuteNonQuery()
            dbs.closecon()
            StartUp.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click
        Dim query1 As String

        If MsgBox("Are You Sure? You Want To Exit", MsgBoxStyle.YesNo, "Log Out") <> DialogResult.No Then

            query1 = "INSERT INTO logs2(`TIME_OUT`) VALUES ('" & LabelTime.Text & "') "
            Dim cmd As New MySqlCommand(query1, dbs.getconn)
            dbs.opencon()
            cmd.ExecuteNonQuery()
            dbs.closecon()
            Me.Hide()

            StartUp.Show()

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        LabelTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
  
   
    Sub fillGrid(ByVal command As MySqlCommand)
        DataGridViewEmp.ReadOnly = True
        Dim picCol As New DataGridViewImageColumn
        DataGridViewEmp.RowTemplate.Height = 80
        DataGridViewEmp.DataSource = emp.getemployee(command)
        picCol = DataGridViewEmp.Columns(1)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        LabelTotal.Text = "Total Employee: " & DataGridViewEmp.Rows.Count
    End Sub


    Private Sub DataGridViewEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmp.CellContentClick
        TextBoxName.Enabled = True
        TextBoxAddress.Enabled = True
        TextBoxPhone.Enabled = True
        TextBoxEmail.Enabled = True
        ComboBoxStatus.Enabled = True
        ComboBoxDept.Enabled = True
        ComboBoxGender.Enabled = True
        TextBoxJobClass.Enabled = True
        ComboBoxJobTitle.Enabled = True
        DateTimePickerBirth.Enabled = True
        DateTimePickerHire.Enabled = True
        DateTimePickerStart.Enabled = True
        ButtonUpload.Enabled = True
        TextBoxCitizenship.Enabled = True
        TextBoxReligion.Enabled = True
        TextBoxElem.Enabled = True
        TextBoxElemYear.Enabled = True
        TextBoxHighschool.Enabled = True
        TextBoxHighYear.Enabled = True
        TextBoxCollege.Enabled = True
        TextBoxCollegeYear.Enabled = True
        TextBoxClientRate.Enabled = True
        TextBoxWorkDay.Enabled = True
        TextBoxHourDay.Enabled = True
        ButtonEdit.Enabled = True

        ButtonRemove.Enabled = True

        TextBoxEmpID.Text = DataGridViewEmp.CurrentRow.Cells(0).Value.ToString
        Dim pic As Byte()
        pic = DataGridViewEmp.CurrentRow.Cells(1).Value
        Dim pics As New MemoryStream(pic)
        PictureBoxEmp.Image = Image.FromStream(pics)
        TextBoxName.Text = DataGridViewEmp.CurrentRow.Cells(2).Value.ToString
        TextBoxAddress.Text = DataGridViewEmp.CurrentRow.Cells(3).Value.ToString
        TextBoxPhone.Text = DataGridViewEmp.CurrentRow.Cells(4).Value.ToString
        TextBoxEmail.Text = DataGridViewEmp.CurrentRow.Cells(5).Value.ToString
        DateTimePickerHire.Value = DataGridViewEmp.CurrentRow.Cells(6).Value
        ComboBoxGender.Text = DataGridViewEmp.CurrentRow.Cells(7).Value
        ComboBoxStatus.Text = DataGridViewEmp.CurrentRow.Cells(8).Value
        DateTimePickerBirth.Value = DataGridViewEmp.CurrentRow.Cells(9).Value
        ComboBoxJobTitle.Text = DataGridViewEmp.CurrentRow.Cells(10).Value
        DateTimePickerStart.Value = DataGridViewEmp.CurrentRow.Cells(11).Value
        TextBoxClientRate.Text = DataGridViewEmp.CurrentRow.Cells(12).Value.ToString
        TextBoxJobClass.Text = DataGridViewEmp.CurrentRow.Cells(13).Value.ToString
        ComboBoxDept.Text = DataGridViewEmp.CurrentRow.Cells(14).Value
        TextBoxCitizenship.Text = DataGridViewEmp.CurrentRow.Cells(15).Value.ToString
        TextBoxReligion.Text = DataGridViewEmp.CurrentRow.Cells(16).Value.ToString
        TextBoxAge.Text = DataGridViewEmp.CurrentRow.Cells(17).Value.ToString
        TextBoxElem.Text = DataGridViewEmp.CurrentRow.Cells(18).Value.ToString
        TextBoxHighschool.Text = DataGridViewEmp.CurrentRow.Cells(19).Value.ToString
        TextBoxCollege.Text = DataGridViewEmp.CurrentRow.Cells(20).Value.ToString
        TextBoxElemYear.Text = DataGridViewEmp.CurrentRow.Cells(21).Value.ToString
        TextBoxHighYear.Text = DataGridViewEmp.CurrentRow.Cells(22).Value.ToString
        TextBoxCollegeYear.Text = DataGridViewEmp.CurrentRow.Cells(23).Value.ToString
        TextBoxHourDay.Text = DataGridViewEmp.CurrentRow.Cells(24).Value.ToString
        TextBoxWorkDay.Text = DataGridViewEmp.CurrentRow.Cells(25).Value.ToString
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        TextBoxEmpID.Clear()
        TextBoxName.Clear()
        TextBoxAddress.Clear()
        TextBoxPhone.Clear()
        TextBoxEmail.Clear()
        TextBoxJobClass.Clear()
        TextBoxCitizenship.Clear()
        TextBoxReligion.Clear()
        TextBoxElem.Clear()
        TextBoxHighschool.Clear()
        TextBoxCollege.Clear()
        TextBoxElemYear.Clear()
        TextBoxHighYear.Clear()
        TextBoxCollegeYear.Clear()
        TextBoxClientRate.Clear()
        TextBoxHourDay.Clear()
        TextBoxWorkDay.Clear()

        DateTimePickerHire.Value = Date.Now
        DateTimePickerBirth.Value = Date.Now
        DateTimePickerStart.Value = Date.Now
        TextBoxEmpID.Enabled = False
        TextBoxName.Enabled = False
        TextBoxAddress.Enabled = False
        TextBoxPhone.Enabled = False
        TextBoxEmail.Enabled = False
        ComboBoxStatus.Enabled = False
        ComboBoxDept.Enabled = False
        ComboBoxGender.Enabled = False
        TextBoxJobClass.Enabled = False
        TextBoxCitizenship.Enabled = False
        TextBoxReligion.Enabled = False
        TextBoxElem.Enabled = False
        TextBoxElemYear.Enabled = False
        TextBoxHighschool.Enabled = False
        TextBoxHighYear.Enabled = False
        TextBoxCollege.Enabled = False
        TextBoxCollegeYear.Enabled = False
        TextBoxClientRate.Enabled = False
        ComboBoxJobTitle.Enabled = False
        DateTimePickerBirth.Enabled = False
        DateTimePickerHire.Enabled = False
        DateTimePickerStart.Enabled = False
        ButtonUpload.Enabled = False
        TextBoxWorkDay.Enabled = False
        TextBoxHourDay.Enabled = False
        ButtonEdit.Enabled = False
        ButtonRemove.Enabled = False
        ComboBoxGender.SelectedIndex = -1
        ComboBoxDept.SelectedIndex = -1
        ComboBoxJobTitle.SelectedIndex = -1
        ComboBoxStatus.SelectedIndex = -1
        PictureBoxEmp.ImageLocation = "../../Images/defaultpic.png"
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
                fillGrid(command)
            Else
                Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` WHERE Employee_ID like '%" & TextBoxSearch.Text & "%'")
                fillGrid(command)
            End If

        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
                fillGrid(command)
            Else
                Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` WHERE Name like '%" & TextBoxSearch.Text & "%'")
                fillGrid(command)
            End If
        End If
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Try
            Dim empID As Integer = Convert.ToInt32(TextBoxEmpID.Text)
            If MsgBox("Are You Sure? You Want To Delete This Employee", MsgBoxStyle.YesNo, "Delete Employee") = MsgBoxResult.Yes Then
                If emp.deleteEmp(empID) Then
                    MsgBox("Employee Successfully DELETED", MsgBoxStyle.Information, "Delete Employee")
                    Dim namess As String = TextBoxuseername.Text
                    Dim action As String = "Remove"
                    Dim desc As String = TextBoxName.Text
                    Dim tim As String = DateTime.Now.ToLongDateString
                    If emp.InserActivity(namess, action, desc, tim) Then
                    Else
                        MsgBox("error", MsgBoxStyle.Information, "Error")
                    End If
                    TextBoxEmpID.Clear()
                    TextBoxName.Clear()
                    TextBoxAddress.Clear()
                    TextBoxPhone.Clear()
                    TextBoxEmail.Clear()
                    TextBoxJobClass.Clear()
                    TextBoxCitizenship.Clear()
                    TextBoxReligion.Clear()
                    TextBoxElem.Clear()
                    TextBoxHighschool.Clear()
                    TextBoxCollege.Clear()
                    TextBoxElemYear.Clear()
                    TextBoxHighYear.Clear()
                    TextBoxCollegeYear.Clear()
                    TextBoxClientRate.Clear()
                    TextBoxHourDay.Clear()
                    TextBoxWorkDay.Clear()
                    PictureBoxEmp.ImageLocation = "../../Images/defaultpic.png"
                    DateTimePickerHire.Value = Date.Now
                    DateTimePickerBirth.Value = Date.Now
                    DateTimePickerStart.Value = Date.Now
                    TextBoxName.Enabled = False
                    TextBoxAddress.Enabled = False
                    TextBoxPhone.Enabled = False
                    TextBoxEmail.Enabled = False
                    ComboBoxStatus.Enabled = False
                    ComboBoxDept.Enabled = False
                    ComboBoxGender.Enabled = False
                    TextBoxJobClass.Enabled = False
                    ComboBoxJobTitle.Enabled = False
                    DateTimePickerBirth.Enabled = False
                    DateTimePickerHire.Enabled = False
                    DateTimePickerStart.Enabled = False
                    ButtonUpload.Enabled = False
                    TextBoxCitizenship.Enabled = False
                    TextBoxReligion.Enabled = False
                    TextBoxElem.Enabled = False
                    TextBoxElemYear.Enabled = False
                    TextBoxHighschool.Enabled = False
                    TextBoxHighYear.Enabled = False
                    TextBoxCollege.Enabled = False
                    TextBoxCollegeYear.Enabled = False
                    TextBoxClientRate.Enabled = False
                    TextBoxWorkDay.Enabled = False
                    TextBoxHourDay.Enabled = False
                    ButtonEdit.Enabled = False
                    ButtonRemove.Enabled = False
                    ComboBoxGender.SelectedIndex = -1
                    ComboBoxDept.SelectedIndex = -1
                    ComboBoxJobTitle.SelectedIndex = -1
                    ComboBoxStatus.SelectedIndex = -1
                    Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
                    fillGrid(command)
                Else
                    MsgBox("Error Employee Not DELETED", MsgBoxStyle.Critical, "Delete Employee")
                End If
            End If
        Catch ex As Exception
            MsgBox("Please Select Employee", MsgBoxStyle.Critical, "Delete Employee")
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Add_Employee.ShowDialog()
        Dim namess As String = TextBoxuseername.Text
        Dim action As String = "ADD"
        Dim desc As String = TextBoxActName.Text
        Dim tim As String = DateTime.Now.ToLongDateString
        If emp.InserActivity(namess, action, desc, tim) Then
        Else
            MsgBox("error", MsgBoxStyle.Information, "Error")
        End If
        Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
        fillGrid(command)
    End Sub
    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
    End Sub
    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
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

    Private Sub TextBoxAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxAddress.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back, Keys.Up, Keys.Down
            Case Else : e.SuppressKeyPress = True
        End Select
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
            PictureBoxEmp.Image = Image.FromFile(opimage.FileName)
        End If
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxEmpID.Clear()
        TextBoxName.Clear()
        TextBoxAddress.Clear()
        TextBoxPhone.Clear()
        TextBoxEmail.Clear()
        TextBoxJobClass.Clear()
        TextBoxName.Enabled = False
        TextBoxAddress.Enabled = False
        TextBoxPhone.Enabled = False
        TextBoxEmail.Enabled = False
        ComboBoxStatus.Enabled = False
        ComboBoxDept.Enabled = False
        ComboBoxGender.Enabled = False
        TextBoxJobClass.Enabled = False
        ComboBoxJobTitle.Enabled = False
        DateTimePickerBirth.Enabled = False
        DateTimePickerHire.Enabled = False
        DateTimePickerStart.Enabled = False
        ButtonUpload.Enabled = False
        TextBoxWorkDay.Enabled = False
        TextBoxHourDay.Enabled = False
        ButtonEdit.Enabled = False
        ButtonRemove.Enabled = False

        ComboBoxGender.SelectedIndex = -1
        ComboBoxDept.SelectedIndex = -1
        ComboBoxJobTitle.SelectedIndex = -1
        ComboBoxStatus.SelectedIndex = -1
    End Sub
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim emp As New EmployeeDB
        Dim empID As String = TextBoxEmpID.Text
        Dim name As String = TextBoxName.Text
        Dim addr As String = TextBoxAddress.Text
        Dim phone As String = TextBoxPhone.Text
        Dim email As String = TextBoxEmail.Text
        Dim hrdate As Date = DateTimePickerHire.Value.Date
        Dim gender As String = ComboBoxGender.Text
        Dim status As String = ComboBoxStatus.Text
        Dim dob As Date = DateTimePickerBirth.Value.Date
        Dim jobt As String = ComboBoxJobTitle.Text
        Dim stdate As Date = DateTimePickerStart.Value.Date
        Dim client As String = TextBoxClientRate.Text
        Dim jobclass As String = TextBoxJobClass.Text
        Dim depart As String = ComboBoxDept.Text
        Dim citi As String = TextBoxCitizenship.Text
        Dim reli As String = TextBoxReligion.Text
        Dim age As String = TextBoxAge.Text
        Dim elem As String = TextBoxElem.Text
        Dim high As String = TextBoxHighschool.Text
        Dim col As String = TextBoxCollege.Text
        Dim elemyear As Integer = TextBoxElemYear.Text
        Dim highyear As Integer = TextBoxHighYear.Text
        Dim collyear As Integer = TextBoxCollegeYear.Text

        Dim pic As New MemoryStream
        Dim hire_date As Date = DateTimePickerHire.Value
        Dim start_date As Date = DateTimePickerStart.Value
        Dim born_year As Integer = DateTimePickerBirth.Value.Year
        Dim this_year As Integer = Date.Now.Year
        Dim now_date As Date = Date.Now
        If this_year - born_year < 15 Or this_year - born_year > 100 Or hire_date > now_date Or start_date > now_date Then
            MsgBox("Enter the Date Correctly", MsgBoxStyle.Information, "Date Error")
        Else


            If verf() Then
                PictureBoxEmp.Image.Save(pic, PictureBoxEmp.Image.RawFormat)
                If emp.UpdateEmployee(empID, pic, name, addr, phone, email, status, hrdate, gender, dob, jobt, stdate, jobclass, depart, client, citi, reli, age, elem, high, col, elemyear, highyear, collyear) Then
                    MsgBox("Employee Information Updated", MsgBoxStyle.Information, "Edit Employee")
                    Dim namess As String = TextBoxuseername.Text
                    Dim action As String = "Edit"
                    Dim desc As String = TextBoxName.Text
                    Dim tim As String = DateTime.Now.ToLongDateString
                    If emp.InserActivity(namess, action, desc, tim) Then
                    Else
                        MsgBox("error", MsgBoxStyle.Information, "Error")
                    End If
                    Dim command As New MySqlCommand("SELECT `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay` FROM `employee` ORDER BY Name")
                    fillGrid(command)

                Else
                    MsgBox("Error Employee Update", MsgBoxStyle.Critical, "Edit Employee")
                End If
            Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Employee")
            End If
        End If
    End Sub
    Function verf() As Boolean
        If TextBoxName.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Or TextBoxPhone.Text.Trim() = "" Or
             TextBoxJobClass.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub TextBoxCitizenship_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCitizenship.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxReligion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxReligion.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxElem_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxElem.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxHighschool_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxHighschool.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub TextBoxCollege_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCollege.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back
            Case Else : e.SuppressKeyPress = True
        End Select
    End Sub
    Private Sub TextBoxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAge.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxClientRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxClientRate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxElemYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxElemYear.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHighYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHighYear.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCollegeYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCollegeYear.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'payroll
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenListStaff.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As Integer
        Dim deduc As Integer
        Dim tax As Integer
        Dim phil As Integer
        Dim s As Integer
        Dim net As Integer
        ans = ((TextBoxPayHour.Text * TextBoxPayWork.Text) * (TextBoxPayrate.Text))
        TextBoxGross.Text = ans
        TextBoxSalary.Text = ans

        tax = ans * 0.15
        TextBoxWage.Text = tax
        phil = ans * 0.05
        TextBoxPhil.Text = phil
        s = ans * 0.02
        TextBoxSSS.Text = s
        deduc = tax + phil + s
        TextBoxDeduction.Text = deduc
        TextBoxDeduct.Text = deduc

        net = TextBoxSalary.Text - TextBoxDeduct.Text
        TextBoxNetSalary.Text = net
        Dim empid As String = TextBoxPayID.Text
        Dim names As String = TextBoxPayName.Text
        Dim gross As String = TextBoxGross.Text
        Dim deduct As String = TextBoxDeduct.Text
        Dim nets As String = TextBoxNetSalary.Text
        If emp.InsertPayroll(empid, names, gross, deduct, nets) Then
            MsgBox("NetSalary has been saved", MsgBoxStyle.Information, "Saved")
            Dim namess As String = TextBoxuseername.Text
            Dim action As String = "Added Salary"
            Dim desc As String = TextBoxPayName.Text
            Dim tim As String = DateTime.Now.ToLongDateString
            If emp.InserActivity(namess, action, desc, tim) Then
            Else
                MsgBox("error", MsgBoxStyle.Information, "Error")
            End If



        Else
            MsgBox("Error", MsgBoxStyle.Critical, "Add User")
        End If

    End Sub
    'end payroll

    'Leave
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        OpenLeaveStaff.ShowDialog()
    End Sub

    Private Sub rdowithPay_CheckedChanged(sender As Object, e As EventArgs) Handles rdowithPay.CheckedChanged
        If rdowithPay.Checked = True Then
            nub = "With Pay"
            rdoWithoutPay.Checked = False
        End If
    End Sub

    Private Sub rdoWithoutPay_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWithoutPay.CheckedChanged
        If rdoWithoutPay.Checked = True Then
            nub = "Without Pay"
            rdowithPay.Checked = False
        End If
    End Sub

    Private Sub rdoSick_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSick.CheckedChanged
        If rdoSick.Checked = True Then
            rdoPaternity.Checked = False
            rdoFuneral.Checked = False
            rdoMaternity.Checked = False
            rdoVacation.Checked = False
            rdoAcidentOnDuty.Checked = False
            bin = "Sick"
        End If
    End Sub

    Private Sub rdoPaternity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPaternity.CheckedChanged
        If rdoPaternity.Checked = True Then
            rdoSick.Checked = False
            rdoFuneral.Checked = False
            rdoMaternity.Checked = False
            rdoVacation.Checked = False
            rdoAcidentOnDuty.Checked = False
            bin = "Paternity"
        End If
    End Sub

    Private Sub rdoVacation_CheckedChanged(sender As Object, e As EventArgs) Handles rdoVacation.CheckedChanged
        If rdoVacation.Checked = True Then
            rdoPaternity.Checked = False
            rdoFuneral.Checked = False
            rdoMaternity.Checked = False
            rdoSick.Checked = False
            rdoAcidentOnDuty.Checked = False
            bin = "Vacation"
        End If
    End Sub

    Private Sub rdoMaternity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMaternity.CheckedChanged
        If rdoMaternity.Checked = True Then
            rdoPaternity.Checked = False
            rdoFuneral.Checked = False
            rdoSick.Checked = False
            rdoVacation.Checked = False
            rdoAcidentOnDuty.Checked = False
            bin = "Maternity"
        End If
    End Sub

    Private Sub rdoFuneral_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFuneral.CheckedChanged
        If rdoFuneral.Checked = True Then
            rdoPaternity.Checked = False
            rdoSick.Checked = False
            rdoMaternity.Checked = False
            rdoVacation.Checked = False
            rdoAcidentOnDuty.Checked = False
            bin = "Funeral"
        End If
    End Sub

    Private Sub rdoAcidentOnDuty_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAcidentOnDuty.CheckedChanged
        If rdoSick.Checked = True Then
            rdoPaternity.Checked = False
            rdoFuneral.Checked = False
            rdoMaternity.Checked = False
            rdoVacation.Checked = False
            rdoSick.Checked = False
            bin = "Accident On Duty"
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim emps As String = TextBoxLeaveId.Text
        Dim numes As String = TextBoxLeaveName.Text
        Dim timefr As String = dtpTimeFrom.Value
        Dim timeto As String = dtpTimeTo.Value
        Dim desc As String = txtreasons.Text
        If verf1() Then
            If emp.InsertLeave(emps, numes, nub, bin, timefr, timeto, desc) Then
                MsgBox("Leave has been saved", MsgBoxStyle.Information, "Saved")
                Dim namess As String = TextBoxuseername.Text
                Dim action As String = "Added Leave"
                Dim descs As String = TextBoxLeaveName.Text
                Dim tim As String = DateTime.Now.ToLongDateString
                If emp.InserActivity(namess, action, desc, tim) Then
                Else
                    MsgBox("error", MsgBoxStyle.Information, "Error")
                End If



            Else
                MsgBox("Error", MsgBoxStyle.Critical, "saved")
            End If
        Else
            MsgBox("Other reason cannot be null", MsgBoxStyle.Information, "Error")
        End If


    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        frmLeaveAbsence.ShowDialog()
    End Sub
    Function verf1() As Boolean
        If txtreasons.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

End Class