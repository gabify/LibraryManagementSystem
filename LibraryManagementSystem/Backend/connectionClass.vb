Imports System.Data.OleDb
Imports System.Data
Public Class connectionClass
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Windows 10 Lite\Desktop\LibraryManagementSystemdb.mdb")
    'Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|LibraryManagementSystemdb.mdb")
    Public op As New OleDbCommand
    Public reader As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Public operation As String
    Dim val As String
    Public Function ifempty(ByVal value As String) As Boolean
        If (value Is "") Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
