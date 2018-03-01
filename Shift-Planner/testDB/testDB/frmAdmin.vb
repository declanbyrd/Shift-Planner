Public Class frmAdmin
    Private Sub btnAddDB_Click(sender As Object, e As EventArgs) Handles btnAddDB.Click

        'adds new user to the database

        ' sql = "INSERT INTO tblEmployee (password ,fName, sName) VALUES ("
        sql = "INSERT INTO EMPLOYEE (fName, sName) VALUES ("
        ' sql &= "'" & txtPassword.Text & "',"
        sql &= "'" & txtFName.Text & "',"
        sql &= "'" & txtSName.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblNewEmployee")
        con.Close()

        MessageBox.Show("New employee has been added to the database.")
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class