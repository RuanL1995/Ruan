CREATE PROCEDURE [dbo].[spUpdateTaskRecord]
/*
** Purpose :	Updates an existing record in the phase table
** Created By :	Rockz
** Created On :	22 Nov 2020
*/

	@TaskId int,
	@TaskName VARCHAR(50),
	@TaskProgress VARCHAR(50),
	@TaskAssignedTo VARCHAR(50)
AS
BEGIN

UPDATE tblTask
	SET
		TaskName = @TaskName,
		TaskProgress = @TaskProgress,
		TaskAssignedTo = @TaskAssignedTo
	WHERE 
		TaskId = @TaskId
END
