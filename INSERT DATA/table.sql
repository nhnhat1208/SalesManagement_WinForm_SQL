
CREATE TABLE Khach_Hang
( Khach_hang_MaKH Char(9) PRIMARY KEY,
  Khach_hang_TenKH NVarchar(50) NOT NULL,
  Khach_hang_DiaChi NVarchar(50) NOT NULL,
);

CREATE TABLE TK_Ngan_Hang
( TK_Ngan_Hang_SoTK Char(9) PRIMARY KEY,
   TK_Ngan_Hang_Ngay_phat_hanh DATETIME not null,
   TK_Ngan_Hang_MaKH Char(9) not null,
   CONSTRAINT fk_tknghang_MaKH FOREIGN KEY (TK_Ngan_Hang_MaKH) REFERENCES Khach_Hang(Khach_hang_MaKH) ON DELETE CASCADE
);

CREATE TABLE Nhan_Vien
( Nhan_Vien_MaNV CHAR(9) PRIMARY KEY,
  Nhan_Vien_CMND VARCHAR(20) UNIQUE,
  Nhan_Vien_HoTen NVARCHAR(50) NOT NULL,
  Nhan_Vien_NgaySinh DATETIME NOT NULL,
  Nhan_Vien_DiaChi NVARCHAR(50) NOT NULL,
  Nhan_Vien_NgayVaoLam DATETIME NOT NULL,
  Nhan_Vien_SoTK INT NOT NULL,
);

CREATE TABLE Chi_Nhanh
( Chi_Nhanh_MaCN CHAR(4) PRIMARY KEY,
  Chi_Nhanh_TenCN NVARCHAR(20) NOT NULL,
  Chi_Nhanh_DiaChi NVARCHAR(50) NOT NULL,
  Chi_Nhanh_NgayMo DATETIME NOT NULL,
  Chi_Nhanh_MaNVQL CHAR(9) NOT NULL,
  CONSTRAINT fk_MaNVQL FOREIGN KEY(Chi_Nhanh_MaNVQL) REFERENCES Nhan_Vien(Nhan_Vien_MaNV) on delete cascade
);--CHECK
CREATE TABLE Phuong_Thuc_Thanh_Toan
( Phuong_Thuc_Thanh_Toan_MaPT varchar(20) primary key,
  Phuong_Thuc_Thanh_Toan_TenPT nvarchar(20) not null,
 );
 CREATE TABLE Phuong_Thuc_Giao_Hang
 ( Phuong_Thuc_Giao_Hang_MaPT varchar(20) primary key,
   Phuong_Thuc_Giao_Hang_TenPT nvarchar(20) not null,
);
CREATE TABLE Hoa_Don
( Hoa_Don_MaHD NVARCHAR(20) PRIMARY KEY,
  Hoa_Don_NgayDatHang DATETIME NOT NULL,
  Hoa_Don_NgayXuatDon DATETIME NOT NULL,
  Hoa_Don_TinhTrangDon NVarchar(20) NOT NULL,
  Hoa_Don_MaKH CHAR(9) NOT NULL,
  Hoa_Don_MaPTGH VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Phuong_Thuc_Giao_Hang(Phuong_Thuc_Giao_Hang_MaPT) ON DELETE CASCADE,
  Hoa_Don_MaNV CHAR(9) NOT NULL FOREIGN KEY REFERENCES Nhan_Vien(Nhan_Vien_MaNV) ON DELETE CASCADE,
  Hoa_Don_MaPT_ThanhToan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Phuong_Thuc_Thanh_Toan(Phuong_Thuc_Thanh_Toan_MaPT) ON DELETE CASCADE,
  Hoa_Don_TienKhachDua MONEY NOT NULL,
  Hoa_Don_TienThua MONEY NOT NULL,
  Hoa_Don_MaGiaoDich Varchar(20),
  Hoa_Don_GhiChu NVARCHAR(20),
  CONSTRAINT fk_HoaDonMaKH FOREIGN KEY(Hoa_Don_MaKH) REFERENCES Khach_Hang(Khach_hang_MaKH) on delete cascade
);
CREATE TABLE Hoa_Don_Truc_Tiep
( Hoa_Don_Truc_Tiep_MaHD NVarchar(20) PRIMARY KEY,
  Hoa_Don_Truc_Tiep_MaCN varchar(20) NOT NULL,
);
CREATE TABLE Hoa_Don_Truc_Tuyen
( Hoa_Don_Truc_Tuyen_MaHD NVarchar(20) PRIMARY KEY,
);

 
CREATE TABLE Dai_ly_Phan_Phoi
( Dai_ly_Phan_Phoi_MaDL NVARCHAR(20) PRIMARY KEY,
  Dai_ly_Phan_Phoi_TenDL NVARCHAR(50) NOT NULL,
  Dai_ly_Phan_Phoi_DiaChi NVARCHAR(50) NOT NULL,
);
CREATE TABLE Hoa_Don_Nhap 
( Hoa_Don_Nhap_MaDN nvarchar(20) PRIMARY KEY,
  Hoa_Don_Nhap_TGNhap DATETIME NOT NULL,
  Hoa_Don_Nhap_MaNV CHAR(9) NOT NULL FOREIGN KEY REFERENCES Nhan_Vien(Nhan_Vien_MaNV) on delete cascade,
  Hoa_Don_Nhap_MaDaiLy NVARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Dai_ly_Phan_Phoi(Dai_ly_Phan_Phoi_MaDL) on delete cascade,
);
CREATE TABLE Loai_San_Pham
( Loai_San_Pham_MaLoai VARCHAR(20) PRIMARY KEY,
  Loai_San_Pham_TenLoai NVARCHAR(20) NOT NULL,
);
CREATE TABLE San_Pham
( San_Pham_MaSP VARCHAR(20) PRIMARY KEY,
  San_Pham_TenSP NVARCHAR(50) NOT NULL,
  San_Pham_HangSX NVARCHAR(20) NOT NULL,
  San_Pham_MauSac NVARCHAR(20) NOT NULL,
  San_Pham_ChatLieu NVARCHAR(20) NOT NULL,
  San_Pham_MaLoai VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Loai_San_Pham(Loai_San_Pham_MaLoai) on delete cascade,
);


