using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai3_5Tests
{
    [Fact]
    public void NhanVienKinhDoanh_TinhLuong_CongDungTienThuongHopDong()
    {
        var nv = new NhanVienKinhDoanh("KD01", "A", 8_000_000, 5);

        // 8.000.000 + 5 * 500.000 = 10.500.000
        Assert.Equal(10_500_000, nv.TinhLuong());
    }

    [Fact]
    public void NhanVienKinhDoanh_KhongCoHopDong_LuongBangLuongCoBan()
    {
        var nv = new NhanVienKinhDoanh("KD02", "B", 8_000_000, 0);

        Assert.Equal(8_000_000, nv.TinhLuong());
    }

    [Fact]
    public void NhanVienSanXuat_Duoi3000SanPham_KhongDuocThuong()
    {
        var nv = new NhanVienSanXuat("SX01", "C", 2000);

        Assert.Equal(2_000_000, nv.TinhLuong());
    }

    [Fact]
    public void NhanVienSanXuat_Tren3000SanPham_DuocThuong5PhanTram()
    {
        var nv = new NhanVienSanXuat("SX02", "D", 3500);

        // 3500 * 1000 = 3.500.000, thuong 5% -> 3.675.000
        Assert.Equal(3_675_000, nv.TinhLuong());
    }

    [Fact]
    public void NhanVienSanXuat_DungBang3000SanPham_KhongDuocThuong()
    {
        // De bai ghi "tren 3000" -> dung bang 3000 KHONG duoc thuong
        var nv = new NhanVienSanXuat("SX03", "E", 3000);

        Assert.Equal(3_000_000, nv.TinhLuong());
    }

    [Fact]
    public void DaHinh_MangNhanVienCongTy_GoiDungPhienBanTinhLuong()
    {
        NhanVienCongTy[] danhSach =
        {
            new NhanVienKinhDoanh("KD01", "A", 8_000_000, 5),
            new NhanVienSanXuat("SX01", "B", 3500),
        };

        Assert.Equal(10_500_000, danhSach[0].TinhLuong());
        Assert.Equal(3_675_000, danhSach[1].TinhLuong());
    }
}
