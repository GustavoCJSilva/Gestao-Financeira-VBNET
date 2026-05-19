Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class CadastroProdutos

    Private ReadOnly connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"

    Private Sub CadastroProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararTela()
    End Sub

    Private Sub btnSalvarProduto_Click(sender As Object, e As EventArgs)
        If ValidarCampos() = False Then
            Return
        End If

        SalvarProduto()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub btnVerProdutos_Click(sender As Object, e As EventArgs) Handles btnVerProdutos.Click
        MessageBox.Show("A tela de consulta de produtos ainda não foi criada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrepararTela()
        chkProdutoAtivo.Checked = True
        txtNomeProduto.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtNomeProduto.Text.Trim() = "" Then
            MessageBox.Show("Informe o nome do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomeProduto.Focus()
            Return False
        End If

        If txtCodigoSku.Text.Trim() = "" Then
            MessageBox.Show("Informe o código/SKU do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigoSku.Focus()
            Return False
        End If

        If txtCategoria.Text.Trim() = "" Then
            MessageBox.Show("Informe a categoria do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategoria.Focus()
            Return False
        End If

        If txtQuantidade.Text.Trim() = "" Then
            MessageBox.Show("Informe a quantidade do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantidade.Focus()
            Return False
        End If

        If Integer.TryParse(txtQuantidade.Text.Trim(), Nothing) = False Then
            MessageBox.Show("A quantidade deve ser um número inteiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantidade.Focus()
            Return False
        End If

        If txtPrecoVenda.Text.Trim() = "" Then
            MessageBox.Show("Informe o preço de venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecoVenda.Focus()
            Return False
        End If

        If DecimalValido(txtPrecoVenda.Text) = False Then
            MessageBox.Show("O preço de venda deve ser um valor válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecoVenda.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub SalvarProduto()
        Dim sql As String =
            "INSERT INTO CadastroProdutos " &
            "(NomeProduto, CodigoSku, CodigoBarras, Categoria, Marca, Modelo, Quantidade, EstoqueMinimo, UnidadeMedida, Localizacao, ProdutoAtivo, PrecoCusto, PrecoVenda, Frete, DescontoMaximo, MargemLucro, Peso, Altura, Largura, Comprimento, Tamanho, Cor, Material, Voltagem, Componentes, Descricao) " &
            "VALUES " &
            "(@NomeProduto, @CodigoSku, @CodigoBarras, @Categoria, @Marca, @Modelo, @Quantidade, @EstoqueMinimo, @UnidadeMedida, @Localizacao, @ProdutoAtivo, @PrecoCusto, @PrecoVenda, @Frete, @DescontoMaximo, @MargemLucro, @Peso, @Altura, @Largura, @Comprimento, @Tamanho, @Cor, @Material, @Voltagem, @Componentes, @Descricao)"

        Using conexao As New SqlConnection(connectionString)
            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@NomeProduto", SqlDbType.VarChar, 150).Value = txtNomeProduto.Text.Trim()
                comando.Parameters.Add("@CodigoSku", SqlDbType.VarChar, 50).Value = txtCodigoSku.Text.Trim()
                comando.Parameters.Add("@CodigoBarras", SqlDbType.VarChar, 50).Value = TextoOuNulo(txtCodigoBarras.Text)
                comando.Parameters.Add("@Categoria", SqlDbType.VarChar, 100).Value = txtCategoria.Text.Trim()
                comando.Parameters.Add("@Marca", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtMarca.Text)
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtModelo.Text)
                comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = Convert.ToInt32(txtQuantidade.Text.Trim())
                comando.Parameters.Add("@EstoqueMinimo", SqlDbType.Int).Value = InteiroOuNulo(txtEstoqueMinimo.Text)
                comando.Parameters.Add("@UnidadeMedida", SqlDbType.VarChar, 30).Value = TextoOuNulo(txtUnidadeMedida.Text)
                comando.Parameters.Add("@Localizacao", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtLocalizacao.Text)
                comando.Parameters.Add("@ProdutoAtivo", SqlDbType.Bit).Value = chkProdutoAtivo.Checked
                comando.Parameters.Add("@PrecoCusto", SqlDbType.Decimal).Value = DecimalOuNulo(txtPrecoCusto.Text)
                comando.Parameters.Add("@PrecoVenda", SqlDbType.Decimal).Value = ConverterDecimal(txtPrecoVenda.Text)
                comando.Parameters.Add("@Frete", SqlDbType.Decimal).Value = DecimalOuNulo(txtFrete.Text)
                comando.Parameters.Add("@DescontoMaximo", SqlDbType.Decimal).Value = DecimalOuNulo(txtDescontoMaximo.Text)
                comando.Parameters.Add("@MargemLucro", SqlDbType.Decimal).Value = DecimalOuNulo(txtMargemLucro.Text)
                comando.Parameters.Add("@Peso", SqlDbType.Decimal).Value = DecimalOuNulo(txtPeso.Text)
                comando.Parameters.Add("@Altura", SqlDbType.Decimal).Value = DecimalOuNulo(txtAltura.Text)
                comando.Parameters.Add("@Largura", SqlDbType.Decimal).Value = DecimalOuNulo(txtLargura.Text)
                comando.Parameters.Add("@Comprimento", SqlDbType.Decimal).Value = DecimalOuNulo(txtComprimento.Text)
                comando.Parameters.Add("@Tamanho", SqlDbType.VarChar, 50).Value = TextoOuNulo(txtTamanho.Text)
                comando.Parameters.Add("@Cor", SqlDbType.VarChar, 50).Value = TextoOuNulo(txtCor.Text)
                comando.Parameters.Add("@Material", SqlDbType.VarChar, 100).Value = TextoOuNulo(txtMaterial.Text)
                comando.Parameters.Add("@Voltagem", SqlDbType.VarChar, 50).Value = TextoOuNulo(txtVoltagem.Text)
                comando.Parameters.Add("@Componentes", SqlDbType.VarChar, 300).Value = TextoOuNulo(txtComponentes.Text)
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar, 1000).Value = TextoOuNulo(txtDescricao.Text)

                Try
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimparCampos()
                Catch ex As Exception
                    MessageBox.Show("Erro ao cadastrar produto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Function InteiroOuNulo(valor As String) As Object
        If String.IsNullOrWhiteSpace(valor) Then
            Return DBNull.Value
        End If

        Dim numero As Integer

        If Integer.TryParse(valor.Trim(), numero) Then
            Return numero
        End If

        Return DBNull.Value
    End Function

    Private Function DecimalOuNulo(valor As String) As Object
        If String.IsNullOrWhiteSpace(valor) Then
            Return DBNull.Value
        End If

        Return ConverterDecimal(valor)
    End Function

    Private Function DecimalValido(valor As String) As Boolean
        Dim numero As Decimal
        Return Decimal.TryParse(valor.Replace(".", ","), NumberStyles.Number, New CultureInfo("pt-BR"), numero)
    End Function

    Private Function ConverterDecimal(valor As String) As Decimal
        Dim numero As Decimal
        Decimal.TryParse(valor.Replace(".", ","), NumberStyles.Number, New CultureInfo("pt-BR"), numero)
        Return numero
    End Function

    Private Sub LimparCampos()
        txtNomeProduto.Clear()
        txtCodigoSku.Clear()
        txtCodigoBarras.Clear()
        txtCategoria.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtQuantidade.Clear()
        txtEstoqueMinimo.Clear()
        txtUnidadeMedida.Clear()
        txtLocalizacao.Clear()
        txtPrecoCusto.Clear()
        txtPrecoVenda.Clear()
        txtFrete.Clear()
        txtDescontoMaximo.Clear()
        txtMargemLucro.Clear()
        txtPeso.Clear()
        txtAltura.Clear()
        txtLargura.Clear()
        txtComprimento.Clear()
        txtTamanho.Clear()
        txtCor.Clear()
        txtMaterial.Clear()
        txtVoltagem.Clear()
        txtComponentes.Clear()
        txtDescricao.Clear()

        chkProdutoAtivo.Checked = True

        txtNomeProduto.Focus()
    End Sub

End Class