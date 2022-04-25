Public Class classUser

    Dim connect As New connectionClass

    'Populate Data from database
    Public Function populateData(ByRef query As String) As DataTable
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query

        Dim table As New DataTable
        connect.conn.Open()
        connect.reader.SelectCommand = connect.op
        connect.reader.Fill(table)
        connect.conn.Close()
        Return table
    End Function

    'Add data in database
    Public Function Insert(ByRef dataSet As Array, ByRef query As String) As String
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@username", dataSet(0))
        connect.op.Parameters.AddWithValue("@password", dataSet(1))
        connect.op.Parameters.AddWithValue("@usertype", dataSet(2))
        Try
            connect.conn.Open()
            connect.op.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.ToString
        End Try
        connect.conn.Close()
        Return ""
    End Function

    'Update data in database
    Public Function Update(ByRef dataSet As Array, ByRef id As Integer, ByRef query As String) As Integer
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@id", id)
        connect.op.Parameters.AddWithValue("@username", dataSet(0))
        connect.op.Parameters.AddWithValue("@password", dataSet(1))
        connect.op.Parameters.AddWithValue("@usertype", dataSet(2))
        connect.conn.Open()
        connect.op.ExecuteNonQuery()
        connect.conn.Close()
        Return 0
    End Function

    'Delete data in database
    Public Function delete(ByVal id As Integer, ByRef query As String) As Integer
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@id", id)
        connect.conn.Open()
        connect.op.ExecuteNonQuery()
        connect.conn.Close()
        Return 0
    End Function

End Class
