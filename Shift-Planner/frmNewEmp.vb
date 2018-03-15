Public Class frmNewEmp
    Private Sub btnNewEmp_Click(sender As Object, e As EventArgs) Handles btnNewEmp.Click

        sql = "INSERT INTO [EMPLOYEE] ([FName], [SName], [password]) VALUES ("
        sql &= "'" & txtFName.Text & "',"
        sql &= "'" & txtSName.Text & "',"
        sql &= "'" & txtPass.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "newEmployee")
        con.Close()

        sql = "SELECT EmployeeId FROM EMPLOYEE where FName = '" & txtFName.Text & "' and SName = '" & txtSName.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "newEmployeeID")
        con.Close()

        MessageBox.Show("New employee successfully added to the database. Employee ID : " & ds.Tables("newEmployeeID").Rows(0).Item("employeeID") & " Password: " & txtPass.Text)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub
End Class