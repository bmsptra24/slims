Imports Newtonsoft.Json

Public Class ClassOpenAI
    Class TAsk
        Public Property data As String
        Public Property status As Integer
    End Class
    Public Shared Async Function Ask(question As String) As Task(Of TAsk)
        Dim apiUrl As String = $"{ClassConfiguration.baseUrl}/openai/ask?question={question}"
        Dim response As String = Await ClassAPI.SendRequest(apiUrl)
        Dim json As TAsk = JsonConvert.DeserializeObject(Of TAsk)(response)
        Return json
    End Function
End Class
