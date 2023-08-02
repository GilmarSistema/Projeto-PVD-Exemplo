Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms

Public Class CaixaForm
    Private dbFolderPath As String = Path.Combine(Application.StartupPath, "Database")
    Private dbFileName As String = Path.Combine(dbFolderPath, "caixa_db.db")
    Private connectionString As String = $"Data Source={dbFileName}"
    Private connection As SQLiteConnection
    Private produtosNoCarrinho As List(Of ProdutoNoCarrinho)
    Private valorTotal As Double

    Public Sub New()
        InitializeComponent()
        connection = New SQLiteConnection(connectionString)
        produtosNoCarrinho = New List(Of ProdutoNoCarrinho)()
        LoadItemsToDataGridView()
        TxtDinheiroCliente.Text = "0.00"
        CarregarDadosNoListView() ' Chama a função para carregar dados no ListView
    End Sub

    Private Sub LoadItemsToDataGridView()
        ' ... Código para carregar DataGridView ...
    End Sub

    Private Sub CarregarDadosNoListView()
        lvProdutos.Items.Clear()

        Using connection As New SQLiteConnection(connectionString)
            Dim sql As String = "SELECT codigo, nome, valor FROM produtos"
            Try
                connection.Open()
                Using command As New SQLiteCommand(sql, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim codigo As String = reader("codigo").ToString()
                            Dim nome As String = reader("nome").ToString()
                            Dim valor As Double = CDbl(reader("valor"))

                            Dim item As New ListViewItem(codigo)
                            item.SubItems.Add(nome)
                            item.SubItems.Add(valor.ToString("C2"))

                            lvProdutos.Items.Add(item)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CalcularTroco()
        ' ... Código para calcular troco ...
    End Sub

    ' Restante do código e eventos ...

End Class

Public Class ProdutoNoCarrinho
    Public Property Codigo As String
    Public Property Nome As String
    Public Property Valor As Double
End Class
