CREATE PROCEDURE [dbo].[spProduto_GetById]
	@Id int
AS
Begin
	
	Select Id, [Name], PublishDate, [Description], Category, ImageName, Price, Brand from dbo.Produto
	Where Id = @Id;
		
End
