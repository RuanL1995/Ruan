CREATE TABLE [dbo].[tblAdmin]
(
	[AdminId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AdminName] VARCHAR(50) NOT NULL, 
    [AdminPassword] VARCHAR(50) NOT NULL, 
    [AdminFirstName] VARCHAR(50) NOT NULL, 
    [AdminSurName] VARCHAR(50) NOT NULL, 
    [AdminEmail] VARCHAR(50) NOT NULL
)
