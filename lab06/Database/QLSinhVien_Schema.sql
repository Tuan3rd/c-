-- ============================================================================
-- Co so du lieu mau QLSinhVien dung cho NNLTCS Thuc Hanh 06a - Tuong tac CSDL {1}.
-- Chay script nay tren SQL Server (vi du bang SSMS, ket noi den (localdb)\MSSQLLocalDB
-- hoac mot instance SQL Server bat ky) truoc khi doi cac Form trong Lab06WinForms sang
-- dung Sql...Repository (xem ghi chu trong tung Form, mac dinh dang dung
-- InMemory...Repository de chay thu khong can cai SQL Server).
--
-- Cau truc dung dung theo de bai:
--   Khoa (MaKhoa, TenKhoa)
--   Lop (MaLop, TenLop, MaKhoa)
--   SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop)
--   MonHoc (MaMonHoc, TenMonHoc)
--   Diem (MaSinhVien, MaMonHoc, Diem)
-- ============================================================================

IF DB_ID('QLSinhVien') IS NULL
BEGIN
    CREATE DATABASE QLSinhVien;
END
GO

USE QLSinhVien;
GO

IF OBJECT_ID('dbo.Diem', 'U') IS NOT NULL DROP TABLE dbo.Diem;
IF OBJECT_ID('dbo.SinhVien', 'U') IS NOT NULL DROP TABLE dbo.SinhVien;
IF OBJECT_ID('dbo.MonHoc', 'U') IS NOT NULL DROP TABLE dbo.MonHoc;
IF OBJECT_ID('dbo.Lop', 'U') IS NOT NULL DROP TABLE dbo.Lop;
IF OBJECT_ID('dbo.Khoa', 'U') IS NOT NULL DROP TABLE dbo.Khoa;
GO

CREATE TABLE dbo.Khoa
(
    MaKhoa  NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE dbo.Lop
(
    MaLop  NVARCHAR(15) NOT NULL PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    MaKhoa NVARCHAR(10) NOT NULL REFERENCES dbo.Khoa(MaKhoa)
);
GO

CREATE TABLE dbo.SinhVien
(
    MaSinhVien NVARCHAR(15) NOT NULL PRIMARY KEY,
    HoTen      NVARCHAR(100) NOT NULL,
    NgaySinh   DATE NULL,
    MaLop      NVARCHAR(15) NOT NULL REFERENCES dbo.Lop(MaLop)
);
GO

CREATE TABLE dbo.MonHoc
(
    MaMonHoc  NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE dbo.Diem
(
    MaSinhVien NVARCHAR(15) NOT NULL REFERENCES dbo.SinhVien(MaSinhVien),
    MaMonHoc   NVARCHAR(10) NOT NULL REFERENCES dbo.MonHoc(MaMonHoc),
    Diem       FLOAT NOT NULL,
    PRIMARY KEY (MaSinhVien, MaMonHoc)
);
GO

-- ============================= Du lieu mau (>= 5 dong moi bang) =============================
-- Dung dung du lieu duoc dinh nghia trong QLSinhVienLogic.QLSinhVienDuLieuMau, de ket
-- qua tra ve tu CSDL that (neu dung Sql...Repository) khop voi ket qua da unit test
-- tren InMemory...Repository.

INSERT INTO dbo.Khoa (MaKhoa, TenKhoa) VALUES
    (N'CNTT', N'Công Nghệ Thông Tin'),
    (N'CNTP', N'Công Nghệ Thực Phẩm'),
    (N'QTKD', N'Quản Trị Kinh Doanh'),
    (N'KT',   N'Kế Toán'),
    (N'CK',   N'Cơ Khí');
GO

INSERT INTO dbo.Lop (MaLop, TenLop, MaKhoa) VALUES
    (N'05DHTH1', N'ĐH Tin học 1', N'CNTT'),
    (N'05DHTH2', N'ĐH Tin học 2', N'CNTT'),
    (N'05CDTP1', N'CĐ Thực phẩm 1', N'CNTP'),
    (N'05DHQT1', N'ĐH Quản trị 1', N'QTKD'),
    (N'05CDKT1', N'CĐ Kế toán 1', N'KT');
GO

INSERT INTO dbo.SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES
    (N'2001140001', N'Nguyễn Văn A', '2002-03-12', N'05DHTH1'),
    (N'2001140002', N'Trần Thị B',   '2002-07-25', N'05DHTH1'),
    (N'2001140003', N'Lê Văn C',     '2001-11-02', N'05DHTH2'),
    (N'2001140004', N'Phạm Thị D',   '2002-01-18', N'05CDTP1'),
    (N'2001140005', N'Hoàng Văn E',  '2001-09-30', N'05DHQT1');
GO

INSERT INTO dbo.MonHoc (MaMonHoc, TenMonHoc) VALUES
    (N'LTC001', N'Lập trình C#'),
    (N'CSDL01', N'Cơ sở dữ liệu'),
    (N'MANG01', N'Mạng máy tính'),
    (N'TOAN01', N'Toán rời rạc'),
    (N'ANHV01', N'Anh văn chuyên ngành');
GO

INSERT INTO dbo.Diem (MaSinhVien, MaMonHoc, Diem) VALUES
    (N'2001140001', N'LTC001', 8.5),
    (N'2001140001', N'CSDL01', 7.0),
    (N'2001140002', N'LTC001', 9.0),
    (N'2001140003', N'MANG01', 6.5),
    (N'2001140004', N'TOAN01', 7.5);
GO
