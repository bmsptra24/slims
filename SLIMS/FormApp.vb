
Public Class FormApp
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim signInControl = New SignInControl()
        Me.Controls.Add(signInControl)
        Me.Text = "Sign In"
    End Sub
End Class