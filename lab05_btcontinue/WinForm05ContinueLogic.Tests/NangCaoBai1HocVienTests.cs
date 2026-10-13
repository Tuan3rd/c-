namespace WinForm05ContinueLogic.Tests;

public class NangCaoBai1HocVienTests
{
    [Fact]
    public void ChuyenHocVien_ChonHaiTrongBaHocVien_ChuyenDungHaiHocVien()
    {
        var lopA = new List<string> { "Trần Hùng", "Nguyễn Hưng", "Lâm Tử" };
        var lopB = new List<string>();

        NangCaoBai1HocVienLogic.ChuyenHocVien(lopA, lopB, new[] { "Nguyễn Hưng", "Lâm Tử" });

        Assert.Equal(new[] { "Trần Hùng" }, lopA);
        Assert.Equal(new[] { "Nguyễn Hưng", "Lâm Tử" }, lopB);
    }

    [Fact]
    public void XoaHocVien_ChonMotTrongHaiHocVien_ChiXoaDungMotHocVien()
    {
        var lop = new List<string> { "Tuấn Hưng", "Hồng Ngọc", "Anh Minh" };

        NangCaoBai1HocVienLogic.XoaHocVien(lop, new[] { "Hồng Ngọc", "Anh Minh" });

        Assert.Equal(new[] { "Tuấn Hưng" }, lop);
    }

    [Theory]
    [InlineData("Trần Văn Tình", true)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TenHopLe_CacTruongHop_TraVeDungSai(string? ten, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, NangCaoBai1HocVienLogic.TenHopLe(ten));
    }
}
