Public Class frmAdmin
    Private Sub btnAddDB_Click(sender As Object, e As EventArgs) Handles btnAddDB.Click

        sql = "INSERT INTO tblEmployee (fName, sName) VALUES ("
        sql &= "'" & txtFName.Text & "',"
        sql &= "'" & txtSName.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblNewEmployee")
        con.Close()

        MessageBox.Show("New employee has been added to the database.")
    End Sub
End Class