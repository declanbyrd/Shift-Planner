Public Class frmHoliday
    Private Sub frmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim employeeID As Integer

        'Gets the employee ID of the user that is currently logged on

        employeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")

        txtEmployeeID.Text = employeeID

        'SQL statement that gets the information on pending holidays
        sql = "SELECT timeOffStartDate, timeOffEndDate, timeOffReason FROM TIMEOFF where employeeID = " & employeeID & " and approved = no"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblPendHol")

        'Loops through all of the values in the 'Pending Holiday' dataset and inserts them into a list box
        'So the employee can see which holiday hasn't been accepted yet
        For i = 0 To ds.Tables("tblPendHol").Rows.Count - 1
            lstBoxPendHol.Items.Add("Reason: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffReason") + " Start Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffStartDate") + " End Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffEndDate"))
        Next

        'SQL statement that gets the information on pending holidays
        sql = "SELECT timeOffStartDate, timeOffEndDate, timeOffReason FROM TIMEOFF where employeeID = " & employeeID & " and approved = yes"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAccHol")

        'Loops through all of the values in the 'Accepted Holiday' dataset and inserts them into a list box
        'So the employee can see which holiday has been accepted 
        For i = 0 To ds.Tables("tblAccHol").Rows.Count - 1
            lstBoxAccHoll.Items.Add("Reason: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffReason") + " Start Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffStartDate") + " End Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffEndDate"))
        Next
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