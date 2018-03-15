Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Shift_Planner

<TestClass()> Public Class UnitTest

    <TestMethod()> Public Sub correctLogon()
        Dim employeeID As Integer = 1
        Dim password As String = "password"

        Assert.IsTrue(LoginRegister.Signin(employeeID, password), "The user has successfully logged on")

    End Sub

    <TestMethod()> Public Sub wrongPassword()
        Dim employeeID As Integer = 1
        Dim password As String = "My First Pet"

        Assert.IsTrue(LoginRegister.Signin(employeeID, password), "The password is incorrect and should not let the user log in")

    End Sub
    <TestMethod()> Public Sub wrongUsername()
        Dim employeeID As Integer = 99
        Dim password As String = "password"

        Assert.IsTrue(LoginRegister.Signin(employeeID, password), "The employee ID should be invalid and the user will not be logged in")

    End Sub

    <TestMethod()> Public Sub usernameAsString()
        Dim employeeID As Integer = "Rhubarb Bikini"
        Dim password As String = "password"

        Assert.IsTrue(LoginRegister.Signin(employeeID, password), "The employee ID should be invalid and the user will not be logged in")

    End Sub

End Class