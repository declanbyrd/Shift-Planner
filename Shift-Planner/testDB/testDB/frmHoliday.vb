Public Class frmHoliday
    Private Sub frmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'gets the employeeID of the user that is logged on
        txtEmployeeID.Text = ds.Tables("tblLogOn").Rows(0).Item("employeeID")




    End Sub

    Private Sub btnAddTimeOff_Click(sender As Object, e As EventArgs) Handles btnAddTimeOff.Click



        sql = "INSERT INTO tblTimeOff (employeeID, timeOffStartDate, timeOffEndDate, timeOffReason) VALUES ("
        sql &= "'" & txtEmployeeID.Text & "',"
        sql &= "'" & dtStart.Value & "',"
        sql &= "'" & dtEnd.Value & "',"
        sql &= "'" & txtReason.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddHoliday")
        con.Close()

        MessageBox.Show("Holiday has been sent for approval")

    End Sub
End Class