using System;
using System.Collections.Generic;

namespace OOPLib;

// ============================================================
// Bai 2.4: lop mang 2 chieu kich thuoc n x m
// ============================================================
public class Mang2Chieu
{
    private readonly int[,] mang;

    public int SoDong { get; }
    public int SoCot { get; }

    public Mang2Chieu(int n, int m)
    {
        SoDong = n;
        SoCot = m;
        mang = new int[n, m];
    }

    // Indexer truy cap phan tu tai (i, j)
    public int this[int i, int j]
    {
        get => mang[i, j];
        set => mang[i, j] = value;
    }

    public void Input()
    {
        for (int i = 0; i < SoDong; i++)
            for (int j = 0; j < SoCot; j++)
            {
                Console.Write($"Nhap phan tu ({i},{j}): ");
                mang[i, j] = int.Parse(Console.ReadLine());
            }
    }

    public void Output()
    {
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
                Console.Write(mang[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }
    }

    // Tim cac so nguyen to trong mang, tai su dung KiemTraSoNguyenTo
    // (dat trong Bai3 vi lien quan toi phan giai thuat dung chung,
    //  o day goi truc tiep ham noi bo de khong phu thuoc thu tu khai bao)
    public int[] TimSoNguyenTo()
    {
        List<int> ketQua = new List<int>();
        foreach (int x in mang)
            if (KiemTraSoNguyenTo(x))
                ketQua.Add(x);
        return ketQua.ToArray();
    }

    private static bool KiemTraSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; (long)i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}
