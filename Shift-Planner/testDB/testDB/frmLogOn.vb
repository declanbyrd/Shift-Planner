Public Class frmLogOn
    Dim employeeID As Integer
    Dim password As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

    Private Sub btnLogOn_Click(sender As Object, e As EventArgs) Handles btnLogOn.Click

        'Converts the value in the text box to type in
        employeeID = CUInt(txtEmpID.Text)
        password = txtPassword.Text

        sql = "SELECT employeeID, password, admin FROM EMPLOYEE WHERE employeeID = " & employeeID & " and password = '" + password + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblLogOn")


        'Checks to see if there is an employee with that username and password
        If ds.Tables("tblLogOn").Rows.Count > 0 Then

            'Checks to see whether the user is an admin or employee.
            'If admin, then the admin form will load, if not, then the employee form will load.
            If ds.Tables("tblLogOn").Rows(0).Item("admin") = True Then

                MessageBox.Show("Log on successful as admin.")
                frmAdmin.Show()
                Me.Hide()

            Else

                MessageBox.Show("Log on successful as employee.")
                frmEmployee.Show()
                Me.Hide()

            End If

        Else
            MessageBox.Show("Incorrect username and/or password, try again.")

        End If

        con.Close()

    End Sub
End Class
