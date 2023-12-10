﻿Imports Newtonsoft.Json

Public Class SignInControl

    Class Response
        Public Property data As ClassUser.TUser
        Public Property category As String
        Public Property status As String
    End Class

    Public Async Function login(nim As String, password As String) As Task

        Dim response = Await ClassUser.SignIn(nim, password)

        Dim json As Response = JsonConvert.DeserializeObject(Of Response)(response)

        If json.status = "400" Then
            MessageBox.Show("Invalid Input!")
            Return
        End If

        If json.category = "admin" Then
            FormAdmin.LabelUserName.Text = json.data.name
            FormAdmin.Show()
        Else
            ClassUser.userData = json.data
            FormMember.LabelUserName.Text = json.data.name
            FormMember.Show()
        End If
    End Function

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nim As String = inputNim.Text
        Dim password As String = inputPassword.Text

        Await login(nim, password)
    End Sub

    Private Async Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Await login("123", "123")
    End Sub

    Private Sub LabelSignUp_Click(sender As Object, e As EventArgs) Handles LabelSignUp.Click
        FormApp.Controls.Clear()

        Dim signUpControl = New SignUpControl()
        FormApp.Text = "Sign Up"
        FormApp.Controls.Add(signUpControl)
    End Sub

End Class
