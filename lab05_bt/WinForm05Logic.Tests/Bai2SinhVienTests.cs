namespace WinForm05Logic.Tests;

public class Bai2SinhVienTests
{
    [Fact]
    public void LopMacDinh_CoDungBonLopTheoDeBai()
    {
        Assert.Equal(new[] { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" }, Bai2SinhVienLogic.LopMacDinh);
    }

    [Fact]
    public void TrungTenLop_TenGiongHetKhongPhanBietHoaThuong_TraVeTrue()
    {
        Assert.True(Bai2SinhVienLogic.TrungTenLop(Bai2SinhVienLogic.LopMacDinh, "05dhth2"));
    }

    [Fact]
    public void TrungTenLop_TenMoiHoanToan_TraVeFalse()
    {
        Assert.False(Bai2SinhVienLogic.TrungTenLop(Bai2SinhVienLogic.LopMacDinh, "05DHTH5"));
    }

    [Fact]
    public void TrungMaSinhVien_MaGiongHet_TraVeTrue()
    {
        Assert.True(Bai2SinhVienLogic.TrungMaSinhVien(new[] { "2001140001", "200114" }, "200114"));
    }

    [Theory]
    [InlineData("200115", "Nguyễn Văn Bình", "TPHCM", true)]
    [InlineData("", "Nguyễn Văn Bình", "TPHCM", false)]
    [InlineData("200115", "", "TPHCM", false)]
    [InlineData("200115", "Nguyễn Văn Bình", "", false)]
    [InlineData(null, "Nguyễn Văn Bình", "TPHCM", false)]
    public void ThongTinSinhVienHopLe_CacTruongHop_TraVeDungSai(string? maSV, string hoTen, string diaChi, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai2SinhVienLogic.ThongTinSinhVienHopLe(maSV, hoTen, diaChi));
    }

    [Fact]
    public void TaoNoiDungNodeSinhVien_MauTrongDeBai_TraVeDungDinhDang()
    {
        Assert.Equal("200115, Nguyễn Văn Bình", Bai2SinhVienLogic.TaoNoiDungNodeSinhVien("200115", "Nguyễn Văn Bình"));
    }

    [Fact]
    public void TachMaSvTuNoiDungNode_NodeHopLe_TraVeDungMaSV()
    {
        Assert.Equal("200115", Bai2SinhVienLogic.TachMaSvTuNoiDungNode("200115, Nguyễn Văn Bình"));
    }

    [Fact]
    public void TachMaSvTuNoiDungNode_KhongCoDauPhay_TraVeNguyenChuoi()
    {
        Assert.Equal("05DHTH1", Bai2SinhVienLogic.TachMaSvTuNoiDungNode("05DHTH1"));
    }
}
