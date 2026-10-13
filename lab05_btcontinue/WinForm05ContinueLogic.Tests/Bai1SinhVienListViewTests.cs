namespace WinForm05ContinueLogic.Tests;

public class Bai1SinhVienListViewTests
{
    [Fact]
    public void DanToc_CoDungNamGiaTri()
    {
        Assert.Equal(new[] { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" }, Bai1SinhVienListViewLogic.DanToc);
    }

    [Theory]
    [InlineData("Nguyễn Văn A", "SV001", true)]
    [InlineData("", "SV001", false)]
    [InlineData("Nguyễn Văn A", "", false)]
    public void ThongTinHopLe_CacTruongHop_TraVeDungSai(string hoTen, string maSV, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1SinhVienListViewLogic.ThongTinHopLe(hoTen, maSV));
    }

    [Fact]
    public void TrungMaSinhVien_KhongPhanBietHoaThuong_TraVeTrue()
    {
        Assert.True(Bai1SinhVienListViewLogic.TrungMaSinhVien(new[] { "SV001" }, "sv001"));
    }

    [Theory]
    [InlineData(true, "Nam")]
    [InlineData(false, "Nữ")]
    public void MoTaGioiTinh_CacTruongHop_TraVeDungChuoi(bool laNam, string ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1SinhVienListViewLogic.MoTaGioiTinh(laNam));
    }

    [Fact]
    public void MoTaNgoaiNgu_ChonAnhVaPhap_TraVeDungDanhSach()
    {
        Assert.Equal("Anh, Pháp", Bai1SinhVienListViewLogic.MoTaNgoaiNgu(true, true, false));
    }

    [Fact]
    public void MoTaNgoaiNgu_KhongChonGi_TraVeKhong()
    {
        Assert.Equal("Không", Bai1SinhVienListViewLogic.MoTaNgoaiNgu(false, false, false));
    }

    [Fact]
    public void MoTaNgoaiNgu_ChonCaBa_TraVeDungThuTu()
    {
        Assert.Equal("Anh, Pháp, Hoa", Bai1SinhVienListViewLogic.MoTaNgoaiNgu(true, true, true));
    }
}
