Imports System
Imports DataLibrary
Imports ModelLibrary
Imports Xunit

Namespace TesteFenixTests
    Public Class DatabaseTests
        <Fact>
        Sub TestGetAll_ShouldWork()
            Dim Repo As ProdutoRepository = New ProdutoRepository()
            Assert.NotEmpty(Repo.GetAllProdutos())

        End Sub
        <Fact>
        Sub TestGetById_ShouldWork()
            Dim Repo As ProdutoRepository = New ProdutoRepository()
            Assert.NotNull(Repo.GetProdutoById(1))

        End Sub

        <Fact>
        Sub TestCreate_ShouldWork()
            Dim Repo As ProdutoRepository = New ProdutoRepository()
            Dim newProd As Produto = New Produto()
            newProd.Name = "Teste2"
            newProd.PublishDate = DateTime.Now
            newProd.Description = "Novo instrumento teste"
            newProd.Category = "Bateria"
            newProd.Image = "Image.png"
            newProd.Price = 3000
            newProd.Brand = "KappaClaus"

            Assert.True(Repo.CreateProduto(newProd))
        End Sub
        <Fact>
        Sub TestUpdate_ShouldWork()
            Dim Repo As ProdutoRepository = New ProdutoRepository()
            Dim newProd As Produto = New Produto()
            newProd.Name = "TesteUpdate"
            newProd.PublishDate = DateTime.Now
            newProd.Description = "Novo instrumento teste atualizado"
            newProd.Category = "Bateria ultra"
            newProd.Image = "Image2.png"
            newProd.Price = 6900
            newProd.Brand = "Kappa"

            Assert.True(Repo.UpdateProduto(2, newProd))
        End Sub

        <Fact>
        Sub TestDelete_ShouldWork()
            Dim Repo As ProdutoRepository = New ProdutoRepository()
            Assert.NotNull(Repo.DeleteProduto(1))

        End Sub
    End Class
End Namespace

