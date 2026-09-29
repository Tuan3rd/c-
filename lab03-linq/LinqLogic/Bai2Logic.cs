namespace LinqLogic;

// Bai 2.1 (mang so nguyen) va Bai 2.2 (mang chuoi) - moi truy van co ban
// deu viet 2 ban Query Syntax / Method Syntax de Program.cs in ca hai,
// va de Test chung minh hai cach cho cung mot ket qua.
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
