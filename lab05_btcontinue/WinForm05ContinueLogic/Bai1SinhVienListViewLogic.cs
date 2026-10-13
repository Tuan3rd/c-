namespace WinForm05ContinueLogic;

// Bai 1 (BT tai lop): ListView sinh vien day du (gioi tinh, ngoai ngu, dan toc).
public static class Bai1SinhVienListViewLogic
{
    public static readonly string[] DanToc = { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" };

    public static bool ThongTinHopLe(string? hoTen, string? maSV) =>
        !string.IsNullOrWhiteSpace(hoTen) && !string.IsNullOrWhiteSpace(maSV);

    public static bool TrungMaSinhVien(IEnumerable<string> dsMaHienCo, string maMoi) =>
        dsMaHienCo.Any(ma => string.Equals(ma, maMoi, StringComparison.OrdinalIgnoreCase));

    public static string MoTaGioiTinh(bool laNam) => laNam ? "Nam" : "Nữ";

    // Ghep cac ngoai ngu duoc chon (checkbox) thanh 1 chuoi hien thi tren ListView.
    public static string MoTaNgoaiNgu(bool anh, bool phap, bool hoa)
    {
        var ds = new List<string>();
        if (anh) ds.Add("Anh");
        if (phap) ds.Add("Pháp");
        if (hoa) ds.Add("Hoa");

        return ds.Count == 0 ? "Không" : string.Join(", ", ds);
    }
}
