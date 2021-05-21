CREATE DATABASE QLPM
GO

USE QLPM
GO

--Account
CREATE TABLE Account
(
	TenDangNhap CHAR(255) PRIMARY KEY,
	TenHienThi NVARCHAR(255) NOT NULL,
	MatKhau CHAR(1000) NOT NULL,
	Loai INT --0:nhân viên || 1: admin
)
GO

--Bệnh nhân
CREATE TABLE BenhNhan
(
	IdBenhNhan INT IDENTITY (1,1) PRIMARY KEY,
	MaBenhNhan AS 'BN' + RIGHT('000'+ CAST(IdBenhNhan AS varchar),4) ,
	HoLot NVARCHAR(255) NOT NULL,
	TenBN NVARCHAR(255) NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(255),
	LienHe NVARCHAR(255),
	GhiChu NVARCHAR(1000)
)
GO

--Bác sĩ
CREATE TABLE BacSi
(
	IdBacSi INT IDENTITY (1,1) PRIMARY KEY,
	MaBacSi AS 'BS' + RIGHT('000'+ CAST(IdBacSi AS varchar),4),
	HoLot NVARCHAR(255) NOT NULL,
	TenBS NVARCHAR(255) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	Email VARCHAR(255) NOT NULL
)
GO

--Thuốc
CREATE TABLE Thuoc
(
	MaThuoc CHAR(11) PRIMARY KEY,
	TenThuoc NVARCHAR(255) NOT NULL,
	DonVi NVARCHAR(10) NOT NULL, --1: Viên ||2: Gói||3: ống
	SoLuong int DEFAULT 0,
	NSX DATE NOT NULL,
	HSD DATE NOT NULL,
	GiaThuoc INT NOT NULL
)
GO
--Phiếu khám
CREATE TABLE PhieuKham
(
	IdPhieuKham INT IDENTITY (1,1) PRIMARY KEY,
	MaPhieuKham AS 'PH' + RIGHT('000'+ CAST(IdPhieuKham AS varchar),4) ,
	IdBenhNhan int NOT NULL,
	NgayKham DATETIME NOT NULL,
	TrieuChung NVARCHAR(255) NOT NULL,
	ChuanDoan NVARCHAR(255) NOT NULL,
	IdBacSi int NOT NULL,
	GhiChu NVARCHAR(255) NOT NULL,
	TienKham INT NOT NULL DEFAULT 30000,

	FOREIGN KEY(IdBenhNhan) REFERENCES dbo.BenhNhan(IdBenhNhan),
	FOREIGN KEY(IdBacSi) REFERENCES dbo.BacSi(IdBacSi)
)
GO

--Chi tiết đơn thuốc
CREATE TABLE DonThuoc
(
	IdDonThuoc INT NOT NULL,
	MaThuoc CHAR(11) NOT NULL,
	CachDung NVARCHAR(30) NOT NULL,
	SLSang INT DEFAULT 0,
	SLTrua INT DEFAULT 0,
	SLChieu INT DEFAULT 0,
	SLToi INT DEFAULT 0

	PRIMARY KEY(IdDonThuoc,MaThuoc),
	FOREIGN KEY(MaThuoc) REFERENCES dbo.Thuoc(MaThuoc),
	FOREIGN KEY(IdDonThuoc) REFERENCES dbo.PhieuKham(IdPhieuKham)
)
GO

--Hóa đơn
CREATE TABLE HoaDon
(
	IdHoaDon INT IDENTITY (1,1) PRIMARY KEY,
	MaHoaDon AS 'HD' + RIGHT('000'+ CAST(IdHoaDon AS varchar),4) ,
	IdPhieuKham INT NOT NULL,
	IdDonThuoc INT NOT NULL,

	FOREIGN KEY(IdPhieuKham) REFERENCES dbo.PhieuKham(IdPhieuKham),
	FOREIGN KEY(IdDonThuoc) REFERENCES dbo.DonThuoc(IdDonThuoc),
)
GO


INSERT INTO dbo.Thuoc VALUES ('VD-32663-19',N'Đại tràng hoàn',N'Viên',30,'05-05-2019','03-30-2022',5000);
INSERT INTO dbo.Thuoc VALUES ('VD-24479-16',N'Atorvastatin 20 mg',N'Viên',20,'05-25-2019','06-17-2022',5150);
INSERT INTO dbo.Thuoc VALUES ('VD-27875-17',N'Acemetin',N'Gói',20,'09-01-2020','08-02-2023',1650);
INSERT INTO dbo.Thuoc VALUES ('VD-28936-18',N'Ezeytine',N'Chai',20,'09-01-2020','08-02-2023',20000);
GO

INSERT INTO dbo.Account VALUES('admin', N'Nguyễn Minh Mẫn', 'admin',  1 );
INSERT INTO dbo.Account VALUES('test1', N'Nguyễn Minh Mẫn', 'e99a18c428cb38d5f260853678922e03',  1 );
INSERT INTO dbo.Account VALUES('test2', N'Nguyễn Minh Mẫn', '30e229876358062f5d83bc824c81a99e',  1 );
INSERT INTO dbo.Account VALUES('thaingoc', N'Phương Thái Ngọc', 'e99a18c428cb38d5f260853678922e03',  1 );
INSERT INTO dbo.Account VALUES('nguyenvana', N'Nguyễn Văn A', '123',  0 );
GO

