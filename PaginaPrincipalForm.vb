Public Class PaginaPrincipalForm
    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        Dim caixaForm As New CaixaForm()
        caixaForm.Show()
    End Sub

    Private Sub PaginaPrincipalForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D2 Then
            Dim caixaForm As New CaixaForm()
            caixaForm.Show()
        End If
    End Sub

    Private Sub Addproduto_Click(sender As Object, e As EventArgs) Handles Addproduto.Click
        Dim addProdutoForm As New AddProdutoForm()
        addProdutoForm.Show()
        Me.Hide()
    End Sub
End Class
