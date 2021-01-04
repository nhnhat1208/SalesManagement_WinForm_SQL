INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])
    VALUES
			('KH01',
			N'Nguyễn Văn Hải',
			N'03 Quang Trung p.17 q.Gò Vấp tp.HCM')
INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])		
    VALUES 
			('KH02',
			N'Đặng Thành Ngân',
			N'854 Thống Nhất p.15 q.Gò Vấp tp.HCM')
INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])
    VALUES 
			('KH03',
			N'Phạm Thu Hương',
			N'232 Đinh Bộ Lĩnh p.26 q.Bình Thạnh tp.HCM')
INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])
    VALUES
           	('KH04',
 			N'Nguyễn Xuân Lộc',
			N'47 Nguyễn Tri Phương p.12 q.10 tp.HCM')
INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])
   VALUES
           	('KH05',
			N'Nguyễn Thị Tiên',
			N'143 Phạm Văn Đồng p.7 q.Gò Vấp tp.HCM')
INSERT INTO [dbo].[Khach_Hang]
           ([Khach_hang_MaKH]
           ,[Khach_hang_TenKH]
           ,[Khach_hang_DiaChi])
   VALUES
           	('KH06',
			N'Lê Quỳnh Như',
			N'03 Lý Thường Kiệt p.12 q.10 tp.HCM')

INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
           	('421527854'
          	 ,'20170220'
           	,'KH01')
INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
          	 ('715399649'
          	 ,'20160313'
           	,'KH02')
INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
           ('458595465'
           ,'20151203'
           ,'KH03')
INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
           ('455413560'
           ,'20170519'
           ,'KH04')
INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
           ('315562750'
           ,'20150521'
           ,'KH05')	
INSERT INTO [dbo].[TK_Ngan_Hang]
           ([TK_Ngan_Hang_SoTK]
           ,[TK_Ngan_Hang_Ngay_phat_hanh]
           ,[TK_Ngan_Hang_MaKH])
     VALUES
           ('134356542'
           ,'20150516'
           ,'KH06')
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV1'
           ,'13515611'
           ,N'Ðỗ Văn Ðô'
           ,'19951011'
           ,N'87A Hàm Nghi, Q.1, Tp.HCM'
           ,CONVERT(datetime, '09-02-2018', 105)
           ,'2156423' )
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV2'
           ,'45486456'
           ,N'Nguyễn Thị Lan'
           ,'20010612'
           ,N'95 Phan Xích Long, Phú Nhuận, Tp.HCM'
           ,CONVERT(datetime, '11-02-2018', 105)
           ,'5456466' )
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV3'
           ,'46299664'
           ,N'Đỗ Thị Hoa'
           ,'19900718'
           ,N'102a Trương Định, Q.3, Tp.HCM'
           , CONVERT(datetime, '28-07-2019', 105)
           ,'5165416' )
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV4'
           ,'20515761'
           ,N'Phan Văn Tiến'
           ,'20000602'
           ,N'201 Điện Biên Phủ, Bình Thạnh, Tp.HCM'
           ,CONVERT(datetime, '29-07-2019', 105)
           ,'2756523' )
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV5'
           ,'25325791'
           ,N'Nguyễn Thị Hồng'
           ,'19990825'
           ,N'129 Nguyễn Văn Công, Gò Vấp, Tp.HCM'
           ,CONVERT(datetime, '30-07-2019', 105)
           ,'1976420' )
INSERT INTO [dbo].[Nhan_Vien]
           ([Nhan_Vien_MaNV]
           ,[Nhan_Vien_CMND]
           ,[Nhan_Vien_HoTen]
           ,[Nhan_Vien_NgaySinh]
           ,[Nhan_Vien_DiaChi]
           ,[Nhan_Vien_NgayVaoLam]
           ,[Nhan_Vien_SoTK])
     VALUES
           ('NV6'
           ,'12420680'
           ,N'Vũ Văn Huy'
           ,'19920313'
           ,N'124 Phan Huy Ích, Tân Bình, Tp.HCM'
           ,CONVERT(datetime, '12-08-2019', 105)
           ,'4776280' )
