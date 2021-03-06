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
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS03\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS03\MSSQL\DATA\"

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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[tblPhase]...';


GO
CREATE TABLE [dbo].[tblPhase] (
    [PhaseId]   INT          IDENTITY (1, 1) NOT NULL,
    [PhaseName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PhaseId] ASC)
);


GO
PRINT N'Creating [dbo].[tblProject]...';


GO
CREATE TABLE [dbo].[tblProject] (
    [ProjectId]       INT          IDENTITY (1, 1) NOT NULL,
    [ProjectName]     VARCHAR (50) NULL,
    [ProjectType]     VARCHAR (50) NULL,
    [ProjectStatus]   VARCHAR (50) NULL,
    [ProjectLocation] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ProjectId] ASC)
);


GO
PRINT N'Creating [dbo].[tblProjectPhase]...';


GO
CREATE TABLE [dbo].[tblProjectPhase] (
    [ProjectId] INT NOT NULL,
    [PhaseId]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectId] ASC)
);


GO
PRINT N'Creating [dbo].[tblTest]...';


GO
CREATE TABLE [dbo].[tblTest] (
    [Id]   INT           NOT NULL,
    [Test] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[tblUser]...';


GO
CREATE TABLE [dbo].[tblUser] (
    [UserId]       INT          IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (50) NOT NULL,
    [UserPassword] VARCHAR (50) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [SurName]      VARCHAR (50) NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
PRINT N'Creating [dbo].[tblUserProject]...';


GO
CREATE TABLE [dbo].[tblUserProject] (
    [UserId]    INT NOT NULL,
    [ProjectId] INT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
PRINT N'Creating [dbo].[FK_tblProject_ToPhase]...';


GO
ALTER TABLE [dbo].[tblProjectPhase]
    ADD CONSTRAINT [FK_tblProject_ToPhase] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[tblProject] ([ProjectId]);


GO
PRINT N'Creating [dbo].[FK_tblPhase_ToPhase]...';


GO
ALTER TABLE [dbo].[tblProjectPhase]
    ADD CONSTRAINT [FK_tblPhase_ToPhase] FOREIGN KEY ([PhaseId]) REFERENCES [dbo].[tblPhase] ([PhaseId]);


GO
PRINT N'Creating [dbo].[FK_tblUser_ToProject]...';


GO
ALTER TABLE [dbo].[tblUserProject]
    ADD CONSTRAINT [FK_tblUser_ToProject] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUser] ([UserId]);


GO
PRINT N'Creating [dbo].[FK_tblProject_ToProject]...';


GO
ALTER TABLE [dbo].[tblUserProject]
    ADD CONSTRAINT [FK_tblProject_ToProject] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[tblProject] ([ProjectId]);


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
PRINT N'Creating [dbo].[spUserR1]...';


GO
CREATE PROCEDURE [dbo].[spUserR1]
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
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ca778909-6bd7-4900-8f5b-c2fd7d7feef6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ca778909-6bd7-4900-8f5b-c2fd7d7feef6')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'b182e280-eb21-4d8a-b975-bc82a20cdac8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('b182e280-eb21-4d8a-b975-bc82a20cdac8')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c59e3c11-00c0-400f-b667-f101659dcee6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c59e3c11-00c0-400f-b667-f101659dcee6')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '9616d79d-2766-41ca-9c1c-d8fb4ba20f5d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('9616d79d-2766-41ca-9c1c-d8fb4ba20f5d')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4846f0b1-26a6-4861-b1b0-be7ccd186bc1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4846f0b1-26a6-4861-b1b0-be7ccd186bc1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2e7e8b4e-9369-43fe-819f-f2afc5fee0f0')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2e7e8b4e-9369-43fe-819f-f2afc5fee0f0')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '7e3ecc77-c4a4-495e-9f8f-5b160d77c60c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('7e3ecc77-c4a4-495e-9f8f-5b160d77c60c')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '56107c50-6c1f-4652-84d4-f65a732b6852')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('56107c50-6c1f-4652-84d4-f65a732b6852')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '0dbda28e-3a12-4709-86a0-bc17abec4567')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('0dbda28e-3a12-4709-86a0-bc17abec4567')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '32e38279-2bd1-4104-864f-18a6a121bc4e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('32e38279-2bd1-4104-864f-18a6a121bc4e')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '98c1a67e-eba9-4693-afe6-4cb609fc36da')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('98c1a67e-eba9-4693-afe6-4cb609fc36da')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '18535b86-1585-4b81-81d0-1574920af1df')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('18535b86-1585-4b81-81d0-1574920af1df')

GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
