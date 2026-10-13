namespace QLSinhVienLogic;

public interface ISanPhamRepository
{
    IReadOnlyList<SanPham> LayTatCa();
    bool TonTai(int maSP);
    SanPham Them(string tenSP);
}

public interface ITonKhoRepository
{
    IReadOnlyList<TonKho> LayTatCa();
    TonKho? LayTheoSanPhamVaNgay(int maSP, DateTime ngay);
    void Them(TonKho tonKho);

    // Cong them so luong ban vao dong ton kho cua dung ngay (dung khi thanh toan hoa don).
    void CongSoLuongBan(int maSP, DateTime ngay, int soLuongBanThem);
}

public interface IHoaDonRepository
{
    IReadOnlyList<HoaDon> LayTatCa();
    HoaDon TaoHoaDonMoi(DateTime ngayTao);
    void DanhDauDaThanhToan(int maHD);
}

public interface IChiTietHoaDonRepository
{
    IReadOnlyList<ChiTietHoaDon> LayTatCa();
    bool TonTai(int maHD, int maSP);
    void Them(ChiTietHoaDon chiTiet);
}
