<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaForm
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
        Label1 = New Label()
        Label2 = New Label()
        Button_finalizar = New Button()
        TxtCodigo = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TxtDinheiroCliente = New TextBox()
        Label5 = New Label()
        TxtTroco = New TextBox()
        Label6 = New Label()
        TxtSubTotal = New TextBox()
        DataGridView1 = New DataGridView()
        TxtTotal = New TextBox()
        lvProdutos = New ListView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(454, 40)
        Label1.TabIndex = 1
        Label1.Text = "LISTA DE PRODUTOS EXISTENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(472, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(424, 47)
        Label2.TabIndex = 2
        Label2.Text = "CARRINHO DE COMPRA"
        ' 
        ' Button_finalizar
        ' 
        Button_finalizar.Location = New Point(727, 419)
        Button_finalizar.Name = "Button_finalizar"
        Button_finalizar.Size = New Size(136, 37)
        Button_finalizar.TabIndex = 4
        Button_finalizar.Text = "Finalizar Compra"
        Button_finalizar.UseVisualStyleBackColor = True
        ' 
        ' TxtCodigo
        ' 
        TxtCodigo.Location = New Point(30, 315)
        TxtCodigo.Name = "TxtCodigo"
        TxtCodigo.Size = New Size(165, 23)
        TxtCodigo.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(30, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 40)
        Label3.TabIndex = 6
        Label3.Text = "Codigo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(20, 360)
        Label4.Name = "Label4"
        Label4.Size = New Size(238, 40)
        Label4.TabIndex = 7
        Label4.Text = "Dinheiro Cliente"
        ' 
        ' TxtDinheiroCliente
        ' 
        TxtDinheiroCliente.Location = New Point(66, 398)
        TxtDinheiroCliente.Name = "TxtDinheiroCliente"
        TxtDinheiroCliente.Size = New Size(129, 23)
        TxtDinheiroCliente.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(336, 355)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 40)
        Label5.TabIndex = 9
        Label5.Text = "Troco"
        ' 
        ' TxtTroco
        ' 
        TxtTroco.Location = New Point(311, 398)
        TxtTroco.Name = "TxtTroco"
        TxtTroco.Size = New Size(129, 23)
        TxtTroco.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(541, 315)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 40)
        Label6.TabIndex = 11
        Label6.Text = "Subtotal"
        ' 
        ' TxtSubTotal
        ' 
        TxtSubTotal.Location = New Point(541, 355)
        TxtSubTotal.Name = "TxtSubTotal"
        TxtSubTotal.Size = New Size(129, 23)
        TxtSubTotal.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(482, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(402, 233)
        DataGridView1.TabIndex = 13
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(324, 332)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(129, 23)
        TxtTotal.TabIndex = 14
        ' 
        ' lvProdutos
        ' 
        lvProdutos.Location = New Point(49, 80)
        lvProdutos.Name = "lvProdutos"
        lvProdutos.Size = New Size(320, 167)
        lvProdutos.TabIndex = 15
        lvProdutos.UseCompatibleStateImageBehavior = False
        ' 
        ' CaixaForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(905, 468)
        Controls.Add(lvProdutos)
        Controls.Add(TxtTotal)
        Controls.Add(DataGridView1)
        Controls.Add(TxtSubTotal)
        Controls.Add(Label6)
        Controls.Add(TxtTroco)
        Controls.Add(Label5)
        Controls.Add(TxtDinheiroCliente)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TxtCodigo)
        Controls.Add(Button_finalizar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CaixaForm"
        Text = "CaixaForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_finalizar As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDinheiroCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtTroco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents lvProdutos As ListView
End Class
