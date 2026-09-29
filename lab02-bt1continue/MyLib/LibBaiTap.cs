using System;

namespace MyLib;

public class LibBaiTap
{
    // So sanh so thuc bang == la khong an toan vi so thuc co sai so bieu dien
    // (vi du 0.1 + 0.2 != 0.3 khi tinh bang double). Nen thay vi kiem tra
    // "a == 0" tuyet doi, ta kiem tra "|a| < EPS" - xem nhu bang 0 neu du gan 0.
    private const double EPS = 1e-9;

    /// <summary>
    /// Giai phuong trinh bac 2: a*x^2 + b*x + c = 0
    /// </summary>
    /// <returns>-1: vo so nghiem, 0: vo nghiem, 1: mot nghiem, 2: hai nghiem phan biet</returns>
    public static int GiaiPTBac2(
        double a, double b, double c,
        ref double x1, ref double x2)
    {
        int sn;

        if (Math.Abs(a) < EPS)
        {
            // a xem nhu bang 0 -> phuong trinh suy bien ve bac 1 (hoac hang so): b*x + c = 0
            if (Math.Abs(b) < EPS)
            {
                // b cung bang 0 -> chi con lai c
                if (Math.Abs(c) < EPS) sn = -1; // 0 = 0 -> vo so nghiem
                else sn = 0;                    // c = 0 vo ly -> vo nghiem
            }
            else
            {
                sn = 1;
                x1 = -c / b;
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < -EPS)
            {
                sn = 0;
            }
            else if (Math.Abs(delta) < EPS)
            {
                sn = 1;
                x1 = -b / (2 * a);
            }
            else
            {
                sn = 2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                if (x1 > x2)
                {
                    double tmp = x1;
                    x1 = x2;
                    x2 = tmp;
                }
            }
        }

        return sn;
    }
}
