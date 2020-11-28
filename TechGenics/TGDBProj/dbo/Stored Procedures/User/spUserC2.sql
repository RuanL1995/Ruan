CREATE PROCEDURE [dbo].[spUserC2]
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
