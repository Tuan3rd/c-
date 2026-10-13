namespace WinFormLogic.Tests;

public class NangCaoBai1Tests
{
    [Theory]
    [InlineData(1, 'A')]
    [InlineData(5, 'A')]
    [InlineData(6, 'B')]
    [InlineData(10, 'B')]
    [InlineData(11, 'C')]
    [InlineData(15, 'C')]
    public void LayLoCuaGhe_CacSoGhe_TraVeDungLo(int soGhe, char loMongDoi)
    {
        Assert.Equal(loMongDoi, NangCaoBai1RapChieuPhimLogic.LayLoCuaGhe(soGhe));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(16)]
    public void LayLoCuaGhe_NgoaiKhoang1Den15_NemArgumentOutOfRangeException(int soGhe)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => NangCaoBai1RapChieuPhimLogic.LayLoCuaGhe(soGhe));
    }

    [Theory]
    [InlineData(1, 1000)]
    [InlineData(6, 1500)]
    [InlineData(11, 2000)]
    public void GiaVeCuaGhe_CacSoGhe_TraVeDungGiaTheoLo(int soGhe, int giaMongDoi)
    {
        Assert.Equal(giaMongDoi, NangCaoBai1RapChieuPhimLogic.GiaVeCuaGhe(soGhe));
    }

    [Fact]
    public void TinhThanhTien_ChonGheOCaBaLo_TongDung()
    {
        // Ghe 1 (lo A=1000) + Ghe 6 (lo B=1500) + Ghe 11 (lo C=2000) = 4500
        int thanhTien = NangCaoBai1RapChieuPhimLogic.TinhThanhTien(new[] { 1, 6, 11 });

        Assert.Equal(4500, thanhTien);
    }

    [Fact]
    public void TinhThanhTien_KhongChonGheNao_TraVe0()
    {
        Assert.Equal(0, NangCaoBai1RapChieuPhimLogic.TinhThanhTien(Array.Empty<int>()));
    }

    [Theory]
    [InlineData(TrangThaiGhe.ChuaBan, TrangThaiGhe.DangChon)]
    [InlineData(TrangThaiGhe.DangChon, TrangThaiGhe.ChuaBan)]
    [InlineData(TrangThaiGhe.DaBan, TrangThaiGhe.DaBan)]
    public void ChuyenTrangThaiKhiClick_CacTrangThai_ChuyenDungQuyTac(TrangThaiGhe trangThaiHienTai, TrangThaiGhe trangThaiMongDoi)
    {
        Assert.Equal(trangThaiMongDoi, NangCaoBai1RapChieuPhimLogic.ChuyenTrangThaiKhiClick(trangThaiHienTai));
    }
}
