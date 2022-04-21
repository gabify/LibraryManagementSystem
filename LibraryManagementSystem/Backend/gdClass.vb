Imports System.Data.SqlClient
Imports System.Configuration
Imports Google.Apis.Auth
Imports Google.Apis.Download
Imports Google.Apis.Drive.v2
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports System.Threading
Imports Google.Apis.Drive.v2.Data
Public Class gdClass

    Public service As New DriveService

    'Select PDF file using open file dialog
    Public Function selectPDF() As String
        Dim pdfFile As String = ""
        Using open As OpenFileDialog = New OpenFileDialog() With {.Filter = "PDF| *.pdf"}
            If (open.ShowDialog = DialogResult.OK) Then
                pdfFile = open.FileName
                Return pdfFile
            End If
        End Using
        Return pdfFile
    End Function

    'Upload PDF to google drive
    Public Function upload(ByRef filepath As String, ByRef title As String, ByRef desc As String, ByRef mimetype As String) As String
        Try
            If service.ApplicationName <> "Library Inventory System" Then createService()
            Dim file As New File
            Dim folderId = "1_DTJBVxOnewXr_lq9yi0p0GfsEdnHjpS"
            file.Title = title
            file.Description = desc
            file.MimeType = mimetype
            'file.Parents = New List(Of ParentReference) From {New ParentReference() With {.Id = folderId}}
            Dim byteArray As Byte() = System.IO.File.ReadAllBytes(filepath)
            Dim stream As New System.IO.MemoryStream(byteArray)
            Dim uploadRequest As FilesResource.InsertMediaUpload = service.Files.Insert(file, stream, file.MimeType)
            uploadRequest.Upload()

            Dim f As File = uploadRequest.ResponseBody

            Return f.Id
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    'OAuth function
    Private Sub createService()
        Dim clientId = "594723546770-egfjl2gdma5bpi5ad3551mte2sdqfsu1.apps.googleusercontent.com"
        Dim clientSecret = "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"

        Dim uc As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = clientId, .ClientSecret = clientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
        service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = uc, .ApplicationName = "Library Inventory System"})
    End Sub

End Class
