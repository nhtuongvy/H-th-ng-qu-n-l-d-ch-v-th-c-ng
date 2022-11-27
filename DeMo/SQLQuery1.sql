CREATE DATABASE DEMO
USE DEMO

--0 QUANLY
--1 KHACHTV
--2 NVCSKH
--3 NVBANHANG
--4 THUNGAN
--5 NVKHO

CREATE TABLE TaiKhoan
( 
	username varchar(30),
	pass varchar(30),
	lvl int,
	stt int IDENTITY (1,1),
	PRIMARY KEY(username,stt)
)

CREATE PROCEDURE TK_INSERTED
(
	@username varchar(30),
	@pass varchar(30),
	@lvl int
	
)
AS
BEGIN
	INSERT INTO TaiKhoan (username, pass, lvl) VALUES 
	(@username,@pass,@lvl)

END
GO

--kt tai khoan
CREATE PROCEDURE NhanVien_GetTaiKhoanByPasswordUsername
(
	@username varchar(30),
	@password varchar(30)
)
AS
BEGIN
	SELECT *
	FROM TaiKhoan
	WHERE username = @username AND pass = @password
END

INSERT INTO TaiKhoan VALUES 
('QL','123',0),
('NVBH','123',3),
('NVCSKH', '123', 2)

CREATE TABLE NhanVien
(  
	MNV varchar(7),
	hoTen nvarchar(30) not null,
	gioiTinh nvarchar(3) not null,
	diaChi nvarchar(100) not null,
	ngaysinh date,
	cmnd varchar(9) not null unique,
	ngayVaoLam date,
	sdt varchar(10) not null unique,
	chucVu nvarchar(30) not null,
	email varchar(100) not null unique,
	primary key(MNV)
)
 

INSERT INTO NhanVien VALUES ('NV1', N'Trần Văn A',N'Nam', N'Cầu Giấy', '1/1/1987', '123456789','2/2/2017','0987654321', N'Giám Đốc', 'A@gmail.com')
CREATE PROCEDURE NhanVien_InsertNhanVien
(
	@MNV varchar(7),
	@hoTen nvarchar(30),
	@gioiTinh nvarchar(3),
	@diaChi nvarchar(100),
	@ngaysinh date,
	@cmnd varchar(9),
	@ngayVaoLam date,
	@sdt varchar(10),
	@chucVu nvarchar(30),
	@email varchar(100)
)
AS
BEGIN
	INSERT INTO NhanVien VALUES (@MNV, @hoTen, @gioiTinh, @diaChi, @ngaysinh, @cmnd, @ngayVaoLam, 	@sdt, @chucVu, @email)
END

GO

CREATE PROC NhanVien_GetAllNhanVien 
AS
BEGIN
	SELECT *
	FROM NhanVien
END
GO



CREATE PROCEDURE NhanVien_UpdateNhanVienByMSNV
(
	@MNV char(7),
	@hoTen nvarchar(30),
	@gioiTinh nvarchar(3),
	@diaChi nvarchar(100),
	@ngaysinh date,
	@cmnd char(9),
	@ngayVaoLam date,
	@sdt char(10),
	@chucVu nvarchar(30),
	@email varchar(100)
)
AS
BEGIN
	UPDATE NhanVien
	SET	MNV=@MNV,
		hoTen =@hoTen,
		gioiTinh =@gioiTinh,
		diaChi =@diaChi,
		ngaysinh =@ngaysinh,
		cmnd =@cmnd,
		ngayVaoLam =@ngayvaolam,
		sdt =@sdt,
		chucVu =@chucVu,
		email =@email
	WHERE MNV = @MNV 
END

GO

CREATE TABLE GIOHANG
( STT INT IDENTITY (1,1) PRIMARY KEY ,
  MSP VARCHAR(10),
  TENSP NVARCHAR(100),
  SOLUONG FLOAT,
  DONGIA  FLOAT,
  TONGTIEN FLOAT,

)

CREATE TABLE DATLICH
( 
  stt int IDENTITY (1,1),
  hoten    nvarchar(100),
  sdt      varchar(15),
  ngay     date,
  khunggio varchar(100),
  dichvu   nvarchar(100),
  mota     nvarchar(800),
  TrangThai nvarchar(50) default N'Chưa xử lý'
 
)

CREATE PROCEDURE DATLICH_INSERTED
(
	 @hoten    nvarchar(100),
      @sdt      varchar(15),
	@ngay     date,
	@khunggio varchar(100),
	@dichvu   nvarchar(100),
	@mota     nvarchar(800),
	@TrangThai nvarchar(50)
	
)
AS
BEGIN
	INSERT INTO DATLICH (hoten,sdt,ngay,khunggio,dichvu,mota) VALUES (@hoten, @sdt, @ngay, @khunggio, @dichvu, @mota)

