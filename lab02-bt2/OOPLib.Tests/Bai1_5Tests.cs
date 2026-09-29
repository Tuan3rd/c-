using System;
using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai1_5Tests
{
    [Fact]
    public void TinhGiaTri_2x3_TaiX2_TraVe16()
    {
        var p = new DonThuc(2, 3); // 2x^3

        Assert.Equal(16, p.TinhGiaTri(2)); // 2 * 2^3 = 16
    }

    [Fact]
    public void TinhGiaTri_SoMuBangKhong_TraVeChinhHeSo()
    {
        var p = new DonThuc(5, 0); // 5x^0 = 5 (hang so)

        Assert.Equal(5, p.TinhGiaTri(100));
    }

    [Fact]
    public void DaoHam_2x3_TraVe6x2()
    {
        var p = new DonThuc(2, 3); // 2x^3

        DonThuc daoHam = p.DaoHam(); // 3 * 2 * x^2 = 6x^2

        Assert.Equal(6, daoHam.HeSo);
        Assert.Equal(2, daoHam.SoMu);
    }

    [Fact]
    public void DaoHam_HangSo_TraVeKhong()
    {
        var p = new DonThuc(7, 0); // hang so 7

        DonThuc daoHam = p.DaoHam();

        Assert.Equal(0, daoHam.HeSo);
        Assert.Equal(0, daoHam.SoMu);
    }

    [Fact]
    public void SoMu_GanGiaTriAm_NemNgoaiLe()
    {
        var p = new DonThuc(1, 2);

        Assert.Throws<ArgumentException>(() => p.SoMu = -1);
    }
}
