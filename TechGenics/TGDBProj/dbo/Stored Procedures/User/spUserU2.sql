CREATE PROCEDURE [dbo].[spUserU2]
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
