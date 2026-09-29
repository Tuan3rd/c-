<Query Kind="Program" />

// ============================================================================
// Ban gop 1 file cua BaiThucHanhLINQ de dan thang vao LINQPad (Query Kind = Program).
// Noi dung giong het ban VSCode (project LinqLogic + BaiThucHanhLINQ), chi gop
// lai thanh 1 file vi LINQPad khong dung project reference giua nhieu file .cs.
// Mo file nay bang LINQPad (File > Open) roi bam Run, hoac copy toan bo noi dung
// (tru dong <Query Kind="Program" /> dau tien) dan vao 1 query "C# Program" moi.
// ============================================================================

void Main()
{
    Bai21();
    Bai22();
    Bai31();
    Bai32();
    Bai41();
    Bai51();
    Bai52();
    Bai62();
}

// ================= Bai 2.1: Truy van mang so nguyen =================
void Bai21()
{
    Console.WriteLine("\n========== BAI 2.1: TRUY VAN MANG SO NGUYEN ==========");
    int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

    Console.WriteLine("\na. Cac phan tu chia het cho 4 va 3:");
    Console.WriteLine("   Query Syntax : " + string.Join(", ", Bai2Logic.ChiaHetCho4Va3_Query(mangSo)));
    Console.WriteLine("   Method Syntax: " + string.Join(", ", Bai2Logic.ChiaHetCho4Va3_Method(mangSo)));

    Console.WriteLine("\nb. Cac phan tu nho hon hoac bang 3:");
    Console.WriteLine("   Query Syntax : " + string.Join(", ", Bai2Logic.NhoHonBang3_Query(mangSo)));
    Console.WriteLine("   Method Syntax: " + string.Join(", ", Bai2Logic.NhoHonBang3_Method(mangSo)));

    Console.WriteLine("\nc. Day moi (so chan chia doi, so le giu nguyen):");
    Console.WriteLine("   Query Syntax : " + string.Join(", ", Bai2Logic.ChanChiaDoiLeGiuNguyen_Query(mangSo)));
    Console.WriteLine("   Method Syntax: " + string.Join(", ", Bai2Logic.ChanChiaDoiLeGiuNguyen_Method(mangSo)));
}

// ================= Bai 2.2: Truy van mang chuoi =================
void Bai22()
{
    Console.WriteLine("\n========== BAI 2.2: TRUY VAN MANG CHUOI ==========");
    string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

    Console.WriteLine("\na. Phan tu co 4 ky tu, sap xep tang dan theo ky tu dau tien:");
    Console.WriteLine("   Query Syntax : " + string.Join(", ", Bai2Logic.Bon4KyTuSapXep_Query(mangChuoi)));
    Console.WriteLine("   Method Syntax: " + string.Join(", ", Bai2Logic.Bon4KyTuSapXep_Method(mangChuoi)));

    Console.WriteLine("\nb. Bien doi thanh dang <chu thuong> - <CHU HOA>:");
    Console.WriteLine("   Query Syntax : " + string.Join(" | ", Bai2Logic.ThuongHoa_Query(mangChuoi)));
    Console.WriteLine("   Method Syntax: " + string.Join(" | ", Bai2Logic.ThuongHoa_Method(mangChuoi)));

    Console.WriteLine("\nc. Phan tu co chua ky tu 'u':");
    Console.WriteLine("   Query Syntax : " + string.Join(", ", Bai2Logic.ChuaKyTuU_Query(mangChuoi)));
    Console.WriteLine("   Method Syntax: " + string.Join(", ", Bai2Logic.ChuaKyTuU_Method(mangChuoi)));

    Console.WriteLine("\nd. Phan tu bat dau bang chu in hoa (ghep lai duoc 'Thuy Kieu Thuy Van'):");
    Console.WriteLine("   Query Syntax : " + string.Join(" ", Bai2Logic.BatDauChuHoa_Query(mangChuoi)));
    Console.WriteLine("   Method Syntax: " + string.Join(" ", Bai2Logic.BatDauChuHoa_Method(mangChuoi)));
}

