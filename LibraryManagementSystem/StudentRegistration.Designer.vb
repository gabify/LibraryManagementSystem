<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegistration
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtyearLevel = New System.Windows.Forms.TextBox()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsrcode = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Year Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sr-code"
        '
        'txtyearLevel
        '
        Me.txtyearLevel.Location = New System.Drawing.Point(12, 152)
        Me.txtyearLevel.Name = "txtyearLevel"
        Me.txtyearLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtyearLevel.TabIndex = 11
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(12, 115)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(100, 20)
        Me.txtcourse.TabIndex = 10
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(12, 77)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 9
        '
        'txtsrcode
        '
        Me.txtsrcode.Location = New System.Drawing.Point(12, 39)
        Me.txtsrcode.Name = "txtsrcode"
        Me.txtsrcode.Size = New System.Drawing.Size(100, 20)
        Me.txtsrcode.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(15, 197)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(15, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 303)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtyearLevel)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtsrcode)
        Me.Name = "StudentRegistration"
        Me.Text = "StudentRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtyearLevel As TextBox
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtsrcode As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
End Class
