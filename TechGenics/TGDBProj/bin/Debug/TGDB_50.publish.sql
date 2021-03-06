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
The column [dbo].[tblProject].[UserID] is being dropped, data loss could occur.

The column ProjectName on table [dbo].[tblProject] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column ProjectPhase on table [dbo].[tblProject] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblProject])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The column [dbo].[tblTask].[ProjectId] on table [dbo].[tblTask] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[tblTask].[UserId] on table [dbo].[tblTask] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column TaskAssignedTo on table [dbo].[tblTask] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column TaskDescription on table [dbo].[tblTask] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column TaskName on table [dbo].[tblTask] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column TaskProgress on table [dbo].[tblTask] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblTask])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'The following operation was generated from a refactoring log file 8dc60ffe-4304-49d0-84a3-700ff5a40661';

PRINT N'Rename [dbo].[tblTask].[ProjectId] to ProjectName';


GO
EXECUTE sp_rename @objname = N'[dbo].[tblTask].[ProjectId]', @newname = N'ProjectName', @objtype = N'COLUMN';


GO
PRINT N'The following operation was generated from a refactoring log file e5f8d39a-c1ee-483a-96a3-ceba65183568';

PRINT N'Rename [dbo].[tblProject].[ProjectType] to ProjectPhase';


GO
EXECUTE sp_rename @objname = N'[dbo].[tblProject].[ProjectType]', @newname = N'ProjectPhase', @objtype = N'COLUMN';


GO
PRINT N'The following operation was generated from a refactoring log file 75ff9bfd-6330-4f77-b470-6613521a1f1b';

PRINT N'Rename [dbo].[tblProject].[ProjectLocation] to DocumentLocation';


GO
EXECUTE sp_rename @objname = N'[dbo].[tblProject].[ProjectLocation]', @newname = N'DocumentLocation', @objtype = N'COLUMN';


GO
PRINT N'Dropping [dbo].[FK_tblTask_tblProject]...';


GO
ALTER TABLE [dbo].[tblTask] DROP CONSTRAINT [FK_tblTask_tblProject];


GO
PRINT N'Dropping [dbo].[FK_tblProject_UserId]...';


GO
ALTER TABLE [dbo].[tblProject] DROP CONSTRAINT [FK_tblProject_UserId];


GO
PRINT N'Altering [dbo].[tblProject]...';


GO
ALTER TABLE [dbo].[tblProject] DROP COLUMN [UserID];


GO
ALTER TABLE [dbo].[tblProject] ALTER COLUMN [DocumentLocation] VARCHAR (MAX) NULL;

ALTER TABLE [dbo].[tblProject] ALTER COLUMN [ProjectName] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblProject] ALTER COLUMN [ProjectPhase] VARCHAR (50) NOT NULL;


GO
PRINT N'Altering [dbo].[tblTask]...';


GO
ALTER TABLE [dbo].[tblTask] ALTER COLUMN [ProjectName] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblTask] ALTER COLUMN [TaskAssignedTo] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblTask] ALTER COLUMN [TaskDescription] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblTask] ALTER COLUMN [TaskName] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblTask] ALTER COLUMN [TaskProgress] VARCHAR (50) NOT NULL;


GO
ALTER TABLE [dbo].[tblTask]
    ADD [UserId]    INT NOT NULL,
        [ProjectId] INT NOT NULL;


GO
PRINT N'Altering [dbo].[tblUser]...';


GO
ALTER TABLE [dbo].[tblUser]
    ADD [Initiation] BIT NULL,
        [Planning]   BIT NULL,
        [Execution]  BIT NULL,
        [CloseOut]   BIT NULL;


GO
PRINT N'Creating [dbo].[FK_tblTask_tblProject]...';


GO
ALTER TABLE [dbo].[tblTask] WITH NOCHECK
    ADD CONSTRAINT [FK_tblTask_tblProject] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[tblProject] ([ProjectId]);


GO
PRINT N'Creating [dbo].[FK_tblTask_tblUser]...';


GO
ALTER TABLE [dbo].[tblTask] WITH NOCHECK
    ADD CONSTRAINT [FK_tblTask_tblUser] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUser] ([UserId]);


GO
PRINT N'Altering [dbo].[spProjectC1]...';


GO
ALTER PROCEDURE [dbo].[spProjectC1]
/*
** Purpose : Adds a new project to the project table
** Created By :	Ruan
** Created On :	15 Oct 2020
*/
@ProjectName VARCHAR(50),
@ProjectPhase VARCHAR(50),
@ProjectStatus VARCHAR(50),
@DocumentLocation VARCHAR(MAX)

