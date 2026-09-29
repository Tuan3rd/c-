using Xunit;

namespace LinqLogic.Tests;

public class Bai6Tests
{
    private static readonly List<MonHoc> DsMon = DuLieu.DS_Mon();
    private static readonly List<He> DsHe = DuLieu.DS_He();

    [Fact]
    public void InnerJoin_LoaiMonKhongKhopHe_Con17Dong()
    {
        var ket = Bai6Logic.InnerJoin(DsMon, DsHe).ToList();

        Assert.Equal(17, ket.Count);
        Assert.DoesNotContain(ket, x => x.MaMon == "XYZ");
    }

    [Fact]
    public void LeftOuterJoin_HeQT_VanXuatHienDuKhongCoMon()
    {
        var ket = Bai6Logic.LeftOuterJoin(DsHe, DsMon).ToList();

        Assert.Equal(18, ket.Count); // 17 mon khop he + 1 dong rieng cho he QT
        Assert.Contains(ket, x => x.TenHe == "Chứng chỉ quốc tế" && x.MaMon == "(chua co mon)");
    }

    [Fact]
    public void HeChuaCoMon_ChiCoChungChiQuocTe()
    {
        var ket = Bai6Logic.HeChuaCoMon(DsHe, DsMon);

        Assert.Equal(new[] { "Chứng chỉ quốc tế" }, ket);
    }

    [Fact]
    public void MonChuaKhaiBaoHe_ChiCoXYZ()
    {
        var ket = Bai6Logic.MonChuaKhaiBaoHe(DsMon, DsHe);

        Assert.Equal(new[] { "XYZ" }, ket);
    }

    [Fact]
    public void FullOuterJoin_ChuaCaHeMoCoiVaMonMoCoi()
    {
        var ket = Bai6Logic.FullOuterJoin(DsHe, DsMon).ToList();

        Assert.Equal(19, ket.Count); // 17 mon khop he + 1 he rong (QT) + 1 mon mo coi (XYZ)
        Assert.Contains(ket, x => x.TenHe == "Chứng chỉ quốc tế" && x.MaMon == null);
        Assert.Contains(ket, x => x.MaMon == "XYZ" && x.TenHe == null);
    }

    [Fact]
    public void Top5GiamDanSoTiet_DungThuTuVaGiaTriDauTien()
    {
        var ket = Bai6Logic.Top5GiamDanSoTiet(DsMon, DsHe).ToList();

        Assert.Equal(5, ket.Count);
        Assert.Equal("CC++", ket[0].MaMon);
        Assert.Equal(128, ket[0].SoTiet);
        Assert.True(ket.Zip(ket.Skip(1), (a, b) => a.SoTiet >= b.SoTiet).All(dung => dung));
    }

    [Fact]
    public void TongMonMoiHe_KTV8_CD9_QT0()
    {
        var nhom = Bai6Logic.TongMonMoiHe(DsHe, DsMon).ToDictionary(x => x.MaHe, x => x.TongMon);

        Assert.Equal(8, nhom["KTV"]);
        Assert.Equal(9, nhom["CD"]);
        Assert.Equal(0, nhom["QT"]);
    }

    [Fact]
    public void SoLoaiSoTietKhacNhau_Tra7()
    {
        Assert.Equal(7, Bai6Logic.SoLoaiSoTietKhacNhau(DsMon));
    }

    [Fact]
    public void MonDauTienBatDauLapTrinh_LaHP3_1()
    {
        var mon = Bai6Logic.MonDauTienBatDauLapTrinh(DsMon);

        Assert.NotNull(mon);
        Assert.Equal("HP3_1", mon!.MaMon);
    }
}
