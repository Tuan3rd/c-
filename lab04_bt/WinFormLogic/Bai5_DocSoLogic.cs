namespace WinFormLogic;

// Bai 5 (BT tai lop): Doc so (1..999) thanh chu tieng Viet.
// Vi du trong de bai: 23 -> "Hai Mươi Ba".
public static class Bai5DocSoLogic
{
    private static readonly string[] ChuSo =
    {
        "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín"
    };

    public static bool LaSoHopLe(string? text, out int giaTri) =>
        int.TryParse(text, out giaTri) && giaTri >= 1 && giaTri <= 999;

    public static string DocSo(int so)
    {
        if (so < 1 || so > 999)
            throw new ArgumentOutOfRangeException(nameof(so), "Chi ho tro so tu 1 den 999");

        int tram = so / 100;
        int chuc = so % 100 / 10;
        int donVi = so % 10;

        var tuDoc = new List<string>();

        if (tram > 0)
        {
            tuDoc.Add(ChuSo[tram]);
            tuDoc.Add("Trăm");
        }

        if (chuc == 0)
        {
            // Hang chuc bang 0 nhung van co hang don vi phia sau hang tram -> doc "Lẻ".
            if (tram > 0 && donVi > 0)
                tuDoc.Add("Lẻ");

            if (donVi > 0)
                tuDoc.Add(ChuSo[donVi]);
        }
        else if (chuc == 1)
        {
            tuDoc.Add("Mười");

            if (donVi == 5)
                tuDoc.Add("Lăm");
            else if (donVi > 0)
                tuDoc.Add(ChuSo[donVi]);
        }
        else
        {
            tuDoc.Add(ChuSo[chuc]);
            tuDoc.Add("Mươi");

            if (donVi == 1)
                tuDoc.Add("Mốt");
            else if (donVi == 5)
                tuDoc.Add("Lăm");
            else if (donVi > 0)
                tuDoc.Add(ChuSo[donVi]);
        }

        return string.Join(" ", tuDoc);
    }
}
