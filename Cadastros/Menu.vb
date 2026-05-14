Public Class Menu

    Private Sub CadastroClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroClientesToolStripMenuItem.Click
        Dim F As New Cadastro_CltxtDataNascimentoientes
        F.Show()
    End Sub

    Private Sub CadastroProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroProdutosToolStripMenuItem.Click
        Dim CadProd As New CadastroProdutos
        CadProd.Show()
    End Sub
End Class
