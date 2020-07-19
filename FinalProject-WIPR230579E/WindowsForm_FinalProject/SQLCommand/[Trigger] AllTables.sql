USE DBMS_ProjectManagement
go

CREATE OR ALTER TRIGGER triggerCheckValidatePhoneNumber
	ON dbo.Student
	FOR INSERT, UPDATE
AS
DECLARE @phoneNoInserted VARCHAR(15) = (SELECT Inserted.Phone FROM Inserted);
	BEGIN TRY
		BEGIN TRANSACTION
			IF (SELECT COUNT(*) FROM dbo.Student WHERE Phone = @phoneNoInserted) > 1
				BEGIN
					PRINT (N'The phone number is used by other student!')
					ROLLBACK TRANSACTION
					RETURN
				END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	END CATCH
GO

CREATE OR ALTER TRIGGER triggerCheckValidateBirthDay
	ON dbo.Student
	FOR INSERT, UPDATE
AS
DECLARE @birthDayInserted DATETIME = (SELECT Inserted.Birthday FROM Inserted);
DECLARE @yearOld INT = CONVERT(int,ROUND(DATEDIFF(hour,@birthDayInserted,GETDATE())/8766.0,0))
	BEGIN TRY
		BEGIN TRANSACTION
			IF @yearOld < 18
				BEGIN
					PRINT (N'Student age must be greater than 18!')
					ROLLBACK TRANSACTION
					RETURN
				END
		COMMIT TRANSACTION
		
	END TRY
	BEGIN CATCH
	END CATCH
GO