INSERT INTO [dbo].[Chi_Nhanh]
           ([Chi_Nhanh_MaCN]
           ,[Chi_Nhanh_TenCN]
           ,[Chi_Nhanh_DiaChi]
           ,[Chi_Nhanh_NgayMo]
           ,[Chi_Nhanh_MaNVQL])
     VALUES
           ('CN1'
           ,'DienMay_quan 7'
           ,N'16, Nguyễn Huy, Q.7, HCM'
           ,'20150210'
           ,'NV1')
INSERT INTO [dbo].[Chi_Nhanh]
           ([Chi_Nhanh_MaCN]
           ,[Chi_Nhanh_TenCN]
           ,[Chi_Nhanh_DiaChi]
           ,[Chi_Nhanh_NgayMo]
           ,[Chi_Nhanh_MaNVQL])
     VALUES
           ('CN2'
           ,'DienMay_quan 2'
           ,N'55, Lê Lợi, Q.2, HCM'
           ,'20161002'
           ,'NV3')
INSERT INTO [dbo].[Chi_Nhanh]
           ([Chi_Nhanh_MaCN]
           ,[Chi_Nhanh_TenCN]
           ,[Chi_Nhanh_DiaChi]
           ,[Chi_Nhanh_NgayMo]
           ,[Chi_Nhanh_MaNVQL])
     VALUES
           ('CN3'
           ,'DienMay_Go Vap'
           ,N'854 Thống Nhất, Q.Gò Vấp, HCM'
           ,'20161205'
           ,'NV4')
INSERT INTO [dbo].[Chi_Nhanh]
           ([Chi_Nhanh_MaCN]
           ,[Chi_Nhanh_TenCN]
           ,[Chi_Nhanh_DiaChi]
           ,[Chi_Nhanh_NgayMo]
           ,[Chi_Nhanh_MaNVQL])
     VALUES
           ('CN4'
           ,'DienMay_Binh Thanh'
           ,N'283 Đinh Bộ Lĩnh, Q.Bình Thạnh, HCM'
           ,'20180609'
           ,'NV6')
INSERT INTO [dbo].[Chi_Nhanh]
           ([Chi_Nhanh_MaCN]
           ,[Chi_Nhanh_TenCN]
           ,[Chi_Nhanh_DiaChi]
           ,[Chi_Nhanh_NgayMo]
           ,[Chi_Nhanh_MaNVQL])
     VALUES
           ('CN5'
           ,'DienMay_Thu Duc'
           ,N'232 Kha Vạn Cân, Q.Thủ Đức, HCM'
           ,'20200918'
           ,'NV2')


INSERT INTO [dbo].[Phuong_Thuc_Thanh_Toan]
           ([Phuong_Thuc_Thanh_Toan_MaPT]
           ,[Phuong_Thuc_Thanh_Toan_TenPT])
     VALUES
           ('PT1'
           ,N'Tiền mặt')
INSERT INTO [dbo].[Phuong_Thuc_Thanh_Toan]
           ([Phuong_Thuc_Thanh_Toan_MaPT]
           ,[Phuong_Thuc_Thanh_Toan_TenPT])
     VALUES
           ('PT2'
           ,N'Ví điện tử')
INSERT INTO [dbo].[Phuong_Thuc_Thanh_Toan]
           ([Phuong_Thuc_Thanh_Toan_MaPT]
           ,[Phuong_Thuc_Thanh_Toan_TenPT])
     VALUES
           ('PT3'
           ,N'Thẻ tín dụng')

INSERT INTO [dbo].[Phuong_Thuc_Giao_Hang]
           ([Phuong_Thuc_Giao_Hang_MaPT]
           ,[Phuong_Thuc_Giao_Hang_TenPT])
     VALUES
           ('GH1'
           ,N'Không giao hàng')
INSERT INTO [dbo].[Phuong_Thuc_Giao_Hang]
           ([Phuong_Thuc_Giao_Hang_MaPT]
           ,[Phuong_Thuc_Giao_Hang_TenPT])
     VALUES
           ('GH2'
           ,N'Giao hàng tận nhà')

INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ1'
           ,'20181020'
           ,'20181020'
           ,'HT'
           ,'KH01'
           ,'GH1'
           ,'NV1'
           ,'PT1'
           ,1000000
           ,50000
           ,'GD1'
           ,'')
INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ2'
           ,'20190103'
           ,'20190104'
           ,'HT'
           ,'KH02'
           ,'GH1'
           ,'NV2'
           ,'PT2'
           ,2200000
           ,0
           ,'GD2'
           ,N'Dễ vỡ')
INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ3'
           ,'20201104'
           ,'20201104'
           ,'HT'
           ,'KH02'
           ,'GH2'
           ,'NV3'
           ,'PT2'
           ,1500000
           ,0
           ,'GD3'
           ,'')
INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ4'
           ,'20201201'
           ,'20201202'
           ,'HT'
           ,'KH03'
           ,'GH2'
           ,'NV4'
           ,'PT2'
           ,3000000
           ,0
           ,'GD4'
           ,N'Dễ vỡ')
INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ5'
           ,'20201203'
           ,'20201204'
           ,'HT'
           ,'KH04'
           ,'GH2'
           ,'NV5'
           ,'PT2'
           ,7000000
           ,0
           ,'GD'
           ,N'Dễ vỡ')
INSERT INTO [dbo].[Hoa_Don]
           ([Hoa_Don_MaHD]
           ,[Hoa_Don_NgayDatHang]
           ,[Hoa_Don_NgayXuatDon]
           ,[Hoa_Don_TinhTrangDon]
           ,[Hoa_Don_MaKH]
           ,[Hoa_Don_MaPTGH]
           ,[Hoa_Don_MaNV]
           ,[Hoa_Don_MaPT_ThanhToan]
           ,[Hoa_Don_TienKhachDua]
           ,[Hoa_Don_TienThua]
           ,[Hoa_Don_MaGiaoDich]
           ,[Hoa_Don_GhiChu])
     VALUES
           (N'HĐ6'
           ,'20201207'
           ,'20201208'
           ,'HT'
           ,'KH05'
           ,'GH2'
           ,'NV6'
           ,'PT2'
           ,4500000
           ,0
           ,'GD6'
           ,N'Dễ vỡ')

INSERT INTO [dbo].[Hoa_Don_Truc_Tiep]
           ([Hoa_Don_Truc_Tiep_MaHD]
           ,[Hoa_Don_Truc_Tiep_MaCN])
     VALUES
           (N'HĐ1'
           ,'CN2')

INSERT INTO [dbo].[Hoa_Don_Truc_Tuyen]
           ([Hoa_Don_Truc_Tuyen_MaHD])
     VALUES
           ('ON1')
INSERT INTO [dbo].[Hoa_Don_Truc_Tuyen]
           ([Hoa_Don_Truc_Tuyen_MaHD])
     VALUES
           ('ON2')

INSERT INTO [dbo].[Dai_ly_Phan_Phoi]
           ([Dai_ly_Phan_Phoi_MaDL]
           ,[Dai_ly_Phan_Phoi_TenDL]
           ,[Dai_ly_Phan_Phoi_DiaChi])
     VALUES
           (N'ĐL1'
           ,'KQC'
           ,N'12, Thành Thái, p.14, Q.10, HCM')
INSERT INTO [dbo].[Dai_ly_Phan_Phoi]
           ([Dai_ly_Phan_Phoi_MaDL]
           ,[Dai_ly_Phan_Phoi_TenDL]
           ,[Dai_ly_Phan_Phoi_DiaChi])
     VALUES
           (N'ĐL2'
           ,'OKKK'
           ,N'33,Lý Thái Tổ, p.1, Q.3, HCM')

INSERT INTO [dbo].[Hoa_Don_Nhap]
           ([Hoa_Don_Nhap_MaDN]
           ,[Hoa_Don_Nhap_TGNhap]
           ,[Hoa_Don_Nhap_MaNV]
           ,[Hoa_Don_Nhap_MaDaiLy])
     VALUES
           (N'ĐN1'
           ,'20200910'
           ,'NV1'
           ,N'ĐL1')
INSERT INTO [dbo].[Hoa_Don_Nhap]
           ([Hoa_Don_Nhap_MaDN]
           ,[Hoa_Don_Nhap_TGNhap]
           ,[Hoa_Don_Nhap_MaNV]
           ,[Hoa_Don_Nhap_MaDaiLy])
     VALUES
           (N'ĐN2'
           ,'20200921'
           ,'NV3'
           ,N'ĐL2')
