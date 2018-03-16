<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class L
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOType = New System.Windows.Forms.TextBox()
        Me.txtOPay = New System.Windows.Forms.TextBox()
        Me.btnAddOvertime = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtODate = New System.Windows.Forms.DateTimePicker()
        Me.cmbH1 = New System.Windows.Forms.ComboBox()
        Me.CmbH2 = New System.Windows.Forms.ComboBox()
        Me.cmbM1 = New System.Windows.Forms.ComboBox()
        Me.cmbM2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        'dtODate
        '
        Me.dtODate.Location = New System.Drawing.Point(98, 45)
        Me.dtODate.Name = "dtODate"
        Me.dtODate.Size = New System.Drawing.Size(125, 20)
        Me.dtODate.TabIndex = 8
        '
        'cmbH1
        '
        Me.cmbH1.FormattingEnabled = True
        Me.cmbH1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cmbH1.Location = New System.Drawing.Point(98, 74)
        Me.cmbH1.Name = "cmbH1"
        Me.cmbH1.Size = New System.Drawing.Size(38, 21)
        Me.cmbH1.TabIndex = 13
        '
        'CmbH2
        '
        Me.CmbH2.FormattingEnabled = True
        Me.CmbH2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.CmbH2.Location = New System.Drawing.Point(98, 108)
        Me.CmbH2.Name = "CmbH2"
        Me.CmbH2.Size = New System.Drawing.Size(38, 21)
        Me.CmbH2.TabIndex = 14
        '
        'cmbM1
        '
        Me.cmbM1.FormattingEnabled = True
        Me.cmbM1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.cmbM1.Location = New System.Drawing.Point(156, 74)
        Me.cmbM1.Name = "cmbM1"
        Me.cmbM1.Size = New System.Drawing.Size(38, 21)
        Me.cmbM1.TabIndex = 15
        '
        'cmbM2
        '
        Me.cmbM2.FormattingEnabled = True
        Me.cmbM2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.cmbM2.Location = New System.Drawing.Point(156, 108)
        Me.cmbM2.Name = "cmbM2"
        Me.cmbM2.Size = New System.Drawing.Size(38, 21)
        Me.cmbM2.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = ":"
        '
        'l
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 219)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbM2)
        Me.Controls.Add(Me.cmbM1)
        Me.Controls.Add(Me.CmbH2)
        Me.Controls.Add(Me.cmbH1)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnAddOvertime)
        Me.Controls.Add(Me.txtOPay)
        Me.Controls.Add(Me.dtODate)
        Me.Controls.Add(Me.txtOType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "l"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Overtime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOType As TextBox
    Friend WithEvents txtOPay As TextBox
    Friend WithEvents btnAddOvertime As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtODate As DateTimePicker
    Friend WithEvents cmbH1 As ComboBox
    Friend WithEvents CmbH2 As ComboBox
    Friend WithEvents cmbM1 As ComboBox
    Friend WithEvents cmbM2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
