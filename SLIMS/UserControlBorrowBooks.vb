Imports Newtonsoft.Json

Public Class UserControlBorrowBooks
    Public Class Response
        Public Property status As Boolean
    End Class
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim idBook As String = TextBoxIdBook.Text
        Dim json As String = Await ClassBook.isAvaible(idBook)
        Dim response = JsonConvert.DeserializeObject(Of Response)(json)

        Console.WriteLine(response)

        If response.status = True Then
            LabelIsBookAvaible.Text = "TBook available!"
        Else
            LabelIsBookAvaible.Text = "TBook not available!"
        End If

        Await Task.Delay(5000)

        LabelIsBookAvaible.Text = ""
    End Sub

    Private Async Sub ButtonDone_Click(sender As Object, e As EventArgs) Handles ButtonDone.Click
        Dim idBook As String = TextBoxIdBook.Text
        Dim idMember As String = TextBoxIdMember.Text
        Dim dateReturn As Date = MonthCalendarDeadline.SelectionStart

        Dim json = Await ClassTransaction.bookBorrow(dateReturn, idMember, idBook)
        If json = "HTTP error! Status: BadRequest" Then
            MsgBox("Invalid input!", MsgBoxStyle.Critical, "Warning")
            Return
        End If
        Dim response = JsonConvert.DeserializeObject(Of Response)(json)

        If response.status = True Then
            TextBoxIdBook.Text = ""
            TextBoxIdMember.Text = ""
            MessageBox.Show("TBook borrowed successfully!")
        Else
            MessageBox.Show("TBook failed to borrow!")
        End If
    End Sub
End Class
