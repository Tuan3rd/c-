using System;
using System.Collections.Generic;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 15: cac phuong thuc thao tac tren mang so nguyen
    // (Nhap mang / In mang la phan I/O nen de trong chuong trinh console,
    //  o day chi giu lai phan logic thuan de test duoc: tim max/min, loc so nguyen to)
    // ============================================================
    public static class Bai15_MangSoHocService
    {
        public static int TimMax(int[] mang)
        {
            KiemTraMangKhongRong(mang);

            int max = mang[0];
            foreach (int x in mang)
                if (x > max) max = x;
            return max;
        }

        public static int TimMin(int[] mang)
        {
            KiemTraMangKhongRong(mang);

            int min = mang[0];
            foreach (int x in mang)
                if (x < min) min = x;
            return min;
        }

        // Tra ve mang moi chi chua cac phan tu la so nguyen to,
        // tai su dung lai KiemTraSoNguyenTo cua Bai 7 thay vi viet lai
        public static int[] LayMangSoNguyenTo(int[] mang)
        {
            if (mang is null)
                throw new ArgumentNullException(nameof(mang));

            List<int> ketQua = new List<int>();
            foreach (int x in mang)
            {
                if (Bai6_7_SoNguyenService.KiemTraSoNguyenTo(x))
                    ketQua.Add(x);
            }
            return ketQua.ToArray();
        }

        private static void KiemTraMangKhongRong(int[] mang)
        {
            if (mang is null)
                throw new ArgumentNullException(nameof(mang));
            if (mang.Length == 0)
                throw new ArgumentException("Mang khong duoc rong.", nameof(mang));
        }
    }
}
