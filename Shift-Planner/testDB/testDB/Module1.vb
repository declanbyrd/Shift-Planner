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

        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source =..\..\testDB.accdb"
        con.ConnectionString = dbProvider & dbSource

        con.Open()

        MessageBox.Show("Connected to database.")

    End Sub
End Module
