CREATE PROCEDURE [dbo].[spTaskR1]
/*
** Purpose : Gets a list of all tasks and info
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
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
END