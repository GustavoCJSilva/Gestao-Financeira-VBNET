<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroProdutos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VoltarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.CadProd = New System.Windows.Forms.TabPage()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.modelo = New System.Windows.Forms.TextBox()
        Me.quantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.material = New System.Windows.Forms.TextBox()
        Me.cor = New System.Windows.Forms.TextBox()
        Me.voltagem = New System.Windows.Forms.TextBox()
        Me.componentes = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.preço = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.frete = New System.Windows.Forms.TextBox()
        Me.comprimento = New System.Windows.Forms.TextBox()
        Me.medida = New System.Windows.Forms.TextBox()
        Me.altura = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.largura = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tamanho = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.descricao = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.CadProd.SuspendLayout()
        Me.pnlConteudo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2238, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VoltarToolStripMenuItem.Text = "Voltar"
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.CadProd)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 24)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(2238, 876)
        Me.Tabs.TabIndex = 2
        '
        'CadProd
        '
        Me.CadProd.Controls.Add(Me.pnlConteudo)
        Me.CadProd.Location = New System.Drawing.Point(4, 22)
        Me.CadProd.Name = "CadProd"
        Me.CadProd.Padding = New System.Windows.Forms.Padding(3)
        Me.CadProd.Size = New System.Drawing.Size(2230, 850)
        Me.CadProd.TabIndex = 0
        Me.CadProd.Text = "Cadastrar Produto"
        Me.CadProd.UseVisualStyleBackColor = True
        '
        'pnlConteudo
        '
        Me.pnlConteudo.BackColor = System.Drawing.Color.White
        Me.pnlConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConteudo.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlConteudo.Controls.Add(Me.TableLayoutPanel5)
        Me.pnlConteudo.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlConteudo.Controls.Add(Me.TableLayoutPanel4)
        Me.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConteudo.Location = New System.Drawing.Point(3, 3)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlConteudo.Size = New System.Drawing.Size(2224, 844)
        Me.pnlConteudo.TabIndex = 47
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.35762!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.64238!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nome, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.marca, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.modelo, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.quantidade, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.material, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cor, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.voltagem, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.componentes, 3, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(554, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 169)
        Me.TableLayoutPanel2.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Dados do Produto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Modelo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(656, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Quantidade"
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(3, 53)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(98, 20)
        Me.nome.TabIndex = 19
        '
        'marca
        '
        Me.marca.Location = New System.Drawing.Point(213, 53)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(98, 20)
        Me.marca.TabIndex = 18
        '
        'modelo
        '
        Me.modelo.Location = New System.Drawing.Point(456, 53)
        Me.modelo.Name = "modelo"
        Me.modelo.Size = New System.Drawing.Size(98, 20)
        Me.modelo.TabIndex = 20
        '
        'quantidade
        '
        Me.quantidade.Location = New System.Drawing.Point(656, 53)
        Me.quantidade.Name = "quantidade"
        Me.quantidade.Size = New System.Drawing.Size(98, 20)
        Me.quantidade.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(213, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Cor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Voltagem"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(656, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Componentes"
        '
        'material
        '
        Me.material.Location = New System.Drawing.Point(3, 111)
        Me.material.Name = "material"
        Me.material.Size = New System.Drawing.Size(98, 20)
        Me.material.TabIndex = 23
        '
        'cor
        '
        Me.cor.Location = New System.Drawing.Point(213, 111)
        Me.cor.Name = "cor"
        Me.cor.Size = New System.Drawing.Size(98, 20)
        Me.cor.TabIndex = 24
        '
        'voltagem
        '
        Me.voltagem.Location = New System.Drawing.Point(456, 111)
        Me.voltagem.Name = "voltagem"
        Me.voltagem.Size = New System.Drawing.Size(98, 20)
        Me.voltagem.TabIndex = 25
        '
        'componentes
        '
        Me.componentes.Location = New System.Drawing.Point(656, 111)
        Me.componentes.Name = "componentes"
        Me.componentes.Size = New System.Drawing.Size(98, 20)
        Me.componentes.TabIndex = 26
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.95577!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.04424!))
        Me.TableLayoutPanel5.Controls.Add(Me.lista, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(554, 576)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(760, 148)
        Me.TableLayoutPanel5.TabIndex = 46
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(124, 47)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(633, 95)
        Me.lista.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Cadastrar Produto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Ver Produtos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47577!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.52423!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.preço, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.frete, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.comprimento, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.medida, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.altura, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.largura, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.tamanho, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(554, 198)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.80488!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.19512!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(760, 194)
        Me.TableLayoutPanel3.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Medidas e Valores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Medida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(214, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Altura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(457, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Largura"
        '
        'preço
        '
        Me.preço.Location = New System.Drawing.Point(457, 117)
        Me.preço.Name = "preço"
        Me.preço.Size = New System.Drawing.Size(71, 20)
        Me.preço.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(656, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Tamanho"
        '
        'frete
        '
        Me.frete.Location = New System.Drawing.Point(214, 117)
        Me.frete.Name = "frete"
        Me.frete.Size = New System.Drawing.Size(60, 20)
        Me.frete.TabIndex = 31
        '
        'comprimento
        '
        Me.comprimento.Location = New System.Drawing.Point(3, 117)
        Me.comprimento.Name = "comprimento"
        Me.comprimento.Size = New System.Drawing.Size(98, 20)
        Me.comprimento.TabIndex = 32
        '
        'medida
        '
        Me.medida.Location = New System.Drawing.Point(3, 59)
        Me.medida.Name = "medida"
        Me.medida.Size = New System.Drawing.Size(98, 20)
        Me.medida.TabIndex = 27
        '
        'altura
        '
        Me.altura.Location = New System.Drawing.Point(214, 59)
        Me.altura.Name = "altura"
        Me.altura.Size = New System.Drawing.Size(98, 20)
        Me.altura.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(457, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Preço"
        '
        'largura
        '
        Me.largura.Location = New System.Drawing.Point(457, 59)
        Me.largura.Name = "largura"
        Me.largura.Size = New System.Drawing.Size(100, 20)
        Me.largura.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(214, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Frete"
        '
        'tamanho
        '
        Me.tamanho.Location = New System.Drawing.Point(656, 59)
        Me.tamanho.Name = "tamanho"
        Me.tamanho.Size = New System.Drawing.Size(94, 20)
        Me.tamanho.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Comprimento"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.descricao, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(554, 398)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46512!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53488!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(760, 172)
        Me.TableLayoutPanel4.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Descrição"
        '
        'descricao
        '
        Me.descricao.Location = New System.Drawing.Point(3, 21)
        Me.descricao.Multiline = True
        Me.descricao.Name = "descricao"
        Me.descricao.Size = New System.Drawing.Size(640, 148)
        Me.descricao.TabIndex = 34
        '
        'CadastroProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2238, 900)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CadastroProdutos"
        Me.Text = "CadastroProdutos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Tabs.ResumeLayout(False)
        Me.CadProd.ResumeLayout(False)
        Me.pnlConteudo.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tabs As TabControl
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents CadProd As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents descricao As TextBox
    Friend WithEvents comprimento As TextBox
    Friend WithEvents frete As TextBox
    Friend WithEvents tamanho As TextBox
    Friend WithEvents largura As TextBox
    Friend WithEvents altura As TextBox
    Friend WithEvents medida As TextBox
    Friend WithEvents componentes As TextBox
    Friend WithEvents voltagem As TextBox
    Friend WithEvents cor As TextBox
    Friend WithEvents material As TextBox
    Friend WithEvents quantidade As TextBox
    Friend WithEvents modelo As TextBox
    Friend WithEvents nome As TextBox
    Friend WithEvents marca As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents preço As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lista As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents pnlConteudo As Panel
End Class
