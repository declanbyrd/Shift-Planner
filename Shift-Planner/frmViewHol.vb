Public Class frmViewHol

    Dim row As Integer



    Private Sub frmViewHol_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'SQL statement that gets the information on pending holidays
        sql = "SELECT * FROM TIMEOFF where status = 2"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblHol")

        'Loops through all of the values in the 'Pending Holiday' dataset and inserts them into a list box
        'So the employee can see which holiday hasn't been accepted yet
        For i = 0 To ds.Tables("tblHol").Rows.Count - 1
            lstBoxHol.Items.Add("Employee: " & ds.Tables("tblHol").Rows(i).Item("employeeID") & " Start Date: " + ds.Tables("tblHol").Rows(i).Item("timeOffStartDate") + " End Date: " + ds.Tables("tblHol").Rows(i).Item("timeOffEndDate"))
        Next
    End Sub

    Private Sub lstBoxHol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxHol.SelectedIndexChanged

        'Gets the row of the list box which will correspond to the row in the database
        row = lstBoxHol.SelectedIndex

        'Formatting string that is a terms and conditions on the holiday.
        txtHolInfo.Text = "By checking 'Agree to Holiday, you are formally accepting employee ID: " & ds.Tables("tblHol").Rows(row).Item("employeeID") & "'s holiday between"
        txtHolInfo.Text &= ds.Tables("tblHol").Rows(row).Item("timeOffStartDate") + " and "
        txtHolInfo.Text &= ds.Tables("tblHol").Rows(row).Item("timeOffEndDate") + ". For the reason of '" + ds.Tables("tblHol").Rows(row).Item("timeOffReason") + "'. Once accepted, this cannot be undone."
    End Sub

    Private Sub chkBoxAcc_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxAcc.CheckedChanged

        'Only enables the the accept holiday button to be anabled if the agree to holiday is checked
        If chkBoxAcc.Checked = True Then
            ChkDeny.Checked = False
        End If
    End Sub

    Private Sub btnAccHol_Click(sender As Object, e As EventArgs) Handles btnResp.Click

        If chkBoxAcc.Checked = False And ChkDeny.Checked = False Then
            MessageBox.Show("Please either accept or deny the holiday")
        ElseIf chkBoxAcc.Checked = True Then
            'SQL statement to update the selected pending holiday to now being accepted
            sql = "UPDATE TIMEOFF SET status = 1 WHERE employeeID = " & ds.Tables("tblHol").Rows(row).Item("employeeID") & " and timeOffReason = '" & ds.Tables("tblHol").Rows(row).Item("timeOffReason") & "'"

            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "tblApproveHol")
            con.Close()

            MessageBox.Show("Holiday has been accepted.")
        ElseIf ChkDeny.Checked = True Then
            'SQL statement to update the selected pending holiday to now being accepted
            sql = "UPDATE TIMEOFF SET status = 0 WHERE employeeID = " & ds.Tables("tblHol").Rows(row).Item("employeeID") & " and timeOffReason = '" & ds.Tables("tblHol").Rows(row).Item("timeOffReason") & "'"

            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "tblApproveHol")
            con.Close()

            MessageBox.Show("Holiday has denied")
        End If


    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub

    Private Sub ChkDeny_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDeny.CheckedChanged
        'Only enables the the accept holiday button to be enabled if the deny to holiday is checked
        If ChkDeny.Checked = True Then
            chkBoxAcc.Checked = False
        End If
    End Sub
End Class