INSERT INTO [dbo].[Hoa_Don_Nhap]
           ([Hoa_Don_Nhap_MaDN]
           ,[Hoa_Don_Nhap_TGNhap]
           ,[Hoa_Don_Nhap_MaNV]
           ,[Hoa_Don_Nhap_MaDaiLy])
     VALUES
           (N'ĐN3'
           ,'20201121'
           ,'NV4'
           ,N'ĐL2')
INSERT INTO [dbo].[Hoa_Don_Nhap]
           ([Hoa_Don_Nhap_MaDN]
           ,[Hoa_Don_Nhap_TGNhap]
           ,[Hoa_Don_Nhap_MaNV]
           ,[Hoa_Don_Nhap_MaDaiLy])
     VALUES
           (N'ĐN4'
           ,'20200609'
           ,'NV6'
           ,N'ĐL1')
INSERT INTO [dbo].[Hoa_Don_Nhap]
           ([Hoa_Don_Nhap_MaDN]
           ,[Hoa_Don_Nhap_TGNhap]
           ,[Hoa_Don_Nhap_MaNV]
           ,[Hoa_Don_Nhap_MaDaiLy])
     VALUES
           (N'ĐN5'
           ,'20200918'
           ,'NV2'
           ,N'ĐL2')

INSERT INTO [dbo].[Loai_San_Pham]
           ([Loai_San_Pham_MaLoai]
           ,[Loai_San_Pham_TenLoai])
     VALUES
           ('L1'
           ,N'Đồ điện dân dụng')
INSERT INTO [dbo].[Loai_San_Pham]
           ([Loai_San_Pham_MaLoai]
           ,[Loai_San_Pham_TenLoai])
     VALUES
           ('L2'
           ,N'Điện lạnh')
INSERT INTO [dbo].[Loai_San_Pham]
           ([Loai_San_Pham_MaLoai]
           ,[Loai_San_Pham_TenLoai])
     VALUES
           ('L3'
           ,N'Điện tử')
INSERT INTO [dbo].[Loai_San_Pham]
           ([Loai_San_Pham_MaLoai]
           ,[Loai_San_Pham_TenLoai])
     VALUES
           ('L4'
           ,N'Đồ dân dụng')
INSERT INTO [dbo].[Loai_San_Pham]
           ([Loai_San_Pham_MaLoai]
           ,[Loai_San_Pham_TenLoai])
     VALUES
           ('L5'
           ,N'Linh kiện điện tử')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP1'
           ,N'Ấm điện'
           ,'Philip'
           ,N'Xám'
           ,'Inox'
           ,'L1')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP2'
           ,N'Máy quạt'
           ,'Senko'
           ,N'Xanh'
           ,N'Nhựa'
           ,'L1')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP3'
           ,N'Tủ lạnh'
           ,'Samsung'
           ,N'Đen'
           ,N'Hợp kim'
           ,'L2')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP4'
           ,N'Nồi'
           ,'Sunhouse'
           ,N'Đen'
           ,'Inox'
           ,'L4')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP5'
           ,N'Laptop'
           ,'Asus'
           ,N'Xám'
           ,N'Hợp kim'
           ,'L3')
INSERT INTO [dbo].[San_Pham]
           ([San_Pham_MaSP]
           ,[San_Pham_TenSP]
           ,[San_Pham_HangSX]
           ,[San_Pham_MauSac]
           ,[San_Pham_ChatLieu]
           ,[San_Pham_MaLoai])
     VALUES
           ('SP6'
           ,N'SSD(ổ cứng)'
           ,'Del'
           ,N'Trắng'
           ,N'Hợp kim'
           ,'L5')
INSERT INTO [dbo].[Don_Vi_Van_Chuyen]
           ([Don_Vi_Van_Chuyen_MaDV]
           ,[Don_Vi_Van_Chuyen_TenDV])
     VALUES
           ('VC1'
           ,N'Giao hàng tiết kiệm')
INSERT INTO [dbo].[Don_Vi_Van_Chuyen]
           ([Don_Vi_Van_Chuyen_MaDV]
           ,[Don_Vi_Van_Chuyen_TenDV])
     VALUES
           ('VC2'
           ,N'Giao hàng nhanh')

