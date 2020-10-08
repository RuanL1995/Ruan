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
PRINT N'Rename refactoring operation with key ca778909-6bd7-4900-8f5b-c2fd7d7feef6 is skipped, element [dbo].[tblUser].[Id] (SqlSimpleColumn) will not be renamed to UserId';


GO
PRINT N'Creating [dbo].[tblUser]...';


GO
CREATE TABLE [dbo].[tblUser] (
    [UserId]       INT          IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (50) NULL,
    [UserPassword] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ca778909-6bd7-4900-8f5b-c2fd7d7feef6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ca778909-6bd7-4900-8f5b-c2fd7d7feef6')

GO

GO
PRINT N'Update complete.';


GO