Public Class UserControlBookEdit

    Private Sub btnChooseCover_Click(sender As Object, e As EventArgs) Handles btnChooseCover.Click
        Dim openFileDialog As New OpenFileDialog()

        ' type file
        openFileDialog.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif|All File|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' add path file
            Dim filePath As String = openFileDialog.FileName

            ' display image and change thee height
            PictureBox1.Image = Image.FromFile(filePath)

        End If
    End Sub
End Class
