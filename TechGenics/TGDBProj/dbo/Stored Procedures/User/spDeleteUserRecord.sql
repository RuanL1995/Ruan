CREATE PROCEDURE [dbo].[spDeleteUserRecord]
/*
** Purpose :	Delete an existing record in the user table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@UserId int

AS
BEGIN

DELETE 
	FROM
		tblUser		
	WHERE 
		UserId = @UserId
END
