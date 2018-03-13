Imports System.Text.RegularExpressions

Public Class PasswordChange
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim currentPassword As String = txtCurrentPass.Text
        Dim newPassword As String = txtNewPass.Text
        Dim confirmPassword As String = txtConfirmPass.Text
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
        Dim matchCap As Boolean = Regex.IsMatch(newPassword, patternCap)
        Dim matchNum As Boolean = Regex.IsMatch(newPassword, patternNum)

        If newPassword.Length < 6 Or newPassword.Length > 16 Then
            MsgBox("Enter a password between 6 and 16 characters long.")
        ElseIf Not matchCap Then
            MsgBox("Enter a password which contains at least one capital letter.")
        ElseIf Not matchNum Then
            MsgBox("Enter a password which contains at least one number.")
        ElseIf Not (newPassword = confirmPassword) Then
            MsgBox("Passwords do not match")
        Else
            'check username is in the database
            'this should be the first check
            'changed password in db
            'close form
            're-enable dashboard
        End If
    End Sub
End Class