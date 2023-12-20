Imports Newtonsoft.Json

Public Class UserControlReturnBooks
    Public Class Response
        Public Property status As Boolean
    End Class

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transactionId As String = TextBoxIdTransaction.Text
        Dim json As String = Await ClassTransaction.bookReturn(transactionId)
        If json = "HTTP error! Status: BadRequest" Then
            MsgBox("Invalid input!", MsgBoxStyle.Critical, "Warning")
            Return
        End If

        Dim response = JsonConvert.DeserializeObject(Of Response)(json)
        If response.status = True Then
            MessageBox.Show("TBook returned successfully!")
        Else
            MessageBox.Show("TBook failed to returm!")
        End If
    End Sub

End Class
