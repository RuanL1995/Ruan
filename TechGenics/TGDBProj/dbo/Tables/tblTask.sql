CREATE TABLE [dbo].[tblTask]
(
	[TaskId] INT NOT NULL PRIMARY KEY, 
    [TaskName] VARCHAR(50) NULL, 
    [TaskProgress] VARCHAR(50) NULL, 
    [TaskAssignedTo] VARCHAR(50) NULL, 
    [ProjectId] INT NOT NULL, 
    CONSTRAINT [FK_tblTask_tblProject] FOREIGN KEY ([ProjectId]) REFERENCES [tblProject]([ProjectId])
)
