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
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(107, 67)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(149, 27)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'bntAccHol
        '
        Me.bntAccHol.Location = New System.Drawing.Point(12, 12)
        Me.bntAccHol.Name = "bntAccHol"
        Me.bntAccHol.Size = New System.Drawing.Size(100, 50)
        Me.bntAccHol.TabIndex = 8
        Me.bntAccHol.Text = "Accept Holiday"
        Me.bntAccHol.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(132, 12)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(100, 50)
        Me.btnAddEmp.TabIndex = 9
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnAddOT
        '
        Me.btnAddOT.Location = New System.Drawing.Point(252, 12)
        Me.btnAddOT.Name = "btnAddOT"
        Me.btnAddOT.Size = New System.Drawing.Size(100, 50)
        Me.btnAddOT.TabIndex = 10
        Me.btnAddOT.Text = "Add Overtime"
        Me.btnAddOT.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 106)
        Me.Controls.Add(Me.btnAddOT)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Controls.Add(Me.bntAccHol)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents bntAccHol As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnAddOT As Button
End Class
