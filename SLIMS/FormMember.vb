Imports System.Net
Imports System.IO

Public Class FormMember

    Sub resetAllButtonNavigate(btnTarget As Button)
        'Change button background color
        btnHome.BackColor = Color.SlateBlue
        btnHistory.BackColor = Color.SlateBlue
        btnComment.BackColor = Color.SlateBlue
        btnRank.BackColor = Color.SlateBlue

        'Change button text color
        btnHome.ForeColor = Color.Lavender
        btnHistory.ForeColor = Color.Lavender
        btnComment.ForeColor = Color.Lavender
        btnRank.ForeColor = Color.Lavender

        'Change button target style
        btnTarget.BackColor = Color.Lavender
        btnTarget.ForeColor = Color.Black
    End Sub


     
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial Homepage
        ClassNavigation.changeControl(New MemberControlHome(), SplitContainer1.Panel2)

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        ' The URL of the external image
        Dim imageUrl As String = "https://cdn.pixabay.com/photo/2019/08/11/18/59/icon-4399701_1280.png"

        ' Download the image from the URL
        Dim webRequest As WebRequest = webRequest.Create(imageUrl)
        Dim webResponse As WebResponse = webRequest.GetResponse()
        Dim stream As Stream = webResponse.GetResponseStream()

        ' Set the image in the PictureBox
        If stream IsNot Nothing Then
            PictureBoxProfilMember.Image = Image.FromStream(stream)
            stream.Close()
        End If

        webResponse.Close()
    End Sub

    ' Private Sub MemberForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '    End
    ' End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)

        MessageBox.Show("https://jsonplaceholder.typicode.com/posts/1")

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        resetAllButtonNavigate(btnHome)
        ClassNavigation.changeControl(New MemberControlHome(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        resetAllButtonNavigate(btnHistory)
        ClassNavigation.changeControl(New MemberControlHistory(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        resetAllButtonNavigate(btnComment)
        ClassNavigation.changeControl(New MemberControlComment(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        resetAllButtonNavigate(btnRank)
        ClassNavigation.changeControl(New MemberControlRank(), SplitContainer1.Panel2)
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
