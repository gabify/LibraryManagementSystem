Public Class main
    Dim user As String = ""
    Public Sub New(ByRef userType As String)

        ' This call is required by the designer.
        InitializeComponent()
        user = userType
        If (userType = "admin") Then
            btnUsers.Enabled = True
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim form As New books(user)
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnTheses_Click(sender As Object, e As EventArgs) Handles btnTheses.Click
        Dim form As New thesis(user)
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim form As New users(user)
        form.Show()
        Me.Close()
    End Sub
End Class