Public Class fileUpload
    Dim accessionNum As Integer
    Public Sub New(ByRef accessionNum As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        accessionNum = accessionNum
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Dim books As New classBook
    Private Sub btnSelectpdf_Click(sender As Object, e As EventArgs) Handles btnSelectpdf.Click
        MessageBox.Show(books.selectPDF(accessionNum) + accessionNum.ToString)
    End Sub
End Class