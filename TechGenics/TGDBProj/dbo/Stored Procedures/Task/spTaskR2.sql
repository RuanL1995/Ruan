CREATE PROCEDURE [dbo].[spTaskR2]
/*
** Purpose : Gets a task by task id
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
@TaskId INT
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT
		T.TaskId,
		T.TaskName,
		T.TaskDescription,
		T.TaskProgress,
		T.TaskAssignedTo,
		T.ProjectName,
		T.UserId,
		T.ProjectId,
		T.TaskStatus
	FROM 
		tblTask T
	WHERE 
		T.TaskId = @TaskId
END
