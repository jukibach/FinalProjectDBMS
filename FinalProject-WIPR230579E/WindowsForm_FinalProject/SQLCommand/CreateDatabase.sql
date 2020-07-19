-- Kiem tra DBMS_ProjectManagement da ton tai hay chua
USE [master]
go
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'DBMS_ProjectManagement') 
begin 
CREATE DATABASE DBMS_ProjectManagement
end
go
CREATE DATABASE DBMS_ProjectManagement
GO
USE DBMS_ProjectManagement
GO

/*
	Create Table Student
*/

CREATE TABLE Student
(
	ID NVARCHAR(10) primary key,
	Fullname NVARCHAR(100),
	Picture	VARBINARY(MAX),
	Birthday DATETIME DEFAULT GETDATE(),
	Gender NVARCHAR(10),
	Class VARCHAR(15),
	Email VARCHAR(100),
	Phone VARCHAR(15),
)
GO
--drop table dbo.student
--go

CREATE TABLE Project
(
	PID VARCHAR(10) PRIMARY KEY,
	
	PName NVARCHAR(100) UNIQUE,
	PContent NVARCHAR(100),
	PType NVARCHAR(20),
	PBegin DATETIME DEFAULT GETDATE(),
	PEnd DATETIME DEFAULT GETDATE(),

)
go
--DROP TABLE dbo.Project
--GO

--/*
--	Create Table Score
--*/
CREATE table Score(ID varchar(10), PID VARCHAR(10) primary key, score float, comment varchar(MAX))
--alter table Score
--ADD constraint FK_Score FOREIGN KEY (PID) REFERENCES Project(PID)
--go
--DROP TABLE dbo.Score
--GO

CREATE TABLE StudentProjects
(
	[Student_ID]  NVARCHAR (10) NOT NULL,
    [Project_PID] varchar(10) NOT NULL
)
go
--drop table [StudentProjects]
--go

CREATE TABLE TaiKhoan
(
	ID VARCHAR(6),
	Username VARCHAR(100) NOT NULL UNIQUE,
	Password VARCHAR(15) NOT NULL,
)
GO 
--drop table [TaiKhoan]
--go