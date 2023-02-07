CREATE PROCEDURE [dbo].[spProduto_GetByCategoria]
	@CategoryId int
AS
Begin

	Select Id, [Name], PublishDate, [Description], Category, ImageName, Price, Brand from dbo.Produto
	Where Category = @CategoryId;

End

