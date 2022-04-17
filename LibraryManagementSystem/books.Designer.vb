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
        Me.btnExport = New System.Windows.Forms.Button()
        Me.remarksCombo = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtqwqRemarks = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtCowqwpy = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchCombo = New System.Windows.Forms.ComboBox()
        Me.booksTotal = New System.Windows.Forms.Label()
        Me.RowNum = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridView1.Size = New System.Drawing.Size(844, 279)
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
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.remarksCombo)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtqwqRemarks)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtCowqwpy)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(674, 113)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export "
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'remarksCombo
        '
        Me.remarksCombo.DisplayMember = "Accession Number"
        Me.remarksCombo.FormattingEnabled = True
        Me.remarksCombo.Location = New System.Drawing.Point(469, 101)
        Me.remarksCombo.Name = "remarksCombo"
        Me.remarksCombo.Size = New System.Drawing.Size(135, 21)
        Me.remarksCombo.TabIndex = 7
        Me.remarksCombo.Text = "---Select From---"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(674, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtqwqRemarks
        '
        Me.txtqwqRemarks.AutoSize = True
        Me.txtqwqRemarks.Location = New System.Drawing.Point(389, 104)
        Me.txtqwqRemarks.Name = "txtqwqRemarks"
        Me.txtqwqRemarks.Size = New System.Drawing.Size(37, 13)
        Me.txtqwqRemarks.TabIndex = 15
        Me.txtqwqRemarks.Text = "Status"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(674, 55)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtCowqwpy
        '
        Me.txtCowqwpy.AutoSize = True
        Me.txtCowqwpy.Location = New System.Drawing.Point(389, 78)
        Me.txtCowqwpy.Name = "txtCowqwpy"
        Me.txtCowqwpy.Size = New System.Drawing.Size(31, 13)
        Me.txtCowqwpy.TabIndex = 14
        Me.txtCowqwpy.Text = "Copy"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(674, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCywqw
        '
        Me.txtCywqw.AutoSize = True
        Me.txtCywqw.Location = New System.Drawing.Point(389, 52)
        Me.txtCywqw.Name = "txtCywqw"
        Me.txtCywqw.Size = New System.Drawing.Size(76, 13)
        Me.txtCywqw.TabIndex = 13
        Me.txtCywqw.Text = "Copyright Year"
        '
        'qw
        '
        Me.qw.AutoSize = True
        Me.qw.Location = New System.Drawing.Point(389, 26)
        Me.qw.Name = "qw"
        Me.qw.Size = New System.Drawing.Size(59, 13)
        Me.qw.TabIndex = 12
        Me.qw.Text = "Publication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Call No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Accession Number"
        '
        'txtCopy
        '
        Me.txtCopy.Location = New System.Drawing.Point(469, 71)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(135, 20)
        Me.txtCopy.TabIndex = 6
        '
        'txtCy
        '
        Me.txtCy.Location = New System.Drawing.Point(469, 45)
        Me.txtCy.Name = "txtCy"
        Me.txtCy.Size = New System.Drawing.Size(135, 20)
        Me.txtCy.TabIndex = 5
        '
        'txtPublication
        '
        Me.txtPublication.Location = New System.Drawing.Point(469, 19)
        Me.txtPublication.Name = "txtPublication"
        Me.txtPublication.Size = New System.Drawing.Size(135, 20)
        Me.txtPublication.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(128, 97)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(128, 71)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(230, 20)
        Me.txtAuthor.TabIndex = 2
        '
        'txtCallNum
        '
        Me.txtCallNum.Location = New System.Drawing.Point(128, 45)
        Me.txtCallNum.Name = "txtCallNum"
        Me.txtCallNum.Size = New System.Drawing.Size(230, 20)
        Me.txtCallNum.TabIndex = 1
        '
        'txtaccessNum
        '
        Me.txtaccessNum.Location = New System.Drawing.Point(128, 19)
        Me.txtaccessNum.Name = "txtaccessNum"
        Me.txtaccessNum.ReadOnly = True
        Me.txtaccessNum.Size = New System.Drawing.Size(230, 20)
        Me.txtaccessNum.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(278, 17)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(532, 20)
        Me.txtsearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(817, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search By:"
        '
        'searchCombo
        '
        Me.searchCombo.DisplayMember = "Accession Number"
        Me.searchCombo.FormattingEnabled = True
        Me.searchCombo.Location = New System.Drawing.Point(91, 17)
        Me.searchCombo.Name = "searchCombo"
        Me.searchCombo.Size = New System.Drawing.Size(121, 21)
        Me.searchCombo.TabIndex = 5
        Me.searchCombo.Text = "Select From..."
        '
        'booksTotal
        '
        Me.booksTotal.AutoSize = True
        Me.booksTotal.Location = New System.Drawing.Point(793, 352)
        Me.booksTotal.Name = "booksTotal"
        Me.booksTotal.Size = New System.Drawing.Size(70, 13)
        Me.booksTotal.TabIndex = 6
        Me.booksTotal.Text = "Total Books: "
        '
        'RowNum
        '
        Me.RowNum.AutoSize = True
        Me.RowNum.Location = New System.Drawing.Point(793, 373)
        Me.RowNum.Name = "RowNum"
        Me.RowNum.Size = New System.Drawing.Size(92, 13)
        Me.RowNum.TabIndex = 7
        Me.RowNum.Text = "Number of Books:"
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(796, 397)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 8
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(796, 426)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 17
        Me.btnUpload.Text = "Upload PDF"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 489)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.RowNum)
        Me.Controls.Add(Me.booksTotal)
        Me.Controls.Add(Me.searchCombo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "books"
        Me.Text = "books"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label5 As Label
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
    Friend WithEvents btnUpload As Button
End Class
