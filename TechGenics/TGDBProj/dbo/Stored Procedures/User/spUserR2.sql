CREATE PROCEDURE [dbo].[spUserR2]
/*
** Purpose : Gets a list of all Users and info
** Created By :	Ruan
** Created On :	10 Oct 2020
*/

AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		U.UserId,
		U.UserName,
		U.UserPassword,	
		U.FirstName,
		U.SurName,
		U.Email,
		U.Initiation,
		U.Planning,
		U.Execution,
		U.CloseOut
	FROM 
		tblUser U  			
END
