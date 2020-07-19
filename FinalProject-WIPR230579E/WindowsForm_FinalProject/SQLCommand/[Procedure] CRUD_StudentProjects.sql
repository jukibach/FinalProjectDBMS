USE DBMS_ProjectManagement
go
CREATE OR ALTER PROCEDURE procedureGetProjectsByStudent
(
	@ID VARCHAR(10)
)
AS
BEGIN
	Select distinct(Project.PID), Project.PName, Project.PContent, Project.PType, Project.PBegin, Project.PEnd, Score.score, Score.comment
                from Project Left Join Score 
				ON(Project.PID = Score.PID) 
                Where Project.PID in 
				(SELECT Project_PID FROM StudentProjects 
				WHERE Student_ID = @ID);
END
go
CREATE OR ALTER PROCEDURE procedureProjectsForCombobox
(
	@ID varchar(10)
)
AS
BEGIN
	select * from Project WHERE PID in ( SELECT Project_PID FROM StudentProjects WHERE Student_ID = @ID)
END
go