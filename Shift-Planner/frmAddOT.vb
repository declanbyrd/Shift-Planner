Public Class L
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddOvertime.Click

        Dim type As String = txtOType.Text
        Dim shiftDate As Date = dtODate.Value.Date
        Dim startTimeHour As Integer = cmbH1.Text
        Dim startTimeMin As Integer = cmbM1.Text
        Dim endTimeHour As Integer = CmbH2.Text
        Dim endTimeMin As Integer = cmbM2.Text
        Dim pay As String = txtOPay.Text

        NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay)


    End Sub

    Public Shared Function NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay)

        Dim success As Boolean = False

        sql = "INSERT INTO CREATEOVERTIME (overtimeType, overtimeDate, overtimeStartTime, overtimeEndTime, overtimePay) VALUES ("
        sql &= "'" & type & "',"
        sql &= "'" & shiftDate & "',"
        sql &= "'" & startTimeHour & ":" & startTimeMin & "',"
        sql &= "'" & endTimeHour & ":" & endTimeMin & "',"
        sql &= "'" & pay & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddOvertime")
        con.Close()

        MessageBox.Show("Overtime added succsessfully")
        success = True
        Return success
    End Function

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub
End Class