END
GO

CREATE PROC DatLich_Load
AS
BEGIN
	SELECT *
	FROM DATLICH
END
GO



CREATE PROCEDURE GIOHANG_INSERTED
(
	@MSP VARCHAR(10),
	@TENSP NVARCHAR(100),
	@SOLUONG FLOAT,
	@DONGIA  FLOAT,
	@TONGTIEN FLOAT
	
)
AS
BEGIN
	INSERT INTO GIOHANG (MSP,TENSP,SOLUONG,DONGIA, TONGTIEN) VALUES 
	(@MSP, @TENSP, @SOLUONG, @DONGIA,@TONGTIEN)

END
GO



set dateformat dmy



GO


CREATE PROC GioHang_Load
AS
BEGIN
	SELECT *
	FROM GIOHANG
END
GO



--DROP PROC  NhanVien_GetTaiKhoanByPasswordUsername
GO

CREATE PROCEDURE GioHang_Delete
(
	@STT varchar(10)
)
AS
BEGIN
	DELETE FROM GIOHANG
	WHERE STT = @STT
END
GO

CREATE TABLE DONHANG
( STT INT IDENTITY (1,1) PRIMARY KEY ,
  MSP VARCHAR(10),
  TENSP NVARCHAR(100),
  SOLUONG FLOAT,
  DONGIA  FLOAT,
  TONGTIEN FLOAT

)
CREATE PROCEDURE DONHANG_INSERTED
(
	@MSP VARCHAR(10),
	@TENSP NVARCHAR(100),
	@SOLUONG FLOAT,
	@DONGIA  FLOAT,
	@TONGTIEN FLOAT
	
)
AS
BEGIN
	INSERT INTO DONHANG (MSP,TENSP,SOLUONG,DONGIA, TONGTIEN) VALUES 
	(@MSP, @TENSP, @SOLUONG, @DONGIA,@TONGTIEN)

END
GO


CREATE PROC DoHang_Load
AS
BEGIN
	SELECT *
	FROM DONHANG
END
GO

CREATE PROCEDURE NhanVien_GetTaiKhoanUsername
(
	@username varchar(30)
)
AS
BEGIN
	SELECT *
	FROM TaiKhoan
	WHERE username = @username 
END

CREATE TABLE DOHANG_DH
( STT INT IDENTITY (1,1) PRIMARY KEY ,
  TenKH nvarchar(100),
  sdtDH   varchar(15),
  DiachiDH nvarchar(100),
  ThongTinSP nvarchar(1000),
  TongTienSP float,
  ThanhToan  nvarchar(50),
)

CREATE PROCEDURE DH_INSERTED
(
	@TenKH nvarchar(100),
	@sdtDH   varchar(15),
	@DiachiDH nvarchar(100),
	@ThongTinSP nvarchar(1000),
	@TongTienSP float,
	@ThanhToan nvarchar(50)
)
AS
BEGIN

	
	INSERT INTO DOHANG_DH (TenKH, sdtDH, DiachiDH,ThongTinSP,TongTienSP,ThanhToan)  VALUES (@TenKH, @sdtDH, @DiachiDH,@ThongTinSP,@TongTienSP,@ThanhToan)
	Update DOHANG_DH
	Set ThanhToan=@ThanhToan
	Where ThanhToan='Null'
END
GO


CREATE PROC DH_load
AS
BEGIN
	SELECT *
	FROM DOHANG_DH
END
GO

CREATE TABLE DHDD
( STT INT IDENTITY (1,1) PRIMARY KEY ,
  TenKH nvarchar(100),
  sdtDH   varchar(15),
  DiachiDH nvarchar(100),
  ThongTinSP nvarchar(1000),
  TongTienSP float,
  ThanhToan  nvarchar(50),
  TrangThai nvarchar(50) default N'Đang xử lý'
)



CREATE PROCEDURE DHDD_INSERTED
(
	@TenKH nvarchar(100),
	@sdtDH   varchar(15),
	@DiachiDH nvarchar(100),
	@ThongTinSP nvarchar(1000),
	@TongTienSP float,
	@ThanhToan nvarchar(50),
	@TrangThai nvarchar(50)
)
AS
BEGIN

	
	INSERT INTO DHDD (TenKH, sdtDH, DiachiDH,ThongTinSP,TongTienSP,ThanhToan)  VALUES (@TenKH, @sdtDH, @DiachiDH,@ThongTinSP,@TongTienSP,@ThanhToan)
	
END
GO

CREATE PROC DHDD_load
AS
BEGIN
	SELECT *
	FROM DHDD
END
GO