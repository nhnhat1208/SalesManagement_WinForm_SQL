--DROP TRIGGER employee_insert_trigger
--GO

CREATE TRIGGER employee_insert_trigger
ON Nhan_Vien
INSTEAD OF INSERT
AS
BEGIN 
	DECLARE @empId CHAR(9) = (SELECT Nhan_Vien_MaNV FROM INSERTED)
	DECLARE @ssn VARCHAR(20) = (SELECT Nhan_Vien_CMND FROM INSERTED)
	DECLARE @birthdate DATETIME = (SELECT Nhan_Vien_NgaySinh FROM INSERTED)
	DECLARE @age INT = (SELECT  FLOOR(DATEDIFF(DAY,@birthdate, GETDATE()) / 365.25))

	IF EXISTS(SELECT * FROM Nhan_Vien WHERE Nhan_Vien_MaNV = @empId)
		PRINT(N'Mã nhân viên b? trùng l?p xin hãy ch?n mã khác')
	ELSE IF EXISTS(SELECT * FROM Nhan_Vien WHERE Nhan_Vien_CMND = @ssn)
		PRINT(N'Ch?ng minh nhân dân b? trùng xin hãy ki?m tra l?i')
	ELSE IF @age < 18
		PRINT(N'Nhân viên không ?? 18 tu?i !')
	ELSE
		BEGIN
			INSERT INTO Nhan_Vien(Nhan_Vien_MaNV, Nhan_Vien_CMND, Nhan_Vien_HoTen
				, Nhan_Vien_NgaySinh, Nhan_Vien_DiaChi, Nhan_Vien_NgayVaoLam, Nhan_Vien_SoTK) 
				SELECT Nhan_Vien_MaNV, Nhan_Vien_CMND, Nhan_Vien_HoTen
					, Nhan_Vien_NgaySinh, Nhan_Vien_DiaChi, GETDATE(), Nhan_Vien_SoTK FROM INSERTED

			DECLARE @compId CHAR(4)
			SELECT @compId = a.NhanVien_ChiNhanh_MaCN FROM (
				SELECT TOP 1 NhanVien_ChiNhanh_MaCN, 
					COUNT(NhanVien_ChiNhanh_MaNV) AS Count 
						FROM NV_ChiNhanh 
						WHERE NhanVien_ChiNhanh_ConLamHayKo = 1
						GROUP BY NhanVien_ChiNhanh_MaCN 
							ORDER BY Count ASC) a

			INSERT INTO NV_ChiNhanh(NhanVien_ChiNhanh_MaNV, NhanVien_ChiNhanh_MaCN, 
				NhanVien_ChiNhanh_ThoiGianBDLam, NhanVien_ChiNhanh_ConLamHayKo)
				VALUES(@empId,@compId,GETDATE(),1)
		END
END

--GO
----DELETE FROM Nhan_Vien WHERE Nhan_Vien_MaNV = 'NV7'
--INSERT INTO Nhan_Vien(Nhan_Vien_MaNV, Nhan_Vien_CMND, Nhan_Vien_HoTen
--			, Nhan_Vien_NgaySinh, Nhan_Vien_DiaChi, Nhan_Vien_SoTK) 
--			VALUES('NV9','12325778','H? V?n Phong', '20050219','04, ???ng 16, Th? ??c, Tp.HCM','1216410' )
--DROP TRIGGER employee_update_trigger
GO
CREATE TRIGGER employee_update_trigger
ON Nhan_Vien
INSTEAD OF UPDATE
AS
BEGIN 
	DECLARE @empId CHAR(9) = (SELECT Nhan_Vien_MaNV FROM INSERTED)
	DECLARE @ssn VARCHAR(20) = (SELECT Nhan_Vien_CMND FROM INSERTED)
	DECLARE @birthdate DATETIME = (SELECT Nhan_Vien_NgaySinh FROM INSERTED)
	DECLARE @name NVARCHAR(50) = (SELECT Nhan_Vien_HoTen FROM INSERTED)
	DECLARE @address NVARCHAR(50) = (SELECT Nhan_Vien_DiaChi FROM INSERTED)
	DECLARE @accountNumber INT = (SELECT Nhan_Vien_SoTK FROM INSERTED)

	DECLARE @age INT = (SELECT  FLOOR(DATEDIFF(DAY,@birthdate, GETDATE()) / 365.25))

	IF NOT EXISTS(SELECT * FROM Nhan_Vien WHERE Nhan_Vien_MaNV = @empId)
		PRINT(N'Mã nhân viên không xu?t hi?n trong b?ng!')
	ELSE IF @age < 18
		PRINT(N'Nhân viên không ?? 18 tu?i !')
	ELSE
		BEGIN
			UPDATE Nhan_Vien 
				SET Nhan_Vien_CMND = @ssn, 
					Nhan_Vien_NgaySinh = @birThdate,
					Nhan_Vien_HoTen = @name,
					Nhan_Vien_DiaChi = @address,
					Nhan_Vien_SoTK = @accountNumber
				WHERE Nhan_Vien_MaNV = @empId
			IF @age > 60
			BEGIN
				PRINT(N'Nhân viên có ?? tu?i không phù h?p ?? ti?p t?c làm vi?c.')
				UPDATE NV_ChiNhanh 
					SET NhanVien_ChiNhanh_ConLamHayKo = 0
					WHERE NhanVien_ChiNhanh_MaNV = @empId
				PRINT(N'?ã cho nhân viên ngh? vi?c.')
			END
		END
END
--GO
--UPDATE Nhan_Vien 
--	SET Nhan_Vien_NgaySinh = '19550130'
--	WHERE Nhan_Vien_MaNV = 'NV6'

GO

--DROP TRIGGER employee_delete_trigger
--GO
CREATE TRIGGER employee_delete_trigger ON Nhan_Vien
AFTER DELETE
AS 
BEGIN
	DECLARE @empId CHAR(9) = (SELECT Nhan_Vien_MaNV FROM deleted)
	DELETE FROM NV_ChiNhanh WHERE NhanVien_ChiNhanh_MaNV = @empId
	DELETE FROM NV_SDT WHERE NhanVien_SDT_MaNV = @empId
	DELETE FROM NVIEN_Email WHERE NhanVien_Email_MaNV = @empId
END
--GO
--DELETE FROM Nhan_Vien WHERE Nhan_Vien_MaNV = 'NV4'