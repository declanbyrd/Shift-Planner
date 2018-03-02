<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddDB = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Labelll = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(75, 32)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(100, 20)
        Me.txtSName.TabIndex = 2
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(75, 6)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 20)
        Me.txtFName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Surname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Forename:"
        '
        'btnAddDB
        '
        Me.btnAddDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddDB.Location = New System.Drawing.Point(75, 85)
        Me.btnAddDB.Name = "btnAddDB"
        Me.btnAddDB.Size = New System.Drawing.Size(100, 23)
        Me.btnAddDB.TabIndex = 4
        Me.btnAddDB.Text = "Add To Database"
        Me.btnAddDB.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(74, 59)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Labelll
        '
        Me.Labelll.AutoSize = True
        Me.Labelll.Location = New System.Drawing.Point(13, 62)
        Me.Labelll.Name = "Labelll"
        Me.Labelll.Size = New System.Drawing.Size(56, 13)
        Me.Labelll.TabIndex = 11
        Me.Labelll.Text = "Password:"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 178)
        Me.Controls.Add(Me.Labelll)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddDB)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard - Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddDB As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Labelll As Label
End Class
