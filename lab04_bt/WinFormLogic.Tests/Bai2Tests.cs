namespace WinFormLogic.Tests;

public class Bai2Tests
{
    [Theory]
    [InlineData("abc@gmail.com", true)]
    [InlineData("a.b@sv.edu.vn", true)]
    [InlineData("abc", false)]
    [InlineData("abc@", false)]
    [InlineData("@gmail.com", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void LaEmailHopLe_CacChuoiNhap_TraVeDungSai(string? email, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai2DangKyLogic.LaEmailHopLe(email));
    }

    [Fact]
    public void ThieuDuLieuBatBuoc_ThieuTenDangNhap_TraVeTrue()
    {
        Assert.True(Bai2DangKyLogic.ThieuDuLieuBatBuoc("", "a@b.com", "123456"));
    }

    [Fact]
    public void ThieuDuLieuBatBuoc_DuCaBaTruong_TraVeFalse()
    {
        Assert.False(Bai2DangKyLogic.ThieuDuLieuBatBuoc("tuan", "a@b.com", "123456"));
    }

    [Fact]
    public void MatKhauKhopNhau_HaiMatKhauGiongNhau_TraVeTrue()
    {
        Assert.True(Bai2DangKyLogic.MatKhauKhopNhau("abc123", "abc123"));
    }

    [Fact]
    public void MatKhauKhopNhau_HaiMatKhauKhacNhau_TraVeFalse()
    {
        Assert.False(Bai2DangKyLogic.MatKhauKhopNhau("abc123", "abc124"));
    }

    [Fact]
    public void KiemTraDangKy_DuLieuHopLe_KhongCoLoi()
    {
        var loi = Bai2DangKyLogic.KiemTraDangKy("tuan", "tuan@gmail.com", "123456", "123456");

        Assert.Empty(loi);
    }

    [Fact]
    public void KiemTraDangKy_ThieuTenVaEmailSaiDinhDang_TraVeHaiLoi()
    {
        var loi = Bai2DangKyLogic.KiemTraDangKy("", "sai-dinh-dang", "123456", "123456");

        Assert.Equal(2, loi.Count);
    }

    [Fact]
    public void KiemTraDangKy_XacNhanMatKhauKhongKhop_CoLoi()
    {
        var loi = Bai2DangKyLogic.KiemTraDangKy("tuan", "tuan@gmail.com", "123456", "654321");

        Assert.Contains("Xac nhan mat khau khong khop", loi);
    }

    [Fact]
    public void TaoThongBaoDangKy_DuLieuHopLe_ChuaDayDuThongTin()
    {
        string thongBao = Bai2DangKyLogic.TaoThongBaoDangKy("tuan", "tuan@gmail.com", "123456");

        Assert.Contains("tuan", thongBao);
        Assert.Contains("tuan@gmail.com", thongBao);
        Assert.Contains("123456", thongBao);
    }
}
