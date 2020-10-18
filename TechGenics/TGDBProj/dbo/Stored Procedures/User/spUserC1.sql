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

