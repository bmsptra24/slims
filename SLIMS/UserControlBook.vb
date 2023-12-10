Imports Newtonsoft.Json

Public Class UserControlBook


    Private Async Sub DataGridViewBooks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBooks.CellValueChanged
        ' Check if the cell value change occurred in the "Year" column
        If e.RowIndex >= 0 Then

            Dim bookId As Integer = If(DataGridViewBooks.Rows(e.RowIndex).Cells("id").Value IsNot Nothing, CInt(DataGridViewBooks.Rows(e.RowIndex).Cells("id").Value), e.RowIndex)
            Dim bookTitle As String = If(DataGridViewBooks.Rows(e.RowIndex).Cells("title").Value IsNot Nothing, CStr(DataGridViewBooks.Rows(e.RowIndex).Cells("title").Value), "")
            Dim bookDescription As String = If(DataGridViewBooks.Rows(e.RowIndex).Cells("description").Value IsNot Nothing, CStr(DataGridViewBooks.Rows(e.RowIndex).Cells("description").Value), "")
            Dim bookAuthor As String = If(DataGridViewBooks.Rows(e.RowIndex).Cells("author").Value IsNot Nothing, CStr(DataGridViewBooks.Rows(e.RowIndex).Cells("author").Value), "")
            Dim publicationYear As String = If(DataGridViewBooks.Rows(e.RowIndex).Cells("publicationYear").Value IsNot Nothing, CStr(DataGridViewBooks.Rows(e.RowIndex).Cells("publicationYear").Value), "")
            Dim stock As Integer = If(DataGridViewBooks.Rows(e.RowIndex).Cells("stock").Value IsNot Nothing, CInt(DataGridViewBooks.Rows(e.RowIndex).Cells("stock").Value), 0)
            Dim coverId As String = If(DataGridViewBooks.Rows(e.RowIndex).Cells("coverId").Value IsNot Nothing, CStr(DataGridViewBooks.Rows(e.RowIndex).Cells("coverId").Value), "")
            Dim createdAt As DateTime = If(DataGridViewBooks.Rows(e.RowIndex).Cells("createdAt").Value IsNot Nothing, CDate(DataGridViewBooks.Rows(e.RowIndex).Cells("createdAt").Value), DateTime.MinValue)

            ' Create a new TBook object with the updated publicationYear
            Dim updatedBook As New ClassBook.Book With {
                .id = bookId,
                .title = bookTitle,
                .description = bookDescription,
                .author = bookAuthor,
                .publicationYear = publicationYear,
                .stock = stock,
                .coverId = coverId,
                .createdAt = createdAt
            }

            ' Convert the updatedBook object to JSON
            Dim updatedBookJson As String = JsonConvert.SerializeObject(updatedBook)

            Dim response = Await ClassBook.Update(bookId, updatedBookJson)

            ' Debug: Display the new JSON in the Output Window
            Console.WriteLine(response)

        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim json As String = Await ClassBook.Add()
        Console.WriteLine(json)

        FormAdmin.resetAllButtonNavigate(FormAdmin.btnBookManagement)
        Dim userControlBook = New UserControlBook()
        Await ClassBook.showTable(userControlBook)
        ClassNavigation.changeControl(userControlBook, FormAdmin.SplitContainer1.Panel2)
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim json As String = Await ClassBook.Delete(ClassBook.selectedBook.ToString())
        Console.WriteLine(json)

        FormAdmin.resetAllButtonNavigate(FormAdmin.btnBookManagement)
        Dim userControlBook = New UserControlBook()
        Await ClassBook.showTable(userControlBook)
        ClassNavigation.changeControl(userControlBook, FormAdmin.SplitContainer1.Panel2)
    End Sub

    Private Sub DataGridViewBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBooks.CellClick
        Dim bookId As Integer = If(DataGridViewBooks.Rows(e.RowIndex).Cells("id").Value IsNot Nothing, CInt(DataGridViewBooks.Rows(e.RowIndex).Cells("id").Value), e.RowIndex)
        ClassBook.selectedBook = bookId
    End Sub
End Class
