namespace WinFormLogic;

// Bai 3 (BT tai lop): Uoc so chung lon nhat (UCLN) - Boi so chung nho nhat (BCNN) cua 2 so a, b.
public static class Bai3UocBoiLogic
{
    public static bool LaSoNguyenDuongHopLe(string? text, out int giaTri) =>
        int.TryParse(text, out giaTri) && giaTri > 0;

    // Giai thuat Euclid.
    public static int UCLN(int a, int b)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), "a va b phai la so nguyen duong");

        while (b != 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }

    public static int BCNN(int a, int b)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), "a va b phai la so nguyen duong");

        return a / UCLN(a, b) * b;
    }
}
