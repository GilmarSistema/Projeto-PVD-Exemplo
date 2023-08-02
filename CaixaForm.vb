Imports System.Data.SQLite
Imports System.IO

Public Class CaixaForm
    Inherits Form

    Private dbFolderPath As String = Path.Combine(Application.StartupPath, "Database")
    Private dbFileName As String = Path.Combine(dbFolderPath, "caixa_db.db")
    Private connectionString As String = $"Data Source={dbFileName}"
    Private connection As SQLiteConnection
    Private produtosNoCarrinho As List(Of ProdutoNoCarrinho)
    Private valorTotal As Double

    Private Sub LoadItemsToDataGridView()
        ' ... Código para carregar DataGridView ...
    End Sub

    Private Sub CarregarDadosNoListView()
        ' ... Código para carregar ListView ...
    End Sub

    Private Sub CalcularTroco()
        ' ... Código para calcular troco ...
    End Sub

    Private Sub CaixaForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim keyword As String = "update"
        Dim currentInput As String = ""

        If e.KeyCode = Keys.Enter Then
            If currentInput.ToLower() = keyword Then
                Dim updateForm As New UpdateForm()
                updateForm.Show()
            End If

            currentInput = ""
        Else
            currentInput += e.KeyCode.ToString().ToLower()
        End If
    End Sub
End Class


Public Class ProdutoNoCarrinho
    Public Property Codigo As String
    Public Property Nome As String
    Public Property Valor As Double
End Class
