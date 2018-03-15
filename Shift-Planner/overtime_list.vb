Public Class overtime_list

    Private sqlQuery As String
    Private i As Integer
    Private currentUser As Integer
    Private otType As String
    Private otDate As String
    Private otStart As String
    Private otEnd As String
    Private otPay As Decimal

    Private Sub Overtime_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Gets the employee ID of the user that is currently logged on and sets the label to the users ID
        currentUser = currentEmployeeID
        currentUserLabel.Text = "Logged in as: " & currentUser


        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT * FROM CREATEOVERTIME where taken = no"

        'Creates a dataset with the results of the query. Closes database connection.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        If ds.Tables("tblOvertime").Rows().Count = 0 Then
            listOfShifts2.Items.Add("No available shifts.")
        End If

        'Populate the list box with overtime shifts from the database
        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            listOfShifts2.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStartTime") + "    " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEndTime") + "      " + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimePay"))
        Next
    End Sub

    Private Sub ListOfShifts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOfShifts2.SelectedIndexChanged

        If listOfShifts2.Text = "No available shifts." Then
            MessageBox.Show("No shifts available")
        Else
            'Stores properties of the selected shift as local variables.

            otType = ds.Tables("tblOvertime").Rows(listOfShifts2.SelectedIndex + 1).Item("overtimeType")
            otDate = ds.Tables("tblOvertime").Rows(listOfShifts2.SelectedIndex + 1).Item("overtimeDate")
            otStart = ds.Tables("tblOvertime").Rows(listOfShifts2.SelectedIndex + 1).Item("overtimeStartTime")
            otEnd = ds.Tables("tblOvertime").Rows(listOfShifts2.SelectedIndex + 1).Item("overtimeEndTime")
            otPay = ds.Tables("tblOvertime").Rows(listOfShifts2.SelectedIndex + 1).Item("overtimePay")

            'Updates text box to show the details of the selected shift.
            shiftDetailsTxtBox.Text = "Would you like to apply for the following shift? " & Environment.NewLine & Environment.NewLine & "Position:  " & otType & Environment.NewLine & "Date:  " & otDate & Environment.NewLine & "Start Time:  " & otStart & Environment.NewLine & "End Time:  " & otEnd & Environment.NewLine & "Pay (per hour):  £" & otPay
        End If

    End Sub

    Private Sub Applybtn_Click(sender As Object, e As EventArgs) Handles applybtn.Click

        'Insert query to allow the current user to apply for the selected shift.
        sql = "INSERT INTO OVERTIME (employeeID, overtimeType, overtimeDate, overtimeStartTime, overtimeEndTime, overTimePay) VALUES ("
        sql &= "'" & currentUser & "',"
        sql &= "'" & otType & "',"
        sql &= "'" & otDate & "',"
        sql &= "'" & otStart & "',"
        sql &= "'" & otEnd & "',"
        sql &= "'" & otPay & "')"

        'Updates the table with the sql query. Closes connection to database.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        MessageBox.Show("Your response to this shift has been sent.")

        sql = "UPDATE CREATEOVERTIME set taken = yes where ID = " & ds.Tables("tblOvertime").Rows(0).Item("ID") & ""

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblUpdateOT")
        con.Close()


    End Sub

    Private Sub changeView_Click(sender As Object, e As EventArgs) Handles changeView.Click
        Overtime_calendar.Show()
        Me.Hide()
    End Sub

    Private Sub shiftDetailsTxtBox_TextChanged(sender As Object, e As EventArgs) Handles shiftDetailsTxtBox.TextChanged

    End Sub

    Private Sub rtrnToDshBtn_Click(sender As Object, e As EventArgs) Handles rtrnToDshBtn.Click
        Me.Hide()
        EmployeeDashboard.Show()
    End Sub
End Class