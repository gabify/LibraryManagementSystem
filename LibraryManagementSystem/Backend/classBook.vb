Imports System.Data
Imports System.Data.OleDb
Imports ClosedXML.Excel
Imports System.IO

Public Class classBook
    Inherits connectionClass

    Dim dbFields() As String = {"accessionNum", "callNum", "author", "title", "publication", "cy", "remarks"}
    'Populate Data from database
    Public Function populateData() As DataTable
        operation = "SELECT * FROM tblBooks ORDER BY accessionNum"
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
        Dim accessNum As Integer = getTotalNumBooks() + 1
        operation = "INSERT INTO tblBooks (accessionNum, callNum, author, title, publication, cy, copy, remarks) 
VALUES (@accessnum, @callnum, @author, @title, @publication, @cy, @copy, @remarks)"
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@accessnum", accessNum)
        op.Parameters.AddWithValue("@callnum", dataSet(0))
        op.Parameters.AddWithValue("@author", dataSet(1))
        op.Parameters.AddWithValue("@title", dataSet(2))
        op.Parameters.AddWithValue("@publication", dataSet(3))
        op.Parameters.AddWithValue("@cy", dataSet(4))
        op.Parameters.AddWithValue("@copy", Convert.ToInt32(dataSet(5)))
        op.Parameters.AddWithValue("@remarks", dataSet(6))
        conn.Open()
        Dim result = op.ExecuteNonQuery()
        conn.Close()
        Return result
    End Function

    'Update data in database
    Public Function update(ByVal id As Integer, ByVal dataSet As Array) As Integer
        operation = "UPDATE tblBooks SET callNum = @callNum, author = @author, title = @title, publication = @publication, cy = @cy, copy = @copy, remarks = @remarks WHERE id = @id"
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@callNum", dataSet(0))
        op.Parameters.AddWithValue("@author", dataSet(1))
        op.Parameters.AddWithValue("@title", dataSet(2))
        op.Parameters.AddWithValue("@publication", dataSet(3))
        op.Parameters.AddWithValue("@cy", dataSet(4))
        op.Parameters.AddWithValue("@copy", Convert.ToInt32(dataSet(5)))
        op.Parameters.AddWithValue("@remarks", dataSet(6))
        op.Parameters.AddWithValue("@id", id)
        conn.Open()
        op.ExecuteNonQuery()
        conn.Close()
        Return 0
    End Function

    'Delete data in database
    Public Function delete(ByVal id As Integer, ByRef query As String) As Integer
        op.Parameters.Clear()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = query
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
        connect.operation = "SELECT * FROM tblBooks WHERE " + dbFields(searchIndex) + " LIKE @value ORDER BY accessionNum"
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

    'Count the total number of books
    Public Function getTotalNumBooks() As Integer
        operation = "SELECT count(*) From tblBooks"
        conn.Open()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        Dim result As Integer = Convert.ToInt32(op.ExecuteScalar)
        conn.Close()
        Return result
    End Function

    Public Function selectPDF(ByRef acceesionNum As Integer) As String
        Dim pdfFile As String = ""
        Using open As OpenFileDialog = New OpenFileDialog() With {.Filter = "PDF| *.pdf"}
            If (open.ShowDialog = DialogResult.OK) Then
                pdfFile = open.FileName
                Return pdfFile
            End If
        End Using
        Return pdfFile
    End Function

End Class
