Public Class registration
    Dim register As New classRegistration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (checkIfStudentFieldEmpty() = False) Then
            Dim data(3) As String
            data(0) = txtsrcode.Text.Trim
            data(1) = txtname.Text.Trim
            data(2) = txtcourse.Text.Trim
            data(3) = txtyearLevel.Text.Trim
            register.registerStudent(data, "INSERT INTO tblStudentInfo (srcode, studentName, course, yearLevel, borrowedBooks) 
VALUES(@srcode, @studentName, @course, @yearLevel, @borrowedBooks)")
            MessageBox.Show("Student registered successfully!")
            clearTextBoxStudent()
        End If

    End Sub


    Private Function checkIfStudentFieldEmpty() As Boolean
        If (txtname.Text = "") Then
            Return True
            MessageBox.Show("Please input a name.")
        ElseIf (txtcourse.Text = "") Then
            Return True
            MessageBox.Show("Please input a course.")
        ElseIf (txtsrcode.Text = "") Then
            Return True
            MessageBox.Show("Please input a name.")
        ElseIf (txtyearLevel.Text = "") Then
            Return True
            MessageBox.Show("Please input a Year Level.")
        End If
        Return False
    End Function

    Private Function checkIfFacultyFieldEmpty() As Boolean
        If (txtemployeeNum.Text = "") Then
            Return True
            MessageBox.Show("Please input a Employee Number.")
        ElseIf (txtemployeeName.Text = "") Then
            Return True
            MessageBox.Show("Please input a Employee Name.")
        End If
        Return False
    End Function

    Private Sub clearTextBoxStudent()
        txtsrcode.Text = ""
        txtname.Text = ""
        txtcourse.Text = ""
        txtyearLevel.Text = ""
    End Sub
    Private Sub clearTextBoxFaculty()
        txtemployeeNum.Text = ""
        txtemployeeName.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearTextBoxStudent()
    End Sub

    Private Sub btnRegisterFaculty_Click(sender As Object, e As EventArgs) Handles btnRegisterFaculty.Click
        Dim registration As New classRegistration
        If (checkIfFacultyFieldEmpty() = False) Then
            Dim data(1) As String

            data(0) = txtemployeeName.Text.Trim
            data(1) = txtemployeeNum.Text.Trim

            registration.registerEmployee(data, "INSERT INTO tblFacultyInfo (employeeName, employeeNum) 
VALUES(@employeeNum, @employeeName)")
            MessageBox.Show("Faculty registered successfully!")
            clearTextBoxFaculty()
        End If
    End Sub
End Class