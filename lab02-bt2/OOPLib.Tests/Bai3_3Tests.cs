using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai3_3Tests
{
    [Fact]
    public void SapXepBangDelegate_SoSanhTangDan_SapXepDung()
    {
        int[] mang = { 5, 2, 9, 1, 7 };

        SapXepBangDelegate.SapXep(mang, (a, b) => a.CompareTo(b));

        Assert.Equal(new[] { 1, 2, 5, 7, 9 }, mang);
    }

    [Fact]
    public void SapXepBangDelegate_SoSanhGiamDan_SapXepDung()
    {
        int[] mang = { 5, 2, 9, 1, 7 };

        SapXepBangDelegate.SapXep(mang, (a, b) => b.CompareTo(a));

        Assert.Equal(new[] { 9, 7, 5, 2, 1 }, mang);
    }

    [Fact]
    public void SapXepBangDelegate_MangChuoiTheoDoDai_SapXepDung()
    {
        // Chung minh delegate dung duoc voi bat ky kieu T nao,
        // ke ca string (khong lien quan gi toi PhanSo/interface o Bai 3.2)
        string[] mang = { "abc", "a", "ab" };

        SapXepBangDelegate.SapXep(mang, (a, b) => a.Length.CompareTo(b.Length));

        Assert.Equal(new[] { "a", "ab", "abc" }, mang);
    }
}
