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
        Me.applyForShiftBtn = New System.Windows.Forms.Button()
        Me.changeView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendar.Location = New System.Drawing.Point(119, 74)
        Me.calendar.MaxSelectionCount = 1
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 3
        '
        'listOfShifts
        '
        Me.listOfShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfShifts.FormattingEnabled = True
        Me.listOfShifts.ItemHeight = 25
        Me.listOfShifts.Location = New System.Drawing.Point(471, 74)
        Me.listOfShifts.Name = "listOfShifts"
        Me.listOfShifts.ScrollAlwaysVisible = True
        Me.listOfShifts.Size = New System.Drawing.Size(733, 229)
        Me.listOfShifts.TabIndex = 4
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentUserLabel.Location = New System.Drawing.Point(827, 21)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(102, 27)
        Me.currentUserLabel.TabIndex = 7
        Me.currentUserLabel.Text = "Welcome "
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.BackColor = System.Drawing.Color.White
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(471, 375)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(537, 338)
        Me.shiftDetailsTxtBox.TabIndex = 8
        '
        'selectedDate
        '
        Me.selectedDate.AutoSize = True
        Me.selectedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedDate.Location = New System.Drawing.Point(466, 37)
        Me.selectedDate.Name = "selectedDate"
        Me.selectedDate.Size = New System.Drawing.Size(17, 25)
        Me.selectedDate.TabIndex = 9
        Me.selectedDate.Text = " "
        '
        'applyForShiftBtn
        '
        Me.applyForShiftBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyForShiftBtn.Location = New System.Drawing.Point(841, 652)
        Me.applyForShiftBtn.Name = "applyForShiftBtn"
        Me.applyForShiftBtn.Size = New System.Drawing.Size(153, 45)
        Me.applyForShiftBtn.TabIndex = 10
        Me.applyForShiftBtn.Text = "Apply for Shift"
        Me.applyForShiftBtn.UseVisualStyleBackColor = True
        '
        'changeView
        '
        Me.changeView.Location = New System.Drawing.Point(171, 293)
        Me.changeView.Name = "changeView"
        Me.changeView.Size = New System.Drawing.Size(138, 42)
        Me.changeView.TabIndex = 11
        Me.changeView.Text = "CHANGE TO LIST VIEW"
        Me.changeView.UseVisualStyleBackColor = True
        '
        'Overtime_calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1260, 834)
        Me.Controls.Add(Me.changeView)
        Me.Controls.Add(Me.applyForShiftBtn)
        Me.Controls.Add(Me.selectedDate)
        Me.Controls.Add(Me.shiftDetailsTxtBox)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.listOfShifts)
        Me.Controls.Add(Me.calendar)
        Me.Name = "Overtime_calendar"
        Me.Text = "Overtime Shifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents listOfShifts As ListBox
    Friend WithEvents currentUserLabel As Label
    Friend WithEvents shiftDetailsTxtBox As TextBox
    Friend WithEvents selectedDate As Label
    Friend WithEvents applyForShiftBtn As Button
    Friend WithEvents changeView As Button
End Class