AS
BEGIN
	INSERT INTO dbo.tblProject
	(
	    ProjectName,
	    ProjectPhase,
	    ProjectStatus,
	    DocumentLocation
	)
	VALUES
	(   
		@ProjectName,
	    @ProjectPhase, 
	    @ProjectStatus, 
	    @DocumentLocation
	)
END
GO
PRINT N'Altering [dbo].[spProjectR1]...';


GO
ALTER PROCEDURE [dbo].[spProjectR1]
/*
** Purpose : Gets a list of all Projects and info
** Created By :	Ruan
** Created On :	18 Oct 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		P.ProjectId,
		P.ProjectName,
		P.ProjectPhase,
		P.ProjectStatus,
		P.DocumentLocation
	FROM 
		tblProject P 		
END
GO
PRINT N'Altering [dbo].[spUpdateProjectRecord]...';


GO
ALTER PROCEDURE [dbo].[spUpdateProjectRecord]
/*
** Purpose :	Updates an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int,
	@ProjectName VARCHAR(50),
	@ProjectPhase VARCHAR(50),
	@ProjectStatus VARCHAR(50),
	@DocumentLocation VARCHAR(MAX)

AS
BEGIN

UPDATE tblProject
	SET
		ProjectName = @ProjectName,
		ProjectPhase = @ProjectPhase,
		ProjectStatus = @ProjectStatus,
		DocumentLocation = @DocumentLocation
	WHERE 
		ProjectId = @ProjectId
END
GO
PRINT N'Creating [dbo].[spProjectR2]...';


GO
CREATE PROCEDURE [dbo].[spProjectR2]
/*
** Purpose : Gets list of all logged in users projects and tasks based on phase user belongs to
** Created By :	Ruan
** Created On :	18 Oct 2020
*/
@CurrentUser VARCHAR(50),
@Initiation Bit = 0,
@Planning Bit = 0,
@Execution Bit = 0,
@CloseOut Bit = 0

AS

BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		P.ProjectId,
		P.ProjectName,
		P.ProjectPhase,
		P.ProjectStatus,
		P.DocumentLocation,
		T.TaskId,
		T.TaskName,
		T.TaskDescription,
		T.TaskProgress,
		T.TaskAssignedTo,  
		U.UserId,
		U.UserName
	FROM 
		tblTask T
		INNER JOIN tblUser U ON T.UserId = U.UserId
		INNER JOIN tblProject P ON T.ProjectId = P.ProjectId
	WHERE 
			T.TaskAssignedTo  = @CurrentUser
		AND P.ProjectPhase LIKE 
		 CASE 
			WHEN @Initiation = 1 THEN 
			'Inititation'
			WHEN @Planning = 1 THEN 
			'Planning'
			WHEN @Execution = 1 THEN 
			'Execution'
			WHEN @CloseOut = 1 THEN 
			'CloseOUt'
			ELSE
				'NOPHASE'
			END
END
GO
PRINT N'Refreshing [dbo].[spDeleteProjectRecord]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDeleteProjectRecord]';


GO
PRINT N'Refreshing [dbo].[spDeleteTaskRecord]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDeleteTaskRecord]';


GO
PRINT N'Refreshing [dbo].[spTaskC1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spTaskC1]';


GO
PRINT N'Refreshing [dbo].[spTaskR1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spTaskR1]';


GO
PRINT N'Refreshing [dbo].[spUpdateTaskRecord]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUpdateTaskRecord]';


GO
PRINT N'Refreshing [dbo].[spDeleteUserRecord]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDeleteUserRecord]';


GO
PRINT N'Refreshing [dbo].[spUpdate]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUpdate]';


GO
PRINT N'Refreshing [dbo].[spUserC1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUserC1]';


GO
PRINT N'Refreshing [dbo].[spUserR1]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUserR1]';


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8dc60ffe-4304-49d0-84a3-700ff5a40661')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8dc60ffe-4304-49d0-84a3-700ff5a40661')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e5f8d39a-c1ee-483a-96a3-ceba65183568')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e5f8d39a-c1ee-483a-96a3-ceba65183568')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '75ff9bfd-6330-4f77-b470-6613521a1f1b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('75ff9bfd-6330-4f77-b470-6613521a1f1b')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[tblTask] WITH CHECK CHECK CONSTRAINT [FK_tblTask_tblProject];

ALTER TABLE [dbo].[tblTask] WITH CHECK CHECK CONSTRAINT [FK_tblTask_tblUser];


GO
PRINT N'Update complete.';


GO
