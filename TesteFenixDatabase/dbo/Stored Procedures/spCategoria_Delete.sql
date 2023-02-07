CREATE PROCEDURE [dbo].[spCategoria_Delete]
	@Id int
AS
Begin
	Delete from dbo.Categoria Where Id = @Id;
End
