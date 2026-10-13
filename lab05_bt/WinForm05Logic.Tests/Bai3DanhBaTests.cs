namespace WinForm05Logic.Tests;

public class Bai3DanhBaTests
{
    [Fact]
    public void DanhSachChuCaiAZ_TraVeDung26ChuCai_BatDauTuAKetThucO_Z()
    {
        var ds = Bai3DanhBaLogic.DanhSachChuCaiAZ().ToList();

        Assert.Equal(26, ds.Count);
        Assert.Equal('A', ds[0]);
        Assert.Equal('Z', ds[^1]);
    }

    [Theory]
    [InlineData("Bình", "Ngô Thanh", true)]
    [InlineData("", "Ngô Thanh", false)]
    [InlineData("Bình", "", false)]
    [InlineData(null, "Ngô Thanh", false)]
    public void ThongTinHopLe_CacTruongHop_TraVeDungSai(string? firstName, string lastName, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai3DanhBaLogic.ThongTinHopLe(firstName, lastName));
    }

    [Fact]
    public void XacDinhChuCaiDau_MauTrongDeBai_Binh_TraVeChuB()
    {
        Assert.Equal('B', Bai3DanhBaLogic.XacDinhChuCaiDau("Bình"));
    }

    [Fact]
    public void XacDinhChuCaiDau_TenChuThuong_VanTraVeChuHoa()
    {
        Assert.Equal('A', Bai3DanhBaLogic.XacDinhChuCaiDau("anh"));
    }

    [Fact]
    public void TaoNoiDungNode_MauTrongDeBai_TraVeDungDinhDang()
    {
        Assert.Equal("Bình, Ngô Thanh", Bai3DanhBaLogic.TaoNoiDungNode("Bình", "Ngô Thanh"));
    }
}
