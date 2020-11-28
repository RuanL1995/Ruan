CREATE TABLE [dbo].[tblTask]
(
	[TaskId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TaskName] VARCHAR(50) NOT NULL,
    [TaskDescription] VARCHAR(50) NOT NULL,
    [TaskProgress] VARCHAR(50) NOT NULL, 
    [TaskAssignedTo] VARCHAR(50) NOT NULL,
    [ProjectName] VARCHAR(50) NOT NULL,  
    [UserId] INT NOT NULL, 
    [ProjectId] INT NOT NULL, 
    [TaskStatus] VARCHAR(50) NULL, 
    CONSTRAINT [FK_tblTask_tblProject] FOREIGN KEY ([ProjectId]) REFERENCES [tblProject]([ProjectId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_tblTask_tblUser] FOREIGN KEY ([UserId]) REFERENCES [tblUser]([UserId]) ON DELETE CASCADE ON UPDATE CASCADE
)
