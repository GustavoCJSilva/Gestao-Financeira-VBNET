<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastro_CltxtDataNascimentoientes
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
        Me.VoltarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSobrenomes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalvarCliente = New System.Windows.Forms.Button()
        Me.txtCpfCnpjs = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Contato = New System.Windows.Forms.Label()
        Me.txtDataNascimentos = New System.Windows.Forms.DateTimePicker()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbTipoCliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkClienteAtivo = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWhatsapp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.TextBox()
        Me.txtCidades = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarMenuToolStripMenuItem
        '
        Me.VoltarMenuToolStripMenuItem.Name = "VoltarMenuToolStripMenuItem"
        Me.VoltarMenuToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VoltarMenuToolStripMenuItem.Text = "Voltar ⬅️"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "👤 Dados do Cliente"
        '
        'txtNomes
        '
        Me.txtNomes.Location = New System.Drawing.Point(4, 106)
        Me.txtNomes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNomes.Name = "txtNomes"
        Me.txtNomes.Size = New System.Drawing.Size(143, 23)
        Me.txtNomes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome"
        '
        'txtSobrenomes
        '
        Me.txtSobrenomes.Location = New System.Drawing.Point(211, 106)
        Me.txtSobrenomes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSobrenomes.Name = "txtSobrenomes"
        Me.txtSobrenomes.Size = New System.Drawing.Size(143, 23)
        Me.txtSobrenomes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sobrenome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF/CNPJ"
        '
        'btnSalvarCliente
        '
        Me.btnSalvarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarCliente.ForeColor = System.Drawing.Color.White
        Me.btnSalvarCliente.Location = New System.Drawing.Point(18, 804)
        Me.btnSalvarCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalvarCliente.Name = "btnSalvarCliente"
        Me.btnSalvarCliente.Size = New System.Drawing.Size(144, 36)
        Me.btnSalvarCliente.TabIndex = 15
        Me.btnSalvarCliente.Text = "Salvar Cliente"
        Me.btnSalvarCliente.UseVisualStyleBackColor = False
        '
        'txtCpfCnpjs
        '
        Me.txtCpfCnpjs.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtCpfCnpjs.Location = New System.Drawing.Point(211, 221)
        Me.txtCpfCnpjs.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCpfCnpjs.Mask = "00000000000"
        Me.txtCpfCnpjs.Name = "txtCpfCnpjs"
        Me.txtCpfCnpjs.Size = New System.Drawing.Size(143, 23)
        Me.txtCpfCnpjs.TabIndex = 16
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(4, 109)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTelefone.Mask = "00000000000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(143, 23)
        Me.txtTelefone.TabIndex = 18
        '
        'Contato
        '
        Me.Contato.AutoSize = True
        Me.Contato.Location = New System.Drawing.Point(4, 48)
        Me.Contato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Contato.Name = "Contato"
        Me.Contato.Size = New System.Drawing.Size(52, 15)
        Me.Contato.TabIndex = 19
        Me.Contato.Text = "Telefone"
        '
        'txtDataNascimentos
        '
        Me.txtDataNascimentos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascimentos.Location = New System.Drawing.Point(429, 106)
        Me.txtDataNascimentos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDataNascimentos.Name = "txtDataNascimentos"
        Me.txtDataNascimentos.Size = New System.Drawing.Size(143, 23)
        Me.txtDataNascimentos.TabIndex = 20
        '
        'btnVerClientes
        '
        Me.btnVerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerClientes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.Location = New System.Drawing.Point(480, 804)
        Me.btnVerClientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(144, 36)
        Me.btnVerClientes.TabIndex = 21
        Me.btnVerClientes.Text = "Ver Clientes"
        Me.btnVerClientes.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(258, 804)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(128, 33)
        Me.btnLimpar.TabIndex = 22
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.6413!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3587!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDataNascimentos, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSobrenomes, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCpfCnpjs, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipoCliente, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkClienteAtivo, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomes, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(604, 258)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 164)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Tipo de Cliente"
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.Location = New System.Drawing.Point(4, 221)
        Me.cmbTipoCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(116, 23)
        Me.cmbTipoCliente.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(429, 164)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 15)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Status"
        '
        'chkClienteAtivo
        '
        Me.chkClienteAtivo.AutoSize = True
        Me.chkClienteAtivo.Location = New System.Drawing.Point(429, 221)
        Me.chkClienteAtivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkClienteAtivo.Name = "chkClienteAtivo"
        Me.chkClienteAtivo.Size = New System.Drawing.Size(94, 19)
        Me.chkClienteAtivo.TabIndex = 24
        Me.chkClienteAtivo.Text = "Cliente Ativo"
        Me.chkClienteAtivo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36956!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63044!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Contato, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTelefone, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtWhatsapp, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEmail, 2, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(18, 276)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(606, 168)
        Me.TableLayoutPanel2.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "📞 Contato"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Whatsapp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(430, 48)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "E-mail"
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(210, 109)
        Me.txtWhatsapp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(116, 23)
        Me.txtWhatsapp.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(430, 109)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(116, 23)
        Me.txtEmail.TabIndex = 23
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCep, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbEstado, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCidades, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtBairro, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtRua, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNumero, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtComplemento, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 5)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(18, 451)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(606, 226)
        Me.TableLayoutPanel3.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "📍 Endereço"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "CEP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(212, 29)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(434, 29)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Cidade"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(4, 60)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(116, 23)
        Me.txtCep.TabIndex = 4
        '
        'cmbEstado
        '
        Me.cmbEstado.Location = New System.Drawing.Point(212, 60)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(116, 23)
        Me.cmbEstado.TabIndex = 5
        '
        'txtCidades
        '
        Me.txtCidades.Location = New System.Drawing.Point(434, 60)
        Me.txtCidades.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCidades.Name = "txtCidades"
        Me.txtCidades.Size = New System.Drawing.Size(116, 23)
        Me.txtCidades.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Rua"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(434, 105)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Número"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(4, 136)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(116, 23)
        Me.txtBairro.TabIndex = 10
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(212, 136)
        Me.txtRua.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(116, 23)
        Me.txtRua.TabIndex = 11
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(434, 136)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(116, 23)
        Me.txtNumero.TabIndex = 12
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(4, 193)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(116, 23)
        Me.txtComplemento.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 168)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Complemento"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtObservacoes, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(18, 683)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(606, 115)
        Me.TableLayoutPanel4.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "📝 Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.Location = New System.Drawing.Point(4, 22)
        Me.txtObservacoes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtObservacoes.Multiline = True
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(597, 88)
        Me.txtObservacoes.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.btnSalvarCliente)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.btnVerClientes)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(14, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 848)
        Me.Panel1.TabIndex = 27
        '
        'Cadastro_CltxtDataNascimentoientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 892)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cadastro_CltxtDataNascimentoientes"
        Me.Text = "Cadastro_Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrenomes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalvarCliente As Button
    Friend WithEvents txtCpfCnpjs As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Contato As Label
    Friend WithEvents txtDataNascimentos As DateTimePicker
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtWhatsapp As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCep As TextBox
    Friend WithEvents cmbEstado As TextBox
    Friend WithEvents txtCidades As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtRua As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbTipoCliente As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkClienteAtivo As CheckBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents Panel1 As Panel
End Class
