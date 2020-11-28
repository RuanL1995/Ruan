CREATE PROCEDURE [dbo].[spProjectC1]
/*
** Purpose : Adds a new project to the project table
** Created By :	Ruan
** Created On :	15 Oct 2020
*/
@ProjectName VARCHAR(50),
@ProjectPhase VARCHAR(50),
@ProjectStatus VARCHAR(50)

AS
BEGIN
	INSERT INTO dbo.tblProject
	(
	    ProjectName,
	    ProjectPhase,
	    ProjectStatus
	)
	VALUES
	(   
		@ProjectName,
	    @ProjectPhase, 
	    @ProjectStatus
	)
END