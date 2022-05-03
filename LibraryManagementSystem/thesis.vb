Public Class thesis
    Dim category() As String = {"Call Number", "Title", "Author", "Adviser", "Year"}
    Dim dbfields() As String = {"callNum", "title", "author", "adviser", "py"}
    Dim thesisId As Integer
    Dim access As New classThesis


    Private Sub thesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchCombo.Items.Clear()
        For Each cat As String In category
            searchCombo.Items.Add(cat)
        Next
        displayDataInDgv()
        displayTotalThesis()
        getNumberOfRows()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'check if fields are empty
        If (access.ifempty(txtCallNum.Text)) Then
            MessageBox.Show("Call Number is empty")
        ElseIf (access.ifempty(txtAuthor.Text)) Then
            MessageBox.Show("Author is empty")
        ElseIf (access.ifempty(txtTitle.Text)) Then
            MessageBox.Show("Title is empty")
        ElseIf (access.ifempty(txtAdviser.Text)) Then
            MessageBox.Show("Publication is empty")
        ElseIf (access.ifempty(txtPy.Text)) Then
            MessageBox.Show("Copy is empty")
        ElseIf (access.ifempty(txtCopy.Text)) Then
            MessageBox.Show("Copyright Year is empty")
        Else
            Try
                Dim val As Integer = Convert.ToInt32(txtCopy.Text)

                'Save data in array
                Dim dataSet(5) As String

                dataSet(0) = txtCallNum.Text.Trim
                dataSet(1) = txtTitle.Text.Trim
                dataSet(2) = txtAuthor.Text.Trim
                dataSet(3) = txtAdviser.Text.Trim
                dataSet(4) = txtPy.Text.Trim
                dataSet(5) = txtCopy.Text.Trim

                'Insert data in database
                access.Insert(dataSet)

                'Update datagridview
                displayDataInDgv()

                'Clear textboxes
                clearTextboxes()
            Catch ex As FormatException
                MessageBox.Show("Please input number on copy.")
            End Try

        End If
        displayTotalThesis()
        getNumberOfRows()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Display data from datagridview to textboxes
        thesisId = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
        txtCallNum.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtAuthor.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtTitle.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtAdviser.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtPy.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtCopy.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            access.delete(thesisId, "DELETE FROM tblTheses WHERE ID = @id")
            displayDataInDgv()
            clearTextboxes()
        End If
        displayTotalThesis()
        getNumberOfRows()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim val As Integer = Convert.ToInt32(txtCopy.Text)
            Dim dataSet(6) As String

            dataSet(0) = txtCallNum.Text.Trim
            dataSet(1) = txtTitle.Text.Trim
            dataSet(2) = txtAuthor.Text.Trim
            dataSet(3) = txtAdviser.Text.Trim
            dataSet(4) = txtPy.Text.Trim
            dataSet(5) = txtCopy.Text.Trim

            'Update data in database
            access.update(thesisId, dataSet, "UPDATE tblTheses SET callNum = @callNum, title = @title, author = @author, adviser = @adviser, py = @py, copy = @copy WHERE ID = @id")

            'Update datagridview
            displayDataInDgv()

            'Clear textboxes
            clearTextboxes()
        Catch ex As FormatException
            MessageBox.Show("Please input number on copy")
        End Try
        displayTotalThesis()
        getNumberOfRows()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (searchCombo.SelectedIndex = -1) Then
            MessageBox.Show("Please select a search category.")
        Else
            If (txtsearch.Text = "") Then
                MessageBox.Show("Please input a search keyword.")
            Else
                'search(searchCombo.SelectedIndex, txtsearch.Text)
                DataGridView1.Refresh()
                DataGridView1.DataSource = access.search(searchCombo.SelectedIndex, txtsearch.Text)
                getNumberOfRows()
            End If
        End If
    End Sub

    Private Sub thesis_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New main()
        form.Show()
    End Sub

    Private Sub displayTotalThesis()
        thesisTotal.Text = "Total Number of Thesis: " + access.getTotalNumTheses("SELECT count(*) From tblTheses").ToString
    End Sub
    Private Sub clearTextboxes()
        'Clear textboxes
        txtCallNum.Text = ""
        txtAuthor.Text = ""
        txtTitle.Text = ""
        txtAdviser.Text = ""
        txtPy.Text = ""
        txtCopy.Text = ""
        txtsearch.Text = ""
        searchCombo.SelectedIndex = -1
    End Sub
    Private Sub getNumberOfRows()
        ThesisNum.Text = "Number of Thesis: " + DataGridView1.RowCount.ToString
    End Sub
    Private Sub displayDataInDgv()
        DataGridView1.Refresh()
        DataGridView1.DataSource = access.populateData
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        displayDataInDgv()
        getNumberOfRows()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dt As New DataTable
        dt = DataGridView1.DataSource
        access.export(dt)
    End Sub

    Private Sub txtCallNum_TextChanged(sender As Object, e As EventArgs) Handles txtCallNum.TextChanged

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged

    End Sub

    Private Sub txtCopy_TextChanged(sender As Object, e As EventArgs) Handles txtCopy.TextChanged

    End Sub

    Private Sub txtPy_TextChanged(sender As Object, e As EventArgs) Handles txtPy.TextChanged

    End Sub

    Private Sub txtAdviser_TextChanged(sender As Object, e As EventArgs) Handles txtAdviser.TextChanged

    End Sub

    Private Sub searchCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchCombo.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub
End Class