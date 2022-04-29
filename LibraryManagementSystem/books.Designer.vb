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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.accessnum, Me.callnum, Me.author, Me.title, Me.publication, Me.cy, Me.copy, Me.remarks})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 347)
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
        Me.accessnum.Width = 111
        '
        'callnum
        '
        Me.callnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.callnum.DataPropertyName = "callNum"
        Me.callnum.HeaderText = "Call No"
        Me.callnum.Name = "callnum"
        Me.callnum.ReadOnly = True
        Me.callnum.Width = 49
        '
        'author
        '
        Me.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        Me.author.Width = 63
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
        'publication
        '
        Me.publication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.publication.DataPropertyName = "publication"
        Me.publication.HeaderText = "Publication"
        Me.publication.Name = "publication"
        Me.publication.ReadOnly = True
        Me.publication.Width = 84
        '
        'cy
        '
        Me.cy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cy.DataPropertyName = "cy"
        Me.cy.HeaderText = "Copyright Year"
        Me.cy.Name = "cy"
        Me.cy.ReadOnly = True
        Me.cy.Width = 93
        '
        'copy
        '
        Me.copy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.copy.DataPropertyName = "copy"
        Me.copy.HeaderText = "Copy"
        Me.copy.Name = "copy"
        Me.copy.ReadOnly = True
        Me.copy.Width = 56
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Status"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 62
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'remarksCombo
        '
        Me.remarksCombo.DisplayMember = "Accession Number"
        Me.remarksCombo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksCombo.FormattingEnabled = True
        Me.remarksCombo.Location = New System.Drawing.Point(512, 105)
        Me.remarksCombo.Name = "remarksCombo"
        Me.remarksCombo.Size = New System.Drawing.Size(191, 27)
        Me.remarksCombo.TabIndex = 7
        Me.remarksCombo.Text = "---Select From---"
        '
        'txtqwqRemarks
        '
        Me.txtqwqRemarks.AutoSize = True
        Me.txtqwqRemarks.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqwqRemarks.Location = New System.Drawing.Point(432, 108)
        Me.txtqwqRemarks.Name = "txtqwqRemarks"
        Me.txtqwqRemarks.Size = New System.Drawing.Size(52, 19)
        Me.txtqwqRemarks.TabIndex = 15
        Me.txtqwqRemarks.Text = "Status"
        '
        'txtCowqwpy
        '
        Me.txtCowqwpy.AutoSize = True
        Me.txtCowqwpy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCowqwpy.Location = New System.Drawing.Point(432, 82)
        Me.txtCowqwpy.Name = "txtCowqwpy"
        Me.txtCowqwpy.Size = New System.Drawing.Size(45, 19)
        Me.txtCowqwpy.TabIndex = 14
        Me.txtCowqwpy.Text = "Copy"
        '
        'txtCywqw
        '
        Me.txtCywqw.AutoSize = True
        Me.txtCywqw.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCywqw.Location = New System.Drawing.Point(432, 56)
        Me.txtCywqw.Name = "txtCywqw"
        Me.txtCywqw.Size = New System.Drawing.Size(115, 19)
        Me.txtCywqw.TabIndex = 13
        Me.txtCywqw.Text = "Copyright Year"
        '
        'qw
        '
        Me.qw.AutoSize = True
        Me.qw.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qw.Location = New System.Drawing.Point(432, 30)
        Me.qw.Name = "qw"
        Me.qw.Size = New System.Drawing.Size(86, 19)
        Me.qw.TabIndex = 12
        Me.qw.Text = "Publication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Call No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Accession Number"
        '
        'txtCopy
        '
        Me.txtCopy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopy.Location = New System.Drawing.Point(512, 75)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(191, 27)
        Me.txtCopy.TabIndex = 6
        '
        'txtCy
        '
        Me.txtCy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCy.Location = New System.Drawing.Point(512, 49)
        Me.txtCy.Name = "txtCy"
        Me.txtCy.Size = New System.Drawing.Size(191, 27)
        Me.txtCy.TabIndex = 5
        '
        'txtPublication
        '
        Me.txtPublication.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublication.Location = New System.Drawing.Point(512, 23)
        Me.txtPublication.Name = "txtPublication"
        Me.txtPublication.Size = New System.Drawing.Size(191, 27)
        Me.txtPublication.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(128, 97)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 27)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(128, 71)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(230, 27)
        Me.txtAuthor.TabIndex = 2
        '
        'txtCallNum
        '
        Me.txtCallNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNum.Location = New System.Drawing.Point(128, 45)
        Me.txtCallNum.Name = "txtCallNum"
        Me.txtCallNum.Size = New System.Drawing.Size(230, 27)
        Me.txtCallNum.TabIndex = 1
        '
        'txtaccessNum
        '
        Me.txtaccessNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccessNum.Location = New System.Drawing.Point(128, 19)
        Me.txtaccessNum.Name = "txtaccessNum"
        Me.txtaccessNum.ReadOnly = True
        Me.txtaccessNum.Size = New System.Drawing.Size(230, 27)
        Me.txtaccessNum.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(17, 68)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export "
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(98, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 23)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(17, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(706, 19)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(227, 20)
        Me.txtsearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(943, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'searchCombo
        '
        Me.searchCombo.DisplayMember = "Accession Number"
        Me.searchCombo.FormattingEnabled = True
        Me.searchCombo.Location = New System.Drawing.Point(571, 19)
        Me.searchCombo.Name = "searchCombo"
        Me.searchCombo.Size = New System.Drawing.Size(121, 21)
        Me.searchCombo.TabIndex = 5
        Me.searchCombo.Text = "Search By....."
        '
        'booksTotal
        '
        Me.booksTotal.AutoSize = True
        Me.booksTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booksTotal.Location = New System.Drawing.Point(12, 9)
        Me.booksTotal.Name = "booksTotal"
        Me.booksTotal.Size = New System.Drawing.Size(103, 19)
        Me.booksTotal.TabIndex = 6
        Me.booksTotal.Text = "Total Books: "
        '
        'RowNum
        '
        Me.RowNum.AutoSize = True
        Me.RowNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowNum.Location = New System.Drawing.Point(12, 30)
        Me.RowNum.Name = "RowNum"
        Me.RowNum.Size = New System.Drawing.Size(138, 19)
        Me.RowNum.TabIndex = 7
        Me.RowNum.Text = "Number of Books:"
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(1024, 18)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 8
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(783, 423)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 113)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1122, 642)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.RowNum)
        Me.Controls.Add(Me.booksTotal)
        Me.Controls.Add(Me.searchCombo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
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
End Class
