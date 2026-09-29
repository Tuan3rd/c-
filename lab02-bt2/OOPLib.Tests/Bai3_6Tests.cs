using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai3_6Tests
{
    [Theory]
    [InlineData(6, 24)]  // tiengAnh = 6 -> khong cong diem
    [InlineData(7, 25)]  // 7 <= tiengAnh <= 8 -> cong 1
    [InlineData(8, 25)]
    [InlineData(9, 26)]  // 9 <= tiengAnh <= 10 -> cong 2
    [InlineData(10, 26)]
    public void ThiSinhChuyen_TinhTongDiem_ThuongDungTheoMocTiengAnh(double tiengAnh, double mongDoi)
    {
        var ts = new ThiSinhChuyen("TS01", "A", 8, 8, 8, tiengAnh);

        Assert.Equal(mongDoi, ts.TinhTongDiem());
    }

    [Fact]
    public void ThiSinhSieuCup_TinhTongDiem_CongDuBonBaiThi()
    {
        var ts = new ThiSinhSieuCup("TS02", "B", 8, 8, 8, 9);

        Assert.Equal(33, ts.TinhTongDiem());
    }

    [Fact]
    public void DaHinh_MangThiSinh_GoiDungPhienBanTinhTongDiem()
    {
        ThiSinh[] danhSach =
        {
            new ThiSinhChuyen("TS01", "A", 8, 9, 7, 9),
            new ThiSinhSieuCup("TS02", "B", 8, 8, 8, 9),
        };

        Assert.Equal(26, danhSach[0].TinhTongDiem());
        Assert.Equal(33, danhSach[1].TinhTongDiem());
    }
}
