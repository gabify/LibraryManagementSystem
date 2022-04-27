<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facultyRegistration
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemployeeName = New System.Windows.Forms.TextBox()
        Me.txtemployeeNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(25, 143)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(25, 101)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 26
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Employee Number"
        '
        'txtemployeeName
        '
        Me.txtemployeeName.Location = New System.Drawing.Point(22, 63)
        Me.txtemployeeName.Name = "txtemployeeName"
        Me.txtemployeeName.Size = New System.Drawing.Size(100, 20)
        Me.txtemployeeName.TabIndex = 19
        '
        'txtemployeeNum
        '
        Me.txtemployeeNum.Location = New System.Drawing.Point(22, 25)
        Me.txtemployeeNum.Name = "txtemployeeNum"
        Me.txtemployeeNum.Size = New System.Drawing.Size(100, 20)
        Me.txtemployeeNum.TabIndex = 18
        '
        'facultyRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemployeeName)
        Me.Controls.Add(Me.txtemployeeNum)
        Me.Name = "facultyRegistration"
        Me.Text = "facultyRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemployeeName As TextBox
    Friend WithEvents txtemployeeNum As TextBox
End Class
