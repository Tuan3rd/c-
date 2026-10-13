namespace WinForm05Logic.Tests;

public class Bai3PhongBanTests
{
    [Fact]
    public void PhongBanMacDinh_CoDungBonPhongBanTheoDeBai()
    {
        Assert.Equal(new[] { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" }, Bai3PhongBanLogic.PhongBanMacDinh);
    }

    [Fact]
    public void TrungTenPhongBan_TenGiongHetChuHoaChuThuong_TraVeTrue()
    {
        bool trung = Bai3PhongBanLogic.TrungTenPhongBan(Bai3PhongBanLogic.PhongBanMacDinh, "kế toán");

        Assert.True(trung);
    }

    [Fact]
    public void TrungTenPhongBan_TenMoiHoanToan_TraVeFalse()
    {
        bool trung = Bai3PhongBanLogic.TrungTenPhongBan(Bai3PhongBanLogic.PhongBanMacDinh, "Kinh doanh");

        Assert.False(trung);
    }

    [Fact]
    public void TaoNoiDungNodeNhanVien_MauTrongDeBai_TraVeDungDinhDang()
    {
        Assert.Equal("Nguyễn Bính (N001)", Bai3PhongBanLogic.TaoNoiDungNodeNhanVien("Nguyễn Bính", "N001"));
    }
}
