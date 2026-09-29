using System;

namespace OOPLib;

// ============================================================
// Bai 1.5: lop Don Thuc P(x) = a.x^n (a thuc, n nguyen khong am)
// ============================================================
public class DonThuc
{
    private double heSo; // a
    private int soMu;    // n

    public double HeSo { get => heSo; set => heSo = value; }

    public int SoMu
    {
        get => soMu;
        set
        {
            if (value < 0)
                throw new ArgumentException("So mu phai la so nguyen khong am.");
            soMu = value;
        }
    }

    public DonThuc(double heSo, int soMu)
    {
        this.heSo = heSo;
        SoMu = soMu; // di qua property de kiem tra soMu >= 0
    }

    // (a) Tinh gia tri P(x) = a * x^n
    public double TinhGiaTri(double x)
    {
        return heSo * Math.Pow(x, soMu);
    }

    // (b) Dao ham: Q(x) = P'(x) = a.n.x^(n-1)
    // Truong hop n = 0 (P(x) = hang so a) thi dao ham bang 0, tra ve don thuc 0.x^0
    public DonThuc DaoHam()
    {
        if (soMu == 0)
            return new DonThuc(0, 0);

        return new DonThuc(heSo * soMu, soMu - 1);
    }

    public override string ToString()
    {
        return $"{heSo}x^{soMu}";
    }
}
