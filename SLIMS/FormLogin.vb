Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If inputNim.Text = "admin" And inputPassword.Text = "admin" Then
            FormAdmin.Show()
        Else
            FormMember.Show()
        End If
        Me.Hide()

    End Sub
End Class