Public Class AdminDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginRegister.Show()
        Me.Close()
    End Sub

    Private Sub bntAccHol_Click(sender As Object, e As EventArgs) Handles bntAccHol.Click
        Me.Hide()
        frmViewHol.Show()
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Me.Hide()
        frmNewEmp.Show()
    End Sub

    Private Sub btnAddOT_Click(sender As Object, e As EventArgs) Handles btnAddOT.Click
        Me.Hide()
        frmAddOT.Show()
    End Sub
End Class