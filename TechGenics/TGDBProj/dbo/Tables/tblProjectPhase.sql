CREATE TABLE [dbo].[tblProjectPhase]
(
	[ProjectId] INT NOT NULL PRIMARY KEY, 
    [PhaseId] INT NOT NULL, 
    CONSTRAINT [FK_tblProject_ToPhase] FOREIGN KEY ([ProjectId]) REFERENCES [tblProject]([ProjectId]), 
    CONSTRAINT [FK_tblPhase_ToPhase] FOREIGN KEY ([PhaseId]) REFERENCES [tblPhase]([PhaseId])
)
