Public Class overtime_list

    Public sqlQuery As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Overtime_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        'txtEmployeeID.Text = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        sqlQuery = "SELECT overtimeDate, overtimePay FROM OVERTIME"

        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()


        'For Each row In ds.Tables("tblOvertime")
        'ListBox1.Items.Add(New ListItem(ds.Tables("tblOvertime").Rows(row).Item("overtimeDate"), ds.Tables("tblOvertime").Rows(row).Item("overtimePay")))
        'Next
    End Sub
End Class