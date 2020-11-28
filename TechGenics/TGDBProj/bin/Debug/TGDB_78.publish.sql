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
PRINT N'Altering [dbo].[spUserC2]...';


GO
ALTER PROCEDURE [dbo].[spUserC2]
/*
** Purpose : Adds a new user
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
@UserName VARCHAR(50),
@UserPassword VARCHAR(50), 
@FirstName VARCHAR(50), 
@SurName VARCHAR(50), 
@Email VARCHAR(50), 
@Initiation BIT, 
@Planning BIT,
@Execution BIT,
@CloseOut BIT

AS
BEGIN
	INSERT INTO dbo.tblUser
	(
	    UserName,
		UserPassword, 
		FirstName, 
		SurName, 
		Email, 
		Initiation, 
		Planning,
		Execution,
		CloseOut
	)
	VALUES
	(   
		@UserName,
		@UserPassword, 
		@FirstName, 
		@SurName, 
		@Email, 
		@Initiation, 
		@Planning,
		@Execution,
		@CloseOut
	)
END
GO
PRINT N'Altering [dbo].[spUserU2]...';


GO
ALTER PROCEDURE [dbo].[spUserU2]
	/*
** Purpose :	Updates a user
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
	@UserId INT,
	@UserName VARCHAR(50),
	@UserPassword VARCHAR(50), 
	@FirstName VARCHAR(50), 
	@SurName VARCHAR(50), 
	@Email VARCHAR(50), 
	@Initiation BIT, 
	@Planning BIT,
	@Execution BIT,
	@CloseOut BIT
AS
BEGIN

UPDATE tblUser
	SET
		UserName = @UserName,
		UserPassword = @UserPassword,
		FirstName = @FirstName,
		SurName = @SurName, 
		Email = @Email,
		Initiation = @Initiation,
		Planning  = @Planning, 
		Execution = @Execution,
		CloseOut = @CloseOut
	WHERE 
		UserId = @UserId
END
GO
PRINT N'Update complete.';


GO
