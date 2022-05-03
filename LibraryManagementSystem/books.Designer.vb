<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class books
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.callnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.publication = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.remarksCombo = New System.Windows.Forms.ComboBox()
        Me.txtqwqRemarks = New System.Windows.Forms.Label()
        Me.txtCowqwpy = New System.Windows.Forms.Label()
        Me.txtCywqw = New System.Windows.Forms.Label()
        Me.qw = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCopy = New System.Windows.Forms.TextBox()
        Me.txtCy = New System.Windows.Forms.TextBox()
        Me.txtPublication = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtCallNum = New System.Windows.Forms.TextBox()
        Me.txtaccessNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.searchCombo = New System.Windows.Forms.ComboBox()
        Me.booksTotal = New System.Windows.Forms.Label()
        Me.RowNum = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.accessnum, Me.callnum, Me.author, Me.title, Me.publication, Me.cy, Me.copy, Me.remarks})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(1, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.4!)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(1145, 342)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'accessnum
        '
        Me.accessnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.accessnum.DataPropertyName = "accessionNum"
        Me.accessnum.HeaderText = "Accession Number"
        Me.accessnum.Name = "accessnum"
        Me.accessnum.ReadOnly = True
        Me.accessnum.Width = 121
        '
        'callnum
        '
        Me.callnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.callnum.DataPropertyName = "callNum"
        Me.callnum.HeaderText = "Call No"
        Me.callnum.Name = "callnum"
        Me.callnum.ReadOnly = True
        Me.callnum.Width = 51
        '
        'author
        '
        Me.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        Me.author.Width = 69
        '
        'title
        '
        Me.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.title.DataPropertyName = "title"
        Me.title.HeaderText = "Title"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 55
        '
        'publication
        '
        Me.publication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.publication.DataPropertyName = "publication"
        Me.publication.HeaderText = "Publication"
        Me.publication.Name = "publication"
        Me.publication.ReadOnly = True
        Me.publication.Width = 92
        '
        'cy
        '
        Me.cy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cy.DataPropertyName = "cy"
        Me.cy.HeaderText = "Copyright Year"
        Me.cy.Name = "cy"
        Me.cy.ReadOnly = True
        '
        'copy
        '
        Me.copy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.copy.DataPropertyName = "copy"
        Me.copy.HeaderText = "Copy"
        Me.copy.Name = "copy"
        Me.copy.ReadOnly = True
        Me.copy.Width = 59
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Status"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.remarksCombo)
        Me.GroupBox1.Controls.Add(Me.txtqwqRemarks)
        Me.GroupBox1.Controls.Add(Me.txtCowqwpy)
        Me.GroupBox1.Controls.Add(Me.txtCywqw)
        Me.GroupBox1.Controls.Add(Me.qw)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCopy)
        Me.GroupBox1.Controls.Add(Me.txtCy)
        Me.GroupBox1.Controls.Add(Me.txtPublication)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.txtCallNum)
        Me.GroupBox1.Controls.Add(Me.txtaccessNum)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "_____________________________________________________"
        '
        'remarksCombo
        '
        Me.remarksCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.remarksCombo.DisplayMember = "Accession Number"
        Me.remarksCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.remarksCombo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksCombo.FormattingEnabled = True
        Me.remarksCombo.Location = New System.Drawing.Point(468, 232)
        Me.remarksCombo.Name = "remarksCombo"
        Me.remarksCombo.Size = New System.Drawing.Size(286, 29)
        Me.remarksCombo.TabIndex = 7
        Me.remarksCombo.Text = "---Select From---"
        '
        'txtqwqRemarks
        '
        Me.txtqwqRemarks.AutoSize = True
        Me.txtqwqRemarks.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqwqRemarks.Location = New System.Drawing.Point(465, 211)
        Me.txtqwqRemarks.Name = "txtqwqRemarks"
        Me.txtqwqRemarks.Size = New System.Drawing.Size(45, 20)
        Me.txtqwqRemarks.TabIndex = 15
        Me.txtqwqRemarks.Text = "Status"
        '
        'txtCowqwpy
        '
        Me.txtCowqwpy.AutoSize = True
        Me.txtCowqwpy.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCowqwpy.Location = New System.Drawing.Point(465, 142)
        Me.txtCowqwpy.Name = "txtCowqwpy"
        Me.txtCowqwpy.Size = New System.Drawing.Size(41, 20)
        Me.txtCowqwpy.TabIndex = 14
        Me.txtCowqwpy.Text = "Copy"
        '
        'txtCywqw
        '
        Me.txtCywqw.AutoSize = True
        Me.txtCywqw.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCywqw.Location = New System.Drawing.Point(465, 75)
        Me.txtCywqw.Name = "txtCywqw"
        Me.txtCywqw.Size = New System.Drawing.Size(99, 20)
        Me.txtCywqw.TabIndex = 13
        Me.txtCywqw.Text = "Copyright Year"
        '
        'qw
        '
        Me.qw.AutoSize = True
        Me.qw.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qw.Location = New System.Drawing.Point(465, 14)
        Me.qw.Name = "qw"
        Me.qw.Size = New System.Drawing.Size(76, 20)
        Me.qw.TabIndex = 12
        Me.qw.Text = "Publication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Call No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Accession Number"
        '
        'txtCopy
        '
        Me.txtCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCopy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCopy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopy.Location = New System.Drawing.Point(468, 164)
        Me.txtCopy.Multiline = True
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(286, 23)
        Me.txtCopy.TabIndex = 6
        '
        'txtCy
        '
        Me.txtCy.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCy.Location = New System.Drawing.Point(468, 97)
        Me.txtCy.Multiline = True
        Me.txtCy.Name = "txtCy"
        Me.txtCy.Size = New System.Drawing.Size(286, 23)
        Me.txtCy.TabIndex = 5
        '
        'txtPublication
        '
        Me.txtPublication.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPublication.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPublication.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublication.Location = New System.Drawing.Point(468, 40)
        Me.txtPublication.Multiline = True
        Me.txtPublication.Name = "txtPublication"
        Me.txtPublication.Size = New System.Drawing.Size(286, 23)
        Me.txtPublication.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(29, 202)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(325, 89)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(29, 146)
        Me.txtAuthor.Multiline = True
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(325, 23)
        Me.txtAuthor.TabIndex = 2
        '
        'txtCallNum
        '
        Me.txtCallNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCallNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCallNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNum.Location = New System.Drawing.Point(28, 95)
        Me.txtCallNum.Multiline = True
        Me.txtCallNum.Name = "txtCallNum"
        Me.txtCallNum.Size = New System.Drawing.Size(325, 23)
        Me.txtCallNum.TabIndex = 1
        '
        'txtaccessNum
        '
        Me.txtaccessNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtaccessNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccessNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccessNum.Location = New System.Drawing.Point(29, 37)
        Me.txtaccessNum.Multiline = True
        Me.txtaccessNum.Name = "txtaccessNum"
        Me.txtaccessNum.ReadOnly = True
        Me.txtaccessNum.Size = New System.Drawing.Size(325, 23)
        Me.txtaccessNum.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(454, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(325, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "_____________________________________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(454, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "_____________________________________________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(454, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(325, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "_____________________________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(325, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "_____________________________________________________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "_____________________________________________________"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.Transparent
        Me.btnExport.Location = New System.Drawing.Point(71, 233)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExport.Size = New System.Drawing.Size(193, 36)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export "
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelete.Location = New System.Drawing.Point(71, 170)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDelete.Size = New System.Drawing.Size(193, 36)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Location = New System.Drawing.Point(71, 107)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUpdate.Size = New System.Drawing.Size(193, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(71, 44)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAdd.Size = New System.Drawing.Size(193, 36)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 10.4!)
        Me.txtsearch.Location = New System.Drawing.Point(755, 25)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(227, 19)
        Me.txtsearch.TabIndex = 2
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Location = New System.Drawing.Point(988, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 31)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'searchCombo
        '
        Me.searchCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.searchCombo.DisplayMember = "Accession Number"
        Me.searchCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchCombo.Font = New System.Drawing.Font("Segoe UI Semilight", 10.4!)
        Me.searchCombo.FormattingEnabled = True
        Me.searchCombo.Location = New System.Drawing.Point(623, 25)
        Me.searchCombo.Name = "searchCombo"
        Me.searchCombo.Size = New System.Drawing.Size(121, 27)
        Me.searchCombo.TabIndex = 5
        Me.searchCombo.Text = "Search By...."
        '
        'booksTotal
        '
        Me.booksTotal.AutoSize = True
        Me.booksTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booksTotal.Location = New System.Drawing.Point(12, 9)
        Me.booksTotal.Name = "booksTotal"
        Me.booksTotal.Size = New System.Drawing.Size(96, 21)
        Me.booksTotal.TabIndex = 6
        Me.booksTotal.Text = "Total Books: "
        '
        'RowNum
        '
        Me.RowNum.AutoSize = True
        Me.RowNum.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowNum.Location = New System.Drawing.Point(12, 30)
        Me.RowNum.Name = "RowNum"
        Me.RowNum.Size = New System.Drawing.Size(134, 21)
        Me.RowNum.TabIndex = 7
        Me.RowNum.Text = "Number of Books:"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Transparent
        Me.btnrefresh.Location = New System.Drawing.Point(1068, 15)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(78, 31)
        Me.btnrefresh.TabIndex = 8
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(816, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 296)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(750, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "______________________________________"
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1171, 726)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.RowNum)
        Me.Controls.Add(Me.booksTotal)
        Me.Controls.Add(Me.searchCombo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Inventory System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtqwqRemarks As Label
    Friend WithEvents txtCowqwpy As Label
    Friend WithEvents txtCywqw As Label
    Friend WithEvents qw As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCopy As TextBox
    Friend WithEvents txtCy As TextBox
    Friend WithEvents txtPublication As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtCallNum As TextBox
    Friend WithEvents txtaccessNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents searchCombo As ComboBox
    Friend WithEvents booksTotal As Label
    Friend WithEvents remarksCombo As ComboBox
    Friend WithEvents RowNum As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents accessnum As DataGridViewTextBoxColumn
    Friend WithEvents callnum As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents publication As DataGridViewTextBoxColumn
    Friend WithEvents cy As DataGridViewTextBoxColumn
    Friend WithEvents copy As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
    Friend WithEvents btnrefresh As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
