Imports System.Net
Imports Newtonsoft.Json
Imports SLIMS.ClassBook
Imports SLIMS.UserControlABook

Public Class FormMember

    Sub resetAllButtonNavigate(btnTarget As Button)
        ' Change button background color
        btnHome.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnHistory.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnComment.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnRank.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")

        ' Change button text color
        btnHome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnHistory.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnComment.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnRank.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")

        ' Change button target style
        btnTarget.BackColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnTarget.ForeColor = Color.White
    End Sub



    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial Homepage
        btnHome_Click(sender, e)

        ' The URL of the external image
        Dim imageUrl As String = "https://cdn.pixabay.com/photo/2019/08/11/18/59/icon-4399701_1280.png"

        Await ClassAPI.GetImage(imageUrl, PictureBoxProfilMember)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormApp.Show()
        Me.Dispose()
        Me.Close()
    End Sub

    Public Async Function showBookCover(memberControlHome As MemberControlHome) As Task
        memberControlHome.FlowLayoutPanelBookContainer.Controls.Clear()

        Dim json = Await ClassBook.FindAll("25")
        Dim books As List(Of ClassBook.Book) = JsonConvert.DeserializeObject(Of List(Of ClassBook.Book))(json)
        Dim filterText As String = memberControlHome.TextBoxSearch.Text.ToLower()

        For Each book As ClassBook.Book In books
            If book.title.ToLower().Contains(filterText) OrElse
                book.description.ToLower().Contains(filterText) Then

                Dim userControlABook = New UserControlABook()
                userControlABook.LabelBookTitle.Text = book.title
                userControlABook.LabelBookDescription.Text = book.description
                userControlABook.varBookId.Text = book.id
                userControlABook.varBookLink.Text = book.linkPdf
                If String.IsNullOrEmpty(book.cover) Then
                    Await ClassAPI.GetImage(ClassConfiguration.coverDefaultLink, userControlABook.PictureBoxCover)
                Else
                    userControlABook.PictureBoxCover.Image = ClassUtils.Base64StringToImage(book.cover)
                End If
                userControlABook.Margin = New Padding(20, 20, 20, 20)
                memberControlHome.FlowLayoutPanelBookContainer.Controls.Add(userControlABook)

            End If

        Next
    End Function

    Private Async Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        resetAllButtonNavigate(btnHome)

        Dim memberControlHome = New MemberControlHome()
        ClassNavigation.changeControl(memberControlHome, SplitContainer1.Panel2)

        Await showBookCover(memberControlHome)
    End Sub

    Private Async Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        resetAllButtonNavigate(btnHistory)
        Dim memberControlHistory = New MemberControlHistory()
        ClassNavigation.changeControl(memberControlHistory, SplitContainer1.Panel2)
        Await ClassUser.showHistory(memberControlHistory)
    End Sub

    Private Async Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        resetAllButtonNavigate(btnComment)
        Dim memberControlComment = New MemberControlComment()
        ClassNavigation.changeControl(memberControlComment, SplitContainer1.Panel2)
        Await ClassComment.showTable(memberControlComment)
    End Sub

    Private Async Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        resetAllButtonNavigate(btnRank)
        Dim memberControlRank = New MemberControlRank()
        ClassNavigation.changeControl(memberControlRank, SplitContainer1.Panel2)
        Await ClassUser.showRank(memberControlRank)
    End Sub

    Private Async Sub btnAskAI_Click(sender As Object, e As EventArgs) Handles btnAskAI.Click
        If RichTextBoxAskAI.Text = "" Then
            Return
        End If
        PanelParentAnswerAskAI.Visible = True
        ButtonClear.Visible = True

        Dim NewAnswerControlUser = New AskAIControlUser()
        NewAnswerControlUser.Dock = DockStyle.Top
        NewAnswerControlUser.LabelAnswer.Text = RichTextBoxAskAI.Text
        RichTextBoxAskAI.Text = ""
        PanelParentAnswerAskAI.Controls.Add(NewAnswerControlUser)

        Dim NewAnswerControlAI = New AskAIControlAI()
        NewAnswerControlAI.Dock = DockStyle.Top
        PanelParentAnswerAskAI.Controls.Add(NewAnswerControlAI)
        Dim response = Await ClassOpenAI.Ask(NewAnswerControlUser.LabelAnswer.Text)
        NewAnswerControlAI.LabelAnswer.Text = response.data
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        PanelParentAnswerAskAI.Controls.Clear()
        PanelParentAnswerAskAI.Visible = False
        ButtonClear.Visible = False
    End Sub
End Class
