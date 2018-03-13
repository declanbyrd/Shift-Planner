Imports System.Data.OleDb
Module Module1

    Public con As New OleDbConnection
    Public dbProvider As String
    Public dbSource As String
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public sql As String
    Public filepath As String

    Public Sub DBConnect()

        'note - comment the other lines and leave the line for your machine uncommented when testing

        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0;"
        'david's machine
        dbSource = "Data Source = C:\Users\User\Documents\GitHub\Shift-Planner\Shift-Planner\Shift-Planner\testDB.accdb"
        'alex's machine
        'dbSource = "Data Source = C:\Users\alexg\Documents\GitHub\Shift-Planner\Shift-Planner\testDB.accdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        MessageBox.Show("Connected to database.")

    End Sub
End Module
