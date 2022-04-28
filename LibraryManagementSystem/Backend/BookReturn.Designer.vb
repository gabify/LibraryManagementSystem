<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookReturn
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
        Me.student = New System.Windows.Forms.TabPage()
        Me.btnBorrowVisitor = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtaccessNumreturn = New System.Windows.Forms.TextBox()
        Me.txtTitlereturn = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.dgvBorrowedBooks = New System.Windows.Forms.DataGridView()
        Me.Borrowedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedstudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowedSrcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessionNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowStudentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtborrowedStudent = New System.Windows.Forms.TextBox()
        Me.btnsearchStudent = New System.Windows.Forms.Button()
        Me.btnRefreshBorrowedStudent = New System.Windows.Forms.Button()
        Me.btnCancelVisitor = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.dgvReturnedBooks = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsearchReturnStudent = New System.Windows.Forms.TextBox()
        Me.btnsearchReturnStudent = New System.Windows.Forms.Button()
        Me.btnRefreshReturnStudent = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtsrcodereturn = New System.Windows.Forms.TextBox()
        Me.txtnamereturn = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.faculty = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefreshReturnFaculty = New System.Windows.Forms.Button()
        Me.btnsearchReturnFaculty = New System.Windows.Forms.Button()
        Me.txtsearchReturnBookFaculty = New System.Windows.Forms.TextBox()
        Me.dgvReturnFaculty = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtemployeeNum = New System.Windows.Forms.TextBox()
        Me.btnCancelFAculty = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefreshBorrowedFaculty = New System.Windows.Forms.Button()
        Me.btnsearchBookFAculty = New System.Windows.Forms.Button()
        Me.txtsearchBookFaculty = New System.Windows.Forms.TextBox()
        Me.dgvBorrowedBooksFaculty = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitleFaculty = New System.Windows.Forms.TextBox()
        Me.txtaccessionNumFaculty = New System.Windows.Forms.TextBox()
        Me.btnReturnFaculty = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dgvReturnedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.faculty.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReturnFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvBorrowedBooksFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'student
        '
        Me.student.Controls.Add(Me.GroupBox13)
        Me.student.Controls.Add(Me.GroupBox12)
        Me.student.Controls.Add(Me.btnCancelVisitor)
        Me.student.Controls.Add(Me.GroupBox10)
        Me.student.Controls.Add(Me.GroupBox11)
        Me.student.Controls.Add(Me.btnBorrowVisitor)
        Me.student.Location = New System.Drawing.Point(4, 22)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(1251, 463)
        Me.student.TabIndex = 2
        Me.student.Text = "Student"
        Me.student.UseVisualStyleBackColor = True
        '
        'btnBorrowVisitor
        '
        Me.btnBorrowVisitor.Location = New System.Drawing.Point(5, 291)
        Me.btnBorrowVisitor.Name = "btnBorrowVisitor"
        Me.btnBorrowVisitor.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrowVisitor.TabIndex = 7
        Me.btnBorrowVisitor.Text = "Return"
        Me.btnBorrowVisitor.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.txtTitlereturn)
        Me.GroupBox11.Controls.Add(Me.txtaccessNumreturn)
        Me.GroupBox11.Location = New System.Drawing.Point(5, 164)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(257, 121)
        Me.GroupBox11.TabIndex = 6
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Book Info"
        '
        'txtaccessNumreturn
        '
        Me.txtaccessNumreturn.Location = New System.Drawing.Point(13, 39)
        Me.txtaccessNumreturn.Name = "txtaccessNumreturn"
        Me.txtaccessNumreturn.Size = New System.Drawing.Size(100, 20)
        Me.txtaccessNumreturn.TabIndex = 4
        '
        'txtTitlereturn
        '
        Me.txtTitlereturn.Location = New System.Drawing.Point(13, 79)
        Me.txtTitlereturn.Name = "txtTitlereturn"
        Me.txtTitlereturn.Size = New System.Drawing.Size(100, 20)
        Me.txtTitlereturn.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Accession Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Title"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnRefreshBorrowedStudent)
        Me.GroupBox10.Controls.Add(Me.btnsearchStudent)
        Me.GroupBox10.Controls.Add(Me.txtborrowedStudent)
        Me.GroupBox10.Controls.Add(Me.dgvBorrowedBooks)
        Me.GroupBox10.Location = New System.Drawing.Point(282, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(484, 446)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        '
        'dgvBorrowedBooks
        '
        Me.dgvBorrowedBooks.AllowUserToAddRows = False
        Me.dgvBorrowedBooks.AllowUserToDeleteRows = False
        Me.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowedBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrowStudentId, Me.accessionNum, Me.BorrowedTitle, Me.borrowedSrcode, Me.BorrowedstudentName, Me.Borrowedate})
        Me.dgvBorrowedBooks.Location = New System.Drawing.Point(0, 88)
        Me.dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        Me.dgvBorrowedBooks.ReadOnly = True
        Me.dgvBorrowedBooks.Size = New System.Drawing.Size(476, 358)
        Me.dgvBorrowedBooks.TabIndex = 0
        '
        'Borrowedate
        '
        Me.Borrowedate.DataPropertyName = "dateBorrowed"
        Me.Borrowedate.HeaderText = "Borrowed Date"
        Me.Borrowedate.Name = "Borrowedate"
        Me.Borrowedate.ReadOnly = True
        '
        'BorrowedstudentName
        '
        Me.BorrowedstudentName.DataPropertyName = "studentName"
        Me.BorrowedstudentName.HeaderText = "Student Name"
        Me.BorrowedstudentName.Name = "BorrowedstudentName"
        Me.BorrowedstudentName.ReadOnly = True
        '
        'borrowedSrcode
        '
        Me.borrowedSrcode.DataPropertyName = "srcode"
        Me.borrowedSrcode.HeaderText = "Sr code"
        Me.borrowedSrcode.Name = "borrowedSrcode"
        Me.borrowedSrcode.ReadOnly = True
        '
        'BorrowedTitle
        '
        Me.BorrowedTitle.DataPropertyName = "title"
        Me.BorrowedTitle.HeaderText = "Title"
        Me.BorrowedTitle.Name = "BorrowedTitle"
        Me.BorrowedTitle.ReadOnly = True
        '
        'accessionNum
        '
        Me.accessionNum.DataPropertyName = "accessionNum"
        Me.accessionNum.HeaderText = "Accession Number"
        Me.accessionNum.Name = "accessionNum"
        Me.accessionNum.ReadOnly = True
        '
        'borrowStudentId
        '
        Me.borrowStudentId.DataPropertyName = "ID"
        Me.borrowStudentId.HeaderText = "borrowStudentId"
        Me.borrowStudentId.Name = "borrowStudentId"
        Me.borrowStudentId.ReadOnly = True
        Me.borrowStudentId.Visible = False
        '
        'txtborrowedStudent
        '
        Me.txtborrowedStudent.Location = New System.Drawing.Point(139, 18)
        Me.txtborrowedStudent.Name = "txtborrowedStudent"
        Me.txtborrowedStudent.Size = New System.Drawing.Size(175, 20)
        Me.txtborrowedStudent.TabIndex = 9
        '
        'btnsearchStudent
        '
        Me.btnsearchStudent.Location = New System.Drawing.Point(320, 16)
        Me.btnsearchStudent.Name = "btnsearchStudent"
        Me.btnsearchStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchStudent.TabIndex = 10
        Me.btnsearchStudent.Text = "Search"
        Me.btnsearchStudent.UseVisualStyleBackColor = True
        '
        'btnRefreshBorrowedStudent
        '
        Me.btnRefreshBorrowedStudent.Location = New System.Drawing.Point(401, 15)
        Me.btnRefreshBorrowedStudent.Name = "btnRefreshBorrowedStudent"
        Me.btnRefreshBorrowedStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshBorrowedStudent.TabIndex = 11
        Me.btnRefreshBorrowedStudent.Text = "Refresh"
        Me.btnRefreshBorrowedStudent.UseVisualStyleBackColor = True
        '
        'btnCancelVisitor
        '
        Me.btnCancelVisitor.Location = New System.Drawing.Point(187, 291)
        Me.btnCancelVisitor.Name = "btnCancelVisitor"
        Me.btnCancelVisitor.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelVisitor.TabIndex = 8
        Me.btnCancelVisitor.Text = "Cancel"
        Me.btnCancelVisitor.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btnRefreshReturnStudent)
        Me.GroupBox12.Controls.Add(Me.btnsearchReturnStudent)
        Me.GroupBox12.Controls.Add(Me.txtsearchReturnStudent)
        Me.GroupBox12.Controls.Add(Me.dgvReturnedBooks)
        Me.GroupBox12.Location = New System.Drawing.Point(766, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(484, 446)
        Me.GroupBox12.TabIndex = 14
        Me.GroupBox12.TabStop = False
        '
        'dgvReturnedBooks
        '
        Me.dgvReturnedBooks.AllowUserToAddRows = False
        Me.dgvReturnedBooks.AllowUserToDeleteRows = False
        Me.dgvReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnedBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.dgvReturnedBooks.Location = New System.Drawing.Point(0, 88)
        Me.dgvReturnedBooks.Name = "dgvReturnedBooks"
        Me.dgvReturnedBooks.ReadOnly = True
        Me.dgvReturnedBooks.Size = New System.Drawing.Size(476, 358)
        Me.dgvReturnedBooks.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "dateReturned"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date Returned"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 52
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "accessionNum"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Accession Number"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 111
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'txtsearchReturnStudent
        '
        Me.txtsearchReturnStudent.Location = New System.Drawing.Point(139, 18)
        Me.txtsearchReturnStudent.Name = "txtsearchReturnStudent"
        Me.txtsearchReturnStudent.Size = New System.Drawing.Size(175, 20)
        Me.txtsearchReturnStudent.TabIndex = 9
        '
        'btnsearchReturnStudent
        '
        Me.btnsearchReturnStudent.Location = New System.Drawing.Point(320, 16)
        Me.btnsearchReturnStudent.Name = "btnsearchReturnStudent"
        Me.btnsearchReturnStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchReturnStudent.TabIndex = 10
        Me.btnsearchReturnStudent.Text = "Search"
        Me.btnsearchReturnStudent.UseVisualStyleBackColor = True
        '
        'btnRefreshReturnStudent
        '
        Me.btnRefreshReturnStudent.Location = New System.Drawing.Point(401, 15)
        Me.btnRefreshReturnStudent.Name = "btnRefreshReturnStudent"
        Me.btnRefreshReturnStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshReturnStudent.TabIndex = 11
        Me.btnRefreshReturnStudent.Text = "Refresh"
        Me.btnRefreshReturnStudent.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label15)
        Me.GroupBox13.Controls.Add(Me.Label16)
        Me.GroupBox13.Controls.Add(Me.txtnamereturn)
        Me.GroupBox13.Controls.Add(Me.txtsrcodereturn)
        Me.GroupBox13.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(257, 155)
        Me.GroupBox13.TabIndex = 6
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Student"
        '
        'txtsrcodereturn
        '
        Me.txtsrcodereturn.Location = New System.Drawing.Point(14, 39)
        Me.txtsrcodereturn.Name = "txtsrcodereturn"
        Me.txtsrcodereturn.Size = New System.Drawing.Size(100, 20)
        Me.txtsrcodereturn.TabIndex = 0
        '
        'txtnamereturn
        '
        Me.txtnamereturn.Location = New System.Drawing.Point(14, 77)
        Me.txtnamereturn.Name = "txtnamereturn"
        Me.txtnamereturn.Size = New System.Drawing.Size(100, 20)
        Me.txtnamereturn.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Sr code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.student)
        Me.TabControl1.Controls.Add(Me.faculty)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 489)
        Me.TabControl1.TabIndex = 1
        '
        'faculty
        '
        Me.faculty.Controls.Add(Me.GroupBox1)
        Me.faculty.Controls.Add(Me.GroupBox2)
        Me.faculty.Controls.Add(Me.btnCancelFAculty)
        Me.faculty.Controls.Add(Me.GroupBox3)
        Me.faculty.Controls.Add(Me.GroupBox4)
        Me.faculty.Controls.Add(Me.btnReturnFaculty)
        Me.faculty.Location = New System.Drawing.Point(4, 22)
        Me.faculty.Name = "faculty"
        Me.faculty.Size = New System.Drawing.Size(1251, 463)
        Me.faculty.TabIndex = 3
        Me.faculty.Text = "Faculty"
        Me.faculty.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefreshReturnFaculty)
        Me.GroupBox1.Controls.Add(Me.btnsearchReturnFaculty)
        Me.GroupBox1.Controls.Add(Me.txtsearchReturnBookFaculty)
        Me.GroupBox1.Controls.Add(Me.dgvReturnFaculty)
        Me.GroupBox1.Location = New System.Drawing.Point(765, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 446)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnRefreshReturnFaculty
        '
        Me.btnRefreshReturnFaculty.Location = New System.Drawing.Point(401, 15)
        Me.btnRefreshReturnFaculty.Name = "btnRefreshReturnFaculty"
        Me.btnRefreshReturnFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshReturnFaculty.TabIndex = 11
        Me.btnRefreshReturnFaculty.Text = "Refresh"
        Me.btnRefreshReturnFaculty.UseVisualStyleBackColor = True
        '
        'btnsearchReturnFaculty
        '
        Me.btnsearchReturnFaculty.Location = New System.Drawing.Point(320, 16)
        Me.btnsearchReturnFaculty.Name = "btnsearchReturnFaculty"
        Me.btnsearchReturnFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchReturnFaculty.TabIndex = 10
        Me.btnsearchReturnFaculty.Text = "Search"
        Me.btnsearchReturnFaculty.UseVisualStyleBackColor = True
        '
        'txtsearchReturnBookFaculty
        '
        Me.txtsearchReturnBookFaculty.Location = New System.Drawing.Point(139, 18)
        Me.txtsearchReturnBookFaculty.Name = "txtsearchReturnBookFaculty"
        Me.txtsearchReturnBookFaculty.Size = New System.Drawing.Size(175, 20)
        Me.txtsearchReturnBookFaculty.TabIndex = 9
        '
        'dgvReturnFaculty
        '
        Me.dgvReturnFaculty.AllowUserToAddRows = False
        Me.dgvReturnFaculty.AllowUserToDeleteRows = False
        Me.dgvReturnFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnFaculty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvReturnFaculty.Location = New System.Drawing.Point(0, 88)
        Me.dgvReturnFaculty.Name = "dgvReturnFaculty"
        Me.dgvReturnFaculty.ReadOnly = True
        Me.dgvReturnFaculty.Size = New System.Drawing.Size(476, 358)
        Me.dgvReturnFaculty.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "accessionNum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Accession Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 52
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dateReturned"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date Returned"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeName)
        Me.GroupBox2.Controls.Add(Me.txtemployeeNum)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 124)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Faculty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employee Number"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(14, 77)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeName.TabIndex = 1
        '
        'txtemployeeNum
        '
        Me.txtemployeeNum.Location = New System.Drawing.Point(14, 39)
        Me.txtemployeeNum.Name = "txtemployeeNum"
        Me.txtemployeeNum.Size = New System.Drawing.Size(100, 20)
        Me.txtemployeeNum.TabIndex = 0
        '
        'btnCancelFAculty
        '
        Me.btnCancelFAculty.Location = New System.Drawing.Point(191, 265)
        Me.btnCancelFAculty.Name = "btnCancelFAculty"
        Me.btnCancelFAculty.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelFAculty.TabIndex = 18
        Me.btnCancelFAculty.Text = "Cancel"
        Me.btnCancelFAculty.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRefreshBorrowedFaculty)
        Me.GroupBox3.Controls.Add(Me.btnsearchBookFAculty)
        Me.GroupBox3.Controls.Add(Me.txtsearchBookFaculty)
        Me.GroupBox3.Controls.Add(Me.dgvBorrowedBooksFaculty)
        Me.GroupBox3.Location = New System.Drawing.Point(281, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 446)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'btnRefreshBorrowedFaculty
        '
        Me.btnRefreshBorrowedFaculty.Location = New System.Drawing.Point(401, 15)
        Me.btnRefreshBorrowedFaculty.Name = "btnRefreshBorrowedFaculty"
        Me.btnRefreshBorrowedFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshBorrowedFaculty.TabIndex = 11
        Me.btnRefreshBorrowedFaculty.Text = "Refresh"
        Me.btnRefreshBorrowedFaculty.UseVisualStyleBackColor = True
        '
        'btnsearchBookFAculty
        '
        Me.btnsearchBookFAculty.Location = New System.Drawing.Point(320, 16)
        Me.btnsearchBookFAculty.Name = "btnsearchBookFAculty"
        Me.btnsearchBookFAculty.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchBookFAculty.TabIndex = 10
        Me.btnsearchBookFAculty.Text = "Search"
        Me.btnsearchBookFAculty.UseVisualStyleBackColor = True
        '
        'txtsearchBookFaculty
        '
        Me.txtsearchBookFaculty.Location = New System.Drawing.Point(139, 18)
        Me.txtsearchBookFaculty.Name = "txtsearchBookFaculty"
        Me.txtsearchBookFaculty.Size = New System.Drawing.Size(175, 20)
        Me.txtsearchBookFaculty.TabIndex = 9
        '
        'dgvBorrowedBooksFaculty
        '
        Me.dgvBorrowedBooksFaculty.AllowUserToAddRows = False
        Me.dgvBorrowedBooksFaculty.AllowUserToDeleteRows = False
        Me.dgvBorrowedBooksFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowedBooksFaculty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.employeeNum, Me.employeeName, Me.DataGridViewTextBoxColumn14})
        Me.dgvBorrowedBooksFaculty.Location = New System.Drawing.Point(0, 88)
        Me.dgvBorrowedBooksFaculty.Name = "dgvBorrowedBooksFaculty"
        Me.dgvBorrowedBooksFaculty.ReadOnly = True
        Me.dgvBorrowedBooksFaculty.Size = New System.Drawing.Size(476, 358)
        Me.dgvBorrowedBooksFaculty.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtTitleFaculty)
        Me.GroupBox4.Controls.Add(Me.txtaccessionNumFaculty)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 138)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 121)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Book Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Accession Number"
        '
        'txtTitleFaculty
        '
        Me.txtTitleFaculty.Location = New System.Drawing.Point(13, 79)
        Me.txtTitleFaculty.Name = "txtTitleFaculty"
        Me.txtTitleFaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtTitleFaculty.TabIndex = 5
        '
        'txtaccessionNumFaculty
        '
        Me.txtaccessionNumFaculty.Location = New System.Drawing.Point(13, 39)
        Me.txtaccessionNumFaculty.Name = "txtaccessionNumFaculty"
        Me.txtaccessionNumFaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtaccessionNumFaculty.TabIndex = 4
        '
        'btnReturnFaculty
        '
        Me.btnReturnFaculty.Location = New System.Drawing.Point(9, 265)
        Me.btnReturnFaculty.Name = "btnReturnFaculty"
        Me.btnReturnFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnReturnFaculty.TabIndex = 17
        Me.btnReturnFaculty.Text = "Return"
        Me.btnReturnFaculty.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "borrowStudentId"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "accessionNum"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Accession Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'employeeNum
        '
        Me.employeeNum.DataPropertyName = "employeeNum"
        Me.employeeNum.HeaderText = "Employee Number"
        Me.employeeNum.Name = "employeeNum"
        Me.employeeNum.ReadOnly = True
        '
        'employeeName
        '
        Me.employeeName.DataPropertyName = "employeeName"
        Me.employeeName.HeaderText = "Employee Name"
        Me.employeeName.Name = "employeeName"
        Me.employeeName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "dateBorrowed"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Borrowed Date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'BookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "BookReturn"
        Me.Text = "BookReturn"
        Me.student.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.dgvReturnedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.faculty.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReturnFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvBorrowedBooksFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents student As TabPage
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtnamereturn As TextBox
    Friend WithEvents txtsrcodereturn As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents btnRefreshReturnStudent As Button
    Friend WithEvents btnsearchReturnStudent As Button
    Friend WithEvents txtsearchReturnStudent As TextBox
    Friend WithEvents dgvReturnedBooks As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelVisitor As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents btnRefreshBorrowedStudent As Button
    Friend WithEvents btnsearchStudent As Button
    Friend WithEvents txtborrowedStudent As TextBox
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents borrowStudentId As DataGridViewTextBoxColumn
    Friend WithEvents accessionNum As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedTitle As DataGridViewTextBoxColumn
    Friend WithEvents borrowedSrcode As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedstudentName As DataGridViewTextBoxColumn
    Friend WithEvents Borrowedate As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTitlereturn As TextBox
    Friend WithEvents txtaccessNumreturn As TextBox
    Friend WithEvents btnBorrowVisitor As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents faculty As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRefreshReturnFaculty As Button
    Friend WithEvents btnsearchReturnFaculty As Button
    Friend WithEvents txtsearchReturnBookFaculty As TextBox
    Friend WithEvents dgvReturnFaculty As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtemployeeNum As TextBox
    Friend WithEvents btnCancelFAculty As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRefreshBorrowedFaculty As Button
    Friend WithEvents btnsearchBookFAculty As Button
    Friend WithEvents txtsearchBookFaculty As TextBox
    Friend WithEvents dgvBorrowedBooksFaculty As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitleFaculty As TextBox
    Friend WithEvents txtaccessionNumFaculty As TextBox
    Friend WithEvents btnReturnFaculty As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents employeeNum As DataGridViewTextBoxColumn
    Friend WithEvents employeeName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
