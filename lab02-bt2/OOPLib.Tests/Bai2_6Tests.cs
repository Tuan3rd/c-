using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_6Tests
{
    [Fact]
    public void TinhTong_BaPhanSo_TraVeDungKetQua()
    {
        var day = new DayPhanSo(3);
        day[0] = new PhanSo(1, 2);
        day[1] = new PhanSo(1, 3);
        day[2] = new PhanSo(1, 6);

        // 1/2 + 1/3 + 1/6 = 1
        PhanSo tong = day.TinhTong();

        Assert.Equal(1, tong.TuSo);
        Assert.Equal(1, tong.MauSo);
    }

    [Fact]
    public void TinhTong_DayRong_TraVeKhong()
    {
        var day = new DayPhanSo(0);

        PhanSo tong = day.TinhTong();

        Assert.Equal(0, tong.TuSo);
    }

    [Fact]
    public void Indexer_MacDinhLaKhongPhanNhat()
    {
        var day = new DayPhanSo(2);

        Assert.Equal("0/1", day[0].ToString());
    }
}
