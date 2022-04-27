Public Class StudentRegistration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registration As New classRegistration
        If (checkIfEmpty() = False) Then
            Dim data(3) As String

            data(0) = txtsrcode.Text.Trim
            data(1) = txtname.Text.Trim
            data(2) = txtcourse.Text.Trim
            data(3) = txtyearLevel.Text.Trim
            registration.registerStudent(data, "INSERT INTO tblStudentInfo (srcode, studentName, course, yearLevel, borrowedBooks) 
VALUES(@srcode, @studentName, @course, @yearLevel, @borrowedBooks)")
            MessageBox.Show("Student registered successfully!")
            clearTextBox()
        End If
    End Sub

    Private Sub clearTextBox()
        txtsrcode.Text = ""
        txtname.Text = ""
        txtcourse.Text = ""
        txtyearLevel.Text = ""
    End Sub

    Private Function checkIfEmpty() As Boolean
        If (txtsrcode.Text = "") Then
            MessageBox.Show("Please input srcode")
            Return True
        ElseIf (txtname.Text = "") Then
            MessageBox.Show("Please input name")
            Return True
        ElseIf (txtcourse.Text = "") Then
            MessageBox.Show("Please input course")
            Return True
        ElseIf (txtyearLevel.Text = "") Then
            MessageBox.Show("Please input Year Level")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class