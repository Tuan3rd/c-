namespace WinFormContinueLogic.Tests;

public class MauBai2FormatTests
{
    [Fact]
    public void XacDinhKieuChu_ChiRegular_TraVeRegular()
    {
        Assert.Equal(KieuChuNhan.Regular, MauBai2FormatLogic.XacDinhKieuChu(true, false, false, false));
    }

    [Fact]
    public void XacDinhKieuChu_ChiBold_TraVeBold()
    {
        Assert.Equal(KieuChuNhan.Bold, MauBai2FormatLogic.XacDinhKieuChu(false, true, false, false));
    }

    [Fact]
    public void XacDinhKieuChu_ChiItalic_TraVeItalic()
    {
        Assert.Equal(KieuChuNhan.Italic, MauBai2FormatLogic.XacDinhKieuChu(false, false, true, false));
    }

    [Fact]
    public void XacDinhKieuChu_ChiBoldItalic_TraVeBoldItalic()
    {
        Assert.Equal(KieuChuNhan.BoldItalic, MauBai2FormatLogic.XacDinhKieuChu(false, false, false, true));
    }

    [Fact]
    public void XacDinhKieuChu_KhongCheckboxNaoDuocChon_MacDinhRegular()
    {
        Assert.Equal(KieuChuNhan.Regular, MauBai2FormatLogic.XacDinhKieuChu(false, false, false, false));
    }

    [Fact]
    public void XacDinhKieuChu_NhieuCheckboxCungDuocChon_UuTienBoldItalic()
    {
        Assert.Equal(KieuChuNhan.BoldItalic, MauBai2FormatLogic.XacDinhKieuChu(true, true, true, true));
    }

    [Theory]
    [InlineData(KieuChuNhan.Regular, false)]
    [InlineData(KieuChuNhan.Bold, true)]
    [InlineData(KieuChuNhan.Italic, false)]
    [InlineData(KieuChuNhan.BoldItalic, true)]
    public void LaDam_CacKieuChu_TraVeDungSai(KieuChuNhan kieuChu, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, MauBai2FormatLogic.LaDam(kieuChu));
    }

    [Theory]
    [InlineData(KieuChuNhan.Regular, false)]
    [InlineData(KieuChuNhan.Bold, false)]
    [InlineData(KieuChuNhan.Italic, true)]
    [InlineData(KieuChuNhan.BoldItalic, true)]
    public void LaNghieng_CacKieuChu_TraVeDungSai(KieuChuNhan kieuChu, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, MauBai2FormatLogic.LaNghieng(kieuChu));
    }
}
