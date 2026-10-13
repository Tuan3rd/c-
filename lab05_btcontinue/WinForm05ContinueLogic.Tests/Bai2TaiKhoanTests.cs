namespace WinForm05ContinueLogic.Tests;

public class Bai2TaiKhoanTests
{
    [Theory]
    [InlineData("0160901609", "Nguyễn Văn An", "TPHCM", "5200000", true)]
    [InlineData("", "Nguyễn Văn An", "TPHCM", "5200000", false)]
    [InlineData("0160901609", "", "TPHCM", "5200000", false)]
    [InlineData("0160901609", "Nguyễn Văn An", "", "5200000", false)]
    [InlineData("0160901609", "Nguyễn Văn An", "TPHCM", "abc", false)]
    [InlineData("0160901609", "Nguyễn Văn An", "TPHCM", "-100", false)]
    public void ThongTinHopLe_CacTruongHop_TraVeDungSai(
        string soTk, string tenKh, string diaChi, string soTien, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai2TaiKhoanLogic.ThongTinHopLe(soTk, tenKh, diaChi, soTien));
    }

    [Fact]
    public void LaSoTienHopLe_MauTrongDeBai_5200000_TraVeDungGiaTri()
    {
        bool ketQua = Bai2TaiKhoanLogic.LaSoTienHopLe("5200000", out decimal soTien);

        Assert.True(ketQua);
        Assert.Equal(5_200_000m, soTien);
    }

    [Fact]
    public void TrungSoTaiKhoan_SoGiongHet_TraVeTrue()
    {
        Assert.True(Bai2TaiKhoanLogic.TrungSoTaiKhoan(new[] { "0160901609", "0160901610" }, "0160901609"));
    }

    [Fact]
    public void TinhTongTien_MauTrongDeBai_HaiTaiKhoan_TraVe6400000()
    {
        // Dung mau trong de bai: 5.200.000 + 1.200.000 = 6.400.000
        decimal tong = Bai2TaiKhoanLogic.TinhTongTien(new[] { 5_200_000m, 1_200_000m });

        Assert.Equal(6_400_000m, tong);
    }
}
