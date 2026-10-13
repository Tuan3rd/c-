namespace WinForm05ContinueLogic;

// Bai 2 (mau): ListView quan ly Ma SV - Ho ten (Them/Xoa/Sua).
public static class Bai2ListViewLogic
{
    public static bool ThongTinHopLe(string? maSV, string? hoTen) =>
        !string.IsNullOrWhiteSpace(maSV) && !string.IsNullOrWhiteSpace(hoTen);

    // "Sinh vien tu viet phuong thuc kiem tra trung ma so sinh vien truoc khi them" - yeu cau rieng cua de.
    public static bool TrungMaSinhVien(IEnumerable<string> dsMaHienCo, string maMoi) =>
        dsMaHienCo.Any(ma => string.Equals(ma, maMoi, StringComparison.OrdinalIgnoreCase));
}
