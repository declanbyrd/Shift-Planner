<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginRegister
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
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.txtLPass = New System.Windows.Forms.TextBox()
        Me.txtLUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpRegister = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtRPass = New System.Windows.Forms.TextBox()
        Me.txtRUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.grpLogin.Location = New System.Drawing.Point(9, 10)
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLogin.Size = New System.Drawing.Size(263, 155)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'btnSignin
        '
        Me.btnSignin.Location = New System.Drawing.Point(154, 107)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(95, 21)
        Me.btnSignin.TabIndex = 4
        Me.btnSignin.Text = "sign in"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'txtLPass
        '
        Me.txtLPass.Location = New System.Drawing.Point(101, 77)
        Me.txtLPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLPass.Name = "txtLPass"
        Me.txtLPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLPass.Size = New System.Drawing.Size(149, 20)
        Me.txtLPass.TabIndex = 3
        '
        'txtLUser
        '
        Me.txtLUser.Location = New System.Drawing.Point(101, 43)
        Me.txtLUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLUser.Name = "txtLUser"
        Me.txtLUser.Size = New System.Drawing.Size(149, 20)
        Me.txtLUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'grpRegister
        '
        Me.grpRegister.Controls.Add(Me.btnRegister)
        Me.grpRegister.Controls.Add(Me.txtRPass)
        Me.grpRegister.Controls.Add(Me.txtRUser)
        Me.grpRegister.Controls.Add(Me.Label3)
        Me.grpRegister.Controls.Add(Me.Label4)
        Me.grpRegister.Enabled = False
        Me.grpRegister.Location = New System.Drawing.Point(277, 10)
        Me.grpRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.grpRegister.Name = "grpRegister"
        Me.grpRegister.Padding = New System.Windows.Forms.Padding(2)
        Me.grpRegister.Size = New System.Drawing.Size(263, 155)
        Me.grpRegister.TabIndex = 6
        Me.grpRegister.TabStop = False
        Me.grpRegister.Text = "Register"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(154, 107)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(95, 21)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtRPass
        '
        Me.txtRPass.Location = New System.Drawing.Point(101, 77)
        Me.txtRPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRPass.Name = "txtRPass"
        Me.txtRPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPass.Size = New System.Drawing.Size(149, 20)
        Me.txtRPass.TabIndex = 3
        '
        'txtRUser
        '
        Me.txtRUser.Location = New System.Drawing.Point(101, 43)
        Me.txtRUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRUser.Name = "txtRUser"
        Me.txtRUser.Size = New System.Drawing.Size(149, 20)
        Me.txtRUser.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username"
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 175)
        Me.Controls.Add(Me.grpRegister)
        Me.Controls.Add(Me.grpLogin)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
