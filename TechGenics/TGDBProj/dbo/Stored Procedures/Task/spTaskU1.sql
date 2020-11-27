CREATE PROCEDURE [dbo].[spTaskU1]
	/*
** Purpose :	Updates a tasks status when moved
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
	@TaskId INT,
	@TaskStatus VARCHAR(50)
AS
BEGIN

UPDATE tblTask
	SET
		TaskStatus = @TaskStatus
	WHERE 
		TaskId = @TaskId
END
