namespace WinFormContinueLogic;

public enum LoaiCafe
{
    CafeDen,
    CafeDa,
    CafeSua,
    CafeSuaDa,
    CafeKem
}

public enum LoaiThucAn
{
    BanhMyTrung,
    BanhMyCa,
    MyTomTrung,
    MyXaoBo,
    MyCay
}

// Bai 1 (nang cao): tinh tien cho quan Cafe Sinh Vien.
// Gia niem yet va cong thuc giam gia Sinh Vien (20%) deu nam trong lop nay de co
// the unit test day du ma khong can dung Form.
public static class CafeSinhVienLogic
{
    private static readonly Dictionary<LoaiCafe, int> GiaCafe = new()
    {
        [LoaiCafe.CafeDen] = 20_000,
        [LoaiCafe.CafeDa] = 25_000,
        [LoaiCafe.CafeSua] = 25_000,
        [LoaiCafe.CafeSuaDa] = 30_000,
        [LoaiCafe.CafeKem] = 35_000
    };

    private static readonly Dictionary<LoaiThucAn, int> GiaThucAn = new()
    {
        [LoaiThucAn.BanhMyTrung] = 15_000,
        [LoaiThucAn.BanhMyCa] = 15_000,
        [LoaiThucAn.MyTomTrung] = 20_000,
        [LoaiThucAn.MyXaoBo] = 30_000,
        [LoaiThucAn.MyCay] = 50_000
    };

    private const double TyLeGiamGiaSinhVien = 0.2;

    public static int GiaCuaCafe(LoaiCafe loai) => GiaCafe[loai];

    public static int GiaCuaThucAn(LoaiThucAn loai) => GiaThucAn[loai];

    public static bool TenKhachHangHopLe(string? ten) => !string.IsNullOrWhiteSpace(ten);

    // cafe co the null (khach khong goi nuoc); dsThucAn co the rong (khong goi do an).
    public static int TinhTien(LoaiCafe? cafe, IEnumerable<LoaiThucAn> dsThucAn, bool laSinhVien)
    {
        int tongTien = 0;

        if (cafe.HasValue)
            tongTien += GiaCuaCafe(cafe.Value);

        tongTien += dsThucAn.Sum(GiaCuaThucAn);

        if (laSinhVien)
            tongTien -= (int)(tongTien * TyLeGiamGiaSinhVien);

        return tongTien;
    }

    // Tong ket cuoi buoi: cong don danh sach so tien cua tung luot khach da thanh toan.
    public static (int TongLuotKhach, int TongTien) TongKet(IEnumerable<int> dsSoTienDaThanhToan)
    {
        var danhSach = dsSoTienDaThanhToan.ToList();
        return (danhSach.Count, danhSach.Sum());
    }
}
