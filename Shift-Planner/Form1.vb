Public Class Form1
    Private Sub btnLoginForm_Click(sender As Object, e As EventArgs) Handles btnLoginForm.Click
        LoginRegister.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub
End Class
