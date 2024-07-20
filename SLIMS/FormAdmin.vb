Imports System.Net
Imports System.IO

Public Class FormAdmin

    ' Private Sub FormAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '     End
    ' End Sub

    Sub resetAllButtonNavigate(btnTarget As Button)
        'Change button background color
        btnDashboard.BackColor = Color.SlateBlue
        btnBorrowBooks.BackColor = Color.SlateBlue
        btnReturnBooks.BackColor = Color.SlateBlue
        btnBookManagement.BackColor = Color.SlateBlue
        btnAccountManagement.BackColor = Color.SlateBlue

        'Change button text color
        btnDashboard.ForeColor = Color.Lavender
        btnBorrowBooks.ForeColor = Color.Lavender
        btnReturnBooks.ForeColor = Color.Lavender
        btnBookManagement.ForeColor = Color.Lavender
        btnAccountManagement.ForeColor = Color.Lavender

        'Change button target style
        btnTarget.BackColor = Color.Lavender
        btnTarget.ForeColor = Color.Black
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init control to dashboard
        ClassNavigation.changeControl(New UserControlDashboard(), SplitContainer1.Panel2)

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        ' The URL of the external image
        Dim imageUrl As String = "https://cdn-icons-png.flaticon.com/512/2919/2919906.png"

        ' Download the image from the URL
        Dim webRequest As WebRequest = webRequest.Create(imageUrl)
        Dim webResponse As WebResponse = webRequest.GetResponse()
        Dim stream As Stream = webResponse.GetResponseStream()

        ' Set the image in the PictureBox
        If stream IsNot Nothing Then
            PictureBoxProfilAdmin.Image = Image.FromStream(stream)
            stream.Close()
        End If

        webResponse.Close()
    End Sub






    'Button Navigation OnClick
    Public Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        resetAllButtonNavigate(btnDashboard)
        ClassNavigation.changeControl(New UserControlDashboard(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnBorrowBooks_Click(sender As Object, e As EventArgs) Handles btnBorrowBooks.Click
        resetAllButtonNavigate(btnBorrowBooks)
        ClassNavigation.changeControl(New UserControlBorrowBooks(), SplitContainer1.Panel2)
    End Sub


    Private Sub btnReturnBooks_Click(sender As Object, e As EventArgs) Handles btnReturnBooks.Click
        resetAllButtonNavigate(btnReturnBooks)
        ClassNavigation.changeControl(New UserControlReturnBooks(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnBookManagement_Click(sender As Object, e As EventArgs) Handles btnBookManagement.Click
        resetAllButtonNavigate(btnBookManagement)
        ClassNavigation.changeControl(New UserControlBook(), SplitContainer1.Panel2)
    End Sub

    Private Sub btnAccountManagement_Click(sender As Object, e As EventArgs) Handles btnAccountManagement.Click
        resetAllButtonNavigate(btnAccountManagement)
        ClassNavigation.changeControl(New UserControlAccountManagement(), SplitContainer1.Panel2)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class