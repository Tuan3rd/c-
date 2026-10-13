namespace QLSinhVienLogic;

// Du lieu mau khop voi bang vi du trong de bai (San pham: Tra xanh, Muc dau, Cafe;
// Ton kho ngay 29/10/2016, SLDau = 50, SLNhap = SLBan = 0 cho ca 3 san pham).
public static class QLCuaHangDuLieuMau
{
    public static readonly DateTime NgayMauBanDau = new(2016, 10, 29);

    public static List<SanPham> SanPhamMau() =>
    [
        new SanPham { MaSP = 1, TenSP = "Tra xanh" },
        new SanPham { MaSP = 2, TenSP = "Muc dau" },
        new SanPham { MaSP = 3, TenSP = "Cafe" },
        new SanPham { MaSP = 4, TenSP = "Snack khoai tay" },
        new SanPham { MaSP = 5, TenSP = "Nuoc suoi" },
    ];

    public static List<TonKho> TonKhoMau() =>
    [
        new TonKho { MaSP = 1, NgayTon = NgayMauBanDau, SLDau = 50, SLNhap = 0, SLBan = 0 },
        new TonKho { MaSP = 2, NgayTon = NgayMauBanDau, SLDau = 50, SLNhap = 0, SLBan = 0 },
        new TonKho { MaSP = 3, NgayTon = NgayMauBanDau, SLDau = 50, SLNhap = 0, SLBan = 0 },
        new TonKho { MaSP = 4, NgayTon = NgayMauBanDau, SLDau = 30, SLNhap = 0, SLBan = 0 },
        new TonKho { MaSP = 5, NgayTon = NgayMauBanDau, SLDau = 40, SLNhap = 0, SLBan = 0 },
    ];

    public static List<HoaDon> HoaDonMau() =>
    [
        new HoaDon { MaHD = 1, NgayTao = NgayMauBanDau, TinhTrangThanhToan = 1 },
    ];

    public static List<ChiTietHoaDon> ChiTietHoaDonMau() =>
    [
        new ChiTietHoaDon { MaHD = 1, MaSP = 1, SoLuong = 5 },
        new ChiTietHoaDon { MaHD = 1, MaSP = 3, SoLuong = 2 },
    ];
}
