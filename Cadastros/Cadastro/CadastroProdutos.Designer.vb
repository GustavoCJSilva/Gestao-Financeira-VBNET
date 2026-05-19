<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastroProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VoltarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.CadProd = New System.Windows.Forms.TabPage()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalvarProduto = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.txtCodigoSku = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnVerProdutos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLocalizacao = New System.Windows.Forms.TextBox()
        Me.chkProdutoAtivo = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEstoqueMinimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUnidadeMedida = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMargemLucro = New System.Windows.Forms.TextBox()
        Me.txtDescontoMaximo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecoCusto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFrete = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtVoltagem = New System.Windows.Forms.TextBox()
        Me.txtComponentes = New System.Windows.Forms.TextBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCor = New System.Windows.Forms.TextBox()
        Me.txtTamanho = New System.Windows.Forms.TextBox()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.CadProd.SuspendLayout()
        Me.pnlConteudo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VoltarToolStripMenuItem.Text = "Voltar ⬅️"
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.CadProd)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 24)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(536, 872)
        Me.Tabs.TabIndex = 2
        '
        'CadProd
        '
        Me.CadProd.Controls.Add(Me.pnlConteudo)
        Me.CadProd.Location = New System.Drawing.Point(4, 22)
        Me.CadProd.Name = "CadProd"
        Me.CadProd.Padding = New System.Windows.Forms.Padding(3)
        Me.CadProd.Size = New System.Drawing.Size(528, 846)
        Me.CadProd.TabIndex = 0
        Me.CadProd.Text = "Cadastrar Produto"
        Me.CadProd.UseVisualStyleBackColor = True
        '
        'pnlConteudo
        '
        Me.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConteudo.Controls.Add(Me.Panel1)
        Me.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConteudo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlConteudo.Location = New System.Drawing.Point(3, 3)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlConteudo.Size = New System.Drawing.Size(522, 840)
        Me.pnlConteudo.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSalvarProduto)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnVerProdutos)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel1.Location = New System.Drawing.Point(13, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel1.Size = New System.Drawing.Size(494, 795)
        Me.Panel1.TabIndex = 8
        '
        'btnSalvarProduto
        '
        Me.btnSalvarProduto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarProduto.ForeColor = System.Drawing.Color.White
        Me.btnSalvarProduto.Location = New System.Drawing.Point(22, 742)
        Me.btnSalvarProduto.Name = "btnSalvarProduto"
        Me.btnSalvarProduto.Size = New System.Drawing.Size(114, 34)
        Me.btnSalvarProduto.TabIndex = 8
        Me.btnSalvarProduto.Text = "Salvar Produto"
        Me.btnSalvarProduto.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69512!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30488!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtModelo, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarca, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCategoria, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigoBarras, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigoSku, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomeProduto, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 117)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(323, 93)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 23)
        Me.txtModelo.TabIndex = 15
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(162, 93)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 23)
        Me.txtMarca.TabIndex = 14
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(3, 93)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 23)
        Me.txtCategoria.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(162, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Modelo"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BackColor = System.Drawing.Color.White
        Me.txtCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(323, 45)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigoBarras.TabIndex = 9
        '
        'txtCodigoSku
        '
        Me.txtCodigoSku.BackColor = System.Drawing.Color.White
        Me.txtCodigoSku.Location = New System.Drawing.Point(162, 45)
        Me.txtCodigoSku.Name = "txtCodigoSku"
        Me.txtCodigoSku.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigoSku.TabIndex = 7
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.BackColor = System.Drawing.Color.White
        Me.txtNomeProduto.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtNomeProduto.Location = New System.Drawing.Point(3, 45)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(100, 23)
        Me.txtNomeProduto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome do Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código/SKU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Código de Barras"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(148, 17)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "📦 Informações Básicas"
        '
        'btnVerProdutos
        '
        Me.btnVerProdutos.BackColor = System.Drawing.Color.White
        Me.btnVerProdutos.Location = New System.Drawing.Point(351, 742)
        Me.btnVerProdutos.Name = "btnVerProdutos"
        Me.btnVerProdutos.Size = New System.Drawing.Size(118, 23)
        Me.btnVerProdutos.TabIndex = 7
        Me.btnVerProdutos.Text = "Ver Produtos → 📋"
        Me.btnVerProdutos.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtLocalizacao, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.chkProdutoAtivo, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtQuantidade, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEstoqueMinimo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUnidadeMedida, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(19, 136)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(450, 141)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.Location = New System.Drawing.Point(3, 106)
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.Size = New System.Drawing.Size(100, 23)
        Me.txtLocalizacao.TabIndex = 7
        '
        'chkProdutoAtivo
        '
        Me.chkProdutoAtivo.AutoSize = True
        Me.chkProdutoAtivo.Location = New System.Drawing.Point(166, 106)
        Me.chkProdutoAtivo.Name = "chkProdutoAtivo"
        Me.chkProdutoAtivo.Size = New System.Drawing.Size(100, 19)
        Me.chkProdutoAtivo.TabIndex = 9
        Me.chkProdutoAtivo.Text = "Produto Ativo"
        Me.chkProdutoAtivo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(166, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Localização"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(3, 49)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantidade.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Quantidade"
        '
        'txtEstoqueMinimo
        '
        Me.txtEstoqueMinimo.Location = New System.Drawing.Point(166, 49)
        Me.txtEstoqueMinimo.Name = "txtEstoqueMinimo"
        Me.txtEstoqueMinimo.Size = New System.Drawing.Size(100, 23)
        Me.txtEstoqueMinimo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Estoque Mínimo"
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(329, 49)
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(100, 23)
        Me.txtUnidadeMedida.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Unidade de Medida"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 17)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "🗃️ Estoque"
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(210, 742)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(84, 23)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar → 🧹"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtMargemLucro, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtDescontoMaximo, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtPrecoCusto, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtPrecoVenda, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtFrete, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label28, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(19, 283)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.84507!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.15493!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(450, 141)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'txtMargemLucro
        '
        Me.txtMargemLucro.Location = New System.Drawing.Point(166, 113)
        Me.txtMargemLucro.Name = "txtMargemLucro"
        Me.txtMargemLucro.Size = New System.Drawing.Size(100, 23)
        Me.txtMargemLucro.TabIndex = 9
        '
        'txtDescontoMaximo
        '
        Me.txtDescontoMaximo.Location = New System.Drawing.Point(3, 113)
        Me.txtDescontoMaximo.Name = "txtDescontoMaximo"
        Me.txtDescontoMaximo.Size = New System.Drawing.Size(100, 23)
        Me.txtDescontoMaximo.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Desconto Màximo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(166, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Margem de Lucro"
        '
        'txtPrecoCusto
        '
        Me.txtPrecoCusto.Location = New System.Drawing.Point(3, 54)
        Me.txtPrecoCusto.Name = "txtPrecoCusto"
        Me.txtPrecoCusto.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecoCusto.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Preço de Custo"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(166, 54)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecoVenda.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(166, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Preço de Venda"
        '
        'txtFrete
        '
        Me.txtFrete.Location = New System.Drawing.Point(329, 54)
        Me.txtFrete.Name = "txtFrete"
        Me.txtFrete.Size = New System.Drawing.Size(100, 23)
        Me.txtFrete.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(329, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Frete"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 17)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "💰 Valores"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtVoltagem, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.txtComponentes, 2, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.txtMaterial, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label23, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label24, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label25, 2, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCor, 2, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTamanho, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txtComprimento, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label20, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label21, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label22, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txtLargura, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtAltura, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtPeso, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label27, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(19, 430)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(450, 217)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'txtVoltagem
        '
        Me.txtVoltagem.Location = New System.Drawing.Point(166, 183)
        Me.txtVoltagem.Name = "txtVoltagem"
        Me.txtVoltagem.Size = New System.Drawing.Size(100, 23)
        Me.txtVoltagem.TabIndex = 16
        '
        'txtComponentes
        '
        Me.txtComponentes.Location = New System.Drawing.Point(329, 183)
        Me.txtComponentes.Name = "txtComponentes"
        Me.txtComponentes.Size = New System.Drawing.Size(100, 23)
        Me.txtComponentes.TabIndex = 17
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(3, 183)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(100, 23)
        Me.txtMaterial.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 15)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Material"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(166, 152)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Voltagem"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(329, 152)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 15)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Componentes"
        '
        'txtCor
        '
        Me.txtCor.Location = New System.Drawing.Point(329, 117)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(100, 23)
        Me.txtCor.TabIndex = 14
        '
        'txtTamanho
        '
        Me.txtTamanho.Location = New System.Drawing.Point(166, 117)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Size = New System.Drawing.Size(100, 23)
        Me.txtTamanho.TabIndex = 13
        '
        'txtComprimento
        '
        Me.txtComprimento.Location = New System.Drawing.Point(3, 117)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(100, 23)
        Me.txtComprimento.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Comprimento"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(166, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 15)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Tamanho"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(329, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 15)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Cor"
        '
        'txtLargura
        '
        Me.txtLargura.Location = New System.Drawing.Point(329, 58)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(100, 23)
        Me.txtLargura.TabIndex = 11
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(166, 58)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 23)
        Me.txtAltura.TabIndex = 10
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(3, 58)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 23)
        Me.txtPeso.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Peso"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(166, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Altura"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(329, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Largura"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 17)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "⚙️ Características"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label26, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtDescricao, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(19, 654)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(450, 82)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(3, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 17)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "📝 Descrição"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(3, 21)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(444, 58)
        Me.txtDescricao.TabIndex = 1
        '
        'CadastroProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 896)
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
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tabs As TabControl
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents CadProd As TabPage
    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoSku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPrecoCusto As TextBox
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents txtFrete As TextBox
    Friend WithEvents txtDescontoMaximo As TextBox
    Friend WithEvents txtMargemLucro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstoqueMinimo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUnidadeMedida As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLocalizacao As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnVerProdutos As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtComprimento As TextBox
    Friend WithEvents txtTamanho As TextBox
    Friend WithEvents txtCor As TextBox
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents txtVoltagem As TextBox
    Friend WithEvents txtComponentes As TextBox
    Friend WithEvents chkProdutoAtivo As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents btnSalvarProduto As Button
End Class
