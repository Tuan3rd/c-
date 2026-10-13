namespace WinFormLogic.Tests;

public class Bai3Tests
{
    [Theory]
    [InlineData("5", true, 5)]
    [InlineData("0", false, 0)]
    [InlineData("-3", false, -3)]
    [InlineData("abc", false, 0)]
    public void LaSoNguyenDuongHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = Bai3UocBoiLogic.LaSoNguyenDuongHopLe(text, out int giaTri);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, giaTri);
    }

    [Theory]
    [InlineData(5, 3, 1)]
    [InlineData(12, 18, 6)]
    [InlineData(7, 7, 7)]
    [InlineData(1, 9, 1)]
    public void UCLN_CacCapSo_TraVeKetQuaDung(int a, int b, int ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai3UocBoiLogic.UCLN(a, b));
    }

    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(4, 6, 12)]
    [InlineData(7, 7, 7)]
    public void BCNN_CacCapSo_TraVeKetQuaDung(int a, int b, int ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai3UocBoiLogic.BCNN(a, b));
    }

    [Fact]
    public void UCLN_MauTrongDeBai_5Va3_TraVe1()
    {
        // Theo hinh minh hoa trong de bai: a=5, b=3 -> UCLN=1, BCNN=15
        Assert.Equal(1, Bai3UocBoiLogic.UCLN(5, 3));
        Assert.Equal(15, Bai3UocBoiLogic.BCNN(5, 3));
    }

    [Fact]
    public void UCLN_SoKhongDuong_NemArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Bai3UocBoiLogic.UCLN(0, 5));
    }

    [Fact]
    public void BCNN_SoKhongDuong_NemArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Bai3UocBoiLogic.BCNN(-1, 5));
    }
}
