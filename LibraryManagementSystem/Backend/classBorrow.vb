Public Class classBorrow
    Dim backEnd As New connectionClass


    'Student borrow
    'Populate books
    Public Function getAllBooks(ByRef query As String) As DataTable
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = query
        backEnd.reader.SelectCommand = backEnd.op
        Dim dt As New DataTable
        backEnd.conn.Open()
        backEnd.reader.Fill(dt)
        backEnd.conn.Close()
        Return dt
    End Function

    'Populate books
    Public Function getAllStudent(ByRef query As String) As DataTable
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = query
        backEnd.reader.SelectCommand = backEnd.op
        Dim dt As New DataTable
        backEnd.conn.Open()
        backEnd.reader.Fill(dt)
        backEnd.conn.Close()
        Return dt
    End Function

    'Search data
    Public Function search(ByRef query As String, ByRef keyword As String) As DataTable
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = query
        backEnd.op.Parameters.AddWithValue("@keyword", "%" + keyword + "%")
        backEnd.reader.SelectCommand = backEnd.op
        Dim dt As New DataTable
        backEnd.conn.Open()
        backEnd.reader.Fill(dt)
        backEnd.conn.Close()
        Return dt
    End Function

    'Borrow book
    Public Function borrow(ByRef query As String, ByRef studentId As String, ByRef bookId As String, ByRef borrowedBooks As String) As String
        Try
            'insert to tblborrowedStudent
            insertBorrow(query, studentId, bookId)

            'update tblBooks
            updateBooks(bookId)

            'update tblStudentInfo
            updateStudent(studentId, borrowedBooks)
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return "Operation successful"
    End Function

    Private Sub insertBorrow(ByRef query As String, ByRef studentId As String, ByRef bookId As String)
        Dim now As Date = Today
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = query
        backEnd.op.Parameters.AddWithValue("@studentId", Convert.ToInt32(studentId))
        backEnd.op.Parameters.AddWithValue("@bookId", Convert.ToInt32(bookId))
        backEnd.op.Parameters.AddWithValue("@dateborrowed", now)
        backEnd.op.Parameters.AddWithValue("@isReturned", 0)
        backEnd.conn.Open()
        backEnd.op.ExecuteNonQuery()
        backEnd.conn.Close()
    End Sub

    Private Sub updateBooks(ByRef bookId As String)
        Dim back As New connectionClass
        back.op.Parameters.Clear()
        back.op.Connection = back.conn
        back.op.CommandType = CommandType.Text
        back.op.CommandText = "UPDATE tblBooks SET remarks = 'Borrowed' WHERE ID = " + bookId
        back.conn.Open()
        back.op.ExecuteNonQuery()
        back.conn.Close()
    End Sub
    Private Sub updateStudent(ByRef studentId As String, ByRef borrowedBooks As String)
        Dim back1 As New connectionClass
        back1.op.Parameters.Clear()
        back1.op.Connection = back1.conn
        back1.op.CommandType = CommandType.Text
        back1.op.CommandText = "UPDATE tblStudentInfo SET borrowedBooks = @borrowed WHERE ID = " + studentId
        back1.op.Parameters.AddWithValue("@borrowed", Convert.ToInt32(borrowedBooks) + 1)
        back1.conn.Open()
        back1.op.ExecuteNonQuery()
        back1.conn.Close()
    End Sub

    'Faculty Borrow
    Public Function borrowFaculty(ByRef query As String, ByRef studentId As String, ByRef bookId As String) As String
        Try
            'insert to tblborrowedStudent
            insertBorrow(query, studentId, bookId)

            'update tblBooks
            updateBooks(bookId)
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return "Operation successful"
    End Function

    'Return

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
        back1.op.Parameters.AddWithValue("@borrowStudentId", borrowStudentId)
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

End Class
