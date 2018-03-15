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
        l.Show()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM SHIFT where employeeID = " & currentEmployeeID

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblShift")
        con.Close()
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        Me.Hide()
        btnDash.Show()
    End Sub
End Class