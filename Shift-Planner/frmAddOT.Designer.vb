<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOT
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOType = New System.Windows.Forms.TextBox()
        Me.txtOSTime = New System.Windows.Forms.TextBox()
        Me.dtODate = New System.Windows.Forms.DateTimePicker()
        Me.txtOETime = New System.Windows.Forms.TextBox()
        Me.txtOPay = New System.Windows.Forms.TextBox()
        Me.btnAddOvertime = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Overtime Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Overtime Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pay:"
        '
        'txtOType
        '
        Me.txtOType.Location = New System.Drawing.Point(98, 10)
        Me.txtOType.Name = "txtOType"
        Me.txtOType.Size = New System.Drawing.Size(125, 20)
        Me.txtOType.TabIndex = 5
        '
        'txtOSTime
        '
        Me.txtOSTime.Location = New System.Drawing.Point(98, 74)
        Me.txtOSTime.Name = "txtOSTime"
        Me.txtOSTime.Size = New System.Drawing.Size(125, 20)
        Me.txtOSTime.TabIndex = 7
        '
        'dtODate
        '
        Me.dtODate.Location = New System.Drawing.Point(98, 45)
        Me.dtODate.Name = "dtODate"
        Me.dtODate.Size = New System.Drawing.Size(125, 20)
        Me.dtODate.TabIndex = 8
        '
        'txtOETime
        '
        Me.txtOETime.Location = New System.Drawing.Point(98, 108)
        Me.txtOETime.Name = "txtOETime"
        Me.txtOETime.Size = New System.Drawing.Size(125, 20)
        Me.txtOETime.TabIndex = 9
        '
        'txtOPay
        '
        Me.txtOPay.Location = New System.Drawing.Point(98, 145)
        Me.txtOPay.Name = "txtOPay"
        Me.txtOPay.Size = New System.Drawing.Size(125, 20)
        Me.txtOPay.TabIndex = 10
        '
        'btnAddOvertime
        '
        Me.btnAddOvertime.Location = New System.Drawing.Point(124, 185)
        Me.btnAddOvertime.Name = "btnAddOvertime"
        Me.btnAddOvertime.Size = New System.Drawing.Size(99, 23)
        Me.btnAddOvertime.TabIndex = 11
        Me.btnAddOvertime.Text = "Add Overtime"
        Me.btnAddOvertime.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Location = New System.Drawing.Point(16, 185)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(99, 23)
        Me.btnDashboard.TabIndex = 12
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'frmAddOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnAddOvertime)
        Me.Controls.Add(Me.txtOPay)
        Me.Controls.Add(Me.txtOETime)
        Me.Controls.Add(Me.dtODate)
        Me.Controls.Add(Me.txtOSTime)
        Me.Controls.Add(Me.txtOType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddOT"
        Me.Text = "Add Overtime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOType As TextBox
    Friend WithEvents txtOSTime As TextBox
    Friend WithEvents dtODate As DateTimePicker
    Friend WithEvents txtOETime As TextBox
    Friend WithEvents txtOPay As TextBox
    Friend WithEvents btnAddOvertime As Button
    Friend WithEvents btnDashboard As Button
End Class
