Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'this code should be run only when the user attempts to login for the first time
        Dim username As String = txtRUser.Text
        Dim password As String = txtRPass.Text
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
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
        Dim username As String = txtLUser.Text
        Dim password As String = txtLPass.Text

        'link to database and check that the username and password are correct
        'if first login then enable register box and disable login box
    End Sub
End Class