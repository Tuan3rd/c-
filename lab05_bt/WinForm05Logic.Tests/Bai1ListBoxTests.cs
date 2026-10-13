namespace WinForm05Logic.Tests;

public class Bai1ListBoxTests
{
    [Fact]
    public void ChuyenMotPhanTu_PhanTuTonTaiBenTrai_ChuyenDungSangPhai()
    {
        var trai = new List<string> { "Cốc", "Ổi", "Xoài" };
        var phai = new List<string>();

        Bai1ListBoxLogic.ChuyenMotPhanTu(trai, phai, "Ổi");

        Assert.Equal(new[] { "Cốc", "Xoài" }, trai);
        Assert.Equal(new[] { "Ổi" }, phai);
    }

    [Fact]
    public void ChuyenTatCa_CoBaPhanTuBenTrai_ChuyenHetSangPhaiVaTraiRong()
    {
        var trai = new List<string> { "Cốc", "Ổi", "Xoài" };
        var phai = new List<string> { "Mận" };

        Bai1ListBoxLogic.ChuyenTatCa(trai, phai);

        Assert.Empty(trai);
        Assert.Equal(new[] { "Mận", "Cốc", "Ổi", "Xoài" }, phai);
    }

    [Fact]
    public void ChuyenTatCa_TraiRong_PhaiKhongDoi()
    {
        var trai = new List<string>();
        var phai = new List<string> { "Cam" };

        Bai1ListBoxLogic.ChuyenTatCa(trai, phai);

        Assert.Equal(new[] { "Cam" }, phai);
    }

    [Fact]
    public void ChuyenNhieuPhanTu_ChonHaiTrongBaPhanTu_ChiChuyenDungHaiPhanTuDaChon()
    {
        var trai = new List<string> { "Cốc", "Ổi", "Xoài" };
        var phai = new List<string>();

        Bai1ListBoxLogic.ChuyenNhieuPhanTu(trai, phai, new[] { "Cốc", "Xoài" });

        Assert.Equal(new[] { "Ổi" }, trai);
        Assert.Equal(new[] { "Cốc", "Xoài" }, phai);
    }

    [Fact]
    public void ChuyenNhieuPhanTu_KhongChonGi_KhongThayDoiGi()
    {
        var trai = new List<string> { "Cốc", "Ổi" };
        var phai = new List<string>();

        Bai1ListBoxLogic.ChuyenNhieuPhanTu(trai, phai, Array.Empty<string>());

        Assert.Equal(new[] { "Cốc", "Ổi" }, trai);
        Assert.Empty(phai);
    }
}
