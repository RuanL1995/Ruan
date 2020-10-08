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
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\"

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
The column [dbo].[tblUser].[Email] on table [dbo].[tblUser] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[tblUser].[FirstName] on table [dbo].[tblUser] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[tblUser].[SurName] on table [dbo].[tblUser] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column UserName on table [dbo].[tblUser] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column UserPassword on table [dbo].[tblUser] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblUser])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Rename refactoring operation with key b182e280-eb21-4d8a-b975-bc82a20cdac8 is skipped, element [dbo].[tblPhase].[Id] (SqlSimpleColumn) will not be renamed to PhaseId';


GO
PRINT N'Altering [dbo].[tblUser]...';


GO
ALTER TABLE [dbo].[tblUser] ALTER COLUMN [UserName] VARCHAR (50) NOT NULL;

ALTER TABLE [dbo].[tblUser] ALTER COLUMN [UserPassword] VARCHAR (50) NOT NULL;


GO
ALTER TABLE [dbo].[tblUser]
    ADD [FirstName] VARCHAR (50) NOT NULL,
        [SurName]   VARCHAR (50) NOT NULL,
        [Email]     VARCHAR (50) NOT NULL;


GO
PRINT N'Creating [dbo].[tblPhase]...';


GO
CREATE TABLE [dbo].[tblPhase] (
    [PhaseId]   INT          IDENTITY (1, 1) NOT NULL,
    [PhaseName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PhaseId] ASC)
);


GO
PRINT N'Altering [dbo].[spUserR1]...';


GO
ALTER PROCEDURE [dbo].[spUserR1]
/*
** Purpose : Gets a list of all Users and info
** Created By :	Ruan
** Created On :	10 Oct 2020
*/
@UserName VARCHAR(50)
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		U.UserId,
		U.UserName,
		U.UserPassword,	
		U.FirstName,
		U.SurName,
		U.Email
	FROM 
		tblUser U  
	WHERE U.UserName = @UserName			
END
GO
PRINT N'Creating [dbo].[spUserC1]...';


GO
CREATE PROCEDURE [dbo].[spUserC1]
/*
** Purpose : Adds a new user to the user table
** Created By :	Ruan
** Created On :	7 Oct 2020
*/
@UserName VARCHAR(50),
@UserPassword VARCHAR(50),
@FirstName VARCHAR(50),
@SurName VARCHAR(50),
@Email VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblUser
	(
	    UserName,
	    UserPassword,
	    FirstName,
	    SurName,
	    Email
	)
	VALUES
	(   
		@UserName,
	    @UserPassword, 
	    @FirstName, 
	    @SurName, 
	    @Email   
	)
END
GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'b182e280-eb21-4d8a-b975-bc82a20cdac8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('b182e280-eb21-4d8a-b975-bc82a20cdac8')

GO

GO
PRINT N'Update complete.';


GO
