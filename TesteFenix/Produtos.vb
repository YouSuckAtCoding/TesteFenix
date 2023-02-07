Imports DataLibrary
Imports ModelLibrary

Public Class Produtos
    Inherits System.Windows.Forms.Form
    Dim _produtoRepository As New ProdutoRepository
    Dim _categoriaRepository As New CategoriaRepository
    Dim ds As New DataSet

    Private Sub Create_Hover(sender As Object, e As EventArgs) Handles CreateBtn.MouseHover
        Dim b = DirectCast(CreateBtn, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub
    Private Sub Remover_Hover(sender As Object, e As EventArgs) Handles RemoverBtn.MouseHover
        Dim b = DirectCast(RemoverBtn, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub
    Private Sub Editar_Hover(sender As Object, e As EventArgs) Handles EditarBtn.MouseHover
        Dim b = DirectCast(EditarBtn, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ds = _produtoRepository.GetAllProdutos()
        DataGridView1.DataSource = ds.Tables(0)

        Dim Categorias As New List(Of Categoria)
        Categorias = _categoriaRepository.GetAllCategorias()
        If Categorias.Count > 0 Then
            For Each categoria In Categorias
                CategoriaList.Items.Add(categoria.Name)

            Next
            IdCategoriaTextBox.Text = Categorias(0).Id
        End If




    End Sub


    Private Sub CategoriaList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriaList.SelectedIndexChanged
        If CategoriaList.SelectedItem.ToString.Length <= 0 Then
            MessageBox.Show("Escolha inválida, por favor escolha um valor")
            Exit Sub
        End If
        Dim selected As New Categoria
        selected = _categoriaRepository.GetCategoriaByName(CategoriaList.SelectedItem.ToString())
        IdCategoriaTextBox.Text = selected.Id
        ds = _produtoRepository.GetProdutosByCategoria(selected.Id)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        InserirProduto.Show()
        Me.Close()
    End Sub

    Private Sub RemoverBtn_Click(sender As Object, e As EventArgs) Handles RemoverBtn.Click
        Dim x As Integer
        If DataGridView1.CurrentRow.Cells(0).Value.GetType() Is GetType(Integer) Then
            x = DataGridView1.CurrentRow.Cells(0).Value
        End If
        If x <= 0 Then
            MessageBox.Show("Por favor selecione um produto")
            Exit Sub
        End If


        Dim res As Boolean = _produtoRepository.DeleteProduto(x)

        If res = True Then
            MessageBox.Show("Produto removido com sucesso")
        Else
            MessageBox.Show("Não foi possível remover o produto selecionado")
        End If

        ClearBoxes()
        Produtos_Load(sender, e)

    End Sub

    Private Sub ClearBoxes()
        CategoriaList.Items.Clear()
        IdCategoriaTextBox.Text = ""
        NovaCategoriaTextBox.Text = ""

    End Sub

    Private Sub InserirCategoriaBtn_Click(sender As Object, e As EventArgs) Handles InserirCategoriaBtn.Click
        If NovaCategoriaTextBox.Text.Length <= 0 Then
            MessageBox.Show("Favor inserir um nome para a nova categoria")
            Exit Sub
        Else
            Dim newCat As New Categoria
            newCat.Name = NovaCategoriaTextBox.Text
            _categoriaRepository.CreateCategoria(newCat)

        End If

        ClearBoxes()
        Produtos_Load(sender, e)
    End Sub

    Private Sub EditarBtn_Click(sender As Object, e As EventArgs) Handles EditarBtn.Click
        Dim x As Integer
        If DataGridView1.CurrentRow.Cells(0).Value.GetType() Is GetType(Integer) Then
            x = DataGridView1.CurrentRow.Cells(0).Value
        End If
        If x <= 0 Then
            MessageBox.Show("Por favor selecione um produto")
            Exit Sub
        End If
        Dim form As New Form
        form = EditarProduto
        EditarProduto.SelectedId = x
        EditarProduto.Show()
        Me.Close()
    End Sub

    Private Sub RemoverCategoriaBtn_Click(sender As Object, e As EventArgs) Handles RemoverCategoriaBtn.Click
        Dim x As Integer
        x = IdCategoriaTextBox.Text


        Dim res As Boolean = _categoriaRepository.DeleteCategoria(x)

        If res = True Then
            MessageBox.Show("Categoria removida com sucesso")
        Else
            MessageBox.Show("Não foi possível remover a categora selecionado")
        End If

        ClearBoxes()
        Produtos_Load(sender, e)

    End Sub
End Class