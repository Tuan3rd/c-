-- ============================================================================
-- Co so du lieu mau QLCuaHang dung cho NNLTCS Thuc Hanh 06b - Tuong tac CSDL {2},
-- Bai ve nha (ban hang / ton kho). Day la mien du lieu hoan toan moi, khong lien quan
-- den QLSinhVien. Chay script nay tren SQL Server truoc khi doi cac Form trong
-- Lab06ContinueWinForms sang dung Sql...Repository (mac dinh dang dung
-- InMemory...Repository de chay thu khong can cai SQL Server).
--
-- Cau truc dung dung theo de bai:
--   SanPham        (MaSP IDENTITY, TenSP)
--   TonKho         (MaSP, NgayTon, SLDau, SLNhap, SLBan)   - PK ghep (MaSP, NgayTon)
--   HoaDon         (MaHD IDENTITY, NgayTao, TinhTrangThanhToan)
--   ChiTietHoaDon  (MaHD, MaSP, SoLuong)                   - PK ghep (MaHD, MaSP)
-- ============================================================================

IF DB_ID('QLCuaHang') IS NULL
BEGIN
    CREATE DATABASE QLCuaHang;
END
GO

USE QLCuaHang;
GO

IF OBJECT_ID('dbo.CHITIET_HOADON', 'U') IS NOT NULL DROP TABLE dbo.CHITIET_HOADON;
IF OBJECT_ID('dbo.HOADON', 'U') IS NOT NULL DROP TABLE dbo.HOADON;
IF OBJECT_ID('dbo.TONKHO', 'U') IS NOT NULL DROP TABLE dbo.TONKHO;
IF OBJECT_ID('dbo.SANPHAM', 'U') IS NOT NULL DROP TABLE dbo.SANPHAM;
GO

CREATE TABLE dbo.SANPHAM
(
    MaSP INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE dbo.TONKHO
(
    MaSP    INT NOT NULL REFERENCES dbo.SANPHAM(MaSP),
    NgayTon DATE NOT NULL,
    SLDau   INT NOT NULL,
    SLNhap  INT NOT NULL,
    SLBan   INT NOT NULL,
    PRIMARY KEY (MaSP, NgayTon)
);
GO

CREATE TABLE dbo.HOADON
(
    MaHD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NgayTao DATE NOT NULL,
    -- 0 = chua thanh toan, 1 = da thanh toan
    TinhTrangThanhToan INT NOT NULL DEFAULT 0
);
GO

CREATE TABLE dbo.CHITIET_HOADON
(
    MaHD    INT NOT NULL REFERENCES dbo.HOADON(MaHD),
    MaSP    INT NOT NULL REFERENCES dbo.SANPHAM(MaSP),
    SoLuong INT NOT NULL,
    PRIMARY KEY (MaHD, MaSP)
);
GO

-- ============================= Du lieu mau (khop voi QLCuaHangDuLieuMau) =============================
-- SET IDENTITY_INSERT dung de giu dung MaSP/MaHD = 1..5 nhu trong QLCuaHangDuLieuMau,
-- de ket qua tra ve tu CSDL that (neu dung Sql...Repository) khop voi InMemory...Repository.

SET IDENTITY_INSERT dbo.SANPHAM ON;
INSERT INTO dbo.SANPHAM (MaSP, TenSP) VALUES
    (1, N'Trà xanh'),
    (2, N'Mức dầu'),
    (3, N'Cafe'),
    (4, N'Snack khoai tây'),
    (5, N'Nước suối');
SET IDENTITY_INSERT dbo.SANPHAM OFF;
GO

INSERT INTO dbo.TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES
    (1, '2016-10-29', 50, 0, 0),
    (2, '2016-10-29', 50, 0, 0),
    (3, '2016-10-29', 50, 0, 0),
    (4, '2016-10-29', 30, 0, 0),
    (5, '2016-10-29', 40, 0, 0);
GO

SET IDENTITY_INSERT dbo.HOADON ON;
INSERT INTO dbo.HOADON (MaHD, NgayTao, TinhTrangThanhToan) VALUES
    (1, '2016-10-29', 1);
SET IDENTITY_INSERT dbo.HOADON OFF;
GO

INSERT INTO dbo.CHITIET_HOADON (MaHD, MaSP, SoLuong) VALUES
    (1, 1, 5),
    (1, 3, 2);
GO
