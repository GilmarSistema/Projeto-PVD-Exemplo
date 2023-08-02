Imports System.Data.SQLite
Imports System.IO

Public Class AddProdutoForm
    Private dbFolderPath As String = Path.Combine(Application.StartupPath, "Database")
    Private dbFileName As String = Path.Combine(dbFolderPath, "caixa_db.db")
    Private connectionString As String = $"Data Source={dbFileName}"
    Private connection As SQLiteConnection

    Public Sub New()
        InitializeComponent()
        connection = New SQLiteConnection(connectionString)
        CreateProductsTable()
        InitializeListViewColumns()
        LoadItemsToListView()
    End Sub

    Private Sub CreateProductsTable()
        If Not File.Exists(dbFileName) Then
            Directory.CreateDirectory(dbFolderPath)
            SQLiteConnection.CreateFile(dbFileName)
        End If

        Dim sql As String = "CREATE TABLE IF NOT EXISTS produtos (codigo TEXT, nome TEXT, valor REAL)"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sql, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Erro ao criar a tabela: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub InitializeListViewColumns()
        ListView_Itens.View = View.Details
        ListView_Itens.Columns.Add("Código", 100, HorizontalAlignment.Left)
        ListView_Itens.Columns.Add("Nome", 150, HorizontalAlignment.Left)
        ListView_Itens.Columns.Add("Valor", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub LoadItemsToListView()
        ListView_Itens.Items.Clear()

        Using connection As New SQLiteConnection(connectionString)
            Dim sql As String = "SELECT * FROM produtos ORDER BY codigo"
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

                            ListView_Itens.Items.Add(item)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao carregar os itens: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If txtCodigo.Text = "" OrElse txtName.Text = "" OrElse Not Double.TryParse(txtValor.Text, Nothing) Then
            MessageBox.Show("Por favor, preencha todos os campos corretamente.")
            Return
        End If

        Dim codigo As String = txtCodigo.Text
        Dim nome As String = txtName.Text
        Dim valor As Double = CDbl(txtValor.Text)

        Using connection As New SQLiteConnection(connectionString)
            Dim sql As String = "INSERT INTO produtos (codigo, nome, valor) VALUES (@codigo, @nome, @valor)"
            Try
                connection.Open()
                Using command As New SQLiteCommand(sql, connection)
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.Parameters.AddWithValue("@nome", nome)
                    command.Parameters.AddWithValue("@valor", valor)

                    command.ExecuteNonQuery()

                    txtCodigo.Text = ""
                    txtName.Text = ""
                    txtValor.Text = ""

                    LoadItemsToListView() ' Atualiza a ListView após adicionar um item
                    MessageBox.Show("Item adicionado com sucesso.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao adicionar o item: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
