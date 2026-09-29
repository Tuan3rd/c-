using System;
using System.Collections.Generic;

namespace OOPLib;

// ============================================================
// Bai 2.3: lop Day So chua n so nguyen (mang 1 chieu)
// ============================================================
public class DaySo
{
    private int[] mang;

    public int SoLuong => mang.Length;

    // Constructor tao day rong voi n phan tu (mac dinh = 0)
    public DaySo(int n)
    {
        mang = new int[n];
    }

    // Constructor tao day tu mang co san
    public DaySo(int[] nguon)
    {
        mang = (int[])nguon.Clone();
    }

    // Indexer truy cap phan tu thu i
    public int this[int i]
    {
        get => mang[i];
        set => mang[i] = value;
    }

    public void Input()
    {
        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Output()
    {
        Console.WriteLine(string.Join(" ", mang));
    }

    // Tra ve mang cac so chan trong day
    public int[] TimSoChan()
    {
        List<int> ketQua = new List<int>();
        foreach (int x in mang)
            if (x % 2 == 0)
                ketQua.Add(x);
        return ketQua.ToArray();
    }
}
