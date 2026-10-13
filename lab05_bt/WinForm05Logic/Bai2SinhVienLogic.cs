namespace WinForm05Logic;

// Bai 2 (BT tai lop): quan ly lop - sinh vien bang TreeView + ComboBox.
public static class Bai2SinhVienLogic
{
    public static readonly string[] LopMacDinh = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

    public static bool TrungTenLop(IEnumerable<string> dsLopHienCo, string tenMoi) =>
        dsLopHienCo.Any(lop => string.Compare(lop, tenMoi, true) == 0);

    public static bool TrungMaSinhVien(IEnumerable<string> dsMaSvHienCo, string maMoi) =>
        dsMaSvHienCo.Any(ma => string.Compare(ma, maMoi, true) == 0);

    public static bool ThongTinSinhVienHopLe(string? maSV, string? hoTen, string? diaChi) =>
        !string.IsNullOrWhiteSpace(maSV) && !string.IsNullOrWhiteSpace(hoTen) && !string.IsNullOrWhiteSpace(diaChi);

    // Dung dinh dang hien thi tren node TreeView: "<Ma SV>, <Ho ten>", dong con la Dia chi.
    public static string TaoNoiDungNodeSinhVien(string maSV, string hoTen) => $"{maSV}, {hoTen}";

    // Node sinh vien co dang "MaSV, HoTen" - tach lai Ma SV de doi chieu khi click chon.
    public static string TachMaSvTuNoiDungNode(string noiDungNode)
    {
        int viTriPhay = noiDungNode.IndexOf(',');
        return viTriPhay < 0 ? noiDungNode : noiDungNode[..viTriPhay];
    }
}
