using System.Globalization;

namespace QLSinhVienLogic;

// Quy tac bat buoc/khong bat buoc tung truong, lay dung tu phan "Yeu cau" cua tung bai.
// So voi lab06 (Thuc hanh 06a), lab nay (06b) bo sung them: kiem tra tuoi sinh vien,
// gioi han Diem trong khoang 0-10 (chat hon lab truoc chi yeu cau >= 0), va cac dieu
// kien rang buoc khoa ngoai (vd: khong duoc xoa Lop con Sinh vien).
public static class KhoaValidation
{
    public static bool ThemHopLe(string? maKhoa, string? tenKhoa) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(tenKhoa);

    public static bool XoaHopLe(string? maKhoa) => !string.IsNullOrWhiteSpace(maKhoa);

    public static bool SuaHopLe(string? maKhoa, string? tenKhoa) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(tenKhoa);
}

public static class LopValidation
{
    // "Lưu ý: không cho rỗng mã lớp khi thêm" - de bai con bat buoc ca Ten lop, Ma khoa.
    public static bool ThemHopLe(string? maKhoa, string? maLop, string? tenLop) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(maLop) && !string.IsNullOrWhiteSpace(tenLop);

    public static bool XoaHopLe(string? maLop) => !string.IsNullOrWhiteSpace(maLop);

    public static bool SuaHopLe(string? maLop, string? maKhoaMoi, string? tenLopMoi) =>
        !string.IsNullOrWhiteSpace(maLop) &&
        !string.IsNullOrWhiteSpace(maKhoaMoi) && !string.IsNullOrWhiteSpace(tenLopMoi);

    // Rang buoc khoa ngoai: khong cho xoa mot Lop neu van con Sinh vien thuoc lop do
    // (tuong duong viec SQL Server tu choi DELETE khi vi pham FOREIGN KEY).
    public static bool CoTheXoa(string maLop, IEnumerable<SinhVien> dsSinhVienHienCo) =>
        !dsSinhVienHienCo.Any(sv => sv.MaLop == maLop);
}

// Bai 1 (tai lop): SinhVien.
public static class SinhVienValidation
{
    public const int TuoiToiThieu = 17;

    public static bool ThemHopLe(string? maLop, string? maSinhVien, string? hoTen, string? ngaySinhText) =>
        !string.IsNullOrWhiteSpace(maLop) &&
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        !string.IsNullOrWhiteSpace(hoTen) &&
        !string.IsNullOrWhiteSpace(ngaySinhText);

    public static bool XoaHopLe(string? maSinhVien) => !string.IsNullOrWhiteSpace(maSinhVien);

    public static bool SuaHopLe(string? maSinhVien, string? maLop, string? hoTen, string? ngaySinhText) =>
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        !string.IsNullOrWhiteSpace(maLop) &&
        !string.IsNullOrWhiteSpace(hoTen) &&
        !string.IsNullOrWhiteSpace(ngaySinhText);

    public static bool NgaySinhHopLe(string? text, out DateTime ngaySinh) =>
        DateTime.TryParse(text, CultureInfo.GetCultureInfo("vi-VN"), DateTimeStyles.None, out ngaySinh);

    // "Sinh viên phải có tuổi từ 17 trở lên (chỉ tính theo năm sinh)" - khong tinh ngay/thang,
    // chi so sanh hieu nam.
    public static bool TuoiHopLe(DateTime ngaySinh, DateTime? homNay = null) =>
        (homNay ?? DateTime.Today).Year - ngaySinh.Year >= TuoiToiThieu;
}

// Bai 2 (tai lop): Diem. Khac lab06 truoc: de bai nay bat buoc Diem nam trong [0, 10].
public static class DiemValidation
{
    public static bool LaDiemHopLe(string? text, out double diem) =>
        double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out diem) &&
        diem >= 0 && diem <= 10;

    public static bool ThemHopLe(string? maSinhVien, string? maMonHoc, string? diemText) =>
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        !string.IsNullOrWhiteSpace(maMonHoc) &&
        LaDiemHopLe(diemText, out _);

    public static bool XoaHopLe(string? maSinhVien, string? maMonHoc) =>
        !string.IsNullOrWhiteSpace(maSinhVien) && !string.IsNullOrWhiteSpace(maMonHoc);

    public static bool SuaHopLe(string? maSinhVien, string? maMonHoc, string? diemText) =>
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        !string.IsNullOrWhiteSpace(maMonHoc) &&
        LaDiemHopLe(diemText, out _);
}
