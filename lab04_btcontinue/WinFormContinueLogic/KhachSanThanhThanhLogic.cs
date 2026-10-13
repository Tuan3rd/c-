namespace WinFormContinueLogic;

public enum LoaiPhong
{
    PhongDon,
    PhongDoi,
    PhongBa
}

// Bai 1 (BT ve nha): tinh tien tra phong cho khach san Thanh Thanh.
// Luu y gia: Loai phong va An sang tinh theo SO NGAY O (nhan voi so ngay), con
// Tien nghi va Karaoke la phi co dinh mot lan (khong nhan theo so ngay) - dung
// theo cach de bai ghi "/1 ngay" chi o Loai phong va An sang, con Tien nghi/
// Karaoke chi ghi gia tri co dinh.
public static class KhachSanThanhThanhLogic
{
    private static readonly Dictionary<LoaiPhong, int> GiaPhongMoiNgay = new()
    {
        [LoaiPhong.PhongDon] = 300_000,
        [LoaiPhong.PhongDoi] = 350_000,
        [LoaiPhong.PhongBa] = 400_000
    };

    private const int GiaMoiTienNghi = 10_000;
    private const int GiaKaraoke = 50_000;
    private const int GiaAnSangMoiNgay = 15_000;

    public static int GiaPhongTheoLoai(LoaiPhong loai) => GiaPhongMoiNgay[loai];

    public static bool TenKhachHopLe(string? ten) => !string.IsNullOrWhiteSpace(ten);

    public static bool DiaChiHopLe(string? diaChi) => !string.IsNullOrWhiteSpace(diaChi);

    public static bool SoNgayOHopLe(string? text, out int soNgay) =>
        int.TryParse(text, out soNgay) && soNgay > 0;

    public static int TinhThanhTien(LoaiPhong loaiPhong, int soNgayO, int soLuongTienNghi, bool coKaraoke, bool coAnSang)
    {
        if (soNgayO <= 0)
            throw new ArgumentOutOfRangeException(nameof(soNgayO), "Số ngày ở phải lớn hơn 0");

        if (soLuongTienNghi < 0)
            throw new ArgumentOutOfRangeException(nameof(soLuongTienNghi), "Số lượng tiện nghi không thể âm");

        int thanhTien = GiaPhongTheoLoai(loaiPhong) * soNgayO;
        thanhTien += soLuongTienNghi * GiaMoiTienNghi;

        if (coKaraoke)
            thanhTien += GiaKaraoke;

        if (coAnSang)
            thanhTien += GiaAnSangMoiNgay * soNgayO;

        return thanhTien;
    }

    public static (int TongLuotKhach, int TongTien) TongKet(IEnumerable<int> dsThanhTienTungLuot)
    {
        var danhSach = dsThanhTienTungLuot.ToList();
        return (danhSach.Count, danhSach.Sum());
    }
}
