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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_CltxtDataNascimentoientes))
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lstCliente.Location = New System.Drawing.Point(185, 125)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(327, 82)
        Me.lstCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Adicionar Cliente"
        '
        'txtNomes
        '
        Me.txtNomes.Location = New System.Drawing.Point(3, 36)
        Me.txtNomes.Name = "txtNomes"
        Me.txtNomes.Size = New System.Drawing.Size(123, 20)
        Me.txtNomes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome"
        '
        'txtSobrenomes
        '
        Me.txtSobrenomes.Location = New System.Drawing.Point(185, 36)
        Me.txtSobrenomes.Name = "txtSobrenomes"
        Me.txtSobrenomes.Size = New System.Drawing.Size(123, 20)
        Me.txtSobrenomes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sobrenome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(536, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF / CNPJ"
        '
        'txtEstados
        '
        Me.txtEstados.Location = New System.Drawing.Point(185, 80)
        Me.txtEstados.Name = "txtEstados"
        Me.txtEstados.Size = New System.Drawing.Size(123, 20)
        Me.txtEstados.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Estado"
        '
        'txtCidades
        '
        Me.txtCidades.Location = New System.Drawing.Point(536, 80)
        Me.txtCidades.Name = "txtCidades"
        Me.txtCidades.Size = New System.Drawing.Size(123, 20)
        Me.txtCidades.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(536, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cidade"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Adicionar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCpfCnpjs
        '
        Me.txtCpfCnpjs.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtCpfCnpjs.Location = New System.Drawing.Point(3, 80)
        Me.txtCpfCnpjs.Mask = "00000000000"
        Me.txtCpfCnpjs.Name = "txtCpfCnpjs"
        Me.txtCpfCnpjs.Size = New System.Drawing.Size(123, 20)
        Me.txtCpfCnpjs.TabIndex = 16
        '
        'txtcontato
        '
        Me.txtcontato.Location = New System.Drawing.Point(3, 125)
        Me.txtcontato.Mask = "00000000000"
        Me.txtcontato.Name = "txtcontato"
        Me.txtcontato.Size = New System.Drawing.Size(123, 20)
        Me.txtcontato.TabIndex = 18
        '
        'Contato
        '
        Me.Contato.AutoSize = True
        Me.Contato.Location = New System.Drawing.Point(3, 106)
        Me.Contato.Name = "Contato"
        Me.Contato.Size = New System.Drawing.Size(44, 13)
        Me.Contato.TabIndex = 19
        Me.Contato.Text = "Contato"
        '
        'txtDataNascimentos
        '
        Me.txtDataNascimentos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascimentos.Location = New System.Drawing.Point(536, 36)
        Me.txtDataNascimentos.Name = "txtDataNascimentos"
        Me.txtDataNascimentos.Size = New System.Drawing.Size(123, 20)
        Me.txtDataNascimentos.TabIndex = 20
        '
        'Cadastros
        '
        Me.Cadastros.Location = New System.Drawing.Point(185, 242)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Size = New System.Drawing.Size(123, 23)
        Me.Cadastros.TabIndex = 21
        Me.Cadastros.Text = "Cadastros Feitos"
        Me.Cadastros.UseVisualStyleBackColor = True
        '
        'Atualizar
        '
        Me.Atualizar.Location = New System.Drawing.Point(536, 242)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(123, 23)
        Me.Atualizar.TabIndex = 22
        Me.Atualizar.Text = "Atualizar"
        Me.Atualizar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.13379!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.86621!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Atualizar, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cadastros, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcontato, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lstCliente, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Contato, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDataNascimentos, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCpfCnpjs, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCidades, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomes, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEstados, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSobrenomes, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(988, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.66019!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.33981!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(696, 419)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ver Clientes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(195, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 647)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Cadastro_CltxtDataNascimentoientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cadastro_CltxtDataNascimentoientes"
        Me.Text = "Cadastro_Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
