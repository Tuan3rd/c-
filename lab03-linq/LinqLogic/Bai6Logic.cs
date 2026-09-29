namespace LinqLogic;

// Bai 6.2 - join va cac toan tu tap hop tren 2 nguon: List<MonHoc> va List<He>.
public static class Bai6Logic
{
    public static IEnumerable<(string TenHe, string MaMon, string TenMon)> InnerJoin(List<MonHoc> dsMon, List<He> dsHe) =>
        from m in dsMon
        join h in dsHe on m.He equals h.MaHe
        select (h.TenHe, m.MaMon, m.TenMon);

    public static IEnumerable<(string TenHe, string MaMon, string TenMon)> LeftOuterJoin(List<He> dsHe, List<MonHoc> dsMon) =>
        from h in dsHe
        join m in dsMon on h.MaHe equals m.He into monCuaHe
        from m in monCuaHe.DefaultIfEmpty()
        select (h.TenHe, m?.MaMon ?? "(chua co mon)", m?.TenMon ?? "");

    public static IEnumerable<(string? TenHe, string? MaMon, string? TenMon)> FullOuterJoin(List<He> dsHe, List<MonHoc> dsMon)
    {
        var heGhepMon = from h in dsHe
                        join m in dsMon on h.MaHe equals m.He into monCuaHe
                        from m in monCuaHe.DefaultIfEmpty()
                        select ((string?)h.TenHe, m?.MaMon, m?.TenMon);

        var monChuaCoHe = from m in dsMon
                          join h in dsHe on m.He equals h.MaHe into heCuaMon
                          from h in heCuaMon.DefaultIfEmpty()
                          where h == null
                          select ((string?)null, (string?)m.MaMon, (string?)m.TenMon);

        return heGhepMon.Concat(monChuaCoHe);
    }

    public static IEnumerable<string> HeChuaCoMon(List<He> dsHe, List<MonHoc> dsMon) =>
        from h in dsHe
        join m in dsMon on h.MaHe equals m.He into monCuaHe
        where !monCuaHe.Any()
        select h.TenHe;

    public static IEnumerable<string> MonChuaKhaiBaoHe(List<MonHoc> dsMon, List<He> dsHe) =>
        from m in dsMon
        join h in dsHe on m.He equals h.MaHe into heCuaMon
        where !heCuaMon.Any()
        select m.MaMon;

    public static IEnumerable<(string TenHe, string MaMon, string TenMon, byte SoTiet)> Top5GiamDanSoTiet(List<MonHoc> dsMon, List<He> dsHe) =>
        (from m in dsMon
         join h in dsHe on m.He equals h.MaHe
         orderby m.SoTiet descending
         select (h.TenHe, m.MaMon, m.TenMon, m.SoTiet)).Take(5);

    public static IEnumerable<(string MaHe, string TenHe, int TongMon)> TongMonMoiHe(List<He> dsHe, List<MonHoc> dsMon) =>
        from h in dsHe
        join m in dsMon on h.MaHe equals m.He into monCuaHe
        select (h.MaHe, h.TenHe, monCuaHe.Count());

    public static int SoLoaiSoTietKhacNhau(List<MonHoc> dsMon) =>
        dsMon.Select(m => m.SoTiet).Distinct().Count();

    public static MonHoc? MonDauTienBatDauLapTrinh(List<MonHoc> dsMon) =>
        dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
}
