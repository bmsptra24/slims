Imports Newtonsoft.Json

Public Class UserControlABook
    Public Class Comment
        Public Property id As Integer
        Public Property content As String
        Public Property createdAt As Date
        Public Property userId As String
        Public Property bookId As Integer
    End Class

    Public Class Book
        Public Property id As Integer
        Public Property author As String
        Public Property cover As String
        Public Property createdAt As Date
        Public Property description As String
        Public Property publicationYear As String
        Public Property stock As Integer
        Public Property linkPdf As String
        Public Property title As String
        Public Property Comment As List(Of Comment)
    End Class

    Public Async Function seeBookDetail() As Task
        Dim memberControlBookDetail = New MemberControlBookDetail()
        Dim bookTitle = Me.LabelBookTitle.Text
        Dim bookId = Me.varBookId.Text

        memberControlBookDetail.LabelBookTitle.Text = bookTitle

        Dim json = Await ClassBook.FindUnique(bookId)
        Dim bookDetail As Book = JsonConvert.DeserializeObject(Of Book)(json)

        memberControlBookDetail.LabelBookId.Text = bookDetail.id
        memberControlBookDetail.LabelPublicationYear.Text = bookDetail.publicationYear
        memberControlBookDetail.LabelAuthor.Text = bookDetail.author
        memberControlBookDetail.LabelStock.Text = bookDetail.stock
        memberControlBookDetail.LabelDescription.Text = bookDetail.description
        memberControlBookDetail.linkPdf = bookDetail.linkPdf
        If bookDetail.linkPdf = "" Then
            memberControlBookDetail.ButtonGetItNow.Visible = False
        End If

        If String.IsNullOrEmpty(bookDetail.cover) Then
            Await ClassAPI.GetImage(ClassConfiguration.coverDefaultLink, memberControlBookDetail.PictureBoxCover)
        Else
            memberControlBookDetail.PictureBoxCover.Image = ClassUtils.Base64StringToImage(bookDetail.cover)
        End If

        Console.WriteLine(json)
        For Each comment As Comment In bookDetail.Comment
            Dim jsonUser = Await ClassUser.FindUnique(comment.userId.ToString())
            Dim userData = JsonConvert.DeserializeObject(Of ClassUser.TUser)(jsonUser)
            Dim memberControlCommentTemplate = New MemberControlCommentTemplate()
            memberControlCommentTemplate.Dock = DockStyle.Top
            memberControlCommentTemplate.LabelUserNameComment.Text = userData.name
            memberControlCommentTemplate.LabelContentComment.Text = comment.content
            memberControlBookDetail.FlowLayoutPanelComments.Controls.Add(memberControlCommentTemplate)
        Next

        ClassNavigation.changeControl(memberControlBookDetail, FormMember.SplitContainer1.Panel2)
    End Function

    Private Async Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Await seeBookDetail()
    End Sub

    Private Async Sub PictureBoxCover_Click(sender As Object, e As EventArgs) Handles PictureBoxCover.Click
        Await seeBookDetail()
    End Sub

End Class
