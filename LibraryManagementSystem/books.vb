Public Class books
    Dim booksDb As New classBook
    Dim bookId As Integer
    Dim category() As String = {"Accession Number", "Call Number", "Author", "Title", "Publication", "Copyright Year", "Status"}
    Dim dbFields() As String = {"accessionNum", "callNum", "author", "title", "publication", "cy", "remarks"}
    Dim status() As String = {"Available", "Borrowed", "Weeded-out", "Lost"}
    Dim user As String = ""

    Public Sub New(ByRef userType As String)

        ' This call is required by the designer.
        InitializeComponent()
        user = userType
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = booksDb.populateData()
        booksTotal.Text = "Total Number of Books: " + booksDb.getTotalNumBooks.ToString
        RowNum.Text = "Number of Books: " + DataGridView1.RowCount.ToString
        searchCombo.Items.Clear()
        For Each cat As String In category
            searchCombo.Items.Add(cat)
        Next
        For Each stats As String In status
            remarksCombo.Items.Add(stats)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'check if fields are empty
        If (booksDb.ifempty(txtCallNum.Text)) Then
            MessageBox.Show("Call Number is empty")
        ElseIf (booksDb.ifempty(txtAuthor.Text)) Then
            MessageBox.Show("Author is empty")
        ElseIf (booksDb.ifempty(txtTitle.Text)) Then
            MessageBox.Show("Title is empty")
        ElseIf (booksDb.ifempty(txtPublication.Text)) Then
            MessageBox.Show("Publication is empty")
        ElseIf (booksDb.ifempty(txtCy.Text)) Then
            MessageBox.Show("Copy is empty")
        ElseIf (booksDb.ifempty(txtCopy.Text)) Then
            MessageBox.Show("Copyright Year is empty")
        ElseIf (remarksCombo.SelectedIndex = -1) Then
            MessageBox.Show("Please specify the status")
        Else
            Try
                Dim val As Integer = Convert.ToInt32(txtCopy.Text)

                'Save data in array
                Dim dataSet(6) As String

                dataSet(0) = txtCallNum.Text.Trim
                dataSet(1) = txtAuthor.Text.Trim
                dataSet(2) = txtTitle.Text.Trim
                dataSet(3) = txtPublication.Text.Trim
                dataSet(4) = txtCy.Text.Trim
                dataSet(5) = txtCopy.Text.Trim
                dataSet(6) = remarksCombo.SelectedItem.ToString

                'Insert data in database
                booksDb.Insert(dataSet)

                'Update datagridview
                DataGridView1.Refresh()
                DataGridView1.DataSource = booksDb.populateData()
                booksTotal.Text = "Total Number of Books: " + booksDb.getTotalNumBooks.ToString
                RowNum.Text = "Number of Books: " + DataGridView1.RowCount.ToString

                'Clear textboxes
                clearTextbox()
            Catch ex As FormatException
                MessageBox.Show("Please input number on copy.")
            End Try

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer
        id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            booksDb.delete(id, "DELETE FROM tblBooks WHERE ID = @id")
            DataGridView1.Refresh()
            DataGridView1.DataSource = booksDb.populateData()
            booksTotal.Text = "Total Number of Books: " + booksDb.getTotalNumBooks.ToString
            RowNum.Text = "Number of Books: " + DataGridView1.RowCount.ToString
            clearTextbox()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Display data from datagridview to textboxes
        bookId = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
        txtaccessNum.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtCallNum.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtAuthor.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtTitle.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtPublication.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtCy.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtCopy.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        For i As Integer = 0 To 3
            If (status(i) = DataGridView1.CurrentRow.Cells(8).Value.ToString) Then
                remarksCombo.SelectedIndex = remarksCombo.FindString(status(i)).ToString
            End If
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (remarksCombo.SelectedIndex = -1) Then
            MessageBox.Show("Please specify the status")
        End If
        Try
            Dim val As Integer = Convert.ToInt32(txtCopy.Text)
            Dim dataSet(6) As String

            dataSet(0) = txtCallNum.Text.Trim
            dataSet(1) = txtAuthor.Text.Trim
            dataSet(2) = txtTitle.Text.Trim
            dataSet(3) = txtPublication.Text.Trim
            dataSet(4) = txtCy.Text.Trim
            dataSet(5) = txtCopy.Text.Trim
            dataSet(6) = remarksCombo.SelectedItem.ToString

            'Update data in database
            booksDb.update(bookId, dataSet)

            'Update datagridview
            DataGridView1.Refresh()
            DataGridView1.DataSource = booksDb.populateData()

            'Clear textboxes
            clearTextbox()
        Catch ex As FormatException
            MessageBox.Show("Please input number on copy")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (searchCombo.SelectedIndex = -1) Then
            MessageBox.Show("Please select a search category.")
        Else
            If (txtsearch.Text = "") Then
                MessageBox.Show("Please input a search keyword.")
            Else
                search(searchCombo.SelectedIndex, txtsearch.Text)
                RowNum.Text = "Number of Books: " + DataGridView1.RowCount.ToString
                'DataGridView1.Refresh()
                'DataGridView1.DataSource = booksDb.search(searchCombo.SelectedIndex, txtsearch.Text)
            End If
        End If

    End Sub

    'Dito ko nilagay kasi di nagana sa class
    Sub search(ByRef category As Integer, ByRef value As String)
        Dim connect As New connectionClass
        Dim dt As New DataTable
        Dim searchVal As Integer
        connect.operation = ""
        connect.op.Parameters.Clear()
        Try
            If (dbFields(category) Is "accessionNum") Then
                connect.operation = "SELECT * FROM tblBooks WHERE " + dbFields(category) + " LIKE @value ORDER BY accessionNum"
                searchVal = Convert.ToInt32(value)
                connect.op.Parameters.AddWithValue("@value", searchVal)
            Else
                Dim val() As String
                val = value.Split(" ")
                If (val.Length > 1) Then
                    connect.operation = "SELECT * FROM tblBooks WHERE " + dbFields(category) + " LIKE @value AND " + dbFields(category) + " LIKE @value1 ORDER BY accessionNum"
                    connect.op.Parameters.AddWithValue("@value", "%" + val(0) + "%")
                    connect.op.Parameters.AddWithValue("@value1", "%" + val(1) + "%")
                Else
                    connect.operation = "SELECT * FROM tblBooks WHERE " + dbFields(category) + " LIKE @value ORDER BY accessionNum"
                    connect.op.Parameters.AddWithValue("@value", "%" + val(0) + "%")
                End If
            End If

            connect.op.Connection = connect.conn
            connect.op.CommandType = CommandType.Text
            connect.op.CommandText = connect.operation
            connect.conn.Open()
            connect.reader.SelectCommand = connect.op
            connect.reader.Fill(dt)
            connect.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        DataGridView1.Refresh()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub books_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form As New main(user)
        form.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim data As New DataTable
        data = DataGridView1.DataSource
        booksDb.export(data)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'Clear textboxes
        clearTextbox()

        DataGridView1.Refresh()
        DataGridView1.DataSource = booksDb.populateData()
        RowNum.Text = "Number of Books: " + DataGridView1.RowCount.ToString
    End Sub

    Private Sub clearTextbox()
        'Clear textboxes
        txtaccessNum.Text = ""
        txtCallNum.Text = ""
        txtAuthor.Text = ""
        txtTitle.Text = ""
        txtPublication.Text = ""
        txtCy.Text = ""
        txtCopy.Text = ""
        txtsearch.Text = ""
        remarksCombo.SelectedIndex = -1
        searchCombo.SelectedIndex = -1
    End Sub
End Class