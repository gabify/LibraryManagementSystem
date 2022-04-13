Public Class classThesis
    Inherits connectionClass

    Dim dbfields() As String = {"callNum", "title", "author", "adviser", "py"}

    'Populate Data from database
    Public Function populateData() As DataTable
        operation = "SELECT * FROM tblTheses"
        Dim table As New DataTable
        conn.Open()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        reader.SelectCommand = op
        reader.Fill(table)
        conn.Close()
        Return table
    End Function

    'Add data in database
    Public Function Insert(ByVal dataSet As Array) As Integer
        operation = "INSERT INTO tblTheses (callNum, title, author, adviser, py, copy) 
VALUES (@callnum, @title,  @author, @adviser, @py, @copy)"
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@callnum", dataSet(0))
        op.Parameters.AddWithValue("@title", dataSet(1))
        op.Parameters.AddWithValue("@author", dataSet(2))
        op.Parameters.AddWithValue("@adivser", dataSet(3))
        op.Parameters.AddWithValue("@py", dataSet(4))
        op.Parameters.AddWithValue("@copy", Convert.ToInt32(dataSet(5)))
        conn.Open()
        Dim result = op.ExecuteNonQuery()
        conn.Close()
        Return result
    End Function

    'Update data in database
    Public Function update(ByVal id As Integer, ByVal dataSet As Array) As Integer
        operation = "UPDATE tblTheses SET callNum = @callNum, title = @title, author = @author, adviser = @adviser, py = @py, copy = @copy WHERE ID = @id"
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@callNum", dataSet(0))
        op.Parameters.AddWithValue("@title", dataSet(1))
        op.Parameters.AddWithValue("@author", dataSet(2))
        op.Parameters.AddWithValue("@adviser", dataSet(3))
        op.Parameters.AddWithValue("@py", dataSet(4))
        op.Parameters.AddWithValue("@copy", Convert.ToInt32(dataSet(5)))
        op.Parameters.AddWithValue("@id", id)
        conn.Open()
        op.ExecuteNonQuery()
        conn.Close()
        Return 0
    End Function

    'Delete data in database
    Public Function delete(ByVal id As Integer) As Integer
        operation = "DELETE FROM tblTheses WHERE ID = @id"
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@id", id)
        conn.Open()
        op.ExecuteNonQuery()
        conn.Close()
        Return 0
    End Function

    'Search data in database (Ayaw gumana dito)
    Public Function search(ByRef searchIndex As Integer, ByRef value As String) As DataTable
        Dim connect As New connectionClass
        Dim dt As New DataTable
        Dim searchVal As Integer
        connect.operation = "SELECT * FROM tblTheses WHERE " + dbfields(searchIndex) + " LIKE @value"
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = connect.operation

        If (dbFields(searchIndex) Is "accessionNum") Then
            searchVal = Convert.ToInt32(value)
            connect.op.Parameters.AddWithValue("@value", searchVal)
        Else
            connect.op.Parameters.AddWithValue("@value", "%" + value + "%")
        End If

        connect.conn.Open()
        connect.reader.SelectCommand = connect.op
        connect.reader.Fill(dt)
        connect.conn.Close()
        Return dt
    End Function

    'Upload pdf file in google drive

    'Count the total number of books
    Public Function getTotalNumTheses() As Integer
        operation = "SELECT count(*) From tblTheses"
        conn.Open()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        Dim result As Integer = Convert.ToInt32(op.ExecuteScalar)
        conn.Close()
        Return result
    End Function
End Class
