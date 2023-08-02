<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipalForm
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
        btn_caixa = New Button()
        Addproduto = New Button()
        SuspendLayout()
        ' 
        ' btn_caixa
        ' 
        btn_caixa.Location = New Point(50, 210)
        btn_caixa.Name = "btn_caixa"
        btn_caixa.Size = New Size(62, 24)
        btn_caixa.TabIndex = 1
        btn_caixa.Text = "Caixa"
        btn_caixa.UseVisualStyleBackColor = True
        ' 
        ' Addproduto
        ' 
        Addproduto.Location = New Point(50, 240)
        Addproduto.Name = "Addproduto"
        Addproduto.Size = New Size(62, 24)
        Addproduto.TabIndex = 2
        Addproduto.Text = "Add"
        Addproduto.UseVisualStyleBackColor = True
        ' 
        ' PaginaPrincipalForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Addproduto)
        Controls.Add(btn_caixa)
        Name = "PaginaPrincipalForm"
        Text = "PaginaPrincipalForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_caixa As Button
    Friend WithEvents Addproduto As Button
End Class
