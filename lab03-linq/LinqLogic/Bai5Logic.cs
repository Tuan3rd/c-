namespace LinqLogic;

// Bai 5.1 (truy van co ban) va Bai 5.2 (thong ke) tren List<MonHoc>.
public static class Bai5Logic
{
    // ----- Bai 5.1 -----
    public static IEnumerable<string> TenMonBatDauLapTrinh_Query(List<MonHoc> ds) =>
        from m in ds where m.TenMon.StartsWith("Lập trình") select m.TenMon;

    public static IEnumerable<string> TenMonBatDauLapTrinh_Method(List<MonHoc> ds) =>
        ds.Where(m => m.TenMon.StartsWith("Lập trình")).Select(m => m.TenMon);

    public static IEnumerable<MonHoc> MonHeCD_SapXep_Query(List<MonHoc> ds) =>
        from m in ds where m.He == "CD" orderby m.SoTiet descending, m.MaMon select m;

    public static IEnumerable<MonHoc> MonHeCD_SapXep_Method(List<MonHoc> ds) =>
        ds.Where(m => m.He == "CD").OrderByDescending(m => m.SoTiet).ThenBy(m => m.MaMon);

    public static IEnumerable<(string TenMon, string He)> MonChuaWeb(List<MonHoc> ds) =>
        ds.Where(m => m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
          .Select(m => (m.TenMon, m.He));

    public static IEnumerable<MonHoc> MonHeKTV_SapXep_Query(List<MonHoc> ds) =>
        from m in ds where m.He == "KTV" orderby m.MaMon select m;

    public static IEnumerable<MonHoc> MonHeKTV_SapXep_Method(List<MonHoc> ds) =>
        ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);

    // ----- Bai 5.2 -----
    public static int TongSoMon(List<MonHoc> ds) => ds.Count;

    public static int SoMonBatDauLapTrinh(List<MonHoc> ds) =>
        ds.Count(m => m.TenMon.StartsWith("Lập trình"));

    public static int TongTietHeKTV(List<MonHoc> ds) =>
        ds.Where(m => m.He == "KTV").Sum(m => m.SoTiet);

    public static IEnumerable<(string He, int TongMon)> TongMonMoiHe(List<MonHoc> ds) =>
        ds.GroupBy(m => m.He).Select(g => (g.Key, g.Count()));

    public static IEnumerable<(byte SoTiet, int TongMon)> NhomTheoSoTietGiamDan(List<MonHoc> ds) =>
        ds.GroupBy(m => m.SoTiet).OrderByDescending(g => g.Key).Select(g => (g.Key, g.Count()));

    public static MonHoc MonSoTietCaoNhat(List<MonHoc> ds) =>
        ds.OrderByDescending(m => m.SoTiet).First();

    public static IEnumerable<(string He, int TongMon, int TongTiet, byte TietCaoNhat, byte TietThapNhat)> ThongKeTheoHe(List<MonHoc> ds) =>
        ds.GroupBy(m => m.He)
          .Select(g => (g.Key, g.Count(), g.Sum(m => m.SoTiet), g.Max(m => m.SoTiet), g.Min(m => m.SoTiet)));

    public static IEnumerable<IGrouping<string, MonHoc>> NhomTheoHe(List<MonHoc> ds) =>
        ds.GroupBy(m => m.He);

    public static IEnumerable<IGrouping<byte, MonHoc>> NhomTheoSoTietTangDan(List<MonHoc> ds) =>
        ds.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);

    // Sap xep theo MaMon TRUOC khi GroupBy, vi GroupBy giu nguyen thu tu phan tu
    // trong tung nhom theo thu tu cua nguon - nho vay moi nhom da san sang dung
    // thu tu "sap xep theo Ma mon" ma de bai yeu cau, khong phai doi Program.cs
    // sap lai luc in.
    public static IEnumerable<IGrouping<string, MonHoc>> NhomHocPhanKTV(List<MonHoc> ds) =>
        ds.Where(m => m.He == "KTV")
          .OrderBy(m => m.MaMon)
          .GroupBy(m => m.MaMon.Substring(0, 3))
          .OrderBy(g => g.Key);

    public static IEnumerable<IGrouping<string, MonHoc>> NhomHeLocSoTietTren40(List<MonHoc> ds)
    {
        var loc = ds.Where(m => m.SoTiet > 40).ToList();
        // Sap theo Ma mon CHI trong tung nhom - giu nguyen thu tu he xuat hien
        // truoc/sau (KTV truoc CD) bang cach sap theo chi so xuat hien dau tien
        // cua He, roi moi den Ma mon; sap thang theo Ma mon toan cuc se lam xao
        // tron thu tu giua cac nhom vi ma mon cua CD/KTV dan xen chu cai.
        var thuTuHe = loc.Select(m => m.He).Distinct().ToList();
        return loc.OrderBy(m => thuTuHe.IndexOf(m.He))
                  .ThenBy(m => m.MaMon)
                  .GroupBy(m => m.He);
    }
}
