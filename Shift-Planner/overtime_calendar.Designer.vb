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
        Me.rtrnToDshBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendar.Location = New System.Drawing.Point(14, 49)
        Me.calendar.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.calendar.MaxSelectionCount = 1
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 3
        '
        'listOfShifts
        '
        Me.listOfShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfShifts.FormattingEnabled = True
        Me.listOfShifts.ItemHeight = 20
        Me.listOfShifts.Location = New System.Drawing.Point(317, 49)
        Me.listOfShifts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listOfShifts.Name = "listOfShifts"
        Me.listOfShifts.ScrollAlwaysVisible = True
        Me.listOfShifts.Size = New System.Drawing.Size(464, 184)
        Me.listOfShifts.TabIndex = 4
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentUserLabel.Location = New System.Drawing.Point(14, 7)
        Me.currentUserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(81, 22)
        Me.currentUserLabel.TabIndex = 7
        Me.currentUserLabel.Text = "Welcome "
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.BackColor = System.Drawing.Color.White
        Me.shiftDetailsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(46, 252)
        Me.shiftDetailsTxtBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(403, 228)
        Me.shiftDetailsTxtBox.TabIndex = 8
        '
        'selectedDate
        '
        Me.selectedDate.AutoSize = True
        Me.selectedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedDate.Location = New System.Drawing.Point(314, 26)
        Me.selectedDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.selectedDate.Name = "selectedDate"
        Me.selectedDate.Size = New System.Drawing.Size(13, 20)
        Me.selectedDate.TabIndex = 9
        Me.selectedDate.Text = " "
        '
        'applyForShiftBtn
        '
        Me.applyForShiftBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyForShiftBtn.Location = New System.Drawing.Point(596, 492)
        Me.applyForShiftBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.applyForShiftBtn.Name = "applyForShiftBtn"
        Me.applyForShiftBtn.Size = New System.Drawing.Size(115, 37)
        Me.applyForShiftBtn.TabIndex = 10
        Me.applyForShiftBtn.Text = "Apply for Shift"
        Me.applyForShiftBtn.UseVisualStyleBackColor = True
        '
        'changeView
        '
        Me.changeView.Location = New System.Drawing.Point(54, 268)
        Me.changeView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.changeView.Name = "changeView"
        Me.changeView.Size = New System.Drawing.Size(104, 34)
        Me.changeView.TabIndex = 11
        Me.changeView.Text = "CHANGE TO LIST VIEW"
        Me.changeView.UseVisualStyleBackColor = True
        '
        'rtrnToDshBtn
        '
        Me.rtrnToDshBtn.Location = New System.Drawing.Point(54, 324)
        Me.rtrnToDshBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtrnToDshBtn.Name = "rtrnToDshBtn"
        Me.rtrnToDshBtn.Size = New System.Drawing.Size(104, 40)
        Me.rtrnToDshBtn.TabIndex = 12
        Me.rtrnToDshBtn.Text = "Return to Dashboard"
        Me.rtrnToDshBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.shiftDetailsTxtBox)
        Me.Panel1.Location = New System.Drawing.Point(271, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 529)
        Me.Panel1.TabIndex = 13
        '
        'Overtime_calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(813, 546)
        Me.Controls.Add(Me.rtrnToDshBtn)
        Me.Controls.Add(Me.changeView)
        Me.Controls.Add(Me.applyForShiftBtn)
        Me.Controls.Add(Me.selectedDate)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.listOfShifts)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Overtime_calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overtime Shifts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents rtrnToDshBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
