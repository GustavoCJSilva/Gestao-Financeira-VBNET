Imports System.Data
Imports System.Data.SqlClient

Public Class Cadastro_CltxtDataNascimentoientes

    Private ReadOnly connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"

    Private Sub Cadastro_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararTela()
    End Sub

    Private Sub btnSalvarCliente_Click(sender As Object, e As EventArgs) Handles btnSalvarCliente.Click
        If ValidarCampos() = False Then
            Return
        End If

        SalvarCliente()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub btnVerClientes_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        Dim tela As New Consultas_Cliente
        tela.Show()
    End Sub

    Private Sub PrepararTela()
        chkClienteAtivo.Checked = True
        txtDataNascimentos.Value = Date.Today
        txtNomes.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtNomes.Text.Trim() = "" Then
            MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomes.Focus()
            Return False
        End If

        If txtSobrenomes.Text.Trim() = "" Then
            MessageBox.Show("Informe o sobrenome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSobrenomes.Focus()
            Return False
        End If

        If cmbTipoCliente.Text.Trim() = "" Then
            MessageBox.Show("Informe o tipo de cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipoCliente.Focus()
            Return False
        End If

        If txtCpfCnpjs.Text.Trim() = "" Then
            MessageBox.Show("Informe o CPF/CNPJ do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCpfCnpjs.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub SalvarCliente()
        Dim sql As String =
            "INSERT INTO CadastroClientes " &
            "(Nome, Sobrenome, DataNascimento, TipoCliente, CpfCnpj, ClienteAtivo, Telefone, Whatsapp, Email, Cep, Estado, Cidade, Bairro, Rua, Numero, Complemento, Observacoes) " &
            "VALUES " &
            "(@Nome, @Sobrenome, @DataNascimento, @TipoCliente, @CpfCnpj, @ClienteAtivo, @Telefone, @Whatsapp, @Email, @Cep, @Estado, @Cidade, @Bairro, @Rua, @Numero, @Complemento, @Observacoes)"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@Nome", SqlDbType.VarChar, 100).Value = txtNomes.Text.Trim()
                comando.Parameters.Add("@Sobrenome", SqlDbType.VarChar, 100).Value = txtSobrenomes.Text.Trim()
                comando.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = txtDataNascimentos.Value.Date
                comando.Parameters.Add("@TipoCliente", SqlDbType.VarChar, 30).Value = cmbTipoCliente.Text.Trim()
                comando.Parameters.Add("@CpfCnpj", SqlDbType.VarChar, 20).Value = txtCpfCnpjs.Text.Trim()
                comando.Parameters.Add("@ClienteAtivo", SqlDbType.Bit).Value = chkClienteAtivo.Checked
                comando.Parameters.Add("@Telefone", SqlDbType.VarChar, 20).Value = TextoOuNulo(txtTelefone.Text)
                comando.Parameters.Add("@Whatsapp", SqlDbType.VarChar, 20).Value = TextoOuNulo(txtWhatsapp.Text)
                comando.Parameters.Add("@Email", SqlDbType.VarChar, 150).Value = TextoOuNulo(txtEmail.Text)
                comando.Parameters.Add("@Cep", SqlDbType.VarChar, 15).Value = TextoOuNulo(txtCep.Text)
                comando.Parameters.Add("@Estado", SqlDbType.VarChar, 2).Value = TextoOuNulo(cmbEstado.Text)
                comando.Parameters.Add("@Cidade", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtCidades.Text)
                comando.Parameters.Add("@Bairro", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtBairro.Text)
                comando.Parameters.Add("@Rua", SqlDbType.VarChar, 150).Value = TextoOuNulo(txtRua.Text)
                comando.Parameters.Add("@Numero", SqlDbType.VarChar, 20).Value = TextoOuNulo(txtNumero.Text)
                comando.Parameters.Add("@Complemento", SqlDbType.VarChar, 150).Value = TextoOuNulo(txtComplemento.Text)
                comando.Parameters.Add("@Observacoes", SqlDbType.VarChar, 500).Value = TextoOuNulo(txtObservacoes.Text)

                Try
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimparCampos()
                Catch ex As Exception
                    MessageBox.Show("Erro ao cadastrar cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

    Private Function TextoOuNulo(valor As String) As Object
        If String.IsNullOrWhiteSpace(valor) Then
            Return DBNull.Value
        End If

        Return valor.Trim()
    End Function

    Private Sub LimparCampos()
        txtNomes.Clear()
        txtSobrenomes.Clear()
        cmbTipoCliente.Clear()
        txtCpfCnpjs.Clear()
        txtTelefone.Clear()
        txtWhatsapp.Clear()
        txtEmail.Clear()
        txtCep.Clear()
        cmbEstado.Clear()
        txtCidades.Clear()
        txtBairro.Clear()
        txtRua.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtObservacoes.Clear()

        chkClienteAtivo.Checked = True
        txtDataNascimentos.Value = Date.Today

        txtNomes.Focus()
    End Sub

    Private Sub VoltarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarMenuToolStripMenuItem.Click
        Close()
    End Sub
End Class