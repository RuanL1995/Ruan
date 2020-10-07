CREATE TABLE [dbo].[tblUser]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] VARCHAR(50) NOT NULL, 
    [UserPassword] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [SurName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL
)
