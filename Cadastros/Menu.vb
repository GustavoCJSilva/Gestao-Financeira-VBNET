Public Class Menu
    Private Sub CadastroClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroClientesToolStripMenuItem1.Click
        Dim CadastroCliente As New Cadastro_CltxtDataNascimentoientes
        CadastroCliente.Show()
    End Sub


    Private Sub CadastroProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroProdutosToolStripMenuItem1.Click
        Dim CadastroProdutos As New CadastroProdutos
        CadastroProdutos.Show()
    End Sub
End Class
