using System;

namespace OOPLib;

// ============================================================
// Bai "2.4" (Day phan so) - cung bi trung so thu tu trong de bai goc
// voi Bai 2.4 mang 2 chieu. Lop nay chua n phan so va tinh tong.
// ============================================================
public class DayPhanSo
{
    private readonly PhanSo[] mang;

    public int SoLuong => mang.Length;

    public DayPhanSo(int n)
    {
        mang = new PhanSo[n];
        for (int i = 0; i < n; i++)
            mang[i] = new PhanSo();
    }

    public PhanSo this[int i]
    {
        get => mang[i];
        set => mang[i] = value;
    }

    // Cong don tat ca phan so trong day, tai su dung toan tu + da overload o Bai 1.4
    public PhanSo TinhTong()
    {
        PhanSo tong = new PhanSo(0, 1);
        foreach (PhanSo p in mang)
            tong = tong + p;
        return tong;
    }
}
