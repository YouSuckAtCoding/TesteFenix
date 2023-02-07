CREATE PROCEDURE [dbo].[spCategoria_GetById]
	@Id int
AS
Begin
	
	Select Id, Name from dbo.Categoria Where Id = @Id

End
