using Xunit;

namespace LinqLogic.Tests;

public class DuLieuTests
{
    [Fact]
    public void DS_Mon_Co18MonKeCaXYZHeRong()
    {
        var ds = DuLieu.DS_Mon();

        Assert.Equal(18, ds.Count);
        var xyz = ds.Single(m => m.MaMon == "XYZ");
        Assert.Equal("", xyz.He);
        Assert.Equal(0, xyz.SoTiet);
    }

    [Fact]
    public void DS_He_Co3HeKeCaQTKhongMonNaoThamChieu()
    {
        var dsHe = DuLieu.DS_He();
        var dsMon = DuLieu.DS_Mon();

        Assert.Equal(3, dsHe.Count);
        Assert.Equal(new[] { "KTV", "CD", "QT" }, dsHe.Select(h => h.MaHe));
        Assert.DoesNotContain(dsMon, m => m.He == "QT");
    }
}
