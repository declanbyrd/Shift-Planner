Public Class overtime_list

    Public sqlQuery As String
    Public i As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Overtime_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()



        sqlQuery = "SELECT overtimeDate, overtimePay FROM otTest"

        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()

        For i = 0 To ds.Tables("tblOvertime").Rows.Count() - 1


            ListBox1.Items.Add(ds.Tables("tblOvertime").Rows(i).Item("overtimeDate") + "    " + ds.Tables("tblOvertime").Rows(i).Item("overtimePay"))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


        sqlQuery = "SELECT overtimeDate, overtimePay FROM OVERTIME"

        da = New OleDb.OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds, "tblOvertime")
        con.Close()


        'For Each row In ds.Tables("tblOvertime")
        'ListBox1.Items.Add(New ListItem(ds.Tables("tblOvertime").Rows(row).Item("overtimeDate"), ds.Tables("tblOvertime").Rows(row).Item("overtimePay")))
        'Next
    End Sub
End Class