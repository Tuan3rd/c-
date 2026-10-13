namespace WinForm05Logic.Tests;

public class Bai2ListBoxSoTests
{
    private static readonly int[] DayMau = { 30, 21, 35, 43, 1, 3, 20, 9, 4, 80 };

    [Theory]
    [InlineData("12", true, 12)]
    [InlineData("0", true, 0)]
    [InlineData("-3", false, -3)]
    [InlineData("abc", false, 0)]
    public void LaSoTuNhienHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = Bai2ListBoxSoLogic.LaSoTuNhienHopLe(text, out int giaTri);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, giaTri);
    }

    [Fact]
    public void TinhTong_DayMauTrongDeBai_TraVeDungTong()
    {
        Assert.Equal(246, Bai2ListBoxSoLogic.TinhTong(DayMau));
    }

    [Fact]
    public void TangMoiPhanTu_Tang2_CongDungMoiPhanTu()
    {
        var ketQua = Bai2ListBoxSoLogic.TangMoiPhanTu(new[] { 1, 2, 3 }, 2);

        Assert.Equal(new[] { 3, 4, 5 }, ketQua);
    }

    [Fact]
    public void BinhPhuongMoiPhanTu_DayMau_TraVeDungBinhPhuong()
    {
        var ketQua = Bai2ListBoxSoLogic.BinhPhuongMoiPhanTu(new[] { 1, 3, 4 });

        Assert.Equal(new[] { 1, 9, 16 }, ketQua);
    }

    [Fact]
    public void LocSoChan_DayMauTrongDeBai_TraVeDungCacSoChan()
    {
        Assert.Equal(new[] { 30, 20, 4, 80 }, Bai2ListBoxSoLogic.LocSoChan(DayMau));
    }

    [Fact]
    public void LocSoLe_DayMauTrongDeBai_TraVeDungCacSoLe()
    {
        Assert.Equal(new[] { 21, 35, 43, 1, 3, 9 }, Bai2ListBoxSoLogic.LocSoLe(DayMau));
    }
}
