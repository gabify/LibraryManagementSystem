Imports System.Data.OleDb
Imports System.Data
Public Class connectionClass
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Windows 10 Lite\Desktop\AccessDatabases\LibraryManagementSystemdb.mdb")
    Public op As New OleDbCommand
    Public reader As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Public operation As String
    Dim val As String



    Public Function login(ByVal username As String, ByVal password As String) As Integer
        logMeIn("SELECT password FROM tblUsers WHERE username = @username", username, password)
        Dim ob As Object
        conn.Open()
        ob = op.ExecuteScalar
        conn.Close()
        If (ob Is Nothing) Then
            Return 1
        Else
            val = ob.ToString()
            If (val = password) Then
                checkUserType("SELECT userType FROM tblUsers WHERE username = @username", username)
                conn.Open()
                Dim userType As String = op.ExecuteScalar.ToString
                conn.Close()

                If (userType = "admin" Or userType = "librarian") Then
                    Return 0
                Else
                    Return 3
                End If
            Else
                Return 2
            End If
        End If
    End Function

    Private Sub logMeIn(ByRef query As String, ByRef username As String, ByRef pass As String)
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = query
        op.Parameters.AddWithValue("@username", username)
    End Sub

    Private Sub checkUserType(ByRef query As String, ByRef username As String)
        op.Parameters.Clear()
        op.Connection = conn
        op.CommandType = CommandType.Text
        op.CommandText = query
        op.Parameters.AddWithValue("@username", username)
    End Sub

    Public Function ifempty(ByVal value As String) As Boolean
        If (value Is "") Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
