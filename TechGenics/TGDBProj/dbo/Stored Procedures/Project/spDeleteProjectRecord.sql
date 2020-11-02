CREATE PROCEDURE [dbo].[spDeleteProjectRecord]
/*
** Purpose :	Delete an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int

AS
BEGIN

DELETE 
	FROM
		tblProject		
	WHERE 
		ProjectId = @ProjectId
END

