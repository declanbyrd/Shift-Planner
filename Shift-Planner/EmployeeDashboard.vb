Public Class EmployeeDashboard
    Private Sub btnOvertime_Click(sender As Object, e As EventArgs) Handles btnOvertime.Click
        'open overtime form
        Overtime_calendar.Show()
        Me.Hide()
    End Sub

    Private Sub btnTimeOff_Click(sender As Object, e As EventArgs) Handles btnTimeOff.Click
        Holiday.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'go to database and fetch user's current shifts
        sql = "SELECT * FROM SHIFT where employeeID = " & currentEmployeeID

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblShift")

        For i = 0 To ds.Tables("tblShift").Rows.Count - 1
            lstShifts.Items.Add(ds.Tables("tblShift").Rows(i).Item("Shift"))
        Next

        'populate the calendar and listbox with the shift data
        'go to database and fetch announcements
        'populate the listbox with announcements
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Me.Enabled = False
        PasswordChange.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginRegister.Show()
        Me.Hide()
    End Sub
End Class