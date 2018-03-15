' Holiday class - this form allows employees to
' apply for time off and see any pending and
' aproved time off.
Public Class Holiday
    ' Form load function, will connect to the database,
    ' take the employeeID of the currently logged in
    ' employee and store it in a variable. Will then
    ' populate 2 list boxes with timeoff data from the db
    ' for that particular employee.
    Dim employeeID As Integer
    Private Sub Holiday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Gets the employee ID of the user that Is currently logged on

        'employeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
        employeeID = currentEmployeeID


        txtEmployeeID.Text = employeeID

        'SQL statement that gets the information on pending holidays
        sql = "SELECT timeOffStartDate, timeOffEndDate, timeOffReason FROM TIMEOFF where employeeID = " & employeeID & " and approved = no"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblPendHol")

        'populate listbox with pending timeoff data
        For i = 0 To ds.Tables("tblPendHol").Rows.Count - 1
            lstBoxPendHol.Items.Add("Reason: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffReason") + "     Start Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffStartDate") + "     End Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffEndDate"))
        Next

        'SQL statement that gets the information on pending holidays
        sql = "SELECT timeOffStartDate, timeOffEndDate, timeOffReason FROM TIMEOFF where employeeID = " & employeeID & " and approved = yes"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAccHol")

        'populate listbox with accepted timeoff data
        For i = 0 To ds.Tables("tblAccHol").Rows.Count - 1
            lstBoxAccHoll.Items.Add("Reason: " + ds.Tables("tblAccHol").Rows(i).Item("timeOffReason") + "     Start Date: " + ds.Tables("tblAccHol").Rows(i).Item("timeOffStartDate") + "     End Date: " + ds.Tables("tblAccHol").Rows(i).Item("timeOffEndDate"))
        Next
    End Sub

    ' Contains new time off request forms which allows
    ' employees to send timeoff requests for admins to review
    ' Data will be taken from inputs and be sent to the db
    ' upon clicking "Apply"
    Private Sub btnAddTimeOff_Click(sender As Object, e As EventArgs) Handles btnAddTimeOff.Click

        ds.Clear()
        lstBoxPendHol.Items.Clear()

        'Creates a new holiday request

        sql = "INSERT INTO TIMEOFF (employeeID, timeOffStartDate, timeOffEndDate, timeOffReason) VALUES ("
        sql &= "'" & txtEmployeeID.Text & "',"
        sql &= "'" & dtStart.Value.Date & "',"
        sql &= "'" & dtEnd.Value.Date & "',"
        sql &= "'" & txtReason.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddHoliday")
        con.Close()

        MessageBox.Show("Holiday has been sent for approval")

        'SQL statement that gets the information on pending holidays
        sql = "SELECT timeOffStartDate, timeOffEndDate, timeOffReason FROM TIMEOFF where employeeID = " & employeeID & " and approved = no"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblPendHol")

        'populate listbox with pending timeoff data
        For i = 0 To ds.Tables("tblPendHol").Rows.Count - 1
            lstBoxPendHol.Items.Add("Reason: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffReason") + "     Start Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffStartDate") + "     End Date: " + ds.Tables("tblPendHol").Rows(i).Item("timeOffEndDate"))
        Next
    End Sub

    Private Sub lstBoxAccHoll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxAccHoll.SelectedIndexChanged

    End Sub

    Private Sub lstBoxPendHol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxPendHol.SelectedIndexChanged

    End Sub

    Private Sub btnRetDash_Click(sender As Object, e As EventArgs) Handles btnRetDash.Click
        Me.Hide()
        EmployeeDashboard.Show()
    End Sub
End Class