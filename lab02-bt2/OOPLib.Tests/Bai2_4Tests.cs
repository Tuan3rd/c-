using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_4Tests
{
    [Fact]
    public void Indexer_GanVaDoc_HoatDongDung()
    {
        var mang = new Mang2Chieu(2, 2);
        mang[0, 0] = 1;
        mang[0, 1] = 2;
        mang[1, 0] = 3;
        mang[1, 1] = 4;

        Assert.Equal(1, mang[0, 0]);
        Assert.Equal(4, mang[1, 1]);
    }

    [Fact]
    public void SoDongSoCot_KhoiTaoDung()
    {
        var mang = new Mang2Chieu(3, 5);

        Assert.Equal(3, mang.SoDong);
        Assert.Equal(5, mang.SoCot);
    }

    [Fact]
    public void TimSoNguyenTo_MangCoLanSoNguyenTo_LocDung()
    {
        var mang = new Mang2Chieu(2, 2);
        mang[0, 0] = 4;
        mang[0, 1] = 7;
        mang[1, 0] = 9;
        mang[1, 1] = 11;

        int[] ketQua = mang.TimSoNguyenTo();

        Assert.Equal(new[] { 7, 11 }, ketQua);
    }
}
