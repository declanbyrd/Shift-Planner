

Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim employeeID As Integer = CUInt(txtLUser.Text)
        Dim password As String = txtLPass.Text

        sql = "SELECT employeeID, password, admin FROM EMPLOYEE WHERE employeeID = " & employeeID & " and password = '" + password + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblLogOn")

        'Checks to see if there is an employee with that username and password
        If ds.Tables("tblLogOn").Rows.Count > 0 Then
            'Checks to see whether the user is an admin or employee.
            currentAdmin = If(ds.Tables("tblLogOn").Rows(0).Item("admin") = True, True, False)
            If ds.Tables("tblLogOn").Rows(0).Item("password") = "changeme" Then
                If currentAdmin Then
                    AdminDashboard.Show()
                    AdminDashboard.Enabled = False
                Else
                    EmployeeDashboard.Show()
                    EmployeeDashboard.Enabled = False
                End If

                firstLogin = True
                PasswordChange.Show()
                currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
                MsgBox("Change your password from the default value.")
                Me.Close()
            ElseIf currentAdmin Then
                MessageBox.Show("Log on successful as admin.")
                AdminDashboard.Show()
                Me.Close()
            Else
                MessageBox.Show("Log on successful as employee.")
                EmployeeDashboard.Show()
                Me.Close()

            End If

        Else
            MessageBox.Show("Incorrect username and/or password, try again.")

        End If

        con.Close()
        ds.Clear()
    End Sub
End Class