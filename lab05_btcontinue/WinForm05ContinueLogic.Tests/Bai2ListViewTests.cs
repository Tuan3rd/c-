namespace WinForm05ContinueLogic.Tests;

public class Bai2ListViewTests
{
    [Theory]
    [InlineData("SV001", "Nguyễn Văn A", true)]
    [InlineData("", "Nguyễn Văn A", false)]
    [InlineData("SV001", "", false)]
    [InlineData(null, "Nguyễn Văn A", false)]
    public void ThongTinHopLe_CacTruongHop_TraVeDungSai(string? maSV, string hoTen, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai2ListViewLogic.ThongTinHopLe(maSV, hoTen));
    }

    [Fact]
    public void TrungMaSinhVien_MaGiongHetKhongPhanBietHoaThuong_TraVeTrue()
    {
        Assert.True(Bai2ListViewLogic.TrungMaSinhVien(new[] { "SV001", "SV002" }, "sv001"));
    }

    [Fact]
    public void TrungMaSinhVien_MaMoiHoanToan_TraVeFalse()
    {
        Assert.False(Bai2ListViewLogic.TrungMaSinhVien(new[] { "SV001", "SV002" }, "SV003"));
    }
}
