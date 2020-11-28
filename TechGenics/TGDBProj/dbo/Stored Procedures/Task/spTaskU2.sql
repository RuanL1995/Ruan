CREATE PROCEDURE [dbo].[spTaskU2]
	/*
** Purpose :	Updates a task
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
	@TaskId INT,
	@TaskName VARCHAR(50),
	@TaskDescription VARCHAR(50), 
	@TaskProgress VARCHAR(50), 
	@TaskAssignedTo VARCHAR(50), 
	@ProjectName VARCHAR(50), 
	@UserId INT, 
	@ProjectId INT, 
	@TaskStatus VARCHAR(50)
AS
BEGIN

UPDATE tblTask
	SET
		TaskName = @TaskName,
		TaskDescription = @TaskDescription,
		TaskProgress = @TaskProgress,
		TaskAssignedTo = @TaskAssignedTo, 
		ProjectName = @ProjectName,
		UserId = @UserId,
		ProjectId  = @ProjectId, 
		TaskStatus = @TaskStatus
	WHERE 
		TaskId = @TaskId
END
