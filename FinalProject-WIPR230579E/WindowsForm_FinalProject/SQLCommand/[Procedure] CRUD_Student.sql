USE DBMS_ProjectManagement
go


CREATE or ALTER procedure procedureGetStudents
AS
BEGIN
	SELECT * from dbo.Student
end
go

CREATE OR ALTER PROCEDURE procedureObtainStudentByID
(
	@ID NVARCHAR(10)
)
AS
BEGIN
	SELECT * FROM Student WHERE ID = @ID
END
GO


CREATE OR ALTER PROCEDURE procedureObtainStudentByName
(
	@Fullname NVARCHAR(100)
)
AS
BEGIN
	SELECT * FROM Student WHERE Fullname LIKE  N'%' + @Fullname + '%'
END
GO
--drop procedure procedureObtainStudentByName
--go
/*
	Insert a student
*/
CREATE or ALTER procedure procedureInsertStudent
(
	@ID nvarchar(10),
	@Fullname nvarchar(100),
	@Picture VARBINARY(MAX),
	@Birthday datetime,
	@Gender nvarchar(10),
	@Class varchar(15),
	@Email varchar(100),
	@Phone varchar(15)
)
AS
BEGIN
	INSERT INTO dbo.Student(ID,Fullname,Picture	,Birthday,Gender,Class,Email,Phone)
	VALUES (@ID ,@Fullname ,@Picture,@Birthday,@Gender,@Class,@Email,@Phone)
END
go
--drop procedure procedureInsertStudent
--go
/*
	Update student's info
*/
CREATE or ALTER procedure procedureUpdateStudent
(
	@ID nvarchar(10),
	@Fullname nvarchar(100),
	@Picture	VARBINARY(MAX),
	@Birthday datetime,
	@Gender nvarchar(10),
	@Class varchar(15),
	@Email varchar(100),
	@Phone varchar(15)
)
AS
BEGIN
	update dbo.Student set
	Fullname = @Fullname,Picture = @Picture, Birthday =@Birthday,
	Gender = @Gender, Class =@Class ,Email = @Email, Phone =@Phone
	where ID =@ID
END
go
/*
	Delete student's info
*/
CREATE OR ALTER PROCEDURE procedureDeleteStudent
(
	@ID VARCHAR(10)
)
AS
BEGIN
	DELETE dbo.Student WHERE ID = @ID
END
go
/*
	
*/
CREATE OR ALTER PROCEDURE procedureGetStudent
AS
BEGIN
	SELECT ID, Fullname FROM dbo.Student
END
GO
--DROP PROCEDURE dbo.procedureGetProject
--GO