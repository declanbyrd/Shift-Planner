Imports System.Text.RegularExpressions

Public Class PasswordChange
    Dim bypass As Boolean
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If firstLogin Then
            txtCurrentPass.Enabled = False
            bypass = True
        End If
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim currentPassword As String = txtCurrentPass.Text
        Dim newPassword As String = txtNewPass.Text
        Dim confirmPassword As String = txtConfirmPass.Text
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
        Dim matchCap As Boolean = Regex.IsMatch(newPassword, patternCap)
        Dim matchNum As Boolean = Regex.IsMatch(newPassword, patternNum)
        Dim correctPass As Boolean = True

        If Not bypass Then
            sql = "SELECT password FROM EMPLOYEE WHERE employeeID = " & currentEmployeeID & " AND password = '" & currentPassword & "'"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "tblPass")

            If ds.Tables("tblPass").Rows.Count < 1 Then
                correctPass = False
            End If

            ds.Clear()
        End If

        If Not correctPass Then
            MsgBox("Current password is incorrect, try again.")
        ElseIf newPassword.Length < 6 Or newPassword.Length > 16 Then
            MsgBox("Enter a password between 6 and 16 characters long.")
        ElseIf Not matchCap Then
            MsgBox("Enter a password which contains at least one capital letter.")
        ElseIf Not matchNum Then
            MsgBox("Enter a password which contains at least one number.")
        ElseIf Not (newPassword = confirmPassword) Then
            MsgBox("Passwords do not match")
        Else
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