Public Class frmNewEmp
    Private Sub BtnNewEmp_Click(sender As Object, e As EventArgs) Handles btnNewEmp.Click

        'Puts the inputted data from the text boxes into variables
        Dim fName As String = txtFName.Text
        Dim sName As String = txtSName.Text
        Dim tempPwd As String = txtPass.Text

        NewEmployee(fName, sName, tempPwd)
    End Sub

    Public Shared Function NewEmployee(fName, sName, tempPwd)

        Dim success As Boolean = False

        'Inserts the details of the employees into the EMPLOYEE table
        sql = "INSERT INTO [EMPLOYEE] ([FName], [SName], [password]) VALUES ("
        sql &= "'" & fName & "',"
        sql &= "'" & sName & "',"
        sql &= "'" & tempPwd & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "newEmployee")
        con.Close()

        'Retrieves the password and employee ID of that user
        sql = "SELECT EmployeeId FROM EMPLOYEE where FName = '" & fName & "' and SName = '" & sName & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "newEmployeeID")
        con.Close()

        MessageBox.Show("New employee successfully added to the database. Employee ID : " & ds.Tables("newEmployeeID").Rows(0).Item("employeeID") & " Password: " & tempPwd)
        success = True
        Return success
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub
End Class