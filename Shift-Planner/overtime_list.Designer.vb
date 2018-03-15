<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class overtime_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.listLabel = New System.Windows.Forms.Label()
        Me.listOfShifts2 = New System.Windows.Forms.ListBox()
        Me.shiftDetailsTxtBox = New System.Windows.Forms.TextBox()
        Me.applybtn = New System.Windows.Forms.Button()
        Me.currentUserLabel = New System.Windows.Forms.Label()
        Me.changeView = New System.Windows.Forms.Button()
        Me.rtrnToDshBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listLabel
        '
        Me.listLabel.AutoSize = True
        Me.listLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listLabel.Location = New System.Drawing.Point(10, 17)
        Me.listLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.listLabel.Name = "listLabel"
        Me.listLabel.Size = New System.Drawing.Size(188, 20)
        Me.listLabel.TabIndex = 2
        Me.listLabel.Text = "Available Overtime Shifts:"
        '
        'listOfShifts2
        '
        Me.listOfShifts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfShifts2.FormattingEnabled = True
        Me.listOfShifts2.ItemHeight = 17
        Me.listOfShifts2.Location = New System.Drawing.Point(14, 69)
        Me.listOfShifts2.Margin = New System.Windows.Forms.Padding(2)
        Me.listOfShifts2.MultiColumn = True
        Me.listOfShifts2.Name = "listOfShifts2"
        Me.listOfShifts2.Size = New System.Drawing.Size(498, 497)
        Me.listOfShifts2.TabIndex = 4
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.BackColor = System.Drawing.Color.White
        Me.shiftDetailsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(556, 69)
        Me.shiftDetailsTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(364, 227)
        Me.shiftDetailsTxtBox.TabIndex = 5
        '
        'applybtn
        '
        Me.applybtn.Location = New System.Drawing.Point(822, 254)
        Me.applybtn.Margin = New System.Windows.Forms.Padding(2)
        Me.applybtn.Name = "applybtn"
        Me.applybtn.Size = New System.Drawing.Size(91, 33)
        Me.applybtn.TabIndex = 7
        Me.applybtn.Text = "Apply for shift"
        Me.applybtn.UseVisualStyleBackColor = True
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentUserLabel.Location = New System.Drawing.Point(750, 23)
        Me.currentUserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(72, 19)
        Me.currentUserLabel.TabIndex = 8
        Me.currentUserLabel.Text = " Welcome"
        '
        'changeView
        '
        Me.changeView.Location = New System.Drawing.Point(688, 439)
        Me.changeView.Margin = New System.Windows.Forms.Padding(2)
        Me.changeView.Name = "changeView"
        Me.changeView.Size = New System.Drawing.Size(102, 45)
        Me.changeView.TabIndex = 9
        Me.changeView.Text = "CHANGE TO CALENDAR VIEW"
        Me.changeView.UseVisualStyleBackColor = True
        '
        'rtrnToDshBtn
        '
        Me.rtrnToDshBtn.Location = New System.Drawing.Point(686, 503)
        Me.rtrnToDshBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.rtrnToDshBtn.Name = "rtrnToDshBtn"
        Me.rtrnToDshBtn.Size = New System.Drawing.Size(104, 40)
        Me.rtrnToDshBtn.TabIndex = 13
        Me.rtrnToDshBtn.Text = "Return to Dashboard"
        Me.rtrnToDshBtn.UseVisualStyleBackColor = True
        '
        'overtime_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(945, 635)
        Me.Controls.Add(Me.rtrnToDshBtn)
        Me.Controls.Add(Me.changeView)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.applybtn)
        Me.Controls.Add(Me.shiftDetailsTxtBox)
        Me.Controls.Add(Me.listOfShifts2)
        Me.Controls.Add(Me.listLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "overtime_list"
        Me.Text = "Overtime Shifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listLabel As Label
    Friend WithEvents listOfShifts2 As ListBox
    Friend WithEvents shiftDetailsTxtBox As TextBox
    Friend WithEvents applybtn As Button
    Friend WithEvents currentUserLabel As Label
    Friend WithEvents changeView As Button
    Friend WithEvents rtrnToDshBtn As Button
End Class
