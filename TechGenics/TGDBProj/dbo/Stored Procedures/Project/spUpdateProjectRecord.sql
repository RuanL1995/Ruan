﻿CREATE PROCEDURE [dbo].[spUpdateProjectRecord]
/*
** Purpose :	Updates an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int,
	@ProjectName VARCHAR(50),
	@ProjectPhase VARCHAR(50),
	@ProjectStatus VARCHAR(50),
	@DocumentLocation VARCHAR(MAX)

AS
BEGIN

UPDATE tblProject
	SET
		ProjectName = @ProjectName,
		ProjectPhase = @ProjectPhase,
		ProjectStatus = @ProjectStatus,
		DocumentLocation = @DocumentLocation
	WHERE 
		ProjectId = @ProjectId
END
