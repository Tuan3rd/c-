namespace WinForm05Logic;

// Bai 2 (mau): ComboBox dan toc - load du lieu va hien thi lua chon theo 2 cach.
public static class Bai2DanTocLogic
{
    public static readonly string[] DanhSachDanToc = { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" };

    public static string TaoThongBaoHienThi(string? danTocDangChon) =>
        string.IsNullOrEmpty(danTocDangChon)
            ? "Bạn chưa chọn dân tộc"
            : $"Dân tộc được chọn: {danTocDangChon}";
}
