Imports System.Data
Imports System.Data.SqlClient

Public Class Consultas_Cliente

    Private ReadOnly connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"

    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, AddressOf Consultas_Cliente_Load
        AddHandler btnBuscar.Click, AddressOf btnBuscar_Click
        AddHandler btnLimparFiltro.Click, AddressOf btnLimparFiltro_Click
        AddHandler btnVerDetalhes.Click, AddressOf btnVerDetalhes_Click
        AddHandler btnEditar.Click, AddressOf btnEditar_Click
        AddHandler btnExcluir.Click, AddressOf btnExcluir_Click
        AddHandler btnAtualizar.Click, AddressOf btnAtualizar_Click
    End Sub

    Private Sub Consultas_Cliente_Load(sender As Object, e As EventArgs)
        PrepararTela()
        ConfigurarGrid()
        CarregarStatus()
        CarregarClientes()
    End Sub

    Private Sub PrepararTela()
        txtTotalClientes.ReadOnly = True
        txtClientesAtivos.ReadOnly = True
        txtClientesInativos.ReadOnly = True
    End Sub

    Private Sub ConfigurarGrid()
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.Columns.Clear()

        dgvClientes.Columns.Add(CriarColunaTexto("IdCliente", "IdCliente", "Código", 70))
        dgvClientes.Columns.Add(CriarColunaTexto("Nome", "Nome", "Nome", 120))
        dgvClientes.Columns.Add(CriarColunaTexto("Sobrenome", "Sobrenome", "Sobrenome", 120))
        dgvClientes.Columns.Add(CriarColunaTexto("CpfCnpj", "CpfCnpj", "CPF/CNPJ", 130))
        dgvClientes.Columns.Add(CriarColunaTexto("Telefone", "Telefone", "Telefone", 120))
        dgvClientes.Columns.Add(CriarColunaTexto("Whatsapp", "Whatsapp", "Whatsapp", 120))
        dgvClientes.Columns.Add(CriarColunaTexto("Email", "Email", "E-mail", 180))
        dgvClientes.Columns.Add(CriarColunaTexto("Cidade", "Cidade", "Cidade", 120))
        dgvClientes.Columns.Add(CriarColunaTexto("Estado", "Estado", "Estado", 70))
        dgvClientes.Columns.Add(CriarColunaTexto("StatusCliente", "StatusCliente", "Status", 90))

        dgvClientes.ReadOnly = True
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.AllowUserToDeleteRows = False
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.MultiSelect = False
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClientes.RowHeadersVisible = False
        dgvClientes.BackgroundColor = Color.White
    End Sub

    Private Function CriarColunaTexto(nome As String, propriedade As String, titulo As String, largura As Integer) As DataGridViewTextBoxColumn
        Dim coluna As New DataGridViewTextBoxColumn()

        coluna.Name = nome
        coluna.DataPropertyName = propriedade
        coluna.HeaderText = titulo
        coluna.Width = largura

        Return coluna
    End Function

    Private Sub CarregarStatus()
        cmbStatusFiltro.Items.Clear()
        cmbStatusFiltro.Items.Add("Todos")
        cmbStatusFiltro.Items.Add("Ativo")
        cmbStatusFiltro.Items.Add("Inativo")
        cmbStatusFiltro.SelectedIndex = 0
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        CarregarClientes()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs)
        CarregarClientes()
    End Sub

    Private Sub btnLimparFiltro_Click(sender As Object, e As EventArgs)
        txtNomeFiltro.Clear()
        txtCpfCnpjFiltro.Clear()
        txtCidadeFiltro.Clear()
        cmbStatusFiltro.SelectedIndex = 0
        CarregarClientes()
    End Sub

    Private Sub CarregarClientes()
        Dim sql As String =
            "SELECT " &
            "IdCliente, " &
            "Nome, " &
            "Sobrenome, " &
            "CpfCnpj, " &
            "Telefone, " &
            "Whatsapp, " &
            "Email, " &
            "Cidade, " &
            "Estado, " &
            "ClienteAtivo, " &
            "CASE WHEN ClienteAtivo = 1 THEN 'Ativo' ELSE 'Inativo' END AS StatusCliente " &
            "FROM CadastroClientes " &
            "WHERE (@Nome = '' OR Nome LIKE '%' + @Nome + '%' OR Sobrenome LIKE '%' + @Nome + '%') " &
            "AND (@CpfCnpj = '' OR CpfCnpj LIKE '%' + @CpfCnpj + '%') " &
            "AND (@Cidade = '' OR Cidade LIKE '%' + @Cidade + '%') " &
            "AND (@Status = 'Todos' OR (@Status = 'Ativo' AND ClienteAtivo = 1) OR (@Status = 'Inativo' AND ClienteAtivo = 0)) " &
            "ORDER BY Nome, Sobrenome"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@Nome", SqlDbType.VarChar, 100).Value = txtNomeFiltro.Text.Trim()
                comando.Parameters.Add("@CpfCnpj", SqlDbType.VarChar, 20).Value = txtCpfCnpjFiltro.Text.Trim()
                comando.Parameters.Add("@Cidade", SqlDbType.VarChar, 100).Value = txtCidadeFiltro.Text.Trim()
                comando.Parameters.Add("@Status", SqlDbType.VarChar, 20).Value = cmbStatusFiltro.Text

                Using adaptador As New SqlDataAdapter(comando)
                    Dim tabela As New DataTable()

                    Try
                        adaptador.Fill(tabela)
                        dgvClientes.DataSource = tabela
                        AtualizarResumo(tabela)
                    Catch ex As Exception
                        MessageBox.Show("Erro ao carregar clientes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using

            End Using
        End Using
    End Sub

    Private Sub AtualizarResumo(tabela As DataTable)
        Dim totalClientes As Integer = tabela.Rows.Count
        Dim clientesAtivos As Integer = 0
        Dim clientesInativos As Integer = 0

        For Each linha As DataRow In tabela.Rows
            If Convert.ToBoolean(linha("ClienteAtivo")) Then
                clientesAtivos += 1
            Else
                clientesInativos += 1
            End If
        Next

        txtTotalClientes.Text = totalClientes.ToString()
        txtClientesAtivos.Text = clientesAtivos.ToString()
        txtClientesInativos.Text = clientesInativos.ToString()
    End Sub

    Private Sub btnVerDetalhes_Click(sender As Object, e As EventArgs)
        If dgvClientes.CurrentRow Is Nothing Then
            MessageBox.Show("Selecione um cliente para ver os detalhes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idCliente As Integer = Convert.ToInt32(dgvClientes.CurrentRow.Cells("IdCliente").Value)

        MostrarDetalhesCliente(idCliente)
    End Sub

    Private Sub MostrarDetalhesCliente(idCliente As Integer)
        Dim sql As String =
            "SELECT * FROM CadastroClientes WHERE IdCliente = @IdCliente"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente

                Try
                    conexao.Open()

                    Using reader As SqlDataReader = comando.ExecuteReader()
                        If reader.Read() = False Then
                            MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If

                        Dim detalhes As String =
                            "Código: " & reader("IdCliente").ToString() & Environment.NewLine &
                            "Nome: " & reader("Nome").ToString() & " " & reader("Sobrenome").ToString() & Environment.NewLine &
                            "Data de Nascimento: " & FormatarData(reader("DataNascimento")) & Environment.NewLine &
                            "Tipo de Cliente: " & reader("TipoCliente").ToString() & Environment.NewLine &
                            "CPF/CNPJ: " & reader("CpfCnpj").ToString() & Environment.NewLine &
                            "Status: " & If(Convert.ToBoolean(reader("ClienteAtivo")), "Ativo", "Inativo") & Environment.NewLine &
                            Environment.NewLine &
                            "Telefone: " & reader("Telefone").ToString() & Environment.NewLine &
                            "Whatsapp: " & reader("Whatsapp").ToString() & Environment.NewLine &
                            "E-mail: " & reader("Email").ToString() & Environment.NewLine &
                            Environment.NewLine &
                            "CEP: " & reader("Cep").ToString() & Environment.NewLine &
                            "Estado: " & reader("Estado").ToString() & Environment.NewLine &
                            "Cidade: " & reader("Cidade").ToString() & Environment.NewLine &
                            "Bairro: " & reader("Bairro").ToString() & Environment.NewLine &
                            "Rua: " & reader("Rua").ToString() & Environment.NewLine &
                            "Número: " & reader("Numero").ToString() & Environment.NewLine &
                            "Complemento: " & reader("Complemento").ToString() & Environment.NewLine &
                            Environment.NewLine &
                            "Observações: " & reader("Observacoes").ToString()

                        MessageBox.Show(detalhes, "Detalhes do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Erro ao buscar detalhes do cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

    Private Function FormatarData(valor As Object) As String
        If valor Is DBNull.Value Then
            Return ""
        End If

        Return Convert.ToDateTime(valor).ToString("dd/MM/yyyy")
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        If dgvClientes.CurrentRow Is Nothing Then
            MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("A edição será feita no próximo passo. Primeiro garantimos a consulta funcionando.", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs)
        If dgvClientes.CurrentRow Is Nothing Then
            MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idCliente As Integer = Convert.ToInt32(dgvClientes.CurrentRow.Cells("IdCliente").Value)
        Dim nomeCliente As String = dgvClientes.CurrentRow.Cells("Nome").Value.ToString()

        Dim resposta As DialogResult = MessageBox.Show("Deseja realmente excluir o cliente " & nomeCliente & "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.No Then
            Return
        End If

        ExcluirCliente(idCliente)
    End Sub

    Private Sub ExcluirCliente(idCliente As Integer)
        Dim sql As String =
            "DELETE FROM CadastroClientes WHERE IdCliente = @IdCliente"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente

                Try
                    conexao.Open()

                    Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

                    If linhasAfetadas > 0 Then
                        MessageBox.Show("Cliente excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CarregarClientes()
                    Else
                        MessageBox.Show("Nenhum cliente foi excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Erro ao excluir cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Close()

    End Sub
End Class