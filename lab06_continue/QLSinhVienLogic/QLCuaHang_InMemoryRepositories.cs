namespace QLSinhVienLogic;

// Danh sach dung chung (List<T>) cho ca Form va Unit Test, khong can SQL Server thuc.
public class InMemorySanPhamRepository : ISanPhamRepository
{
    private readonly List<SanPham> _danhSach;
    private int _maTiepTheo;

    public InMemorySanPhamRepository(IEnumerable<SanPham>? duLieuMau = null)
    {
        _danhSach = duLieuMau?.ToList() ?? [];
        _maTiepTheo = (_danhSach.Count == 0 ? 0 : _danhSach.Max(sp => sp.MaSP)) + 1;
    }

    public IReadOnlyList<SanPham> LayTatCa() => _danhSach.AsReadOnly();

    public bool TonTai(int maSP) => _danhSach.Any(sp => sp.MaSP == maSP);

    // MaSP tu dong tang (mo phong IDENTITY cua SQL Server).
    public SanPham Them(string tenSP)
    {
        var sanPhamMoi = new SanPham { MaSP = _maTiepTheo++, TenSP = tenSP };
        _danhSach.Add(sanPhamMoi);
        return sanPhamMoi;
    }
}

public class InMemoryTonKhoRepository : ITonKhoRepository
{
    private readonly List<TonKho> _danhSach;

    public InMemoryTonKhoRepository(IEnumerable<TonKho>? duLieuMau = null)
    {
        _danhSach = duLieuMau?.ToList() ?? [];
    }

    public IReadOnlyList<TonKho> LayTatCa() => _danhSach.AsReadOnly();

    public TonKho? LayTheoSanPhamVaNgay(int maSP, DateTime ngay) =>
        _danhSach.FirstOrDefault(t => t.MaSP == maSP && t.NgayTon.Date == ngay.Date);

    public void Them(TonKho tonKho)
    {
        if (LayTheoSanPhamVaNgay(tonKho.MaSP, tonKho.NgayTon) is not null)
            throw new InvalidOperationException($"Da ton tai dong ton kho cho San pham {tonKho.MaSP} ngay {tonKho.NgayTon:dd/MM/yyyy}.");

        _danhSach.Add(tonKho);
    }

    public void CongSoLuongBan(int maSP, DateTime ngay, int soLuongBanThem)
    {
        var dong = LayTheoSanPhamVaNgay(maSP, ngay)
            ?? throw new InvalidOperationException($"Khong tim thay dong ton kho cho San pham {maSP} ngay {ngay:dd/MM/yyyy}.");

        dong.SLBan += soLuongBanThem;
    }
}

public class InMemoryHoaDonRepository : IHoaDonRepository
{
    private readonly List<HoaDon> _danhSach;
    private int _maTiepTheo;

    public InMemoryHoaDonRepository(IEnumerable<HoaDon>? duLieuMau = null)
    {
        _danhSach = duLieuMau?.ToList() ?? [];
        _maTiepTheo = (_danhSach.Count == 0 ? 0 : _danhSach.Max(hd => hd.MaHD)) + 1;
    }

    public IReadOnlyList<HoaDon> LayTatCa() => _danhSach.AsReadOnly();

    // MaHD tu dong tang; hoa don moi tao luon o trang thai chua thanh toan.
    public HoaDon TaoHoaDonMoi(DateTime ngayTao)
    {
        var hoaDonMoi = new HoaDon { MaHD = _maTiepTheo++, NgayTao = ngayTao, TinhTrangThanhToan = 0 };
        _danhSach.Add(hoaDonMoi);
        return hoaDonMoi;
    }

    public void DanhDauDaThanhToan(int maHD)
    {
        var hoaDon = _danhSach.FirstOrDefault(hd => hd.MaHD == maHD)
            ?? throw new InvalidOperationException($"Khong tim thay Hoa don {maHD}.");

        hoaDon.TinhTrangThanhToan = 1;
    }
}

public class InMemoryChiTietHoaDonRepository : IChiTietHoaDonRepository
{
    private readonly List<ChiTietHoaDon> _danhSach;

    public InMemoryChiTietHoaDonRepository(IEnumerable<ChiTietHoaDon>? duLieuMau = null)
    {
        _danhSach = duLieuMau?.ToList() ?? [];
    }

    public IReadOnlyList<ChiTietHoaDon> LayTatCa() => _danhSach.AsReadOnly();

    public bool TonTai(int maHD, int maSP) => _danhSach.Any(ct => ct.MaHD == maHD && ct.MaSP == maSP);

    public void Them(ChiTietHoaDon chiTiet)
    {
        if (TonTai(chiTiet.MaHD, chiTiet.MaSP))
            throw new InvalidOperationException($"San pham {chiTiet.MaSP} da co trong Hoa don {chiTiet.MaHD}.");

        _danhSach.Add(chiTiet);
    }
}
