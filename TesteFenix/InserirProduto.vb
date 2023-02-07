Imports System.IO
Imports DataLibrary
Imports ModelLibrary

Public Class InserirProduto
    Dim _repository As New ProdutoRepository
    Dim imageName As String
    Dim _categoriaRepository As New CategoriaRepository
    Dim list As New List(Of Categoria)
    Private Sub InserirProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        list = _categoriaRepository.GetAllCategorias()
        For Each categoria In list
            CategoriaCmb.Items.Add(categoria.Name)
        Next
    End Sub

    Private Sub EscolherImagem_Click(sender As Object, e As EventArgs) Handles EscolherImagem.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImageBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            imageName = OpenFileDialog1.SafeFileName.ToString()
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub CriarProdutoBtn_Click(sender As Object, e As EventArgs) Handles CriarProdutoBtn.Click
        Dim newProduto As New Produto()

        newProduto.Name = NameTextBox.Text
        newProduto.PublishDate = DateTime.Now
        newProduto.Description = DescricaoTextBox.Text
        newProduto.Category = CheckCategoria(CategoriaCmb.SelectedItem.ToString())
        newProduto.Price = Decimal.Parse(PrecoTextBox.Text)
        newProduto.Brand = MarcaTextBox.Text
        newProduto.Image = imageName

        If ValidateInstrumento(newProduto) = True Then
            Dim res As Boolean = _repository.CreateProduto(newProduto)
            SaveImage()
            CheckResult(res)
        End If

        Produtos.Show()
        Me.Close()

    End Sub

    Private Function CheckCategoria(selectedValue As String) As Integer
        For Each categoria In list
            If categoria.Name = selectedValue Then
                Return categoria.Id
            End If
        Next
        Return 0
    End Function

    Private Sub SaveImage()
        Dim pathToSaveTo As String
        pathToSaveTo = Application.StartupPath()
        Dim trimmedPath As String() = pathToSaveTo.Split(New Char() {"bin\Debug\net6.0-windows\"})
        Dim correctPath As String = trimmedPath(0) & "Images\"

        Try
            ImageBox.Image.Save(correctPath & imageName, Drawing.Imaging.ImageFormat.Jpeg)

        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & vbCrLf &
                            ex.Message, "Error Saving Image File",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub CheckResult(ByVal res As Boolean)
        If res = True Then
            MessageBox.Show("Inserido com Sucesso.")
        Else
            MessageBox.Show("Problema ao inserir produto.")
        End If
    End Sub

    Private Function ValidateInstrumento(ByVal inst As Produto) As Boolean

        If inst.Name.Length <= 0 Then
            Return False
        End If

        If inst.Description.Length <= 0 Then
            Return False
        End If

        If inst.Category <= 0 Then
            Return False
        End If

        If inst.Brand.Length <= 0 Then
            Return False
        End If

        If inst.Price <= 0 Then
            Return False
        End If

        If inst.Image.Length <= 0 Then
            Return False
        End If

        Return True
    End Function

    Private Sub CriarProdutoBtn_Hover(sender As Object, e As EventArgs) Handles CriarProdutoBtn.MouseHover
        Dim b = DirectCast(CriarProdutoBtn, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub

    Private Sub EscolherImagem_Hover(sender As Object, e As EventArgs) Handles EscolherImagem.MouseHover
        Dim b = DirectCast(EscolherImagem, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub


End Class