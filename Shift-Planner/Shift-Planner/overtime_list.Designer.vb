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
        Me.applybtn = New System.Windows.Forms.Button()
        Me.currentUserLabel = New System.Windows.Forms.Label()
        Me.changeView = New System.Windows.Forms.Button()
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
        Me.listOfShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfShifts.FormattingEnabled = True
        Me.listOfShifts.ItemHeight = 20
        Me.listOfShifts.Location = New System.Drawing.Point(19, 85)
        Me.listOfShifts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listOfShifts.MultiColumn = True
        Me.listOfShifts.Name = "listOfShifts"
        Me.listOfShifts.Size = New System.Drawing.Size(663, 624)
        Me.listOfShifts.TabIndex = 4
        '
        'shiftDetailsTxtBox
        '
        Me.shiftDetailsTxtBox.BackColor = System.Drawing.Color.White
        Me.shiftDetailsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shiftDetailsTxtBox.Enabled = False
        Me.shiftDetailsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftDetailsTxtBox.Location = New System.Drawing.Point(742, 85)
        Me.shiftDetailsTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.shiftDetailsTxtBox.Multiline = True
        Me.shiftDetailsTxtBox.Name = "shiftDetailsTxtBox"
        Me.shiftDetailsTxtBox.ReadOnly = True
        Me.shiftDetailsTxtBox.Size = New System.Drawing.Size(485, 279)
        Me.shiftDetailsTxtBox.TabIndex = 5
        '
        'applybtn
        '
        Me.applybtn.Location = New System.Drawing.Point(1096, 312)
        Me.applybtn.Name = "applybtn"
        Me.applybtn.Size = New System.Drawing.Size(121, 41)
        Me.applybtn.TabIndex = 7
        Me.applybtn.Text = "Apply for shift"
        Me.applybtn.UseVisualStyleBackColor = True
        '
        'currentUserLabel
        '
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentUserLabel.Location = New System.Drawing.Point(1000, 28)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(86, 22)
        Me.currentUserLabel.TabIndex = 8
        Me.currentUserLabel.Text = " Welcome"
        '
        'changeView
        '
        Me.changeView.Location = New System.Drawing.Point(917, 540)
        Me.changeView.Name = "changeView"
        Me.changeView.Size = New System.Drawing.Size(136, 55)
        Me.changeView.TabIndex = 9
        Me.changeView.Text = "CHANGE TO CALENDAR VIEW"
        Me.changeView.UseVisualStyleBackColor = True
        '
        'overtime_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1260, 834)
        Me.Controls.Add(Me.changeView)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.applybtn)
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
    Friend WithEvents applybtn As Button
    Friend WithEvents currentUserLabel As Label
    Friend WithEvents changeView As Button
End Class
