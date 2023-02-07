CREATE PROCEDURE [dbo].[spCategoria_Create]
	@Name nvarchar(20)
AS
Begin

	Insert into dbo.Categoria (Name) Values (@Name)
End
