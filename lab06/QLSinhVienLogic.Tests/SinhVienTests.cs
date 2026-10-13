namespace QLSinhVienLogic.Tests;

public class SinhVienRepositoryTests
{
    [Fact]
    public void Them_SinhVienMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemorySinhVienRepository();

        repo.Them(new SinhVien { MaSinhVien = "SV01", HoTen = "Nguyễn Văn A", MaLop = "05DHTH1", NgaySinh = new DateTime(2002, 1, 1) });

        Assert.True(repo.TonTai("SV01"));
    }

    [Fact]
    public void Xoa_MaSvVaHoTenKhopDung_XoaThanhCong()
    {
        var repo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());

        repo.Xoa("2001140001", "Nguyễn Văn A");

        Assert.False(repo.TonTai("2001140001"));
    }

    [Fact]
    public void Xoa_HoTenKhongKhop_NemInvalidOperationException()
    {
        var repo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());

        // Dung yeu cau de bai: xoa theo CA ma SV VA ten trung khop - ten sai thi khong xoa duoc.
        Assert.Throws<InvalidOperationException>(() => repo.Xoa("2001140001", "Tên Sai"));
        Assert.True(repo.TonTai("2001140001"));
    }

    [Fact]
    public void Sua_ChiTruyenHoTenMoi_MaLopVaNgaySinhGiuNguyen()
    {
        var repo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());
        var truoc = repo.LayTatCa().First(s => s.MaSinhVien == "2001140001");

        repo.Sua("2001140001", maLopMoi: null, hoTenMoi: "Nguyễn Văn A (đổi tên)", ngaySinhMoi: null);

        var sau = repo.LayTatCa().First(s => s.MaSinhVien == "2001140001");
        Assert.Equal("Nguyễn Văn A (đổi tên)", sau.HoTen);
        Assert.Equal(truoc.MaLop, sau.MaLop);
        Assert.Equal(truoc.NgaySinh, sau.NgaySinh);
    }
}

public class SinhVienValidationTests
{
    [Theory]
    [InlineData("05DHTH1", "SV01", "Nguyễn Văn A", "01/01/2002", true)]
    [InlineData("", "SV01", "Nguyễn Văn A", "01/01/2002", false)]
    [InlineData("05DHTH1", "", "Nguyễn Văn A", "01/01/2002", false)]
    [InlineData("05DHTH1", "SV01", "", "01/01/2002", false)]
    [InlineData("05DHTH1", "SV01", "Nguyễn Văn A", "", false)]
    public void ThemHopLe_CacTruongHop_TraVeDungSai(
        string maLop, string maSV, string hoTen, string ngaySinh, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, SinhVienValidation.ThemHopLe(maLop, maSV, hoTen, ngaySinh));
    }

    [Fact]
    public void XoaHopLe_CanCaMaSvVaHoTen()
    {
        Assert.True(SinhVienValidation.XoaHopLe("SV01", "Nguyễn Văn A"));
        Assert.False(SinhVienValidation.XoaHopLe("SV01", ""));
        Assert.False(SinhVienValidation.XoaHopLe("", "Nguyễn Văn A"));
    }

    [Fact]
    public void SuaHopLe_ChiMotTruongCoDuLieu_VanHopLe()
    {
        Assert.True(SinhVienValidation.SuaHopLe("SV01", maLopMoi: "05DHTH2", hoTenMoi: null, ngaySinhMoiText: null));
    }

    [Fact]
    public void SuaHopLe_KhongTruongNaoCoDuLieu_KhongHopLe()
    {
        Assert.False(SinhVienValidation.SuaHopLe("SV01", null, null, null));
    }

    [Fact]
    public void NgaySinhHopLe_ChuoiNgayHopLe_TraVeDungGiaTri()
    {
        bool ketQua = SinhVienValidation.NgaySinhHopLe("12/03/2002", out DateTime ngaySinh);

        Assert.True(ketQua);
        Assert.Equal(2002, ngaySinh.Year);
    }

    [Fact]
    public void NgaySinhHopLe_ChuoiKhongPhaiNgay_TraVeFalse()
    {
        Assert.False(SinhVienValidation.NgaySinhHopLe("abc", out _));
    }
}
