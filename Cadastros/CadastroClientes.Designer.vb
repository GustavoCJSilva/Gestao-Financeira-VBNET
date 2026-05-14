<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_CltxtDataNascimentoientes
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
        Me.VoltarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCliente = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSobrenomes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEstados = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidades = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCpfCnpjs = New System.Windows.Forms.MaskedTextBox()
        Me.txtcontato = New System.Windows.Forms.MaskedTextBox()
        Me.Contato = New System.Windows.Forms.Label()
        Me.txtDataNascimentos = New System.Windows.Forms.DateTimePicker()
        Me.Cadastros = New System.Windows.Forms.Button()
        Me.Atualizar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoltarMenuToolStripMenuItem
        '
        Me.VoltarMenuToolStripMenuItem.Name = "VoltarMenuToolStripMenuItem"
        Me.VoltarMenuToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.VoltarMenuToolStripMenuItem.Text = "Voltar Menu"
        '
        'lstCliente
        '
        Me.lstCliente.FormattingEnabled = True
        Me.lstCliente.Location = New System.Drawing.Point(0, 27)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(875, 563)
        Me.lstCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(881, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Adicionar Cliente"
        '
        'txtNomes
        '
        Me.txtNomes.Location = New System.Drawing.Point(884, 112)
        Me.txtNomes.Name = "txtNomes"
        Me.txtNomes.Size = New System.Drawing.Size(123, 20)
        Me.txtNomes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(881, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome"
        '
        'txtSobrenomes
        '
        Me.txtSobrenomes.Location = New System.Drawing.Point(1031, 112)
        Me.txtSobrenomes.Name = "txtSobrenomes"
        Me.txtSobrenomes.Size = New System.Drawing.Size(123, 20)
        Me.txtSobrenomes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1028, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sobrenome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1183, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(881, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF / CNPJ"
        '
        'txtEstados
        '
        Me.txtEstados.Location = New System.Drawing.Point(1031, 201)
        Me.txtEstados.Name = "txtEstados"
        Me.txtEstados.Size = New System.Drawing.Size(123, 20)
        Me.txtEstados.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1028, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Estado"
        '
        'txtCidades
        '
        Me.txtCidades.Location = New System.Drawing.Point(1186, 200)
        Me.txtCidades.Name = "txtCidades"
        Me.txtCidades.Size = New System.Drawing.Size(123, 20)
        Me.txtCidades.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1183, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cidade"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(884, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Adicionar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCpfCnpjs
        '
        Me.txtCpfCnpjs.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtCpfCnpjs.Location = New System.Drawing.Point(884, 201)
        Me.txtCpfCnpjs.Mask = "00000000000"
        Me.txtCpfCnpjs.Name = "txtCpfCnpjs"
        Me.txtCpfCnpjs.Size = New System.Drawing.Size(123, 20)
        Me.txtCpfCnpjs.TabIndex = 16
        '
        'txtcontato
        '
        Me.txtcontato.Location = New System.Drawing.Point(884, 259)
        Me.txtcontato.Mask = "00000000000"
        Me.txtcontato.Name = "txtcontato"
        Me.txtcontato.Size = New System.Drawing.Size(123, 20)
        Me.txtcontato.TabIndex = 18
        '
        'Contato
        '
        Me.Contato.AutoSize = True
        Me.Contato.Location = New System.Drawing.Point(881, 243)
        Me.Contato.Name = "Contato"
        Me.Contato.Size = New System.Drawing.Size(44, 13)
        Me.Contato.TabIndex = 19
        Me.Contato.Text = "Contato"
        '
        'txtDataNascimentos
        '
        Me.txtDataNascimentos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascimentos.Location = New System.Drawing.Point(1186, 112)
        Me.txtDataNascimentos.Name = "txtDataNascimentos"
        Me.txtDataNascimentos.Size = New System.Drawing.Size(123, 20)
        Me.txtDataNascimentos.TabIndex = 20
        '
        'Cadastros
        '
        Me.Cadastros.Location = New System.Drawing.Point(1031, 300)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Size = New System.Drawing.Size(123, 23)
        Me.Cadastros.TabIndex = 21
        Me.Cadastros.Text = "Cadastros Feitos"
        Me.Cadastros.UseVisualStyleBackColor = True
        '
        'Atualizar
        '
        Me.Atualizar.Location = New System.Drawing.Point(1186, 300)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(123, 23)
        Me.Atualizar.TabIndex = 22
        Me.Atualizar.Text = "Atualizar"
        Me.Atualizar.UseVisualStyleBackColor = True
        '
        'Cadastro_CltxtDataNascimentoientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 700)
        Me.Controls.Add(Me.Atualizar)
        Me.Controls.Add(Me.Cadastros)
        Me.Controls.Add(Me.txtDataNascimentos)
        Me.Controls.Add(Me.Contato)
        Me.Controls.Add(Me.txtcontato)
        Me.Controls.Add(Me.txtCpfCnpjs)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCidades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEstados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSobrenomes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cadastro_CltxtDataNascimentoientes"
        Me.Text = "Cadastro_Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoltarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstCliente As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrenomes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEstados As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCidades As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCpfCnpjs As MaskedTextBox
    Friend WithEvents txtcontato As MaskedTextBox
    Friend WithEvents Contato As Label
    Friend WithEvents txtDataNascimentos As DateTimePicker
    Friend WithEvents Cadastros As Button
    Friend WithEvents Atualizar As Button
End Class
