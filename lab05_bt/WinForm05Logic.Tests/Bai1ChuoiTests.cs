namespace WinForm05Logic.Tests;

public class Bai1ChuoiTests
{
    [Fact]
    public void TaoTenNgauNhien_KetQuaCoDungBaTu()
    {
        var rnd = new Random(42);

        string ten = Bai1ChuoiLogic.TaoTenNgauNhien(rnd);

        Assert.Equal(3, ten.Split(' ').Length);
    }

    [Fact]
    public void TaoTenNgauNhien_TungTuPhaiNamTrongMangGoc()
    {
        var rnd = new Random(1);

        string ten = Bai1ChuoiLogic.TaoTenNgauNhien(rnd);
        string[] tu = ten.Split(' ');

        Assert.Contains(tu[0], Bai1ChuoiLogic.Ho);
        Assert.Contains(tu[1], Bai1ChuoiLogic.TenLot);
        Assert.Contains(tu[2], Bai1ChuoiLogic.Ten);
    }

    [Fact]
    public void TaoDanhSachTenNgauNhien_50Ten_TraVeDung50PhanTu()
    {
        var rnd = new Random(7);

        var ds = Bai1ChuoiLogic.TaoDanhSachTenNgauNhien(50, rnd);

        Assert.Equal(50, ds.Count);
        Assert.All(ds, ten => Assert.Equal(3, ten.Split(' ').Length));
    }

    [Theory]
    [InlineData("Trần Anh Sơn", "Sơn", true)]
    [InlineData("Lê Quang Hà", "Sơn", false)]
    [InlineData("Lý Ngọc Sơn", "sơn", true)]
    public void CoTen_CacTruongHop_TraVeDungSai(string hoTenDayDu, string ten, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1ChuoiLogic.CoTen(hoTenDayDu, ten));
    }

    [Theory]
    [InlineData("Lê Quang Hà", "Lê", true)]
    [InlineData("Nguyễn Thành Danh", "Lê", false)]
    [InlineData("lê Quang Hà", "Lê", true)]
    public void CoHo_CacTruongHop_TraVeDungSai(string hoTenDayDu, string ho, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1ChuoiLogic.CoHo(hoTenDayDu, ho));
    }

    [Fact]
    public void ChuyenThanhChuHoa_TenCoDau_ChuyenDungTatCaKyTu()
    {
        Assert.Equal("NGUYỄN THÀNH DANH", Bai1ChuoiLogic.ChuyenThanhChuHoa("Nguyễn Thành Danh"));
    }

    [Fact]
    public void ChuyenThanhChuThuong_TenCoDau_ChuyenDungTatCaKyTu()
    {
        Assert.Equal("nguyễn thành danh", Bai1ChuoiLogic.ChuyenThanhChuThuong("Nguyễn Thành Danh"));
    }

    [Fact]
    public void VietHoaDauMoiTu_ChuoiToanThuong_VietHoaDungDauMoiTu()
    {
        Assert.Equal("Nguyễn Thành Danh", Bai1ChuoiLogic.VietHoaDauMoiTu("nguyễn thành danh"));
    }

    [Fact]
    public void VietHoaDauMoiTu_ChuoiToanHoa_VietHoaDungDauMoiTuConLaiThuong()
    {
        Assert.Equal("Nguyễn Thành Danh", Bai1ChuoiLogic.VietHoaDauMoiTu("NGUYỄN THÀNH DANH"));
    }
}
