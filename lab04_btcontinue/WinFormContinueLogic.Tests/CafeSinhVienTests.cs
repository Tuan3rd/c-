namespace WinFormContinueLogic.Tests;

public class CafeSinhVienTests
{
    [Theory]
    [InlineData(LoaiCafe.CafeDen, 20_000)]
    [InlineData(LoaiCafe.CafeDa, 25_000)]
    [InlineData(LoaiCafe.CafeSua, 25_000)]
    [InlineData(LoaiCafe.CafeSuaDa, 30_000)]
    [InlineData(LoaiCafe.CafeKem, 35_000)]
    public void GiaCuaCafe_CacLoai_TraVeDungBangGia(LoaiCafe loai, int giaMongDoi)
    {
        Assert.Equal(giaMongDoi, CafeSinhVienLogic.GiaCuaCafe(loai));
    }

    [Theory]
    [InlineData(LoaiThucAn.BanhMyTrung, 15_000)]
    [InlineData(LoaiThucAn.BanhMyCa, 15_000)]
    [InlineData(LoaiThucAn.MyTomTrung, 20_000)]
    [InlineData(LoaiThucAn.MyXaoBo, 30_000)]
    [InlineData(LoaiThucAn.MyCay, 50_000)]
    public void GiaCuaThucAn_CacLoai_TraVeDungBangGia(LoaiThucAn loai, int giaMongDoi)
    {
        Assert.Equal(giaMongDoi, CafeSinhVienLogic.GiaCuaThucAn(loai));
    }

    [Theory]
    [InlineData("Tuấn", true)]
    [InlineData("", false)]
    [InlineData("   ", false)]
    [InlineData(null, false)]
    public void TenKhachHangHopLe_CacChuoiNhap_TraVeDungSai(string? ten, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, CafeSinhVienLogic.TenKhachHangHopLe(ten));
    }

    [Fact]
    public void TinhTien_ChiGoiCafeDenKhongLaSinhVien_TraVeDungGiaCafe()
    {
        int tien = CafeSinhVienLogic.TinhTien(LoaiCafe.CafeDen, Array.Empty<LoaiThucAn>(), laSinhVien: false);

        Assert.Equal(20_000, tien);
    }

    [Fact]
    public void TinhTien_CafeVaMotMonAnKhongLaSinhVien_CongDonDung()
    {
        int tien = CafeSinhVienLogic.TinhTien(LoaiCafe.CafeSuaDa, new[] { LoaiThucAn.MyCay }, laSinhVien: false);

        Assert.Equal(30_000 + 50_000, tien);
    }

    [Fact]
    public void TinhTien_LaSinhVien_GiamDung20PhanTram()
    {
        // Cafe den (20.000) + Banh my trung (15.000) = 35.000, giam 20% = 28.000
        int tien = CafeSinhVienLogic.TinhTien(LoaiCafe.CafeDen, new[] { LoaiThucAn.BanhMyTrung }, laSinhVien: true);

        Assert.Equal(28_000, tien);
    }

    [Fact]
    public void TinhTien_KhongGoiCafeChiGoiDoAn_KhongTinhTienCafe()
    {
        int tien = CafeSinhVienLogic.TinhTien(null, new[] { LoaiThucAn.MyXaoBo, LoaiThucAn.BanhMyCa }, laSinhVien: false);

        Assert.Equal(30_000 + 15_000, tien);
    }

    [Fact]
    public void TinhTien_GoiNhieuMonAnCungLuc_CongDonTatCa()
    {
        var dsMon = new[] { LoaiThucAn.BanhMyTrung, LoaiThucAn.BanhMyCa, LoaiThucAn.MyTomTrung };

        int tien = CafeSinhVienLogic.TinhTien(LoaiCafe.CafeDa, dsMon, laSinhVien: false);

        Assert.Equal(25_000 + 15_000 + 15_000 + 20_000, tien);
    }

    [Fact]
    public void TongKet_BaLuotKhach_CongDungTongLuotVaTongTien()
    {
        var (tongLuot, tongTien) = CafeSinhVienLogic.TongKet(new[] { 20_000, 35_000, 28_000 });

        Assert.Equal(3, tongLuot);
        Assert.Equal(83_000, tongTien);
    }

    [Fact]
    public void TongKet_ChuaCoLuotNao_TraVe0Va0()
    {
        var (tongLuot, tongTien) = CafeSinhVienLogic.TongKet(Array.Empty<int>());

        Assert.Equal(0, tongLuot);
        Assert.Equal(0, tongTien);
    }
}
