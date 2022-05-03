Public Class main

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        With books
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(books)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTheses_Click(sender As Object, e As EventArgs) Handles btnTheses.Click
        With thesis
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(thesis)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        With BorrowAndReturn
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(BorrowAndReturn)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnJournal_Click(sender As Object, e As EventArgs) Handles btnJournal.Click
        With journal
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(journal)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        With BookReturn
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(BookReturn)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        With dashboard
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dashboard
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        With registration
            .TopLevel = False
            displayPanel.Controls.Clear()
            displayPanel.Controls.Add(registration)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class