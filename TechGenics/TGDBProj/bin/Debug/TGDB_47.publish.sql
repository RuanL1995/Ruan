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
The table [dbo].[tblAdmin] is being dropped and re-created since all non-computed columns within the table have been redefined.
*/

IF EXISTS (select top 1 1 from [dbo].[tblAdmin])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping [dbo].[tblAdmin]...';


GO
DROP TABLE [dbo].[tblAdmin];


GO
PRINT N'Creating [dbo].[tblAdmin]...';


GO
CREATE TABLE [dbo].[tblAdmin] (
    [AdminId]        INT          IDENTITY (1, 1) NOT NULL,
    [AdminName]      VARCHAR (50) NOT NULL,
    [AdminPassword]  VARCHAR (50) NOT NULL,
    [AdminFirstName] VARCHAR (50) NOT NULL,
    [AdminSurName]   VARCHAR (50) NOT NULL,
    [AdminEmail]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AdminId] ASC)
);


GO
PRINT N'Update complete.';


GO
