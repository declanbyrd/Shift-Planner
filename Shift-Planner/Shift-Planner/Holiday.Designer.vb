<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holiday
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lstBoxAccHoll = New System.Windows.Forms.ListBox()
        Me.lstBoxPendHol = New System.Windows.Forms.ListBox()
        Me.btnAddTimeOff = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time Off Start:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time Off End:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Reason:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(88, 6)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(152, 20)
        Me.txtEmployeeID.TabIndex = 4
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(88, 37)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(152, 20)
        Me.dtStart.TabIndex = 5
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(88, 73)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(152, 20)
        Me.dtEnd.TabIndex = 6
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(88, 114)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(152, 71)
        Me.txtReason.TabIndex = 7
        '
        'lstBoxAccHoll
        '
        Me.lstBoxAccHoll.FormattingEnabled = True
        Me.lstBoxAccHoll.Location = New System.Drawing.Point(314, 37)
        Me.lstBoxAccHoll.Name = "lstBoxAccHoll"
        Me.lstBoxAccHoll.Size = New System.Drawing.Size(447, 173)
        Me.lstBoxAccHoll.TabIndex = 8
        '
        'lstBoxPendHol
        '
        Me.lstBoxPendHol.FormattingEnabled = True
        Me.lstBoxPendHol.Location = New System.Drawing.Point(314, 270)
        Me.lstBoxPendHol.Name = "lstBoxPendHol"
        Me.lstBoxPendHol.Size = New System.Drawing.Size(447, 173)
        Me.lstBoxPendHol.TabIndex = 9
        '
        'btnAddTimeOff
        '
        Me.btnAddTimeOff.Location = New System.Drawing.Point(165, 191)
        Me.btnAddTimeOff.Name = "btnAddTimeOff"
        Me.btnAddTimeOff.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTimeOff.TabIndex = 10
        Me.btnAddTimeOff.Text = "Apply"
        Me.btnAddTimeOff.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Accepted Holidays:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pending Holidays:"
        '
        'Holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 456)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAddTimeOff)
        Me.Controls.Add(Me.lstBoxPendHol)
        Me.Controls.Add(Me.lstBoxAccHoll)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Holiday"
        Me.Text = "Holiday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents txtReason As TextBox
    Friend WithEvents lstBoxAccHoll As ListBox
    Friend WithEvents lstBoxPendHol As ListBox
    Friend WithEvents btnAddTimeOff As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
