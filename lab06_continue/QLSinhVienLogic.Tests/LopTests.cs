namespace QLSinhVienLogic.Tests;

public class LopRepositoryTests
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
        Assert.Equal("CNTT", lop.MaKhoa);
    }

    [Fact]
    public void Xoa_MaLopTonTai_XoaDungLop()
    {
        var repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

        repo.Xoa("05DHTH1");

        Assert.False(repo.TonTai("05DHTH1"));
    }
}

public class LopValidationTests
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

    // Khac lab06 (06a): o lab nay (06b), Sua bat buoc CA Ma khoa moi VA Ten lop moi
    // (khong con cho phep sua mot phan), dung theo "Yeu cau" rieng cua bai nay.
    [Theory]
    [InlineData("05DHTH1", "QTKD", "Tên mới", true)]
    [InlineData("05DHTH1", null, "Tên mới", false)]
    [InlineData("05DHTH1", "QTKD", null, false)]
    [InlineData("", "QTKD", "Tên mới", false)]
    public void SuaHopLe_CacTruongHop_TraVeDungSai(string maLop, string? maKhoaMoi, string? tenLopMoi, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, LopValidation.SuaHopLe(maLop, maKhoaMoi, tenLopMoi));
    }

    [Fact]
    public void CoTheXoa_KhongConSinhVienThuocLop_TraVeTrue()
    {
        var dsSinhVien = QLSinhVienDuLieuMau.SinhVienMau().Where(sv => sv.MaLop != "05DHTH1");

        Assert.True(LopValidation.CoTheXoa("05DHTH1", dsSinhVien));
    }

    [Fact]
    public void CoTheXoa_VanConSinhVienThuocLop_TraVeFalse()
    {
        var dsSinhVien = QLSinhVienDuLieuMau.SinhVienMau();

        // Du lieu mau co it nhat 1 sinh vien thuoc lop "05DHTH1" nen khong duoc xoa lop nay.
        Assert.False(LopValidation.CoTheXoa("05DHTH1", dsSinhVien));
    }
}
