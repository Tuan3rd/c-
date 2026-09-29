namespace BaiTapLogic
{
    // ============================================================
    // Bai 8: tham chieu ref - hoan vi 2 so thuc
    // Bai 9: tham chieu out - tim gia tri lon nhat va nho nhat cua 3 so thuc
    // ============================================================
    public static class Bai8_9_SoThucService
    {
        // ================== BAI 8 ==================
        // Dung ref vi ham can SUA TRUC TIEP gia tri cua bien a, b ben ngoai,
        // khac voi tham tri (truyen ban sao, sua trong ham khong anh huong ben ngoai)
        public static void HoanVi(ref double a, ref double b)
        {
            double tam = a;
            a = b;
            b = tam;
        }

        // ================== BAI 9 ==================
        // Dung out vi ham can TRA VE 2 gia tri cung luc (min va max),
        // trong khi return chi tra ve duoc 1 gia tri
        public static void TimMinMax(double a, double b, double c, out double min, out double max)
        {
            min = a;
            max = a;

            if (b < min) min = b;
            if (c < min) min = c;

            if (b > max) max = b;
            if (c > max) max = c;
        }
    }
}
