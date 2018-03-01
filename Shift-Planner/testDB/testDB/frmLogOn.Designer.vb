<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogOn
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
        Me.components = New System.ComponentModel.Container()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDBDataSet = New testDB.testDBDataSet()
        Me.TblEmployeeTableAdapter = New testDB.testDBDataSetTableAdapters.tblEmployeeTableAdapter()
        Me.TableAdapterManager = New testDB.testDBDataSetTableAdapters.TableAdapterManager()
        Me.btnLogOn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.TestDBDataSet
        '
        'TestDBDataSet
        '
        Me.TestDBDataSet.DataSetName = "testDBDataSet"
        Me.TestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblEmployeeTableAdapter = Me.TblEmployeeTableAdapter
        Me.TableAdapterManager.UpdateOrder = testDB.testDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnLogOn
        '
        Me.btnLogOn.Location = New System.Drawing.Point(113, 62)
        Me.btnLogOn.Name = "btnLogOn"
        Me.btnLogOn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOn.TabIndex = 0
        Me.btnLogOn.Text = "Log On"
        Me.btnLogOn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(88, 10)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpID.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(88, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 4
        '
        'frmLogOn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 104)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogOn)
        Me.Name = "frmLogOn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log On"
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestDBDataSet As testDBDataSet
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents TblEmployeeTableAdapter As testDBDataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents TableAdapterManager As testDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnLogOn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
