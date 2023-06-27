
-- 1. Bảng nhân viên
create table NHANVIEN
(
	MANV	CHAR(10) not null,
	TENNV	NVARCHAR(200) not null,
	SDT		CHAR(10) not null,
	CCCD	CHAR(12) not null,
	NS		DATE,
	EMAIL	VARCHAR(50),
	UN		CHAR(30),
	PW		CHAR(30)
)



-- 2. Bảng khách hàng
CREATE TABLE KHACHHANG
(
	MAKH	CHAR(10) not null,
	TENKH	NVARCHAR(200) not null,
	SDT		CHAR(10)	not null,
	DC		NVARCHAR(500) not null
)


-- 3. Bảng sản phẩm drop table SANPHAM
CREATE TABLE SANPHAM
(
	MASP	char(10) primary key,
	TENSP	NVARCHAR(200),
	DVT		NVARCHAR(100),
	DONGIA	Decimal(18,0) CHECK (DONGIA>=0),
	SLTON	INT,
	MAMH	char(10),
	NGAYCN	DATETIME
)


-- 4. Bảng mặt hàng
create table MATHANG
(
	MAMH	char(10)	not null primary key,
	TENMH	nvarchar(200) not null
)


-- 5. Bảng nhà cung ứng
CREATE TABLE NCU
(
	MANCU	INT IDENTITY(1,1),
	TENNCU	NVARCHAR(200)	not null,
	SDTNCU	CHAR(10)	not null,
	DC		NVARCHAR(500) not null,
	TENSALE	NVARCHAR(200) not null,
	TENSEP	NVARCHAR(200) not null,
	SDTSEP	CHAR(10) not null
)

DROP TABLE HDB
create table HDB
(
MAHDB		char(10) not null primary key,
MANV		char(10) not null,
NGAY_HDB	datetime not null,
MAKH		char(10) not null,
TongTien	Decimal(18,0) CHECK (TongTien>=0) not null,
DATHU		Decimal(18,0) not null,
CHUATHU		Decimal(18,0) not null,
)

DROP TABLE HDB_CT
-- 6. Bảng hoá đơn bán
CREATE TABLE HDB_CT
(
	MAHDB		char(10) not null,
	MASP		char(10) not null,
	SL			INT not null,
	DONGIA		Decimal(18,0) CHECK (DONGIA>=0) not null,
	THANHTIEN	Decimal(18,0) CHECK (THANHTIEN>=0) not null,
	--constraint pk_hdc_ct primary key (MAHDB,MASP),
	CONSTRAINT fk_hdb_ct_nv FOREIGN KEY (MAHDB) REFERENCES HDB (MAHDB),
	CONSTRAINT fk_hdb_ct_kh FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP)
)


-- 7. Bảng hoá đơn mua
CREATE TABLE HDM
(
	MAHDM		INT IDENTITY(1,1),
	MANCU		INT,
	TENNCU		NVARCHAR(200),
	TENSP		NVARCHAR(200),
	MAMH		INT,
	SL			INT,
	DONGIA		Decimal(18,0) CHECK (DONGIA>=0),
	THANHTIEN	Decimal(18,0) CHECK (THANHTIEN>=0),
	NGAYMUA		DATETIME,
	TONGTIEN	Decimal(18,0) CHECK (TONGTIEN>=0),
	DATT		Decimal(18,0),
	CHUATT		Decimal(18,0)
)


