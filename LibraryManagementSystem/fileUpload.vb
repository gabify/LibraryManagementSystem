Public Class fileUpload
    Dim accessionNum As Integer
    'Public Sub New(ByRef accessionNum As Integer)

    ' This call is required by the designer.
    'InitializeComponent()
    'accessionNum = accessionNum
    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Dim books As New classBook
    Private Sub btnSelectpdf_Click(sender As Object, e As EventArgs) Handles btnSelectpdf.Click
        Dim onlineService As New gdClass
        txtpath.Text = onlineService.selectPDF
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim onlineService As New gdClass
        MessageBox.Show(onlineService.upload(txtpath.Text, "sample.pdf", "sample", "application/vnd.google-apps.file"))
    End Sub
End Class