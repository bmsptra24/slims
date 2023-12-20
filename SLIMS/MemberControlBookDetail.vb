Public Class MemberControlBookDetail
    Public linkPdf As String

    Private Sub ButtonGetItNow_Click(sender As Object, e As EventArgs) Handles ButtonGetItNow.Click
        Process.Start(linkPdf)
    End Sub
End Class
