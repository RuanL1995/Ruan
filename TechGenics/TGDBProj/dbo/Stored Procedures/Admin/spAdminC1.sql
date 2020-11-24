CREATE PROCEDURE [dbo].[spAdminC1]
/*
** Purpose : Adds a new admin to the admin table
** Created By :	Ruan
** Created On :	7 Oct 2020
*/
@AdminName VARCHAR(50),
@AdminPassword VARCHAR(50),
@AdminFirstName VARCHAR(50),
@AdminSurName VARCHAR(50),
@AdminEmail VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblAdmin
	(
	    AdminName,
	    AdminPassword,
	    AdminFirstName,
	    AdminSurName,
	    AdminEmail
	)
	VALUES
	(   
		@AdminName,
	    @AdminPassword, 
	    @AdminFirstName, 
	    @AdminSurName, 
	    @AdminEmail   
	)
END