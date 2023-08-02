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
        BtnVerificarAtualizacao = New Button()
        SuspendLayout()
        ' 
        ' BtnVerificarAtualizacao
        ' 
        BtnVerificarAtualizacao.Location = New Point(195, 347)
        BtnVerificarAtualizacao.Name = "BtnVerificarAtualizacao"
        BtnVerificarAtualizacao.Size = New Size(89, 34)
        BtnVerificarAtualizacao.TabIndex = 0
        BtnVerificarAtualizacao.Text = "Update"
        BtnVerificarAtualizacao.UseVisualStyleBackColor = True
        ' 
        ' UpdateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnVerificarAtualizacao)
        Name = "UpdateForm"
        Text = "UpdateForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnVerificarAtualizacao As Button
End Class
