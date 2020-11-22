CREATE TABLE [dbo].[tblPhase]
(
	[PhaseId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PhaseName] VARCHAR(50) NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_tblPhase_tblUser] FOREIGN KEY ([UserId]) REFERENCES [tblUser]([UserID])
)
