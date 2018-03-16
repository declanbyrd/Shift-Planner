Public Class BtnDash
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim employeeID As Integer = txtEmpID.Text
        Dim shiftDate As Date = dtSDate.Value.Date
        Dim startTimeHour As Integer = cmbH1.Text
        Dim startTimeMin As Integer = cmbM1.Text
        Dim endTimeHour As Integer = CmbH2.Text
        Dim endTimeMin As Integer = cmbM2.Text

        NewShift(employeeID, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin)
    End Sub

    Public Shared Function NewShift(employeeID, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin)

        Dim success As Boolean = False

        sql = "INSERT INTO SHIFT (employeeID, startTime, endTime, shiftDate) VALUES ("
        sql &= "'" & employeeID & "',"
        sql &= "'" & shiftDate & "',"
        sql &= "'" & startTimeHour & ":" & startTimeMin & "',"
        sql &= "'" & endTimeHour & ":" & endTimeMin & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddShift")
        con.Close()

        MessageBox.Show("Shift added succsessfully")
        success = True
        Return success
    End Function
End Class