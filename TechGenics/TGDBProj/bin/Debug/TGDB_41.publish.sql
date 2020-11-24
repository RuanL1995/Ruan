﻿/*
Deployment script for TGDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "TGDB"
:setvar DefaultFilePrefix "TGDB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column [dbo].[tblPhase].[UserId] on table [dbo].[tblPhase] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblPhase])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The column [dbo].[tblProject].[UserID] on table [dbo].[tblProject] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblProject])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Rename refactoring operation with key aa1fbfc3-ee75-43ae-b56a-86365b509b91 is skipped, element [dbo].[tblPhase].[UserID] (SqlSimpleColumn) will not be renamed to UserId';


GO
PRINT N'Rename refactoring operation with key bb783f73-995c-402d-a826-543d8cc6b7c3 is skipped, element [dbo].[tblTask].[Id] (SqlSimpleColumn) will not be renamed to TaskId';


GO
PRINT N'Rename refactoring operation with key 52a27231-1206-4b2c-8df5-5d7a75099e00 is skipped, element [dbo].[tblTask].[AssignedTo] (SqlSimpleColumn) will not be renamed to TaskAssignedTo';


GO
PRINT N'Altering [dbo].[tblPhase]...';


GO
ALTER TABLE [dbo].[tblPhase]
    ADD [UserId] INT NOT NULL;


GO
PRINT N'Altering [dbo].[tblProject]...';


GO
ALTER TABLE [dbo].[tblProject]
    ADD [UserID] INT NOT NULL;


GO
PRINT N'Creating [dbo].[tblTask]...';


GO
CREATE TABLE [dbo].[tblTask] (
    [TaskId]          INT          NOT NULL,
    [TaskName]        VARCHAR (50) NULL,
    [TaskDescription] VARCHAR (50) NULL,
    [TaskProgress]    VARCHAR (50) NULL,
    [TaskAssignedTo]  VARCHAR (50) NULL,
    [ProjectId]       INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([TaskId] ASC)
);


GO
PRINT N'Creating [dbo].[FK_tblTask_tblProject]...';


GO
ALTER TABLE [dbo].[tblTask] WITH NOCHECK
    ADD CONSTRAINT [FK_tblTask_tblProject] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[tblProject] ([ProjectId]);


GO
PRINT N'Creating [dbo].[FK_tblPhase_tblUser]...';


GO
ALTER TABLE [dbo].[tblPhase] WITH NOCHECK
    ADD CONSTRAINT [FK_tblPhase_tblUser] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUser] ([UserId]);


GO
PRINT N'Creating [dbo].[FK_tblProject_UserId]...';


GO
ALTER TABLE [dbo].[tblProject] WITH NOCHECK
    ADD CONSTRAINT [FK_tblProject_UserId] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tblUser] ([UserId]);


GO
PRINT N'Altering [dbo].[spPhaseC1]...';


GO
ALTER PROCEDURE [dbo].[spPhaseC1]
/*
** Purpose : Adds a new phase to the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
@PhaseName VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblPhase
	(
	    PhaseName
	)
	VALUES
	(   
		@PhaseName
	)
END
GO
PRINT N'Creating [dbo].[spDeletePhaseRecord]...';


GO
CREATE PROCEDURE [dbo].[spDeletePhaseRecord]
/*
** Purpose :	Delete an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@PhaseId int

AS
BEGIN

DELETE 
	FROM
		tblPhase		
	WHERE 
		PhaseId = @PhaseId 
END
GO
PRINT N'Creating [dbo].[spDeleteProjectRecord]...';


GO
CREATE PROCEDURE [dbo].[spDeleteProjectRecord]
/*
** Purpose :	Delete an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int

AS
BEGIN

DELETE 
	FROM
		tblProject		
	WHERE 
		ProjectId = @ProjectId
END
GO
PRINT N'Creating [dbo].[spDeleteTaskRecord]...';


GO
CREATE PROCEDURE [dbo].[spDeleteTaskRecord]
/*
** Purpose :	Delete an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@TaskId int,
	@TaskName VARCHAR(50),
	@TaskProgress VARCHAR(50),
	@TaskAssignedTo VARCHAR(50)

AS
BEGIN

DELETE 
	FROM
		tblTask		
	WHERE 
		TaskId = @TaskId 
END
GO
PRINT N'Creating [dbo].[spDeleteUserRecord]...';


GO
CREATE PROCEDURE [dbo].[spDeleteUserRecord]
/*
** Purpose :	Delete an existing record in the user table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@UserId int

AS
BEGIN

DELETE 
	FROM
		tblUser		
	WHERE 
		UserId = @UserId
END
GO
PRINT N'Creating [dbo].[spTaskC1]...';


GO
CREATE PROCEDURE [dbo].[spTaskC1]
/*
** Purpose : Adds a new phase to the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
@TaskName VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblTask
	(
	    TaskName
	)
	VALUES
	(   
		@TaskName
	)
END
GO
PRINT N'Creating [dbo].[spTaskR1]...';


GO
CREATE PROCEDURE [dbo].[spTaskR1]
/*
** Purpose : Gets a list of all Phases and info
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT
		T.TaskId,
		T.TaskName,
		T.TaskProgress,
		T.TaskAssignedTo
	FROM 
		tblTask T
END
GO
PRINT N'Creating [dbo].[spUpdate]...';


GO
CREATE PROCEDURE [dbo].[spUpdate]
/*
** Purpose :	Updates an existing record in the user table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@UserId int,
	@UserName VARCHAR(50),
	@UserPassword VARCHAR(50),
	@FirstName VARCHAR(50),
	@SurName VARCHAR(50),
	@Email VARCHAR(50)

AS
BEGIN

UPDATE tblUser
	SET
		UserName = @UserName,
		UserPassword = @UserPassword,
		FirstName = @FirstName,
		SurName = @SurName,
		Email = @Email
	WHERE 
		UserId = @UserId
END
GO
PRINT N'Creating [dbo].[spUpdatePhaseRecord]...';


GO
CREATE PROCEDURE [dbo].[spUpdatePhaseRecord]
/*
** Purpose :	Updates an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@PhaseId int,
	@PhaseName VARCHAR(50)

AS
BEGIN

UPDATE tblPhase
	SET
		PhaseName = @PhaseName
	WHERE 
		PhaseId = @PhaseId
END
GO
PRINT N'Creating [dbo].[spUpdateProjectRecord]...';


GO
CREATE PROCEDURE [dbo].[spUpdateProjectRecord]
/*
** Purpose :	Updates an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int,
	@ProjectName VARCHAR(50),
	@ProjectType VARCHAR(50),
	@ProjectStatus VARCHAR(50),
	@ProjectLocation VARCHAR(50)

AS
BEGIN

UPDATE tblProject
	SET
		ProjectName = @ProjectName,
		ProjectType = @ProjectType,
		ProjectStatus = @ProjectStatus,
		ProjectLocation = @ProjectLocation
	WHERE 
		ProjectId = @ProjectId
END
GO
PRINT N'Creating [dbo].[spUpdateTaskRecord]...';


GO
CREATE PROCEDURE [dbo].[spUpdateTaskRecord]
/*
** Purpose :	Updates an existing record in the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
*/

	@TaskId int,
	@TaskName VARCHAR(50),
	@TaskProgress VARCHAR(50),
	@TaskAssignedTo VARCHAR(50)
