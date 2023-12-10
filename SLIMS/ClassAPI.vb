Imports System.IO
Imports System.Net
Imports System.Net.Http

Public Class ClassAPI
    Public Shared Async Function SendRequest(apiUrl As String) As Task(Of String)
        Using httpClient As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Return Await response.Content.ReadAsStringAsync()
                Else
                    Return $"HTTP error! Status: {response.StatusCode}"
                End If
            Catch ex As Exception
                Return $"An error occurred: {ex.Message}"
            End Try
        End Using
    End Function

    Public Shared Async Function GetImage(imageUrl As String, pictureBox As PictureBox) As Task
        ' Download the image from the URL
        Dim webRequest As WebRequest = WebRequest.Create(imageUrl)
        Dim webResponse As WebResponse = webRequest.GetResponse()
        Dim stream As Stream = webResponse.GetResponseStream()

        ' Set the image in the PictureBox
        If stream IsNot Nothing Then
            pictureBox.Image = Image.FromStream(stream)
            stream.Close()
        End If

        webResponse.Close()

        Return
    End Function
End Class
