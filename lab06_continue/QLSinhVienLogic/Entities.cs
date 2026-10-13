namespace QLSinhVienLogic;

// Cac thuc the tuong ung voi 5 bang trong co so du lieu mau QLSinhVien:
// Khoa(MaKhoa, TenKhoa); Lop(MaLop, TenLop, MaKhoa); SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop);
// MonHoc(MaMonHoc, TenMonHoc); Diem(MaSinhVien, MaMonHoc, Diem).
public class Khoa
{
    public required string MaKhoa { get; set; }
    public required string TenKhoa { get; set; }
}

public class Lop
{
    public required string MaLop { get; set; }
    public required string TenLop { get; set; }
    public required string MaKhoa { get; set; }
}

public class SinhVien
{
    public required string MaSinhVien { get; set; }
    public required string HoTen { get; set; }
    public DateTime? NgaySinh { get; set; }
    public required string MaLop { get; set; }
}

public class MonHoc
{
    public required string MaMonHoc { get; set; }
    public required string TenMonHoc { get; set; }
}

public class Diem
{
    public required string MaSinhVien { get; set; }
    public required string MaMonHoc { get; set; }
    public double DiemSo { get; set; }
}
