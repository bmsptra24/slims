Imports Newtonsoft.Json

Public Class ClassBook
    Public Class Book
        Public Property id As Integer
        Public Property title As String
        Public Property description As String
        Public Property author As String
        Public Property publicationYear As String
        Public Property stock As Integer
        Public Property coverId As String
        Public Property createdAt As DateTime
    End Class

    Public Shared selectedBook As Integer

    Public Shared Async Function Add() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/add"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Count() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/count"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function FindAll(take As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/findAll?take={take}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function FindUnique(id As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/findUnique?id={id}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Update(id As String, data As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/update?id={id}&data={data}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function Delete(id As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/remove?id={id}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountInMonth(gte As String, lt As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/countInMonth?gte={gte}&lt={lt}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function isAvaible(id As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/isAvaible?id={id}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function showTable(userControlBook As UserControlBook) As Task
        Dim json = Await ClassBook.FindAll("25")
        Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(json)

        'Create table header
        userControlBook.DataGridViewBooks.Columns.Add("id", "Id")
        userControlBook.DataGridViewBooks.Columns.Add("title", "Title")
        userControlBook.DataGridViewBooks.Columns.Add("description", "Description")
        userControlBook.DataGridViewBooks.Columns.Add("publicationYear", "Year")
        userControlBook.DataGridViewBooks.Columns.Add("author", "Author")
        userControlBook.DataGridViewBooks.Columns.Add("stock", "Stock")
        userControlBook.DataGridViewBooks.Columns.Add("coverId", "Cover ID")
        userControlBook.DataGridViewBooks.Columns.Add("createdAt", "Created At")

        'add table value
        For Each book As Book In books
            userControlBook.DataGridViewBooks.Rows.Add(book.id, book.title, book.description, book.publicationYear, book.author, book.stock, book.coverId, book.createdAt)
        Next

    End Function
End Class
