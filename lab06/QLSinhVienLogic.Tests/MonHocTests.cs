namespace QLSinhVienLogic.Tests;

public class MonHocRepositoryTests
{
    [Fact]
    public void Them_MonHocMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemoryMonHocRepository();

        repo.Them(new MonHoc { MaMonHoc = "LTC001", TenMonHoc = "Lập trình C#" });

        Assert.True(repo.TonTai("LTC001"));
    }

    [Fact]
    public void Them_MaMonHocDaTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new MonHoc { MaMonHoc = "LTC001", TenMonHoc = "Trùng mã" }));
    }

    [Fact]
    public void Xoa_MaMonHocTonTai_XoaDungMonHoc()
    {
        var repo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());

        repo.Xoa("LTC001");

        Assert.False(repo.TonTai("LTC001"));
    }

    [Fact]
    public void Sua_MaMonHocTonTai_CapNhatDungTenMonHoc()
    {
        var repo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());

        repo.Sua(new MonHoc { MaMonHoc = "LTC001", TenMonHoc = "Lập trình C# nâng cao" });

        Assert.Equal("Lập trình C# nâng cao", repo.LayTatCa().First(m => m.MaMonHoc == "LTC001").TenMonHoc);
    }
}

public class MonHocValidationTests
{
    [Theory]
    [InlineData("LTC001", "Lập trình C#", true)]
    [InlineData("", "Lập trình C#", false)]
    [InlineData("LTC001", "", false)]
    public void ThemHopLe_CacTruongHop_TraVeDungSai(string maMonHoc, string tenMonHoc, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, MonHocValidation.ThemHopLe(maMonHoc, tenMonHoc));
    }

    [Fact]
    public void XoaHopLe_ChiCanMaMonHoc_KhongCanTenMonHoc()
    {
        Assert.True(MonHocValidation.XoaHopLe("LTC001"));
    }

    [Fact]
    public void XoaHopLe_MaMonHocRong_TraVeFalse()
    {
        Assert.False(MonHocValidation.XoaHopLe(""));
    }

    [Fact]
    public void SuaHopLe_CaHaiTruongDayDu_TraVeTrue()
    {
        Assert.True(MonHocValidation.SuaHopLe("LTC001", "Lập trình C# nâng cao"));
    }
}
