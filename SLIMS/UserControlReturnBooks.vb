Public Class UserControlReturnBooks

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(ClassAPI.getString("https://jsonplaceholder.typicode.com/posts/1"))

    End Sub
End Class
