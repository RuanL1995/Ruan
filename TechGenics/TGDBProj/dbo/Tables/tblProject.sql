CREATE TABLE [dbo].[tblProject]
(
	[ProjectId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] VARCHAR(50) NULL, 
    [ProjectType] VARCHAR(50) NULL, 
    [ProjectStatus] VARCHAR(50) NULL, 
    [ProjectLocation] VARCHAR(50) NULL, 
    [UserID] INT NOT NULL, 
    CONSTRAINT [FK_tblProject_UserId] FOREIGN KEY ([UserId]) REFERENCES [tblUser]([UserId])
)
