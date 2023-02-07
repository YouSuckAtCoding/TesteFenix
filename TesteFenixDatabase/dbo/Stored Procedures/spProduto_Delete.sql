CREATE PROCEDURE [dbo].[spProduto_Delete]
	@Id int
AS
Begin

		Delete from dbo.[Produto]
		Where Id = @Id;

End
