Public Class classRegistration
    Dim backend As New connectionClass
    Public Sub registerStudent(ByRef data() As String, ByRef query As String)
        backend.op.Parameters.Clear()
        backend.op.Connection = backend.conn
        backend.op.CommandType = CommandType.Text
        backend.op.CommandText = query
        backend.op.Parameters.AddWithValue("@srcode", data(0))
        backend.op.Parameters.AddWithValue("@studentName", data(1))
        backend.op.Parameters.AddWithValue("@course", data(2))
        backend.op.Parameters.AddWithValue("@yearLevel", data(3))
        backend.op.Parameters.AddWithValue("@borrowedBooks", 0)
        backend.conn.Open()
        backend.op.ExecuteNonQuery()
        backend.conn.Close()
    End Sub

    Public Sub registerEmployee(ByRef data() As String, ByRef query As String)
        backend.op.Parameters.Clear()
        backend.op.Connection = backend.conn
        backend.op.CommandType = CommandType.Text
        backend.op.CommandText = query
        backend.op.Parameters.AddWithValue("@employeeNum", data(0))
        backend.op.Parameters.AddWithValue("@employeeName", data(1))
        backend.conn.Open()
        backend.op.ExecuteNonQuery()
        backend.conn.Close()
    End Sub

End Class
