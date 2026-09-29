using Xunit;

namespace LinqLogic.Tests;

public class Bai2Tests
{
    private static readonly int[] MangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
    private static readonly string[] MangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

    [Fact]
    public void ChiaHetCho4Va3_MangSoMau_TraVe12_24_0()
    {
        var expected = new[] { 12, 24, 0 };

        Assert.Equal(expected, Bai2Logic.ChiaHetCho4Va3_Query(MangSo));
        Assert.Equal(expected, Bai2Logic.ChiaHetCho4Va3_Method(MangSo));
    }

    [Fact]
    public void NhoHonBang3_MangSoMau_TraVe3_0()
    {
        var expected = new[] { 3, 0 };

        Assert.Equal(expected, Bai2Logic.NhoHonBang3_Query(MangSo));
        Assert.Equal(expected, Bai2Logic.NhoHonBang3_Method(MangSo));
    }

    [Fact]
    public void ChanChiaDoiLeGiuNguyen_MangSoMau_KhopKetQuaMauCuaDeBai()
    {
        // Ket qua mau ghi san trong de: 25, 21, 8, 3, 9, 4, 6, 7, 12, 0
        var expected = new[] { 25, 21, 8, 3, 9, 4, 6, 7, 12, 0 };

        Assert.Equal(expected, Bai2Logic.ChanChiaDoiLeGiuNguyen_Query(MangSo));
        Assert.Equal(expected, Bai2Logic.ChanChiaDoiLeGiuNguyen_Method(MangSo));
    }

    [Fact]
    public void Bon4KyTuSapXep_MangChuoiMau_ThuTuTheoMaUnicode()
    {
        // K (75) < T (84) < l (108) nen thu tu la Kieu, Thuy, Thuy, long
        var expected = new[] { "Kiều", "Thúy", "Thúy", "lòng" };

        Assert.Equal(expected, Bai2Logic.Bon4KyTuSapXep_Query(MangChuoi));
        Assert.Equal(expected, Bai2Logic.Bon4KyTuSapXep_Method(MangChuoi));
    }

    [Fact]
    public void ThuongHoa_MotPhanTu_DungDinhDangThuongGachHoa()
    {
        var ket = Bai2Logic.ThuongHoa_Method(new[] { "đầu" });

        Assert.Equal(new[] { "đầu - ĐẦU" }, ket);
        Assert.Equal(ket, Bai2Logic.ThuongHoa_Query(new[] { "đầu" }));
    }

    [Fact]
    public void ChuaKyTuU_MangChuoiMau_ChiKhopDauVaKieu()
    {
        // "Thuy" chua ky tu "u" co dau (u), khac ky tu 'u' thuong nen khong duoc tinh
        var expected = new[] { "đầu", "Kiều" };

        Assert.Equal(expected, Bai2Logic.ChuaKyTuU_Query(MangChuoi));
        Assert.Equal(expected, Bai2Logic.ChuaKyTuU_Method(MangChuoi));
    }

    [Fact]
    public void BatDauChuHoa_MangChuoiMau_GhepThanhThuyKieuThuyVan()
    {
        var ket = Bai2Logic.BatDauChuHoa_Method(MangChuoi);

        Assert.Equal("Thúy Kiều Thúy Vân", string.Join(" ", ket));
        Assert.Equal(ket, Bai2Logic.BatDauChuHoa_Query(MangChuoi));
    }
}