// ================= Bai 3.1: Thong ke mang so =================
void Bai31()
{
    Console.WriteLine("\n========== BAI 3.1: THONG KE MANG SO ==========");
    int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

    int tongSoPhanTu = Bai3Logic.TongSoPhanTu(mangSo);
    int soChan = Bai3Logic.SoPhanTuChan(mangSo);
    int soLe = Bai3Logic.SoPhanTuLe(mangSo);
    Console.WriteLine($"\na. Tong so phan tu = {tongSoPhanTu}, so phan tu chan = {soChan}, so phan tu le = {soLe}");

    Console.WriteLine($"\nb. Tong cac gia tri = {Bai3Logic.Tong(mangSo)}, gia tri lon nhat = {Bai3Logic.GiaTriLonNhat(mangSo)}, gia tri nho nhat = {Bai3Logic.GiaTriNhoNhat(mangSo)}");

    Console.WriteLine($"\nc. So gia tri khac nhau trong mang = {Bai3Logic.SoGiaTriKhacNhau(mangSo)}");

    Console.WriteLine("\nd. Phan nhom theo so du khi chia cho 5:");
    foreach (var nhom in Bai3Logic.PhanNhomModulo5(mangSo))
        Console.WriteLine($"   So du {nhom.Key}: {string.Join(", ", nhom)}");
}

// ================= Bai 3.2: Thong ke mang chuoi =================
void Bai32()
{
    Console.WriteLine("\n========== BAI 3.2: THONG KE MANG CHUOI ==========");
    string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì", "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

    int doDaiNgan = Bai3Logic.DoDaiNganNhat(monAn);
    int doDaiDai = Bai3Logic.DoDaiDaiNhat(monAn);
    Console.WriteLine($"\na. Ten ngan nhat ({doDaiNgan} ky tu): {string.Join(", ", Bai3Logic.MonTenNganNhat(monAn))}");
    Console.WriteLine($"   Ten dai nhat ({doDaiDai} ky tu): {string.Join(", ", Bai3Logic.MonTenDaiNhat(monAn))}");

    Console.WriteLine("\nb. Phan nhom theo tu dau tien cua ten mon:");
    foreach (var nhom in Bai3Logic.NhomTheoTuDau(monAn))
        Console.WriteLine($"   {nhom.Key}: {string.Join(", ", nhom)}");

    Console.WriteLine($"\nc. So phan tu co tu dau tien la 'Banh' = {Bai3Logic.DemMonCoTuDau(monAn, "Bánh")}");
}

// ================= Bai 4.1: Nguon du lieu doi tuong =================
void Bai41()
{
    Console.WriteLine("\n========== BAI 4.1: DU LIEU DOI TUONG (MonHoc, He) ==========");
    Console.WriteLine("\nDanh sach mon hoc (DS_Mon):");
    foreach (var m in DuLieu.DS_Mon())
        Console.WriteLine($"   {m.MaMon,-8} {m.TenMon,-45} He={m.He,-4} SoTiet={m.SoTiet}");

    Console.WriteLine("\nDanh sach he (DS_He):");
    foreach (var h in DuLieu.DS_He())
        Console.WriteLine($"   {h.MaHe,-6} {h.TenHe}");
}

