CREATE TABLE [dbo].[tblUserProject]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [ProjectId] INT NULL, 
    CONSTRAINT [FK_tblUser_ToProject] FOREIGN KEY ([UserId]) REFERENCES [tblUser]([UserId]), 
    CONSTRAINT [FK_tblProject_ToProject] FOREIGN KEY ([ProjectId]) REFERENCES [tblProject]([ProjectId]) 
)
