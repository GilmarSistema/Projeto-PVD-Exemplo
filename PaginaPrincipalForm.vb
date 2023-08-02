Public Class PaginaPrincipalForm
    ' ... Outros códigos e eventos da classe ...

    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        AbrirCaixaForm()
    End Sub

    Private Sub PaginaPrincipalForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D2 Then
            AbrirCaixaForm()
        End If
    End Sub

    Private Sub AbrirCaixaForm()
        Dim caixaForm As New CaixaForm()
        caixaForm.Show()
        Me.Hide()
    End Sub

    Private Sub Addproduto_Click(sender As Object, e As EventArgs) Handles Addproduto.Click
        Dim addProdutoForm As New AddProdutoForm()
        addProdutoForm.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        ' Crie uma instância da UpdateForm
        Dim updateForm As New UpdateForm()

        ' Oculta a janela atual
        Me.Hide()

        ' Mostra a UpdateForm
        updateForm.ShowDialog() ' Use ShowDialog para bloquear interações com a janela anterior

        ' Depois que a UpdateForm for fechada, mostre novamente a janela principal
        Me.Show()
    End Sub
End Class