CREATE TABLE Don_Vi_Van_Chuyen 
( Don_Vi_Van_Chuyen_MaDV NVARCHAR(20) PRIMARY KEY,
  Don_Vi_Van_Chuyen_TenDV NVARCHAR(50) NOT NULL,
);
CREATE TABLE Phuong_Tien
( Phuong_Tien_MaPT VARCHAR(20) PRIMARY KEY,
  Phuong_Tien_BienSoPT VARCHAR(20) NOT NULL,
);
CREATE TABLE Xe_Tai
( Xe_Tai_MaPT VARCHAR(20) PRIMARY KEY,);
CREATE TABLE Tai_Xe
( Tai_Xe_MaTX VARCHAR(20) PRIMARY KEY,
  Tai_Xe_CMND VARCHAR(20) NOT NULL,
  Tai_Xe_NgaySinh DATETIME NOT NULL,
  Tai_Xe_SoBangLai VARCHAR(20) NOT NULL,
  Tai_Xe_HoTen NVARCHAR(50) NOT NULL,
);
CREATE TABLE Xe_May
( Xe_May_MaPT VARCHAR(20) PRIMARY KEY,
  Xe_May_MaTX VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tai_Xe(Tai_Xe_MaTX) on delete cascade,
);

CREATE TABLE Don_Van
( Don_Van_MaHD NVARCHAR(20) NOT NULL,
  Don_Van_MaDon NVARCHAR(20) NOT NULL,
  Don_Van_NgayDongGoi DATETIME NOT NULL,
  Don_Van_Luu_Y NVARCHAR(20),
  Don_Van_MaDV NVARCHAR(20),
  Don_Van_DiaDiemGiaoHang NVARCHAR(50) NOT NULL,
  Don_Van_Phi MONEY NOT NULL,
  Don_Van_NgayChuyenChoDVVC DATETIME,
  Don_Van_NgayGiaoHang DATETIME NOT NULL,
  Don_Van_NgayNhanHang DATETIME NOT NULL,
  CONSTRAINT pk_don_van PRIMARY KEY(Don_Van_MaHD,Don_Van_MaDon));
 ALTER TABLE Don_Van
 ADD CONSTRAINT fk_madvvc FOREIGN KEY(Don_Van_MaDV) REFERENCES Don_Vi_Van_Chuyen(Don_Vi_Van_Chuyen_MaDV) ON DELETE SET NULL;
 CREATE TABLE Bang_Giasp
(Bang_gia_MaSP VARCHAR(20) not NULL ,
 Bang_gia_MaGia VARCHAR(20) not NULL ,
 Bang_gia_Gia MONEY not NULL,
 Bang_gia_LoaiGia NVARCHAR(20) not NULL,
 Bang_gia_TrangThai NVARCHAR(50),
 Bang_gia_NgayApDung DATETIME not NULL,
 Bang_gia_NgayKT DATETIME not NULL,
 CONSTRAINT Bang_gia PRIMARY key (Bang_gia_MaSP, Bang_gia_MaGia)
 );
