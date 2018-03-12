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

        'Gets the employee ID of the user that is currently logged on
        'currentUser = ds.Tables("tblLogOn").Rows(0).Item("employeeID")

        DBConnect()

        sqlQuery = "SELECT overtimeDate, overtimePay FROM otTest"

        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1
            ListBox1.Items.Add("Date:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + "Pay:  " + ds.Tables("tblOvertime").Rows(i).Item("overtimePay") + " p/h" + ds.Tables("tblOvertime").Rows(i).Item("overtimeType") + "Start: " + ds.Tables("tblOvertime").Rows(i).Item("overtimeStart") + "Finish:   " + ds.Tables("tblOvertime").Rows(i).Item("overtimeEnd"))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        otType = ds.Tables("tblOvertime").Rows(ListBox1.SelectedIndex).Item("overtimeType")
        otDate = ds.Tables("tblOvertime").Rows(ListBox1.SelectedIndex).Item("overtimeDate")
        otStart = ds.Tables("tblOvertime").Rows(ListBox1.SelectedIndex).Item("overtimeStart")
        otEnd = ds.Tables("tblOvertime").Rows(ListBox1.SelectedIndex).Item("overtimeEnd")
        otPay = ds.Tables("tblOvertime").Rows(ListBox1.SelectedIndex).Item("overtimePay")

        TextBox1.Text = "Would you like to apply for the following shift? " & Environment.NewLine & "Position:  " & otType & "Date:  " & otDate & "Start Time:  " & otStart & "End Time:  " & otEnd & "Pay (per hour):  " & otPay
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    sqlQuery = "INSERT INTO tblovertime (employeeID, overtimeType, overtimeDate, overTimePay, overtimeStart, overtimeEnd) VALUES ("
    '    sql& = "'" & currentUser & "',"
    '    sql& = "'" & otType & "',"
    '    sql& = "'" & otDate & "',"
    '    sql& = "'" & otStart & "',"
    '    sql& = "'" & otEnd & "',"
    '    sql& = "'" & otPay & "')"


    '    da = New OleDb.OleDbDataAdapter(sqlQuery, con)
    '    da.Fill(ds, "tblOvertime")
    '    con.Close()
    'End Sub
End Class