// ================= Bai 5.1: Truy van co ban tren List<MonHoc> =================
void Bai51()
{
    Console.WriteLine("\n========== BAI 5.1: TRUY VAN CO BAN TREN List<MonHoc> ==========");
    List<MonHoc> dsMon = DuLieu.DS_Mon();

    Console.WriteLine("\na. Ten cac mon hoc bat dau bang 'Lap trinh':");
    foreach (var ten in Bai5Logic.TenMonBatDauLapTrinh_Query(dsMon)) Console.WriteLine("   - " + ten);
    Console.WriteLine("   (Method Syntax cho cung ket qua, tong " + Bai5Logic.TenMonBatDauLapTrinh_Method(dsMon).Count() + " mon)");

    Console.WriteLine("\nb. Mon thuoc he 'CD', sap xep So tiet giam dan roi Ma mon tang dan:");
    foreach (var m in Bai5Logic.MonHeCD_SapXep_Query(dsMon))
        Console.WriteLine($"   {m.MaMon,-8} {m.TenMon,-45} SoTiet={m.SoTiet}");

    Console.WriteLine("\nc. Mon co ten chua 'web' (khong phan biet hoa/thuong), chi lay Ten mon va He:");
    foreach (var x in Bai5Logic.MonChuaWeb(dsMon))
        Console.WriteLine($"   {x.TenMon} ({x.He})");

    Console.WriteLine("\nd. Mon thuoc he 'KTV', sap xep tang dan theo Ma mon:");
    foreach (var m in Bai5Logic.MonHeKTV_SapXep_Query(dsMon))
        Console.WriteLine($"   {m.MaMon,-8} {m.TenMon}");
}

// ================= Bai 5.2: Thong ke tren List<MonHoc> =================
void Bai52()
{
    Console.WriteLine("\n========== BAI 5.2: THONG KE TREN List<MonHoc> ==========");
    List<MonHoc> dsMon = DuLieu.DS_Mon();

    Console.WriteLine($"\na. Tong so mon hien co = {Bai5Logic.TongSoMon(dsMon)}");

    Console.WriteLine($"\nb. So mon co ten bat dau bang 'Lap trinh' = {Bai5Logic.SoMonBatDauLapTrinh(dsMon)}");

    Console.WriteLine($"\nc. Tong so tiet cua he KTV = {Bai5Logic.TongTietHeKTV(dsMon)}");

    Console.WriteLine("\nd. Tong so mon cua moi he:");
    foreach (var x in Bai5Logic.TongMonMoiHe(dsMon))
        Console.WriteLine($"   He '{x.He}': {x.TongMon} mon");

    Console.WriteLine("\ne. Nhom theo So tiet, in So tiet va Tong so mon (giam dan theo So tiet):");
    foreach (var x in Bai5Logic.NhomTheoSoTietGiamDan(dsMon))
        Console.WriteLine($"   So tiet {x.SoTiet}: {x.TongMon} mon");

    var monCaoNhat = Bai5Logic.MonSoTietCaoNhat(dsMon);
    Console.WriteLine($"\nf. Mon co so tiet cao nhat: {monCaoNhat.MaMon} - {monCaoNhat.TenMon} (He {monCaoNhat.He}, {monCaoNhat.SoTiet} tiet)");

    Console.WriteLine("\ng. Thong ke theo He (tong mon, tong tiet, tiet cao nhat, tiet thap nhat):");
    foreach (var x in Bai5Logic.ThongKeTheoHe(dsMon))
        Console.WriteLine($"   He '{x.He}': tong mon={x.TongMon}, tong tiet={x.TongTiet}, cao nhat={x.TietCaoNhat}, thap nhat={x.TietThapNhat}");

    Console.WriteLine("\nh. Danh sach mon hoc phan nhom theo He:");
    foreach (var nhom in Bai5Logic.NhomTheoHe(dsMon))
    {
        Console.WriteLine($"   He '{nhom.Key}':");
        foreach (var m in nhom)
            Console.WriteLine($"      {m.MaMon} - {m.TenMon} ({m.SoTiet} tiet)");
    }

    Console.WriteLine("\ni. Danh sach mon hoc phan nhom theo So tiet (tang dan theo So tiet):");
    foreach (var nhom in Bai5Logic.NhomTheoSoTietTangDan(dsMon))
    {
        Console.WriteLine($"   So tiet {nhom.Key}:");
        foreach (var m in nhom)
            Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
    }

    Console.WriteLine("\nj. He KTV, phan nhom theo hoc phan (HP2, HP3, HP4, HP5), sap xep theo Ma mon:");
    foreach (var nhom in Bai5Logic.NhomHocPhanKTV(dsMon))
    {
        Console.WriteLine($"   {nhom.Key}:");
        foreach (var m in nhom.OrderBy(m => m.MaMon))
            Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
    }

    Console.WriteLine("\nk. Phan nhom theo He, chi lay mon co So tiet > 40, sap xep theo Ma mon trong tung nhom:");
    foreach (var nhom in Bai5Logic.NhomHeLocSoTietTren40(dsMon))
    {
        Console.WriteLine($"   He '{nhom.Key}':");
        foreach (var m in nhom.OrderBy(m => m.MaMon))
            Console.WriteLine($"      {m.MaMon} - {m.TenMon} ({m.SoTiet} tiet)");
    }
}

