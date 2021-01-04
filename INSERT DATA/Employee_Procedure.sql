--DROP PROCEDURE p_employee_search
--GO
--CREATE PROCEDURE  p_employee_search
--	@id CHAR(9)
--AS
--BEGIN
--	SET NOCOUNT ON
--	IF NOT EXISTS(SELECT * FROM Nhan_Vien WHERE Nhan_Vien_MaNV = @id)
--	BEGIN
--		PRINT(N'Không tìm thấy mã nhân viên !');
--		RETURN 0;
--	END
	
--	SELECT TOP 1 Nhan_Vien_HoTen,Nhan_Vien_CMND,Nhan_Vien_NgaySinh,Nhan_Vien_NgayVaoLam,NhanVien_ChiNhanh_MaCN AS MaCN
--		,NhanVien_ChiNhanh_ThoiGianBDLam,NhanVien_ChiNhanh_ConLamHayKo AS ConLamHayKo 
--		FROM Nhan_Vien INNER JOIN NV_ChiNhanh ON Nhan_Vien_MaNV = NhanVien_ChiNhanh_MaNV 
--			ORDER BY NhanVien_ChiNhanh_ThoiGianBDLam DESC;
--	RETURN @@ROWCOUNT
--END

--GO
--EXEC p_employee_search 'NV1'

DROP PROCEDURE p_employee_quitJob
GO
CREATE PROCEDURE  p_employee_quitJob
	@id CHAR(9)
AS
BEGIN
	SET NOCOUNT ON
	IF NOT EXISTS(SELECT * FROM NV_ChiNhanh WHERE NhanVien_ChiNhanh_MaNV = @id)
	BEGIN
		PRINT(N'Không tìm thấy mã nhân viên !');
		RETURN 0;
	END

	IF NOT EXISTS(SELECT * FROM NV_ChiNhanh WHERE NhanVien_ChiNhanh_MaNV = @id AND NhanVien_ChiNhanh_ConLamHayKo = 1)
	BEGIN
		PRINT(N'Nhân viên đã nghỉ việc từ trước hiện tại không còn làm việc !');
		RETURN 0;
	END
	
	UPDATE NV_ChiNhanh SET
		NhanVien_ChiNhanh_ConLamHayKo = 0 
			WHERE NhanVien_ChiNhanh_MaNV = @id AND NhanVien_ChiNhanh_ConLamHayKo = 1;
	PRINT(N'Đã cho nhân viên nghỉ việc')
	RETURN @@ROWCOUNT
END

GO
EXEC p_employee_quitJob 'NV2'