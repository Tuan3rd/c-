namespace WinForm05ContinueLogic.Tests;

public class QL_LopRepositoryTests
{
    [Fact]
    public void Them_LopMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemoryLopRepository();

        repo.Them(new Lop { MaLop = "05DHTH1", TenLop = "ĐH Tin học 1", MaKhoa = "CNTT" });

        Assert.True(repo.TonTai("05DHTH1"));
    }

    [Fact]
    public void Them_MaLopDaTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new Lop { MaLop = "05DHTH1", TenLop = "Trùng mã", MaKhoa = "CNTT" }));
    }

    [Fact]
    public void Sua_ChiTruyenTenLopMoi_MaKhoaGiuNguyen()
    {
        var repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

        repo.Sua("05DHTH1", tenLopMoi: "ĐH Tin học 1 (đổi tên)", maKhoaMoi: null);

        var lop = repo.LayTatCa().First(l => l.MaLop == "05DHTH1");
        Assert.Equal("ĐH Tin học 1 (đổi tên)", lop.TenLop);
        Assert.Equal("CNTT", lop.MaKhoa); // khong doi vi khong truyen maKhoaMoi
    }

    [Fact]
    public void Sua_ChiTruyenMaKhoaMoi_TenLopGiuNguyen()
    {
        var repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

        repo.Sua("05DHTH1", tenLopMoi: null, maKhoaMoi: "QTKD");

        var lop = repo.LayTatCa().First(l => l.MaLop == "05DHTH1");
        Assert.Equal("ĐH Tin học 1", lop.TenLop); // khong doi
        Assert.Equal("QTKD", lop.MaKhoa);
    }

    [Fact]
    public void Xoa_MaLopTonTai_XoaDungLop()
    {
        var repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

        repo.Xoa("05DHTH1");

        Assert.False(repo.TonTai("05DHTH1"));
    }
}

public class QL_LopValidationTests
{
    [Theory]
    [InlineData("CNTT", "05DHTH1", "ĐH Tin học 1", true)]
    [InlineData("", "05DHTH1", "ĐH Tin học 1", false)]
    [InlineData("CNTT", "", "ĐH Tin học 1", false)]
    [InlineData("CNTT", "05DHTH1", "", false)]
    public void ThemHopLe_CacTruongHop_TraVeDungSai(string maKhoa, string maLop, string tenLop, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, LopValidation.ThemHopLe(maKhoa, maLop, tenLop));
    }

    [Fact]
    public void XoaHopLe_ChiCanMaLop()
    {
        Assert.True(LopValidation.XoaHopLe("05DHTH1"));
        Assert.False(LopValidation.XoaHopLe(""));
    }

    [Fact]
    public void SuaHopLe_ChiTenLopCoDuLieu_VanHopLe()
    {
        // "Ma khoa, Ten lop phai co it nhat 1 truong co du lieu"
        Assert.True(LopValidation.SuaHopLe("05DHTH1", maKhoaMoi: null, tenLopMoi: "Tên mới"));
    }

    [Fact]
    public void SuaHopLe_ChiMaKhoaCoDuLieu_VanHopLe()
    {
        Assert.True(LopValidation.SuaHopLe("05DHTH1", maKhoaMoi: "QTKD", tenLopMoi: null));
    }

    [Fact]
    public void SuaHopLe_KhongTruongNaoCoDuLieu_KhongHopLe()
    {
        Assert.False(LopValidation.SuaHopLe("05DHTH1", maKhoaMoi: null, tenLopMoi: null));
    }

    [Fact]
    public void SuaHopLe_MaLopRong_KhongHopLeDuCacTruongKhacCoDuLieu()
    {
        Assert.False(LopValidation.SuaHopLe("", maKhoaMoi: "QTKD", tenLopMoi: "Tên mới"));
    }
}
