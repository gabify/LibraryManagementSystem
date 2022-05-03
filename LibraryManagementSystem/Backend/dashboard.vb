Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        reload()
    End Sub

    Private Sub reload()
        getNumberOfBooks()
        getNumberOfThesis()
        getNumberOfJournal()
        getReturnBooks()
        getNumberOfBorrow()
        getDateToday()
    End Sub

    Private Sub getNumberOfBooks()
        Dim book As New classBook
        numOfBooks.Text = book.getTotalNumBooks.ToString
    End Sub
    Private Sub getNumberOfThesis()
        Dim thesis As New classThesis
        numOfThesis.Text = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblTheses").ToString
    End Sub
    Private Sub getNumberOfJournal()
        Dim thesis As New classThesis
        numOfJournals.Text = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblJournals").ToString
    End Sub
    Private Sub getNumberOfBorrowed()
        Dim thesis As New classThesis
        numOfBorrowed.Text = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblJournals").ToString
    End Sub

    Private Sub getNumberOfBorrow()
        Dim thesis As New classThesis
        numOfBorrowed.Text = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblBooks WHERE remarks = 'Borrowed'").ToString
    End Sub

    Private Function getNumberOfReturnStudent() As Integer
        Dim thesis As New classThesis
        Dim now As Date = Today
        Dim dNow As String = now.ToString("d")
        Dim result As Integer = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblReturnedBookStudent WHERE dateReturned = #" + Date.Parse(dNow) + "#")
        Return result
    End Function
    Private Function getNumberOfReturnedFaculty() As Integer
        Dim thesis As New classThesis
        Dim now As Date = Today
        Dim dNow As String = now.ToString("d")
        Dim result As Integer = thesis.getTotalNumTheses("SELECT COUNT(*) FROM tblReturnedBookFaculty WHERE dateReturned = #" + Date.Parse(dNow) + "#")
        Return 0
    End Function

    Private Sub getReturnBooks()
        numOfReturn.Text = (getNumberOfReturnStudent() + getNumberOfReturnedFaculty()).ToString
    End Sub

    Private Sub getDateToday()
        Dim now As Date = Today
        dateToday.Text = now.ToShortDateString
    End Sub

    Private Sub btnInfoBooks_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInfoTheses_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reload()
    End Sub
End Class