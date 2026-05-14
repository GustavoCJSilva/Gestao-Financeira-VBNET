Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class CadastroProdutos 'Formulário para Cadastrar Produtos com Layout Profissional e Conexão com Banco de Dados SQL Server'

    Private ReadOnly connectionString As String =
        "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"

    Private pnlSombra As Panel
    Private pnlCabecalho As Panel
    Private lblTituloTela As Label
    Private lblSubtituloTela As Label

    Private Sub CadastroProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Configura o Formulário ao Carregar a Tela'
        ConfigurarTela()
        MontarLayoutProfissional()
        AplicarTema()
        CentralizarConteudo()
    End Sub

    Private Sub CadastroProdutos_Resize(sender As Object, e As EventArgs) Handles Me.Resize 'Recalcula o Layout para Manter o Formulário Centralizado e com Proporções Adequadas'
        CentralizarConteudo()
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click 'Fecha o Formulário para Voltar à Tela Anterior'
        Close()
    End Sub

    Private Sub ConfigurarTela() 'Configura as Propriedades Básicas do Formulário'
        Me.BackColor = Color.FromArgb(226, 232, 240)
        Me.Font = New Font("Segoe UI", 9.0F)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = New Size(1180, 900)

        pnlConteudo.Dock = DockStyle.None
        pnlConteudo.Anchor = AnchorStyles.None
        pnlConteudo.AutoSize = False
        pnlConteudo.Width = 980
        pnlConteudo.Height = 820
        pnlConteudo.BackColor = Color.White
        pnlConteudo.BorderStyle = BorderStyle.None
    End Sub

    Private Sub MontarLayoutProfissional() 'Limpa o Painel de Conteúdo e Cria um Layout Profissional para o Formulário'
        pnlConteudo.Controls.Clear()

        CriarSombra()
        CriarCabecalho()

        Dim margemX As Integer = 48
        Dim larguraConteudo As Integer = pnlConteudo.Width - 96

        Dim campoW As Integer = 160
        Dim campoH As Integer = 26

        Dim col1 As Integer = margemX
        Dim col2 As Integer = margemX + 235
        Dim col3 As Integer = margemX + 470
        Dim col4 As Integer = margemX + 705


        CriarTituloSecao("Dados do Produto", margemX, 112)

        CriarLabelCampo("Nome", col1, 142)
        ConfigurarCampo(nome, col1, 164, campoW, campoH)

        CriarLabelCampo("Marca", col2, 142)
        ConfigurarCampo(marca, col2, 164, campoW, campoH)

        CriarLabelCampo("Modelo", col3, 142)
        ConfigurarCampo(modelo, col3, 164, campoW, campoH)

        CriarLabelCampo("Quantidade", col4, 142)
        ConfigurarCampo(quantidade, col4, 164, campoW, campoH)

        CriarLabelCampo("Material", col1, 204)
        ConfigurarCampo(material, col1, 226, campoW, campoH)

        CriarLabelCampo("Cor", col2, 204)
        ConfigurarCampo(cor, col2, 226, campoW, campoH)

        CriarLabelCampo("Voltagem", col3, 204)
        ConfigurarCampo(voltagem, col3, 226, campoW, campoH)

        CriarLabelCampo("Componentes", col4, 204)
        ConfigurarCampo(componentes, col4, 226, campoW, campoH)

        CriarLinhaSeparadora(margemX, 278, larguraConteudo)



        CriarTituloSecao("Medidas e Valores", margemX, 302)

        CriarLabelCampo("Medida", col1, 332)
        ConfigurarCampo(medida, col1, 354, campoW, campoH)

        CriarLabelCampo("Altura", col2, 332)
        ConfigurarCampo(altura, col2, 354, campoW, campoH)

        CriarLabelCampo("Largura", col3, 332)
        ConfigurarCampo(largura, col3, 354, campoW, campoH)

        CriarLabelCampo("Tamanho", col4, 332)
        ConfigurarCampo(tamanho, col4, 354, campoW, campoH)

        CriarLabelCampo("Comprimento", col1, 394)
        ConfigurarCampo(comprimento, col1, 416, campoW, campoH)

        CriarLabelCampo("Frete", col2, 394)
        ConfigurarCampo(frete, col2, 416, campoW, campoH)

        CriarLabelCampo("Preço", col3, 394)
        ConfigurarCampo(preço, col3, 416, campoW, campoH)

        CriarLinhaSeparadora(margemX, 468, larguraConteudo)


        CriarTituloSecao("Descrição", margemX, 492)

        descricao.Parent = pnlConteudo
        descricao.Left = margemX
        descricao.Top = 522
        descricao.Width = larguraConteudo
        descricao.Height = 110
        descricao.Multiline = True
        descricao.ScrollBars = ScrollBars.Vertical
        descricao.BackColor = Color.FromArgb(248, 250, 252)
        descricao.ForeColor = Color.FromArgb(15, 23, 42)
        descricao.BorderStyle = BorderStyle.FixedSingle
        descricao.Font = New Font("Segoe UI", 9.0F)

        ' 

        Button1.Parent = pnlConteudo
        Button1.Text = "Cadastrar Produto"
        Button1.Left = margemX
        Button1.Top = 654
        Button1.Width = 150
        Button1.Height = 36

        Button2.Parent = pnlConteudo
        Button2.Text = "Ver Produtos"
        Button2.Left = Button1.Right + 16
        Button2.Top = 654
        Button2.Width = 145
        Button2.Height = 36


        CriarTituloSecao("Produtos Cadastrados", margemX, 710)

        lista.Parent = pnlConteudo
        lista.Left = margemX
        lista.Top = 738
        lista.Width = larguraConteudo
        lista.Height = 60
        lista.Visible = True
        lista.HorizontalScrollbar = True

        pnlConteudo.BringToFront()
    End Sub

    Private Sub CriarSombra() 'Cria um Painel de Sombra para Dar Profundidade ao Layout'
        If pnlConteudo.Parent Is Nothing Then
            Return
        End If

        If pnlSombra Is Nothing OrElse pnlSombra.IsDisposed Then
            pnlSombra = New Panel()
            pnlSombra.Name = "pnlSombra"
            pnlSombra.BackColor = Color.FromArgb(148, 163, 184)

            pnlConteudo.Parent.Controls.Add(pnlSombra)
            pnlSombra.SendToBack()
        End If

        AtualizarSombra()
    End Sub

    Private Sub AtualizarSombra() 'Posiciona a Sombra Atrás do Painel de Conteúdo'
        If pnlSombra Is Nothing OrElse pnlSombra.IsDisposed Then
            Return
        End If

        pnlSombra.Width = pnlConteudo.Width
        pnlSombra.Height = pnlConteudo.Height
        pnlSombra.Left = pnlConteudo.Left + 10
        pnlSombra.Top = pnlConteudo.Top + 10

        pnlSombra.SendToBack()
        pnlConteudo.BringToFront()
    End Sub

    Private Sub CriarCabecalho() 'Cria o Painel de Cabeçalho com Título e Subtítulo'
        pnlCabecalho = New Panel()
        pnlCabecalho.Name = "pnlCabecalho"
        pnlCabecalho.Left = 0
        pnlCabecalho.Top = 0
        pnlCabecalho.Width = pnlConteudo.Width
        pnlCabecalho.Height = 86
        pnlCabecalho.BackColor = Color.FromArgb(15, 23, 42)

        lblTituloTela = New Label()
        lblTituloTela.Text = "Cadastro de Produtos"
        lblTituloTela.AutoSize = True
        lblTituloTela.Left = 32
        lblTituloTela.Top = 18
        lblTituloTela.ForeColor = Color.White
        lblTituloTela.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)

        lblSubtituloTela = New Label()
        lblSubtituloTela.Text = "Registre produtos com dados técnicos, medidas, valores e descrição"
        lblSubtituloTela.AutoSize = True
        lblSubtituloTela.Left = 34
        lblSubtituloTela.Top = 52
        lblSubtituloTela.ForeColor = Color.FromArgb(203, 213, 225)
        lblSubtituloTela.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        pnlCabecalho.Controls.Add(lblTituloTela)
        pnlCabecalho.Controls.Add(lblSubtituloTela)

        pnlConteudo.Controls.Add(pnlCabecalho)
        pnlCabecalho.BringToFront()
    End Sub

    Private Sub CriarTituloSecao(texto As String, x As Integer, y As Integer) 'Cria Títulos para as Seções do Formulário'
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.AutoSize = True
        lbl.Left = x
        lbl.Top = y
        lbl.ForeColor = Color.FromArgb(37, 99, 235)
        lbl.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

        pnlConteudo.Controls.Add(lbl)
    End Sub

    Private Sub CriarLabelCampo(texto As String, x As Integer, y As Integer) 'Cria um Label para Identificar os Campos de Texto'
        Dim lbl As New Label()
        lbl.Text = texto
        lbl.AutoSize = True
        lbl.Left = x
        lbl.Top = y
        lbl.ForeColor = Color.FromArgb(30, 41, 59)
        lbl.Font = New Font("Segoe UI", 8.7F, FontStyle.Regular)

        pnlConteudo.Controls.Add(lbl)
    End Sub

    Private Sub CriarLinhaSeparadora(x As Integer, y As Integer, largura As Integer) 'Cria uma Linha Fina para Separar as Seções do Formulário'
        Dim linha As New Panel()
        linha.Left = x
        linha.Top = y
        linha.Width = largura
        linha.Height = 1
        linha.BackColor = Color.FromArgb(226, 232, 240)

        pnlConteudo.Controls.Add(linha)
    End Sub

    Private Sub ConfigurarCampo(campo As TextBox, x As Integer, y As Integer, largura As Integer, altura As Integer) 'Configura o Estilo dos Campos de Texto'
        campo.Parent = pnlConteudo
        campo.Left = x
        campo.Top = y
        campo.Width = largura
        campo.Height = altura
        campo.BackColor = Color.FromArgb(248, 250, 252)
        campo.ForeColor = Color.FromArgb(15, 23, 42)
        campo.BorderStyle = BorderStyle.FixedSingle
        campo.Font = New Font("Segoe UI", 9.0F)
    End Sub

    Private Sub CentralizarConteudo() 'Centraliza o Painel do Formulário'
        If pnlConteudo Is Nothing OrElse pnlConteudo.Parent Is Nothing Then
            Return
        End If

        Dim larguraArea As Integer = pnlConteudo.Parent.ClientSize.Width
        Dim alturaArea As Integer = pnlConteudo.Parent.ClientSize.Height

        pnlConteudo.Left = Math.Max(20, (larguraArea - pnlConteudo.Width) \ 2)
        pnlConteudo.Top = Math.Max(55, (alturaArea - pnlConteudo.Height) \ 2)

        AtualizarSombra()
    End Sub

    Private Sub AplicarTema() 'Aplica o Tema Personalizado'
        EstilizarBotaoPrimario(Button1)
        EstilizarBotaoSecundario(Button2)
        EstilizarLista()
    End Sub

    Private Sub EstilizarBotaoPrimario(botao As Button) 'Define o Estilo do Botão Primário'
        botao.FlatStyle = FlatStyle.Flat
        botao.FlatAppearance.BorderSize = 0
        botao.BackColor = Color.FromArgb(37, 99, 235)
        botao.ForeColor = Color.White
        botao.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        botao.Cursor = Cursors.Hand
    End Sub

    Private Sub EstilizarBotaoSecundario(botao As Button) 'Define o Estilo do Botão Secundário'
        botao.FlatStyle = FlatStyle.Flat
        botao.FlatAppearance.BorderSize = 1
        botao.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        botao.BackColor = Color.White
        botao.ForeColor = Color.FromArgb(15, 23, 42)
        botao.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        botao.Cursor = Cursors.Hand
    End Sub

    Private Sub EstilizarLista() 'Deixa a Lista com o Mesmo Tema do Formulário'
        lista.BackColor = Color.FromArgb(248, 250, 252)
        lista.ForeColor = Color.FromArgb(15, 23, 42)
        lista.BorderStyle = BorderStyle.FixedSingle
        lista.Font = New Font("Consolas", 9.0F)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Cadastrando o Produto
        Dim nomeProduto As String = Me.nome.Text.Trim()
        Dim marcaProduto As String = Me.marca.Text.Trim()
        Dim modeloProduto As String = Me.modelo.Text.Trim()
        Dim quantidadeProduto As String = Me.quantidade.Text.Trim()
        Dim materialProduto As String = Me.material.Text.Trim()
        Dim corProduto As String = Me.cor.Text.Trim()
        Dim voltagemProduto As String = Me.voltagem.Text.Trim()
        Dim componentesProduto As String = Me.componentes.Text.Trim()
        Dim medidaProduto As String = Me.medida.Text.Trim()
        Dim alturaProduto As String = Me.altura.Text.Trim()
        Dim larguraProduto As String = Me.largura.Text.Trim()
        Dim tamanhoProduto As String = Me.tamanho.Text.Trim()
        Dim freteProduto As String = Me.frete.Text.Trim()
        Dim comprimentoProduto As String = Me.comprimento.Text.Trim()
        Dim precoProduto As String = Me.preço.Text.Trim()
        Dim descricaoProduto As String = Me.descricao.Text.Trim()

        If String.IsNullOrWhiteSpace(nomeProduto) OrElse
           String.IsNullOrWhiteSpace(marcaProduto) OrElse
           String.IsNullOrWhiteSpace(modeloProduto) OrElse
           String.IsNullOrWhiteSpace(quantidadeProduto) OrElse
           String.IsNullOrWhiteSpace(materialProduto) OrElse
           String.IsNullOrWhiteSpace(corProduto) OrElse
           String.IsNullOrWhiteSpace(voltagemProduto) OrElse
           String.IsNullOrWhiteSpace(componentesProduto) OrElse
           String.IsNullOrWhiteSpace(medidaProduto) OrElse
           String.IsNullOrWhiteSpace(alturaProduto) OrElse
           String.IsNullOrWhiteSpace(larguraProduto) OrElse
           String.IsNullOrWhiteSpace(tamanhoProduto) OrElse
           String.IsNullOrWhiteSpace(freteProduto) OrElse
           String.IsNullOrWhiteSpace(comprimentoProduto) OrElse
           String.IsNullOrWhiteSpace(precoProduto) OrElse
           String.IsNullOrWhiteSpace(descricaoProduto) Then

            MessageBox.Show("Preencha todos os campos antes de cadastrar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sql As String =
            "INSERT INTO CadProdu " &
            "(Nome, Marca, Modelo, Quantidade, Material, Cor, Voltagem, Componentes, Medida, Altura, Largura, Tamanho, Frete, Comprimento, Preco, Descricao) " &
            "VALUES " &
            "(@Nome, @Marca, @Modelo, @Quantidade, @Material, @Cor, @Voltagem, @Componentes, @Medida, @Altura, @Largura, @Tamanho, @Frete, @Comprimento, @Preco, @Descricao)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)

                command.Parameters.AddWithValue("@Nome", nomeProduto)
                command.Parameters.AddWithValue("@Marca", marcaProduto)
                command.Parameters.AddWithValue("@Modelo", modeloProduto)
                command.Parameters.AddWithValue("@Quantidade", quantidadeProduto)
                command.Parameters.AddWithValue("@Material", materialProduto)
                command.Parameters.AddWithValue("@Cor", corProduto)
                command.Parameters.AddWithValue("@Voltagem", voltagemProduto)
                command.Parameters.AddWithValue("@Componentes", componentesProduto)
                command.Parameters.AddWithValue("@Medida", medidaProduto)
                command.Parameters.AddWithValue("@Altura", alturaProduto)
                command.Parameters.AddWithValue("@Largura", larguraProduto)
                command.Parameters.AddWithValue("@Tamanho", tamanhoProduto)
                command.Parameters.AddWithValue("@Frete", freteProduto)
                command.Parameters.AddWithValue("@Comprimento", comprimentoProduto)
                command.Parameters.AddWithValue("@Preco", precoProduto)
                command.Parameters.AddWithValue("@Descricao", descricaoProduto)

                Try
                    connection.Open()

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimparCampos()
                    Else
                        MessageBox.Show("Falha ao cadastrar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Erro ao cadastrar produto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Botão de Mostrar os Produtos'
        lista.Visible = True
        lista.Items.Clear()

        Dim sql As String =
            "SELECT Nome, Marca, Modelo, Quantidade, Material, Cor, Voltagem, Componentes, Medida, Altura, Largura, Tamanho, Frete, Comprimento, Preco " &
            "FROM CadProdu"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)

                Try
                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            Dim item As String =
                                reader("Nome").ToString() & " | " &
                                reader("Marca").ToString() & " | " &
                                reader("Modelo").ToString() & " | Qtd: " &
                                reader("Quantidade").ToString() & " | R$ " &
                                reader("Preco").ToString()

                            lista.Items.Add(item)
                        End While
                    End Using

                    If lista.Items.Count = 0 Then
                        lista.Items.Add("Nenhum produto cadastrado.")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Erro ao buscar produtos: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub


    Private Sub preço_KeyPress(sender As Object, e As KeyPressEventArgs) Handles preço.KeyPress, frete.KeyPress 'Bloqueia Outros Caracteres sem serem Numeros'
        If Not Char.IsDigit(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) AndAlso
           e.KeyChar <> ","c AndAlso
           e.KeyChar <> "."c Then

            e.Handled = True
        End If
    End Sub

    Private Sub LimparCampos() 'Limpa os Campos Após o Cadastro'
        nome.Clear()
        marca.Clear()
        modelo.Clear()
        quantidade.Clear()
        material.Clear()
        cor.Clear()
        voltagem.Clear()
        componentes.Clear()
        medida.Clear()
        altura.Clear()
        largura.Clear()
        tamanho.Clear()
        frete.Clear()
        comprimento.Clear()
        preço.Clear()
        descricao.Clear()

        nome.Focus()
    End Sub

End Class