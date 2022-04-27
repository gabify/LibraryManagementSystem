Public Class facultyRegistration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registration As New classRegistration
        If (checkIfEmpty() = False) Then
            Dim data(1) As String

            data(0) = txtemployeeName.Text.Trim
            data(1) = txtemployeeNum.Text.Trim

            registration.registerEmployee(data, "INSERT INTO tblFacultyInfo (employeeName, employeeNum) 
VALUES(@employeeNum, @employeeName)")
            MessageBox.Show("Faculty registered successfully!")
            clearTextBox()
        End If
    End Sub

    Private Sub clearTextBox()
        txtemployeeNum.Text = ""
        txtemployeeName.Text = ""
    End Sub

    Private Function checkIfEmpty() As Boolean
        If (txtemployeeNum.Text = "") Then
            MessageBox.Show("Please input srcode")
            Return True
        ElseIf (txtemployeeName.Text = "") Then
            MessageBox.Show("Please input name")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class