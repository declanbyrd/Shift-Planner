<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChange
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtCurrentPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(218, 144)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(127, 26)
        Me.btnChange.TabIndex = 13
        Me.btnChange.Text = "change password"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(148, 67)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(197, 22)
        Me.txtNewPass.TabIndex = 12
        '
        'txtCurrentPass
        '
        Me.txtCurrentPass.Location = New System.Drawing.Point(148, 25)
        Me.txtCurrentPass.Name = "txtCurrentPass"
        Me.txtCurrentPass.Size = New System.Drawing.Size(197, 22)
        Me.txtCurrentPass.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Current password"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(148, 109)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(197, 22)
        Me.txtConfirmPass.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Confirm password"
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 182)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtCurrentPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "PasswordChange"
        Me.Text = "PasswordChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtCurrentPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label1 As Label
End Class
