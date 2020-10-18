CREATE PROCEDURE [dbo].[spUserProjectR1]
/*
** Purpose : Gets a list of all UserProjects and info
** Created By :	Ruan
** Created On :	15 Oct 2020
*/
AS
BEGIN
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 

	SELECT 
		UP.UserId,
		UP.ProjectId
	FROM 
		tblUserProject UP  		
END