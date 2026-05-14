Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports LinqToDB.Data

Public Class Cadastro_CltxtDataNascimentoientes
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As Object
    Private myReader As SqlDataReader
    Private results As String
    Private objBanco As Object
    Private dgvDados As Object
    Private Cmd As SqlCommand
    Private conexao As Object
    Private comando As Object

    Private Sub VoltarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarMenuToolStripMenuItem.Click
        Dim Voltar As New Menu
        Close()

    End Sub

    Private Sub txtNome(sender As Object, e As EventArgs) Handles txtNomes.TextChanged

    End Sub

    Private Sub txtSobrenome(sender As Object, e As EventArgs) Handles txtSobrenomes.TextChanged

    End Sub

    Private Sub txtEstado(sender As Object, e As EventArgs) Handles txtEstados.TextChanged

    End Sub

    Private Sub txtCidade(sender As Object, e As EventArgs) Handles txtCidades.TextChanged

    End Sub

    Private Sub lstClientes(sender As Object, e As EventArgs) Handles lstCliente.SelectedIndexChanged

    End Sub

    Private Sub btnAdicionarCliente(sender As Object, e As EventArgs) Handles Button1.Click
        'Declarando Variaveis e aplicando'
        Dim nome As String = txtNomes.Text
        Dim sobrenome As String = txtSobrenomes.Text
        Dim dataNascimento As String = txtDataNascimentos.Text
        Dim cpfCnpj As String = txtCpfCnpjs.Text
        Dim estado As String = txtEstados.Text
        Dim cidade As String = txtCidades.Text
        Dim Contato As String = txtcontato.Text

        Dim cliente As String = nome & "" & sobrenome & " | " &
            "Data de Nascimento: " & dataNascimento & " | " &
                            "CPF/CNPJ: " & cpfCnpj & " | " &
                            "Estado: " & estado & " | " &
                            "Cidade: " & cidade & " | " &
                            "Contato:" & Contato

        lstCliente.Items.Add(cliente)

        If String.IsNullOrEmpty(nome) Or
            String.IsNullOrEmpty(sobrenome) Or
            String.IsNullOrEmpty(dataNascimento) Or
            String.IsNullOrEmpty(cpfCnpj) Or
            String.IsNullOrEmpty(estado) Or
            String.IsNullOrEmpty(cidade) Or
            String.IsNullOrEmpty(Contato) Then

            MessageBox.Show("Favor Preencher Todos os Dados")
            Return
        End If

        Dim connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"
        Dim sql As String = "INSERT INTO CadastroClientes (Nome, Sobrenome, Datanascimento, Cpf, Estado, Cidade, Contato) VALUES (@Nome, @Sobrenome, @Datanascimento, @Cpf, @Estado, @Cidade, @Contato)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@Sobrenome", sobrenome)
                command.Parameters.AddWithValue("@Datanascimento", dataNascimento)
                command.Parameters.AddWithValue("@Cpf", cpfCnpj)
                command.Parameters.AddWithValue("@Estado", estado)
                command.Parameters.AddWithValue("@Cidade", cidade)
                command.Parameters.AddWithValue("@Contato", Contato)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    MessageBox.Show("Cliente Cadastrado com Sucesso!")
                Catch ex As Exception
                    MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub txtCpfCnpj(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCpfCnpjs.MaskInputRejected

    End Sub



    Private Sub txtcontatos(sender As Object, e As MaskInputRejectedEventArgs) Handles txtcontato.MaskInputRejected

    End Sub

    Private Sub txtDataNascimento(sender As Object, e As EventArgs) Handles txtDataNascimentos.ValueChanged

    End Sub

    Private Sub Cadastros_Click(sender As Object, e As EventArgs) Handles Cadastros.Click

        lstCliente.Visible = True
        CarregarClientes()
    End Sub

    Private Sub Atualizar_Click(sender As Object, e As EventArgs) Handles Atualizar.Click
        CarregarClientes()
    End Sub

    Private Sub CarregarClientes()
        lstCliente.Items.Clear()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"
        Dim sql As String = "SELECT Nome, Sobrenome, Datanascimento, Cpf, Estado, Cidade, Contato FROM CadastroClientes"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Using Reader As SqlDataReader = command.ExecuteReader()
                        While Reader.Read()
                            Dim cliente As String =
                                Reader("Nome").ToString() & " " &
                                Reader("Sobrenome").ToString() & " | " &
                                "Data de Nascimento: " & Reader("Datanascimento").ToString() & " | " &
                                "CPF/CNPJ: " & Reader("Cpf").ToString() & " | " &
                                "Estado: " & Reader("Estado").ToString() & " | " &
                                "Cidade: " & Reader("Cidade").ToString() & " | " &
                                "Contato: " & Reader("Contato").ToString()
                            lstCliente.Items.Add(cliente)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar clientes: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class