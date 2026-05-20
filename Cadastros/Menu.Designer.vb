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
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.VendasToolStripMenuItem, Me.ConsultasToolStripMenuItem})
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
        Me.CadastroClientesToolStripMenuItem1.Text = "Clientes"
        '
        'CadastroProdutosToolStripMenuItem1
        '
        Me.CadastroProdutosToolStripMenuItem1.Name = "CadastroProdutosToolStripMenuItem1"
        Me.CadastroProdutosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CadastroProdutosToolStripMenuItem1.Text = "Produtos"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.HistóricoDeVendasToolStripMenuItem})
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
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarClientesToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar Clientes"
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
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As ToolStripMenuItem
End Class
