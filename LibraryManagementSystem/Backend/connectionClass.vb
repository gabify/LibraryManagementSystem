Imports System.Data.OleDb
Imports System.Data
Public Class connectionClass
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Windows 10 Lite\Desktop\AccessDatabases\LibraryManagementSystemdb.mdb")
    Public op As New OleDbCommand
    Public reader As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Public operation As String



    Public Function login(ByVal username As String, ByVal password As String) As Integer
        operation = "SELECT password FROM tblUsers WHERE username = @username"
        conn.Open()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = operation
        op.Parameters.AddWithValue("@username", username)
        Dim val As String = op.ExecuteScalar().ToString()
        conn.Close()
        If (val Is vbNullString) Then
            Return 1
        Else
            If (val = password) Then
                Return 0
            Else
                Return 2
            End If
        End If
    End Function

    Public Function ifempty(ByVal value As String) As Boolean
        If (value Is "") Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
