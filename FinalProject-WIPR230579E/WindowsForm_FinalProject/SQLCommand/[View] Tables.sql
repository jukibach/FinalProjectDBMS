USE DBMS_ProjectManagement
GO


/* Student */
-- Lấy danh sách Student
CREATE OR ALTER VIEW viewStudent
AS
	SELECT *
	FROM dbo.Student
	ORDER BY ID, Fullname ASC
	OFFSET 0 ROW
GO
--drop view viewStudent
--go
CREATE OR ALTER VIEW viewProject
AS
	SELECT *
	FROM dbo.Project
	ORDER BY PID, PName ASC
	OFFSET 0 ROW
GO

CREATE OR ALTER VIEW viewScore
AS
select Student.ID, Student.Fullname,Student.Picture, Student.Birthday,Student.Gender, Student.Class,Student.Email,Student.Phone, Score.score, Score.comment
from Student inner join StudentProjects on Student.ID = StudentProjects.Student_ID inner join Score on Score.PID = StudentProjects.Project_PID
GO
--drop view viewScore
--go

--CREATE OR ALTER VIEW viewScore
--AS
--select Student.ID, Student.Fullname,Student.Picture, Student.Birthday,Student.Gender, Student.Class,Student.Email,Student.Phone, Score.score, Score.comment
--from Student inner join Score on Student.ID = Score.ID 
--GO

/* Tài Khoản */
-- Lấy danh sách tài khoản
CREATE OR ALTER VIEW viewGetTaiKhoan
AS
	SELECT * FROM dbo.TaiKhoan
	ORDER BY Username
	OFFSET 0 ROW
GO

