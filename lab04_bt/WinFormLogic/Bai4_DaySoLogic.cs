namespace WinFormLogic;

// Bai 4 (BT tai lop): Nhap mot day so nguyen, tinh tong - tong chan - tong le.
public static class Bai4DaySoLogic
{
    public static bool LaSoNguyenHopLe(string? text, out int giaTri) =>
        int.TryParse(text, out giaTri);

    public static int TongCacPhanTu(IEnumerable<int> daySo) => daySo.Sum();

    public static int TongChan(IEnumerable<int> daySo) => daySo.Where(x => x % 2 == 0).Sum();

    public static int TongLe(IEnumerable<int> daySo) => daySo.Where(x => x % 2 != 0).Sum();
}
