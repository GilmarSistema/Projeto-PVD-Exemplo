Imports Octokit
Imports System.IO
Imports System.Net.Http
Imports System.Windows.Forms

Public Class UpdateForm
    Inherits Form

    Private WithEvents client As New HttpClient()

    Private Async Sub BtnVerificarAtualizacao_Click(sender As Object, e As EventArgs) Handles BtnVerificarAtualizacao.Click
        Await VerificarAtualizacao()
    End Sub

    Private Async Function VerificarAtualizacao() As Task
        Dim owner As String = "GilmarSistema" ' Substitua pelo nome do proprietário do seu repositório
        Dim repository As String = "Projeto-PVD-Exemplo" ' Substitua pelo nome do repositório
        Dim personalAccessToken As String = "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" ' Substitua pelo seu token de acesso pessoal

        Dim gitHubClient = New GitHubClient(New ProductHeaderValue("Projeto-PVD-Exemplo"))
        Dim tokenAuth = New Credentials(personalAccessToken)
        gitHubClient.Credentials = tokenAuth

        Try
            Dim releases = Await gitHubClient.Repository.Release.GetAll(owner, repository)

            Dim latestRelease = releases.FirstOrDefault()

            If latestRelease IsNot Nothing Then
                Dim currentVersion As Version = New Version(System.Windows.Forms.Application.ProductVersion)
                Dim latestVersion As Version = New Version(latestRelease.TagName)

                If latestVersion > currentVersion Then
                    Dim downloadUrl As String = latestRelease.Assets.FirstOrDefault()?.BrowserDownloadUrl
                    Dim downloadPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Projeto_temp.exe")

                    Try
                        ' Iniciar o download do arquivo
                        Await DownloadFileAsync(downloadUrl, downloadPath)

                        ' Fechar a janela atual e iniciar o novo aplicativo
                        Me.Hide()
                        Process.Start(downloadPath)
                        System.Windows.Forms.Application.Exit()
                    Catch ex As Exception
                        MessageBox.Show("Erro ao fazer o download da atualização: " & ex.Message, "Erro de Download", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Você já possui a versão mais recente.", "Nenhuma Atualização Disponível", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Não foi possível verificar atualizações no momento.", "Erro de Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar atualizações: " & ex.Message, "Erro de Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function DownloadFileAsync(url As String, filePath As String) As Task
        Dim response = Await client.GetAsync(url)
        response.EnsureSuccessStatusCode()

        Using contentStream = Await response.Content.ReadAsStreamAsync()
            Using fileStream = File.Create(filePath)
                Await contentStream.CopyToAsync(fileStream)
            End Using
        End Using
    End Function
End Class
