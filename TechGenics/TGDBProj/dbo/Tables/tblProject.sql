CREATE TABLE [dbo].[tblProject]
(
	[ProjectId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] VARCHAR(50) NULL, 
    [ProjectType] VARCHAR(50) NULL, 
    [ProjectStatus] VARCHAR(50) NULL, 
    [ProjectLocation] VARCHAR(50) NULL
)
