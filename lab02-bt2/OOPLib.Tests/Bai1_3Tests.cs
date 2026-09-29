using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai1_3Tests
{
    [Fact]
    public void DefaultConstructor_KhoiTaoGiaTriMacDinh()
    {
        var p = new Person();

        Assert.Equal(0, p.Id);
        Assert.Equal(0, p.Yob);
        Assert.Equal(0, p.Yod);
    }

    [Fact]
    public void CopyConstructor_TaoBanSaoDocLap()
    {
        var goc = new Person(1, "Thai Tuan", 2003, 0);
        var sao = new Person(goc);

        sao.Name = "Doi ten";

        // Sua ban sao khong duoc anh huong ban goc
        Assert.Equal("Thai Tuan", goc.Name);
        Assert.Equal("Doi ten", sao.Name);
    }

    [Fact]
    public void IsLiving_YodBangKhong_TraVeTrue()
    {
        var p = new Person(1, "A", 2000, 0);

        Assert.True(p.IsLiving());
    }

    [Fact]
    public void IsLiving_YodKhacKhong_TraVeFalse()
    {
        var p = new Person(1, "A", 1900, 1980);

        Assert.False(p.IsLiving());
    }
}
