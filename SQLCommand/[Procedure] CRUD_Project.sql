USE DBMS_ProjectManagement
go

/*
	Hiển thị thông tin bàn bằng ID
*/
CREATE OR ALTER PROCEDURE procedureObtainProjectByID
(
	@PID VARCHAR(10)
)
AS
BEGIN
	SELECT * FROM Project WHERE PID = @PID
END
GO
--DROP PROCEDURE dbo.procedureObtainProjectByID
--GO

/*
	Chèn thêm thông tin bàn
*/
CREATE OR ALTER PROCEDURE procedureInsertProject
( 
	@PID VARCHAR(10),
	@PName NVARCHAR(100),
	@PContent NVARCHAR(100),
	@PType NVARCHAR(20),
	@PBegin DATETIME,
	@PEnd DATETIME
)
AS
BEGIN
	INSERT INTO dbo.Project
	(
	PID,
	PName,
	PContent,
	PType,
	PBegin,
	PEnd
	)
	VALUES
	(
	@PID,
	@PName,
	@PContent,
	@PType,
	@PBegin,
	@PEnd
	)
END
GO
--DROP PROCEDURE dbo.procedureInsertBan
--GO

/*
	Sửa đổi thông tin của project
*/
CREATE OR ALTER PROCEDURE procedureUpdateProject
(
	@PID VARCHAR(10),
	@PName NVARCHAR(100),
	@PContent NVARCHAR(100),
	@PType NVARCHAR(20),
	@PBegin DATETIME,
	@PEnd DATETIME
)
AS
BEGIN
	UPDATE dbo.Project SET			
					PName = @PName,
					PContent = @PContent,
					PType = @PType,
					PBegin = @PBegin,
					PEnd =@PEnd
			WHERE	PID = @PID
END
GO
--DROP PROCEDURE dbo.procedureUpdateBan
--GO

/*
	Xóa thông tin của bàn
*/
CREATE OR ALTER PROCEDURE procedureDeleteProject
(
	@PID VARCHAR(10)
)
AS
BEGIN
	DELETE dbo.Project where PID = @PID
END
GO
--DROP PROCEDURE dbo.procedureDeleteBan
--GO

/*
	
*/
CREATE OR ALTER PROCEDURE procedureGetProject
AS
BEGIN
	SELECT PID, PName FROM dbo.Project
END
GO
--DROP PROCEDURE dbo.procedureGetProject
--GO

/*
	Add mutiple students into project
*/
CREATE OR ALTER PROCEDURE InsertStudentToProject
(
	@ID NVARCHAR(10),
	@PID VARCHAR(10)
)
AS 
BEGIN
	INSERT INTO dbo.StudentProjects
	(Student_ID,Project_PID)
	VALUES (@ID,@PID)
END
go
--DROP PROCEDURE dbo.InsertStudentToProject
--GO
