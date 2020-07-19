USE DBMS_ProjectManagement
go
CREATE OR ALTER PROCEDURE procedureGetAllScoreByProject
(
	@PID VARCHAR(10)
)
AS
BEGIN
	SELECT StudentProjects.Student_ID, s.Fullname,s.Picture,s.Birthday,s.Gender,s.Class,s.Email,s.Phone, sc.score,sc.comment
	FROM dbo.Student s inner join dbo.Score sc on s.ID = sc.ID inner join dbo.StudentProjects
	 on sc.PID = StudentProjects.Project_PID
	WHERE StudentProjects.Project_PID = @PID
	ORDER BY Fullname, sc.Score ASC
	OFFSET 0 ROW
END
GO
--drop proc procedureGetAllScoreByProject
--go





