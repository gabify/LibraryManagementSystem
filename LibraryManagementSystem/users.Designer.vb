<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.combousertype = New System.Windows.Forms.ComboBox()
        Me.txtretry = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeOfUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.combousertype)
        Me.GroupBox1.Controls.Add(Me.txtretry)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(124, 315)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "User Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Retry Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(10, 315)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(124, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update User"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'combousertype
        '
        Me.combousertype.FormattingEnabled = True
        Me.combousertype.Location = New System.Drawing.Point(10, 223)
        Me.combousertype.Name = "combousertype"
        Me.combousertype.Size = New System.Drawing.Size(189, 21)
        Me.combousertype.TabIndex = 3
        '
        'txtretry
        '
        Me.txtretry.Location = New System.Drawing.Point(9, 169)
        Me.txtretry.Name = "txtretry"
        Me.txtretry.Size = New System.Drawing.Size(190, 20)
        Me.txtretry.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(9, 102)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(190, 20)
        Me.txtpassword.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(9, 39)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(190, 20)
        Me.txtusername.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.username, Me.password, Me.typeOfUser})
        Me.DataGridView1.Location = New System.Drawing.Point(281, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(325, 393)
        Me.DataGridView1.TabIndex = 1
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 80
        '
        'password
        '
        Me.password.DataPropertyName = "password"
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        '
        'typeOfUser
        '
        Me.typeOfUser.DataPropertyName = "userType"
        Me.typeOfUser.HeaderText = "User Type"
        Me.typeOfUser.Name = "typeOfUser"
        Me.typeOfUser.ReadOnly = True
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 424)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents combousertype As ComboBox
    Friend WithEvents txtretry As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents typeOfUser As DataGridViewTextBoxColumn
End Class
