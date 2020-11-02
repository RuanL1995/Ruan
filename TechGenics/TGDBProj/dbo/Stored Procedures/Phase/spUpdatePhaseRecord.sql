CREATE PROCEDURE [dbo].[spUpdatePhaseRecord]
/*
** Purpose :	Updates an existing record in the phase table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@PhaseId int,
	@PhaseName VARCHAR(50)

AS
BEGIN

UPDATE tblPhase
	SET
		PhaseName = @PhaseName
	WHERE 
		PhaseId = @PhaseId
END

