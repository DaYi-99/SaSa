


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



---- 7. Viết hàm Stored Procedure tạo mã khách hàng
if exists (select name from sysobjects where name='KH_TAOMAKH')
drop procedure KH_TAOMAKH
go

create procedure KH_TAOMAKH
as
begin
	---- Trường hợp 1: Chưa có khách hàng
	if not exists (select * from KHACHHANG)
	select 'KH_' + '1'

	---- Trường hợp 2: Đã có khách hàng
	else 
	begin
		declare @kh1 char(10), @kh2 char(10)
		select @kh1 = MAKH from KHACHHANG
		set  @kh2 = left(rtrim(@kh1),7)
		if len(@kh2) = 4
		select 'KH_' + CONVERT(char,right(rtrim(@kh1),1) + 1)
		else if len(@kh2) = 5
		select 'KH_' + CONVERT(char,right(rtrim(@kh1),2) + 1)
		else if len(@kh2) = 6
		select 'KH_' + CONVERT(char,right(rtrim(@kh1),3) + 1)
		else if len(@kh2) = 7
		select 'KH_' + CONVERT(char,right(rtrim(@kh1),4) + 1)
	end
end
go

--declare @k char(10) = 'KH_1', @h char(10)

--set @h = left(rtrim(@k),7) 
--	if len(@h) = 4
--	select 'KH_' +  CONVERT(char,right(rtrim(@k),1) + 1)
--	else if len(@h) = 5
--	select 'KH_' +  CONVERT(char,right(rtrim(@k),2) + 1)
--	else if len(@h) = 6
--	select 'KH_' +  CONVERT(char,right(rtrim(@k),3) + 1)
--	else if len(@h) = 7
--	select 'KH_' +  CONVERT(char,right(rtrim(@k),4) + 1)




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



---- 7. Viết hàm Stored Procedure tạo mã hoá đơn bán
if exists (select name from sysobjects where name='HDB_TAOMAHDB')
drop procedure HDB_TAOMAHDB
go

create procedure HDB_TAOMAHDB
as
begin
	---- Trường hợp 1: Chưa có khách hàng
	if not exists (select * from KHACHHANG)
	select 'HDB_' + '1'

	---- Trường hợp 2: Đã có khách hàng
	else 
	begin
		declare @hdb1 char(10), @hdb2 char(10)
		select @hdb1 = MAHDB from HDB
		set  @hdb2 = left(rtrim(@hdb1),8)
		if len(@hdb2) = 5
		select 'HDB_' + CONVERT(char,right(rtrim(@hdb1),1) + 1)
		else if len(@hdb2) = 6
		select 'HDB_' + CONVERT(char,right(rtrim(@hdb1),2) + 1)
		else if len(@hdb2) = 7
		select 'HDB_' + CONVERT(char,right(rtrim(@hdb1),3) + 1)
		else if len(@hdb2) = 8
		select 'HDB_' + CONVERT(char,right(rtrim(@hdb1),4) + 1)
	end
end
go