CREATE TABLE NV_ChiNhanh
(NhanVien_ChiNhanh_MaNV CHAR(9) not NULL,
 NhanVien_ChiNhanh_MaCN CHAR(4) not NULL,
 NhanVien_ChiNhanh_ThoiGianBDLam DATETIME not NULL,
 NhanVien_ChiNhanh_ConLamHayKo BIT not NULL,
 CONSTRAINT NhanVien_ChiNhanh PRIMARY key(NhanVien_ChiNhanh_MaNV,NhanVien_ChiNhanh_MaCN)
 );
CREATE TABLE DVan_ChiNhanh
(DonVan_ChiNhanh_MaHD NVARchar(20) not NULL,
 DonVan_ChiNhanh_MaDonVan NVARCHAR(20) not NULL,
 DonVan_ChiNhanh_MaCN CHAR(4) not NULL,
 CONSTRAINT DonVan_ChiNhanh PRIMARY key (DonVan_ChiNhanh_MaHD,DonVan_ChiNhanh_MaDonVan,DonVan_ChiNhanh_MaCN)
 );
CREATE TABLE DVan_SanPham
(DonVan_SanPham_MaHD NVARchar(20) not NULL,
DonVan_SanPham_MaDon NVARCHAR(20) not NULL,
DonVan_SanPham_MaSP NVARCHAR(20) not NULL,
 DonVan_SanPham_SoLuong int not NULL,
 CONSTRAINT DonVan_SanPham PRIMARY key (DonVan_SanPham_MaHD, DonVan_SanPham_MaDon, DonVan_SanPham_MaSP)
 );
CREATE TABLE SP_HoaDonNhap
(SanPham_HoaDonNhap_MaSP VARCHAR(20) not NULL,
SanPham_HoaDonNhap_MaDN NVARchar(20) not NULL,
SanPham_HoaDonNhap_GiaNhap money not NULL,
SanPham_HoaDonNhap_SoLuong int not NULL,
 CONSTRAINT SanPham_HoaDonNhap PRIMARY key (SanPham_HoaDonNhap_MaSP, SanPham_HoaDonNhap_MaDN)
 );
CREATE TABLE DaiLyPhanPhoi_SanPham
(DaiLy_SanPham_MaDaiLy NVARCHAR(20) not NULL,
 DaiLy_SanPham_MaSP VARCHAR(20) not NULL,
 CONSTRAINT DaiLy_SanPham PRIMARY key(DaiLy_SanPham_MaDaiLy, DaiLy_SanPham_MaSP)
 );
CREATE TABLE KH_SDT
(KhachHang_SDT_MaKH char(9) not NULL,
 KhachHang_SDT_SDT Varchar(20) not NULL,
 CONSTRAINT KhachHang_SDT PRIMARY key (KhachHang_SDT_MaKH, KhachHang_SDT_SDT)
 );
CREATE TABLE KH_Email
(KhachHang_Email_MaKH char(9) not NULL,
 KhachHang_Email_email Varchar(100) not NULL,
 CONSTRAINT KhachHang_Email PRIMARY key (KhachHang_Email_MaKH, KhachHang_Email_email)
 );
CREATE TABLE NV_SDT
(NhanVien_SDT_MaNV char(9) not NULL,
NhanVien_SDT_SDT varchar(20) not NULL,
CONSTRAINT Nhan_vien_SDT PRIMARY key (NhanVien_SDT_MaNV, NhanVien_SDT_SDT)
);
CREATE TABLE NVIEN_Email
(NhanVien_Email_MaNV char(9) not NULL,
NhanVien_Email_email varchar(100) not NULL,
 CONSTRAINT NhanVien_Email PRIMARY key(NhanVien_Email_MaNV, NhanVien_Email_email)
 );
CREATE TABLE CNhanh_SDT
(ChiNhanh_SDT_MaCN char(4) not NULL,
ChiNhanh_SDT_SDT varchar(20) not NULL,
 CONSTRAINT ChiNhanh_SDT PRIMARY key(ChiNhanh_SDT_MaCN, ChiNhanh_SDT_SDT)
 );
CREATE TABLE DaiLyPhanPhoi_SDT
(DaiLy_SDT_MaDaiLy VARCHAR(20) not NULL,
 DaiLy_SDT_SDT varchar(20) not NULL,
 CONSTRAINT DaiLy_SDT PRIMARY key(DaiLy_SDT_MaDaiLy, DaiLy_SDT_SDT)
 );
