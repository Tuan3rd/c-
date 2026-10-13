namespace QLSinhVienLogic;

// Cong thuc chuyen ngay cho Bai 1 (BT ve nha):
// SLDau(ngay moi) = SLDau(ngay truoc) + SLNhap(ngay truoc) - SLBan(ngay truoc)
// SLNhap va SLBan cua ngay moi luon bat dau tu 0.
public static class TonKhoLogic
{
    public static int TonHienTai(TonKho tonKho) => tonKho.SLDau + tonKho.SLNhap - tonKho.SLBan;

    // Tim dong ton kho gan nhat TRUOC ngay can tao moi, dung de lam "ngay truoc" cho
    // cong thuc chuyen so du. Nhan vao danh sach da loc theo dung 1 San pham.
    public static TonKho? DongGanNhatTruocNgay(IEnumerable<TonKho> tonKhoCuaSanPham, DateTime ngay) =>
        tonKhoCuaSanPham
            .Where(t => t.NgayTon.Date < ngay.Date)
            .OrderByDescending(t => t.NgayTon)
            .FirstOrDefault();

    public static TonKho TaoDongNgayMoi(TonKho? tonKhoNgayTruoc, int maSP, DateTime ngayMoi)
    {
        int slDauMoi = tonKhoNgayTruoc is null ? 0 : TonHienTai(tonKhoNgayTruoc);

        return new TonKho
        {
            MaSP = maSP,
            NgayTon = ngayMoi,
            SLDau = slDauMoi,
            SLNhap = 0,
            SLBan = 0,
        };
    }
}

// Bai 2 (BT ve nha): ban hang. De bai goc ghi "Tong SLBan = Tong SLBan - so luong" nhung
// cong thuc do lam ton kho giam dan khi ban them hang, vo ly ve nghiep vu (ban hang phai
// LAM TANG so luong da ban). Em sua lai thanh phep CONG (SLBan += soLuong) va giai thich
// ro trong bao cao - xem muc "Dieu chinh so voi de bai" cua Lab06Continue.
public static class BanHangValidation
{
    // So luong ban phai > 0 va khong vuot qua so luong con ton trong ngay.
    public static bool SoLuongHopLe(string? text, int soLuongTonHienTai, out int soLuong) =>
        int.TryParse(text, out soLuong) && soLuong > 0 && soLuong <= soLuongTonHienTai;
}
