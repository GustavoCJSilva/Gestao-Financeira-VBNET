Public Class Menu
    Private Sub CadastroClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroClientesToolStripMenuItem1.Click
        Dim CadastroCliente As New Cadastro_CltxtDataNascimentoientes
        CadastroCliente.Show()
    End Sub


    Private Sub CadastroProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroProdutosToolStripMenuItem1.Click
        Dim CadastroProdutos As New CadastroProdutos
        CadastroProdutos.Show()
    End Sub

    Private Sub NovaVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaVendaToolStripMenuItem.Click
        Dim Nova_venda As New Nova_Venda
        Nova_venda.Show()
    End Sub

    Private Sub HistóricoDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoDeVendasToolStripMenuItem.Click
        Dim Historico_de_Vendas As New Historico_de_Vendas
        Historico_de_Vendas.Show()
    End Sub

    Private Sub ConsultarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarClientesToolStripMenuItem.Click
        Dim Consultas_Cliente As New Consultas_Cliente
        Consultas_Cliente.Show()
    End Sub
End Class
