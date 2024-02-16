


---- 1. Viết hàm Stored Procedure kiểm tra đăng nhập
if exists (select name from sysobjects where name='Check_Login')
drop procedure Check_Login
go

create procedure Check_Login
@UN char(30),
@PW char(30)
as
begin
    if exists (select * from NHANVIEN where UN = @UN and PW = @PW)
        select 1 as code
    else if exists(select * from NHANVIEN 
	where UN = @UN and PW != @PW or UN != @UN and PW = @PW
	) 
        select 2 as code
    else select 3 as code
end


---- 2. Viết hàm Stored Procedure tạo Mã nhân viên
if exists (select name from sysobjects where name='pr_TAOMANV')
drop procedure pr_TAOMANV
go

------------------------------------------------------------------------------------ NHÂN VIÊN ----------------
---- 2. Viết hàm Stored Procedure tạo mã nhân viên
create procedure pr_TAOMANV
as
begin
	---- Trường hợp 1: Chưa có nhân viên
	if not exists (select * from NHANVIEN)
	select 'NV_' + '1'

	---- Trường hợp 1: Đã có nhân viên
	else
	begin
		declare @nv1 char(10),@nv2 char(10)
		select @nv1 = max(MANV) from NHANVIEN
		set  @nv2 = right(rtrim(@nv1),4) + 1
		if len(@nv2) = 1
		select 'NV_' +'000'+@nv2
		else if len(@nv2) = 2
		select 'NV_' +'00'+@nv2
		else if len(@nv2) = 3
		select 'NV_' +'0' +@nv2
		else if len(@nv2) = 4
		select 'NV_'+@nv2
	end
end
go


---- 3. Viết hàm Stored Procedure thêm nhân viên
if exists (select name from sysobjects where name='pr_THEMNV')
drop procedure pr_THEMNV
go

create procedure pr_THEMNV
(
@MANV char(10),
@TENNV nvarchar(200),
@SDT char(10),
@CCCD char(12),
@NGAYSINH date,
@EMAIL varchar(50),
@UN char(30),
@PW	char(30)
)
as
begin
	if exists (select * from NHANVIEN where CCCD = @CCCD)
		raiserror('CCCD của nhân viên này đã tồn tại!',16,0)
	else if YEAR(GETDATE()) - year(@NGAYSINH) < 18
		raiserror('Nhân viên chưa đủ 18 tuổi!',16,0)
	else
	begin
		insert into NHANVIEN(MANV,TENNV,SDT,CCCD,NS,EMAIL,UN,PW)
			values (@MANV,@TENNV,@SDT,@CCCD,@NGAYSINH,@EMAIL,@UN,@PW)
	end
end
go

---- 4. Viết hàm Stored Procedure xoá nhân viên
if exists (select name from sysobjects where name='pr_XOANV')
drop procedure pr_XOANV
go

create procedure pr_XOANV
(
@MANV char(10)
)
as
begin
    alter table HDB nocheck constraint all
	delete from NHANVIEN WHERE MANV=@MANV
	alter table HDB check constraint all
end



---- 5. Viết hàm Stored Procedure Tìm kiếm nhân viên
if exists (select name from sysobjects where name='pr_TIMNV')
drop procedure pr_TIMNV
go


---- 5. Viết hàm Stored Procedure tìm nhân viên
if exists (select name from sysobjects where name='pr_TIMNV')
drop procedure pr_TIMNV
go

create procedure pr_TIMNV
(
@TENNV nvarchar(200),
@SDT char(10),
@CCCD char(12)
)
as
begin
	if @TENNV<>''
		select * from NHANVIEN where TENNV like '%' + @TENNV + '%'
	else if @SDT<>''
		select * from NHANVIEN where SDT like '%' + @SDT + '%'
	else if @CCCD<>''
	select * from NHANVIEN where CCCD like '%' + @CCCD + '%'
end
go


---- 6. Viết hàm Stored Procedure sửa nhân viên
if exists (select name from sysobjects where name='pr_SUANV')
drop procedure pr_SUANV
go

