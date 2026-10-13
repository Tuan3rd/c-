namespace WinForm05Logic;

// Bai 3 (mau): TreeView phong ban - nhan vien.
public static class Bai3PhongBanLogic
{
    public static readonly string[] PhongBanMacDinh = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };

    // Dung string.Compare(string, string, bool) nhu de bai goi y, bool=true -> khong phan biet hoa/thuong.
    public static bool TrungTenPhongBan(IEnumerable<string> dsPhongBanHienCo, string tenMoi) =>
        dsPhongBanHienCo.Any(pb => string.Compare(pb, tenMoi, true) == 0);

    public static string TaoNoiDungNodeNhanVien(string hoTen, string maSo) => $"{hoTen} ({maSo})";
}
