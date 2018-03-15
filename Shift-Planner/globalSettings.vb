Imports System.Data.OleDb
Module globalSettings

    Public con As New OleDbConnection
    Public dbProvider As String
    Public dbSource As String
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public sql As String
    Public filepath As String
    Public currentEmployeeID As Integer
    Public currentAdmin As Boolean
    Public firstLogin As Boolean = False

    Public Sub DBConnect()
        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0;"
        dbSource = “Data Source = |DataDirectory|\testDB.accdb”
        con.ConnectionString = dbProvider & dbSource
        con.Open()
    End Sub
End Module
