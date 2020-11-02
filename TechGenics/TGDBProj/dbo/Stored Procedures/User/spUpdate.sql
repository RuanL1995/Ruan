CREATE PROCEDURE [dbo].[spUpdate]
/*
** Purpose :	Updates an existing record in the user table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@UserId int,
	@UserName VARCHAR(50),
	@UserPassword VARCHAR(50),
	@FirstName VARCHAR(50),
	@SurName VARCHAR(50),
	@Email VARCHAR(50)

AS
BEGIN

UPDATE tblUser
	SET
		UserName = @UserName,
		UserPassword = @UserPassword,
		FirstName = @FirstName,
		SurName = @SurName,
		Email = @Email
	WHERE 
		UserId = @UserId
END
