

Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'this code should be run only when the user attempts to login for the first time
        Dim username As String = txtRUser.Text
        Dim password As String = txtRPass.Text
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
        Dim regex As Regex
        Dim matchCap As Boolean = Regex.IsMatch(password, patternCap)
        Dim matchNum As Boolean = Regex.IsMatch(password, patternNum)

        If password.Length < 6 Or password.Length > 16 Then
            MsgBox("Enter a password between 6 and 16 characters long.")
        ElseIf Not matchCap Then
            MsgBox("Enter a password which contains at least one capital letter.")
        ElseIf Not matchNum Then
            MsgBox("Enter a password which contains at least one number.")
        Else
            'check username is in the database
            'this should be the first check
            'change password in db
            'close form and open dashboard
        End If
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim employeeID As Integer = CUInt(txtLUser.Text)
        Dim password As String = txtLPass.Text

        sql = "SELECT employeeID, password, admin FROM EMPLOYEE WHERE employeeID = " & employeeID & " and password = '" + password + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblLogOn")

        'Checks to see if there is an employee with that username and password
        If ds.Tables("tblLogOn").Rows.Count > 0 Then
            'Checks to see whether the user is an admin or employee.
            'If admin, then the admin form will load, if not, then the employee form will load.
            If ds.Tables("tblLogOn").Rows(0).Item("admin") = True Then
                MessageBox.Show("Log on successful as admin.")
                AdminDashboard.Show()
                Me.Close()
            Else
                MessageBox.Show("Log on successful as employee.")
                EmployeeDashboard.Show()
                Me.Close()

            End If

        Else
            MessageBox.Show("Incorrect username and/or password, try again.")

        End If

        con.Close()
        ds.Clear()
    End Sub
End Class