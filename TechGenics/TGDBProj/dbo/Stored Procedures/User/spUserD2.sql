CREATE PROCEDURE [dbo].[spUserD2]
/*
** Purpose :	Delete an existing user
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
