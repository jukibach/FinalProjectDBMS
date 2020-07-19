USE DBMS_ProjectManagement
GO 

/*
	Lấy danh sách tài khoản
*/
CREATE OR ALTER PROCEDURE procedureGetTaiKhoan
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan
END
GO
--DROP PROCEDURE dbo.procedureGetTaiKhoan
--GO
/*
	Lấy thông tin tài khoản theo ID
*/
CREATE OR ALTER PROCEDURE procedureGetTaiKhoanByID
(
	@ID VARCHAR(6)
)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE ID = @ID
END
GO
--DROP PROCEDURE dbo.procedureGetTaiKhoanByID
--GO

/*
	Thêm tài khoản mới
*/
CREATE OR ALTER PROCEDURE procedureInsertTaiKhoan
(
	@ID VARCHAR(6),
	@Username VARCHAR(100),
	@Password VARCHAR(15)
)
AS
BEGIN
	INSERT dbo.TaiKhoan
	(
	    ID,
	    Username,
	    Password
	)
	VALUES
	(   @ID,
	    @Username,
	    @Password
	    )
END
GO

--DROP PROCEDURE dbo.procedureInsertTaiKhoan
--GO

/*
	Sửa đổi thông tin tài khoản
*/
CREATE OR ALTER PROCEDURE procedureUpdateTaiKhoan
(
	@ID VARCHAR(6),
	@Username VARCHAR(100),
	@Password VARCHAR(15)
)
AS
BEGIN
	UPDATE dbo.TaiKhoan SET
							Username = @Username,
							Password = @Password
					  WHERE	ID = @ID
END
GO
--DROP PROCEDURE dbo.procedureUpdateTaiKhoan
--GO

--DROP PROCEDURE dbo.procedureUpdateTaiKhoan
--GO
CREATE OR ALTER PROCEDURE procedureDeleteTaiKhoan
(
	@ID VARCHAR(6)
)
AS
BEGIN
	DELETE dbo.TaiKhoan WHERE ID = @ID
END
go
CREATE OR ALTER PROCEDURE procedureCheckDangNhap
(
	@Username VARCHAR(100),
	@Password VARCHAR(200)
)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan tk
	WHERE tk.Username= @Username AND 
		  tk.Password= @Password				
END
GO