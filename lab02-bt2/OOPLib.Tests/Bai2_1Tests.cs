using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_1Tests
{
    [Fact]
    public void Add_VaIndexer_TruyCapDungPhanTu()
    {
        var arr = new ArrayPoint();
        arr.Add(new Point(1, 1));
        arr.Add(new Point(2, 2));

        Assert.Equal(2, arr.SoLuong);
        Assert.Equal(1, arr[0].X);
        Assert.Equal(2, arr[1].X);
    }

    [Fact]
    public void Indexer_GanGiaTriMoi_CapNhatDungPhanTu()
    {
        var arr = new ArrayPoint();
        arr.Add(new Point(1, 1));

        arr[0] = new Point(9, 9);

        Assert.Equal(9, arr[0].X);
        Assert.Equal(9, arr[0].Y);
    }
}
