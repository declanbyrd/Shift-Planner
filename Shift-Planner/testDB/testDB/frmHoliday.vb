Public Class frmHoliday
    Private Sub frmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Gets the employee ID of the user that is currently logged on
        txtEmployeeID.Text = ds.Tables("tblLogOn").Rows(0).Item("employeeID")




    End Sub

    Private Sub btnAddTimeOff_Click(sender As Object, e As EventArgs) Handles btnAddTimeOff.Click

        'Creates a new holiday request

        sql = "INSERT INTO TIMEOFF (employeeID, timeOffStartDate, timeOffEndDate, timeOffReason) VALUES ("
        sql &= "'" & txtEmployeeID.Text & "',"
        sql &= "'" & dtStart.Value & "',"
        sql &= "'" & dtEnd.Value & "',"
        sql &= "'" & txtReason.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddHoliday")
        con.Close()

        MessageBox.Show("Holiday has been sent for approval")

    End Sub

    Private Sub lstBoxPendHol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxPendHol.SelectedIndexChanged

    End Sub

    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged

    End Sub
End Class