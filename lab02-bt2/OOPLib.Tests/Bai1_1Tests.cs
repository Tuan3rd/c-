using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai1_1Tests
{
    [Fact]
    public void TinhTuoi_NamSinhBinhThuong_TraVeDungTuoi()
    {
        var sv = new SinhVien("Thai Tuan", 2003);

        Assert.Equal(22, sv.TinhTuoi(2025));
    }

    [Fact]
    public void TinhTuoi_NamHienTaiBangNamSinh_TraVeKhong()
    {
        var sv = new SinhVien("Thai Tuan", 2003);

        Assert.Equal(0, sv.TinhTuoi(2003));
    }

    [Fact]
    public void Property_GanGiaTriMoi_DocLaiDungGiaTri()
    {
        var sv = new SinhVien("A", 2000);
        sv.HoTen = "B";
        sv.NamSinh = 2001;

        Assert.Equal("B", sv.HoTen);
        Assert.Equal(2001, sv.NamSinh);
    }
}
