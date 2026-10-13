namespace WinForm05Logic;

// Bai 1 (BT tai lop): nhap so vao ComboBox, liet ke va thong ke uoc so cua so duoc chon.
public static class Bai1UocSoLogic
{
    public static bool LaSoHopLe(string? text, out int giaTri) =>
        int.TryParse(text, out giaTri) && giaTri > 0;

    public static List<int> DanhSachUocSo(int n)
    {
        if (n <= 0)
            throw new ArgumentOutOfRangeException(nameof(n), "n phải là số nguyên dương");

        var ds = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                ds.Add(i);
        }

        return ds;
    }

    public static int TongUocSo(IEnumerable<int> uocSo) => uocSo.Sum();

    public static int SoLuongUocSoChan(IEnumerable<int> uocSo) => uocSo.Count(x => x % 2 == 0);

    public static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; (long)i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public static int SoLuongUocSoNguyenTo(IEnumerable<int> uocSo) => uocSo.Count(LaSoNguyenTo);
}
