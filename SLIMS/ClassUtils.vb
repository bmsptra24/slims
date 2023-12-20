Public Class ClassUtils
    Public Shared Function ImageToBase64String(image As Image) As String
        Dim ms As New IO.MemoryStream()
        image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imageByte = ms.ToArray()
        Return Convert.ToBase64String(imageByte)
    End Function

    Public Shared Function Base64StringToImage(base64String As String) As Image
        Try
            Dim imageBytes As Byte() = Convert.FromBase64String(base64String)

            Dim ms As New IO.MemoryStream(imageBytes)

            Dim image As Image = Image.FromStream(ms)

            Return image
        Catch ex As Exception
            Throw New Exception("Failed to convert base64 string to Image.", ex)
            Return Nothing
        End Try
    End Function

End Class
