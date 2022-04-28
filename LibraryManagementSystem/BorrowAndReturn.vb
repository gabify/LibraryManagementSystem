Public Class BorrowAndReturn
    Dim borrowFunc As New classBorrow

    'Faculty Functions
    Private Sub populateBookFaculty()
        dgvBooksFaculty.Refresh()
        dgvBooksFaculty.DataSource = borrowFunc.getAllBooks("SELECT ID, accessionNum, title, remarks FROM tblBooks ORDER BY accessionNum")
    End Sub

    Private Sub populateEmployee()
        dgvEmployee.Refresh()
        dgvEmployee.DataSource = borrowFunc.getAllStudent("SELECT employeeId, employeeNum, employeeName FROM tblFacultyInfo")
    End Sub

    Private Sub searchaccessnumFaculty()
        dgvBooksFaculty.Refresh()
        dgvBooksFaculty.DataSource = borrowFunc.search("SELECT ID, accessionNum, title, remarks FROM tblBooks WHERE accessionNum LIKE @keyword ORDER BY accessionNum", txtsearchBookFaculty.Text.Trim)
    End Sub

    Private Sub searchTitleFaculty()
        dgvBooksFaculty.Refresh()
        dgvBooksFaculty.DataSource = borrowFunc.search("SELECT ID, accessionNum, title, remarks FROM tblBooks WHERE title LIKE @keyword ORDER BY accessionNum", txtsearchBookFaculty.Text.Trim)
    End Sub
    Private Sub searchEmployeeNum()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.search("SELECT employeeId, employeeNum, employeeName FROM tblFacultyInfo WHERE srcode LIKE @keyword", txtsearchEmployee.Text.Trim)
    End Sub
    Private Sub searchEmployeeName()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.search("SELECT employeeId, employeeNum, employeeName FROM tblFacultyInfo WHERE studentName LIKE @keyword", txtsearchEmployee.Text.Trim)
    End Sub
    Private Sub searchEmployee()
        If (rdEmployeeNum.Checked = True) Then
            searchEmployeeNum()
        ElseIf (rdEmployeeName.Checked = True) Then
            searchEmployeeName()
        End If
    End Sub
    Private Sub searchBookFaculty()
        If (rdaccessionNumFaculty.Checked = True) Then
            searchaccessnumFaculty()
        ElseIf (rdTitleFaculty.Checked = True) Then
            searchTitleFaculty()
        End If
    End Sub

    Private Sub clearFieldsFaculty()
        txtEmployeeName.Text = ""
        txtEmployeeNum.Text = ""
        txtAccessionNumFaculty.Text = ""
        txtTitleFaculty.Text = ""
    End Sub

    Private Sub borrowBookFaculty()
        If (dgvBooksFaculty.CurrentRow.Cells(3).Value.ToString = "Borrowed") Then
            MessageBox.Show("This book is already borrowed.")
        Else
            MessageBox.Show(borrowFunc.borrowFaculty("INSERT INTO tblFacultyBorrow (employeeId, bookId, dateBorrowed, isReturned) VALUES (@studentId, @bookId, @dateborrowed, @isReturned)",
                          dgvEmployee.CurrentRow.Cells(0).Value.ToString, dgvBooksFaculty.CurrentRow.Cells(0).Value.ToString))
            populateBookFaculty()
            populateEmployee()
            clearFieldsFaculty()
        End If
    End Sub
    Private Sub clearbookSearchFaculty()
        txtsearchBookFaculty.Text = ""
        rdaccessionNumFaculty.Checked = False
        rdTitleFaculty.Checked = False
    End Sub
    Private Sub clearStudentSearchEmployee()
        txtsearchEmployee.Text = ""
        rdEmployeeName.Checked = False
        rdEmployeeNum.Checked = False
    End Sub

    'Student Functions
    Private Sub populateBooks()
        DataGridView1.Refresh()
        DataGridView1.DataSource = borrowFunc.getAllBooks("SELECT ID, accessionNum, title, remarks FROM tblBooks ORDER BY accessionNum")
    End Sub
    Private Sub populateStudent()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.getAllStudent("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel, borrowedBooks FROM tblStudentInfo")
    End Sub

    Private Sub searchaccessnum()
        DataGridView1.Refresh()
        DataGridView1.DataSource = borrowFunc.search("SELECT ID, accessionNum, title, remarks FROM tblBooks WHERE accessionNum LIKE @keyword ORDER BY accessionNum", txtsearchbook.Text.Trim)
    End Sub

    Private Sub searchTitle()
        DataGridView1.Refresh()
        DataGridView1.DataSource = borrowFunc.search("SELECT ID, accessionNum, title, remarks FROM tblBooks WHERE title LIKE @keyword ORDER BY accessionNum", txtsearchbook.Text.Trim)
    End Sub
    Private Sub searchSrcode()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.search("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel, borrowedBooks FROM tblStudentInfo WHERE srcode LIKE @keyword", txtsearchStudent.Text.Trim)
    End Sub
    Private Sub searchName()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.search("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel, borrowedBooks FROM tblStudentInfo WHERE studentName LIKE @keyword", txtsearchStudent.Text.Trim)
    End Sub

    Private Sub searchstudent()
        If (rdsrcode.Checked = True) Then
            searchSrcode()
        ElseIf (rdName.Checked = True) Then
            searchName()
        End If
    End Sub
    Private Sub searchBook()
        If (rdacccesionNum.Checked = True) Then
            searchaccessnum()
        ElseIf (rdTitle.Checked = True) Then
            searchTitle()
        End If
    End Sub

    Private Sub clearbookSearch()
        txtsearchbook.Text = ""
        rdacccesionNum.Checked = False
        rdTitle.Checked = False
    End Sub
    Private Sub clearStudentSearch()
        txtsearchStudent.Text = ""
        rdsrcode.Checked = False
        rdName.Checked = False
    End Sub
    Private Sub borrowBook()
        If (Convert.ToInt32(DataGridView2.CurrentRow.Cells(3).Value) >= 2) Then
            MessageBox.Show("The maximum number of borrowed book reached.")
        ElseIf (DataGridView1.CurrentRow.Cells(3).Value.ToString = "Borrowed") Then
            MessageBox.Show("This book is already borrowed.")
        Else
            MessageBox.Show(borrowFunc.borrow("INSERT INTO tblBorrowStudent (studentID, bookId, dateBorrowed, isReturned) VALUES (@studentId, @bookId, @dateborrowed, @isReturned)",
                          DataGridView2.CurrentRow.Cells(0).Value.ToString, DataGridView1.CurrentRow.Cells(0).Value.ToString, DataGridView2.CurrentRow.Cells(3).Value.ToString))
            populateBooks()
            populateStudent()
            clearFields()
        End If
    End Sub

    Private Sub clearFields()
        txtsrcode.Text = ""
        txtname.Text = ""
        txtcourse.Text = ""
        txtyearLevel.Text = ""
        txtAccessionNum.Text = ""
        txtTitle.Text = ""
    End Sub

    'Load data
    Private Sub BorrowAndReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateBooks()
        populateStudent()
        populateBookFaculty()
        populateEmployee()

    End Sub

    Private Sub btnstudentSearch_Click(sender As Object, e As EventArgs) Handles btnstudentSearch.Click
        searchstudent()
    End Sub

    Private Sub btnSearchbook_Click(sender As Object, e As EventArgs) Handles btnSearchbook.Click
        searchBook()
    End Sub

    Private Sub btnrefreshbook_Click(sender As Object, e As EventArgs) Handles btnrefreshbook.Click
        populateBooks()
        clearbookSearch()
    End Sub
    Private Sub btnRefreshStudent_Click(sender As Object, e As EventArgs) Handles btnRefreshStudent.Click
        populateStudent()
        clearStudentSearch()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        borrowBook()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtAccessionNum.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtTitle.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        txtsrcode.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
        txtname.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
        txtcourse.Text = DataGridView2.CurrentRow.Cells(4).Value.ToString
        txtyearLevel.Text = DataGridView2.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub dgvBooksFaculty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooksFaculty.CellClick
        txtAccessionNumFaculty.Text = dgvBooksFaculty.CurrentRow.Cells(1).Value.ToString
        txtTitleFaculty.Text = dgvBooksFaculty.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        txtEmployeeNum.Text = dgvEmployee.CurrentRow.Cells(1).Value.ToString
        txtEmployeeName.Text = dgvEmployee.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btnSearchBookFaculty_Click(sender As Object, e As EventArgs) Handles btnSearchBookFaculty.Click
        searchBookFaculty()
    End Sub

    Private Sub btnSearchEmployee_Click(sender As Object, e As EventArgs) Handles btnSearchEmployee.Click
        searchEmployee()
    End Sub

    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        Dim form As New StudentRegistration
        form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New facultyRegistration
        form.Show()
    End Sub

    Private Sub btnRefreshEmployee_Click(sender As Object, e As EventArgs) Handles btnRefreshEmployee.Click
        populateEmployee()
        clearbookSearchFaculty()
    End Sub

    Private Sub btnRefreshBookFaculty_Click(sender As Object, e As EventArgs) Handles btnRefreshBookFaculty.Click
        populateBookFaculty()
        clearStudentSearchEmployee()
    End Sub

    Private Sub btnBorrowFaculty_Click(sender As Object, e As EventArgs) Handles btnBorrowFaculty.Click
        borrowBookFaculty()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearFields()
    End Sub

    Private Sub btnCancelFaculty_Click(sender As Object, e As EventArgs) Handles btnCancelFaculty.Click
        clearFieldsFaculty()
    End Sub

    Private Sub BorrowAndReturn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New main
        form.Show()
    End Sub
End Class