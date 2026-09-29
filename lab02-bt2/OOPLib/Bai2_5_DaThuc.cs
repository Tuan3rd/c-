using System;

namespace OOPLib;

// ============================================================
// Bai "2.3" (Da thuc) - de bai danh trung so thu tu voi Bai 2.3 mang 1 chieu,
// co le la loi danh so trong tai lieu goc. O day dat ten file/lop theo dung
// noi dung (Da thuc) de khong bi nham voi DaySo.
//
// Da thuc P(x) = a0 + a1.x + a2.x^2 + ... + an.x^n, luu duoi dang mang he so
// he_so[i] la he so cua x^i (i chay tu 0 den n)
// ============================================================
public class DaThuc
{
    private readonly double[] heSo;

    public int Bac => heSo.Length - 1;

    // Tao da thuc bac n (co n+1 he so, mac dinh = 0)
    public DaThuc(int bac)
    {
        heSo = new double[bac + 1];
    }

    public DaThuc(double[] heSoNguon)
    {
        heSo = (double[])heSoNguon.Clone();
    }

    // Indexer truy cap he so cua x^i (chinh la "don thuc thu i" theo cach hieu he so)
    public double this[int i]
    {
        get => heSo[i];
        set => heSo[i] = value;
    }

    public void Input()
    {
        for (int i = 0; i <= Bac; i++)
        {
            Console.Write($"Nhap he so a{i} (cua x^{i}): ");
            heSo[i] = double.Parse(Console.ReadLine());
        }
    }

    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        var phanTu = new System.Collections.Generic.List<string>();
        for (int i = 0; i <= Bac; i++)
            phanTu.Add($"{heSo[i]}x^{i}");
        return string.Join(" + ", phanTu);
    }

    // Tinh gia tri da thuc tai x, dung so Horner de tinh nhanh va chinh xac hon
    // so voi tinh tung Math.Pow(x, i) roi cong don
    public double TinhGiaTri(double x)
    {
        double ketQua = 0;
        for (int i = Bac; i >= 0; i--)
            ketQua = ketQua * x + heSo[i];
        return ketQua;
    }
}
