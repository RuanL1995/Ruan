CREATE PROCEDURE [dbo].[spPhaseC1]
/*
** Purpose : Adds a new phase to the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
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