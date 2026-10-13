namespace WinForm05Logic.Tests;

public class Bai1UocSoTests
{
    [Theory]
    [InlineData("20", true, 20)]
    [InlineData("0", false, 0)]
    [InlineData("-5", false, -5)]
    [InlineData("abc", false, 0)]
    public void LaSoHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = Bai1UocSoLogic.LaSoHopLe(text, out int giaTri);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, giaTri);
    }

    [Fact]
    public void DanhSachUocSo_MauTrongDeBai_20_TraVeDungSauUocSo()
    {
        // Dung mau trong de bai: uoc so cua 20 bat dau 1, 2, 4, 5, 10 (va 20)
        var uocSo = Bai1UocSoLogic.DanhSachUocSo(20);

        Assert.Equal(new[] { 1, 2, 4, 5, 10, 20 }, uocSo);
    }

    [Fact]
    public void DanhSachUocSo_SoNguyenTo_ChiCo1VaChinhNo()
    {
        Assert.Equal(new[] { 1, 7 }, Bai1UocSoLogic.DanhSachUocSo(7));
    }

    [Fact]
    public void DanhSachUocSo_SoKhongDuong_NemArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Bai1UocSoLogic.DanhSachUocSo(0));
    }

    [Fact]
    public void TongUocSo_UocSoCua20_TraVe42()
    {
        var uocSo = Bai1UocSoLogic.DanhSachUocSo(20);

        Assert.Equal(42, Bai1UocSoLogic.TongUocSo(uocSo));
    }

    [Fact]
    public void SoLuongUocSoChan_UocSoCua20_TraVe4()
    {
        // Uoc so chan cua 20: 2, 4, 10, 20
        var uocSo = Bai1UocSoLogic.DanhSachUocSo(20);

        Assert.Equal(4, Bai1UocSoLogic.SoLuongUocSoChan(uocSo));
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(20, false)]
    public void LaSoNguyenTo_CacGiaTri_TraVeDungSai(int n, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1UocSoLogic.LaSoNguyenTo(n));
    }

    [Fact]
    public void SoLuongUocSoNguyenTo_UocSoCua20_TraVe2()
    {
        // Trong {1,2,4,5,10,20} chi co 2 va 5 la so nguyen to
        var uocSo = Bai1UocSoLogic.DanhSachUocSo(20);

        Assert.Equal(2, Bai1UocSoLogic.SoLuongUocSoNguyenTo(uocSo));
    }
}
