Imports Microsoft.VisualBasic.Devices
Imports System.Runtime.ConstrainedExecution
Imports System.ServiceModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json
Imports System.Net.Http
Imports SLIMS.UserControlBookEdit
Imports System.Text

Public Class ClassBook
    Public Class Book
        Public Property id As Integer
        Public Property title As String
        Public Property description As String
        Public Property author As String
        Public Property publicationYear As String
        Public Property stock As Integer
        Public Property linkPdf As String
        Public Property cover As String
        Public Property createdAt As DateTime
    End Class
    Public Shared selectedBook As Integer
    Public Shared Async Function Add(title As String, author As String, publicationYear As String, stock As String, linkPdf As String, cover As String, description As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/book/add"

        ' Create a Params object to hold your parameters
        Dim bookParams As New Params With {
        .title = title,
        .author = author,
        .publicationYear = publicationYear,
        .stock = stock,
        .linkPdf = linkPdf,
        .cover = cover,
        .description = description
    }

        ' Convert Params object to JSON
        Dim jsonParams As String = JsonConvert.SerializeObject(bookParams)

        ' Use HttpClient with HttpRequestMessage to send a POST request with the parameters in the body
        Using client As New HttpClient()
            Dim content As New StringContent(jsonParams, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync(apiUrl, content)
            Return Await response.Content.ReadAsStringAsync()
        End Using
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
        userControlBook.DataGridViewBooks.Columns.Clear()
        userControlBook.DataGridViewBooks.Rows.Clear()

        Dim json = Await ClassBook.FindAll("25")
        Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(json)

        'Create table header
        userControlBook.DataGridViewBooks.Columns.Add("id", "Id")
        userControlBook.DataGridViewBooks.Columns.Add("title", "Title")
        userControlBook.DataGridViewBooks.Columns.Add("description", "Description")
        userControlBook.DataGridViewBooks.Columns.Add("publicationYear", "Year")
        userControlBook.DataGridViewBooks.Columns.Add("author", "Author")
        userControlBook.DataGridViewBooks.Columns.Add("stock", "Stock")
        userControlBook.DataGridViewBooks.Columns.Add("linkPdf", "Link Pdf")
        userControlBook.DataGridViewBooks.Columns.Add("createdAt", "Created At")

        Dim filterText As String = userControlBook.TextBoxSearch.Text.ToLower()

        'add table value
        For Each book As Book In books
            If book.title.ToLower().Contains(filterText) OrElse
           book.description.ToLower().Contains(filterText) OrElse
           book.publicationYear.ToLower().Contains(filterText) OrElse
           book.author.ToLower().Contains(filterText) Then

                userControlBook.DataGridViewBooks.Rows.Add(book.id, book.title, book.description, book.publicationYear, book.author, book.stock, book.linkPdf, book.createdAt)
            End If

        Next

    End Function
End Class