create procedure pr_SUANV
(
@MANV char(10),
@TENNV nvarchar(200),
@SDT char(10),
@CCCD char(12),
@NGAYSINH date,
@EMAIL varchar(50),
@UN char(30),
@PW	char(30)
)
as
begin
	update NHANVIEN
	set
		TENNV = @TENNV,
		SDT = @SDT,
		CCCD = @CCCD,
		NS = @NGAYSINH,
		EMAIL = @EMAIL,
		UN=@UN,
		PW=@PW
	where MANV = @MANV
end
go


------------------------------------------------------------------------------------ KHÁCH HÀNG ----------------------
---- 7. Viết hàm Stored Procedure tạo mã khách hàng
if exists (select name from sysobjects where name='KH_TAOMAKH')
drop procedure KH_TAOMAKH
go

create procedure KH_TAOMAKH
as
begin
	---- Trường hợp 1: Chưa có khách hàng
	if not exists (select * from KHACHHANG)
	select 'KH_' + '0001'

	---- Trường hợp 2: Đã có khách hàng
	else 
	begin
		declare @kh1 char(10),@kh2 char(10)
		select @kh1 = max(MAKH) from KHACHHANG
		set  @kh2 = right(rtrim(@kh1),4) + 1
		if len(@kh2) = 1
		select 'KH_' +'000'+@kh2
		else if len(@kh2) = 2
		select 'KH_' +'00'+@kh2
		else if len(@kh2) = 3
		select 'KH_' +'0' +@kh2
		else if len(@kh2) = 4
		select 'KH_'+@kh2
	end
end
go

exec KH_TAOMAKH 
select trim(convert(char,(select len(trim(MAKH)) from KHACHHANG)))
select SUBSTRING((select max(MAKH) from KHACHHANG),4,1)
select right(rtrim('kh010'),2)+1

---- 8. Viết hàm Stored Procedure thêm khách hàng
if exists (select name from sysobjects where name='KH_THEMKH')
drop procedure KH_THEMKH
go

create procedure KH_THEMKH
(
@MAKH char(10),
@TENKH nvarchar(200),
@SDT char(10),
@DC nvarchar(500)
)
as
begin
	if exists (select * from KHACHHANG where MAKH = @MAKH)
		raiserror('Khách hàng này đã tồn tại, bạn không thể thêm mới khách hàng này!',16,0)
	else
	begin
		insert into KHACHHANG(MAKH,TENKH,SDT,DC)
			values (@MAKH,@TENKH,@SDT,@DC)
		---raiserror('Thêm khách hàng [%s] này thành công',16,1,@TENKH)
	end
end
go


---- 9. Viết hàm Stored Procedure xoá khách hàng
if exists (select name from sysobjects where name='KH_XOAKH')
drop procedure KH_XOAKH
go

create procedure KH_XOAKH
(
@MAKH char(10)
)
as
begin
    alter table HDB nocheck constraint all
	delete from KHACHHANG WHERE MAKH = @MAKH
	alter table HDB check constraint all
end


---- 10. Viết hàm Stored Procedure sửa khách hàng
if exists (select name from sysobjects where name='pr_SUAKH')
drop procedure pr_SUAKH
go


---- 10. Viết hàm Stored Procedure sửa khách hàng
if exists (select name from sysobjects where name='KH_SUAKH')
drop procedure KH_SUAKH
go

create procedure KH_SUAKH
(
@MAKH char(10),
@TENKH nvarchar(200),
@SDT char(10),
@DC nvarchar(500)
)
as
begin
	update KHACHHANG
	set TENKH = @TENKH, SDT = @SDT, DC = @DC
	where MAKH = @MAKH
end
go


---- 11. Viết hàm Stored Procedure tìm khách hàng
if exists (select name from sysobjects where name='KH_TIMKH')
drop procedure KH_TIMKH
go

create procedure KH_TIMKH
(
@MAKH char(10),
@TENKH nvarchar(200)
)
as
begin
	if @MAKH<>''
		select * from KHACHHANG where MAKH like '%' + @MAKH + '%'
	else if @TENKH<>''
		select * from KHACHHANG where TENKH like '%' + @TENKH + '%'
end
go