// ================= Bai 6.2: Join tren hai nguon du lieu =================
void Bai62()
{
    Console.WriteLine("\n========== BAI 6.2: JOIN TREN HAI NGUON DU LIEU ==========");
    List<MonHoc> dsMon = DuLieu.DS_Mon();
    List<He> dsHe = DuLieu.DS_He();

    Console.WriteLine("\na. Join (inner join): Ten he - Ma mon - Ten mon:");
    foreach (var x in Bai6Logic.InnerJoin(dsMon, dsHe))
        Console.WriteLine($"   {x.TenHe,-20} {x.MaMon,-8} {x.TenMon}");

    Console.WriteLine("\nb. Left outer join (GroupJoin + DefaultIfEmpty), bao gom ca he chua co mon:");
    foreach (var x in Bai6Logic.LeftOuterJoin(dsHe, dsMon))
        Console.WriteLine($"   {x.TenHe,-20} {x.MaMon,-16} {x.TenMon}");

    Console.WriteLine("\nc. Ca he chua co mon va mon chua khai bao he (full outer join):");
    foreach (var x in Bai6Logic.FullOuterJoin(dsHe, dsMon))
        Console.WriteLine($"   He: {x.TenHe ?? "(khong co)",-20} Mon: {x.MaMon ?? "(khong co)",-8} {x.TenMon}");

    Console.WriteLine("\nd. Chi rieng he chua co mon va mon chua khai bao he (bo phan da khop):");
    foreach (var tenHe in Bai6Logic.HeChuaCoMon(dsHe, dsMon))
        Console.WriteLine($"   He chua co mon: {tenHe}");
    foreach (var maMon in Bai6Logic.MonChuaKhaiBaoHe(dsMon, dsHe))
        Console.WriteLine($"   Mon chua khai bao he: {maMon}");

    Console.WriteLine("\ne. 5 mon dau tien co so tiet giam dan (Ten he, Ma mon, Ten mon, So tiet):");
    foreach (var x in Bai6Logic.Top5GiamDanSoTiet(dsMon, dsHe))
        Console.WriteLine($"   {x.TenHe,-20} {x.MaMon,-8} {x.TenMon,-45} {x.SoTiet} tiet");

    Console.WriteLine("\nf. Tong so mon hoc cua moi he (Ma he, Ten he, Tong so mon):");
    foreach (var x in Bai6Logic.TongMonMoiHe(dsHe, dsMon))
        Console.WriteLine($"   {x.MaHe,-6} {x.TenHe,-20} Tong mon = {x.TongMon}");

    Console.WriteLine($"\ng. So loai So tiet khac nhau trong danh sach mon hoc = {Bai6Logic.SoLoaiSoTietKhacNhau(dsMon)}");

    var monDauTien = Bai6Logic.MonDauTienBatDauLapTrinh(dsMon);
    Console.WriteLine($"\nh. Mon hoc dau tien co ten bat dau bang 'Lap trinh': {monDauTien?.MaMon} - {monDauTien?.TenMon}");

    Console.WriteLine("\ni. Danh sach mon theo tung he, danh so thu tu trong moi nhom:");
    foreach (var nhom in Bai5Logic.NhomTheoHe(dsMon))
    {
        Console.WriteLine($"   He '{nhom.Key}':");
        int stt = 1;
        foreach (var m in nhom)
            Console.WriteLine($"      {stt++}. {m.MaMon} - {m.TenMon}");
    }
}

