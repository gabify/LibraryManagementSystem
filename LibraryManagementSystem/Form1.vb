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
            ElseIf (result = 3) Then
                MessageBox.Show("Account do not have admin credentials.")
            Else
                Dim frm As New main
                frm.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub passcheck_CheckStateChanged(sender As Object, e As EventArgs) Handles passcheck.CheckStateChanged
        If (txtpassword.UseSystemPasswordChar = True) Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtusername_Click(sender As Object, e As EventArgs) Handles txtusername.Click
        txtusername.Text = ""
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        btnCancel.BackColor = Color.Transparent
        btnCancel.ForeColor = Color.DarkRed
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.DarkRed
        btnCancel.ForeColor = Color.Transparent
    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.Transparent
        btnLogin.ForeColor = Color.DarkRed
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.DarkRed
        btnLogin.ForeColor = Color.Transparent
    End Sub

    Private Sub txtpassword_Click(sender As Object, e As EventArgs) Handles txtpassword.Click
        txtpassword.Text = ""
    End Sub
End Class
