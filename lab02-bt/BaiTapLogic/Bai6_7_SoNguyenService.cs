namespace BaiTapLogic
{
    // ============================================================
    // Bai 6: phuong thuc tra ve gia tri (return) - tim so lon nhat trong 3 so nguyen
    // Bai 7: phuong thuc kieu bool - kiem tra so nguyen to
    // Ca hai deu truyen tham so theo kieu tham TRI (gia tri), khong sua doi bien goc.
    // ============================================================
    public static class Bai6_7_SoNguyenService
    {
        // ================== BAI 6 ==================
        public static int TimGiaTriLonNhat(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        // ================== BAI 7 ==================
        // So nguyen to la so tu nhien > 1, chi chia het cho 1 va chinh no
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            // Chi can kiem tra uoc so den can bac 2 cua n la du,
            // vi neu n co uoc lon hon can(n) thi chac chan cung co uoc nho hon can(n)
            for (int i = 2; (long)i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
