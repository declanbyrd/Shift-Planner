Public Class Overtime_calendar
    Private sqlQuery As String
    Private i As Integer
    Private currentUser As Integer
    Private otType As String
    Private otDate As String
    Private otStart As String
    Private otEnd As String
    Private otPay As Decimal
    Private calendarDate As String

    Private Sub Overtime_calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        calendarDate = calendar.SelectionRange.Start.ToShortDateString
        selectedDate.Text = calendar.SelectionRange.Start.ToLongDateString
        Me.calendar.ShowToday = False

        'Gets the employee ID of the user that is currently logged on and sets the label to the users ID
        'currentUser = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
        'currentUserLabel.Text = "Logged in as: " + currentUser

        'connect to the database
        DBConnect()

        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT * FROM otTest WHERE overtimeDate = " & calendarDate & ""

        'Creates a dataset with the results of the query. Closes database connection.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        'Populate the list box with overtime shifts from the database
        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            listOfShifts.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStart") + "    " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEnd"))
        Next
    End Sub

    Private Sub ListOfShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOfShifts.SelectedIndexChanged

        'Stores properties of the selected shift as local variables.

        otType = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeType")
        otDate = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeDate")
        otStart = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeStart")
        otEnd = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeEnd")
        otPay = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimePay")

        'Updates text box to show the details of the selected shift.
        shiftDetailsTxtBox.Text = "Would you like to apply for the following shift? " & Environment.NewLine & Environment.NewLine & "Position:  " & otType & Environment.NewLine & "Date:  " & otDate & Environment.NewLine & "Start Time:  " & otStart & Environment.NewLine & "End Time:  " & otEnd & Environment.NewLine & "Pay (per hour):  £" & otPay

    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar.DateChanged
        calendarDate = calendar.SelectionRange.Start.ToShortDateString
        selectedDate.Text = calendar.SelectionRange.Start.ToLongDateString

        'connect to the database
        DBConnect()

        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT * FROM otTest WHERE overtimeDate = " & calendarDate & ""

        'Creates a dataset with the results of the query. Closes database connection.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        'Populate the list box with overtime shifts from the database
        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            listOfShifts.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStart") + "    " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEnd"))
        Next
    End Sub
End Class