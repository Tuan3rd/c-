namespace WinForm05ContinueLogic.Tests;

public class QL_KhoaValidationTests
{
    [Theory]
    [InlineData("CNTT", "Công Nghệ Thông Tin", true)]
    [InlineData("", "Công Nghệ Thông Tin", false)]
    [InlineData("CNTT", "", false)]
    public void ThemHopLe_CacTruongHop_TraVeDungSai(string maKhoa, string tenKhoa, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, KhoaValidation.ThemHopLe(maKhoa, tenKhoa));
    }

    [Fact]
    public void XoaHopLe_MaKhoaCoDuLieu_TraVeTrue()
    {
        Assert.True(KhoaValidation.XoaHopLe("CNTT"));
    }

    [Fact]
    public void SuaHopLe_CaHaiTruongDayDu_TraVeTrue()
    {
        Assert.True(KhoaValidation.SuaHopLe("CNTT", "Công Nghệ Thông Tin (đổi tên)"));
    }
}
