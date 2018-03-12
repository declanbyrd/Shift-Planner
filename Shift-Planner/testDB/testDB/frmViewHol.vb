Public Class frmViewHol

    Dim row As Integer



    Private Sub frmViewHol_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'SQL statement that gets the information on pending holidays
        sql = "SELECT * FROM TIMEOFF where approved = no"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblHol")

        'Loops through all of the values in the 'Pending Holiday' dataset and inserts them into a list box
        'So the employee can see which holiday hasn't been accepted yet
        For i = 0 To ds.Tables("tblHol").Rows.Count - 1
            lstBoxHol.Items.Add("Employee: " & ds.Tables("tblHol").Rows(i).Item("employeeID") & " Reason: " + ds.Tables("tblHol").Rows(i).Item("timeOffReason") + " Start Date: " + ds.Tables("tblHol").Rows(i).Item("timeOffStartDate") + " End Date: " + ds.Tables("tblHol").Rows(i).Item("timeOffEndDate"))
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
            btnAccHol.Enabled = True
        Else
            btnAccHol.Enabled = False
        End If
    End Sub

    Private Sub btnAccHol_Click(sender As Object, e As EventArgs) Handles btnAccHol.Click

        'SQL statement to update the selected pending holiday to now being accepted
        sql = "UPDATE TIMEOFF SET approved = yes WHERE employeeID = " & ds.Tables("tblHol").Rows(row).Item("employeeID") & ""

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblApproveHol")
        con.Close()

        MessageBox.Show("Holiday has been accepted.")

    End Sub
End Class