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
        Me.student = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRegisterStudent = New System.Windows.Forms.Button()
        Me.rdName = New System.Windows.Forms.RadioButton()
        Me.rdsrcode = New System.Windows.Forms.RadioButton()
        Me.btnRefreshStudent = New System.Windows.Forms.Button()
        Me.btnstudentSearch = New System.Windows.Forms.Button()
        Me.txtsearchStudent = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.studentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowedBooks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdTitle = New System.Windows.Forms.RadioButton()
        Me.rdacccesionNum = New System.Windows.Forms.RadioButton()
        Me.btnrefreshbook = New System.Windows.Forms.Button()
        Me.btnSearchbook = New System.Windows.Forms.Button()
        Me.txtsearchbook = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acccesnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAccessionNum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtyearLevel = New System.Windows.Forms.TextBox()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsrcode = New System.Windows.Forms.TextBox()
        Me.faculty = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdEmployeeName = New System.Windows.Forms.RadioButton()
        Me.rdEmployeeNum = New System.Windows.Forms.RadioButton()
        Me.btnRefreshEmployee = New System.Windows.Forms.Button()
        Me.btnSearchEmployee = New System.Windows.Forms.Button()
        Me.txtsearchEmployee = New System.Windows.Forms.TextBox()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeNum = New System.Windows.Forms.TextBox()
        Me.btnCancelFaculty = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdTitleFaculty = New System.Windows.Forms.RadioButton()
        Me.rdaccessionNumFaculty = New System.Windows.Forms.RadioButton()
        Me.btnRefreshBookFaculty = New System.Windows.Forms.Button()
        Me.btnSearchBookFaculty = New System.Windows.Forms.Button()
        Me.txtsearchBookFaculty = New System.Windows.Forms.TextBox()
        Me.dgvBooksFaculty = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTitleFaculty = New System.Windows.Forms.TextBox()
        Me.txtAccessionNumFaculty = New System.Windows.Forms.TextBox()
        Me.btnBorrowFaculty = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.student.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.faculty.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvBooksFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.student)
        Me.TabControl1.Controls.Add(Me.faculty)
        Me.TabControl1.Location = New System.Drawing.Point(3, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 489)
        Me.TabControl1.TabIndex = 0
        '
        'student
        '
        Me.student.Controls.Add(Me.GroupBox4)
        Me.student.Controls.Add(Me.GroupBox3)
        Me.student.Controls.Add(Me.btnCancel)
        Me.student.Controls.Add(Me.btnBorrow)
        Me.student.Controls.Add(Me.GroupBox2)
        Me.student.Controls.Add(Me.GroupBox1)
        Me.student.Location = New System.Drawing.Point(4, 22)
        Me.student.Name = "student"
        Me.student.Padding = New System.Windows.Forms.Padding(3)
        Me.student.Size = New System.Drawing.Size(1251, 463)
        Me.student.TabIndex = 0
        Me.student.Text = "Student"
        Me.student.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRegisterStudent)
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
        'btnRegisterStudent
        '
        Me.btnRegisterStudent.Location = New System.Drawing.Point(258, 46)
        Me.btnRegisterStudent.Name = "btnRegisterStudent"
        Me.btnRegisterStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterStudent.TabIndex = 16
        Me.btnRegisterStudent.Text = "Register Student"
        Me.btnRegisterStudent.UseVisualStyleBackColor = True
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
        'btnrefreshbook
        '
        Me.btnrefreshbook.Location = New System.Drawing.Point(371, 17)
        Me.btnrefreshbook.Name = "btnrefreshbook"
        Me.btnrefreshbook.Size = New System.Drawing.Size(75, 23)
        Me.btnrefreshbook.TabIndex = 11
        Me.btnrefreshbook.Text = "Refresh"
        Me.btnrefreshbook.UseVisualStyleBackColor = True
        '
        'btnSearchbook
        '
        Me.btnSearchbook.Location = New System.Drawing.Point(290, 17)
        Me.btnSearchbook.Name = "btnSearchbook"
        Me.btnSearchbook.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchbook.TabIndex = 10
        Me.btnSearchbook.Text = "Search"
        Me.btnSearchbook.UseVisualStyleBackColor = True
        '
        'txtsearchbook
        '
        Me.txtsearchbook.Location = New System.Drawing.Point(53, 18)
        Me.txtsearchbook.Name = "txtsearchbook"
        Me.txtsearchbook.Size = New System.Drawing.Size(227, 20)
        Me.txtsearchbook.TabIndex = 9
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(305, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year Level"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
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
        'txtyearLevel
        '
        Me.txtyearLevel.Location = New System.Drawing.Point(14, 152)
        Me.txtyearLevel.Name = "txtyearLevel"
        Me.txtyearLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtyearLevel.TabIndex = 3
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(14, 115)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(100, 20)
        Me.txtcourse.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(14, 77)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 1
        '
        'txtsrcode
        '
        Me.txtsrcode.Location = New System.Drawing.Point(14, 39)
        Me.txtsrcode.Name = "txtsrcode"
        Me.txtsrcode.Size = New System.Drawing.Size(100, 20)
        Me.txtsrcode.TabIndex = 0
        '
        'faculty
        '
        Me.faculty.Controls.Add(Me.GroupBox5)
        Me.faculty.Controls.Add(Me.GroupBox8)
        Me.faculty.Controls.Add(Me.btnCancelFaculty)
        Me.faculty.Controls.Add(Me.GroupBox6)
        Me.faculty.Controls.Add(Me.GroupBox7)
        Me.faculty.Controls.Add(Me.btnBorrowFaculty)
        Me.faculty.Location = New System.Drawing.Point(4, 22)
        Me.faculty.Name = "faculty"
        Me.faculty.Padding = New System.Windows.Forms.Padding(3)
        Me.faculty.Size = New System.Drawing.Size(1251, 463)
        Me.faculty.TabIndex = 1
        Me.faculty.Text = "Faculty"
        Me.faculty.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.rdEmployeeName)
        Me.GroupBox5.Controls.Add(Me.rdEmployeeNum)
        Me.GroupBox5.Controls.Add(Me.btnRefreshEmployee)
        Me.GroupBox5.Controls.Add(Me.btnSearchEmployee)
        Me.GroupBox5.Controls.Add(Me.txtsearchEmployee)
        Me.GroupBox5.Controls.Add(Me.dgvEmployee)
        Me.GroupBox5.Location = New System.Drawing.Point(902, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(339, 446)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Register Student"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rdEmployeeName
        '
        Me.rdEmployeeName.AutoSize = True
        Me.rdEmployeeName.Location = New System.Drawing.Point(149, 45)
        Me.rdEmployeeName.Name = "rdEmployeeName"
        Me.rdEmployeeName.Size = New System.Drawing.Size(102, 17)
        Me.rdEmployeeName.TabIndex = 15
        Me.rdEmployeeName.TabStop = True
        Me.rdEmployeeName.Text = "Employee Name"
        Me.rdEmployeeName.UseVisualStyleBackColor = True
        '
        'rdEmployeeNum
        '
        Me.rdEmployeeNum.AutoSize = True
        Me.rdEmployeeNum.Location = New System.Drawing.Point(12, 46)
        Me.rdEmployeeNum.Name = "rdEmployeeNum"
        Me.rdEmployeeNum.Size = New System.Drawing.Size(111, 17)
        Me.rdEmployeeNum.TabIndex = 14
        Me.rdEmployeeNum.TabStop = True
        Me.rdEmployeeNum.Text = "Employee Number"
        Me.rdEmployeeNum.UseVisualStyleBackColor = True
        '
        'btnRefreshEmployee
        '
        Me.btnRefreshEmployee.Location = New System.Drawing.Point(261, 16)
        Me.btnRefreshEmployee.Name = "btnRefreshEmployee"
        Me.btnRefreshEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshEmployee.TabIndex = 11
        Me.btnRefreshEmployee.Text = "Refresh"
        Me.btnRefreshEmployee.UseVisualStyleBackColor = True
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.Location = New System.Drawing.Point(180, 16)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchEmployee.TabIndex = 10
        Me.btnSearchEmployee.Text = "Search"
        Me.btnSearchEmployee.UseVisualStyleBackColor = True
        '
        'txtsearchEmployee
        '
        Me.txtsearchEmployee.Location = New System.Drawing.Point(9, 17)
        Me.txtsearchEmployee.Name = "txtsearchEmployee"
        Me.txtsearchEmployee.Size = New System.Drawing.Size(161, 20)
        Me.txtsearchEmployee.TabIndex = 9
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.employeeNum, Me.employeeName})
        Me.dgvEmployee.Location = New System.Drawing.Point(0, 93)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.Size = New System.Drawing.Size(339, 353)
        Me.dgvEmployee.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "employeeId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'employeeNum
        '
        Me.employeeNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.employeeNum.DataPropertyName = "employeeNum"
        Me.employeeNum.HeaderText = "Employee Number"
        Me.employeeNum.Name = "employeeNum"
        Me.employeeNum.ReadOnly = True
        Me.employeeNum.Width = 108
        '
        'employeeName
        '
        Me.employeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.employeeName.DataPropertyName = "employeeName"
        Me.employeeName.HeaderText = "Employee Name"
        Me.employeeName.Name = "employeeName"
        Me.employeeName.ReadOnly = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.txtEmployeeName)
        Me.GroupBox8.Controls.Add(Me.txtEmployeeNum)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(367, 124)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Borrower's Info"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Employee Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Employee Number"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(14, 77)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeName.TabIndex = 1
        '
        'txtEmployeeNum
        '
        Me.txtEmployeeNum.Location = New System.Drawing.Point(14, 39)
        Me.txtEmployeeNum.Name = "txtEmployeeNum"
        Me.txtEmployeeNum.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeNum.TabIndex = 0
        '
        'btnCancelFaculty
        '
        Me.btnCancelFaculty.Location = New System.Drawing.Point(298, 263)
        Me.btnCancelFaculty.Name = "btnCancelFaculty"
        Me.btnCancelFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelFaculty.TabIndex = 3
        Me.btnCancelFaculty.Text = "Cancel"
        Me.btnCancelFaculty.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdTitleFaculty)
        Me.GroupBox6.Controls.Add(Me.rdaccessionNumFaculty)
        Me.GroupBox6.Controls.Add(Me.btnRefreshBookFaculty)
        Me.GroupBox6.Controls.Add(Me.btnSearchBookFaculty)
        Me.GroupBox6.Controls.Add(Me.txtsearchBookFaculty)
        Me.GroupBox6.Controls.Add(Me.dgvBooksFaculty)
        Me.GroupBox6.Location = New System.Drawing.Point(405, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(450, 446)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'rdTitleFaculty
        '
        Me.rdTitleFaculty.AutoSize = True
        Me.rdTitleFaculty.Location = New System.Drawing.Point(190, 45)
        Me.rdTitleFaculty.Name = "rdTitleFaculty"
        Me.rdTitleFaculty.Size = New System.Drawing.Size(45, 17)
        Me.rdTitleFaculty.TabIndex = 13
        Me.rdTitleFaculty.TabStop = True
        Me.rdTitleFaculty.Text = "Title"
        Me.rdTitleFaculty.UseVisualStyleBackColor = True
        '
        'rdaccessionNumFaculty
        '
        Me.rdaccessionNumFaculty.AutoSize = True
        Me.rdaccessionNumFaculty.Location = New System.Drawing.Point(53, 46)
        Me.rdaccessionNumFaculty.Name = "rdaccessionNumFaculty"
        Me.rdaccessionNumFaculty.Size = New System.Drawing.Size(114, 17)
        Me.rdaccessionNumFaculty.TabIndex = 12
        Me.rdaccessionNumFaculty.TabStop = True
        Me.rdaccessionNumFaculty.Text = "Accession Number"
        Me.rdaccessionNumFaculty.UseVisualStyleBackColor = True
        '
        'btnRefreshBookFaculty
        '
        Me.btnRefreshBookFaculty.Location = New System.Drawing.Point(371, 17)
        Me.btnRefreshBookFaculty.Name = "btnRefreshBookFaculty"
        Me.btnRefreshBookFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshBookFaculty.TabIndex = 11
        Me.btnRefreshBookFaculty.Text = "Refresh"
        Me.btnRefreshBookFaculty.UseVisualStyleBackColor = True
        '
        'btnSearchBookFaculty
        '
        Me.btnSearchBookFaculty.Location = New System.Drawing.Point(290, 17)
        Me.btnSearchBookFaculty.Name = "btnSearchBookFaculty"
        Me.btnSearchBookFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchBookFaculty.TabIndex = 10
        Me.btnSearchBookFaculty.Text = "Search"
        Me.btnSearchBookFaculty.UseVisualStyleBackColor = True
        '
        'txtsearchBookFaculty
        '
        Me.txtsearchBookFaculty.Location = New System.Drawing.Point(53, 18)
        Me.txtsearchBookFaculty.Name = "txtsearchBookFaculty"
        Me.txtsearchBookFaculty.Size = New System.Drawing.Size(227, 20)
        Me.txtsearchBookFaculty.TabIndex = 9
        '
        'dgvBooksFaculty
        '
        Me.dgvBooksFaculty.AllowUserToAddRows = False
        Me.dgvBooksFaculty.AllowUserToDeleteRows = False
        Me.dgvBooksFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooksFaculty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvBooksFaculty.Location = New System.Drawing.Point(0, 88)
        Me.dgvBooksFaculty.Name = "dgvBooksFaculty"
        Me.dgvBooksFaculty.ReadOnly = True
        Me.dgvBooksFaculty.Size = New System.Drawing.Size(450, 358)
        Me.dgvBooksFaculty.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "accessionNum"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Accession Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 111
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 52
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "remarks"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txtTitleFaculty)
        Me.GroupBox7.Controls.Add(Me.txtAccessionNumFaculty)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(367, 121)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Book Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Title"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Accession Number"
        '
        'txtTitleFaculty
        '
        Me.txtTitleFaculty.Location = New System.Drawing.Point(13, 79)
        Me.txtTitleFaculty.Name = "txtTitleFaculty"
        Me.txtTitleFaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtTitleFaculty.TabIndex = 5
        '
        'txtAccessionNumFaculty
        '
        Me.txtAccessionNumFaculty.Location = New System.Drawing.Point(13, 39)
        Me.txtAccessionNumFaculty.Name = "txtAccessionNumFaculty"
        Me.txtAccessionNumFaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtAccessionNumFaculty.TabIndex = 4
        '
        'btnBorrowFaculty
        '
        Me.btnBorrowFaculty.Location = New System.Drawing.Point(6, 263)
        Me.btnBorrowFaculty.Name = "btnBorrowFaculty"
        Me.btnBorrowFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrowFaculty.TabIndex = 2
        Me.btnBorrowFaculty.Text = "Borrow"
        Me.btnBorrowFaculty.UseVisualStyleBackColor = True
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
        Me.student.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.faculty.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvBooksFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents student As TabPage
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
    Friend WithEvents faculty As TabPage
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdEmployeeName As RadioButton
    Friend WithEvents rdEmployeeNum As RadioButton
    Friend WithEvents btnRefreshEmployee As Button
    Friend WithEvents btnSearchEmployee As Button
    Friend WithEvents txtsearchEmployee As TextBox
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmployeeNum As TextBox
    Friend WithEvents btnCancelFaculty As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rdTitleFaculty As RadioButton
    Friend WithEvents rdaccessionNumFaculty As RadioButton
    Friend WithEvents btnRefreshBookFaculty As Button
    Friend WithEvents btnSearchBookFaculty As Button
    Friend WithEvents txtsearchBookFaculty As TextBox
    Friend WithEvents dgvBooksFaculty As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTitleFaculty As TextBox
    Friend WithEvents txtAccessionNumFaculty As TextBox
    Friend WithEvents btnBorrowFaculty As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents employeeNum As DataGridViewTextBoxColumn
    Friend WithEvents employeeName As DataGridViewTextBoxColumn
    Friend WithEvents btnRegisterStudent As Button
    Friend WithEvents Button1 As Button
End Class
