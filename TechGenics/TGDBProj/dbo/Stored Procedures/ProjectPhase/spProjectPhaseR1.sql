CREATE PROCEDURE [dbo].[spProjectPhaseR1]
/*
** Purpose : Gets a list of all ProjectPhases and info
** Created By :	Ruan
** Created On :	10 Oct 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		PPH.ProjectId,
		PPH.PhaseId
	FROM 
		tblProjectPhase PPH		
END