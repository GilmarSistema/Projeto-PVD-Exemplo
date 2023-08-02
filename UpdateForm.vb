Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class UpdateForm
    Private availableReleases As List(Of JObject)

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Não carregar releases no carregamento inicial
    End Sub

    Private Sub CheckForUpdates()
        Dim owner As String = "GilmarSistema"
        Dim repo As String = "Projeto-PVD-Exemplo"
        Dim releasesUrl As String = $"https://api.github.com/repos/{owner}/{repo}/releases"

        Using client As New HttpClient()
            Dim token As String = "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"
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Token", token)

            Dim response As HttpResponseMessage = client.GetAsync(releasesUrl).Result

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = response.Content.ReadAsStringAsync().Result
                availableReleases = JArray.Parse(responseContent).ToObject(Of List(Of JObject))()

                ListBoxReleases.Items.Clear() ' Limpar lista anterior de releases

                ' Exibir releases disponíveis para o usuário
                For Each release As JObject In availableReleases
                    Dim releaseName As String = release("name").ToString()
                    ListBoxReleases.Items.Add(releaseName)
                Next

                ListBoxReleases.Enabled = True ' Habilitar a lista de releases
            Else
                ' Lidar com resposta não bem-sucedida
            End If
        End Using
    End Sub

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        CheckForUpdates()
    End Sub

    Private Sub ListBoxReleases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxReleases.SelectedIndexChanged
        Dim selectedReleaseName As String = ListBoxReleases.SelectedItem.ToString()
        Dim selectedRelease As JObject = availableReleases.Find(Function(release) release("name").ToString() = selectedReleaseName)

        If selectedRelease IsNot Nothing Then
            Dim selectedTagName As String = selectedRelease("tag_name").ToString()
            StartUpdateProcess(selectedTagName)
        End If
    End Sub

    Private Sub StartUpdateProcess(tagName As String)
        Dim owner As String = "GilmarSistema"
        Dim repo As String = "Projeto-PVD-Exemplo"
        Dim releaseAssetsUrl As String = $"https://api.github.com/repos/{owner}/{repo}/releases/tags/{tagName}"

        Using client As New HttpClient()
            Dim token As String = "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"
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Token", token)

            Dim response As HttpResponseMessage = client.GetAsync(releaseAssetsUrl).Result

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = response.Content.ReadAsStringAsync().Result
                Dim release As JObject = JObject.Parse(responseContent)

                Dim assets As JArray = release("assets")
                For Each asset As JObject In assets
                    Dim assetName As String = asset("name").ToString()
                    Dim assetUrl As String = asset("browser_download_url").ToString()

                    Dim updateFilePath As String = Path.Combine(GetAppDirectory(), "Updates", assetName)

                    ' Usando HttpClient para baixar o arquivo
                    Using httpClient As New HttpClient()
                        Dim assetStream As Stream = httpClient.GetStreamAsync(assetUrl).Result
                        Using fileStream As New FileStream(updateFilePath, FileMode.Create)
                            assetStream.CopyTo(fileStream)
                        End Using
                    End Using

                    ' Aqui você deve implementar a lógica de aplicar a atualização
                    ' Isso pode incluir a substituição de arquivos, execução de scripts, etc.
                Next
            Else
                ' Lidar com resposta não bem-sucedida
            End If
        End Using
    End Sub

    Private Function GetAppDirectory() As String
        Return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    End Function
End Class