INSERT INTO [dbo].[Phuong_Tien]
           ([Phuong_Tien_MaPT]
           ,[Phuong_Tien_BienSoPT])
     VALUES
           ('PTI1'
           ,'51A-23456')
INSERT INTO [dbo].[Phuong_Tien]
           ([Phuong_Tien_MaPT]
           ,[Phuong_Tien_BienSoPT])
     VALUES
           ('PTI2'
           ,'55V-86564')
INSERT INTO [dbo].[Phuong_Tien]
           ([Phuong_Tien_MaPT]
           ,[Phuong_Tien_BienSoPT])
     VALUES
           ('PTI3'
           ,'71-C405677')
INSERT INTO [dbo].[Phuong_Tien]
           ([Phuong_Tien_MaPT]
           ,[Phuong_Tien_BienSoPT])
     VALUES
           ('PTI4'
           ,'86-A567778')
INSERT INTO [dbo].[Phuong_Tien]
           ([Phuong_Tien_MaPT]
           ,[Phuong_Tien_BienSoPT])
     VALUES
           ('PTI5'
           ,'77-F123567')

INSERT INTO [dbo].[Xe_Tai]
           ([Xe_Tai_MaPT])
     VALUES
           ('PTI1')
INSERT INTO [dbo].[Xe_Tai]
           ([Xe_Tai_MaPT])
     VALUES
           ('PTI3')

INSERT INTO [dbo].[Tai_Xe]
           ([Tai_Xe_MaTX]
           ,[Tai_Xe_CMND]
           ,[Tai_Xe_NgaySinh]
           ,[Tai_Xe_SoBangLai]
           ,[Tai_Xe_HoTen])
     VALUES
           ('TX1'
           ,'634567381'
           ,'19900406'
           ,'4745578'
           ,N'Nguyễn Văn Hậu')
INSERT INTO [dbo].[Tai_Xe]
           ([Tai_Xe_MaTX]
           ,[Tai_Xe_CMND]
           ,[Tai_Xe_NgaySinh]
           ,[Tai_Xe_SoBangLai]
           ,[Tai_Xe_HoTen])
     VALUES
           ('TX2'
           ,'767565443'
           ,'19870522'
           ,'4656322'
           ,N'Mai Thị Ly')
INSERT INTO [dbo].[Tai_Xe]
           ([Tai_Xe_MaTX]
           ,[Tai_Xe_CMND]
           ,[Tai_Xe_NgaySinh]
           ,[Tai_Xe_SoBangLai]
           ,[Tai_Xe_HoTen])
     VALUES
           ('TX3'
           ,'768503443'
           ,'19900506'
           ,'4885578'
           ,N'Phan Văn Tuấn')
INSERT INTO [dbo].[Tai_Xe]
           ([Tai_Xe_MaTX]
           ,[Tai_Xe_CMND]
           ,[Tai_Xe_NgaySinh]
           ,[Tai_Xe_SoBangLai]
           ,[Tai_Xe_HoTen])
     VALUES
           ('TX4'
           ,'767508423'
           ,'19990612'
           ,'5045328'
           ,N'Nguyễn Thị Chương')
INSERT INTO [dbo].[Tai_Xe]
           ([Tai_Xe_MaTX]
           ,[Tai_Xe_CMND]
           ,[Tai_Xe_NgaySinh]
           ,[Tai_Xe_SoBangLai]
           ,[Tai_Xe_HoTen])
     VALUES
           ('TX5'
           ,'886663443'
           ,'19950713'
           ,'5045328'
           ,N'Trần Trung Hiếu')

INSERT INTO [dbo].[Xe_May]
           ([Xe_May_MaPT]
           ,[Xe_May_MaTX])
     VALUES
           ('PTI2'
           ,'TX1')
INSERT INTO [dbo].[Xe_May]
           ([Xe_May_MaPT]
           ,[Xe_May_MaTX])
     VALUES
           ('PTI4'
           ,'TX3')
INSERT INTO [dbo].[Xe_May]
           ([Xe_May_MaPT]
           ,[Xe_May_MaTX])
     VALUES
           ('PTI5'
           ,'TX2')
