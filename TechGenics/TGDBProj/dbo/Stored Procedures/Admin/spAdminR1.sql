CREATE PROCEDURE [dbo].[spAdminR1]
/*
** Purpose : Gets a list of all Admins and info
** Created By :	Ruan
** Created On :	10 Oct 2020
*/
@AdminName VARCHAR(50)
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		A.AdminId,
		A.AdminName,
		A.AdminPassword,	
		A.AdminFirstName,
		A.AdminSurName,
		A.AdminEmail
	FROM 
		tblAdmin A  
	WHERE A.AdminName = @AdminName			
END
