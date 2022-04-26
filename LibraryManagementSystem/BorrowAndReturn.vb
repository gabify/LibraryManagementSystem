Public Class BorrowAndReturn
    Dim borrowFunc As New classBorrow

    Private Sub populateBooks()
        DataGridView1.Refresh()
        DataGridView1.DataSource = borrowFunc.getAllBooks("SELECT ID, accessionNum, title, remarks FROM tblBooks ORDER BY accessionNum")
    End Sub
    Private Sub populateStudent()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.getAllStudent("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel FROM tblStudentInfo")
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
        DataGridView2.DataSource = borrowFunc.search("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel FROM tblStudentInfo WHERE srcode LIKE @keyword", txtsearchStudent.Text.Trim)
    End Sub
    Private Sub searchName()
        DataGridView2.Refresh()
        DataGridView2.DataSource = borrowFunc.search("SELECT ID, srcode, studentName, borrowedBooks, course, yearLevel FROM tblStudentInfo WHERE studentName LIKE @keyword", txtsearchStudent.Text.Trim)
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
        If (DataGridView1.CurrentRow.Cells(3).Value.ToString = "Borrowed") Then
            MessageBox.Show("This book is already borrowed.")
        Else
            MessageBox.Show(borrowFunc.borrow("INSERT INTO tblBorrowStudent (studentID, bookId, dateBorrowed, isReturned) VALUES (@studentId, @bookId, @dateborrowed, @isReturned)",
                          DataGridView2.CurrentRow.Cells(0).Value.ToString, DataGridView1.CurrentRow.Cells(0).Value.ToString))
            populateBooks()
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

    Private Sub BorrowAndReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateBooks()
        populateStudent()
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


End Class