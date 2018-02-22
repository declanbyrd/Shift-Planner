<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoliday
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
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.btnAddTimeOff = New System.Windows.Forms.Button()
        Me.lstBoxPendHol = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time Off Start:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time Off End:"
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStart.Location = New System.Drawing.Point(98, 44)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(133, 20)
        Me.dtStart.TabIndex = 2
        Me.dtStart.Value = New Date(2018, 2, 21, 0, 0, 0, 0)
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEnd.Location = New System.Drawing.Point(98, 70)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(133, 20)
        Me.dtEnd.TabIndex = 3
        Me.dtEnd.Value = New Date(2018, 2, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reason:"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(98, 97)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(133, 72)
        Me.txtReason.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(98, 17)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(133, 20)
        Me.txtEmployeeID.TabIndex = 7
        '
        'btnAddTimeOff
        '
        Me.btnAddTimeOff.Location = New System.Drawing.Point(156, 175)
        Me.btnAddTimeOff.Name = "btnAddTimeOff"
        Me.btnAddTimeOff.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTimeOff.TabIndex = 8
        Me.btnAddTimeOff.Text = "Apply"
        Me.btnAddTimeOff.UseVisualStyleBackColor = True
        '
        'lstBoxPendHol
        '
        Me.lstBoxPendHol.FormattingEnabled = True
        Me.lstBoxPendHol.Location = New System.Drawing.Point(20, 235)
        Me.lstBoxPendHol.Name = "lstBoxPendHol"
        Me.lstBoxPendHol.Size = New System.Drawing.Size(191, 199)
        Me.lstBoxPendHol.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pending Holiday:"
        '
        'frmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 449)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstBoxPendHol)
        Me.Controls.Add(Me.btnAddTimeOff)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoliday"
        Me.Text = "Holiday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents btnAddTimeOff As Button
    Friend WithEvents lstBoxPendHol As ListBox
    Friend WithEvents Label5 As Label
End Class
