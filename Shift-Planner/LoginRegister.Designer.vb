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
        Me.grpLogin.SuspendLayout()
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
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpLogin.Size = New System.Drawing.Size(263, 155)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'btnSignin
        '
        Me.btnSignin.Location = New System.Drawing.Point(154, 107)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(95, 21)
        Me.btnSignin.TabIndex = 4
        Me.btnSignin.Text = "sign in"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'txtLPass
        '
        Me.txtLPass.Location = New System.Drawing.Point(101, 77)
        Me.txtLPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLPass.Name = "txtLPass"
        Me.txtLPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLPass.Size = New System.Drawing.Size(149, 20)
        Me.txtLPass.TabIndex = 3
        '
        'txtLUser
        '
        Me.txtLUser.Location = New System.Drawing.Point(101, 43)
        Me.txtLUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 175)
        Me.Controls.Add(Me.grpLogin)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LoginRegister"
        Me.Text = "LoginRegister"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents btnSignin As Button
    Friend WithEvents txtLPass As TextBox
    Friend WithEvents txtLUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
