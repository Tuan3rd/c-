namespace WinForm05Logic.Tests;

public class Bai2DanTocTests
{
    [Fact]
    public void DanhSachDanToc_CoDungNamDanToc()
    {
        Assert.Equal(new[] { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" }, Bai2DanTocLogic.DanhSachDanToc);
    }

    [Fact]
    public void TaoThongBaoHienThi_DaChonKMe_TraVeDungChuoiMauTrongDeBai()
    {
        Assert.Equal("Dân tộc được chọn: K’Me", Bai2DanTocLogic.TaoThongBaoHienThi("K’Me"));
    }

    [Fact]
    public void TaoThongBaoHienThi_ChuaChon_TraVeThongBaoNhacNho()
    {
        Assert.Equal("Bạn chưa chọn dân tộc", Bai2DanTocLogic.TaoThongBaoHienThi(null));
    }

    [Fact]
    public void TaoThongBaoHienThi_ChuoiRong_TraVeThongBaoNhacNho()
    {
        Assert.Equal("Bạn chưa chọn dân tộc", Bai2DanTocLogic.TaoThongBaoHienThi(""));
    }
}
