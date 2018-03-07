Public Class overtime_list
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Overtime_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployeeID.Text = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
    End Sub
End Class