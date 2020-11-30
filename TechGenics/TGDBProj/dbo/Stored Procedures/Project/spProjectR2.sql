CREATE PROCEDURE [dbo].[spProjectR2]
/*
** Purpose : Gets list of all logged in users projects and tasks based on phase user belongs to
** Created By :	Ruan
** Created On :	18 Oct 2020
*/
@CurrentUser VARCHAR(50),
@Initiation Bit = 0,
@Planning Bit = 0,
@Execution Bit = 0,
@CloseOut Bit = 0

AS

BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
	SELECT 
		P.ProjectId,
		P.ProjectName,
		P.ProjectPhase,
		P.ProjectStatus,
		P.DocumentLocation,
		T.TaskId,
		T.TaskName,
		T.TaskDescription,
		T.TaskProgress,
		T.TaskAssignedTo,  
		T.TaskStatus,
		U.UserId,
		U.UserName
	INTO #FilterByUser
	FROM 
		tblProject P
		LEFT JOIN tblTask T ON T.ProjectId = P.ProjectId
		LEFT JOIN tblUser U ON T.UserId = U.UserId
		
	WHERE 
			(@CurrentUser IS NULL OR T.TaskAssignedTo  = @CurrentUser)

		
	SELECT * FROM #FilterByUser
	WHERE 
		ProjectPhase LIKE 
		 CASE 
			WHEN @Initiation = 1 THEN 
			'Initiation'			
			END
		OR ProjectPhase LIKE 
		 CASE 			
			WHEN @Planning = 1 THEN 
			'Planning'			
			END
		OR ProjectPhase LIKE 
		 CASE 
			WHEN @Execution = 1 THEN 
			'Execution'
			END
		OR ProjectPhase LIKE 
		 CASE 
			WHEN @CloseOut = 1 THEN 
			'CloseOUt'
			END			
END