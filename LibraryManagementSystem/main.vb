Public Class main
    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim form As New books
        form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnTheses_Click(sender As Object, e As EventArgs) Handles btnTheses.Click
        Dim form As New thesis
        form.ShowDialog()
        Me.Close()
    End Sub
End Class