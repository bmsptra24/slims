Public Class MemberControlHome
    Private Async Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Await FormMember.showBookCover(Me)
    End Sub
End Class