INSERT INTO dbo.BenhNhan VALUES(N'Nguyễn Minh', N'Mẫn', N'Nam', '11-21-2000', N'Long Xuyên, An Giang', N'0907713520', N'thường xuyên sốt');
INSERT INTO dbo.BenhNhan VALUES(N'Trần Minh', N'Minh', N'Nam', '08-06-1988', N'Quận 1,HCM', N'ming@gmail.com', null);
GO



INSERT INTO dbo.BacSi VALUES (N'Trần Văn',N'Nam','0906632542','namtran@gmail.com');
INSERT INTO dbo.BacSi VALUES (N'Nguyễn Thị',N'Chi','0906632236','chichi@gmail.com');
INSERT INTO dbo.BacSi VALUES (N'Nguyễn Minh',N'Mẫn','0907713520','chichi@gmail.com');
INSERT INTO dbo.BacSi VALUES (N'Phương Thái',N'Ngọc','0907713520','chichi@gmail.com');
GO

INSERT INTO dbo.PhieuKham VALUES (1,'06-29-2021',N'Nóng, nhức đầu, ói',N'Sốt',1,N' ',30000);
	INSERT INTO dbo.PhieuKham VALUES (2,'06-29-2021',N'Nóng, nhức đầu, ói',N'Sốt',2,N' ',30000);
	INSERT INTO dbo.PhieuKham VALUES (2,'06-29-2021 15:06:20',N'Nóng, nhức đầu, ói',N'Sốt',2,N'fqwfqwefdsfew',5000);
GO

select * from BacSi
SELECT * FROM dbo.BenhNhan
SELECT * FROM dbo.Thuoc
SELECT * FROM dbo.PhieuKham
SELECT * FROM dbo.Account

--phieu kham benh--
SELECT ph.*,bn.HoLot+' '+bn.TenBN AS BenhNhan,bs.HoLot+' '+bs.TenBS AS BacSi 
FROM dbo.BenhNhan bn,dbo.BacSi bs,dbo.PhieuKham ph
WHERE ph.IdBenhNhan=bn.IdBenhNhan AND ph.IdBacSi=bs.IdBacSi AND bn.MaBenhNhan=N'BN0001'

SELECT ph.MaPhieuKham, ph.NgayKham, ph.IdBenhNhan, bn.HoLot+' '+bn.TenBN AS BenhNhan, ph.IdBacSi, bs.HoLot+' '+bs.TenBS AS BacSi,ph.TrieuChung,ph.ChuanDoan, ph.TienKham
FROM dbo.BenhNhan bn, dbo.BacSi bs, dbo.PhieuKham ph
WHERE ph.IdBenhNhan=bn.IdBenhNhan AND ph.IdBacSi=bs.IdBacSi

SELECT IdBacSi FROM dbo.BacSi WHERE HoLot+' '+TenBS=N'Phương Thái Ngọc'

INSERT INTO dbo.PhieuKham VALUES (2,'06-29-2021 15:06:20',N'Nóng, nhức đầu, ói',N'Sốt',2,N'fqwfqwefdsfew',5000);

DELETE FROM dbo.PhieuKham WHERE MaPhieuKham='PH0013'

SELECT ph.MaPhieuKham, ph.NgayKham, ph.IdBenhNhan, bn.HoLot+' '+bn.TenBN AS BenhNhan, ph.IdBacSi, bs.HoLot+' '+bs.TenBS AS BacSi,ph.TrieuChung,ph.ChuanDoan,ph.GhiChu, ph.TienKham FROM dbo.BenhNhan bn, dbo.BacSi bs,dbo.PhieuKham ph WHERE ph.IdBenhNhan = bn.IdBenhNhan AND ph.IdBacSi = bs.IdBacSi AND bn.HoLot+' '+bn.TenBN=N'Nguyễn Minh Mẫn'

SELECT * FROM dbo.Thuoc
SELECT * FROM dbo.DonThuoc
SELECT* FROM dbo.PhieuKham
SELECT * FROM dbo.Thuoc WHERE TenThuoc='Acemetin'

INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-24479-16',N'Uong',2,3,1,2)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-27875-17',N'Nuot',2,2,2,2)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-28936-18',N'Ngam',1,2,3,4)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(2,'VD-28936-18',N'Ngam',1,2,3,4)

SELECT t.TenThuoc,d.SLSang,d.SLTrua,d.SLChieu,d.SLToi,d.CachDung 
FROM dbo.PhieuKham p,dbo.DonThuoc d,dbo.Thuoc t 
WHERE t.MaThuoc=d.MaThuoc AND p.IdPhieuKham=d.IdDonThuoc AND d.IdDonThuoc='2'

SELECT * FROM dbo.DonThuoc
DELETE FROM dbo.DonThuoc WHERE IdDonThuoc=1 AND MaThuoc='VD-24479-16'
update DonThuoc set CachDung=N'iiii',SLSang=1,SLTrua=2,SLChieu=3,SLToi=4 where IdDonThuoc=1 and MaThuoc='VD-28936-18'