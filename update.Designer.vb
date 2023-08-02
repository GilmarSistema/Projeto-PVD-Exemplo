<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(update))
        Label1 = New Label()
        BtnAtualizar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(88, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(522, 50)
        Label1.TabIndex = 0
        Label1.Text = "PAGINA DE  ATUALIZAÇÃO"
        ' 
        ' BtnAtualizar
        ' 
        BtnAtualizar.BackColor = Color.Transparent
        BtnAtualizar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAtualizar.Location = New Point(295, 349)
        BtnAtualizar.Name = "BtnAtualizar"
        BtnAtualizar.Size = New Size(284, 69)
        BtnAtualizar.TabIndex = 1
        BtnAtualizar.Text = "Verificar e fazer Atualização"
        BtnAtualizar.UseVisualStyleBackColor = False
        ' 
        ' update
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OrangeRed
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAtualizar)
        Controls.Add(Label1)
        Name = "update"
        Text = "update"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAtualizar As Button
End Class
