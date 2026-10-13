namespace WinFormLogic.Tests;

public class Bai4Tests
{
    private static readonly int[] DayMau = { 2, 1, 3, 5, 4 };

    [Theory]
    [InlineData("10", true, 10)]
    [InlineData("-5", true, -5)]
    [InlineData("abc", false, 0)]
    public void LaSoNguyenHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = Bai4DaySoLogic.LaSoNguyenHopLe(text, out int giaTri);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, giaTri);
    }

    [Fact]
    public void TongCacPhanTu_DayMauTrongDeBai_TraVe15()
    {
        // Theo hinh minh hoa: day 2 1 3 5 4 -> tong = 15
        Assert.Equal(15, Bai4DaySoLogic.TongCacPhanTu(DayMau));
    }

    [Fact]
    public void TongChan_DayMauTrongDeBai_TraVe6()
    {
        // 2 + 4 = 6
        Assert.Equal(6, Bai4DaySoLogic.TongChan(DayMau));
    }

    [Fact]
    public void TongLe_DayMauTrongDeBai_TraVe9()
    {
        // 1 + 3 + 5 = 9
        Assert.Equal(9, Bai4DaySoLogic.TongLe(DayMau));
    }

    [Fact]
    public void TongCacPhanTu_DayRong_TraVe0()
    {
        Assert.Equal(0, Bai4DaySoLogic.TongCacPhanTu(Array.Empty<int>()));
    }

    [Fact]
    public void TongChan_CoSoAm_TinhDungSoAmChan()
    {
        var day = new[] { -4, -3, 2 };

        Assert.Equal(-2, Bai4DaySoLogic.TongChan(day));
        Assert.Equal(-3, Bai4DaySoLogic.TongLe(day));
    }
}
