Imports DataLibrary
Imports ModelLibrary

Public Class EditarProduto
    Dim _repository As New ProdutoRepository
    Dim imageName As String
    Public Shared SelectedId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub EditarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prod As New Produto
        prod = _repository.GetProdutoById(SelectedId)
        If prod IsNot Nothing Then

            NameTextBox.Text = prod.Name
            DescricaoTextBox.Text = prod.Description
            CategoriaTextBox.Text = prod.Category
            PrecoTextBox.Text = prod.Price
            MarcaTextBox.Text = prod.Brand
            Try
                Dim FileName As String
                FileName = GetImagePath() & prod.Image
                ImageBox.Image = Image.FromFile(FileName)
                ImageBox.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                ImageBox.Image = Nothing
            End Try

        End If
    End Sub
    Private Function GetImagePath() As String
        Dim pathToSaveTo As String
        pathToSaveTo = Application.StartupPath()
        Dim trimmedPath As String() = pathToSaveTo.Split(New Char() {"bin\Debug\net6.0-windows\"})
        Dim correctPath As String = trimmedPath(0) & "Images\"
        Return correctPath
    End Function
    Private Sub EscolherImagem_Click(sender As Object, e As EventArgs) Handles EscolherImagem.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImageBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            imageName = OpenFileDialog1.SafeFileName.ToString()
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub EditarProdutoBtn_Click(sender As Object, e As EventArgs) Handles EditarProdutoBtn.Click
        Dim newProduto As New Produto()
        newProduto.Id = SelectedId
        newProduto.Name = NameTextBox.Text
        newProduto.PublishDate = DateTime.Now
        newProduto.Description = DescricaoTextBox.Text
        newProduto.Category = CategoriaTextBox.Text
        newProduto.Price = Decimal.Parse(PrecoTextBox.Text)
        newProduto.Brand = MarcaTextBox.Text
        If imageName Is Nothing Then
            Dim prod As New Produto
            prod = _repository.GetProdutoById(SelectedId)
            newProduto.Image = prod.Image
        Else
            newProduto.Image = imageName
        End If

        If ValidateInstrumento(newProduto) = True Then
            Dim res As Boolean = _repository.UpdateProduto(SelectedId, newProduto)
            SaveImage()
            CheckResult(res)
        End If

        Produtos.Show()
        Me.Close()

    End Sub

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

    Private Sub EditarProdutoBtn_Hover(sender As Object, e As EventArgs) Handles EditarProdutoBtn.MouseHover
        Dim b = DirectCast(EditarProdutoBtn, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub

    Private Sub EscolherImagem_Hover(sender As Object, e As EventArgs) Handles EscolherImagem.MouseHover
        Dim b = DirectCast(EscolherImagem, Button)
        b.FlatAppearance.MouseOverBackColor = Color.DarkBlue
    End Sub


End Class