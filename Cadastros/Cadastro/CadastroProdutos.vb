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
    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click 'Fecha o Formulário para Voltar à Tela Anterior'
        Close()
    End Sub
    Private Sub quantidade_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class