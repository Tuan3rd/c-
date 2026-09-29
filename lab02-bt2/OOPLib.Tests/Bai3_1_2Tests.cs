using System;
using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai3_1_2Tests
{
    // ---------- Bai 3.1: Array.Sort() tinh (dung IComparable) ----------

    [Fact]
    public void ArraySort_MangPhanSo_SapXepTangDan()
    {
        PhanSo[] mang = { new PhanSo(3, 4), new PhanSo(1, 2), new PhanSo(-1, 3) };

        Array.Sort(mang);

        Assert.Equal("-1/3", mang[0].ToString());
        Assert.Equal("1/2", mang[1].ToString());
        Assert.Equal("3/4", mang[2].ToString());
    }

    // ---------- Bai 3.2: sap xep tong quat bang interface ----------

    [Fact]
    public void SapXepTongQuat_MangPhanSo_SapXepTangDan()
    {
        PhanSo[] mang = { new PhanSo(3, 4), new PhanSo(1, 2), new PhanSo(-1, 3) };

        SapXepTongQuat.SapXep(mang);

        Assert.Equal("-1/3", mang[0].ToString());
        Assert.Equal("1/2", mang[1].ToString());
        Assert.Equal("3/4", mang[2].ToString());
    }

    [Fact]
    public void SapXepTongQuat_MangDaSapXep_KhongThayDoi()
    {
        PhanSo[] mang = { new PhanSo(1, 4), new PhanSo(1, 2) };

        SapXepTongQuat.SapXep(mang);

        Assert.Equal("1/4", mang[0].ToString());
        Assert.Equal("1/2", mang[1].ToString());
    }

    [Fact]
    public void SapXepTongQuat_ArraySortVaTuVietChoCungKetQua()
    {
        // Chung minh 2 cach sap xep (Bai 3.1 va Bai 3.2) cho ra cung mot ket qua
        PhanSo[] mangA = { new PhanSo(5, 6), new PhanSo(-1, 3), new PhanSo(1, 2) };
        PhanSo[] mangB = { new PhanSo(5, 6), new PhanSo(-1, 3), new PhanSo(1, 2) };

        Array.Sort(mangA);
        SapXepTongQuat.SapXep(mangB);

        for (int i = 0; i < mangA.Length; i++)
            Assert.Equal(mangA[i].ToString(), mangB[i].ToString());
    }
}
