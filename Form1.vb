Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Verifica se o nome de usuário e a senha correspondem a uma combinação fixa
        If username = "123" AndAlso password = "" Then
            ' Credenciais corretas, abre a próxima janela (PaginaPrincipalForm)
            Dim paginaPrincipal As New PaginaPrincipalForm()
            paginaPrincipal.Show()

            ' Esconde o formulário atual (Form1) após o login bem-sucedido (opcional)
            Me.Hide()
        Else
            ' Credenciais inválidas, não exibe mensagem de erro
            ' Mas você pode adicionar aqui alguma lógica de feedback visual (por exemplo, mudar a cor do campo de senha)
        End If
    End Sub
End Class
