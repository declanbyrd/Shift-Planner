Public Class EmployeeDashboard
    Private Sub btnOvertime_Click(sender As Object, e As EventArgs) Handles btnOvertime.Click
        'open overtime form
        Me.Close()
    End Sub

    Private Sub btnTimeOff_Click(sender As Object, e As EventArgs) Handles btnTimeOff.Click
        'open time off form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'go to database and fetch user's current shifts
        'populate the calendar and listbox with the shift data
        'go to database and fetch announcements
        'populate the listbox with announcements
    End Sub
End Class