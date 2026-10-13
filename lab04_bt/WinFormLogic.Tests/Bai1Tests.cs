namespace WinFormLogic.Tests;

public class Bai1Tests
{
    [Theory]
    [InlineData("10", true)]
    [InlineData("-3.5", true)]
    [InlineData("0", true)]
    [InlineData("", false)]
    [InlineData("abc", false)]
    [InlineData("1a2", false)]
    public void LaSoHopLe_CacChuoiNhap_TraVeDungSai(string text, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1TinhToanLogic.LaSoHopLe(text));
    }

    [Theory]
    [InlineData('5', "12", 2, true)]
    [InlineData('a', "12", 2, false)]
    [InlineData('-', "", 0, true)]
    [InlineData('-', "5", 1, false)]
    [InlineData('.', "12", 2, true)]
    [InlineData('.', "1.2", 3, false)]
    public void LaKyTuNhapSoDuocPhep_CacTruongHop_TraVeDungSai(char kyTu, string textHienTai, int viTri, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1TinhToanLogic.LaKyTuNhapSoDuocPhep(kyTu, textHienTai, viTri));
    }

    [Fact]
    public void Cong_5Va3_TraVe8()
    {
        Assert.Equal(8, Bai1TinhToanLogic.Cong(5, 3));
    }

    [Fact]
    public void Tru_5Va3_TraVe2()
    {
        Assert.Equal(2, Bai1TinhToanLogic.Tru(5, 3));
    }

    [Fact]
    public void Nhan_5Va3_TraVe15()
    {
        Assert.Equal(15, Bai1TinhToanLogic.Nhan(5, 3));
    }

    [Fact]
    public void Chia_10Va4_TraVe2Phay5()
    {
        Assert.Equal(2.5, Bai1TinhToanLogic.Chia(10, 4));
    }

    [Fact]
    public void Chia_ChoKhong_NemDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => Bai1TinhToanLogic.Chia(10, 0));
    }
}
