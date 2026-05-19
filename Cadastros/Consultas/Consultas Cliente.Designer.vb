<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas_Cliente
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomeFiltro = New System.Windows.Forms.TextBox()
        Me.txtCpfCnpjFiltro = New System.Windows.Forms.TextBox()
        Me.txtCidadeFiltro = New System.Windows.Forms.TextBox()
        Me.cmbStatusFiltro = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimparFiltro = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalClientes = New System.Windows.Forms.TextBox()
        Me.txtClientesAtivos = New System.Windows.Forms.TextBox()
        Me.txtClientesInativos = New System.Windows.Forms.TextBox()
        Me.btnVerDetalhes = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VoltarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.41253!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.58747!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomeFiltro, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCpfCnpjFiltro, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCidadeFiltro, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatusFiltro, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(25, 28)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(834, 136)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "🔍 Filtros de Busca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF/CNPJ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status"
        '
        'txtNomeFiltro
        '
        Me.txtNomeFiltro.Location = New System.Drawing.Point(3, 90)
        Me.txtNomeFiltro.Name = "txtNomeFiltro"
        Me.txtNomeFiltro.Size = New System.Drawing.Size(100, 29)
        Me.txtNomeFiltro.TabIndex = 5
        '
        'txtCpfCnpjFiltro
        '
        Me.txtCpfCnpjFiltro.Location = New System.Drawing.Point(204, 90)
        Me.txtCpfCnpjFiltro.Name = "txtCpfCnpjFiltro"
        Me.txtCpfCnpjFiltro.Size = New System.Drawing.Size(100, 29)
        Me.txtCpfCnpjFiltro.TabIndex = 6
        '
        'txtCidadeFiltro
        '
        Me.txtCidadeFiltro.Location = New System.Drawing.Point(466, 90)
        Me.txtCidadeFiltro.Name = "txtCidadeFiltro"
        Me.txtCidadeFiltro.Size = New System.Drawing.Size(100, 29)
        Me.txtCidadeFiltro.TabIndex = 7
        '
        'cmbStatusFiltro
        '
        Me.cmbStatusFiltro.FormattingEnabled = True
        Me.cmbStatusFiltro.Location = New System.Drawing.Point(702, 90)
        Me.cmbStatusFiltro.Name = "cmbStatusFiltro"
        Me.cmbStatusFiltro.Size = New System.Drawing.Size(121, 29)
        Me.cmbStatusFiltro.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(24, 172)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(148, 34)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimparFiltro
        '
        Me.btnLimparFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparFiltro.Location = New System.Drawing.Point(711, 172)
        Me.btnLimparFiltro.Name = "btnLimparFiltro"
        Me.btnLimparFiltro.Size = New System.Drawing.Size(148, 34)
        Me.btnLimparFiltro.TabIndex = 2
        Me.btnLimparFiltro.Text = "Limpar"
        Me.btnLimparFiltro.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.50614!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvClientes, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(24, 212)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.04938!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.95061!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(835, 162)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "👥 Clientes Encontrados"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.71429!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTotalClientes, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtClientesAtivos, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtClientesInativos, 2, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(24, 380)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.27778!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.72222!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(835, 132)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "📊 Resumo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total de Clientes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Clientes Alvos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(562, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Clientes Inativos"
        '
        'txtTotalClientes
        '
        Me.txtTotalClientes.Location = New System.Drawing.Point(3, 81)
        Me.txtTotalClientes.Multiline = True
        Me.txtTotalClientes.Name = "txtTotalClientes"
        Me.txtTotalClientes.Size = New System.Drawing.Size(278, 48)
        Me.txtTotalClientes.TabIndex = 4
        '
        'txtClientesAtivos
        '
        Me.txtClientesAtivos.Location = New System.Drawing.Point(287, 81)
        Me.txtClientesAtivos.Multiline = True
        Me.txtClientesAtivos.Name = "txtClientesAtivos"
        Me.txtClientesAtivos.Size = New System.Drawing.Size(269, 48)
        Me.txtClientesAtivos.TabIndex = 5
        '
        'txtClientesInativos
        '
        Me.txtClientesInativos.Location = New System.Drawing.Point(562, 81)
        Me.txtClientesInativos.Multiline = True
        Me.txtClientesInativos.Name = "txtClientesInativos"
        Me.txtClientesInativos.Size = New System.Drawing.Size(269, 48)
        Me.txtClientesInativos.TabIndex = 6
        '
        'btnVerDetalhes
        '
        Me.btnVerDetalhes.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVerDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDetalhes.Location = New System.Drawing.Point(24, 515)
        Me.btnVerDetalhes.Name = "btnVerDetalhes"
        Me.btnVerDetalhes.Size = New System.Drawing.Size(198, 39)
        Me.btnVerDetalhes.TabIndex = 5
        Me.btnVerDetalhes.Text = "Ver Detalhes"
        Me.btnVerDetalhes.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Location = New System.Drawing.Point(661, 515)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(198, 39)
        Me.btnAtualizar.TabIndex = 6
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(447, 515)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(198, 39)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(233, 515)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(198, 39)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.btnLimparFiltro)
        Me.Panel1.Controls.Add(Me.btnVerDetalhes)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Location = New System.Drawing.Point(31, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 589)
        Me.Panel1.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VoltarToolStripMenuItem.Text = "Voltar"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(3, 29)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(829, 130)
        Me.dgvClientes.TabIndex = 1
        '
        'Consultas_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(962, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Consultas_Cliente"
        Me.Text = "Consultas_Cliente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeFiltro As TextBox
    Friend WithEvents txtCpfCnpjFiltro As TextBox
    Friend WithEvents txtCidadeFiltro As TextBox
    Friend WithEvents cmbStatusFiltro As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimparFiltro As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalClientes As TextBox
    Friend WithEvents txtClientesAtivos As TextBox
    Friend WithEvents txtClientesInativos As TextBox
    Friend WithEvents btnVerDetalhes As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvClientes As DataGridView
End Class
