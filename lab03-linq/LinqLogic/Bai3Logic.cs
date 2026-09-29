namespace LinqLogic;

// Bai 3.1 (thong ke mang so) va Bai 3.2 (thong ke mang chuoi) - cac
// phuong thuc mo rong Count/Sum/Max/Min/Distinct/GroupBy.
public static class Bai3Logic
{
    // ----- Bai 3.1 -----
    public static int TongSoPhanTu(int[] mangSo) => mangSo.Count();
    public static int SoPhanTuChan(int[] mangSo) => mangSo.Count(x => x % 2 == 0);
    public static int SoPhanTuLe(int[] mangSo) => mangSo.Count(x => x % 2 != 0);
    public static int Tong(int[] mangSo) => mangSo.Sum();
    public static int GiaTriLonNhat(int[] mangSo) => mangSo.Max();
    public static int GiaTriNhoNhat(int[] mangSo) => mangSo.Min();
    public static int SoGiaTriKhacNhau(int[] mangSo) => mangSo.Distinct().Count();

    public static IEnumerable<IGrouping<int, int>> PhanNhomModulo5(int[] mangSo) =>
        mangSo.GroupBy(x => x % 5).OrderBy(g => g.Key);

    // ----- Bai 3.2 -----
    public static int DoDaiNganNhat(string[] monAn) => monAn.Min(s => s.Length);
    public static int DoDaiDaiNhat(string[] monAn) => monAn.Max(s => s.Length);

    public static IEnumerable<string> MonTenNganNhat(string[] monAn) =>
        monAn.Where(s => s.Length == DoDaiNganNhat(monAn));

    public static IEnumerable<string> MonTenDaiNhat(string[] monAn) =>
        monAn.Where(s => s.Length == DoDaiDaiNhat(monAn));

    public static IEnumerable<IGrouping<string, string>> NhomTheoTuDau(string[] monAn) =>
        monAn.GroupBy(s => s.Split(' ')[0]);

    public static int DemMonCoTuDau(string[] monAn, string tuDau) =>
        monAn.Count(s => s.Split(' ')[0] == tuDau);
}
