CREATE PROCEDURE [dbo].[spDeleteTaskRecord]
/*
** Purpose :	Delete an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@TaskId int

AS
BEGIN

DELETE 
	FROM
		tblTask		
	WHERE 
		TaskId = @TaskId 
END
