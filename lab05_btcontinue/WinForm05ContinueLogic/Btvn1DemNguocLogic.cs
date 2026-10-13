namespace WinForm05ContinueLogic;

// Bai 1 (BT ve nha): dem nguoc thoi gian, bat dau tu 30:00.
public static class Btvn1DemNguocLogic
{
    public static readonly TimeSpan ThoiGianBanDau = TimeSpan.FromMinutes(30);

    public static TimeSpan GiamMotGiay(TimeSpan hienTai) =>
        hienTai > TimeSpan.Zero ? hienTai - TimeSpan.FromSeconds(1) : TimeSpan.Zero;

    // Dung dang "mm:ss" giong hinh minh hoa de bai ("30:00").
    public static string DinhDang(TimeSpan thoiGian) =>
        $"{(int)thoiGian.TotalMinutes:00}:{thoiGian.Seconds:00}";

    public static bool DaKetThuc(TimeSpan thoiGian) => thoiGian <= TimeSpan.Zero;
}