AS
BEGIN

UPDATE tblTask
	SET
		TaskName = @TaskName,
		TaskProgress = @TaskProgress,
		TaskAssignedTo = @TaskAssignedTo
	WHERE 
		TaskId = @TaskId
END
GO
PRINT N'Refreshing [dbo].[spPhaseR1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPhaseR1]';


GO
PRINT N'Refreshing [dbo].[spProjectC1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spProjectC1]';


GO
PRINT N'Refreshing [dbo].[spProjectR1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spProjectR1]';


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'aa1fbfc3-ee75-43ae-b56a-86365b509b91')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('aa1fbfc3-ee75-43ae-b56a-86365b509b91')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'bb783f73-995c-402d-a826-543d8cc6b7c3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('bb783f73-995c-402d-a826-543d8cc6b7c3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '52a27231-1206-4b2c-8df5-5d7a75099e00')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('52a27231-1206-4b2c-8df5-5d7a75099e00')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[tblTask] WITH CHECK CHECK CONSTRAINT [FK_tblTask_tblProject];

ALTER TABLE [dbo].[tblPhase] WITH CHECK CHECK CONSTRAINT [FK_tblPhase_tblUser];

ALTER TABLE [dbo].[tblProject] WITH CHECK CHECK CONSTRAINT [FK_tblProject_UserId];


GO
PRINT N'Update complete.';


GO
