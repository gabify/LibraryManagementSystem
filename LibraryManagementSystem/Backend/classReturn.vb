Public Class classReturn
    Dim backend As New connectionClass

    'Student
    Public Function returnBook(ByRef borrowedStudentId As String, ByRef accessionNum As String, ByRef srcode As String) As String
        Try
            insertReturn(borrowedStudentId, accessionNum)
            updateBook(accessionNum)
            updateBorrowStudent(borrowedStudentId)
            updateStudentInfo(srcode)
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return "Book returned successfully"
    End Function

    'Add to return table
    Private Sub insertReturn(ByRef BorrowedstudentId As String, ByRef accessionNum As String)
        Dim now As Date = Today
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = "INSERT INTO tblReturnedBookStudent (borrowedStudentId, dateReturned, accessionNum) VALUES (@borrowedStudentId, @dateReturned, @accessionNum)"
        backEnd.op.Parameters.AddWithValue("@borrowedStudentId", Convert.ToInt32(BorrowedstudentId))
        backEnd.op.Parameters.AddWithValue("@dateReturn", now)
        backEnd.op.Parameters.AddWithValue("@accessionNum", Convert.ToInt32(accessionNum))
        backEnd.conn.Open()
        backEnd.op.ExecuteNonQuery()
        backEnd.conn.Close()
    End Sub

    'Update tblBooks
    Private Sub updateBook(ByRef accessionNum As String)
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblBooks SET remarks = 'Avaialble' WHERE accessionNum = @accessionNum"
        back1.op.Parameters.AddWithValue("@accessionNum", Convert.ToInt32(accessionNum))
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub

    'Update tblBorrowStudent

    Private Sub updateBorrowStudent(ByRef borrowStudentId As String)
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblBorrowStudent SET isReturned = 1 WHERE ID = @borrowStudentId"
        back1.op.Parameters.AddWithValue("@borrowStudentId", Convert.ToInt32(borrowStudentId))
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub

    'get number of Borrowed books
    Private Function getnumberOfBorrowedBooks(ByRef srcode As String) As Integer
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "SELECT borrowedBooks FROM tblStudentInfo WHERE srcode = @srcode"
        back1.op.Parameters.AddWithValue("@srcode", srcode)
        back1.conn.Open()
        Dim val As Integer = Convert.ToInt32(back1.op.ExecuteScalar)
        back1.conn.Close()
        Return val
    End Function

    'Update tblStudentInfo

    Private Sub updateStudentInfo(ByRef srcode As String)
        Dim borrowedBooks As Integer = getnumberOfBorrowedBooks(srcode)
        If (borrowedBooks > 0) Then
            borrowedBooks -= 1
        End If
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblStudentInfo SET borrowedBooks = @borrowedBooks WHERE srcode = @srcode"
        back1.op.Parameters.AddWithValue("@borrowedBooks", borrowedBooks)
        back1.op.Parameters.AddWithValue("@srcode", srcode)
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub

    'Faculty
    Public Function returnBookFaculty(ByRef borrowFacultyId As String, ByRef accessionNum As String) As String
        Try
            insertReturnFaculty(borrowFacultyId, accessionNum)
            updateBookFaculty(accessionNum)
            updateBorrowFaculty(borrowFacultyId)
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return "Book returned successfully"
    End Function
    'Add to return table
    Private Sub insertReturnFaculty(ByRef borrowFacultyId As String, ByRef accessionNum As String)
        Dim now As Date = Today
        backend.op.Parameters.Clear()
        backend.op.Connection = backend.conn
        backend.op.CommandType = CommandType.Text
        backend.op.CommandText = "INSERT INTO tblReturnedBookFaculty (borrowFacultyId, dateReturned, accessionNum) VALUES (@borrowFacultyId, @dateReturned, @accessionNum)"
        backend.op.Parameters.AddWithValue("@borrowFacultyId", Convert.ToInt32(borrowFacultyId))
        backend.op.Parameters.AddWithValue("@dateReturn", now)
        backend.op.Parameters.AddWithValue("@accessionNum", Convert.ToInt32(accessionNum))
        backend.conn.Open()
        backend.op.ExecuteNonQuery()
        backend.conn.Close()
    End Sub

    'Update tblBooks
    Private Sub updateBookFaculty(ByRef accessionNum As String)
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblBooks SET remarks = 'Avaialble' WHERE accessionNum = @accessionNum"
        back1.op.Parameters.AddWithValue("@accessionNum", Convert.ToInt32(accessionNum))
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub

    'Update tblBorrowStudent

    Private Sub updateBorrowFaculty(ByRef borrowFacultyId As String)
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblFacultyBorrow SET isReturned = 1 WHERE ID = @borrowwFacultyId"
        back1.op.Parameters.AddWithValue("@borrowFacultyId", Convert.ToInt32(borrowFacultyId))
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub
End Class
