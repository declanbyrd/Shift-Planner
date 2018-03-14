Public Class AdminDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginRegister.Show()
        Me.Close()
    End Sub

    Private Sub bntAccHol_Click(sender As Object, e As EventArgs) Handles bntAccHol.Click
        Me.Hide()
        frmViewHol.Show()
    End Sub
End Class