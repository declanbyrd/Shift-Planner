<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overtime_calendar
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
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.listOfShifts = New System.Windows.Forms.ListBox()
        Me.currentUserLabel = New System.Windows.Forms.Label()
        Me.shiftDetailsTxtBox = New System.Windows.Forms.TextBox()
        Me.selectedDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendar.Location = New System.Drawing.Point(45, 74)
        Me.calendar.MaxSelectionCount = 1
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 3
        '
        'listOfShifts
        '
        Me.listOfShifts.FormattingEnabled = True
        Me.listOfShifts.ItemHeight = 16
        Me.listOfShifts.Location = New System.Drawing.Point(440, 100)
        Me.listOfShifts.Name = "listOfShifts"
        Me.listOfShifts.Size = New System.Drawing.Size(537, 244)
        Me.listOfShifts.TabIndex = 4
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserLabel.Location = New System.Drawing.Point(874, 18)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(14, 19)
        Me.currentUserLabel.TabIndex = 7
        Me.currentUserLabel.Text = " "
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(45, 373)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(496, 338)
        Me.shiftDetailsTxtBox.TabIndex = 8
        '
        'selectedDate
        '
        Me.selectedDate.AutoSize = True
        Me.selectedDate.Location = New System.Drawing.Point(440, 58)
        Me.selectedDate.Name = "selectedDate"
        Me.selectedDate.Size = New System.Drawing.Size(12, 17)
        Me.selectedDate.TabIndex = 9
        Me.selectedDate.Text = " "
        '
        'overtime_calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 834)
        Me.Controls.Add(Me.selectedDate)
        Me.Controls.Add(Me.shiftDetailsTxtBox)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.listOfShifts)
        Me.Controls.Add(Me.calendar)
        Me.Name = "overtime_calendar"
        Me.Text = "Overtime Shifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents listOfShifts As ListBox
    Friend WithEvents currentUserLabel As Label
    Friend WithEvents shiftDetailsTxtBox As TextBox
    Friend WithEvents selectedDate As Label
End Class