INSERT INTO Don_Van VALUES (N'HĐ2', 411, CONVERT(datetime, '04-01-2019', 105), N'Không', 'VC1',
							N'52, Hoàng Hoa Thám, p.14, Q.2, tp.HCM', 50, 
							CONVERT(datetime, '04-01-2019', 105), 
							CONVERT(datetime, '05-01-2019', 105),
							CONVERT(datetime, '05-01-2019', 105));
INSERT INTO Don_Van VALUES (N'HĐ3', 412, CONVERT(datetime, '04-11-2020', 105), N'Không', 'VC2',
							N'99, Quang Trung, p.2, Q.7, tp.HCM', 100, 
							CONVERT(datetime, '04-11-2020', 105), 
							CONVERT(datetime, '04-11-2020', 105),
							CONVERT(datetime, '04-11-2020', 105));
INSERT INTO Don_Van VALUES (N'HĐ4', 413, CONVERT(datetime, '04-11-2020', 105), N'Không', 'VC1',
							N'123/3, Lê Lợi, p.Bến Nghé, Q.1, tp.HCM', 125, 
							CONVERT(datetime, '04-11-2020', 105), 
							CONVERT(datetime, '05-11-2020', 105),
							CONVERT(datetime, '07-11-2020', 105));
INSERT INTO Don_Van VALUES (N'HĐ5', 414, CONVERT(datetime, '05-11-2020', 105), N'Không', 'VC2',
							N'49, Đ48, Hiệp Bình Chánh, Q.Thủ Đức, tp.HCM', 90, 
							CONVERT(datetime, '05-11-2020', 105), 
							CONVERT(datetime, '05-11-2020', 105),
							CONVERT(datetime, '06-11-2020', 105));
INSERT INTO Don_Van VALUES (N'HĐ6', 415, CONVERT(datetime, '05-11-2020', 105), N'Không', 'VC1',
							N'87A Hàm Nghi, Nguyễn Thái Bình, Q.1, tp.HCM', 57, 
							CONVERT(datetime, '05-11-2020', 105), 
							CONVERT(datetime, '05-11-2020', 105),
							CONVERT(datetime, '05-11-2020', 105));

INSERT INTO Bang_Giasp VALUES ('SP1', 'G11', 400, N'Gốc', '', 
								CONVERT(datetime, '02-12-2018', 105), '');
INSERT INTO Bang_Giasp VALUES ('SP2', 'G22', 1000, N'Gốc', '', 
								CONVERT(datetime, '04-08-2018', 105), '');
INSERT INTO Bang_Giasp VALUES ('SP3', 'G33', 1800, N'Gốc', '', 
								CONVERT(datetime, '09-01-2019', 105), '');
INSERT INTO Bang_Giasp VALUES ('SP3', 'G44', 1500, N'KM', '', 
								CONVERT(datetime, '02-11-2019', 105), CONVERT(datetime, '01-04-2020', 105));
INSERT INTO Bang_Giasp VALUES ('SP4', 'G55', 700, N'Gốc', '', 
								CONVERT(datetime, '01-01-2020', 105), '');

