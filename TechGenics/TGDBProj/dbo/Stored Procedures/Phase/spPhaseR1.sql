CREATE PROCEDURE [dbo].[spPhaseR1]
/*
** Purpose : Gets a list of all Phases and info
** Created By :	Ruan
** Created On :	17 Oct 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		PH.PhaseId,
		PH.PhaseName
	FROM 
		tblPhase PH	
END
