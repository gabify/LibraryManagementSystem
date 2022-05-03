Public Class journal

    Private Sub journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        getNumbers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        add()
    End Sub

    Private Sub add()
        Dim dataset(1) As String
        Dim journal As New classJournal
        dataset(0) = txtTitle.Text.Trim
        dataset(1) = txtfrequency.Text.Trim

        journal.Insert(dataset, "INSERT INTO tblJournals (title, frequency) 
VALUES (@title, @frequency)")
        loadData()
        getNumbers()
    End Sub

    Private Sub loadData()
        Dim journal As New classJournal
        DataGridView1.Refresh()
        DataGridView1.DataSource = journal.populateData("SELECT * FROM tblJournals")
        clearFields()
    End Sub
    Private Sub updateData()
        Dim journal As New classJournal
        journal.Update(txtTitle.Text.Trim, txtfrequency.Text.Trim, "UPDATE tblJournals SET title = @title, frequency = @frequency WHERE ID = @id", Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value))
        loadData()
        getNumbers()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtTitle.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtfrequency.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer
        id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim journal As New classJournal
            journal.delete(id, "DELETE FROM tblJournals WHERE ID = @id")
            loadData()
            getNumbers()
            clearFields()
        End If
    End Sub

    Private Sub clearFields()
        txtTitle.Text = ""
        txtfrequency.Text = ""
        txtsearch.Text = ""

        rdTitle.Checked = False
        rdFrequency.Checked = False
    End Sub

    Private Sub exportExcel()
        Dim journal As New classJournal
        MessageBox.Show(journal.export(DataGridView1.DataSource))
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        exportExcel()
    End Sub

    Private Sub getNumbers()
        Dim journals As New classJournal
        journalTotal.Text = "Total Number of Journals: " + journals.getTotalNumJournals.ToString
        RowNum.Text = "Number of Journals: " + DataGridView1.RowCount.ToString
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        loadData()
        clearFields()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search()
    End Sub

    Private Sub search()
        Dim cjournal As New classJournal
        If (rdTitle.Checked = True) Then
            DataGridView1.DataSource = cjournal.searchTitle(txtsearch.Text.Trim, "SELECT * FROM tblJournals WHERE title LIKE @keyword")
        ElseIf (rdFrequency.Checked = True) Then
            DataGridView1.DataSource = cjournal.searchTitle(txtsearch.Text.Trim, "SELECT * FROM tblJournals WHERE frequency LIKE @keyword")
        End If
    End Sub

    Private Sub journal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New main
        form.Show()
    End Sub
End Class