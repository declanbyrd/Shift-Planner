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
        Me.listOfShifts = New System.Windows.Forms.ListBox()
        Me.shiftDetailsTxtBox = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.Label()
        Me.applybtn = New System.Windows.Forms.Button()
        Me.currentUserLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listLabel
        '
        Me.listLabel.AutoSize = True
        Me.listLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listLabel.Location = New System.Drawing.Point(13, 21)
        Me.listLabel.Name = "listLabel"
        Me.listLabel.Size = New System.Drawing.Size(236, 25)
        Me.listLabel.TabIndex = 2
        Me.listLabel.Text = "Available Overtime Shifts:"
        '
        'listOfShifts
        '
        Me.listOfShifts.FormattingEnabled = True
        Me.listOfShifts.ItemHeight = 16
        Me.listOfShifts.Location = New System.Drawing.Point(19, 85)
        Me.listOfShifts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listOfShifts.MultiColumn = True
        Me.listOfShifts.Name = "listOfShifts"
        Me.listOfShifts.Size = New System.Drawing.Size(459, 644)
        Me.listOfShifts.TabIndex = 4
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.shiftDetailsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(547, 85)
        Me.shiftDetailsTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(485, 279)
        Me.shiftDetailsTxtBox.TabIndex = 5
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.AutoSize = True
        Me.txtEmployeeID.Location = New System.Drawing.Point(952, 21)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(12, 17)
        Me.txtEmployeeID.TabIndex = 6
        Me.txtEmployeeID.Text = " "
        '
        'applybtn
        '
        Me.applybtn.Location = New System.Drawing.Point(560, 312)
        Me.applybtn.Name = "applybtn"
        Me.applybtn.Size = New System.Drawing.Size(121, 41)
        Me.applybtn.TabIndex = 7
        Me.applybtn.Text = "Apply for shift"
        Me.applybtn.UseVisualStyleBackColor = True
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.Location = New System.Drawing.Point(846, 20)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(12, 17)
        Me.currentUserLabel.TabIndex = 8
        Me.currentUserLabel.Text = " "
        '
        'overtime_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 782)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.applybtn)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.shiftDetailsTxtBox)
        Me.Controls.Add(Me.listOfShifts)
        Me.Controls.Add(Me.listLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "overtime_list"
        Me.Text = "Overtime Shifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listLabel As Label
    Friend WithEvents listOfShifts As ListBox
    Friend WithEvents shiftDetailsTxtBox As TextBox
    Friend WithEvents txtEmployeeID As Label
    Friend WithEvents applybtn As Button
    Friend WithEvents currentUserLabel As Label
End Class
