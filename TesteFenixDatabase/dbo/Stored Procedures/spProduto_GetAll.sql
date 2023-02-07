CREATE PROCEDURE [dbo].[spProduto_GetAll]
	
AS
Begin
	
	Select Id, [Name], PublishDate, [Description], Category, ImageName, Price, Brand from dbo.Produto;
		
End