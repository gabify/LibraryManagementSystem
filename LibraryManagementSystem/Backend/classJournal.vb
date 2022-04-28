Imports ClosedXML.Excel

Public Class classJournal
    Dim connect As New connectionClass

    'Populate Data from database
    Public Function populateData(ByRef query As String) As DataTable
        connect.operation = "SELECT * FROM tblJournals"
        Dim table As New DataTable
        connect.op.Parameters.Clear()
        connect.conn.Open()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.reader.SelectCommand = connect.op
        connect.reader.Fill(table)
        connect.conn.Close()
        Return table
    End Function

    'Add data in database
    Public Function Insert(ByVal dataSet As Array, ByRef query As String) As Integer
        connect.operation = "INSERT INTO tblJournals (title, frequency) 
VALUES (@title, @frequency)"
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@title", dataSet(0))
        connect.op.Parameters.AddWithValue("@frequency", dataSet(1))
        connect.conn.Open()
        Dim result = connect.op.ExecuteNonQuery()
        connect.conn.Close()
        Return result
    End Function

    'Update data in database
    Public Function Update(ByVal dataSet As Array, ByRef query As String, ByRef id As String) As Integer
        connect.operation = "UPDATE tblJournals SET title = @title, frequency = @frequency WHERE ID = @id"
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@id", Convert.ToInt32(id))
        connect.op.Parameters.AddWithValue("@title", dataSet(0))
        connect.op.Parameters.AddWithValue("@frequency", dataSet(1))
        connect.conn.Open()
        Dim result = connect.op.ExecuteNonQuery()
        connect.conn.Close()
        Return result
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

    'Export to excel
    Public Function export(ByRef data As DataTable) As String
        Dim message As String = ""
        Using save As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook| *.xlsx"}
            If (save.ShowDialog() = DialogResult.OK) Then
                Try
                    Using wb As XLWorkbook = New XLWorkbook()
                        wb.Worksheets.Add(data, "Books")
                        wb.SaveAs(save.FileName)
                    End Using
                    message = "You have succcessfully exported your data."
                Catch ex As Exception
                    message = ex.ToString
                End Try
            End If
        End Using
        Return message
    End Function

    Public Function searchTitle(ByRef keyword As String, ByRef query As String) As DataTable
        Dim connect As New connectionClass
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@keyword", "%" + keyword + "%")
        Dim dt As New DataTable
        connect.conn.Open()
        connect.reader.SelectCommand = connect.op
        connect.reader.Fill(dt)
        connect.conn.Close()
        Return dt
    End Function

    Public Function searchFrequency(ByRef keyword As String, ByRef query As String) As DataTable
        Dim connect As New connectionClass
        connect.op.Parameters.Clear()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = query
        connect.op.Parameters.AddWithValue("@keyword", "%" + keyword + "%")
        Dim dt As New DataTable
        connect.conn.Open()
        connect.reader.SelectCommand = connect.op
        connect.reader.Fill(dt)
        connect.conn.Close()
        Return dt
    End Function

    'Count the total number of Journals
    Public Function getTotalNumJournals() As Integer
        Dim connect As New connectionClass
        connect.operation = "SELECT count(*) From tblJournals"
        connect.conn.Open()
        connect.op.Connection = connect.conn
        connect.op.CommandType = CommandType.Text
        connect.op.CommandText = connect.operation
        Dim result As Integer = Convert.ToInt32(connect.op.ExecuteScalar)
        connect.conn.Close()
        Return result
    End Function
End Class
