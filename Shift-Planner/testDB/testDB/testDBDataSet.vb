Partial Class testDBDataSet
    Partial Public Class tblEmployeeDataTable
        Private Sub tblEmployeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.employeeIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
