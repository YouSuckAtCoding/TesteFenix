CREATE TABLE [dbo].[Produto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (100) NOT NULL,
	[PublishDate] datetime NOT NULL,
	[Description] NVARCHAR (200) NOT NULL,
	[Category] INT NOT NULL,
	[ImageName] NVARCHAR(50) NOT NULL,
	[Price] MONEY NOT NULL,
	[Brand] NVARCHAR(20) NOT NULL,

)
