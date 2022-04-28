Public Class main

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim form As New books()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnTheses_Click(sender As Object, e As EventArgs) Handles btnTheses.Click
        Dim form As New thesis()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim form As New BorrowAndReturn()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnJournal_Click(sender As Object, e As EventArgs) Handles btnJournal.Click
        Dim form As New journal()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim form As New BookReturn
        form.Show()
        Me.Close()
    End Sub
End Class