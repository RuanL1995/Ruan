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
The column TaskStatus on table [dbo].[tblTask] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[tblTask])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering [dbo].[tblTask]...';


GO
ALTER TABLE [dbo].[tblTask] ALTER COLUMN [TaskStatus] VARCHAR (50) NOT NULL;


GO
PRINT N'Refreshing [dbo].[spDeleteTaskRecord]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDeleteTaskRecord]';


GO
PRINT N'Refreshing [dbo].[spProjectR2]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spProjectR2]';


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
PRINT N'Update complete.';


GO
