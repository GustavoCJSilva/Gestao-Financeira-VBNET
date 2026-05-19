Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Nova_Venda

    Private ReadOnly connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"
    Private ReadOnly cultura As New CultureInfo("pt-BR")
    Private itensVenda As DataTable

    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, AddressOf Nova_Venda_Load
        AddHandler cmbCliente.SelectedIndexChanged, AddressOf cmbCliente_SelectedIndexChanged
        AddHandler cmbProduto.SelectedIndexChanged, AddressOf cmbProduto_SelectedIndexChanged
        AddHandler btnAdicionarProduto.Click, AddressOf btnAdicionarProduto_Click
        AddHandler btnFinalizarVenda.Click, AddressOf btnFinalizarVenda_Click
        AddHandler btnLimpar.Click, AddressOf btnLimpar_Click
        AddHandler btnCancelar.Click, AddressOf btnCancelar_Click
        AddHandler dgvItensVenda.CellContentClick, AddressOf dgvItensVenda_CellContentClick
    End Sub

    Private Sub Nova_Venda_Load(sender As Object, e As EventArgs)
        PrepararTela()
        CriarTabelaItens()
        ConfigurarGrid()
        CarregarClientes()
        CarregarProdutos()
        CarregarFormasPagamento()
        CalcularTotais()
    End Sub

    Private Sub PrepararTela()
        dtpDataVenda.Value = Date.Today

        txtCpfCnpj.ReadOnly = True
        txtCodigoProduto.ReadOnly = True
        txtPrecoUnitario.ReadOnly = True
        txtSubtotal.ReadOnly = True
        txtDescontoTotal.ReadOnly = True
        txtTotalFinal.ReadOnly = True

        nudQuantidade.Minimum = 1
        nudQuantidade.Maximum = 999999
        nudQuantidade.Value = 1

        txtDesconto.Text = "0,00"
    End Sub

    Private Sub CriarTabelaItens()
        itensVenda = New DataTable()
        itensVenda.Columns.Add("IdProduto", GetType(Integer))
        itensVenda.Columns.Add("Produto", GetType(String))
        itensVenda.Columns.Add("Codigo", GetType(String))
        itensVenda.Columns.Add("Quantidade", GetType(Integer))
        itensVenda.Columns.Add("PrecoUnitario", GetType(Decimal))
        itensVenda.Columns.Add("Desconto", GetType(Decimal))
        itensVenda.Columns.Add("Total", GetType(Decimal))
    End Sub

    Private Sub ConfigurarGrid()
        dgvItensVenda.AutoGenerateColumns = False
        dgvItensVenda.Columns.Clear()
        dgvItensVenda.DataSource = itensVenda

        dgvItensVenda.Columns.Add(CriarColunaTexto("Produto", "Produto", "Produto", 250))
        dgvItensVenda.Columns.Add(CriarColunaTexto("Codigo", "Codigo", "Código", 100))
        dgvItensVenda.Columns.Add(CriarColunaTexto("Quantidade", "Quantidade", "Qtd", 70))
        dgvItensVenda.Columns.Add(CriarColunaTexto("PrecoUnitario", "PrecoUnitario", "Preço Unitário", 120))
        dgvItensVenda.Columns.Add(CriarColunaTexto("Desconto", "Desconto", "Desconto", 100))
        dgvItensVenda.Columns.Add(CriarColunaTexto("Total", "Total", "Total", 120))

        Dim colunaRemover As New DataGridViewButtonColumn()
        colunaRemover.Name = "Remover"
        colunaRemover.HeaderText = ""
        colunaRemover.Text = "Remover"
        colunaRemover.UseColumnTextForButtonValue = True
        colunaRemover.Width = 90
        dgvItensVenda.Columns.Add(colunaRemover)

        dgvItensVenda.ReadOnly = True
        dgvItensVenda.AllowUserToAddRows = False
        dgvItensVenda.AllowUserToDeleteRows = False
        dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItensVenda.MultiSelect = False
    End Sub

    Private Function CriarColunaTexto(nome As String, propriedade As String, titulo As String, largura As Integer) As DataGridViewTextBoxColumn
        Dim coluna As New DataGridViewTextBoxColumn()
        coluna.Name = nome
        coluna.DataPropertyName = propriedade
        coluna.HeaderText = titulo
        coluna.Width = largura
        Return coluna
    End Function

    Private Sub CarregarClientes()
        Dim sql As String =
            "SELECT IdCliente, Nome + ' ' + Sobrenome AS NomeCompleto, CpfCnpj " &
            "FROM CadastroClientes " &
            "WHERE ClienteAtivo = 1 " &
            "ORDER BY Nome, Sobrenome"

        Using conexao As New SqlConnection(connectionString)
            Using adaptador As New SqlDataAdapter(sql, conexao)
                Dim tabela As New DataTable()

                Try
                    adaptador.Fill(tabela)

                    cmbCliente.DataSource = tabela
                    cmbCliente.DisplayMember = "NomeCompleto"
                    cmbCliente.ValueMember = "IdCliente"
                    cmbCliente.SelectedIndex = -1

                    txtCpfCnpj.Clear()
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar clientes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CarregarProdutos()
        Dim sql As String =
            "SELECT IdProduto, NomeProduto, CodigoSku, PrecoVenda, Quantidade " &
            "FROM CadastroProdutos " &
            "WHERE ProdutoAtivo = 1 " &
            "ORDER BY NomeProduto"

        Using conexao As New SqlConnection(connectionString)
            Using adaptador As New SqlDataAdapter(sql, conexao)
                Dim tabela As New DataTable()

                Try
                    adaptador.Fill(tabela)

                    cmbProduto.DataSource = tabela
                    cmbProduto.DisplayMember = "NomeProduto"
                    cmbProduto.ValueMember = "IdProduto"
                    cmbProduto.SelectedIndex = -1

                    txtCodigoProduto.Clear()
                    txtPrecoUnitario.Clear()
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar produtos: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CarregarFormasPagamento()
        cmbFormaPagamento.Items.Clear()
        cmbFormaPagamento.Items.Add("Dinheiro")
        cmbFormaPagamento.Items.Add("Pix")
        cmbFormaPagamento.Items.Add("Cartão de Débito")
        cmbFormaPagamento.Items.Add("Cartão de Crédito")
        cmbFormaPagamento.Items.Add("Boleto")
        cmbFormaPagamento.SelectedIndex = -1
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbCliente.SelectedIndex = -1 OrElse TypeOf cmbCliente.SelectedItem IsNot DataRowView Then
            txtCpfCnpj.Clear()
            Return
        End If

        Dim linha As DataRowView = CType(cmbCliente.SelectedItem, DataRowView)
        txtCpfCnpj.Text = linha("CpfCnpj").ToString()
    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbProduto.SelectedIndex = -1 OrElse TypeOf cmbProduto.SelectedItem IsNot DataRowView Then
            txtCodigoProduto.Clear()
            txtPrecoUnitario.Clear()
            Return
        End If

        Dim linha As DataRowView = CType(cmbProduto.SelectedItem, DataRowView)
        Dim preco As Decimal = Convert.ToDecimal(linha("PrecoVenda"))

        txtCodigoProduto.Text = linha("CodigoSku").ToString()
        txtPrecoUnitario.Text = preco.ToString("N2", cultura)
        nudQuantidade.Value = 1
        txtDesconto.Text = "0,00"
    End Sub

    Private Sub btnAdicionarProduto_Click(sender As Object, e As EventArgs)
        If ValidarProdutoParaAdicionar() = False Then
            Return
        End If

        Dim linhaProduto As DataRowView = CType(cmbProduto.SelectedItem, DataRowView)

        Dim idProduto As Integer = Convert.ToInt32(linhaProduto("IdProduto"))
        Dim nomeProduto As String = linhaProduto("NomeProduto").ToString()
        Dim codigo As String = linhaProduto("CodigoSku").ToString()
        Dim estoqueAtual As Integer = Convert.ToInt32(linhaProduto("Quantidade"))
        Dim quantidade As Integer = Convert.ToInt32(nudQuantidade.Value)
        Dim precoUnitario As Decimal = ConverterDecimal(txtPrecoUnitario.Text)
        Dim desconto As Decimal = ConverterDecimal(txtDesconto.Text)
        Dim quantidadeAtualNoCarrinho As Integer = ObterQuantidadeProdutoNoCarrinho(idProduto)

        If quantidade + quantidadeAtualNoCarrinho > estoqueAtual Then
            MessageBox.Show("Quantidade maior que o estoque disponível. Estoque atual: " & estoqueAtual.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalItem As Decimal = quantidade * precoUnitario - desconto

        If totalItem < 0 Then
            MessageBox.Show("O desconto não pode ser maior que o total do item.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim linhaExistente As DataRow = ProcurarItemCarrinho(idProduto)

        If linhaExistente IsNot Nothing Then
            linhaExistente("Quantidade") = Convert.ToInt32(linhaExistente("Quantidade")) + quantidade
            linhaExistente("Desconto") = Convert.ToDecimal(linhaExistente("Desconto")) + desconto
            linhaExistente("Total") = Convert.ToDecimal(linhaExistente("Quantidade")) * precoUnitario - Convert.ToDecimal(linhaExistente("Desconto"))
        Else
            Dim novaLinha As DataRow = itensVenda.NewRow()
            novaLinha("IdProduto") = idProduto
            novaLinha("Produto") = nomeProduto
            novaLinha("Codigo") = codigo
            novaLinha("Quantidade") = quantidade
            novaLinha("PrecoUnitario") = precoUnitario
            novaLinha("Desconto") = desconto
            novaLinha("Total") = totalItem
            itensVenda.Rows.Add(novaLinha)
        End If

        CalcularTotais()
        LimparProdutoSelecionado()
    End Sub

    Private Function ValidarProdutoParaAdicionar() As Boolean
        If cmbProduto.SelectedIndex = -1 OrElse TypeOf cmbProduto.SelectedItem IsNot DataRowView Then
            MessageBox.Show("Selecione um produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProduto.Focus()
            Return False
        End If

        If nudQuantidade.Value <= 0 Then
            MessageBox.Show("Informe uma quantidade maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudQuantidade.Focus()
            Return False
        End If

        If txtPrecoUnitario.Text.Trim() = "" OrElse DecimalValido(txtPrecoUnitario.Text) = False Then
            MessageBox.Show("Preço unitário inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If txtDesconto.Text.Trim() = "" Then
            txtDesconto.Text = "0,00"
        End If

        If DecimalValido(txtDesconto.Text) = False Then
            MessageBox.Show("Desconto inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDesconto.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ObterQuantidadeProdutoNoCarrinho(idProduto As Integer) As Integer
        Dim quantidade As Integer = 0

        For Each linha As DataRow In itensVenda.Rows
            If Convert.ToInt32(linha("IdProduto")) = idProduto Then
                quantidade += Convert.ToInt32(linha("Quantidade"))
            End If
        Next

        Return quantidade
    End Function

    Private Function ProcurarItemCarrinho(idProduto As Integer) As DataRow
        For Each linha As DataRow In itensVenda.Rows
            If Convert.ToInt32(linha("IdProduto")) = idProduto Then
                Return linha
            End If
        Next

        Return Nothing
    End Function

    Private Sub dgvItensVenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then
            Return
        End If

        If dgvItensVenda.Columns(e.ColumnIndex).Name = "Remover" Then
            itensVenda.Rows(e.RowIndex).Delete()
            itensVenda.AcceptChanges()
            CalcularTotais()
        End If
    End Sub

    Private Sub CalcularTotais()
        Dim subtotal As Decimal = 0
        Dim descontoTotal As Decimal = 0
        Dim totalFinal As Decimal = 0

        For Each linha As DataRow In itensVenda.Rows
            subtotal += Convert.ToDecimal(linha("Quantidade")) * Convert.ToDecimal(linha("PrecoUnitario"))
            descontoTotal += Convert.ToDecimal(linha("Desconto"))
            totalFinal += Convert.ToDecimal(linha("Total"))
        Next

        txtSubtotal.Text = subtotal.ToString("N2", cultura)
        txtDescontoTotal.Text = descontoTotal.ToString("N2", cultura)
        txtTotalFinal.Text = totalFinal.ToString("N2", cultura)
    End Sub

    Private Sub btnFinalizarVenda_Click(sender As Object, e As EventArgs)
        If ValidarVenda() = False Then
            Return
        End If

        FinalizarVenda()
    End Sub

    Private Function ValidarVenda() As Boolean
        If cmbCliente.SelectedIndex = -1 OrElse TypeOf cmbCliente.SelectedItem IsNot DataRowView Then
            MessageBox.Show("Selecione um cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCliente.Focus()
            Return False
        End If

        If itensVenda.Rows.Count = 0 Then
            MessageBox.Show("Adicione pelo menos um produto na venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProduto.Focus()
            Return False
        End If

        If cmbFormaPagamento.SelectedIndex = -1 Then
            MessageBox.Show("Selecione a forma de pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFormaPagamento.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub FinalizarVenda()
        Dim idCliente As Integer = Convert.ToInt32(cmbCliente.SelectedValue)
        Dim subtotal As Decimal = ConverterDecimal(txtSubtotal.Text)
        Dim descontoTotal As Decimal = ConverterDecimal(txtDescontoTotal.Text)
        Dim totalFinal As Decimal = ConverterDecimal(txtTotalFinal.Text)
        Dim formaPagamento As String = cmbFormaPagamento.Text.Trim()

        Using conexao As New SqlConnection(connectionString)
            conexao.Open()

            Using transacao As SqlTransaction = conexao.BeginTransaction()
                Try
                    Dim idVenda As Integer = InserirVenda(conexao, transacao, idCliente, subtotal, descontoTotal, totalFinal, formaPagamento)

                    For Each linha As DataRow In itensVenda.Rows
                        InserirItemVenda(conexao, transacao, idVenda, linha)
                        BaixarEstoque(conexao, transacao, linha)
                    Next

                    transacao.Commit()

                    MessageBox.Show("Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LimparVenda()
                    CarregarProdutos()
                Catch ex As Exception
                    transacao.Rollback()
                    MessageBox.Show("Erro ao finalizar venda: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Function InserirVenda(conexao As SqlConnection, transacao As SqlTransaction, idCliente As Integer, subtotal As Decimal, descontoTotal As Decimal, totalFinal As Decimal, formaPagamento As String) As Integer
        Dim sql As String =
            "INSERT INTO Vendas " &
            "(IdCliente, DataVenda, Subtotal, DescontoTotal, TotalFinal, FormaPagamento, StatusVenda) " &
            "OUTPUT INSERTED.IdVenda " &
            "VALUES " &
            "(@IdCliente, @DataVenda, @Subtotal, @DescontoTotal, @TotalFinal, @FormaPagamento, @StatusVenda)"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente
            comando.Parameters.Add("@DataVenda", SqlDbType.DateTime).Value = dtpDataVenda.Value
            AdicionarParametroDecimal(comando, "@Subtotal", subtotal)
            AdicionarParametroDecimal(comando, "@DescontoTotal", descontoTotal)
            AdicionarParametroDecimal(comando, "@TotalFinal", totalFinal)
            comando.Parameters.Add("@FormaPagamento", SqlDbType.VarChar, 50).Value = formaPagamento
            comando.Parameters.Add("@StatusVenda", SqlDbType.VarChar, 30).Value = "Finalizada"

            Return Convert.ToInt32(comando.ExecuteScalar())
        End Using
    End Function

    Private Sub InserirItemVenda(conexao As SqlConnection, transacao As SqlTransaction, idVenda As Integer, linha As DataRow)
        Dim sql As String =
            "INSERT INTO VendaItens " &
            "(IdVenda, IdProduto, NomeProduto, CodigoSku, Quantidade, PrecoUnitario, Desconto, TotalItem) " &
            "VALUES " &
            "(@IdVenda, @IdProduto, @NomeProduto, @CodigoSku, @Quantidade, @PrecoUnitario, @Desconto, @TotalItem)"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@IdVenda", SqlDbType.Int).Value = idVenda
            comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = Convert.ToInt32(linha("IdProduto"))
            comando.Parameters.Add("@NomeProduto", SqlDbType.VarChar, 150).Value = linha("Produto").ToString()
            comando.Parameters.Add("@CodigoSku", SqlDbType.VarChar, 50).Value = linha("Codigo").ToString()
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = Convert.ToInt32(linha("Quantidade"))
            AdicionarParametroDecimal(comando, "@PrecoUnitario", Convert.ToDecimal(linha("PrecoUnitario")))
            AdicionarParametroDecimal(comando, "@Desconto", Convert.ToDecimal(linha("Desconto")))
            AdicionarParametroDecimal(comando, "@TotalItem", Convert.ToDecimal(linha("Total")))

            comando.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub BaixarEstoque(conexao As SqlConnection, transacao As SqlTransaction, linha As DataRow)
        Dim sql As String =
            "UPDATE CadastroProdutos " &
            "SET Quantidade = Quantidade - @Quantidade " &
            "WHERE IdProduto = @IdProduto AND Quantidade >= @Quantidade"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = Convert.ToInt32(linha("Quantidade"))
            comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = Convert.ToInt32(linha("IdProduto"))

            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

            If linhasAfetadas = 0 Then
                Throw New Exception("Estoque insuficiente para o produto: " & linha("Produto").ToString())
            End If
        End Using
    End Sub

    Private Sub AdicionarParametroDecimal(comando As SqlCommand, nomeParametro As String, valor As Decimal)
        Dim parametro As SqlParameter = comando.Parameters.Add(nomeParametro, SqlDbType.Decimal)
        parametro.Precision = 18
        parametro.Scale = 3
        parametro.Value = valor
    End Sub

    Private Function DecimalValido(valor As String) As Boolean
        Dim numero As Decimal
        Return Decimal.TryParse(LimparValorDecimal(valor), NumberStyles.Number, cultura, numero)
    End Function

    Private Function ConverterDecimal(valor As String) As Decimal
        Dim numero As Decimal
        Decimal.TryParse(LimparValorDecimal(valor), NumberStyles.Number, cultura, numero)
        Return numero
    End Function

    Private Function LimparValorDecimal(valor As String) As String
        If valor Is Nothing Then
            Return "0"
        End If

        Return valor.Replace("R$", "").Trim()
    End Function

    Private Sub LimparProdutoSelecionado()
        cmbProduto.SelectedIndex = -1
        txtCodigoProduto.Clear()
        txtPrecoUnitario.Clear()
        txtDesconto.Text = "0,00"
        nudQuantidade.Value = 1
    End Sub

    Private Sub LimparVenda()
        cmbCliente.SelectedIndex = -1
        txtCpfCnpj.Clear()
        dtpDataVenda.Value = Date.Today

        LimparProdutoSelecionado()

        itensVenda.Rows.Clear()
        CalcularTotais()

        cmbFormaPagamento.SelectedIndex = -1
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs)
        LimparVenda()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

End Class