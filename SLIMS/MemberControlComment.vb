Imports Newtonsoft.Json

Public Class MemberControlComment

    Private Async Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Await ClassComment.showTable(Me)
    End Sub

    Private Async Sub DataGridViewComment_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewComment.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim commentId As Integer = If(DataGridViewComment.Rows(e.RowIndex).Cells("id").Value IsNot Nothing, CInt(DataGridViewComment.Rows(e.RowIndex).Cells("id").Value), e.RowIndex)
            Dim bookId As String = If(DataGridViewComment.Rows(e.RowIndex).Cells("bookId").Value IsNot Nothing, CStr(DataGridViewComment.Rows(e.RowIndex).Cells("bookId").Value), "")
            Dim content As String = If(DataGridViewComment.Rows(e.RowIndex).Cells("content").Value IsNot Nothing, CStr(DataGridViewComment.Rows(e.RowIndex).Cells("content").Value), "")
            Dim createdAt As String = If(DataGridViewComment.Rows(e.RowIndex).Cells("createdAt").Value IsNot Nothing, CStr(DataGridViewComment.Rows(e.RowIndex).Cells("createdAt").Value), "")

            ' Create a new TBook object with the updated publicationYear
            Dim updatedComment As New ClassComment.TComment With {
                .id = commentId,
                .bookId = bookId,
                .content = content,
                .createdAt = createdAt,
                .userId = ClassUser.userData.id
            }

            ' Convert the updatedComment object to JSON
            Dim updatedCommentJson As String = JsonConvert.SerializeObject(updatedComment)

            Dim response = Await ClassComment.Update(commentId, updatedCommentJson)

            ' Debug: Display the new JSON in the Output Window
            Console.WriteLine(response)

        End If
    End Sub
End Class
