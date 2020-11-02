CREATE PROCEDURE [dbo].[spDeletePhaseRecord]
/*
** Purpose :	Delete an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@PhaseId int

AS
BEGIN

DELETE 
	FROM
		tblPhase		
	WHERE 
		PhaseId = @PhaseId 
END
