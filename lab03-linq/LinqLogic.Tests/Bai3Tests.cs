using Xunit;

namespace LinqLogic.Tests;

public class Bai3Tests
{
    private static readonly int[] MangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
    private static readonly string[] MonAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì", "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

    [Fact]
    public void ThongKeSoLuong_MangSoMau_TongChanLeDung()
    {
        Assert.Equal(11, Bai3Logic.TongSoPhanTu(MangSo));
        Assert.Equal(6, Bai3Logic.SoPhanTuChan(MangSo));
        Assert.Equal(5, Bai3Logic.SoPhanTuLe(MangSo));
    }

    [Fact]
    public void TongMaxMin_MangSoMau_DungGiaTri()
    {
        Assert.Equal(305, Bai3Logic.Tong(MangSo));
        Assert.Equal(85, Bai3Logic.GiaTriLonNhat(MangSo));
        Assert.Equal(1, Bai3Logic.GiaTriNhoNhat(MangSo));
    }

    [Fact]
    public void SoGiaTriKhacNhau_MangSoMau_Tra8()
    {
        Assert.Equal(8, Bai3Logic.SoGiaTriKhacNhau(MangSo));
    }

    [Fact]
    public void PhanNhomModulo5_MangSoMau_DungTungNhom()
    {
        var nhom = Bai3Logic.PhanNhomModulo5(MangSo).ToDictionary(g => g.Key, g => g.ToArray());

        Assert.Equal(new[] { 50, 50, 85 }, nhom[0]);
        Assert.Equal(new[] { 1 }, nhom[1]);
        Assert.Equal(new[] { 42, 12, 42 }, nhom[2]);
        Assert.Equal(new[] { 3, 8, 3 }, nhom[3]);
        Assert.Equal(new[] { 9 }, nhom[4]);
    }

    [Fact]
    public void DoDaiNganNhatDaiNhat_MonAnMau_Dung6Va16KyTu()
    {
        Assert.Equal(6, Bai3Logic.DoDaiNganNhat(MonAn));
        Assert.Equal(16, Bai3Logic.DoDaiDaiNhat(MonAn));
        Assert.Equal(new[] { "Mì xào", "Mì gói" }, Bai3Logic.MonTenNganNhat(MonAn));
        Assert.Equal(new[] { "Hủ tiếu Nam vang" }, Bai3Logic.MonTenDaiNhat(MonAn));
    }

    [Fact]
    public void NhomTheoTuDau_MonAnMau_Ra6NhomDungSoLuong()
    {
        var nhom = Bai3Logic.NhomTheoTuDau(MonAn).ToDictionary(g => g.Key, g => g.Count());

        Assert.Equal(6, nhom.Count);
        Assert.Equal(3, nhom["Bún"]);
        Assert.Equal(2, nhom["Hủ"]);
        Assert.Equal(3, nhom["Bánh"]);
        Assert.Equal(2, nhom["Nước"]);
        Assert.Equal(3, nhom["Mì"]);
        Assert.Equal(1, nhom["Cơm"]);
    }

    [Fact]
    public void DemMonCoTuDau_TuBanh_Tra3()
    {
        Assert.Equal(3, Bai3Logic.DemMonCoTuDau(MonAn, "Bánh"));
    }
}
