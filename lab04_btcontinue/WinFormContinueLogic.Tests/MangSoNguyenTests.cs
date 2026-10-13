namespace WinFormContinueLogic.Tests;

public class MangSoNguyenTests
{
    // Mang mau dung trong hinh minh hoa cua de bai.
    private static readonly int[] MangMau = { 5, 6, 4, 7, 8, 9, 10, 5, 6, 3, 2, 1 };

    private static MangSoNguyen TaoMangMauDaSapXepTang()
    {
        var m = new MangSoNguyen();
        m.Nhap(MangMau);
        m.SapXepTang();
        return m;
    }

    [Fact]
    public void Nhap_MangMau_SoPhanTuBang12()
    {
        var m = new MangSoNguyen();
        m.Nhap(MangMau);

        Assert.Equal(12, m.SoPhanTu);
    }

    [Fact]
    public void SapXepTang_MangMau_KhopDungVoiHinhMinhHoa()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(new[] { 1, 2, 3, 4, 5, 5, 6, 6, 7, 8, 9, 10 }, m.DanhSach);
    }

    [Fact]
    public void SapXepGiam_MangMau_ThuTuGiamDan()
    {
        var m = new MangSoNguyen();
        m.Nhap(MangMau);
        m.SapXepGiam();

        Assert.Equal(new[] { 10, 9, 8, 7, 6, 6, 5, 5, 4, 3, 2, 1 }, m.DanhSach);
    }

    [Fact]
    public void TimGiaTriTheoViTri_ViTri4SauKhiSapXepTang_TraVe5()
    {
        // Dung mau trong de bai: tim vi tri = 4 -> so tim duoc la 5
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(5, m.TimGiaTriTheoViTri(4));
    }

    [Fact]
    public void TimViTriTheoGiaTri_GiaTriCoTonTai_TraVeViTriDauTien()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(4, m.TimViTriTheoGiaTri(5));
    }

    [Fact]
    public void TimViTriTheoGiaTri_GiaTriKhongTonTai_TraVeAm1()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(-1, m.TimViTriTheoGiaTri(100));
    }

    [Fact]
    public void TimGiaTriTheoViTri_ViTriNgoaiKhoang_NemArgumentOutOfRangeException()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Throws<ArgumentOutOfRangeException>(() => m.TimGiaTriTheoViTri(100));
    }

    [Fact]
    public void ThemTaiViTri_ViTriHopLe_ChenDungViTri()
    {
        var m = TaoMangMauDaSapXepTang();

        m.ThemTaiViTri(99, 0);

        Assert.Equal(99, m.DanhSach[0]);
        Assert.Equal(13, m.SoPhanTu);
    }

    [Fact]
    public void ThemTaiViTri_ViTriBangSoPhanTu_ChenVaoCuoiMang()
    {
        var m = TaoMangMauDaSapXepTang();

        m.ThemTaiViTri(99, m.SoPhanTu);

        Assert.Equal(99, m.DanhSach[^1]);
    }

    [Fact]
    public void ThemTaiViTri_ViTriAm_NemArgumentOutOfRangeException()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Throws<ArgumentOutOfRangeException>(() => m.ThemTaiViTri(99, -1));
    }

    [Fact]
    public void XoaTheoGiaTri_GiaTriTonTai_XoaDungMotPhanTu()
    {
        var m = TaoMangMauDaSapXepTang();

        m.XoaTheoGiaTri(5);

        Assert.Equal(11, m.SoPhanTu);
        Assert.Equal(1, m.DanhSach.Count(x => x == 5));
    }

    [Fact]
    public void XoaTheoGiaTri_GiaTriKhongTonTai_NemArgumentException()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Throws<ArgumentException>(() => m.XoaTheoGiaTri(100));
    }

    [Fact]
    public void XoaTheoViTri_ViTriHopLe_XoaDungPhanTu()
    {
        var m = TaoMangMauDaSapXepTang();

        m.XoaTheoViTri(0);

        Assert.Equal(new[] { 2, 3, 4, 5, 5, 6, 6, 7, 8, 9, 10 }, m.DanhSach);
    }

    [Fact]
    public void TinhTong_MangMauDaSapXep_TraVe66()
    {
        // Dung mau trong de bai: Tong mang = 66
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(66, m.TinhTong());
    }

    [Fact]
    public void TinhTongChan_MangMauDaSapXep_TraVe36()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(36, m.TinhTongChan());
    }

    [Fact]
    public void TinhTongLe_MangMauDaSapXep_TraVe30()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(30, m.TinhTongLe());
    }

    [Fact]
    public void GiaTriLonNhat_MangMau_TraVe10()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(10, m.GiaTriLonNhat());
    }

    [Fact]
    public void GiaTriNhoNhat_MangMau_TraVe1()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Equal(1, m.GiaTriNhoNhat());
    }

    [Fact]
    public void GiaTriLonNhat_MangRong_NemInvalidOperationException()
    {
        var m = new MangSoNguyen();

        Assert.Throws<InvalidOperationException>(() => m.GiaTriLonNhat());
    }

    [Fact]
    public void ThayTheTheoGiaTri_GiaTriXuatHienNhieuLan_ThayHetTatCa()
    {
        var m = TaoMangMauDaSapXepTang();

        int soLanThay = m.ThayTheTheoGiaTri(5, 50);

        Assert.Equal(2, soLanThay);
        Assert.DoesNotContain(5, m.DanhSach);
        Assert.Equal(2, m.DanhSach.Count(x => x == 50));
    }

    [Fact]
    public void ThayTheTheoViTri_ViTriHopLe_ThayDungPhanTu()
    {
        var m = TaoMangMauDaSapXepTang();

        m.ThayTheTheoViTri(0, 99);

        Assert.Equal(99, m.DanhSach[0]);
    }

    [Fact]
    public void ThayTheTheoViTri_ViTriNgoaiKhoang_NemArgumentOutOfRangeException()
    {
        var m = TaoMangMauDaSapXepTang();

        Assert.Throws<ArgumentOutOfRangeException>(() => m.ThayTheTheoViTri(100, 99));
    }

    [Fact]
    public void Xoa_SauKhiNhap_TraVeMangRong()
    {
        var m = TaoMangMauDaSapXepTang();

        m.Xoa();

        Assert.Equal(0, m.SoPhanTu);
    }
}
