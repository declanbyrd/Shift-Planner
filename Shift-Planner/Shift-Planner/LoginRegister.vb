Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtRUser.Text
        Dim password As String = txtRPass.Text
        Dim refCode As String = txtRefCode.Text
        Dim patternCap As String = "[A-Za-z0-9]*[A-Z]+[A-Za-z0-9]*"
        Dim patternNum As String = "[A-Za-z0-9]*[0-9]+[A-Za-z0-9]*"
        Dim matchCap As Boolean = Regex.IsMatch(password, patternCap)
        Dim matchNum As Boolean = Regex.IsMatch(password, patternNum)

        If username.Length < 6 Or username.Length > 16 Then
            MsgBox("Enter a username between 6 and 16 characters long.")
        ElseIf password.Length < 6 Or password.Length > 16 Then
            MsgBox("Enter a password between 6 and 16 characters long.")
        ElseIf Not matchCap Then
            MsgBox("Enter a password which contains at least one capital letter.")
        ElseIf Not matchNum Then
            MsgBox("Enter a password which contains at least one number.")
        Else
            'link to database and check that the refCode is valid
        End If
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim username As String = txtLUser.Text
        Dim password As String = txtLPass.Text

        'link to database and check that the username and password are correct
    End Sub
End Class