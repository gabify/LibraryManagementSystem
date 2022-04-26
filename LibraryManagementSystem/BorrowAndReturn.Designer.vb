<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowAndReturn
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.borrow = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtsrcode = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtyearLevel = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAccessionNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnrefreshbook = New System.Windows.Forms.Button()
        Me.btnSearchbook = New System.Windows.Forms.Button()
        Me.txtsearchbook = New System.Windows.Forms.TextBox()
        Me.btnRefreshStudent = New System.Windows.Forms.Button()
        Me.btnstudentSearch = New System.Windows.Forms.Button()
        Me.txtsearchStudent = New System.Windows.Forms.TextBox()
        Me.rdacccesionNum = New System.Windows.Forms.RadioButton()
        Me.rdTitle = New System.Windows.Forms.RadioButton()
        Me.rdName = New System.Windows.Forms.RadioButton()
        Me.rdsrcode = New System.Windows.Forms.RadioButton()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acccesnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowedBooks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.borrow.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.borrow)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 489)
        Me.TabControl1.TabIndex = 0
        '
        'borrow
        '
        Me.borrow.Controls.Add(Me.GroupBox4)
        Me.borrow.Controls.Add(Me.GroupBox3)
        Me.borrow.Controls.Add(Me.btnCancel)
        Me.borrow.Controls.Add(Me.btnBorrow)
        Me.borrow.Controls.Add(Me.GroupBox2)
        Me.borrow.Controls.Add(Me.GroupBox1)
        Me.borrow.Location = New System.Drawing.Point(4, 22)
        Me.borrow.Name = "borrow"
        Me.borrow.Padding = New System.Windows.Forms.Padding(3)
        Me.borrow.Size = New System.Drawing.Size(1251, 463)
        Me.borrow.TabIndex = 0
        Me.borrow.Text = "Borrow"
        Me.borrow.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1251, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtyearLevel)
        Me.GroupBox1.Controls.Add(Me.txtcourse)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtsrcode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower's Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.txtAccessionNum)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Info"
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(22, 354)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrow.TabIndex = 2
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(305, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdTitle)
        Me.GroupBox3.Controls.Add(Me.rdacccesionNum)
        Me.GroupBox3.Controls.Add(Me.btnrefreshbook)
        Me.GroupBox3.Controls.Add(Me.btnSearchbook)
        Me.GroupBox3.Controls.Add(Me.txtsearchbook)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(413, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 446)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdName)
        Me.GroupBox4.Controls.Add(Me.rdsrcode)
        Me.GroupBox4.Controls.Add(Me.btnRefreshStudent)
        Me.GroupBox4.Controls.Add(Me.btnstudentSearch)
        Me.GroupBox4.Controls.Add(Me.txtsearchStudent)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(902, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 446)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookId, Me.acccesnum, Me.title, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(450, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.studentId, Me.srcode, Me.studentName, Me.borrowedBooks, Me.course, Me.yearLevel})
        Me.DataGridView2.Location = New System.Drawing.Point(0, 93)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(339, 353)
        Me.DataGridView2.TabIndex = 1
        '
        'txtsrcode
        '
        Me.txtsrcode.Location = New System.Drawing.Point(14, 39)
        Me.txtsrcode.Name = "txtsrcode"
        Me.txtsrcode.Size = New System.Drawing.Size(100, 20)
        Me.txtsrcode.TabIndex = 0
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(14, 77)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 1
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(14, 115)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(100, 20)
        Me.txtcourse.TabIndex = 2
        '
        'txtyearLevel
        '
        Me.txtyearLevel.Location = New System.Drawing.Point(14, 152)
        Me.txtyearLevel.Name = "txtyearLevel"
        Me.txtyearLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtyearLevel.TabIndex = 3
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(13, 79)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 5
        '
        'txtAccessionNum
        '
        Me.txtAccessionNum.Location = New System.Drawing.Point(13, 39)
        Me.txtAccessionNum.Name = "txtAccessionNum"
        Me.txtAccessionNum.Size = New System.Drawing.Size(100, 20)
        Me.txtAccessionNum.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sr-code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Title"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Accession Number"
        '
        'btnrefreshbook
        '
        Me.btnrefreshbook.Location = New System.Drawing.Point(371, 14)
        Me.btnrefreshbook.Name = "btnrefreshbook"
        Me.btnrefreshbook.Size = New System.Drawing.Size(75, 23)
        Me.btnrefreshbook.TabIndex = 11
        Me.btnrefreshbook.Text = "Refresh"
        Me.btnrefreshbook.UseVisualStyleBackColor = True
        '
        'btnSearchbook
        '
        Me.btnSearchbook.Location = New System.Drawing.Point(290, 14)
        Me.btnSearchbook.Name = "btnSearchbook"
        Me.btnSearchbook.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchbook.TabIndex = 10
        Me.btnSearchbook.Text = "Search"
        Me.btnSearchbook.UseVisualStyleBackColor = True
        '
        'txtsearchbook
        '
        Me.txtsearchbook.Location = New System.Drawing.Point(53, 15)
        Me.txtsearchbook.Name = "txtsearchbook"
        Me.txtsearchbook.Size = New System.Drawing.Size(227, 20)
        Me.txtsearchbook.TabIndex = 9
        '
        'btnRefreshStudent
        '
        Me.btnRefreshStudent.Location = New System.Drawing.Point(261, 16)
        Me.btnRefreshStudent.Name = "btnRefreshStudent"
        Me.btnRefreshStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshStudent.TabIndex = 11
        Me.btnRefreshStudent.Text = "Refresh"
        Me.btnRefreshStudent.UseVisualStyleBackColor = True
        '
        'btnstudentSearch
        '
        Me.btnstudentSearch.Location = New System.Drawing.Point(180, 16)
        Me.btnstudentSearch.Name = "btnstudentSearch"
        Me.btnstudentSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnstudentSearch.TabIndex = 10
        Me.btnstudentSearch.Text = "Search"
        Me.btnstudentSearch.UseVisualStyleBackColor = True
        '
        'txtsearchStudent
        '
        Me.txtsearchStudent.Location = New System.Drawing.Point(9, 17)
        Me.txtsearchStudent.Name = "txtsearchStudent"
        Me.txtsearchStudent.Size = New System.Drawing.Size(161, 20)
        Me.txtsearchStudent.TabIndex = 9
        '
        'rdacccesionNum
        '
        Me.rdacccesionNum.AutoSize = True
        Me.rdacccesionNum.Location = New System.Drawing.Point(53, 46)
        Me.rdacccesionNum.Name = "rdacccesionNum"
        Me.rdacccesionNum.Size = New System.Drawing.Size(114, 17)
        Me.rdacccesionNum.TabIndex = 12
        Me.rdacccesionNum.TabStop = True
        Me.rdacccesionNum.Text = "Accession Number"
        Me.rdacccesionNum.UseVisualStyleBackColor = True
        '
        'rdTitle
        '
        Me.rdTitle.AutoSize = True
        Me.rdTitle.Location = New System.Drawing.Point(190, 45)
        Me.rdTitle.Name = "rdTitle"
        Me.rdTitle.Size = New System.Drawing.Size(45, 17)
        Me.rdTitle.TabIndex = 13
        Me.rdTitle.TabStop = True
        Me.rdTitle.Text = "Title"
        Me.rdTitle.UseVisualStyleBackColor = True
        '
        'rdName
        '
        Me.rdName.AutoSize = True
        Me.rdName.Location = New System.Drawing.Point(149, 45)
        Me.rdName.Name = "rdName"
        Me.rdName.Size = New System.Drawing.Size(53, 17)
        Me.rdName.TabIndex = 15
        Me.rdName.TabStop = True
        Me.rdName.Text = "Name"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdsrcode
        '
        Me.rdsrcode.AutoSize = True
        Me.rdsrcode.Location = New System.Drawing.Point(12, 46)
        Me.rdsrcode.Name = "rdsrcode"
        Me.rdsrcode.Size = New System.Drawing.Size(65, 17)
        Me.rdsrcode.TabIndex = 14
        Me.rdsrcode.TabStop = True
        Me.rdsrcode.Text = "Sr- code"
        Me.rdsrcode.UseVisualStyleBackColor = True
        '
        'bookId
        '
        Me.bookId.DataPropertyName = "ID"
        Me.bookId.HeaderText = "id"
        Me.bookId.Name = "bookId"
        Me.bookId.ReadOnly = True
        Me.bookId.Visible = False
        '
        'acccesnum
        '
        Me.acccesnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.acccesnum.DataPropertyName = "accessionNum"
        Me.acccesnum.HeaderText = "Accession Number"
        Me.acccesnum.Name = "acccesnum"
        Me.acccesnum.ReadOnly = True
        Me.acccesnum.Width = 111
        '
        'title
        '
        Me.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.title.DataPropertyName = "title"
        Me.title.HeaderText = "Title"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 52
        '
        'status
        '
        Me.status.DataPropertyName = "remarks"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'studentId
        '
        Me.studentId.DataPropertyName = "ID"
        Me.studentId.HeaderText = "id"
        Me.studentId.Name = "studentId"
        Me.studentId.ReadOnly = True
        Me.studentId.Visible = False
        '
        'srcode
        '
        Me.srcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.srcode.DataPropertyName = "srcode"
        Me.srcode.HeaderText = "Sr-code"
        Me.srcode.Name = "srcode"
        Me.srcode.ReadOnly = True
        Me.srcode.Width = 69
        '
        'studentName
        '
        Me.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.studentName.DataPropertyName = "studentName"
        Me.studentName.HeaderText = "Name"
        Me.studentName.Name = "studentName"
        Me.studentName.ReadOnly = True
        Me.studentName.Width = 60
        '
        'borrowedBooks
        '
        Me.borrowedBooks.DataPropertyName = "borrowedBooks"
        Me.borrowedBooks.HeaderText = "Books Borrowed"
        Me.borrowedBooks.Name = "borrowedBooks"
        Me.borrowedBooks.ReadOnly = True
        '
        'course
        '
        Me.course.DataPropertyName = "course"
        Me.course.HeaderText = "Course"
        Me.course.Name = "course"
        Me.course.ReadOnly = True
        Me.course.Visible = False
        '
        'yearLevel
        '
        Me.yearLevel.DataPropertyName = "yearLevel"
        Me.yearLevel.HeaderText = "Year Level"
        Me.yearLevel.Name = "yearLevel"
        Me.yearLevel.ReadOnly = True
        Me.yearLevel.Visible = False
        '
        'BorrowAndReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 490)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "BorrowAndReturn"
        Me.Text = "BorrowAndReturn"
        Me.TabControl1.ResumeLayout(False)
        Me.borrow.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents borrow As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAccessionNum As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtyearLevel As TextBox
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtsrcode As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rdName As RadioButton
    Friend WithEvents rdsrcode As RadioButton
    Friend WithEvents btnRefreshStudent As Button
    Friend WithEvents btnstudentSearch As Button
    Friend WithEvents txtsearchStudent As TextBox
    Friend WithEvents rdTitle As RadioButton
    Friend WithEvents rdacccesionNum As RadioButton
    Friend WithEvents btnrefreshbook As Button
    Friend WithEvents btnSearchbook As Button
    Friend WithEvents txtsearchbook As TextBox
    Friend WithEvents bookId As DataGridViewTextBoxColumn
    Friend WithEvents acccesnum As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents studentId As DataGridViewTextBoxColumn
    Friend WithEvents srcode As DataGridViewTextBoxColumn
    Friend WithEvents studentName As DataGridViewTextBoxColumn
    Friend WithEvents borrowedBooks As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents yearLevel As DataGridViewTextBoxColumn
End Class
