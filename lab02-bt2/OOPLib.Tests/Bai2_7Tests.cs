using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_7Tests
{
    [Fact]
    public void NhanVienDonGian_TinhLuong_KhongVang_BangMucLuong()
    {
        var nv = new NhanVienDonGian("A", 10_000_000, 0);

        Assert.Equal(10_000_000, nv.TinhLuong());
    }

    [Fact]
    public void NhanVienDonGian_TinhLuong_CoVang_TruDungSoTien()
    {
        var nv = new NhanVienDonGian("A", 10_000_000, 2);

        Assert.Equal(9_800_000, nv.TinhLuong());
    }

    [Fact]
    public void PhongBan_TongLuong_CongDungTatCaNhanVien()
    {
        var pb = new PhongBan();
        pb.Add(new NhanVienDonGian("A", 10_000_000, 0));
        pb.Add(new NhanVienDonGian("B", 8_000_000, 1));

        Assert.Equal(17_900_000, pb.TongLuong());
    }

    [Fact]
    public void PhongBan_KhongCoNhanVien_TongLuongBangKhong()
    {
        var pb = new PhongBan();

        Assert.Equal(0, pb.TongLuong());
    }
}
