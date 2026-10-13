using System.Globalization;

namespace WinForm05ContinueLogic;

// Bai 2 (BT tai lop): quan ly thong tin tai khoan ngan hang.
public static class Bai2TaiKhoanLogic
{
    public static bool ThongTinHopLe(string? soTaiKhoan, string? tenKhachHang, string? diaChi, string? soTienText) =>
        !string.IsNullOrWhiteSpace(soTaiKhoan) &&
        !string.IsNullOrWhiteSpace(tenKhachHang) &&
        !string.IsNullOrWhiteSpace(diaChi) &&
        LaSoTienHopLe(soTienText, out _);

    public static bool LaSoTienHopLe(string? text, out decimal soTien) =>
        decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out soTien) && soTien >= 0;

    public static bool TrungSoTaiKhoan(IEnumerable<string> dsSoTaiKhoanHienCo, string soMoi) =>
        dsSoTaiKhoanHienCo.Any(stk => string.Equals(stk, soMoi, StringComparison.OrdinalIgnoreCase));

    public static decimal TinhTongTien(IEnumerable<decimal> dsSoTien) => dsSoTien.Sum();
}
