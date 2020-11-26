CREATE TABLE [dbo].[tblProject]
(
	[ProjectId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] VARCHAR(50) NOT NULL, 
    [ProjectPhase] VARCHAR(50) NOT NULL, 
    [ProjectStatus] VARCHAR(50) NULL, 
    [DocumentLocation] VARCHAR(MAX) NULL, 
)
