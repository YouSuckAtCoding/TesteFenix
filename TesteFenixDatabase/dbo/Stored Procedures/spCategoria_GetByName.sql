CREATE PROCEDURE [dbo].[spCategoria_GetByName]
	@Name nvarchar(20)
AS
Begin
	Select Id, [Name] from dbo.Categoria Where [Name] = @Name
End
