Imports Newtonsoft.Json

Public Class ClassComment
    Public Class TComment
        Public Property id As Integer
        Public Property content As String
        Public Property createdAt As DateTime
        Public Property userId As String
        Public Property bookId As Integer
    End Class

    Public Shared Async Function FindAll(take As String, userId As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/comment/findAll?take={take}&userId={userId}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Update(id As String, data As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/comment/update?id={id}&data={data}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function showTable(memberControlComment As MemberControlComment) As Task
        memberControlComment.DataGridViewComment.Columns.Clear()
        memberControlComment.DataGridViewComment.Rows.Clear()

        Dim json = Await ClassComment.FindAll("25", ClassUser.userData.id)
        Dim comments As List(Of TComment) = JsonConvert.DeserializeObject(Of List(Of TComment))(json)

        'Create table header
        memberControlComment.DataGridViewComment.Columns.Add("id", "Id")
        memberControlComment.DataGridViewComment.Columns.Add("bookId", "Book ID")
        memberControlComment.DataGridViewComment.Columns.Add("content", "Content")
        memberControlComment.DataGridViewComment.Columns.Add("createdAt", "Create At")

        Dim filterText As String = memberControlComment.TextBoxSearch.Text.ToLower()

        'add table value
        For Each comment As TComment In comments
            If comment.userId = ClassUser.userData.id And comment.content.ToLower().Contains(filterText) Then

                memberControlComment.DataGridViewComment.Rows.Add(comment.id, comment.bookId, comment.content, comment.createdAt)
            End If

        Next

    End Function
End Class
