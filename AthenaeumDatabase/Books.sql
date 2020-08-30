CREATE TABLE [dbo].[Books]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY CLUSTERED,
	[Title] VARCHAR (50),
	[Author] VARCHAR (50),
	[Rating] INT,
	[Review] VARCHAR (50),
	[Notes] VARCHAR (50),
	[Category] VARCHAR (50),
)
