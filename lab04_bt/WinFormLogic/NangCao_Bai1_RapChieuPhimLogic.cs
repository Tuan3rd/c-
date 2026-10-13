namespace WinFormLogic;

// Bai 1 (nang cao): Ban ve rap chieu phim.
// Rap co 3 hang ghe, moi hang 5 ghe (ghe so 1..15). Trong bai tap nay, moi hang duoc
// xem la mot lo (hang 1 = lo A, hang 2 = lo B, hang 3 = lo C) theo dung mo ta de bai
// "co 3 hang ghe ... duoc phan thanh 3 lo".
public enum TrangThaiGhe
{
    ChuaBan,
    DangChon,
    DaBan
}

public static class NangCaoBai1RapChieuPhimLogic
{
    public const int TongSoGhe = 15;
    public const int SoGheMoiHang = 5;

    private static readonly Dictionary<char, int> GiaVeTheoLo = new()
    {
        ['A'] = 1000,
        ['B'] = 1500,
        ['C'] = 2000
    };

    public static char LayLoCuaGhe(int soGhe)
    {
        if (soGhe < 1 || soGhe > TongSoGhe)
            throw new ArgumentOutOfRangeException(nameof(soGhe), "So ghe phai tu 1 den 15");

        int chiSoHang = (soGhe - 1) / SoGheMoiHang; // 0, 1, 2
        return (char)('A' + chiSoHang);
    }

    public static int GiaVeCuaGhe(int soGhe) => GiaVeTheoLo[LayLoCuaGhe(soGhe)];

    public static int TinhThanhTien(IEnumerable<int> dsGheDangChon) => dsGheDangChon.Sum(GiaVeCuaGhe);

    // Quy tac doi mau khi click: chua ban -> dang chon; dang chon -> chua ban;
    // da ban thi giu nguyen (Form se tu hien MessageBox canh bao rieng).
    public static TrangThaiGhe ChuyenTrangThaiKhiClick(TrangThaiGhe trangThaiHienTai) => trangThaiHienTai switch
    {
        TrangThaiGhe.ChuaBan => TrangThaiGhe.DangChon,
        TrangThaiGhe.DangChon => TrangThaiGhe.ChuaBan,
        _ => trangThaiHienTai
    };
}
