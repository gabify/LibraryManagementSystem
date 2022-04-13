<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thesis
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
        Me.booksTotal = New System.Windows.Forms.Label()
        Me.searchCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtCowqwpy = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCywqw = New System.Windows.Forms.Label()
        Me.qw = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCopy = New System.Windows.Forms.TextBox()
        Me.txtPy = New System.Windows.Forms.TextBox()
        Me.txtAdviser = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtCallNum = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.callnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adviser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.py = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'booksTotal
        '
        Me.booksTotal.AutoSize = True
        Me.booksTotal.Location = New System.Drawing.Point(792, 345)
        Me.booksTotal.Name = "booksTotal"
        Me.booksTotal.Size = New System.Drawing.Size(80, 13)
        Me.booksTotal.TabIndex = 13
        Me.booksTotal.Text = "Number Books:"
        '
        'searchCombo
        '
        Me.searchCombo.DisplayMember = "Accession Number"
        Me.searchCombo.FormattingEnabled = True
        Me.searchCombo.Location = New System.Drawing.Point(90, 10)
        Me.searchCombo.Name = "searchCombo"
        Me.searchCombo.Size = New System.Drawing.Size(121, 21)
        Me.searchCombo.TabIndex = 12
        Me.searchCombo.Text = "Select From..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Search By:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(816, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(277, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(532, 20)
        Me.txtsearch.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtCowqwpy)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtCywqw)
        Me.GroupBox1.Controls.Add(Me.qw)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCopy)
        Me.GroupBox1.Controls.Add(Me.txtPy)
        Me.GroupBox1.Controls.Add(Me.txtAdviser)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.txtCallNum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 109)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(674, 76)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(674, 47)
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
        Me.btnAdd.Location = New System.Drawing.Point(674, 18)
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
        Me.txtCywqw.Size = New System.Drawing.Size(29, 13)
        Me.txtCywqw.TabIndex = 13
        Me.txtCywqw.Text = "Year"
        '
        'qw
        '
        Me.qw.AutoSize = True
        Me.qw.Location = New System.Drawing.Point(389, 26)
        Me.qw.Name = "qw"
        Me.qw.Size = New System.Drawing.Size(42, 13)
        Me.qw.TabIndex = 12
        Me.qw.Text = "Adviser"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Call No"
        '
        'txtCopy
        '
        Me.txtCopy.Location = New System.Drawing.Point(469, 71)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(135, 20)
        Me.txtCopy.TabIndex = 6
        '
        'txtPy
        '
        Me.txtPy.Location = New System.Drawing.Point(469, 45)
        Me.txtPy.Name = "txtPy"
        Me.txtPy.Size = New System.Drawing.Size(135, 20)
        Me.txtPy.TabIndex = 5
        '
        'txtAdviser
        '
        Me.txtAdviser.Location = New System.Drawing.Point(469, 19)
        Me.txtAdviser.Name = "txtAdviser"
        Me.txtAdviser.Size = New System.Drawing.Size(135, 20)
        Me.txtAdviser.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(117, 49)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(117, 75)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(230, 20)
        Me.txtAuthor.TabIndex = 2
        '
        'txtCallNum
        '
        Me.txtCallNum.Location = New System.Drawing.Point(117, 19)
        Me.txtCallNum.Name = "txtCallNum"
        Me.txtCallNum.Size = New System.Drawing.Size(230, 20)
        Me.txtCallNum.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.callnum, Me.title, Me.author, Me.adviser, Me.py, Me.copy})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(844, 279)
        Me.DataGridView1.TabIndex = 7
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'callnum
        '
        Me.callnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.callnum.DataPropertyName = "callNum"
        Me.callnum.HeaderText = "Call No"
        Me.callnum.Name = "callnum"
        Me.callnum.ReadOnly = True
        Me.callnum.Width = 66
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
        'author
        '
        Me.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        Me.author.Width = 63
        '
        'adviser
        '
        Me.adviser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.adviser.DataPropertyName = "adviser"
        Me.adviser.HeaderText = "Adviser"
        Me.adviser.Name = "adviser"
        Me.adviser.ReadOnly = True
        Me.adviser.Width = 67
        '
        'py
        '
        Me.py.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.py.DataPropertyName = "py"
        Me.py.HeaderText = "Year"
        Me.py.Name = "py"
        Me.py.ReadOnly = True
        Me.py.Width = 54
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
        'thesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 478)
        Me.Controls.Add(Me.booksTotal)
        Me.Controls.Add(Me.searchCombo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "thesis"
        Me.Text = "thesis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents booksTotal As Label
    Friend WithEvents searchCombo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtCowqwpy As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCywqw As Label
    Friend WithEvents qw As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCopy As TextBox
    Friend WithEvents txtPy As TextBox
    Friend WithEvents txtAdviser As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtCallNum As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents callnum As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents adviser As DataGridViewTextBoxColumn
    Friend WithEvents py As DataGridViewTextBoxColumn
    Friend WithEvents copy As DataGridViewTextBoxColumn
End Class
