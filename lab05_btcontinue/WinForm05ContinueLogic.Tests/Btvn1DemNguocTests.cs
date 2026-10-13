namespace WinForm05ContinueLogic.Tests;

public class Btvn1DemNguocTests
{
    [Fact]
    public void ThoiGianBanDau_MauTrongDeBai_Bang30Phut()
    {
        Assert.Equal(TimeSpan.FromMinutes(30), Btvn1DemNguocLogic.ThoiGianBanDau);
        Assert.Equal("30:00", Btvn1DemNguocLogic.DinhDang(Btvn1DemNguocLogic.ThoiGianBanDau));
    }

    [Fact]
    public void GiamMotGiay_TuMotPhut_TraVe59Giay()
    {
        var ketQua = Btvn1DemNguocLogic.GiamMotGiay(TimeSpan.FromMinutes(1));

        Assert.Equal("00:59", Btvn1DemNguocLogic.DinhDang(ketQua));
    }

    [Fact]
    public void GiamMotGiay_DaBang0_KhongBiAmThem()
    {
        var ketQua = Btvn1DemNguocLogic.GiamMotGiay(TimeSpan.Zero);

        Assert.Equal(TimeSpan.Zero, ketQua);
    }

    [Theory]
    [InlineData(0, true)]
    [InlineData(1, false)]
    public void DaKetThuc_CacTruongHop_TraVeDungSai(int giay, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Btvn1DemNguocLogic.DaKetThuc(TimeSpan.FromSeconds(giay)));
    }
}
