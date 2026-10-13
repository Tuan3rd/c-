using System.Globalization;

namespace WinForm05Logic;

// Bai 1 (nang cao): xu ly chuoi ten ngau nhien tren ListBox.
public static class Bai1ChuoiLogic
{
    public static readonly string[] Ho = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };

    public static readonly string[] TenLot =
    {
        "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng"
    };

    public static readonly string[] Ten =
    {
        "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm"
    };

    public static string TaoTenNgauNhien(Random ngauNhien) =>
        $"{Ho[ngauNhien.Next(Ho.Length)]} {TenLot[ngauNhien.Next(TenLot.Length)]} {Ten[ngauNhien.Next(Ten.Length)]}";

    public static List<string> TaoDanhSachTenNgauNhien(int soLuong, Random ngauNhien) =>
        Enumerable.Range(0, soLuong).Select(_ => TaoTenNgauNhien(ngauNhien)).ToList();

    // "Ten" trong de bai la tu cuoi cung cua ho ten day du (vd "Trần Anh Sơn" -> ten "Sơn").
    public static bool CoTen(string hoTenDayDu, string ten)
    {
        string[] tu = hoTenDayDu.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return tu.Length > 0 && string.Equals(tu[^1], ten, StringComparison.OrdinalIgnoreCase);
    }

    // "Ho" la tu dau tien.
    public static bool CoHo(string hoTenDayDu, string ho)
    {
        string[] tu = hoTenDayDu.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return tu.Length > 0 && string.Equals(tu[0], ho, StringComparison.OrdinalIgnoreCase);
    }

    public static string ChuyenThanhChuHoa(string s) => s.ToUpper(CultureInfo.InvariantCulture);

    public static string ChuyenThanhChuThuong(string s) => s.ToLower(CultureInfo.InvariantCulture);

    // Viet hoa ky tu dau cua moi tu, cac ky tu con lai giu nguyen chu thuong.
    public static string VietHoaDauMoiTu(string s)
    {
        string[] tu = s.Split(' ');
        for (int i = 0; i < tu.Length; i++)
        {
            if (tu[i].Length == 0)
                continue;

            tu[i] = char.ToUpper(tu[i][0], CultureInfo.InvariantCulture) +
                    tu[i][1..].ToLower(CultureInfo.InvariantCulture);
        }

        return string.Join(' ', tu);
    }
}
