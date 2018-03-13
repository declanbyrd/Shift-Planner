<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginRegister
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
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLUser = New System.Windows.Forms.TextBox()
        Me.txtLPass = New System.Windows.Forms.TextBox()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.grpRegister = New System.Windows.Forms.GroupBox()
        Me.txtRPass = New System.Windows.Forms.TextBox()
        Me.txtRUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.grpLogin.SuspendLayout()
        Me.grpRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.btnSignin)
        Me.grpLogin.Controls.Add(Me.txtLPass)
        Me.grpLogin.Controls.Add(Me.txtLUser)
        Me.grpLogin.Controls.Add(Me.Label2)
        Me.grpLogin.Controls.Add(Me.Label1)
        Me.grpLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(351, 191)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtLUser
        '
        Me.txtLUser.Location = New System.Drawing.Point(135, 53)
        Me.txtLUser.Name = "txtLUser"
        Me.txtLUser.Size = New System.Drawing.Size(197, 22)
        Me.txtLUser.TabIndex = 2
        '
        'txtLPass
        '
        Me.txtLPass.Location = New System.Drawing.Point(135, 95)
        Me.txtLPass.Name = "txtLPass"
        Me.txtLPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLPass.Size = New System.Drawing.Size(197, 22)
        Me.txtLPass.TabIndex = 3
        '
        'btnSignin
        '
        Me.btnSignin.Location = New System.Drawing.Point(205, 132)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(127, 26)
        Me.btnSignin.TabIndex = 4
        Me.btnSignin.Text = "sign in"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'grpRegister
        '
        Me.grpRegister.Controls.Add(Me.btnRegister)
        Me.grpRegister.Controls.Add(Me.txtRPass)
        Me.grpRegister.Controls.Add(Me.txtRUser)
        Me.grpRegister.Controls.Add(Me.Label3)
        Me.grpRegister.Controls.Add(Me.Label4)
        Me.grpRegister.Enabled = False
        Me.grpRegister.Location = New System.Drawing.Point(369, 12)
        Me.grpRegister.Name = "grpRegister"
        Me.grpRegister.Size = New System.Drawing.Size(351, 191)
        Me.grpRegister.TabIndex = 6
        Me.grpRegister.TabStop = False
        Me.grpRegister.Text = "Register"
        '
        'txtRPass
        '
        Me.txtRPass.Location = New System.Drawing.Point(135, 95)
        Me.txtRPass.Name = "txtRPass"
        Me.txtRPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPass.Size = New System.Drawing.Size(197, 22)
        Me.txtRPass.TabIndex = 3
        '
        'txtRUser
        '
        Me.txtRUser.Location = New System.Drawing.Point(135, 53)
        Me.txtRUser.Name = "txtRUser"
        Me.txtRUser.Size = New System.Drawing.Size(197, 22)
        Me.txtRUser.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(205, 132)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(127, 26)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 215)
        Me.Controls.Add(Me.grpRegister)
        Me.Controls.Add(Me.grpLogin)
        Me.Name = "LoginRegister"
        Me.Text = "LoginRegister"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.grpRegister.ResumeLayout(False)
        Me.grpRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents btnSignin As Button
    Friend WithEvents txtLPass As TextBox
    Friend WithEvents txtLUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpRegister As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtRPass As TextBox
    Friend WithEvents txtRUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
=======
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Text = "LoginRegister"
    End Sub
End Class
