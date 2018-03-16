

Imports System.Text.RegularExpressions

Public Class LoginRegister
    Private Sub BtnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click

        'Holds the variable for the current user that is logged into the program
        Dim employeeID As Integer = CUInt(txtLUser.Text)
        'Holds the password
        Dim password As String = txtLPass.Text

        Signin(employeeID, password)

    End Sub

    Public Shared Function Signin(employeeID, password)
        Dim success As Boolean
        If String.IsNullOrEmpty(employeeID) Or String.IsNullOrEmpty(employeeID) Then
            MessageBox.Show("Do not leave either field blank")
            success = False
        ElseIf IsNumeric(employeeID) = False Then
            MessageBox.Show("The Username nust be an integer")
            success = False
        Else
            sql = "SELECT employeeID, password, admin FROM EMPLOYEE WHERE employeeID = " & employeeID & " and password = '" + password + "'"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "tblLogOn")

            'Checks to see if there is an employee with the entered username and password
            If ds.Tables("tblLogOn").Rows.Count > 0 Then
                'Set to true if current user is an admin, false if they are not
                currentAdmin = If(ds.Tables("tblLogOn").Rows(0).Item("admin") = True, True, False)
                currentEmployeeID = ds.Tables("tblLogOn").Rows(0).Item("employeeID")
                If ds.Tables("tblLogOn").Rows(0).Item("password") = "changeme" Then
                    'password is changeme so this is the first login
                    If currentAdmin Then
                        AdminDashboard.Show()
                        AdminDashboard.Enabled = False
                        success = True
                    Else
                        EmployeeDashboard.Show()
                        EmployeeDashboard.Enabled = False
                        success = True
                    End If
                    'Prompts the user to change their password if it is their first log in
                    firstLogin = True
                    PasswordChange.Show()
                    MsgBox("Change your password from the default value.")
                    LoginRegister.Close()
                ElseIf currentAdmin Then
                    'If the user that has logged in is an admion, then the admin form will load
                    MessageBox.Show("Log on successful as admin.")
                    AdminDashboard.Show()
                    LoginRegister.Close()
                    success = True
                Else
                    'If the user that has logged in is and employee, then the employee form will load
                    MessageBox.Show("Log on successful as employee.")
                    EmployeeDashboard.Show()
                    LoginRegister.Close()
                    success = True
                End If

            Else
                'Error message displays if the username or password is incorrect
                MessageBox.Show("Incorrect username and/or password, try again.")
                success = False

            End If
        End If

        Return success

        con.Close()
        ds.Clear()
    End Function

    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

End Class