Imports System.Net
Imports System.IO

Public Class ClassAPI
    Public Shared Function getString(apiUrl As String)
        Using client As New WebClient()
            Try
                ' Download the data as a string
                Dim responseData As String = client.DownloadString(apiUrl)
                Return responseData
            Catch ex As Exception
                ' Handle exceptions
                Return ex.Message
            End Try
        End Using
    End Function
End Class
