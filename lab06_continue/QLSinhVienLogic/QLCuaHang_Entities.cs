namespace QLSinhVienLogic;

// Bai 1 (BT ve nha): co so du lieu QLCuaHang - SanPham(MaSP, TenSP), TonKho(MaSP,
// NgayTon, SLDau, SLNhap, SLBan), HoaDon(MaHD, NgayTao, TinhTrangThanhToan),
// ChiTietHoaDon(MaHD, MaSP, SoLuong). MaSP va MaHD la truong tu dong tang.
public class SanPham
{
    public int MaSP { get; set; }
    public required string TenSP { get; set; }
}

public class TonKho
{
    public required int MaSP { get; set; }
    public DateTime NgayTon { get; set; }
    public int SLDau { get; set; }
    public int SLNhap { get; set; }
    public int SLBan { get; set; }
}

public class HoaDon
{
    public int MaHD { get; set; }
    public DateTime NgayTao { get; set; }

    // 0 = chua thanh toan, 1 = da thanh toan.
    public int TinhTrangThanhToan { get; set; }
}

public class ChiTietHoaDon
{
    public required int MaHD { get; set; }
    public required int MaSP { get; set; }
    public int SoLuong { get; set; }
}
