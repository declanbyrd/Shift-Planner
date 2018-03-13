Public Class overtime_list

    Public sqlQuery As String
    Public i As Integer
    Public currentUser As Integer
    Public otType As String
    Public otDate As String
    Public otStart As String
    Public otEnd As String
    Public otPay As Decimal

    Private Sub Overtime_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Gets the employee ID of the user that is currently logged on and sets the label to the users ID
        currentUser = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
        currentUserLabel.Text = "Logged in as: " + currentUser

        'connect to the database
        DBConnect()

        'Sql query to get the required values from the overtime table
        sqlQuery = "SELECT overtimeDate, overtimePay, overtimeType, overtimeStart, overtimeEnd FROM otTest"

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

    Private Sub Applybtn_Click(sender As Object, e As EventArgs) Handles applybtn.Click

        'connect to the database
        DBConnect()

        'Insert query to allow the current user to apply for the selected shift.
        sqlQuery = "INSERT INTO tblovertime (employeeID, overtimeType, overtimeDate, overTimePay, overtimeStart, overtimeEnd) VALUES ("
        sql& = "'" & currentUser & "',"
        sql& = "'" & otType & "',"
        sql& = "'" & otDate & "',"
        sql& = "'" & otStart & "',"
        sql& = "'" & otEnd & "',"
        sql& = "'" & otPay & "')"

        'Updates the table with the sql query. Closes connection to database.
        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()
    End Sub
End Class