﻿
/* ..1 cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
DROP TRIGGER IF EXISTS trg_HDM_CT

CREATE TRIGGER trg_HDM_CT ON HDM_CT AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SLTON = SLTON + (
		SELECT SL
		FROM inserted
		WHERE MASP = SANPHAM.MASP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.MASP = inserted.MASP
END
GO

/* ..2 cập nhật hàng trong kho sau khi hủy đặt hàng */
DROP TRIGGER IF EXISTS trg_HuyHDM

create TRIGGER trg_HuyHDM ON HDM_CT FOR DELETE AS 
BEGIN
	UPDATE SANPHAM
	SET SLTON = SLTON - (SELECT SL FROM deleted WHERE MASP = SANPHAM.MASP)
	FROM SANPHAM
	JOIN deleted ON SANPHAM.MASP = deleted.MASP
END
GO

/* ..3 Cập nhật hàng trong kho sau khi tạo hoá đơn bán */
DROP TRIGGER IF EXISTS trg_HDB_CT

CREATE TRIGGER trg_HDB_CT ON HDB_CT AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SLTON = SLTON - (
		SELECT SL
		FROM inserted
		WHERE MASP = SANPHAM.MASP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.MASP = inserted.MASP
END
GO

/* ..4 Cập nhật hàng trong kho sau khi hủy hoá đơn bán */
DROP TRIGGER IF EXISTS trg_HuyHDB

create TRIGGER trg_HuyHDB ON HDB_CT FOR DELETE AS 
BEGIN
	UPDATE SANPHAM
	SET SLTON = SLTON + (SELECT SL FROM deleted WHERE MASP = SANPHAM.MASP)
	FROM SANPHAM
	JOIN deleted ON SANPHAM.MASP = deleted.MASP
END
GO
