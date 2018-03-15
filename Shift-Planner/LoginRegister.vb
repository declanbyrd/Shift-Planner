

Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click

        If String.IsNullOrEmpty(txtLUser.Text) Or String.IsNullOrEmpty(txtLUser.Text) Then
            MessageBox.Show("Do not leave either field blank")
        ElseIf IsNumeric(txtLUser.text) = False Then
            MessageBox.Show("The Username nust be an integer")
        Else

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
                        currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
                        AdminDashboard.Show()
                        AdminDashboard.Enabled = False
                    Else
                        currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
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
                    currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
                    AdminDashboard.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Log on successful as employee.")
                    currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
                    EmployeeDashboard.Show()
                    Me.Close()

                End If

            Else
                MessageBox.Show("Incorrect username and/or password, try again.")

            End If
        End If

        con.Close()
        ds.Clear()
    End Sub


    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

End Class