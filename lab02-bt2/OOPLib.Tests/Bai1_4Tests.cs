using System;
using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai1_4Tests
{
    [Fact]
    public void Constructor_TuDongRutGon()
    {
        var p = new PhanSo(2, 4);

        Assert.Equal(1, p.TuSo);
        Assert.Equal(2, p.MauSo);
    }

    [Fact]
    public void Constructor_MauSoAm_ChuyenDauVeTuSo()
    {
        var p = new PhanSo(1, -2);

        Assert.Equal(-1, p.TuSo);
        Assert.Equal(2, p.MauSo);
    }

    [Fact]
    public void Constructor_MauSoBangKhong_NemNgoaiLe()
    {
        Assert.Throws<ArgumentException>(() => new PhanSo(1, 0));
    }

    [Fact]
    public void ConstructorMacNhien_TraVeKhongPhanNhat()
    {
        var p = new PhanSo();

        Assert.Equal(0, p.TuSo);
        Assert.Equal(1, p.MauSo);
    }

    [Fact]
    public void CopyConstructor_TaoBanSaoDungGiaTri()
    {
        var goc = new PhanSo(3, 4);
        var sao = new PhanSo(goc);

        Assert.Equal(goc.TuSo, sao.TuSo);
        Assert.Equal(goc.MauSo, sao.MauSo);
    }

    [Fact]
    public void ToString_TraVeDungDinhDang()
    {
        var p = new PhanSo(3, 4);

        Assert.Equal("3/4", p.ToString());
    }

    [Theory]
    [InlineData(1, 2, 1, 3, 5, 6)]   // 1/2 + 1/3 = 5/6
    [InlineData(1, 2, 1, 2, 1, 1)]   // 1/2 + 1/2 = 1
    public void ToanTu_Cong_TraVeDungKetQua(int tuA, int mauA, int tuB, int mauB, int tuMongDoi, int mauMongDoi)
    {
        var a = new PhanSo(tuA, mauA);
        var b = new PhanSo(tuB, mauB);

        var ketQua = a + b;

        Assert.Equal(tuMongDoi, ketQua.TuSo);
        Assert.Equal(mauMongDoi, ketQua.MauSo);
    }

    [Fact]
    public void ToanTu_Tru_TraVeDungKetQua()
    {
        var a = new PhanSo(1, 2);
        var b = new PhanSo(1, 3);

        var ketQua = a - b;

        Assert.Equal(1, ketQua.TuSo);
        Assert.Equal(6, ketQua.MauSo);
    }

    [Fact]
    public void ToanTu_Nhan_TraVeDungKetQua()
    {
        var a = new PhanSo(2, 3);
        var b = new PhanSo(3, 4);

        var ketQua = a * b;

        Assert.Equal(1, ketQua.TuSo);
        Assert.Equal(2, ketQua.MauSo);
    }

    [Fact]
    public void ToanTu_Chia_TraVeDungKetQua()
    {
        var a = new PhanSo(1, 2);
        var b = new PhanSo(1, 3);

        var ketQua = a / b;

        Assert.Equal(3, ketQua.TuSo);
        Assert.Equal(2, ketQua.MauSo);
    }

    [Fact]
    public void ToanTu_ChiaChoPhanSoBangKhong_NemNgoaiLe()
    {
        var a = new PhanSo(1, 2);
        var b = new PhanSo(0, 5);

        Assert.Throws<DivideByZeroException>(() => a / b);
    }

    [Fact]
    public void ToanTu_MotNgoi_TraVeDungKetQua()
    {
        var a = new PhanSo(2, 3);

        Assert.Equal("2/3", (+a).ToString());
        Assert.Equal("-2/3", (-a).ToString());
    }

    [Fact]
    public void ToanTu_SoSanh_TraVeDungKetQua()
    {
        var a = new PhanSo(1, 2);
        var b = new PhanSo(1, 3);

        Assert.True(a > b);
        Assert.False(a < b);
        Assert.True(a >= b);
        Assert.False(a <= b);
    }

    [Fact]
    public void ToanTu_BangNhauVaKhacNhau_HoatDongDung()
    {
        var a = new PhanSo(2, 4); // rut gon thanh 1/2
        var b = new PhanSo(1, 2);
        var c = new PhanSo(1, 3);

        Assert.True(a == b);
        Assert.False(a == c);
        Assert.True(a != c);
        Assert.False(a != b);
    }

    [Fact]
    public void Equals_HaiPhanSoBangNhauVeGiaTri_TraVeTrue()
    {
        var a = new PhanSo(2, 4);
        var b = new PhanSo(1, 2);

        Assert.True(a.Equals(b));
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void CompareTo_DungDeArraySort()
    {
        PhanSo[] mang = { new PhanSo(3, 4), new PhanSo(1, 2), new PhanSo(-1, 3) };

        Array.Sort(mang);

        Assert.Equal("-1/3", mang[0].ToString());
        Assert.Equal("1/2", mang[1].ToString());
        Assert.Equal("3/4", mang[2].ToString());
    }
}
