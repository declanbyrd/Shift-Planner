Public Class btnDash
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "INSERT INTO SHIFT (employeeID, startTime, endTime, shiftDate) VALUES ("
        sql &= "'" & txtEmpID.Text & "',"
        sql &= "'" & dtSDate.Value.Date & "',"
        sql &= "'" & cmbH1.Text & ":" & cmbM1.Text & "',"
        sql &= "'" & CmbH2.Text & ":" & cmbM2.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddShift")
        con.Close()

        MessageBox.Show("Shift added succsessfully")


    End Sub
End Class