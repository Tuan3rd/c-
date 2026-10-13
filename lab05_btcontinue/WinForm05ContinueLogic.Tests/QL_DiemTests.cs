namespace WinForm05ContinueLogic.Tests;

public class QL_DiemRepositoryTests
{
    [Fact]
    public void Them_DiemMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemoryDiemRepository();

        repo.Them(new Diem { MaSinhVien = "SV01", MaMonHoc = "LTC001", DiemSo = 8.5 });

        Assert.True(repo.TonTai("SV01", "LTC001"));
    }

    [Fact]
    public void Them_DaTonTaiDiemSinhVienMonHocDo_NemInvalidOperationException()
    {
        var repo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new Diem { MaSinhVien = "2001140001", MaMonHoc = "LTC001", DiemSo = 5 }));
    }

    [Fact]
    public void Sua_DiemTonTai_CapNhatDungGiaTri()
    {
        var repo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());

        repo.Sua("2001140001", "LTC001", 9.5);

        Assert.Equal(9.5, repo.LayTatCa().First(d => d.MaSinhVien == "2001140001" && d.MaMonHoc == "LTC001").DiemSo);
    }

    [Fact]
    public void Xoa_DiemTonTai_XoaDungDong()
    {
        var repo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());

        repo.Xoa("2001140001", "LTC001");

        Assert.False(repo.TonTai("2001140001", "LTC001"));
    }
}

public class QL_DiemValidationTests
{
    [Theory]
    [InlineData("8.5", true, 8.5)]
    [InlineData("10", true, 10)]
    [InlineData("-1", false, -1)]
    [InlineData("abc", false, 0)]
    [InlineData("", false, 0)]
    public void LaDiemHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, double giaTriMongDoi)
    {
        bool ketQua = DiemValidation.LaDiemHopLe(text, out double diem);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, diem);
    }

    [Fact]
    public void ThemHopLe_DiemKhongPhaiSo_KhongHopLe()
    {
        Assert.False(DiemValidation.ThemHopLe("SV01", "LTC001", "tám"));
    }

    [Fact]
    public void XoaHopLe_KhongCanDiem_ChiCanMaSvVaMaMonHoc()
    {
        Assert.True(DiemValidation.XoaHopLe("SV01", "LTC001"));
    }

    [Fact]
    public void SuaHopLe_DiemBatBuocVaPhaiLaSo()
    {
        Assert.True(DiemValidation.SuaHopLe("SV01", "LTC001", "9.5"));
        Assert.False(DiemValidation.SuaHopLe("SV01", "LTC001", ""));
        Assert.False(DiemValidation.SuaHopLe("SV01", "LTC001", "chín"));
    }
}
