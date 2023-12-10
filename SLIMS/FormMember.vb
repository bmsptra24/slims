Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports SLIMS.ClassBook
Imports System.Drawing.Printing

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

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        ' The URL of the external image
        Dim imageUrl As String = "https://cdn.pixabay.com/photo/2019/08/11/18/59/icon-4399701_1280.png"

        Await ClassAPI.GetImage(imageUrl, PictureBoxProfilMember)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormApp.Show()
        Me.Close()
    End Sub

    Private Async Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        resetAllButtonNavigate(btnHome)

        Dim memberControlHome = New MemberControlHome()
        ClassNavigation.changeControl(memberControlHome, SplitContainer1.Panel2)

        Dim json = Await ClassBook.FindAll("25")
        Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(json)

        For Each book As Book In books
            Dim userControlABook = New UserControlABook()
            userControlABook.LabelBookTitle.Text = book.title
            userControlABook.LabelBookDescription.Text = book.description
            userControlABook.varBookId.Text = book.id
            'ClassAPI.GetImage(book.coverId, userControlABook.PictureBoxCover)
            Await ClassAPI.GetImage("https://edit.org/images/cat/book-covers-big-2019101610.jpg", userControlABook.PictureBoxCover)

            userControlABook.Margin = New Padding(20, 20, 20, 20)
            memberControlHome.FlowLayoutPanelBookContainer.Controls.Add(userControlABook)
        Next
    End Sub

    Private Async Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        resetAllButtonNavigate(btnHistory)
        Dim memberControlHistory = New MemberControlHistory()
        ClassNavigation.changeControl(memberControlHistory, SplitContainer1.Panel2)
        Await ClassUser.showHistory(memberControlHistory)
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        resetAllButtonNavigate(btnComment)
        ClassNavigation.changeControl(New MemberControlComment(), SplitContainer1.Panel2)
    End Sub

    Private Async Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        resetAllButtonNavigate(btnRank)
        Dim memberControlRank = New MemberControlRank()
        ClassNavigation.changeControl(memberControlRank, SplitContainer1.Panel2)
        Await ClassUser.showRank(memberControlRank)
    End Sub

    Private Sub btnAskAI_Click(sender As Object, e As EventArgs) Handles btnAskAI.Click
        If RichTextBoxAskAI.Text = "" Then
            Return
        End If
        PanelParentAnswerAskAI.Visible = True

        Dim NewAnswerControlUser = New AskAIControlUser()
        NewAnswerControlUser.Dock = DockStyle.Top
        NewAnswerControlUser.LabelAnswer.Text = RichTextBoxAskAI.Text
        RichTextBoxAskAI.Text = ""
        PanelParentAnswerAskAI.Controls.Add(NewAnswerControlUser)

        Dim NewAnswerControlAI = New AskAIControlAI()
        NewAnswerControlAI.Dock = DockStyle.Top
        NewAnswerControlAI.LabelAnswer.Text = "Ya benar sekali!"
        PanelParentAnswerAskAI.Controls.Add(NewAnswerControlAI)
    End Sub
End Class
