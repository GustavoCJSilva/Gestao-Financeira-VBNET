<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nova_Venda
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCpfCnpj = New System.Windows.Forms.TextBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.dtpDataVenda = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdicionarProduto = New System.Windows.Forms.Button()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecoUnitario = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvItensVenda = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDescontoTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalFinal = New System.Windows.Forms.TextBox()
        Me.cmbFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnFinalizarVenda = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvItensVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1202, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(49, 19)
        Me.VoltarToolStripMenuItem.Text = "Voltar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 389.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCpfCnpj, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCliente, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDataVenda, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 20)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.92754!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.07246!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1093, 173)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "👤 Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF/CNPJ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(708, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data da Venda"
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.Location = New System.Drawing.Point(356, 118)
        Me.txtCpfCnpj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Size = New System.Drawing.Size(148, 29)
        Me.txtCpfCnpj.TabIndex = 5
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(3, 116)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(121, 29)
        Me.cmbCliente.TabIndex = 7
        '
        'dtpDataVenda
        '
        Me.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataVenda.Location = New System.Drawing.Point(707, 116)
        Me.dtpDataVenda.Name = "dtpDataVenda"
        Me.dtpDataVenda.Size = New System.Drawing.Size(200, 29)
        Me.dtpDataVenda.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21276!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78724!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAdicionarProduto, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbProduto, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCodigoProduto, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.nudQuantidade, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPrecoUnitario, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDesconto, 1, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 201)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.51852!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.48148!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1093, 257)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "📦 Produto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Produto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Código"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(704, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 21)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Quantidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Preço Unitário"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(355, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 21)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Desconto"
        '
        'btnAdicionarProduto
        '
        Me.btnAdicionarProduto.Location = New System.Drawing.Point(704, 213)
        Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
        Me.btnAdicionarProduto.Size = New System.Drawing.Size(169, 37)
        Me.btnAdicionarProduto.TabIndex = 11
        Me.btnAdicionarProduto.Text = "Adicionar Produto"
        Me.btnAdicionarProduto.UseVisualStyleBackColor = True
        '
        'cmbProduto
        '
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(3, 94)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(121, 29)
        Me.cmbProduto.TabIndex = 12
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Location = New System.Drawing.Point(355, 94)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(100, 29)
        Me.txtCodigoProduto.TabIndex = 13
        '
        'nudQuantidade
        '
        Me.nudQuantidade.Location = New System.Drawing.Point(704, 94)
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(120, 29)
        Me.nudQuantidade.TabIndex = 14
        '
        'txtPrecoUnitario
        '
        Me.txtPrecoUnitario.Location = New System.Drawing.Point(3, 213)
        Me.txtPrecoUnitario.Name = "txtPrecoUnitario"
        Me.txtPrecoUnitario.Size = New System.Drawing.Size(100, 29)
        Me.txtPrecoUnitario.TabIndex = 15
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(355, 213)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(100, 29)
        Me.txtDesconto.TabIndex = 16
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgvItensVenda, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(23, 464)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1093, 131)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "🧾 Itens da Venda"
        '
        'dgvItensVenda
        '
        Me.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItensVenda.Location = New System.Drawing.Point(3, 39)
        Me.dgvItensVenda.Name = "dgvItensVenda"
        Me.dgvItensVenda.Size = New System.Drawing.Size(1087, 89)
        Me.dgvItensVenda.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.72623!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.27377!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label14, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtSubtotal, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtDescontoTotal, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTotalFinal, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbFormaPagamento, 3, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(20, 601)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1093, 137)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "💰 Pagamento e Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 21)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Subtotal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 21)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Desconto Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(601, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Total Final"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(846, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 21)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Forma de Pagamento"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(3, 97)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 29)
        Me.txtSubtotal.TabIndex = 5
        '
        'txtDescontoTotal
        '
        Me.txtDescontoTotal.Location = New System.Drawing.Point(264, 97)
        Me.txtDescontoTotal.Name = "txtDescontoTotal"
        Me.txtDescontoTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtDescontoTotal.TabIndex = 6
        '
        'txtTotalFinal
        '
        Me.txtTotalFinal.Location = New System.Drawing.Point(601, 97)
        Me.txtTotalFinal.Name = "txtTotalFinal"
        Me.txtTotalFinal.Size = New System.Drawing.Size(100, 29)
        Me.txtTotalFinal.TabIndex = 7
        '
        'cmbFormaPagamento
        '
        Me.cmbFormaPagamento.FormattingEnabled = True
        Me.cmbFormaPagamento.Location = New System.Drawing.Point(846, 97)
        Me.cmbFormaPagamento.Name = "cmbFormaPagamento"
        Me.cmbFormaPagamento.Size = New System.Drawing.Size(106, 29)
        Me.cmbFormaPagamento.TabIndex = 8
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(20, 756)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(266, 35)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Location = New System.Drawing.Point(438, 756)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(266, 35)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnFinalizarVenda
        '
        Me.btnFinalizarVenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarVenda.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarVenda.Location = New System.Drawing.Point(847, 756)
        Me.btnFinalizarVenda.Name = "btnFinalizarVenda"
        Me.btnFinalizarVenda.Size = New System.Drawing.Size(266, 35)
        Me.btnFinalizarVenda.TabIndex = 7
        Me.btnFinalizarVenda.Text = "Finalizar Venda"
        Me.btnFinalizarVenda.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnFinalizarVenda)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Location = New System.Drawing.Point(23, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 810)
        Me.Panel1.TabIndex = 8
        '
        'Nova_Venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1202, 880)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Nova_Venda"
        Me.Text = "Nova_Venda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dgvItensVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCpfCnpj As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAdicionarProduto As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnFinalizarVenda As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents dtpDataVenda As DateTimePicker
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents txtCodigoProduto As TextBox
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents txtPrecoUnitario As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDescontoTotal As TextBox
    Friend WithEvents txtTotalFinal As TextBox
    Friend WithEvents cmbFormaPagamento As ComboBox
    Friend WithEvents dgvItensVenda As DataGridView
End Class
