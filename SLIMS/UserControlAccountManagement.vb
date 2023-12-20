Imports Newtonsoft.Json

Public Class UserControlAccountManagement

    Private Async Sub DataGridViewBooks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAccounts.CellValueChanged
        ' Check if the cell value change occurred in the "Name" column
        If e.RowIndex >= 0 Then

            Dim userId As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("id").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("id").Value), "")
            Dim userName As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("name").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("name").Value), "")
            Dim userEmail As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("email").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("email").Value), "")
            Dim userNim As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("nim").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("nim").Value), "")
            Dim userAlamat As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("alamat").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("alamat").Value), "")
            Dim userNohp As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("nohp").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("nohp").Value), "")
            Dim userPassword As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("password").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("password").Value), "")
            Dim numBorrowedBooks As Integer? = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("numBorrowedBooks").Value IsNot Nothing, CInt(DataGridViewAccounts.Rows(e.RowIndex).Cells("numBorrowedBooks").Value), Nothing)
            Dim numReturnedBooks As Integer? = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("numReturnedBooks").Value IsNot Nothing, CInt(DataGridViewAccounts.Rows(e.RowIndex).Cells("numReturnedBooks").Value), Nothing)

            ' Create a new TUser object with the updated information
            Dim updatedUser As New ClassUser.TUser With {
                .id = userId,
                .name = userName,
                .email = userEmail,
                .nim = userNim,
                .alamat = userAlamat,
                .nohp = userNohp,
                .password = userPassword,
                .numBorrowedBooks = numBorrowedBooks,
                .numReturnedBooks = numReturnedBooks
            }

            ' Convert the updatedUser object to JSON
            Dim updatedUserJson As String = JsonConvert.SerializeObject(updatedUser)

            ' Assuming you have an Update method in your ClassBook
            Dim response = Await ClassBook.Update(userId, updatedUserJson)

            ' Debug: Display the new JSON in the Output Window
            Console.WriteLine(response)

        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim json As String = Await ClassUser.Add()
        Console.WriteLine(json)

        FormAdmin.resetAllButtonNavigate(FormAdmin.btnAccountManagement)
        Dim userControlAccount = New UserControlAccountManagement()
        Await ClassUser.showTable(userControlAccount)
        ClassNavigation.changeControl(userControlAccount, FormAdmin.SplitContainer1.Panel2)
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim json As String = Await ClassUser.Delete(ClassUser.selectedUser.ToString())
        Console.WriteLine(json)

        FormAdmin.resetAllButtonNavigate(FormAdmin.btnAccountManagement)
        Dim userControlAccount = New UserControlAccountManagement()
        Await ClassUser.showTable(userControlAccount)
        ClassNavigation.changeControl(userControlAccount, FormAdmin.SplitContainer1.Panel2)
    End Sub

    Private Sub DataGridViewAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAccounts.CellClick
        Dim userId As String = If(DataGridViewAccounts.Rows(e.RowIndex).Cells("id").Value IsNot Nothing, CStr(DataGridViewAccounts.Rows(e.RowIndex).Cells("id").Value), e.RowIndex.ToString())
        ClassUser.selectedUser = userId
    End Sub

    Private Async Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Await ClassUser.showTable(Me)
    End Sub
End Class
