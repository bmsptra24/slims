Imports Newtonsoft.Json

Public Class SignUpControl
    Class Response
        Public Property data As ClassUser.TUser
        Public Property status As Integer
    End Class
    Private Sub LabelSignIn_Click(sender As Object, e As EventArgs) Handles LabelSignIn.Click
        FormApp.Controls.Clear()

        Dim signInControl = New SignInControl()
        signInControl.Dock = DockStyle.Fill
        FormApp.Text = "Sign In"
        FormApp.Controls.Add(signInControl)
    End Sub

    Private Async Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        ' Check is password same?
        If Not String.Equals(TextBoxNewPassword.Text.Trim(), TextBoxConfirmPassword.Text.Trim(), StringComparison.Ordinal) Then
            Return
        End If

        Dim response = Await ClassUser.SignUp(TextBoxName.Text, TextBoxNim.Text, TextBoxAddress.Text, TextBoxEmail.Text, TextBoxPhoneNumber.Text, TextBoxNewPassword.Text)
        If response = "HTTP error! Status: NotFound" Then
            MsgBox("System error! Try again later", MsgBoxStyle.Critical)
            Return
        End If
        Dim json As Response = JsonConvert.DeserializeObject(Of Response)(response)

        If Integer.Equals(json.status, 200) Then
            FormApp.Controls.Clear()
            Dim signInControl = New SignInControl()
            signInControl.Dock = DockStyle.Fill
            FormApp.Text = "Sign In"
            FormApp.Controls.Add(signInControl)
            MsgBox("Sign Up successed!", MsgBoxStyle.MsgBoxRight)
        Else
            MsgBox("Sign Up Fail!", MsgBoxStyle.Critical)
        End If
        Console.WriteLine(json)
    End Sub
End Class
