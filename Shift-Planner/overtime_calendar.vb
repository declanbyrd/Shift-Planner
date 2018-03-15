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
    Dim overtimeID As Integer

    Private Sub Overtime_calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        calendarDate = calendar.SelectionRange.Start.ToShortDateString
        selectedDate.Text = calendar.SelectionRange.Start.ToLongDateString
        Me.calendar.ShowToday = False

        'Gets the employee ID of the user that is currently logged on and sets the label to the users ID
        currentUser = currentEmployeeID
        currentUserLabel.Text = "Logged in as: " & currentUser


        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT * FROM CREATEOVERTIME WHERE overtimeDate = " & calendarDate & ""

        'Creates a dataset with the results of the query. Closes database connection.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        'Populate the list box with overtime shifts from the database
        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            listOfShifts.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStart") + "    " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEnd"))
        Next

        shiftDetailsTxtBox.Text = "No shift selected"
        applyForShiftBtn.Enabled = False
    End Sub

    Private Sub ListOfShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOfShifts.SelectedIndexChanged


        'Validation for if the listbox contains no shifts
        If listOfShifts.Text = "No available shifts for this day." Then
            MessageBox.Show("There are no overtime shifts available for today. Please select another day")
        Else
            'Stores properties of the selected shift as local variables.
            otType = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeType")
            otDate = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeDate")
            otStart = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeStartTime")
            otEnd = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimeEndTime")
            otPay = ds.Tables("tblOvertime").Rows(listOfShifts.SelectedIndex).Item("overtimePay")

            'Updates text box to show the details of the selected shift.
            shiftDetailsTxtBox.Text = "Would you like to apply for the following shift? " & Environment.NewLine & Environment.NewLine & "Position:  " & otType & Environment.NewLine & "Date:  " & otDate & Environment.NewLine & "Start Time:  " & otStart & Environment.NewLine & "End Time:  " & otEnd & Environment.NewLine & "Pay (per hour):  £" & otPay

            'Enables the button allowing for someone to take the shift
            applyForShiftBtn.Enabled = True
        End If


    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar.DateChanged

        listOfShifts.Items.Clear()
        ds.Clear()

        calendarDate = calendar.SelectionRange.Start.ToShortDateString
        selectedDate.Text = calendar.SelectionRange.Start.ToLongDateString



        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT * FROM CREATEOVERTIME WHERE overtimeDate = #" & calendarDate & "# and taken = no"

        'Creates a dataset with the results of the query. Closes database connection.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")

        con.Close()

        If ds.Tables("tblOvertime").Rows().Count = 0 Then
            listOfShifts.Items.Add("No available shifts for this day.")
        End If

        'Populate the list box with overtime shifts from the database
        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            listOfShifts.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStartTime") + "    " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEndTime"))
        Next
    End Sub

    Private Sub ApplyForShiftBtn_Click(sender As Object, e As EventArgs) Handles applyForShiftBtn.Click


        'Insert query to allow the current user to apply for the selected shift.
        sql = "INSERT INTO OVERTIME (employeeID, overtimeType, overtimeDate, overtimeStartTime, overtimeEndTime, overtimePay) VALUES ("
        sql &= "'" & currentUser & "',"
        sql &= "'" & otType & "',"
        sql &= "'" & otDate & "',"
        sql &= "'" & otStart & "',"
        sql &= "'" & otEnd & "',"
        sql &= "'" & otPay & "')"

        'Updates the table with the sql query. Closes connection to database.
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblOT")
        con.Close()

        MessageBox.Show("You have now applied for this shift. It is your responsibility to turn up to this shift.")

        sql = "UPDATE CREATEOVERTIME set taken = yes where ID = " & ds.Tables("tblOvertime").Rows(0).Item("ID") & ""

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblUpdateOT")
    End Sub

    Private Sub changeView_Click(sender As Object, e As EventArgs) Handles changeView.Click
        overtime_list.Show()
        Me.Hide()
    End Sub

    Private Sub rtrnToDshBtn_Click(sender As Object, e As EventArgs) Handles rtrnToDshBtn.Click
        EmployeeDashboard.Show()
        Me.Hide()
    End Sub
End Class