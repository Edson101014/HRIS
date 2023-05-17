Imports MySql.Data.MySqlClient
Imports System.IO
Public Class EmployeeDB
    Dim dbs As New db
    Public Function InsertEmployee(ByVal empID As String, ByVal picture As MemoryStream, ByVal name As String, ByVal adr As String, ByVal phone As String, ByVal email As String, ByVal status As String, ByVal hrdate As Date, ByVal gender As String, ByVal dob As Date, ByVal jobt As String, ByVal stdate As Date, ByVal jobclass As String, ByVal depart As String, ByVal clientrate As String, ByVal citizen As String, ByVal religion As String, ByVal age As String, ByVal elem As String, ByVal high As String, ByVal coll As String, ByVal elemyear As String, ByVal highyear As String, ByVal collyear As String, ByVal hourday As String, ByVal work As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `employee`( `Employee_ID`, `Picture`, `Name`, `Address`, `phone`, `email`, `hiredate`, `Status`, `gender`, `dateofbirth`, `jobtitle`, `startdate`, `ClientRate`, `jobclass`, `Department`, `Citizenship`, `Religion`, `Age`, `Elementary`, `Highschool`, `College`, `ElemYear`, `HighYear`, `CollegeYear`,`HourPerDay`,`WorkDay`) VALUES (@eID,@pic,@nme,@add,@phne,@mail,@hdate,@gend,@stat,@dobirth,@jobtitle,@sdate,@clientR,@jclass,@dep,@citizen,@reli,@age,@elem,@high,@col,@elyear,@hiyear,@colyear,@hour,@workday)", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@clientR,@jclass,@dep,@citizen,@reli,@age,@elem,@high,@col,@elyear,@hiyear,@colyear
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@nme", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = adr
        command.Parameters.Add("@phne", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@hdate", MySqlDbType.DateTime).Value = hrdate
        command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status
        command.Parameters.Add("@dobirth", MySqlDbType.DateTime).Value = dob
        command.Parameters.Add("@jobtitle", MySqlDbType.VarChar).Value = jobt
        command.Parameters.Add("@sdate", MySqlDbType.DateTime).Value = stdate
        command.Parameters.Add("@clientR", MySqlDbType.VarChar).Value = clientrate
        command.Parameters.Add("@jclass", MySqlDbType.VarChar).Value = jobclass
        command.Parameters.Add("@dep", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = citizen
        command.Parameters.Add("@reli", MySqlDbType.VarChar).Value = religion
        command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age
        command.Parameters.Add("@elem", MySqlDbType.VarChar).Value = elem
        command.Parameters.Add("@high", MySqlDbType.VarChar).Value = high
        command.Parameters.Add("@col", MySqlDbType.VarChar).Value = coll
        command.Parameters.Add("@elyear", MySqlDbType.VarChar).Value = elemyear
        command.Parameters.Add("@colyear", MySqlDbType.VarChar).Value = collyear
        command.Parameters.Add("@hiyear", MySqlDbType.VarChar).Value = highyear
        command.Parameters.Add("@hour", MySqlDbType.VarChar).Value = hourday
        command.Parameters.Add("@workday", MySqlDbType.VarChar).Value = work
        command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray

        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
    Function getemployee(ByVal command As MySqlCommand) As DataTable

        command.Connection = dbs.getconn()
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table
    End Function
    Public Function deleteEmp(ByVal id As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `employee` WHERE Employee_ID = @empID", dbs.getconn())
        command.Parameters.Add("@empID", MySqlDbType.Int32).Value = id


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()

    End Function
    Public Function UpdateEmployee(ByVal empID As String, ByVal picture As MemoryStream, ByVal name As String, ByVal adr As String, ByVal phone As String, ByVal email As String, ByVal status As String, ByVal hrdate As Date, ByVal gender As String, ByVal dob As Date, ByVal jobt As String, ByVal stdate As Date, ByVal jobclass As String, ByVal depart As String, ByVal clientrate As String, ByVal citizen As String, ByVal religion As String, ByVal age As String, ByVal elem As String, ByVal high As String, ByVal coll As String, ByVal elemyear As String, ByVal highyear As String, ByVal collyear As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `employee` SET `Employee_ID`=@empIDs, `Picture`=@pic,`Name`=@nme,`Address`=@add,`phone`=@phne,`email`=@mail,`hiredate`=@hdate,`gender`=@gend,`status`=@stat,`dateofbirth`=@dobirth,`jobtitle`=@jobtitle,`startdate`=@sdate,`ClientRate`=@clientR,`jobclass`=@jclass,`Department`=@dep,`Citizenship`=@citizen,`Religion`=@reli,`Age`=@age,`Elementary`=@elem,`Highschool`=@high,`College`=@coll,`ElemYear`=@elyear,`HighYear`=@hiyear,`CollegeYear`=@colyear WHERE Employee_ID=@empIDs", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@jclass,@p,@dep,@pic



        command.Parameters.Add("@empIDs", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@nme", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = adr
        command.Parameters.Add("@phne", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@hdate", MySqlDbType.DateTime).Value = hrdate
        command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status
        command.Parameters.Add("@dobirth", MySqlDbType.DateTime).Value = dob
        command.Parameters.Add("@jobtitle", MySqlDbType.VarChar).Value = jobt
        command.Parameters.Add("@sdate", MySqlDbType.DateTime).Value = stdate
        command.Parameters.Add("@clientR", MySqlDbType.VarChar).Value = clientrate
        command.Parameters.Add("@jclass", MySqlDbType.VarChar).Value = jobclass
        command.Parameters.Add("@dep", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = citizen
        command.Parameters.Add("@reli", MySqlDbType.VarChar).Value = religion
        command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age
        command.Parameters.Add("@elem", MySqlDbType.VarChar).Value = elem
        command.Parameters.Add("@high", MySqlDbType.VarChar).Value = high
        command.Parameters.Add("@coll", MySqlDbType.VarChar).Value = coll
        command.Parameters.Add("@elyear", MySqlDbType.VarChar).Value = elemyear
        command.Parameters.Add("@colyear", MySqlDbType.VarChar).Value = collyear
        command.Parameters.Add("@hiyear", MySqlDbType.VarChar).Value = highyear
        command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray

        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()

    End Function
    Public Function deleteUSER(ByVal USERNAME As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `info` WHERE UserID = @empID", dbs.getconn())
        command.Parameters.Add("@empID", MySqlDbType.VarChar).Value = USERNAME


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()

    End Function
    Public Function Insertuser(ByVal userids As String, ByVal name As String, ByVal USER As String, ByVal pass As String, ByVal auth As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `INFO`(`UserID`,`Name`,`USERNAME`,`PASSWORD`, `AUTH_LEVEL`) VALUES (@useID,@nmes,@eID,@nme,@add)", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@jclass,@p,@dep,@pic
        command.Parameters.Add("@useID", MySqlDbType.VarChar).Value = userids
        command.Parameters.Add("@nmes", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = USER
        command.Parameters.Add("@nme", MySqlDbType.VarChar).Value = pass
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = auth


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
    Public Function UpdateUser(ByVal userID As String, ByVal name As String, ByVal user As String, ByVal pass As String, ByVal auth As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `info` SET `UserID`=@userIDs,`Name`=@nmes,`USERNAME`=@nme,`PASSWORD`=@add,`AUTH_LEVEL`=@auths WHERE UserID=@userIDs", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@jclass,@p,@dep,@pic
        command.Parameters.Add("@userIDs", MySqlDbType.VarChar).Value = userID
        command.Parameters.Add("@nmes", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@nme", MySqlDbType.VarChar).Value = user
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = pass
        command.Parameters.Add("@auths", MySqlDbType.VarChar).Value = auth
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
    Public Function InsertPayroll(ByVal PayID As String, ByVal names As String, ByVal gross As String, ByVal deduct As String, ByVal Netsalary As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `payroll`(`Employee_ID`,`Name`,`GrossSalary`,`Deduction`, `NetSalary`) VALUES (@payid,@payname,@paygross,@paydeduct,@paynet)", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@jclass,@p,@dep,@pic
        command.Parameters.Add("@payID", MySqlDbType.VarChar).Value = PayID
        command.Parameters.Add("@payname", MySqlDbType.VarChar).Value = names
        command.Parameters.Add("@paygross", MySqlDbType.VarChar).Value = gross
        command.Parameters.Add("@paydeduct", MySqlDbType.VarChar).Value = deduct
        command.Parameters.Add("@paynet", MySqlDbType.VarChar).Value = Netsalary


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
    Public Function InsertLeave(ByVal ems As String, ByVal numes As String, ByVal statis As String, ByVal reas As String, ByVal timfr As String, ByVal timeto As String, ByVal desc As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `leavesystem`(`Employee_ID`, `Name`, `Status`, `Reason`, `Time From`,  `Time To`, `Other Reason`) VALUES (@eid,@nms,@stu,@reas,@timefrom,@timeto,@other)", dbs.getconn())
        '@empid @nme,@add,@phne,@mail,@hdate,@gend,@dobirth,@jobtitle,@sdate,@jclass,@p,@dep,@pic
        command.Parameters.Add("@eid", MySqlDbType.VarChar).Value = ems
        command.Parameters.Add("@nms", MySqlDbType.VarChar).Value = numes
        command.Parameters.Add("@stu", MySqlDbType.VarChar).Value = statis
        command.Parameters.Add("@reas", MySqlDbType.VarChar).Value = reas
        command.Parameters.Add("@timefrom", MySqlDbType.VarChar).Value = timfr
        command.Parameters.Add("@timeto", MySqlDbType.VarChar).Value = timeto
        command.Parameters.Add("@other", MySqlDbType.VarChar).Value = desc


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
    Public Function InserActivity(ByVal namess As String, ByVal action As String, ByVal des As String, ByVal time As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `activitylog`( `Name`, `Action`, `Description`, `Time`) VALUES (@actName,@act,@actdes,@time)", dbs.getconn)
        command.Parameters.Add("@actName", MySqlDbType.VarChar).Value = namess
        command.Parameters.Add("@act", MySqlDbType.VarChar).Value = action
        command.Parameters.Add("@actdes", MySqlDbType.VarChar).Value = des
        command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function
End Class
