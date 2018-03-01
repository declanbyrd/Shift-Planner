<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overtime_calendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Monday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Friday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saturday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sunday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Monday, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday, Me.Saturday, Me.Sunday})
        Me.DataGridView1.Location = New System.Drawing.Point(308, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'Monday
        '
        Me.Monday.HeaderText = "Monday"
        Me.Monday.Name = "Monday"
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tuesday"
        Me.Tuesday.Name = "Tuesday"
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wednesday"
        Me.Wednesday.Name = "Wednesday"
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thursday"
        Me.Thursday.Name = "Thursday"
        '
        'Friday
        '
        Me.Friday.HeaderText = "Friday"
        Me.Friday.Name = "Friday"
        '
        'Saturday
        '
        Me.Saturday.HeaderText = "Saturday"
        Me.Saturday.Name = "Saturday"
        '
        'Sunday
        '
        Me.Sunday.HeaderText = "Sunday"
        Me.Sunday.Name = "Sunday"
        '
        'overtime_calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 834)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "overtime_calendar"
        Me.Text = "Overtime Shifts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Saturday As DataGridViewTextBoxColumn
    Friend WithEvents Sunday As DataGridViewTextBoxColumn
End Class
