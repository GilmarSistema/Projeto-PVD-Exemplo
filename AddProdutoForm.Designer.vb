<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProdutoForm
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
        txtName = New TextBox()
        txtCodigo = New TextBox()
        txtValor = New TextBox()
        Label1 = New Label()
        btnAdicionar = New Button()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ListView_Itens = New ListView()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(134, 172)
        txtName.Name = "txtName"
        txtName.Size = New Size(127, 23)
        txtName.TabIndex = 0
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(134, 112)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(127, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(116, 246)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(127, 23)
        txtValor.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(20, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 37)
        Label1.TabIndex = 3
        Label1.Text = "Codigo"
        ' 
        ' btnAdicionar
        ' 
        btnAdicionar.BackColor = Color.White
        btnAdicionar.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnAdicionar.ForeColor = SystemColors.MenuHighlight
        btnAdicionar.Location = New Point(20, 387)
        btnAdicionar.Name = "btnAdicionar"
        btnAdicionar.Size = New Size(208, 59)
        btnAdicionar.TabIndex = 7
        btnAdicionar.Text = "Adicionar"
        btnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.ImageAlign = ContentAlignment.BottomCenter
        Label4.Location = New Point(286, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(362, 37)
        Label4.TabIndex = 8
        Label4.Text = "Lista dos itens cadastrado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(12, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 37)
        Label2.TabIndex = 9
        Label2.Text = "Nome"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(12, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 37)
        Label3.TabIndex = 10
        Label3.Text = "PREÇO"
        ' 
        ' ListView_Itens
        ' 
        ListView_Itens.Location = New Point(373, 124)
        ListView_Itens.Name = "ListView_Itens"
        ListView_Itens.Size = New Size(390, 144)
        ListView_Itens.TabIndex = 11
        ListView_Itens.UseCompatibleStateImageBehavior = False
        ListView_Itens.View = View.Details
        ' 
        ' AddProdutoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LimeGreen
        ClientSize = New Size(846, 458)
        Controls.Add(ListView_Itens)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(btnAdicionar)
        Controls.Add(Label1)
        Controls.Add(txtValor)
        Controls.Add(txtCodigo)
        Controls.Add(txtName)
        Name = "AddProdutoForm"
        Text = "AddProdutoForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView_Itens As ListView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1ListView_Itens As ListView
End Class
