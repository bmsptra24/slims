Public Class ClassTransaction

    Public Shared Async Function bookBorrow(dateReturn As Date, userId As String, bookId As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/add?dateReturn={dateReturn}&userId={userId}&bookId={bookId}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function bookReturn(transactionId As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/update?id={transactionId}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountInMonthBorrow(gte As String, lt As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/countInMonthBorrow?gte={gte}&lt={lt}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountInMonthReturn(gte As String, lt As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/countInMonthReturn?gte={gte}&lt={lt}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountBorrow() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/countBorrow"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function CountReturn() As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/countReturn"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function

    Public Shared Async Function FindAll(take As String) As Task(Of String)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/transaction/findAll?take={take}"
        Return Await ClassAPI.SendRequest(apiUrl)
    End Function
End Class
