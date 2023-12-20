Imports System.Net
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormAdmin
    Dim userControlLoading = New UserControlLoading()

    ' Private Sub FormAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '     End
    ' End Sub

    Public Sub resetAllButtonNavigate(btnTarget As Button)
        'Change button background color
        btnDashboard.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnBorrowBooks.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnReturnBooks.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnBookManagement.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")
        btnAccountManagement.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2efeb")

        'Change button text color
        btnDashboard.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnBorrowBooks.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnReturnBooks.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnBookManagement.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnAccountManagement.ForeColor = System.Drawing.ColorTranslator.FromHtml("#403235")

        'Change button target style
        btnTarget.BackColor = System.Drawing.ColorTranslator.FromHtml("#403235")
        btnTarget.ForeColor = Color.White
    End Sub

    Private Async Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init control to dashboard
        btnDashboard_Click(sender, e)

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        ' The URL of the external image
        Dim imageUrl As String = "https://cdn-icons-png.flaticon.com/512/2919/2919906.png"

        Await ClassAPI.GetImage(imageUrl, PictureBoxProfilAdmin)

    End Sub

    'Button Navigation OnClick
    Public Async Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        resetAllButtonNavigate(btnDashboard)
        ClassNavigation.changeControl(userControlLoading, SplitContainer1.Panel2)

        Dim userControlDashboard = New UserControlDashboard()
        ClassNavigation.changeControl(userControlDashboard, SplitContainer1.Panel2)


        'update label user
        userControlDashboard.LabelAccounts.Text = Await ClassUser.Count()
        userControlDashboard.LabelBooks.Text = Await ClassBook.Count()
        userControlDashboard.LabelBorrowed.Text = Await ClassTransaction.CountBorrow()
        userControlDashboard.LabelReturned.Text = Await ClassTransaction.CountReturn()

        'Update chart
        'USER
        userControlDashboard.ChartMember.Series.Clear()
        Dim seriesUser As New Series
        seriesUser.Name = "2023"
        seriesUser.ChartType = SeriesChartType.Line

        For i As Integer = 1 To 12
            Dim response = Await ClassUser.CountInMonth($"2023-{i}-01", $"202{If(i >= 12, "4", "3")}-{If(i >= 12, i, i + 1)}-01")
            seriesUser.Points.AddXY(i, response)
        Next

        userControlDashboard.ChartMember.Series.Add(seriesUser)


        'BOOKS
        userControlDashboard.ChartBooks.Series.Clear()
        Dim seriesBooks As New Series
        seriesBooks.Name = "2023"
        seriesBooks.ChartType = SeriesChartType.Line

        For i As Integer = 1 To 12
            Dim response = Await ClassBook.CountInMonth($"2023-{i}-01", $"202{If(i >= 12, "4", "3")}-{If(i >= 12, i, i + 1)}-01")
            seriesBooks.Points.AddXY(i, response)
        Next
        userControlDashboard.ChartBooks.Series.Add(seriesBooks)

        'BORROWED
        userControlDashboard.ChartBorrowed.Series.Clear()
        Dim seriesBorrow As New Series
        seriesBorrow.Name = "2023"
        seriesBorrow.ChartType = SeriesChartType.Line

        For i As Integer = 1 To 12
            Dim response = Await ClassTransaction.CountInMonthBorrow($"2023-{i}-01", $"202{If(i >= 12, "4", "3")}-{If(i >= 12, i, i + 1)}-01")
            seriesBorrow.Points.AddXY(i, response)
        Next
        userControlDashboard.ChartBorrowed.Series.Add(seriesBorrow)

        'RETUNED
        userControlDashboard.ChartReturned.Series.Clear()
        Dim seriesReturn As New Series
        seriesReturn.Name = "2023"
        seriesReturn.ChartType = SeriesChartType.Line

        For i As Integer = 1 To 12
            Dim response = Await ClassTransaction.CountInMonthReturn($"2023-{i}-01", $"202{If(i >= 12, "4", "3")}-{If(i >= 12, i, i + 1)}-01")
            seriesReturn.Points.AddXY(i, response)
        Next

        userControlDashboard.ChartReturned.Series.Add(seriesReturn)

    End Sub

    Private Sub btnBorrowBooks_Click(sender As Object, e As EventArgs) Handles btnBorrowBooks.Click
        resetAllButtonNavigate(btnBorrowBooks)
        ClassNavigation.changeControl(userControlLoading, SplitContainer1.Panel2)
        Dim userControlBorrowBooks = New UserControlBorrowBooks()
        ClassNavigation.changeControl(userControlBorrowBooks, SplitContainer1.Panel2)

    End Sub

    Private Sub btnReturnBooks_Click(sender As Object, e As EventArgs) Handles btnReturnBooks.Click
        resetAllButtonNavigate(btnReturnBooks)
        ClassNavigation.changeControl(New UserControlReturnBooks(), SplitContainer1.Panel2)


    End Sub

    Public Async Sub btnBookManagement_Click(sender As Object, e As EventArgs) Handles btnBookManagement.Click
        resetAllButtonNavigate(btnBookManagement)
        ClassNavigation.changeControl(userControlLoading, SplitContainer1.Panel2)

        Dim userControlBook = New UserControlBook()

        Await ClassBook.showTable(userControlBook)

        ClassNavigation.changeControl(userControlBook, SplitContainer1.Panel2)

    End Sub




    Private Async Sub btnAccountManagement_Click(sender As Object, e As EventArgs) Handles btnAccountManagement.Click
        resetAllButtonNavigate(btnAccountManagement)
        ClassNavigation.changeControl(userControlLoading, SplitContainer1.Panel2)

        Dim userControlAccount = New UserControlAccountManagement()

        Await ClassUser.showTable(userControlAccount)

        ClassNavigation.changeControl(userControlAccount, SplitContainer1.Panel2)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormApp.Show()
        Me.Dispose()
        Me.Close()
    End Sub
End Class