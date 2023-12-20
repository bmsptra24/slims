Imports Newtonsoft.Json
Public Class ClassUser
    Public Class TUser
        Public Property id As String
        Public Property name As String
        Public Property email As String
        Public Property nim As String
        Public Property alamat As String
        Public Property nohp As String
        Public Property password As String
        Public Property numBorrowedBooks As Integer?
        Public Property numReturnedBooks As Integer?
        Public Property rank As Integer
        Public Property createdAt As Date

    End Class

    Public Class TBook
        Public Property title As String
        Public Property description As String
        Public Property author As String
        Public Property publicationYear As String
    End Class

    Public Class TTransaction
        Public Property dateReturn As Date
        Public Property createdAt As Date
        Public Property isReturned As Boolean
        Public Property userId As String
        Public Property Book As TBook
    End Class

    Public Class TRank
        Public Property id As String
        Public Property name As String
        Public Property numReturnedBooks As Integer?
    End Class

    Public Shared selectedUser As String

    Public Shared userData As ClassUser.TUser

    Public Shared Async Function Count() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/count"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountInMonth(gte As String, lt As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/countInMonth?gte={gte}&lt={lt}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function SignIn(nim As String, password As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/signin?nim={nim}&password={password}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function SignUp(name As String, nim As String, address As String, email As String, phoneNumber As String, password As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/signup?name={Uri.EscapeDataString(name)}&nim={Uri.EscapeDataString(nim)}&address={Uri.EscapeDataString(address)}&email={Uri.EscapeDataString(email)}&phoneNumber={Uri.EscapeDataString(phoneNumber)}&password={Uri.EscapeDataString(password)}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Add() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/add"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function FindAll(take As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/findAll?take={take}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function FindUnique(id As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/findUnique?id={id}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Rank(take As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/rank?take={take}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Update(id As String, data As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/update?id={id}&data={data}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Delete(id As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/user/remove?id={id}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function


    Public Shared Async Function showTable(userControlUser As UserControlAccountManagement) As Task
        userControlUser.DataGridViewAccounts.Columns.Clear()
        userControlUser.DataGridViewAccounts.Rows.Clear()

        Dim json = Await FindAll("25")
        Console.WriteLine(json)
        Dim users As List(Of TUser) = JsonConvert.DeserializeObject(Of List(Of TUser))(json)

        ' Create table header
        userControlUser.DataGridViewAccounts.Columns.Add("id", "Id")
        userControlUser.DataGridViewAccounts.Columns.Add("name", "Name")
        userControlUser.DataGridViewAccounts.Columns.Add("email", "Email")
        userControlUser.DataGridViewAccounts.Columns.Add("nim", "NIM")
        userControlUser.DataGridViewAccounts.Columns.Add("alamat", "Alamat")
        userControlUser.DataGridViewAccounts.Columns.Add("nohp", "NoHP")
        userControlUser.DataGridViewAccounts.Columns.Add("password", "Password")
        userControlUser.DataGridViewAccounts.Columns.Add("numBorrowedBooks", "Borrowed Books")
        userControlUser.DataGridViewAccounts.Columns.Add("numReturnedBooks", "Returned Books")

        Dim filterText As String = userControlUser.TextBoxSearch.Text.ToLower()

        ' Add table values
        For Each user As TUser In users
            If user.name.ToLower().Contains(filterText) OrElse
           user.email.ToLower().Contains(filterText) OrElse
           user.alamat.ToLower().Contains(filterText) OrElse
           user.nim.ToLower().Contains(filterText) Then

                userControlUser.DataGridViewAccounts.Rows.Add(user.id, user.name, user.email, user.nim, user.alamat, user.nohp, user.password, user.numBorrowedBooks, user.numReturnedBooks)

            End If

        Next


    End Function

    Public Shared Async Function showHistory(memberControlHistory As MemberControlHistory) As Task
        memberControlHistory.DataGridViewHistory.Columns.Clear()
        memberControlHistory.DataGridViewHistory.Rows.Clear()

        Dim jsonTransactions = Await ClassTransaction.FindAll("25")
        Dim transactions As List(Of ClassUser.TTransaction) = JsonConvert.DeserializeObject(Of List(Of ClassUser.TTransaction))(jsonTransactions)

        ' Create table header
        memberControlHistory.DataGridViewHistory.Columns.Add("no", "No")
        memberControlHistory.DataGridViewHistory.Columns.Add("title", "Title")
        memberControlHistory.DataGridViewHistory.Columns.Add("description", "Description")
        memberControlHistory.DataGridViewHistory.Columns.Add("author", "Author")
        memberControlHistory.DataGridViewHistory.Columns.Add("publicationYear", "Year")
        memberControlHistory.DataGridViewHistory.Columns.Add("isReturned", "Is Returned")
        memberControlHistory.DataGridViewHistory.Columns.Add("dateReturn", "Last Return")
        memberControlHistory.DataGridViewHistory.Columns.Add("createdAt", "Created at")

        Dim filterText As String = memberControlHistory.TextBoxSearch.Text.ToLower()

        ' Add table values
        Dim i = 1
        For Each transaction As ClassUser.TTransaction In transactions
            ' Apply the filter condition
            If String.Equals(transaction.userId, ClassUser.userData.id) And
                (transaction.Book.title.ToLower().Contains(filterText) OrElse
                transaction.Book.description.ToLower().Contains(filterText) OrElse
                transaction.Book.publicationYear.ToLower().Contains(filterText) OrElse
                transaction.Book.author.ToLower().Contains(filterText)) Then

                memberControlHistory.DataGridViewHistory.Rows.Add(
                    i,
                    transaction.Book.title,
                    transaction.Book.description,
                    transaction.Book.author,
                    transaction.Book.publicationYear,
                    If(transaction.isReturned, "Yes", "No"),
                    transaction.dateReturn,
                    transaction.createdAt
                )
                i = i + 1
            End If
        Next
    End Function

    Public Shared Async Function showRank(memberControlRank As MemberControlRank) As Task
        'memberControlRank.LabelUserRank.Text = ClassUser.userData.rank

        Dim json = Await ClassUser.Rank("25")
        Console.WriteLine(json)
        Dim ranks As List(Of ClassUser.TRank) = JsonConvert.DeserializeObject(Of List(Of ClassUser.TRank))(json)

        ' Create table header
        memberControlRank.DataGridViewRank.Columns.Add("no", "No")
        memberControlRank.DataGridViewRank.Columns.Add("name", "Name")
        memberControlRank.DataGridViewRank.Columns.Add("numReturnedBooks", "Returned Book")

        ' Add table values
        Dim i = 1
        For Each rank As ClassUser.TRank In ranks
            If rank.id = userData.id Then
                memberControlRank.LabelUserRank.Text = i
            End If
            memberControlRank.DataGridViewRank.Rows.Add(
                i,
                rank.name,
                rank.numReturnedBooks
                )
            i = i + 1
        Next
    End Function
End Class
