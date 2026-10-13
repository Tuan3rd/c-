namespace WinFormContinueLogic.Tests;

public class KhachSanThanhThanhTests
{
    [Theory]
    [InlineData(LoaiPhong.PhongDon, 300_000)]
    [InlineData(LoaiPhong.PhongDoi, 350_000)]
    [InlineData(LoaiPhong.PhongBa, 400_000)]
    public void GiaPhongTheoLoai_CacLoaiPhong_TraVeDungBangGia(LoaiPhong loai, int giaMongDoi)
    {
        Assert.Equal(giaMongDoi, KhachSanThanhThanhLogic.GiaPhongTheoLoai(loai));
    }

    [Theory]
    [InlineData("Lê Quang Anh", true)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TenKhachHopLe_CacChuoiNhap_TraVeDungSai(string? ten, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, KhachSanThanhThanhLogic.TenKhachHopLe(ten));
    }

    [Theory]
    [InlineData("3", true, 3)]
    [InlineData("0", false, 0)]
    [InlineData("-1", false, -1)]
    [InlineData("abc", false, 0)]
    public void SoNgayOHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = KhachSanThanhThanhLogic.SoNgayOHopLe(text, out int soNgay);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, soNgay);
    }

    [Fact]
    public void TinhThanhTien_MauTrongDeBai_PhongDon3NgayDu3TienNghiVaAnSang_TraVe975000()
    {
        // Dung mau trong de bai: Le Quang Anh, Phong don, 3 ngay, 3 tien nghi (Tivi+Internet+May
        // nuoc nong), An sang (co), Karaoke (khong) -> Thanh tien = 975.000 VND
        int thanhTien = KhachSanThanhThanhLogic.TinhThanhTien(
            LoaiPhong.PhongDon, soNgayO: 3, soLuongTienNghi: 3, coKaraoke: false, coAnSang: true);

        Assert.Equal(975_000, thanhTien);
    }

    [Fact]
    public void TinhThanhTien_PhongDoiKhongTienNghiKhongDichVu_ChiTinhTienPhong()
    {
        int thanhTien = KhachSanThanhThanhLogic.TinhThanhTien(
            LoaiPhong.PhongDoi, soNgayO: 2, soLuongTienNghi: 0, coKaraoke: false, coAnSang: false);

        Assert.Equal(350_000 * 2, thanhTien);
    }

    [Fact]
    public void TinhThanhTien_CoKaraoke_KaraokeTinhMotLanKhongNhanTheoSoNgay()
    {
        int thanhTien = KhachSanThanhThanhLogic.TinhThanhTien(
            LoaiPhong.PhongBa, soNgayO: 5, soLuongTienNghi: 0, coKaraoke: true, coAnSang: false);

        Assert.Equal(400_000 * 5 + 50_000, thanhTien);
    }

    [Fact]
    public void TinhThanhTien_TienNghiTinhMotLanKhongNhanTheoSoNgay()
    {
        int thanhTien = KhachSanThanhThanhLogic.TinhThanhTien(
            LoaiPhong.PhongDon, soNgayO: 4, soLuongTienNghi: 2, coKaraoke: false, coAnSang: false);

        Assert.Equal(300_000 * 4 + 2 * 10_000, thanhTien);
    }

    [Fact]
    public void TinhThanhTien_SoNgayKhongDuong_NemArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            KhachSanThanhThanhLogic.TinhThanhTien(LoaiPhong.PhongDon, 0, 0, false, false));
    }

    [Fact]
    public void TongKet_BaLuotKhach_CongDungTongLuotVaTongTien()
    {
        var (tongLuot, tongTien) = KhachSanThanhThanhLogic.TongKet(new[] { 975_000, 700_000, 400_000 });

        Assert.Equal(3, tongLuot);
        Assert.Equal(2_075_000, tongTien);
    }
}
