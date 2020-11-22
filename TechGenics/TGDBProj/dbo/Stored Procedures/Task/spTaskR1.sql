CREATE PROCEDURE [dbo].[spTaskR1]
/*
** Purpose : Gets a list of all Phases and info
** Created By :	Rockz
** Created On :	22 Nov 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT
		T.TaskId,
		T.TaskName,
		T.TaskProgress,
		T.TaskAssignedTo
	FROM 
		tblTask T
END