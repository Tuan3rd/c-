namespace QLSinhVienLogic;

// Du lieu mau cho 5 bang cua co so du lieu QLSinhVien, dung theo dung yeu cau cua de
// bai "sinh vien tuy chon nhap du lieu mau cho moi bang (it nhat 5 mau tin)". Dung chung
// cho ca script SQL seed du lieu (xem Database/QLSinhVien_Schema.sql) va cho cac
// InMemory...Repository khoi tao san khi Form mo len de chay thu duoc ngay.
public static class QLSinhVienDuLieuMau
{
    public static List<Khoa> KhoaMau() => new()
    {
        new Khoa { MaKhoa = "CNTT", TenKhoa = "Công Nghệ Thông Tin" },
        new Khoa { MaKhoa = "CNTP", TenKhoa = "Công Nghệ Thực Phẩm" },
        new Khoa { MaKhoa = "QTKD", TenKhoa = "Quản Trị Kinh Doanh" },
        new Khoa { MaKhoa = "KT", TenKhoa = "Kế Toán" },
        new Khoa { MaKhoa = "CK", TenKhoa = "Cơ Khí" }
    };

    public static List<Lop> LopMau() => new()
    {
        new Lop { MaLop = "05DHTH1", TenLop = "ĐH Tin học 1", MaKhoa = "CNTT" },
        new Lop { MaLop = "05DHTH2", TenLop = "ĐH Tin học 2", MaKhoa = "CNTT" },
        new Lop { MaLop = "05CDTP1", TenLop = "CĐ Thực phẩm 1", MaKhoa = "CNTP" },
        new Lop { MaLop = "05DHQT1", TenLop = "ĐH Quản trị 1", MaKhoa = "QTKD" },
        new Lop { MaLop = "05CDKT1", TenLop = "CĐ Kế toán 1", MaKhoa = "KT" }
    };

    public static List<SinhVien> SinhVienMau() => new()
    {
        new SinhVien { MaSinhVien = "2001140001", HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(2002, 3, 12), MaLop = "05DHTH1" },
        new SinhVien { MaSinhVien = "2001140002", HoTen = "Trần Thị B", NgaySinh = new DateTime(2002, 7, 25), MaLop = "05DHTH1" },
        new SinhVien { MaSinhVien = "2001140003", HoTen = "Lê Văn C", NgaySinh = new DateTime(2001, 11, 2), MaLop = "05DHTH2" },
        new SinhVien { MaSinhVien = "2001140004", HoTen = "Phạm Thị D", NgaySinh = new DateTime(2002, 1, 18), MaLop = "05CDTP1" },
        new SinhVien { MaSinhVien = "2001140005", HoTen = "Hoàng Văn E", NgaySinh = new DateTime(2001, 9, 30), MaLop = "05DHQT1" }
    };

    public static List<MonHoc> MonHocMau() => new()
    {
        new MonHoc { MaMonHoc = "LTC001", TenMonHoc = "Lập trình C#" },
        new MonHoc { MaMonHoc = "CSDL01", TenMonHoc = "Cơ sở dữ liệu" },
        new MonHoc { MaMonHoc = "MANG01", TenMonHoc = "Mạng máy tính" },
        new MonHoc { MaMonHoc = "TOAN01", TenMonHoc = "Toán rời rạc" },
        new MonHoc { MaMonHoc = "ANHV01", TenMonHoc = "Anh văn chuyên ngành" }
    };

    public static List<Diem> DiemMau() => new()
    {
        new Diem { MaSinhVien = "2001140001", MaMonHoc = "LTC001", DiemSo = 8.5 },
        new Diem { MaSinhVien = "2001140001", MaMonHoc = "CSDL01", DiemSo = 7.0 },
        new Diem { MaSinhVien = "2001140002", MaMonHoc = "LTC001", DiemSo = 9.0 },
        new Diem { MaSinhVien = "2001140003", MaMonHoc = "MANG01", DiemSo = 6.5 },
        new Diem { MaSinhVien = "2001140004", MaMonHoc = "TOAN01", DiemSo = 7.5 }
    };
}
