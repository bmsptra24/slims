Imports Newtonsoft.Json

Public Class UserControlBookEdit
    Public cover As Image


    Public Shared idBookEdit As Integer

    Public Class Params
        Public Property title As String
        Public Property description As String
        Public Property author As String
        Public Property publicationYear As String
        Public Property stock As Integer
        Public Property linkPdf As String
        Public Property cover As String
    End Class

    Private Async Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim title = TextBoxBookTitle.Text
        Dim author = TextBoxBookAuthor.Text
        Dim publicationYear = TextBoxPublicationYear.Text
        Dim stock = TextBoxStock.Text
        Dim linkPdf = TextBoxLinkPdf.Text
        Dim description = RichTextBoxDescription.Text
        If cover Is Nothing Then
            Return
        End If

        Dim base64String As String = ClassUtils.ImageToBase64String(cover)

        If String.IsNullOrEmpty(title) OrElse
            String.IsNullOrEmpty(author) OrElse
            String.IsNullOrEmpty(publicationYear) OrElse
            String.IsNullOrEmpty(stock) OrElse
            String.IsNullOrEmpty(description) OrElse
            String.IsNullOrEmpty(base64String) Then
            Return
        End If

        Dim response = Await ClassBook.Add(title, author, publicationYear, stock, linkPdf, base64String, description)
        Console.WriteLine(response)

        'back to book management control
        FormAdmin.btnBookManagement_Click(sender, e)
    End Sub

    Private Sub btnChooseCover_Click(sender As Object, e As EventArgs) Handles btnChooseCover.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image File|*.jpg;*.jpeg;*.png|All File|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            Dim originalImage As Image = Image.FromFile(filePath)

            Dim resizedImage As Image = ResizeImage(originalImage, ClassConfiguration.coverWidth, ClassConfiguration.coverHeight)

            PictureBoxCover.Image = resizedImage

            cover = resizedImage
            originalImage.Dispose()
        End If
    End Sub

    ' function to resize the image
    Private Function ResizeImage(image As Image, width As Integer, height As Integer) As Image
        Dim resizedImage As New Bitmap(width, height)
        Using graphics As Graphics = Graphics.FromImage(resizedImage)
            graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            graphics.DrawImage(image, 0, 0, width, height)
        End Using
        Return resizedImage
    End Function

End Class
