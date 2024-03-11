
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

insert into NHANVIEN values ('NV_0001',N'Nghĩa','0937693918','261508141',GETDATE(),'','dayi','1')


drop table KHACHHANG
-- 2. Bảng khách hàng
CREATE TABLE KHACHHANG
(
	MAKH	CHAR(10) primary key,
	TENKH	NVARCHAR(200) not null,
	SDT		CHAR(10)	not null,
	DC		NVARCHAR(500) not null
)


drop table MATHANG
-- 3. Bảng mặt hàng
create table MATHANG
(
	MAMH	char(10)	not null primary key,
	TENMH	nvarchar(200) not null
)

drop table SANPHAM
-- 4. Bảng sản phẩm drop table SANPHAM
CREATE TABLE SANPHAM
(
	MASP	char(10) primary key,
	TENSP	NVARCHAR(200),
	DVT		NVARCHAR(100),
	DONGIA	Decimal(18,0) CHECK (DONGIA>=0),
	SLTON	INT,
	MAMH	char(10),
	NGAYCN	DATETIME,
	CONSTRAINT fk_sp_mh FOREIGN KEY (MAMH) REFERENCES MATHANG (MAMH)
)

insert into SANPHAM values ('SP_1',N'khăn 86',N'cái',350,1000,'MH_1',GETDATE())





drop table NCU
-- 5. Bảng nhà cung ứng
CREATE TABLE NCU
(
	MANCU	char(10) primary key,
	TENNCU	NVARCHAR(200)	not null,
	SDTNCU	CHAR(10)	not null,
	DC		NVARCHAR(500) not null,
	TENSALE	NVARCHAR(200) not null,
	TENSEP	NVARCHAR(200) not null,
	SDTSEP	CHAR(10) not null
)


DROP TABLE HDB
-- 6. Bảng hoá đơn bán
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


set dateformat dmy
insert into HDB values ('hdb1','nv_0001',getdate(),'kh_1',1,1,0)

-- hoa don ban
	alter table HDB_CT nocheck constraint all 
	delete from HDB
	alter table HDB_CT check constraint all
delete from HDB_CT 

--- hoa don mua
	alter table HDM_CT nocheck constraint all
	delete from HDM
	alter table HDM_CT check constraint all
delete from HDM_CT


DROP TABLE HDB_CT
-- 7. Bảng hoá đơn bán chi tiết
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


drop table HDM
-- 8. Bảng hoá đơn mua
CREATE TABLE HDM
(
	MAHDM		char(10) primary key,
	MANCU		char(10) not null,
	TENNCU		NVARCHAR(200) not null,
	NGAYMUA		DATETIME not null,
	TONGTIEN	Decimal(18,0) CHECK (TONGTIEN>=0) not null,
	DATT		Decimal(18,0),
	CHUATT		Decimal(18,0)
)


drop table HDM_CT
-- 9. Bảng hoá đơn mua chi tiết
create table HDM_CT
(
	MAHDM		char(10) not null,
	MASP		CHAR(10) not null,
	MAMH		CHAR(10) not null,
	SL			INT not null,
	DONGIA		Decimal(18,0) CHECK (DONGIA>=0) not null,
	THANHTIEN	Decimal(18,0) CHECK (THANHTIEN>=0) not null,
	CONSTRAINT fk_hdm_ct_hdb FOREIGN KEY (MAHDM) REFERENCES HDM (MAHDM),
	CONSTRAINT fk_hdbm_ct_sp FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
	CONSTRAINT fk_hdbm_ct_mh FOREIGN KEY (MAMH) REFERENCES MATHANG (MAMH)
)



--- Tạo bảng tạm

DROP TABLE HDB
create table HDB_Tam
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

CREATE TABLE HDB_CT_Tam
(
	MAHDB		char(10) not null,
	MASP		char(10) not null,
	SL			INT not null,
	DONGIA		Decimal(18,0) CHECK (DONGIA>=0) not null,
	THANHTIEN	Decimal(18,0) CHECK (THANHTIEN>=0) not null,
)
delete from HDB_Tam
delete from HDB_CT_Tam
--- Tạo bảng tạm

select SUM(THANHTIEN) from HDB_CT_Tam where MAHDB= 'HDB_00003'

select a.TENKH from KHACHHANG as a, HDB_Tam as b where a.MAKH = b.MAKH 