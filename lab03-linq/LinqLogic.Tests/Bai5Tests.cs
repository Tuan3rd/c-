using Xunit;

namespace LinqLogic.Tests;

public class Bai5Tests
{
    private static readonly List<MonHoc> DsMon = DuLieu.DS_Mon();

    [Fact]
    public void TenMonBatDauLapTrinh_Du18Mon_Ra5MonDungThuTu()
    {
        var expected = new[]
        {
            "Lập trình Windows Forms",
            "Lập trình Web với HTML, CSS và JavaScript",
            "Lập trình CSDL SQL Server căn bản",
            "Lập trình CSDL SQL Server nâng cao",
            "Lập trình hướng đối tượng với C/C++",
        };

        Assert.Equal(expected, Bai5Logic.TenMonBatDauLapTrinh_Query(DsMon));
        Assert.Equal(expected, Bai5Logic.TenMonBatDauLapTrinh_Method(DsMon));
    }

    [Fact]
    public void MonHeCD_SapXep_DungThuTuGiamDanSoTietRoiTangDanMaMon()
    {
        var expectedMaMon = new[] { "CC++", "JLCB", "LINQ", "DAWEB", "DAWIN", "BWEB", "CRYS", "XML", "JQUE" };

        Assert.Equal(expectedMaMon, Bai5Logic.MonHeCD_SapXep_Query(DsMon).Select(m => m.MaMon));
        Assert.Equal(expectedMaMon, Bai5Logic.MonHeCD_SapXep_Method(DsMon).Select(m => m.MaMon));
    }

    [Fact]
    public void MonChuaWeb_KhongPhanBietHoaThuong_Ra3Mon()
    {
        var ket = Bai5Logic.MonChuaWeb(DsMon).ToList();

        Assert.Equal(3, ket.Count);
        Assert.Contains(ket, x => x.TenMon == "Lập trình Web với HTML, CSS và JavaScript" && x.He == "KTV");
        Assert.Contains(ket, x => x.TenMon == "Xây dựng ứng dụng Web với ASP.NET" && x.He == "KTV");
        Assert.Contains(ket, x => x.TenMon == "Đồ án thực tế Web với ASP.NET" && x.He == "CD");
    }

    [Fact]
    public void MonHeKTV_SapXep_Du8MonTangDanMaMon()
    {
        var expected = new[] { "HP2_1", "HP2_2", "HP3_1", "HP3_2", "HP4_1", "HP4_2", "HP5_1", "HP5_2" };

        Assert.Equal(expected, Bai5Logic.MonHeKTV_SapXep_Query(DsMon).Select(m => m.MaMon));
        Assert.Equal(expected, Bai5Logic.MonHeKTV_SapXep_Method(DsMon).Select(m => m.MaMon));
    }

    [Fact]
    public void TongSoMon_Du18Mon()
    {
        Assert.Equal(18, Bai5Logic.TongSoMon(DsMon));
    }

    [Fact]
    public void SoMonBatDauLapTrinh_Tra5()
    {
        Assert.Equal(5, Bai5Logic.SoMonBatDauLapTrinh(DsMon));
    }

    [Fact]
    public void TongTietHeKTV_Tra512()
    {
        Assert.Equal(512, Bai5Logic.TongTietHeKTV(DsMon));
    }

    [Fact]
    public void TongMonMoiHe_KTV8_CD9_HeRongMotMon()
    {
        var nhom = Bai5Logic.TongMonMoiHe(DsMon).ToDictionary(x => x.He, x => x.TongMon);

        Assert.Equal(8, nhom["KTV"]);
        Assert.Equal(9, nhom["CD"]);
        Assert.Equal(1, nhom[""]);
    }

    [Fact]
    public void NhomTheoSoTietGiamDan_DungThuTuVaSoLuongMoiNhom()
    {
        var ket = Bai5Logic.NhomTheoSoTietGiamDan(DsMon).ToList();

        Assert.Equal(new byte[] { 128, 72, 64, 40, 32, 22, 0 }, ket.Select(x => x.SoTiet));
        Assert.Equal(9, ket.First(x => x.SoTiet == 64).TongMon);
        Assert.Equal(3, ket.First(x => x.SoTiet == 32).TongMon);
    }

    [Fact]
    public void MonSoTietCaoNhat_LaCCPlusPlus128Tiet()
    {
        var mon = Bai5Logic.MonSoTietCaoNhat(DsMon);

        Assert.Equal("CC++", mon.MaMon);
        Assert.Equal(128, mon.SoTiet);
    }

    [Fact]
    public void ThongKeTheoHe_KTVvaCD_DungSoLieu()
    {
        var nhom = Bai5Logic.ThongKeTheoHe(DsMon).ToDictionary(x => x.He);

        Assert.Equal((8, 512, (byte)64, (byte)64), (nhom["KTV"].TongMon, nhom["KTV"].TongTiet, nhom["KTV"].TietCaoNhat, nhom["KTV"].TietThapNhat));
        Assert.Equal((9, 462, (byte)128, (byte)22), (nhom["CD"].TongMon, nhom["CD"].TongTiet, nhom["CD"].TietCaoNhat, nhom["CD"].TietThapNhat));
    }

    [Fact]
    public void NhomHocPhanKTV_Ra4NhomHP2DenHP5()
    {
        var nhom = Bai5Logic.NhomHocPhanKTV(DsMon).ToDictionary(g => g.Key, g => g.Select(m => m.MaMon).ToArray());

        Assert.Equal(new[] { "HP2", "HP3", "HP4", "HP5" }, nhom.Keys);
        Assert.Equal(new[] { "HP2_1", "HP2_2" }, nhom["HP2"]);
        Assert.Equal(new[] { "HP5_1", "HP5_2" }, nhom["HP5"]);
    }

    [Fact]
    public void NhomHeLocSoTietTren40_KhongConNhomRongCuaXYZ()
    {
        var nhom = Bai5Logic.NhomHeLocSoTietTren40(DsMon).ToDictionary(g => g.Key, g => g.Select(m => m.MaMon).ToArray());

        Assert.Equal(2, nhom.Count); // chi con KTV va CD, nhom "" cua XYZ da bien mat vi loc truoc khi GroupBy
        Assert.Equal(8, nhom["KTV"].Length);
        Assert.Equal(new[] { "CC++", "JLCB", "LINQ" }, nhom["CD"]);
    }
}
