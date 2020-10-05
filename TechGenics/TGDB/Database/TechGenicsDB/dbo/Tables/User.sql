CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [UserName] NCHAR(10) NULL, 
    [UserPassword] NCHAR(10) NULL
)
