Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Shift_Planner

<TestClass()> Public Class UnitTest

    <TestMethod()> Public Sub CorrectLogon()
        Dim employeeID As Integer = 1
        Dim password As String = "password"

        Assert.IsTrue(LoginRegister.Signin(employeeID, password), "The user has successfully logged on")

    End Sub

    <TestMethod()> Public Sub WrongPassword()
        Dim employeeID As Integer = 1
        Dim password As String = "My First Pet"

        Assert.IsFalse(LoginRegister.Signin(employeeID, password), "The password is incorrect and should not let the user log in")

    End Sub
    <TestMethod()> Public Sub WrongUsername()
        Dim employeeID As Integer = 99
        Dim password As String = "password"

        Assert.IsFalse(LoginRegister.Signin(employeeID, password), "The employee ID should be invalid and the user will not be logged in")

    End Sub

    <TestMethod()> Public Sub UsernameAsString()
        Dim employeeID As Integer = "Rhubarb Bikini"
        Dim password As String = "password"

        Assert.IsFalse(LoginRegister.Signin(employeeID, password), "The employee ID should be invalid and the user will not be logged in")

    End Sub

    <TestMethod()> Public Sub ValidNewEmployee()
        Dim fName As String = "Rhubarb"
        Dim sName As String = "Bikini"
        Dim tempPwd As String = "IamRhubarbBikini"

        Assert.IsTrue(frmNewEmp.NewEmployee(fName, sName, tempPwd), "A new user should be created")
    End Sub

    <TestMethod()> Public Sub InvalidSnameNewEmployee()
        Dim fName As String = "Rhubarb"
        Dim sName As String = "66 105 107 105 110 105"
        Dim tempPwd As String = "IamRhubarbBikini"

        Assert.IsFalse(frmNewEmp.NewEmployee(fName, sName, tempPwd), "A user cannot have numbers in their last name")
    End Sub

    <TestMethod()> Public Sub InvalidPwdNewEmployee()
        Dim fName As String = "Rhubarb"
        Dim sName As String = "Bikini"
        Dim tempPwd As String = "rb"

        Assert.IsFalse(frmNewEmp.NewEmployee(fName, sName, tempPwd), "Password must be larger than 6 characters")
    End Sub

    <TestMethod()> Public Sub ValidHolidayRequest()
        Dim employeeID As Integer = 2
        Dim startDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim endDate As Date = Date.FromOADate(5 / 4 / 2018)
        Dim reason As String = "Family holiday"

        Assert.IsTrue(Holiday.NewHolidayRequest(employeeID, startDate, endDate, reason), "Request should be sent.")
    End Sub

    <TestMethod()> Public Sub InvalidDateHolidayRequest()
        Dim employeeID As Integer = 2
        Dim startDate As Date = Date.FromOADate(1 / 1 / 2002)
        Dim endDate As Date = Date.FromOADate(25 / 12 / 2008)
        Dim reason As String = "Family holiday"

        Assert.IsFalse(Holiday.NewHolidayRequest(employeeID, startDate, endDate, reason), "Request should not be sent. Time of cannot be in the past")
    End Sub

    <TestMethod()> Public Sub InvalidReasonHolidayRequest()
        Dim employeeID As Integer = 2
        Dim startDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim endDate As Date = Date.FromOADate(5 / 4 / 2018)
        Dim reason As String = " "

        Assert.IsFalse(Holiday.NewHolidayRequest(employeeID, startDate, endDate, reason), "Request should not be sent. Reasoning cannot be left blank.")
    End Sub

    <TestMethod()> Public Sub ValidNewShift()

        Dim employeeID As Integer = 2
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30

        Assert.IsTrue(BtnDash.NewShift(employeeID, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin), "New shift should be added.")
    End Sub

    <TestMethod()> Public Sub InvalidDateNewShift()

        Dim employeeID As Integer = 2
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2003)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30

        Assert.IsFalse(BtnDash.NewShift(employeeID, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin), "New shift should not be added. Shifts cannot be added in the past")
    End Sub

    <TestMethod()> Public Sub InvalidTimesNewShift()

        Dim employeeID As Integer = 2
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = -100
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 300000
        Dim endTimeMin As Integer = 30

        Assert.IsFalse(BtnDash.NewShift(employeeID, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin), "New shift should not be added. Time must be in 24 hour format")
    End Sub

    <TestMethod()> Public Sub ValidNewOvertime()

        Dim type As String = "Checkouts"
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30
        Dim pay As Double = 7.5

        Assert.IsTrue(L.NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay), "New overtime shift should be added.")
    End Sub

    <TestMethod()> Public Sub InvalidTypeNewOvertime()

        Dim type As String = "##########"
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30
        Dim pay As Double = 7.5

        Assert.IsFalse(L.NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay), "New overtime shift should not be added. Type must be a String")
    End Sub

    <TestMethod()> Public Sub InvalidDateNewOvertime()

        Dim type As String = "Checkouts"
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2008)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30
        Dim pay As Double = 7.5

        Assert.IsFalse(L.NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay), "New overtime shift should not be added. Shifts cannot be in the past")
    End Sub

    <TestMethod()> Public Sub InvalidHoursNewOvertime()

        Dim type As String = "Checkouts"
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = -100
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 300000
        Dim endTimeMin As Integer = 30
        Dim pay As Double = 7.5

        Assert.IsFalse(L.NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay), "New overtime shift should not be added. Times must be in 24 hour format")
    End Sub

    <TestMethod()> Public Sub InvalidPayNewOvertime()

        Dim type As String = "Checkouts"
        Dim shiftDate As Date = Date.FromOADate(30 / 3 / 2018)
        Dim startTimeHour As Integer = 12
        Dim startTimeMin As Integer = 15
        Dim endTimeHour As Integer = 18
        Dim endTimeMin As Integer = 30
        Dim pay As Double = -100

        Assert.IsFalse(L.NewOvertimeShift(type, shiftDate, startTimeHour, startTimeMin, endTimeHour, endTimeMin, pay), "New overtime shift should not be added. Pay must be positive!")
    End Sub
End Class