CREATE TABLE DaiLyPhanPhoi_Email
(DaiLy_Email_MaDaiLy varchar(20) not NULL,
 DaiLy_Email_email varchar(100) not NULL,
 CONSTRAINT DaiLy_Email PRIMARY key(DaiLy_Email_MaDaiLy,DaiLy_Email_email)
 );
CREATE TABLE TXe_SDT
( TaiXe_SDT_MaTX VARCHAR(20) not NULL,
 TaiXe_SDT_SDT varchar(20) not NULL,
 CONSTRAINT TaiXe_SDT PRIMARY key(TaiXe_SDT_MaTX , TaiXe_SDT_SDT)
 );
CREATE TABLE DVVC_SDT
(DonViVanChuyen_SDT_MaDV NVARCHAR(20) not NULL,
 DonViVanChuyen_SDT_SDT varchar(20) not NULL,
 CONSTRAINT DonViVanChuyen_SDT PRIMARY key (DonViVanChuyen_SDT_MaDV, DonViVanChuyen_SDT_SDT)
 );
CREATE TABLE DVVC_Email
(DonViVanChuyen_Email_MaDV NVARCHAR(20)  not NULL,
 DonViVanChuyen_Email_email varchar(100) not NULL,
 CONSTRAINT DonViVanChuyen_Email PRIMARY key (DonViVanChuyen_Email_MaDV, DonViVanChuyen_Email_email)
 );
CREATE TABLE DVVC_DonVan_ViTriDonHang
(DonViVanChuyen_DonVan_ViTriDonHang_MaDV NVARCHAR(20) not NULL,
 DonViVanChuyen_DonVan_ViTriDonHang_MaHD NVARCHAR(20) not NULL,
DonViVanChuyen_DonVan_ViTriDonHang_MaDon NVARCHAR(20) not NULL,
DonViVanChuyen_DonVan_ViTriDonHang_VTDonHang Nvarchar(100) not NULL,
 CONSTRAINT DonViVanChuyen_DonVan_ViTriDonHang PRIMARY key (DonViVanChuyen_DonVan_ViTriDonHang_MaDV, DonViVanChuyen_DonVan_ViTriDonHang_MaHD, DonViVanChuyen_DonVan_ViTriDonHang_MaDon, DonViVanChuyen_DonVan_ViTriDonHang_VTDonHang)
 );
CREATE TABLE VChuyen_ViTriDonHang
(VanChuyen_ViTriDonHang_MaTX varchar(20) not NULL,
VanChuyen_ViTriDonHang_MaHD NVARchar(20) not NULL,
VanChuyen_ViTriDonHang_MaDon NVARCHAR(20) not NULL,
VanChuyen_ViTriDonHang_VTDonHang Nvarchar(100) not NULL,
CONSTRAINT VanChuyen_ViTriDonHang PRIMARY key (VanChuyen_ViTriDonHang_MaTX, VanChuyen_ViTriDonHang_MaHD, VanChuyen_ViTriDonHang_MaDon, VanChuyen_ViTriDonHang_VTDonHang)
 );
CREATE TABLE VanChuyen
( Van_Chuyen_MaTX VARCHAR(20) not NULL,
 Van_Chuyen_MaHD NVARCHAR(20) not NULL,
 Van_Chuyen_MaDon NVARCHAR(20) not NULL,
 Van_Chuyen_MaPhuongTien VARCHAR(20) not NULL,
 Van_Chuyen_NgayGiao DATETIME not NULL,
 Van_Chuyen_NgayNhan DATETIME not NULL,
Van_Chuyen_Luu_Y nvarchar(100),
Van_Chuyen_So_KM int not NULL,
CONSTRAINT Van_Chuyen PRIMARY key ( Van_Chuyen_MaTX, Van_Chuyen_MaHD, Van_Chuyen_MaDon)
 );
CREATE TABLE HDon_SanPham_BangGia
( HoaDon_SanPham_BangGia_MaHD NVARchar(20) not NULL,
 HoaDon_SanPham_BangGia_MaSP VARchar(20) not NULL,
HoaDon_SanPham_BangGia_MaGia NVARCHAR(20) not NULL,
HoaDon_SanPham_BangGia_SoLuong int not NULL,
HoaDon_SanPham_BangGia_Gia_Ban money not NULL,
 CONSTRAINT HoaDon_SanPham_BangGia PRIMARY key (HoaDon_SanPham_BangGia_MaHD, HoaDon_SanPham_BangGia_MaSP),

 );
 ALTER TABLE HDon_SanPham_BangGia
 ADD CONSTRAINT fk_HDon_SanPham_BangGia_MaHD FOREIGN KEY(HoaDon_SanPham_BangGia_MaHD) REFERENCEs Hoa_Don (Hoa_Don_MaHD) ON DELETE cascade ;