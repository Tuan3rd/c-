using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_5Tests
{
    [Fact]
    public void TinhGiaTri_DaThucBac2_TaiX2_TraVeDungKetQua()
    {
        // P(x) = 1 + 2x + 3x^2, tai x=2: 1 + 4 + 12 = 17
        var p = new DaThuc(new double[] { 1, 2, 3 });

        Assert.Equal(17, p.TinhGiaTri(2));
    }

    [Fact]
    public void Indexer_GanVaDoc_HoatDongDung()
    {
        var p = new DaThuc(2); // bac 2, 3 he so
        p[0] = 5;
        p[1] = 0;
        p[2] = 1;

        Assert.Equal(5, p[0]);
        Assert.Equal(1, p[2]);
    }

    [Fact]
    public void Bac_TraVeDungBacDaThuc()
    {
        var p = new DaThuc(4);

        Assert.Equal(4, p.Bac);
    }

    [Fact]
    public void TinhGiaTri_TaiXBangKhong_TraVeHeSoTuDo()
    {
        var p = new DaThuc(new double[] { 7, 3, 2 });

        Assert.Equal(7, p.TinhGiaTri(0));
    }
}
