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
		U.UserPassword	
	FROM 
		tblUser U  
	WHERE U.UserName = @UserName			
END
