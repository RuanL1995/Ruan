CREATE PROCEDURE [dbo].[spUpdateProjectRecord]
/*
** Purpose :	Updates an existing record in the project table
** Created By :	Rockz
** Created On :	28 Oct 2020
*/

	@ProjectId int,
	@ProjectName VARCHAR(50),
	@ProjectType VARCHAR(50),
	@ProjectStatus VARCHAR(50),
	@ProjectLocation VARCHAR(50)

AS
BEGIN

UPDATE tblProject
	SET
		ProjectName = @ProjectName,
		ProjectType = @ProjectType,
		ProjectStatus = @ProjectStatus,
		ProjectLocation = @ProjectLocation
	WHERE 
		ProjectId = @ProjectId
END
