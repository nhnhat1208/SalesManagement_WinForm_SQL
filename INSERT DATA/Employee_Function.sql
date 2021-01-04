DROP FUNCTION [dbo].[f_employee_count]
GO
CREATE FUNCTION [dbo].[f_employee_count] (
	@compId CHAR(4),
	@age INT
)
RETURNS INT
AS
BEGIN
	DECLARE @count INT = 0
	IF NOT EXISTS(SELECT * FROM Chi_Nhanh WHERE Chi_Nhanh_MaCN = @compId)
		RETURN 0
	IF @age <= 0
		RETURN 0
	
	DECLARE @ListEmp TABLE (id CHAR(9),birthdate DATETIME, processed BIT DEFAULT 0) 
	INSERT INTO @ListEmp(id,birthdate) SELECT Nhan_Vien_MaNV, Nhan_Vien_NgaySinh 
		FROM Nhan_Vien INNER JOIN NV_ChiNhanh ON NhanVien_ChiNhanh_MaNV=Nhan_Vien_MaNV 
			WHERE NhanVien_ChiNhanh_ConLamHayKo = 1 AND NhanVien_ChiNhanh_MaCN = @compId

	DECLARE @birthdate DATETIME
	DECLARE @empId CHAR(9)
	WHILE (SELECT COUNT(*) FROM @ListEmp WHERE processed = 0) > 0
	BEGIN	
		SELECT TOP 1 @birthdate = birthdate, @empId = id FROM @ListEmp WHERE processed = 0

		IF (FLOOR(DATEDIFF(DAY,@birthdate, GETDATE()) / 365.25) >= @age)
			SET @count = @count + 1

		UPDATE @ListEmp SET processed = 1 WHERE id = @empId 
	END

	RETURN @count
END
GO
SELECT [dbo].[f_employee_count]('CN2',21) AS Soluong