Public Class MemberControlHistory

    Private Async Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Await ClassUser.showHistory(Me)
    End Sub

End Class
