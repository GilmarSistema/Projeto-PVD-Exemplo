<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        labelGitHubVersion = New Label()
        ButtonUpdate = New Button()
        labelCurrentVersion = New Label()
        ListBoxReleases = New ListBox()
        SuspendLayout()
        ' 
        ' labelGitHubVersion
        ' 
        labelGitHubVersion.AutoSize = True
        labelGitHubVersion.Location = New Point(29, 216)
        labelGitHubVersion.Name = "labelGitHubVersion"
        labelGitHubVersion.Size = New Size(99, 15)
        labelGitHubVersion.TabIndex = 0
        labelGitHubVersion.Text = "Versão do GitHub"
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Location = New Point(100, 293)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(55, 37)
        ButtonUpdate.TabIndex = 1
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' labelCurrentVersion
        ' 
        labelCurrentVersion.AutoSize = True
        labelCurrentVersion.Location = New Point(41, 258)
        labelCurrentVersion.Name = "labelCurrentVersion"
        labelCurrentVersion.Size = New Size(72, 15)
        labelCurrentVersion.TabIndex = 2
        labelCurrentVersion.Text = "Versão Atual"
        ' 
        ' ListBoxReleases
        ' 
        ListBoxReleases.FormattingEnabled = True
        ListBoxReleases.ItemHeight = 15
        ListBoxReleases.Location = New Point(255, 105)
        ListBoxReleases.Name = "ListBoxReleases"
        ListBoxReleases.Size = New Size(325, 109)
        ListBoxReleases.TabIndex = 3
        ' 
        ' UpdateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBoxReleases)
        Controls.Add(labelCurrentVersion)
        Controls.Add(ButtonUpdate)
        Controls.Add(labelGitHubVersion)
        Name = "UpdateForm"
        Text = "UpdateForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelGitHubVersion As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents labelCurrentVersion As Label
    Friend WithEvents ListBoxReleases As ListBox
End Class
