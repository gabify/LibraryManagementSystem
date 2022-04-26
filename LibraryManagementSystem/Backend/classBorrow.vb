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
    Public Function borrow(ByRef query As String, ByRef studentId As String, ByRef bookId As String) As String
        'insert to tblborrowedStudent
        Dim now As Date = Today
        backEnd.op.Parameters.Clear()
        backEnd.op.Connection = backEnd.conn
        backEnd.op.CommandType = CommandType.Text
        backEnd.op.CommandText = query
        backEnd.op.Parameters.AddWithValue("@studentId", Convert.ToInt32(studentId))
        backEnd.op.Parameters.AddWithValue("@bookId", Convert.ToInt32(bookId))
        backEnd.op.Parameters.AddWithValue("@dateborrowed", now)
        backEnd.op.Parameters.AddWithValue("@isReturned", 0)

        'update tblBooks
        Dim back As New connectionClass
        back.op.Parameters.Clear()
        back.op.Connection = back.conn
        back.op.CommandType = CommandType.Text
        back.op.CommandText = "UPDATE tblBooks SET remarks = 'Borrowed' WHERE ID = " + bookId
        Try
            backEnd.conn.Open()
            backEnd.op.ExecuteNonQuery()
            backEnd.conn.Close()

            back.conn.Open()
            back.op.ExecuteNonQuery()
            back.conn.Close()
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return "Operation successful"
    End Function

    'Faculty Borrow


    'Visitor Borrow

End Class
