using System;
using System.Collections.Generic;
using System.Linq;
using LinqLogic;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
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
    static void Bai21()
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
    static void Bai22()
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
    static void Bai31()
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
    static void Bai32()
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
    static void Bai41()
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
    static void Bai51()
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
    static void Bai52()
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
    static void Bai62()
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
}
