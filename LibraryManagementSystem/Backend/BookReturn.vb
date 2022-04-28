Public Class BookReturn
    Dim borrowFunc As New classBorrow
    Dim returnFunc As New classReturn
    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefreshStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnstudentSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnrefreshbook_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearchbook_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefreshEmployee_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearchEmployee_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelFaculty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefreshBookFaculty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearchBookFaculty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBorrowFaculty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBorrowVisitor_Click(sender As Object, e As EventArgs)

    End Sub
    'Student
    Private Sub getAllBorrowedBooksStudent()
        dgvBorrowedBooks.Refresh()
        dgvBorrowedBooks.DataSource = borrowFunc.getAllBooks("SELECT
 tblBorrowStudent.ID, tblBooks.accessionNum, tblBooks.title, tblStudentInfo.srcode, tblStudentInfo.studentName, tblBorrowStudent.dateBorrowed
from ( tblBooks inner join tblBorrowStudent on tblBooks.ID = tblBorrowStudent.bookID) inner join tblStudentInfo on tblStudentInfo.ID = tblBorrowStudent.studentId where tblBorrowStudent.isReturned = 0 ORDER BY accessionNum")
    End Sub
    Private Sub getAllReturnedBooksStudent()
        dgvReturnedBooks.Refresh()
        dgvReturnedBooks.DataSource = borrowFunc.getAllBooks("SELECT
 tblReturnedBookStudent.ID, tblBooks.accessionNum, tblBooks.title, tblReturnedBookStudent.dateReturned
from (tblBooks inner join tblReturnedBookStudent on tblBooks.accessionNum = tblReturnedBookStudent.accessionNum) order by tblBooks.accessionNum")
    End Sub

    Private Sub returnBookStudent()
        MessageBox.Show(returnFunc.returnBook(dgvBorrowedBooks.CurrentRow.Cells(0).Value.ToString, txtaccessNumreturn.Text, txtsrcodereturn.Text))
    End Sub

    Private Sub searchSrcode()
        dgvBorrowedBooks.Refresh()
        dgvBorrowedBooks.DataSource = borrowFunc.search("SELECT
 tblBorrowStudent.ID, tblBooks.accessionNum, tblBooks.title, tblStudentInfo.srcode, tblStudentInfo.studentName, tblBorrowStudent.dateBorrowed
from ( tblBooks inner join tblBorrowStudent on tblBooks.ID = tblBorrowStudent.bookID) inner join tblStudentInfo on tblStudentInfo.ID = tblBorrowStudent.studentId where tblBorrowStudent.isReturned = 0 AND tblStudentInfo.srcode LIKE @keyword ORDER BY accessionNum", txtborrowedStudent.Text.Trim)
    End Sub

    Private Sub clearsearchFieldsStudent()
        txtborrowedStudent.Text = ""
    End Sub

    'Faculty
    Private Sub getAllBorrowedBooksFaculty()
        dgvBorrowedBooksFaculty.Refresh()
        dgvBorrowedBooksFaculty.DataSource = borrowFunc.getAllBooks("SELECT
tblFacultyBorrow.ID, tblBooks.accessionNum, tblBooks.title, tblFacultyInfo.employeeNum, tblFacultyInfo.employeeName, tblFacultyBorrow.dateBorrowed
from ( tblBooks inner join tblFacultyBorrow on tblBooks.ID = tblFacultyBorrow.bookId) inner join tblFacultyInfo on tblFacultyInfo.employeeId = tblFacultyBorrow.employeeId where tblFacultyBorrow.isReturned = 0 ORDER BY accessionNum")
    End Sub
    Private Sub getAllReturnedBooksFaculty()
        dgvReturnFaculty.Refresh()
        dgvReturnFaculty.DataSource = borrowFunc.getAllBooks("SELECT
 tblReturnedBookFaculty.ID, tblBooks.accessionNum, tblBooks.title, tblReturnedBookFaculty.dateReturned
from (tblBooks inner join tblReturnedBookFaculty on tblBooks.accessionNum = tblReturnedBookFaculty.accessionNum) order by tblBooks.accessionNum")
    End Sub
    Private Sub returnBookFaculty()
        MessageBox.Show(returnFunc.returnBookFaculty(dgvBorrowedBooksFaculty.CurrentRow.Cells(0).Value.ToString, txtaccessionNumFaculty.Text))
        getAllBorrowedBooksFaculty()
        getAllReturnedBooksFaculty()
        clearFields()
    End Sub
    Private Sub searchFaculty()
        dgvBorrowedBooksFaculty.Refresh()
        dgvBorrowedBooksFaculty.DataSource = borrowFunc.search("SELECT
tblFacultyBorrow.ID, tblBooks.accessionNum, tblBooks.title, tblFacultyInfo.employeeNum, tblFacultyInfo.employeeName, tblFacultyBorrow.dateBorrowed
from ( tblBooks inner join tblFacultyBorrow on tblBooks.ID = tblFacultyBorrow.bookId) inner join tblFacultyInfo on tblFacultyInfo.employeeId = tblFacultyBorrow.employeeId where tblFacultyBorrow.isReturned = 0 AND tblFacultyInfo.employeeNum LIKE @keyword ORDER BY accessionNum", txtsearchBookFaculty.Text.Trim)
    End Sub



    Private Sub dgvBorrowedBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowedBooks.CellContentClick
        txtaccessNumreturn.Text = dgvBorrowedBooks.CurrentRow.Cells(1).Value.ToString
        txtTitlereturn.Text = dgvBorrowedBooks.CurrentRow.Cells(2).Value.ToString
        txtsrcodereturn.Text = dgvBorrowedBooks.CurrentRow.Cells(3).Value.ToString
        txtnamereturn.Text = dgvBorrowedBooks.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub dgvBorrowedBooksFaculty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowedBooksFaculty.CellClick
        txtaccessionNumFaculty.Text = dgvBorrowedBooksFaculty.CurrentRow.Cells(1).Value.ToString
        txtTitleFaculty.Text = dgvBorrowedBooksFaculty.CurrentRow.Cells(2).Value.ToString
        txtemployeeNum.Text = dgvBorrowedBooksFaculty.CurrentRow.Cells(3).Value.ToString
        txtEmployeeName.Text = dgvBorrowedBooksFaculty.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub clearFields()
        txtsrcodereturn.Text = ""
        txtnamereturn.Text = ""
        txtaccessNumreturn.Text = ""
        txtTitlereturn.Text = ""
    End Sub

    Private Sub btnBorrowVisitor_Click_1(sender As Object, e As EventArgs) Handles btnBorrowVisitor.Click
        returnBookStudent()
        getAllBorrowedBooksStudent()
        getAllReturnedBooksStudent()
        clearFields()
        clearsearchFieldsStudent()
    End Sub

    Private Sub BookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllBorrowedBooksStudent()
        getAllReturnedBooksStudent()
        getAllBorrowedBooksFaculty()
        getAllReturnedBooksFaculty()
    End Sub

    Private Sub BookReturn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New main
        form.Show()
    End Sub

    Private Sub btnsearchStudent_Click(sender As Object, e As EventArgs) Handles btnsearchStudent.Click
        searchSrcode()
    End Sub

    Private Sub btnRefreshBorrowedStudent_Click(sender As Object, e As EventArgs) Handles btnRefreshBorrowedStudent.Click
        getAllBorrowedBooksStudent()
        clearsearchFieldsStudent()
    End Sub

    Private Sub btnCancelVisitor_Click(sender As Object, e As EventArgs) Handles btnCancelVisitor.Click
        clearFields()
        clearsearchFieldsStudent()
    End Sub

    Private Sub btnReturnFaculty_Click(sender As Object, e As EventArgs) Handles btnReturnFaculty.Click
        returnBookFaculty()
    End Sub
End Class