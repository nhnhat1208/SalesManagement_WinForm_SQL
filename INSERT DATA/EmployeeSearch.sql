--SELECT Nhan_Vien_MaNV,Nhan_Vien_HoTen,Nhan_Vien_NgayVaoLam, NhanVien_ChiNhanh_MaCN,NhanVien_ChiNhanh_ThoiGianBDLam,NhanVien_ChiNhanh_ConLamHayKo 
--	FROM Nhan_Vien INNER JOIN NV_ChiNhanh ON NhanVien_ChiNhanh_MaNV=Nhan_Vien_MaNV WHERE NhanVien_ChiNhanh_MaCN = 'CN1'
--	ORDER BY Nhan_Vien_MaNV ASC;

--SELECT Hoa_Don_Nhap_MaDN,Hoa_Don_Nhap_MaDaiLy,Hoa_Don_Nhap_TGNhap,Hoa_Don_Nhap_MaNV,NhanVien_ChiNhanh_MaCN
--	FROM NV_ChiNhanh INNER JOIN Hoa_Don_Nhap ON NhanVien_ChiNhanh_MaNV=Hoa_Don_Nhap_MaNV 
--	WHERE NhanVien_ChiNhanh_MaCN = 'CN2' ORDER BY Hoa_Don_Nhap_TGNhap DESC;

--SELECT COUNT(Nhan_Vien_MaNV) AS SoLuong, NhanVien_ChiNhanh_MaCN
--	FROM Nhan_Vien INNER JOIN NV_ChiNhanh ON NhanVien_ChiNhanh_MaNV=Nhan_Vien_MaNV 
--	WHERE NhanVien_ChiNhanh_ConLamHayKo = 1
--	GROUP BY NhanVien_ChiNhanh_MaCN
--	HAVING COUNT([NhanVien_ChiNhanh_MaNV]) > 1
--	ORDER BY NhanVien_ChiNhanh_MaCN ASC;

--SELECT NhanVien_ChiNhanh_MaCN, SUM(Hoa_Don_TienKhachDua-Hoa_Don_TienThua) AS DoanhThu
--	FROM Hoa_Don INNER JOIN NV_ChiNhanh ON NhanVien_ChiNhanh_MaNV=Hoa_Don_MaNV
--	WHERE Hoa_Don_NgayXuatDon > '20170101'
--	GROUP BY NhanVien_ChiNhanh_MaCN
--	HAVING SUM(Hoa_Don_TienKhachDua-Hoa_Don_TienThua) > 7000000
--	ORDER BY DoanhThu DESC;