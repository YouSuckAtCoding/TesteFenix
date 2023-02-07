CREATE PROCEDURE [dbo].[spProduto_Create]
	@Name nvarchar(100),
	@Date datetime,
	@Description nvarchar(200),
	@Category nvarchar(20),
	@Image nvarchar(20),
	@Price money,
	@Brand nvarchar(20)

AS
Begin
	
	Insert into dbo.[Produto] ([Name], PublishDate, [Description], Category, ImageName, Price, Brand)
	values (@Name, @Date, @Description, @Category, @Image, @Price, @Brand );
	
End
