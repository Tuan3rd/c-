using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_3Tests
{
    [Fact]
    public void Indexer_GanVaDoc_HoatDongDung()
    {
        var day = new DaySo(3);
        day[0] = 10;
        day[1] = 20;
        day[2] = 30;

        Assert.Equal(10, day[0]);
        Assert.Equal(30, day[2]);
    }

    [Fact]
    public void Constructor_TuMangCoSan_SaoChepDungGiaTri()
    {
        var day = new DaySo(new[] { 1, 2, 3 });

        Assert.Equal(3, day.SoLuong);
        Assert.Equal(2, day[1]);
    }

    [Fact]
    public void TimSoChan_MangHonHop_LocDungSoChan()
    {
        var day = new DaySo(new[] { 1, 2, 3, 4, 5, 6 });

        int[] ketQua = day.TimSoChan();

        Assert.Equal(new[] { 2, 4, 6 }, ketQua);
    }

    [Fact]
    public void TimSoChan_KhongCoSoChan_TraVeMangRong()
    {
        var day = new DaySo(new[] { 1, 3, 5 });

        Assert.Empty(day.TimSoChan());
    }
}
