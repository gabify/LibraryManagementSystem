Imports LibraryManagementSystem.connectionClass
Public Class Form1
    Dim db As New connectionClass

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (db.ifempty(txtusername.Text) AndAlso db.ifempty(txtpassword.Text)) Then
            MessageBox.Show("Please input Username and Password")
        ElseIf (db.ifempty(txtusername.Text) AndAlso Not db.ifempty(txtpassword.Text)) Then
            MessageBox.Show("Please input Username")
        ElseIf (Not db.ifempty(txtusername.Text) AndAlso db.ifempty(txtpassword.Text)) Then
            MessageBox.Show("Please input Password")
        Else
            Dim result As Integer
            result = db.login(txtusername.Text.Trim, txtpassword.Text.Trim)
            If (result = 1) Then
                MessageBox.Show("Username does not exist")
            ElseIf (result = 2) Then
                MessageBox.Show("Incorrect Password")
            Else
                Dim frm As New main
                frm.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
