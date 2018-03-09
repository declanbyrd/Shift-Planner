<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDashboard
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTimeOff = New System.Windows.Forms.Button()
        Me.btnOvertime = New System.Windows.Forms.Button()
        Me.calShifts = New System.Windows.Forms.MonthCalendar()
        Me.lstShifts = New System.Windows.Forms.ListBox()
        Me.lstAnnouncements = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstShifts)
        Me.GroupBox1.Controls.Add(Me.calShifts)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(961, 290)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shifts"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstAnnouncements)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(961, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Announcements"
        '
        'btnTimeOff
        '
        Me.btnTimeOff.Location = New System.Drawing.Point(774, 604)
        Me.btnTimeOff.Name = "btnTimeOff"
        Me.btnTimeOff.Size = New System.Drawing.Size(199, 33)
        Me.btnTimeOff.TabIndex = 3
        Me.btnTimeOff.Text = "Apply for time off"
        Me.btnTimeOff.UseVisualStyleBackColor = True
        '
        'btnOvertime
        '
        Me.btnOvertime.Location = New System.Drawing.Point(558, 604)
        Me.btnOvertime.Name = "btnOvertime"
        Me.btnOvertime.Size = New System.Drawing.Size(199, 33)
        Me.btnOvertime.TabIndex = 4
        Me.btnOvertime.Text = "Overtime shifts"
        Me.btnOvertime.UseVisualStyleBackColor = True
        '
        'calShifts
        '
        Me.calShifts.Location = New System.Drawing.Point(12, 51)
        Me.calShifts.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.calShifts.Name = "calShifts"
        Me.calShifts.TabIndex = 0
        '
        'lstShifts
        '
        Me.lstShifts.FormattingEnabled = True
        Me.lstShifts.ItemHeight = 16
        Me.lstShifts.Location = New System.Drawing.Point(287, 51)
        Me.lstShifts.Name = "lstShifts"
        Me.lstShifts.Size = New System.Drawing.Size(659, 212)
        Me.lstShifts.TabIndex = 1
        '
        'lstAnnouncements
        '
        Me.lstAnnouncements.FormattingEnabled = True
        Me.lstAnnouncements.ItemHeight = 16
        Me.lstAnnouncements.Location = New System.Drawing.Point(12, 51)
        Me.lstAnnouncements.Name = "lstAnnouncements"
        Me.lstAnnouncements.Size = New System.Drawing.Size(934, 228)
        Me.lstAnnouncements.TabIndex = 2
        '
        'EmployeeDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 645)
        Me.Controls.Add(Me.btnOvertime)
        Me.Controls.Add(Me.btnTimeOff)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EmployeeDashboard"
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstShifts As ListBox
    Friend WithEvents calShifts As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTimeOff As Button
    Friend WithEvents btnOvertime As Button
    Friend WithEvents lstAnnouncements As ListBox
End Class
