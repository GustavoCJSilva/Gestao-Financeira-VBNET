<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historico_de_Vendas
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.cmbFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelarVenda = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalVendas = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtVendasCanceladas = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 25)
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
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.42308!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.57692!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbClienteFiltro, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDataInicial, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDataFinal, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFormaPagamento, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatus, 4, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 162)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "🔍 Filtros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(574, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de Pagamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(763, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'cmbClienteFiltro
        '
        Me.cmbClienteFiltro.FormattingEnabled = True
        Me.cmbClienteFiltro.Location = New System.Drawing.Point(3, 109)
        Me.cmbClienteFiltro.Name = "cmbClienteFiltro"
        Me.cmbClienteFiltro.Size = New System.Drawing.Size(121, 29)
        Me.cmbClienteFiltro.TabIndex = 6
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(143, 109)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(200, 29)
        Me.dtpDataInicial.TabIndex = 7
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(358, 109)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(200, 29)
        Me.dtpDataFinal.TabIndex = 8
        '
        'cmbFormaPagamento
        '
        Me.cmbFormaPagamento.FormattingEnabled = True
        Me.cmbFormaPagamento.Location = New System.Drawing.Point(574, 109)
        Me.cmbFormaPagamento.Name = "cmbFormaPagamento"
        Me.cmbFormaPagamento.Size = New System.Drawing.Size(121, 29)
        Me.cmbFormaPagamento.TabIndex = 9
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(763, 109)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 29)
        Me.cmbStatus.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(15, 182)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(202, 44)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCancelarVenda
        '
        Me.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenda.Location = New System.Drawing.Point(253, 182)
        Me.btnCancelarVenda.Name = "btnCancelarVenda"
        Me.btnCancelarVenda.Size = New System.Drawing.Size(202, 44)
        Me.btnCancelarVenda.TabIndex = 3
        Me.btnCancelarVenda.Text = "Cancelar Venda"
        Me.btnCancelarVenda.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Location = New System.Drawing.Point(483, 182)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(202, 44)
        Me.btnAtualizar.TabIndex = 4
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(719, 182)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(202, 44)
        Me.btnVoltar.TabIndex = 5
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvVendas, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 241)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.17808!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.82191!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(906, 146)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "🧾 Vendas Encontradas"
        '
        'dgvVendas
        '
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.Location = New System.Drawing.Point(3, 31)
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.Size = New System.Drawing.Size(900, 112)
        Me.dgvVendas.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.95597!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.04403!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTotalVendas, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtValorTotal, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtVendasCanceladas, 2, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(15, 393)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(906, 185)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "💰 Resumo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total de Vendas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Volar Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(636, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 21)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Vendas Canceladas"
        '
        'txtTotalVendas
        '
        Me.txtTotalVendas.Location = New System.Drawing.Point(3, 134)
        Me.txtTotalVendas.Name = "txtTotalVendas"
        Me.txtTotalVendas.Size = New System.Drawing.Size(100, 29)
        Me.txtTotalVendas.TabIndex = 4
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(307, 134)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtValorTotal.TabIndex = 5
        '
        'txtVendasCanceladas
        '
        Me.txtVendasCanceladas.Location = New System.Drawing.Point(636, 134)
        Me.txtVendasCanceladas.Name = "txtVendasCanceladas"
        Me.txtVendasCanceladas.Size = New System.Drawing.Size(100, 29)
        Me.txtVendasCanceladas.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.btnCancelarVenda)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.btnVoltar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(61, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 598)
        Me.Panel1.TabIndex = 12
        '
        'Historico_de_Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Historico_de_Vendas"
        Me.Text = "Historico de Vendas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbClienteFiltro As ComboBox
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents cmbFormaPagamento As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelarVenda As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalVendas As TextBox
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents txtVendasCanceladas As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvVendas As DataGridView
End Class
