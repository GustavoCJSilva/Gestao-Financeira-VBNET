Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Historico_de_Vendas

    Private ReadOnly connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"
    Private ReadOnly cultura As New CultureInfo("pt-BR")

    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, AddressOf Historico_de_Vendas_Load
        AddHandler btnBuscar.Click, AddressOf btnBuscar_Click
        AddHandler btnAtualizar.Click, AddressOf btnAtualizar_Click
        AddHandler btnCancelarVenda.Click, AddressOf btnCancelarVenda_Click
        AddHandler btnVoltar.Click, AddressOf btnVoltar_Click
    End Sub

    Private Sub Historico_de_Vendas_Load(sender As Object, e As EventArgs)
        PrepararTela()
        ConfigurarGrid()
        CarregarClientes()
        CarregarFormasPagamento()
        CarregarStatus()
        CarregarVendas()
    End Sub

    Private Sub PrepararTela()
        dtpDataInicial.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpDataFinal.Value = Date.Today

        txtTotalVendas.ReadOnly = True
        txtValorTotal.ReadOnly = True
        txtVendasCanceladas.ReadOnly = True
    End Sub

    Private Sub ConfigurarGrid()
        dgvVendas.AutoGenerateColumns = False
        dgvVendas.Columns.Clear()

        dgvVendas.Columns.Add(CriarColunaTexto("IdVenda", "IdVenda", "Código", 70))
        dgvVendas.Columns.Add(CriarColunaTexto("DataVenda", "DataVenda", "Data", 110, "dd/MM/yyyy"))
        dgvVendas.Columns.Add(CriarColunaTexto("Cliente", "Cliente", "Cliente", 220))
        dgvVendas.Columns.Add(CriarColunaTexto("FormaPagamento", "FormaPagamento", "Pagamento", 140))
        dgvVendas.Columns.Add(CriarColunaTexto("QuantidadeItens", "QuantidadeItens", "Itens", 70))
        dgvVendas.Columns.Add(CriarColunaTexto("Subtotal", "Subtotal", "Subtotal", 110, "N2"))
        dgvVendas.Columns.Add(CriarColunaTexto("DescontoTotal", "DescontoTotal", "Desconto", 110, "N2"))
        dgvVendas.Columns.Add(CriarColunaTexto("TotalFinal", "TotalFinal", "Total", 110, "N2"))
        dgvVendas.Columns.Add(CriarColunaTexto("StatusVenda", "StatusVenda", "Status", 110))

        dgvVendas.ReadOnly = True
        dgvVendas.AllowUserToAddRows = False
        dgvVendas.AllowUserToDeleteRows = False
        dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVendas.MultiSelect = False
        dgvVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVendas.RowHeadersVisible = False
        dgvVendas.BackgroundColor = Color.White
    End Sub

    Private Function CriarColunaTexto(nome As String, propriedade As String, titulo As String, largura As Integer, Optional formato As String = "") As DataGridViewTextBoxColumn
        Dim coluna As New DataGridViewTextBoxColumn()

        coluna.Name = nome
        coluna.DataPropertyName = propriedade
        coluna.HeaderText = titulo
        coluna.Width = largura

        If formato <> "" Then
            coluna.DefaultCellStyle.Format = formato
        End If

        Return coluna
    End Function

    Private Sub CarregarClientes()
        Dim sql As String =
            "SELECT IdCliente, NomeCompleto FROM " &
            "(SELECT 0 AS IdCliente, 'Todos' AS NomeCompleto " &
            "UNION ALL " &
            "SELECT IdCliente, Nome + ' ' + Sobrenome AS NomeCompleto FROM CadastroClientes) AS Clientes " &
            "ORDER BY CASE WHEN IdCliente = 0 THEN 0 ELSE 1 END, NomeCompleto"

        Using conexao As New SqlConnection(connectionString)
            Using adaptador As New SqlDataAdapter(sql, conexao)
                Dim tabela As New DataTable()

                Try
                    adaptador.Fill(tabela)

                    cmbClienteFiltro.DataSource = tabela
                    cmbClienteFiltro.DisplayMember = "NomeCompleto"
                    cmbClienteFiltro.ValueMember = "IdCliente"
                    cmbClienteFiltro.SelectedValue = 0
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar clientes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CarregarFormasPagamento()
        cmbFormaPagamento.Items.Clear()
        cmbFormaPagamento.Items.Add("Todas")
        cmbFormaPagamento.Items.Add("Dinheiro")
        cmbFormaPagamento.Items.Add("Pix")
        cmbFormaPagamento.Items.Add("Cartão de Débito")
        cmbFormaPagamento.Items.Add("Cartão de Crédito")
        cmbFormaPagamento.Items.Add("Boleto")
        cmbFormaPagamento.SelectedIndex = 0
    End Sub

    Private Sub CarregarStatus()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Todas")
        cmbStatus.Items.Add("Finalizada")
        cmbStatus.Items.Add("Cancelada")
        cmbStatus.Items.Add("Pendente")
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        CarregarVendas()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs)
        CarregarVendas()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub CarregarVendas()
        Dim sql As String =
            "SELECT " &
            "V.IdVenda, " &
            "V.DataVenda, " &
            "C.Nome + ' ' + C.Sobrenome AS Cliente, " &
            "V.FormaPagamento, " &
            "COUNT(VI.IdItemVenda) AS QuantidadeItens, " &
            "V.Subtotal, " &
            "V.DescontoTotal, " &
            "V.TotalFinal, " &
            "V.StatusVenda " &
            "FROM Vendas V " &
            "INNER JOIN CadastroClientes C ON C.IdCliente = V.IdCliente " &
            "LEFT JOIN VendaItens VI ON VI.IdVenda = V.IdVenda " &
            "WHERE V.DataVenda >= @DataInicial " &
            "AND V.DataVenda < @DataFinal " &
            "AND (@IdCliente = 0 OR V.IdCliente = @IdCliente) " &
            "AND (@FormaPagamento = 'Todas' OR V.FormaPagamento = @FormaPagamento) " &
            "AND (@StatusVenda = 'Todas' OR V.StatusVenda = @StatusVenda) " &
            "GROUP BY V.IdVenda, V.DataVenda, C.Nome, C.Sobrenome, V.FormaPagamento, V.Subtotal, V.DescontoTotal, V.TotalFinal, V.StatusVenda " &
            "ORDER BY V.DataVenda DESC, V.IdVenda DESC"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)
                comando.Parameters.Add("@DataInicial", SqlDbType.DateTime).Value = dtpDataInicial.Value.Date
                comando.Parameters.Add("@DataFinal", SqlDbType.DateTime).Value = dtpDataFinal.Value.Date.AddDays(1)
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Convert.ToInt32(cmbClienteFiltro.SelectedValue)
                comando.Parameters.Add("@FormaPagamento", SqlDbType.VarChar, 50).Value = cmbFormaPagamento.Text
                comando.Parameters.Add("@StatusVenda", SqlDbType.VarChar, 30).Value = cmbStatus.Text

                Using adaptador As New SqlDataAdapter(comando)
                    Dim tabela As New DataTable()

                    Try
                        adaptador.Fill(tabela)
                        dgvVendas.DataSource = tabela
                        AtualizarResumo(tabela)
                    Catch ex As Exception
                        MessageBox.Show("Erro ao carregar vendas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub AtualizarResumo(tabela As DataTable)
        Dim totalVendas As Integer = tabela.Rows.Count
        Dim vendasCanceladas As Integer = 0
        Dim valorTotal As Decimal = 0

        For Each linha As DataRow In tabela.Rows
            If linha("StatusVenda").ToString() = "Cancelada" Then
                vendasCanceladas += 1
            Else
                valorTotal += Convert.ToDecimal(linha("TotalFinal"))
            End If
        Next

        txtTotalVendas.Text = totalVendas.ToString()
        txtValorTotal.Text = valorTotal.ToString("N2", cultura)
        txtVendasCanceladas.Text = vendasCanceladas.ToString()
    End Sub

    Private Sub btnCancelarVenda_Click(sender As Object, e As EventArgs)
        If dgvVendas.CurrentRow Is Nothing Then
            MessageBox.Show("Selecione uma venda para cancelar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenda As Integer = Convert.ToInt32(dgvVendas.CurrentRow.Cells("IdVenda").Value)
        Dim statusVenda As String = dgvVendas.CurrentRow.Cells("StatusVenda").Value.ToString()

        If statusVenda = "Cancelada" Then
            MessageBox.Show("Essa venda já está cancelada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim resposta As DialogResult = MessageBox.Show("Deseja realmente cancelar esta venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.No Then
            Return
        End If

        CancelarVenda(idVenda)
    End Sub

    Private Sub CancelarVenda(idVenda As Integer)
        Using conexao As New SqlConnection(connectionString)
            conexao.Open()

            Using transacao As SqlTransaction = conexao.BeginTransaction()
                Try
                    Dim itens As DataTable = BuscarItensVenda(conexao, transacao, idVenda)

                    For Each linha As DataRow In itens.Rows
                        DevolverEstoque(conexao, transacao, Convert.ToInt32(linha("IdProduto")), Convert.ToInt32(linha("Quantidade")))
                    Next

                    AtualizarStatusVenda(conexao, transacao, idVenda)

                    transacao.Commit()

                    MessageBox.Show("Venda cancelada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CarregarVendas()
                Catch ex As Exception
                    transacao.Rollback()
                    MessageBox.Show("Erro ao cancelar venda: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Function BuscarItensVenda(conexao As SqlConnection, transacao As SqlTransaction, idVenda As Integer) As DataTable
        Dim sql As String =
            "SELECT IdProduto, Quantidade " &
            "FROM VendaItens " &
            "WHERE IdVenda = @IdVenda"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@IdVenda", SqlDbType.Int).Value = idVenda

            Using adaptador As New SqlDataAdapter(comando)
                Dim tabela As New DataTable()
                adaptador.Fill(tabela)
                Return tabela
            End Using
        End Using
    End Function

    Private Sub DevolverEstoque(conexao As SqlConnection, transacao As SqlTransaction, idProduto As Integer, quantidade As Integer)
        Dim sql As String =
            "UPDATE CadastroProdutos " &
            "SET Quantidade = Quantidade + @Quantidade " &
            "WHERE IdProduto = @IdProduto"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = quantidade
            comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = idProduto
            comando.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AtualizarStatusVenda(conexao As SqlConnection, transacao As SqlTransaction, idVenda As Integer)
        Dim sql As String =
            "UPDATE Vendas " &
            "SET StatusVenda = 'Cancelada' " &
            "WHERE IdVenda = @IdVenda " &
            "AND StatusVenda <> 'Cancelada'"

        Using comando As New SqlCommand(sql, conexao, transacao)
            comando.Parameters.Add("@IdVenda", SqlDbType.Int).Value = idVenda

            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

            If linhasAfetadas = 0 Then
                Throw New Exception("A venda não pôde ser cancelada.")
            End If
        End Using
    End Sub

End Class