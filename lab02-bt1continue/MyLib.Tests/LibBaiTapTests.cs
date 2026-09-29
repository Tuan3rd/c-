using MyLib;
using Xunit;

namespace MyLib.Tests;

public class LibBaiTapTests
{
    // ========== 7 test case toi thieu theo bang kiem thu trong de bai ==========

    [Fact]
    public void GiaiPTBac2_A0_B0_C0_VoSoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void GiaiPTBac2_A0_B0_CKhac0_VoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2, x1);
    }

    [Fact]
    public void GiaiPTBac2_DeltaNhoHon0_VoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_DeltaBang0_CoNghiemKep()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(1, x1);
    }

    [Fact]
    public void GiaiPTBac2_DeltaLonHon0_CoHaiNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1, x1);
        Assert.Equal(2, x2);
    }

    [Fact]
    public void GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1, x1);
        Assert.Equal(2, x2);
        Assert.True(x1 <= x2);
    }

    // ========== Test bo sung cho phan nang cap dung EPS khi so sanh double ==========
    // Muc dich: chung minh ham xu ly dung ca khi a hoac delta khong bang 0 tuyet doi,
    // ma chi la mot so rat nho gan 0 do sai so lam tron cua kieu double.

    [Fact]
    public void GiaiPTBac2_ARatGanKhong_VanDuocXemLaPhuongTrinhBac1()
    {
        // a = 1e-12 gan bang 0 hon nguong EPS (1e-9) -> phai xu ly nhu a = 0
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1e-12, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2, x1);
    }

    [Fact]
    public void GiaiPTBac2_DeltaRatGanKhongTuTrenXuong_VanLaNghiemKep()
    {
        // b*b - 4ac = 1e-10, nho hon EPS (1e-9) -> phai xem nhu delta = 0 (nghiem kep)
        double a = 1, b = -2, c = 1 - 2.5e-11; // delta = 4 - 4*(1-2.5e-11) = 1e-10
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(a, b, c, ref x1, ref x2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void GiaiPTBac2_DeltaAmRoRet_VanTraVeVoNghiem()
    {
        // delta = -3, lon hon han EPS ve do lon -> phai la vo nghiem (khong bi EPS lam sai lech)
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, 1, 1, ref x1, ref x2);
        Assert.Equal(0, result);
    }
}