INSERT INTO NV_ChiNhanh VALUES ('NV1', 'CN1', CONVERT(datetime, '09-02-2018', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV2', 'CN1', CONVERT(datetime, '11-02-2018', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV3', 'CN1', CONVERT(datetime, '28-07-2019', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV4', 'CN1', CONVERT(datetime, '29-07-2019', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV5', 'CN2', CONVERT(datetime, '30-07-2019', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV6', 'CN2', CONVERT(datetime, '12-08-2019', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV2', 'CN2', CONVERT(datetime, '29-07-2019', 105), 1);
INSERT INTO NV_ChiNhanh VALUES ('NV1', 'CN2', CONVERT(datetime, '20-09-2019', 105), 0);

INSERT INTO DVan_ChiNhanh VALUES ('HĐ2', 411, 'CN1');
INSERT INTO DVan_ChiNhanh VALUES ('HĐ3', 412, 'CN2');
INSERT INTO DVan_ChiNhanh VALUES ('HĐ4', 413, 'CN1');
INSERT INTO DVan_ChiNhanh VALUES ('HĐ5', 414, 'CN2');
INSERT INTO DVan_ChiNhanh VALUES ('HĐ6', 415, 'CN2');

INSERT INTO DVan_SanPham VALUES ('HĐ2', 411, 'SP1', 1);
INSERT INTO DVan_SanPham VALUES ('HĐ2', 411, 'SP3', 1);
INSERT INTO DVan_SanPham VALUES ('HĐ3', 412, 'SP3', 1);
INSERT INTO DVan_SanPham VALUES ('HĐ3', 412, 'SP1', 2);
INSERT INTO DVan_SanPham VALUES ('HĐ4', 413, 'SP2', 3);

INSERT INTO SP_HoaDonNhap VALUES ('SP1', 'ĐN1', 200, 15);
INSERT INTO SP_HoaDonNhap VALUES ('SP2', 'ĐN1', 700, 10);
INSERT INTO SP_HoaDonNhap VALUES ('SP3', 'ĐN1', 1400, 7);
INSERT INTO SP_HoaDonNhap VALUES ('SP1', 'ĐN2', 200, 40);
INSERT INTO SP_HoaDonNhap VALUES ('SP2', 'ĐN2', 670, 32);

INSERT INTO DaiLyPhanPhoi_SanPham VALUES ('ĐL1', 'SP1');
INSERT INTO DaiLyPhanPhoi_SanPham VALUES ('ĐL1', 'SP2');
INSERT INTO DaiLyPhanPhoi_SanPham VALUES ('ĐL2', 'SP3');

INSERT INTO KH_SDT VALUES ('KH01','0986736247');
INSERT INTO KH_SDT VALUES ('KH01','0923194299');
INSERT INTO KH_SDT VALUES ('KH01','0723138881');
INSERT INTO KH_SDT VALUES ('KH02','0129999124');
INSERT INTO KH_SDT VALUES ('KH03','0400120010');

INSERT INTO KH_Email VALUES ('KH01','gsvgs@gmail.com');
INSERT INTO KH_Email VALUES ('KH01','gtnsa@gmail.com');
INSERT INTO KH_Email VALUES ('KH02','nhantjd@gmail.com');
INSERT INTO KH_Email VALUES ('KH02','fiths@gmail.com');
INSERT INTO KH_Email VALUES ('KH03','asd124@gmail.com');

INSERT INTO NV_SDT VALUES ('NV1','0129921313');
INSERT INTO NV_SDT VALUES ('NV1','0921000021');
INSERT INTO NV_SDT VALUES ('NV2','0191299965');
INSERT INTO NV_SDT VALUES ('NV2','0125553246');
INSERT INTO NV_SDT VALUES ('NV3','0792390001');
INSERT INTO NV_SDT VALUES ('NV4','0792210001');
INSERT INTO NV_SDT VALUES ('NV4','0792210141');
INSERT INTO NV_SDT VALUES ('NV5','0122390001');
INSERT INTO NV_SDT VALUES ('NV6','0462390001');
INSERT INTO NV_SDT VALUES ('NV6','0421460001');

INSERT INTO NVIEN_Email VALUES ('NV1','nv1ws@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV1','nv1sws@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV1','nv1@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV2','nv2@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV3','nhhong22@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV3','hongnh22@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV4','njasmine@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV4','njasmine12x@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV5','nhpoision@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV5','poisio2n@gmail.com');
INSERT INTO NVIEN_Email VALUES ('NV6','nh123api@gmail.com');

INSERT INTO CNhanh_SDT VALUES ('CN1','18002999');
INSERT INTO CNhanh_SDT VALUES ('CN1','0129993828');
INSERT INTO CNhanh_SDT VALUES ('CN2','18002969');
INSERT INTO CNhanh_SDT VALUES ('CN2','0123573428');

INSERT INTO DaiLyPhanPhoi_SDT VALUES ('ĐL1','0734627737');
INSERT INTO DaiLyPhanPhoi_SDT VALUES ('ĐL2','0764964367');
INSERT INTO DaiLyPhanPhoi_SDT VALUES ('ĐL2','0637727387');

INSERT INTO DaiLyPhanPhoi_Email VALUES ('ĐL1','dailyqqwe@gmail.com');
INSERT INTO DaiLyPhanPhoi_Email VALUES ('ĐL1','dailydmls@gmail.com');
INSERT INTO DaiLyPhanPhoi_Email VALUES ('ĐL2','daily12mn@gmail.com');

INSERT INTO TXe_SDT VALUES ('TX1','0748456632');
INSERT INTO TXe_SDT VALUES ('TX2','0365345434');
INSERT INTO TXe_SDT VALUES ('TX2','0864443345');
INSERT INTO TXe_SDT VALUES ('TX2','0999912991');

INSERT INTO DVVC_SDT VALUES ('VC1','0274367263');
INSERT INTO DVVC_SDT VALUES ('VC1','0173646838');
INSERT INTO DVVC_SDT VALUES ('VC2','0987543258');
INSERT INTO DVVC_SDT VALUES ('VC2','0764356365');

INSERT INTO DVVC_Email VALUES ('VC1','giaohangtietkiem@gmail.com');
INSERT INTO DVVC_Email VALUES ('VC1','ghtk7868@gmail.com');
INSERT INTO DVVC_Email VALUES ('VC2','giaohangnhanh@gmail.com');
INSERT INTO DVVC_Email VALUES ('VC2','ghnfast@gmail.com');

INSERT INTO DVVC_DonVan_ViTriDonHang VALUES ('VC1', 'HĐ3', 412, N'Nhập kho vận chuyển');
INSERT INTO DVVC_DonVan_ViTriDonHang VALUES ('VC1', 'HĐ3', 412, N'Xuất kho vận chuyển');
INSERT INTO DVVC_DonVan_ViTriDonHang VALUES ('VC1', 'HĐ3', 412, N'Đã giao cho khách');
INSERT INTO DVVC_DonVan_ViTriDonHang VALUES ('VC1', 'HĐ4', 413, N'Nhập kho vận chuyển');
INSERT INTO DVVC_DonVan_ViTriDonHang VALUES ('VC1', 'HĐ4', 413, N'Xuất kho vận chuyển');

INSERT INTO VChuyen_ViTriDonHang VALUES ('TX1', 'HĐ3', 412, N'Xuất tại cửa hàng');
INSERT INTO VChuyen_ViTriDonHang VALUES ('TX1', 'HĐ3', 412, N'Đã giao cho khách');
INSERT INTO VChuyen_ViTriDonHang VALUES ('TX2', 'HĐ4', 413, N'Xuất tại cửa hàng');
INSERT INTO VChuyen_ViTriDonHang VALUES ('TX2', 'HĐ4', 413, N'Đang trên đường vận chuyển');
INSERT INTO VChuyen_ViTriDonHang VALUES ('TX2', 'HĐ4', 413, N'Đã giao cho khách');

INSERT INTO VanChuyen VALUES ('TX1','HĐ3',412,'PTI2',CONVERT(datetime, '04-11-2020', 105), 
							CONVERT(datetime, '04-11-2020', 105),N'Không',5.3)
INSERT INTO VanChuyen VALUES ('TX2','HĐ4',413,'PTI1',CONVERT(datetime, '05-11-2020', 105), 
							CONVERT(datetime, '07-11-2020', 105),N'Không',10.25)
INSERT INTO VanChuyen VALUES ('TX1','HĐ5',414,'PTI2',CONVERT(datetime, '05-11-2020', 105), 
							CONVERT(datetime, '06-11-2020', 105),N'Không',7.9)
INSERT INTO VanChuyen VALUES ('TX2','HĐ6',415,'PTI1',CONVERT(datetime, '05-11-2020', 105), 
							CONVERT(datetime, '05-11-2020', 105),N'Không',14.25)

INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ1','SP2','G22',1,1000);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ2','SP1','G11',1,400);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ2','SP3','G33',1,1800);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ3','SP3','G44',1,1500);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ4','SP2','G22',3,1000);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ5','SP2','G22',4,1000);
INSERT INTO HDon_SanPham_BangGia VALUES (N'HĐ6','SP2','G22',3,1000);
 
 Create INDEX id_Khach_Hang_MaKH
 on Khach_Hang ( Khach_Hang_MaKH);
 Create INDEX id_Hoa_Don_MaHD
 on Hoa_Don ( Hoa_Don_MaHD);
 create INDEX id_San_Pham_MaSP
 on San_Pham ( San_Pham_MaSP);
