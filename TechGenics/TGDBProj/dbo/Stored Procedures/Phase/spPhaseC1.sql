CREATE PROCEDURE [dbo].[spPhaseC1]
/*
** Purpose : Adds a new phase to the phase table
** Created By :	Ruan
** Created On :	15 Oct 2020
*/
@PhaseName VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblPhase
	(
	    PhaseName
	)
	VALUES
	(   
		@PhaseName
	)
END