------------------------------------------------------------------------ HOÁ ĐƠN --------------------------------------------------
---- 12. Viết hàm Stored Procedure tạo mã hoá đơn bán
if exists (select name from sysobjects where name='HDB_TAOMAHDB')
drop procedure HDB_TAOMAHDB
go

create procedure HDB_TAOMAHDB
as
begin
	---- Trường hợp 1: Chưa có hoá đơn bán nào
	if not exists (select * from HDB)
	select 'HDB_' + '00001'

	---- Trường hợp 2: Đã có hoá đơn trong database
	else 
	begin
		declare @hdb1 char(10), @hdb2 char(10)
		select @hdb1 = max(MAHDB) from HDB
		set  @hdb2 = right(rtrim(@hdb1),5) + 1
		if len(@hdb2) = 1
		select 'HDB_' + '0000' + @hdb2
		else if len(@hdb2) = 2
		select 'HDB_' + '000' + @hdb2
		else if len(@hdb2) = 3
		select 'HDB_' + '00' + @hdb2
		else if len(@hdb2) = 4
		select 'HDB_' + '0' + @hdb2
		else if len(@hdb2) = 5
		select 'HDB_' + @hdb2
	end
end
go



---- 3. Viết hàm Stored Procedure thêm nhân viên
if exists (select name from sysobjects where name='HDB_THEM')
drop procedure HDB_THEM
go

create procedure HDB_THEM
(
@MAHDB char(10),
@MANV char(10),
@NGAYHDB datetime,
@MAKH char(10),
@TONGTIEN decimal,
@DATHU decimal,
@CHUATHU decimal
)
as
begin
	--if exists (select * from NHANVIEN where CCCD = @CCCD)
	--	raiserror('CCCD của nhân viên này đã tồn tại!',16,0)
	--else if YEAR(GETDATE()) - year(@NGAYSINH) < 18
	--	raiserror('Nhân viên chưa đủ 18 tuổi!',16,0)
	--else
	begin
		insert into HDB(MAHDB, MANV, NGAY_HDB, MAKH, TongTien, DATHU, CHUATHU)
			values (@MAHDB, @MANV, @NGAYHDB, @MAKH, @TONGTIEN, @DATHU, @CHUATHU)
	end
end
go

---- 13. Viết hàm Stored Procedure tạo mã hoá đơn mua
if exists (select name from sysobjects where name='HDM_TAOMAHDM')
drop procedure HDM_TAOMAHDM
go

create procedure HDM_TAOMAHDM
as
begin
	---- Trường hợp 1: Chưa có hoá đơn bán nào
	if not exists (select * from HDM)
	select 'HDM_' + '00001'

	---- Trường hợp 2: Đã có hoá đơn trong database
	else 
	begin
		declare @hdm1 char(10), @hdm2 char(10)
		select @hdm1 = max(MAHDM) from HDM
		set  @hdm2 = right(rtrim(@hdm1),5) + 1
		if len(@hdm2) = 1
		select 'HDM_' + '0000' + @hdm2
		else if len(@hdm2) = 2
		select 'HDM_' + '000' + @hdm2
		else if len(@hdm2) = 3
		select 'HDM_' + '00' + @hdm2
		else if len(@hdm2) = 4
		select 'HDM_' + '0' + @hdm2
		else if len(@hdm2) = 5
		select 'HDM' + @hdm2
	end
end
go


------------------------------------------------------------------------ SẢN PHẨM --------------------------------------------------
---- 13. Viết hàm Stored Procedure tạo mã sản phẩm
if exists (select name from sysobjects where name='SP_TAOMASP')
drop procedure SP_TAOMASP
go

create procedure SP_TAOMASP
as
begin
	---- Trường hợp 1: Chưa có sản phẩm nào
	if not exists (select * from SANPHAM)
	select 'SP_' + '01'

	---- Trường hợp 2: Đã có hoá đơn trong database
	else 
	begin
		declare @sp1 char(10),@sp2 char(10)
		select @sp1 = max(MASP) from SANPHAM
		set  @sp2 = right(rtrim(@sp1),2) + 1
		if len(@sp2) = 1
		select 'SP_' +'0' +@sp2
		else if len(@sp2) = 2
		select 'SP_'+@sp2
	end
end
go

exec SP_TAOMASP 

