CREATE PROCEDURE [dbo].[spProduto_Update]
	@Id int,
	@Name nvarchar(100),
	@Date datetime,
	@Description nvarchar(200),
	@Category nvarchar(20),
	@Image nvarchar(20),
	@Price money,
	@Brand nvarchar(20)
AS
Begin

	Update dbo.[Produto]
		Set [Name] = @Name,
		PublishDate = @Date,
		[Description] = @Description,
		Category = @Category,
		ImageName = @Image,
		Price = @Price,
		Brand = @Brand
		Where Id = @Id;

End
