Imports System.Text.RegularExpressions

Public Class PasswordChange
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If firstLogin Then
            'user doesn't need to enter current password if it is their first login
            txtCurrentPass.Enabled = False
            txtCurrentPass.Text = "changeme"
        End If
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        'holds the current password
        Dim currentPassword As String = txtCurrentPass.Text
        'Holds the new password
        Dim newPassword As String = txtNewPass.Text
        Dim confirmPassword As String = txtConfirmPass.Text
        'Regex to ensure that the password entered follos specific rules
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
        Dim matchCap As Boolean = Regex.IsMatch(newPassword, patternCap)
        Dim matchNum As Boolean = Regex.IsMatch(newPassword, patternNum)

        'SQL to select information on an employee where the employee If and password is the one that they have entered
        sql = "SELECT * FROM EMPLOYEE WHERE employeeID = " & currentEmployeeID & " AND password = '" & currentPassword & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblCorrectLogin")

        'Checks to see if the new password is the same as the old password
        If ds.Tables("tblCorrectLogin").Rows.Count < 1 Then
            MsgBox("Current password incorrect, try again")
            'checks to see if the password is between 6 and 16 characters
        ElseIf newPassword.Length < 6 Or newPassword.Length > 16 Then
            MsgBox("Enter a password between 6 and 16 characters long.")
            'Checks to see that the password contains at least one capital letter
        ElseIf Not matchCap Then
            MsgBox("Enter a password which contains at least one capital letter.")
            'Checks to see that the password contians at least 1 number
        ElseIf Not matchNum Then
            MsgBox("Enter a password which contains at least one number.")
            'Checks to see if the password and confirm password match
        ElseIf Not (newPassword = confirmPassword) Then
            MsgBox("Passwords do not match")
        Else
            'If the password is of the correct format then the password will be updated in the database
            sql = "UPDATE [EMPLOYEE] SET [password] = '" & newPassword & "' WHERE [employeeID] = " & currentEmployeeID & ""
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "EMPLOYEE")
            firstLogin = False

            MessageBox.Show("Password Changed Successfully!")

            If currentAdmin Then
                AdminDashboard.Enabled = True
                Me.Close()
            Else
                EmployeeDashboard.Enabled = True
                Me.Close()
            End If
        End If
    End Sub
End Class