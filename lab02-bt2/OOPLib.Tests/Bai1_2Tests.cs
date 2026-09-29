using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai1_2Tests
{
    [Fact]
    public void DefaultConstructor_KhoiTaoBangKhong()
    {
        var p = new Point();

        Assert.Equal(0, p.X);
        Assert.Equal(0, p.Y);
    }

    [Fact]
    public void ToanTu_Cong_TraVeDungKetQua()
    {
        var a = new Point(1, 2);
        var b = new Point(4, 6);

        var c = a + b;

        Assert.Equal(5, c.X);
        Assert.Equal(8, c.Y);
    }

    [Fact]
    public void ToanTu_Tru_TraVeDungKetQua()
    {
        var a = new Point(1, 2);
        var b = new Point(4, 6);

        var c = a - b;

        Assert.Equal(-3, c.X);
        Assert.Equal(-4, c.Y);
    }

    [Fact]
    public void ToanTu_LayAm_TraVeDungKetQua()
    {
        var a = new Point(1, -2);

        var c = -a;

        Assert.Equal(-1, c.X);
        Assert.Equal(2, c.Y);
    }

    [Fact]
    public void ToString_TraVeDungDinhDang()
    {
        var a = new Point(1.5, -2.5);

        Assert.Equal("(1.5, -2.5)", a.ToString());
    }

    [Fact]
    public void KhoangCach_TamGiac345_TraVeDungKetQua()
    {
        var a = new Point(0, 0);
        var b = new Point(3, 4);

        // Ca 2 cach (thanh vien va tinh) phai cho cung mot ket qua
        Assert.Equal(5, a.KhoangCachDen(b));
        Assert.Equal(5, Point.KhoangCach(a, b));
    }

    [Fact]
    public void TrungDiem_CaHaiCach_ChoCungKetQua()
    {
        var a = new Point(0, 0);
        var b = new Point(4, 8);

        Point m1 = a.TrungDiemVoi(b);
        Point m2 = Point.TrungDiem(a, b);

        Assert.Equal(2, m1.X);
        Assert.Equal(4, m1.Y);
        Assert.Equal(m1.X, m2.X);
        Assert.Equal(m1.Y, m2.Y);
    }
}
