CREATE PROCEDURE [dbo].[spTaskC1]
/*
** Purpose : Adds a new task to the task table
** Created By :	Ruan
** Created On :	22 Nov 2020
*/
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
	INSERT INTO dbo.tblTask
	(
	    TaskName,
		TaskDescription,
		TaskProgress,
		TaskAssignedTo,
		ProjectName,
		UserId,
		ProjectId,
		TaskStatus
	)
	VALUES
	(   
		@TaskName,
		@TaskDescription,
		@TaskProgress,
		@TaskAssignedTo,
		@ProjectName,
		@UserId,
		@ProjectId,
		@TaskStatus
	)
END