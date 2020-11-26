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
PRINT N'Altering [dbo].[spProjectR2]...';


GO
ALTER PROCEDURE [dbo].[spProjectR2]
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
			ELSE
				'NOPHASE'
			END
		AND P.ProjectPhase LIKE 
		 CASE 			
			WHEN @Planning = 1 THEN 
			'Planning'			
			ELSE
				'NOPHASE'
			END
		AND P.ProjectPhase LIKE 
		 CASE 
			WHEN @Execution = 1 THEN 
			'Execution'
			ELSE
				'NOPHASE'
			END
		AND P.ProjectPhase LIKE 
		 CASE 
			WHEN @CloseOut = 1 THEN 
			'CloseOUt'
			ELSE
				'NOPHASE'
			END
END
GO
PRINT N'Update complete.';


GO
