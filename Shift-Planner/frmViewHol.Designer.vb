<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewHol
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
        Me.lstBoxHol = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHolInfo = New System.Windows.Forms.TextBox()
        Me.chkBoxAcc = New System.Windows.Forms.CheckBox()
        Me.btnAccHol = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxHol
        '
        Me.lstBoxHol.FormattingEnabled = True
        Me.lstBoxHol.Location = New System.Drawing.Point(16, 29)
        Me.lstBoxHol.Name = "lstBoxHol"
        Me.lstBoxHol.Size = New System.Drawing.Size(350, 407)
        Me.lstBoxHol.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pending Holiday:"
        '
        'txtHolInfo
        '
        Me.txtHolInfo.Enabled = False
        Me.txtHolInfo.Location = New System.Drawing.Point(373, 29)
        Me.txtHolInfo.Multiline = True
        Me.txtHolInfo.Name = "txtHolInfo"
        Me.txtHolInfo.Size = New System.Drawing.Size(217, 155)
        Me.txtHolInfo.TabIndex = 2
        '
        'chkBoxAcc
        '
        Me.chkBoxAcc.AutoSize = True
        Me.chkBoxAcc.Location = New System.Drawing.Point(373, 191)
        Me.chkBoxAcc.Name = "chkBoxAcc"
        Me.chkBoxAcc.Size = New System.Drawing.Size(104, 17)
        Me.chkBoxAcc.TabIndex = 3
        Me.chkBoxAcc.Text = "Agree to Holiday"
        Me.chkBoxAcc.UseVisualStyleBackColor = True
        '
        'btnAccHol
        '
        Me.btnAccHol.Enabled = False
        Me.btnAccHol.Location = New System.Drawing.Point(483, 215)
        Me.btnAccHol.Name = "btnAccHol"
        Me.btnAccHol.Size = New System.Drawing.Size(106, 23)
        Me.btnAccHol.TabIndex = 4
        Me.btnAccHol.Text = "Accept Holiday"
        Me.btnAccHol.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Location = New System.Drawing.Point(515, 415)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(75, 23)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'frmViewHol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 450)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnAccHol)
        Me.Controls.Add(Me.chkBoxAcc)
        Me.Controls.Add(Me.txtHolInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBoxHol)
        Me.Name = "frmViewHol"
        Me.Text = "View Holiday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBoxHol As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHolInfo As TextBox
    Friend WithEvents chkBoxAcc As CheckBox
    Friend WithEvents btnAccHol As Button
    Friend WithEvents btnDashboard As Button
End Class
