CREATE PROCEDURE [dbo].[spTaskC1]
/*
** Purpose : Adds a new phase to the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
@TaskName VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblTask
	(
	    TaskName
	)
	VALUES
	(   
		@TaskName
	)
END