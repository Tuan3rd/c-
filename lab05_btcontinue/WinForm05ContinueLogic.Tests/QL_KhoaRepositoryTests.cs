namespace WinForm05ContinueLogic.Tests;

public class QL_KhoaRepositoryTests
{
    [Fact]
    public void Them_KhoaMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemoryKhoaRepository();

        repo.Them(new Khoa { MaKhoa = "CNTT", TenKhoa = "Công Nghệ Thông Tin" });

        Assert.Single(repo.LayTatCa());
        Assert.True(repo.TonTai("CNTT"));
    }

    [Fact]
    public void Them_MaKhoaDaTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new Khoa { MaKhoa = "CNTT", TenKhoa = "Trùng mã" }));
    }

    [Fact]
    public void Xoa_MaKhoaTonTai_XoaDungKhoa()
    {
        var repo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());

        repo.Xoa("CNTT");

        Assert.False(repo.TonTai("CNTT"));
    }

    [Fact]
    public void Xoa_MaKhoaKhongTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryKhoaRepository();

        Assert.Throws<InvalidOperationException>(() => repo.Xoa("ABC"));
    }

    [Fact]
    public void Sua_MaKhoaTonTai_CapNhatDungTenKhoa()
    {
        var repo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());

        repo.Sua(new Khoa { MaKhoa = "CNTT", TenKhoa = "CNTT Đổi Tên" });

        Assert.Equal("CNTT Đổi Tên", repo.LayTatCa().First(k => k.MaKhoa == "CNTT").TenKhoa);
    }

    [Fact]
    public void Sua_MaKhoaKhongTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryKhoaRepository();

        Assert.Throws<InvalidOperationException>(() => repo.Sua(new Khoa { MaKhoa = "ABC", TenKhoa = "X" }));
    }
}
