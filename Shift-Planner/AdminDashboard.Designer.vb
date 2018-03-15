<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.bntAccHol = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnAddOT = New System.Windows.Forms.Button()
        Me.lblAnnouncements = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(16, 216)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(299, 33)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'bntAccHol
        '
        Me.bntAccHol.Location = New System.Drawing.Point(16, 95)
        Me.bntAccHol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bntAccHol.Name = "bntAccHol"
        Me.bntAccHol.Size = New System.Drawing.Size(299, 33)
        Me.bntAccHol.TabIndex = 8
        Me.bntAccHol.Text = "Accept Holiday"
        Me.bntAccHol.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(16, 136)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(299, 33)
        Me.btnAddEmp.TabIndex = 9
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnAddOT
        '
        Me.btnAddOT.Location = New System.Drawing.Point(16, 177)
        Me.btnAddOT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddOT.Name = "btnAddOT"
        Me.btnAddOT.Size = New System.Drawing.Size(299, 33)
        Me.btnAddOT.TabIndex = 10
        Me.btnAddOT.Text = "Add Overtime"
        Me.btnAddOT.UseVisualStyleBackColor = True
        '
        'lblAnnouncements
        '
        Me.lblAnnouncements.AutoSize = True
        Me.lblAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnouncements.Location = New System.Drawing.Point(20, 54)
        Me.lblAnnouncements.MinimumSize = New System.Drawing.Size(290, 30)
        Me.lblAnnouncements.Name = "lblAnnouncements"
        Me.lblAnnouncements.Size = New System.Drawing.Size(290, 30)
        Me.lblAnnouncements.TabIndex = 11
        Me.lblAnnouncements.Text = "No announcements"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 260)
        Me.Controls.Add(Me.lblAnnouncements)
        Me.Controls.Add(Me.btnAddOT)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Controls.Add(Me.bntAccHol)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents bntAccHol As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnAddOT As Button
    Friend WithEvents lblAnnouncements As Label
End Class
