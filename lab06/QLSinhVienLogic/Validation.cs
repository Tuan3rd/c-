using System.Globalization;

namespace QLSinhVienLogic;

// Quy tac bat buoc/khong bat buoc tung truong, lay dung tu phan "Yeu cau" cua tung bai
// trong de bai - moi bai co quy tac khac nhau ro ret nen tach rieng tung class.

// Bai mau + Bai 1 (tai lop): Khoa va MonHoc - ca 2 truong deu bat buoc cho ca Them/Xoa/Sua.
public static class KhoaValidation
{
    public static bool ThemHopLe(string? maKhoa, string? tenKhoa) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(tenKhoa);

    public static bool XoaHopLe(string? maKhoa) => !string.IsNullOrWhiteSpace(maKhoa);

    public static bool SuaHopLe(string? maKhoa, string? tenKhoa) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(tenKhoa);
}

public static class MonHocValidation
{
    public static bool ThemHopLe(string? maMonHoc, string? tenMonHoc) =>
        !string.IsNullOrWhiteSpace(maMonHoc) && !string.IsNullOrWhiteSpace(tenMonHoc);

    // "Ma mon hoc khong duoc de trong, Ten mon hoc khong nhap du lieu" -> chi can Ma.
    public static bool XoaHopLe(string? maMonHoc) => !string.IsNullOrWhiteSpace(maMonHoc);

    public static bool SuaHopLe(string? maMonHoc, string? tenMonHoc) =>
        !string.IsNullOrWhiteSpace(maMonHoc) && !string.IsNullOrWhiteSpace(tenMonHoc);
}

// Bai ve nha: Lop - Them: ca 3 bat buoc. Xoa: chi MaLop. Sua: MaLop bat buoc, con lai
// chi can it nhat 1 trong 2 (TenLop/MaKhoa) co du lieu.
public static class LopValidation
{
    public static bool ThemHopLe(string? maKhoa, string? maLop, string? tenLop) =>
        !string.IsNullOrWhiteSpace(maKhoa) && !string.IsNullOrWhiteSpace(maLop) && !string.IsNullOrWhiteSpace(tenLop);

    public static bool XoaHopLe(string? maLop) => !string.IsNullOrWhiteSpace(maLop);

    public static bool SuaHopLe(string? maLop, string? maKhoaMoi, string? tenLopMoi) =>
        !string.IsNullOrWhiteSpace(maLop) &&
        (!string.IsNullOrWhiteSpace(maKhoaMoi) || !string.IsNullOrWhiteSpace(tenLopMoi));
}

// Bai nang cao 1: SinhVien - Them: ca 4 bat buoc. Xoa: MaSV + HoTen bat buoc (dung de
// so trung truoc khi xoa). Sua: MaSV bat buoc, con lai chi can it nhat 1 trong 3 co du lieu.
public static class SinhVienValidation
{
    public static bool ThemHopLe(string? maLop, string? maSinhVien, string? hoTen, string? ngaySinhText) =>
        !string.IsNullOrWhiteSpace(maLop) &&
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        !string.IsNullOrWhiteSpace(hoTen) &&
        !string.IsNullOrWhiteSpace(ngaySinhText);

    public static bool XoaHopLe(string? maSinhVien, string? hoTen) =>
        !string.IsNullOrWhiteSpace(maSinhVien) && !string.IsNullOrWhiteSpace(hoTen);

    public static bool SuaHopLe(string? maSinhVien, string? maLopMoi, string? hoTenMoi, string? ngaySinhMoiText) =>
        !string.IsNullOrWhiteSpace(maSinhVien) &&
        (!string.IsNullOrWhiteSpace(maLopMoi) || !string.IsNullOrWhiteSpace(hoTenMoi) || !string.IsNullOrWhiteSpace(ngaySinhMoiText));

    public static bool NgaySinhHopLe(string? text, out DateTime ngaySinh) =>
        DateTime.TryParse(text, CultureInfo.GetCultureInfo("vi-VN"), DateTimeStyles.None, out ngaySinh);
}

// Bai nang cao 2: Diem - Them: ca 3 bat buoc, Diem phai la so. Xoa: MaSV + MaMonHoc bat
// buoc, Diem khong can nhap. Sua: MaSV + MaMonHoc bat buoc, Diem bat buoc va phai la so.
public static class DiemValidation
{
    public static bool LaDiemHopLe(string? text, out double diem) =>
        double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out diem) && diem >= 0;

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