// ============================================================================
// LinqLogic - Bai 2.1 / 2.2: truy van co ban tren mang (where/orderby/select)
// ============================================================================
public static class Bai2Logic
{
    // ----- Bai 2.1 -----
    public static IEnumerable<int> ChiaHetCho4Va3_Query(int[] mangSo) =>
        from x in mangSo where x % 4 == 0 && x % 3 == 0 select x;

    public static IEnumerable<int> ChiaHetCho4Va3_Method(int[] mangSo) =>
        mangSo.Where(x => x % 4 == 0 && x % 3 == 0);

    public static IEnumerable<int> NhoHonBang3_Query(int[] mangSo) =>
        from x in mangSo where x <= 3 select x;

    public static IEnumerable<int> NhoHonBang3_Method(int[] mangSo) =>
        mangSo.Where(x => x <= 3);

    public static IEnumerable<int> ChanChiaDoiLeGiuNguyen_Query(int[] mangSo) =>
        from x in mangSo select x % 2 == 0 ? x / 2 : x;

    public static IEnumerable<int> ChanChiaDoiLeGiuNguyen_Method(int[] mangSo) =>
        mangSo.Select(x => x % 2 == 0 ? x / 2 : x);

    // ----- Bai 2.2 -----
    public static IEnumerable<string> Bon4KyTuSapXep_Query(string[] mangChuoi) =>
        from s in mangChuoi where s.Length == 4 orderby s[0] select s;

    public static IEnumerable<string> Bon4KyTuSapXep_Method(string[] mangChuoi) =>
        mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);

    public static IEnumerable<string> ThuongHoa_Query(string[] mangChuoi) =>
        from s in mangChuoi select s.ToLower() + " - " + s.ToUpper();

    public static IEnumerable<string> ThuongHoa_Method(string[] mangChuoi) =>
        mangChuoi.Select(s => s.ToLower() + " - " + s.ToUpper());

    public static IEnumerable<string> ChuaKyTuU_Query(string[] mangChuoi) =>
        from s in mangChuoi where s.Contains('u') select s;

    public static IEnumerable<string> ChuaKyTuU_Method(string[] mangChuoi) =>
        mangChuoi.Where(s => s.Contains('u'));

    public static IEnumerable<string> BatDauChuHoa_Query(string[] mangChuoi) =>
        from s in mangChuoi where char.IsUpper(s[0]) select s;

    public static IEnumerable<string> BatDauChuHoa_Method(string[] mangChuoi) =>
        mangChuoi.Where(s => char.IsUpper(s[0]));
}

// ============================================================================
// LinqLogic - Bai 3.1 / 3.2: Count/Sum/Max/Min/Distinct/GroupBy tren mang
// ============================================================================
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

// ============================================================================
// LinqLogic - Bai 5.1 / 5.2: truy van co ban + thong ke tren List<MonHoc>
// ============================================================================
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
    // thu tu "sap xep theo Ma mon" ma de bai yeu cau, khong phai doi noi goi
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

// ============================================================================
// LinqLogic - Bai 6.2: join va cac toan tu tap hop tren 2 nguon (MonHoc, He)
// ============================================================================
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

// ============================================================================
// Nguon du lieu doi tuong: MonHoc, He, DuLieu (Bai 4.1 va Bai 6.1)
// ============================================================================

// He o day luu Ma he (vd "KTV", "CD"), khong phai Ten he day du -
// muon lay Ten he phai join sang List<He> (xem Bai6Logic)
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public static class DuLieu
{
    // Mon XYZ co He de trong va SoTiet = 0 (mon "chua khai bao he") -
    // he QT trong DS_He() lai khong co mon nao ca (he "chua co mon") -
    // hai truong hop nay duoc dung o Bai6Logic (outer join) de minh hoa.
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new MonHoc { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new MonHoc { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new MonHoc { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 },
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD", TenHe = "Chuyên đề" },
            new He { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" },
        };
    }
}
