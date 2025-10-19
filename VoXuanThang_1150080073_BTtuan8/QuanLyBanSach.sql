-- Tạo cơ sở dữ liệu QuanLyBanSach
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QuanLyBanSach')
BEGIN
    CREATE DATABASE QuanLyBanSach;
END
GO

USE QuanLyBanSach;
GO

-- Xóa bảng nếu tồn tại
IF OBJECT_ID('dbo.Sach', 'U') IS NOT NULL DROP TABLE dbo.Sach;
IF OBJECT_ID('dbo.NhaXuatBan', 'U') IS NOT NULL DROP TABLE dbo.NhaXuatBan;
GO

-- Tạo bảng NhaXuatBan
CREATE TABLE NhaXuatBan
(
    XB CHAR(10) PRIMARY KEY,
    TenXB NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(500)
);
GO

-- Tạo bảng Sach
CREATE TABLE Sach
(
    MaSach CHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(300) NOT NULL,
    XB CHAR(10),
    TenTacGia NVARCHAR(100),
    NamXuatBan DATETIME,
    GhiChu NVARCHAR(500),
    FOREIGN KEY (XB) REFERENCES NhaXuatBan(XB)
);
GO

-- Thêm dữ liệu cho bảng NhaXuatBan
INSERT INTO NhaXuatBan VALUES ('001', 'Học viện X-men', 'Quang Trung, Hà Nội');
INSERT INTO NhaXuatBan VALUES ('002', 'Khoa học xã hội', 'Trần Phú, Hà Nội');
INSERT INTO NhaXuatBan VALUES ('003', 'Viện văn hóa thể thao', 'Bà Triệu, Hà Nội');
GO

-- Thêm dữ liệu cho bảng Sach
INSERT INTO Sach VALUES ('1', 'Học lập trình C#', '001', 'Nguyễn Lưu', CONVERT(DATETIME, '2022'), 'Khác');
INSERT INTO Sach VALUES ('2', 'Lập trình ASP.NET Core', '002', 'Trọng Khải', CONVERT(DATETIME, '2019'), 'Khác');
INSERT INTO Sach VALUES ('3', 'Lập trình Scratch', '002', 'Bá Trọng', CONVERT(DATETIME, '2022'), 'Khác');
GO

-- Tạo Stored Procedure: Hiển thị danh sách nhà xuất bản
CREATE PROCEDURE HienThiXB
AS
BEGIN
    SELECT XB, TenXB, DiaChi FROM NhaXuatBan;
END;
GO

-- Tạo Stored Procedure: Hiển thị chi tiết nhà xuất bản theo mã
CREATE PROCEDURE HienThiChiTietXB
    @maXB CHAR(10)
AS
BEGIN
    SELECT XB, TenXB, DiaChi FROM NhaXuatBan WHERE XB = @maXB;
END;
GO

-- Tạo Stored Procedure: Thêm dữ liệu
CREATE PROCEDURE ThemDuLieu
    @maXB CHAR(10),
    @tenXB NVARCHAR(100),
    @diaChi NVARCHAR(500)
AS
BEGIN
    INSERT INTO NhaXuatBan (XB, TenXB, DiaChi) VALUES (@maXB, @tenXB, @diaChi);
END;
GO

-- Tạo Stored Procedure: Sửa dữ liệu
CREATE PROCEDURE SuaDuLieu
    @maXB CHAR(10),
    @tenXB NVARCHAR(100),
    @diaChi NVARCHAR(500)
AS
BEGIN
    UPDATE NhaXuatBan SET TenXB = @tenXB, DiaChi = @diaChi WHERE XB = @maXB;
END;
GO

-- Tạo Stored Procedure: Xóa dữ liệu
CREATE PROCEDURE XoaDuLieu
    @maXB CHAR(10)
AS
BEGIN
    DELETE FROM NhaXuatBan WHERE XB = @maXB;
END;
GO
