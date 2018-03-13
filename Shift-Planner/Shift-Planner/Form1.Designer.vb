<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLoginForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoginForm
        '
        Me.btnLoginForm.Location = New System.Drawing.Point(37, 73)
        Me.btnLoginForm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLoginForm.Name = "btnLoginForm"
        Me.btnLoginForm.Size = New System.Drawing.Size(156, 37)
        Me.btnLoginForm.TabIndex = 0
        Me.btnLoginForm.Text = "test login form"
        Me.btnLoginForm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 206)
        Me.Controls.Add(Me.btnLoginForm)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoginForm As Button
End Class
