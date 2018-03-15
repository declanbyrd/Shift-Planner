Public Class EmployeeDashboard
    'when this is set to True, the first index of the listbox will always be an overtime announcement
    Dim overtimeAnnouncement As Boolean = False
    'each item will correspond to an approved holiday which hasn't been seen
    Dim holidayIndexes(100) As Integer
    Private Sub btnOvertime_Click(sender As Object, e As EventArgs) Handles btnOvertime.Click
        'open overtime form
        Overtime_calendar.Show()
        Me.Hide()
    End Sub

    Private Sub btnTimeOff_Click(sender As Object, e As EventArgs) Handles btnTimeOff.Click
        Holiday.Show()
        Me.Hide()
    End Sub

    Private Sub refreshPage()
        lstAnnouncements.Items.Clear()
        lstShifts.Items.Clear()

        'go to database and fetch user's current shifts
        sql = "SELECT * FROM SHIFT where employeeID = " & currentEmployeeID

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblShift")
        con.Close()

        For i = 0 To ds.Tables("tblShift").Rows.Count - 1
            lstShifts.Items.Add(ds.Tables("tblShift").Rows(i).Item("Shift"))
        Next

        sql = "SELECT * FROM OVERTIME where employeeID = " & currentEmployeeID

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblOvertimeShift")
        con.Close()

        For i = 0 To ds.Tables("tblOvertimeShift").Rows.Count - 1
            lstShifts.Items.Add("You're working an overtime shift on: " & ds.Tables("tblOvertimeShift").Rows(i).Item("overtimeDate"))
        Next

        'populate the calendar and listbox with the shift data

        'populate the listbox with announcements
        'overtime available
        sql = "SELECT * FROM CREATEOVERTIME WHERE taken = no"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblOvertimeAn")
        con.Close()

        If ds.Tables("tblOvertimeAn").Rows.Count > 0 Then
            lstAnnouncements.Items.Add("Overtime is available")
            overtimeAnnouncement = True
        End If

        'approved / not approved holidays :
        Dim approvalString As String = ""
        sql = "SELECT * FROM TIMEOFF WHERE employeeID = " & currentEmployeeID & " AND seen = no AND (status = 1 OR status = 0)"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblTimeoff")
        con.Close()

        For i = 0 To ds.Tables("tblTimeoff").Rows.Count - 1
            approvalString = If(ds.Tables("tblTimeoff").Rows(i).Item("status") = 1, "", "not")
            lstAnnouncements.Items.Add("Your holiday from " & ds.Tables("tblTimeoff").Rows(i).Item("timeOffStartDate") &
                    " to " & ds.Tables("tblTimeoff").Rows(i).Item("timeOffEndDate") & " has " & approvalString & " been approved")
            holidayIndexes(i) = ds.Tables("tblTimeoff").Rows(i).Item("timeOffID")
        Next

        ds.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshPage()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Me.Enabled = False
        PasswordChange.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginRegister.Show()
        Me.Hide()
    End Sub

    Private Sub lstAnnouncements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAnnouncements.SelectedIndexChanged
        'if there is new overtime in the announcements then the first index of the 
        'holiday announcements will be 1 istead of 0
        Dim timeOffIndexAddition As Integer = If(overtimeAnnouncement, 1, 0)
        Dim result As Integer
        If lstAnnouncements.SelectedIndex > timeOffIndexAddition - 1 Then
            result = MessageBox.Show("Remove this announcement?", "caption", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                sql = "UPDATE TIMEOFF set seen = yes WHERE timeOffID =" &
                    holidayIndexes(lstAnnouncements.SelectedIndex - timeOffIndexAddition)

                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "tblTimeoff")
                con.Close()

                refreshPage()
            End If
        End If
    End Sub
End Class