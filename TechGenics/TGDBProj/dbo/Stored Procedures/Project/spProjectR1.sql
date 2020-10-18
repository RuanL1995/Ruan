CREATE PROCEDURE [dbo].[spProjectR1]
/*
** Purpose : Gets a list of all Projects and info
** Created By :	Ruan
** Created On :	18 Oct 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		P.ProjectId,
		P.ProjectName,
		P.ProjectType,
		P.ProjectStatus,
		P.ProjectLocation
	FROM 
		tblProject P 		
END
