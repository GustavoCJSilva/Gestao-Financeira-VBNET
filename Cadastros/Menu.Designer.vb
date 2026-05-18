<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrataDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaídaDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosComEstoqueBaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMaisVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueBaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadosDaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemaDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermissõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreOSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.VendasToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroClientesToolStripMenuItem1, Me.CadastroProdutosToolStripMenuItem1})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'CadastroClientesToolStripMenuItem1
        '
        Me.CadastroClientesToolStripMenuItem1.Name = "CadastroClientesToolStripMenuItem1"
        Me.CadastroClientesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CadastroClientesToolStripMenuItem1.Text = "Cadastro Clientes"
        '
        'CadastroProdutosToolStripMenuItem1
        '
        Me.CadastroProdutosToolStripMenuItem1.Name = "CadastroProdutosToolStripMenuItem1"
        Me.CadastroProdutosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CadastroProdutosToolStripMenuItem1.Text = "Cadastro Produtos"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.HistóricoDeVendasToolStripMenuItem, Me.CancelarVendaToolStripMenuItem})
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NovaVendaToolStripMenuItem.Text = "Nova Venda"
        '
        'HistóricoDeVendasToolStripMenuItem
        '
        Me.HistóricoDeVendasToolStripMenuItem.Name = "HistóricoDeVendasToolStripMenuItem"
        Me.HistóricoDeVendasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.HistóricoDeVendasToolStripMenuItem.Text = "Histórico de Vendas"
        '
        'CancelarVendaToolStripMenuItem
        '
        Me.CancelarVendaToolStripMenuItem.Name = "CancelarVendaToolStripMenuItem"
        Me.CancelarVendaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CancelarVendaToolStripMenuItem.Text = "Cancelar Venda"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrataDeEstoqueToolStripMenuItem, Me.SaídaDeEstoqueToolStripMenuItem, Me.ProdutosComEstoqueBaixoToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'EntrataDeEstoqueToolStripMenuItem
        '
        Me.EntrataDeEstoqueToolStripMenuItem.Name = "EntrataDeEstoqueToolStripMenuItem"
        Me.EntrataDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.EntrataDeEstoqueToolStripMenuItem.Text = "Entrata de Estoque"
        '
        'SaídaDeEstoqueToolStripMenuItem
        '
        Me.SaídaDeEstoqueToolStripMenuItem.Name = "SaídaDeEstoqueToolStripMenuItem"
        Me.SaídaDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SaídaDeEstoqueToolStripMenuItem.Text = "Saída de Estoque"
        '
        'ProdutosComEstoqueBaixoToolStripMenuItem
        '
        Me.ProdutosComEstoqueBaixoToolStripMenuItem.Name = "ProdutosComEstoqueBaixoToolStripMenuItem"
        Me.ProdutosComEstoqueBaixoToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ProdutosComEstoqueBaixoToolStripMenuItem.Text = "Produtos com Estoque Baixo"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarClientesToolStripMenuItem, Me.ConsultarProdutosToolStripMenuItem, Me.ConsultarVendasToolStripMenuItem, Me.ConsultarEstoqueToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar Clientes"
        '
        'ConsultarProdutosToolStripMenuItem
        '
        Me.ConsultarProdutosToolStripMenuItem.Name = "ConsultarProdutosToolStripMenuItem"
        Me.ConsultarProdutosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultarProdutosToolStripMenuItem.Text = "Consultar Produtos"
        '
        'ConsultarVendasToolStripMenuItem
        '
        Me.ConsultarVendasToolStripMenuItem.Name = "ConsultarVendasToolStripMenuItem"
        Me.ConsultarVendasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultarVendasToolStripMenuItem.Text = "Consultar Vendas"
        '
        'ConsultarEstoqueToolStripMenuItem
        '
        Me.ConsultarEstoqueToolStripMenuItem.Name = "ConsultarEstoqueToolStripMenuItem"
        Me.ConsultarEstoqueToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultarEstoqueToolStripMenuItem.Text = "Consultar Estoque"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioDeClientesToolStripMenuItem, Me.RelatórioDeProdutosToolStripMenuItem, Me.RelatórioDeVendasToolStripMenuItem, Me.ProdutosMaisVendidosToolStripMenuItem, Me.EstoqueBaixoToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'RelatórioDeClientesToolStripMenuItem
        '
        Me.RelatórioDeClientesToolStripMenuItem.Name = "RelatórioDeClientesToolStripMenuItem"
        Me.RelatórioDeClientesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RelatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes"
        '
        'RelatórioDeProdutosToolStripMenuItem
        '
        Me.RelatórioDeProdutosToolStripMenuItem.Name = "RelatórioDeProdutosToolStripMenuItem"
        Me.RelatórioDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RelatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos"
        '
        'RelatórioDeVendasToolStripMenuItem
        '
        Me.RelatórioDeVendasToolStripMenuItem.Name = "RelatórioDeVendasToolStripMenuItem"
        Me.RelatórioDeVendasToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RelatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos Mais vendidos"
        '
        'EstoqueBaixoToolStripMenuItem
        '
        Me.EstoqueBaixoToolStripMenuItem.Name = "EstoqueBaixoToolStripMenuItem"
        Me.EstoqueBaixoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EstoqueBaixoToolStripMenuItem.Text = "Estoque Baixo"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosDaEmpresaToolStripMenuItem, Me.TemaDoSistemaToolStripMenuItem, Me.BackupToolStripMenuItem, Me.PermissõesToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'DadosDaEmpresaToolStripMenuItem
        '
        Me.DadosDaEmpresaToolStripMenuItem.Name = "DadosDaEmpresaToolStripMenuItem"
        Me.DadosDaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DadosDaEmpresaToolStripMenuItem.Text = "Dados da Empresa"
        '
        'TemaDoSistemaToolStripMenuItem
        '
        Me.TemaDoSistemaToolStripMenuItem.Name = "TemaDoSistemaToolStripMenuItem"
        Me.TemaDoSistemaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TemaDoSistemaToolStripMenuItem.Text = "Tema do Sistema"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'PermissõesToolStripMenuItem
        '
        Me.PermissõesToolStripMenuItem.Name = "PermissõesToolStripMenuItem"
        Me.PermissõesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PermissõesToolStripMenuItem.Text = "Permissões"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreOSistemaToolStripMenuItem, Me.ManualDeUsoToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SobreOSistemaToolStripMenuItem
        '
        Me.SobreOSistemaToolStripMenuItem.Name = "SobreOSistemaToolStripMenuItem"
        Me.SobreOSistemaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema"
        '
        'ManualDeUsoToolStripMenuItem
        '
        Me.ManualDeUsoToolStripMenuItem.Name = "ManualDeUsoToolStripMenuItem"
        Me.ManualDeUsoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ManualDeUsoToolStripMenuItem.Text = "Manual de Uso"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 594)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 618)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CadastroProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrataDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaídaDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosComEstoqueBaixoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosMaisVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstoqueBaixoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadosDaEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemaDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermissõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreOSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsoToolStripMenuItem As ToolStripMenuItem
End Class
