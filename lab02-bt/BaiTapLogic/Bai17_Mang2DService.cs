using System;
using System.Collections.Generic;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 17: mang 2 chieu ngau nhien trong [10, 100], tach so chan/le
    // ============================================================
    public static class Bai17_Mang2DService
    {
        // Nhan Random tu ben ngoai truyen vao (thay vi tu tao "new Random()" ben trong)
        // de unit test co the dung mot Random co seed co dinh, cho ket qua lap lai duoc.
        public static int[,] SinhNgauNhien(int n, int m, int min, int max, Random rng)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (m <= 0) throw new ArgumentOutOfRangeException(nameof(m));
            if (min > max) throw new ArgumentException("min khong duoc lon hon max.");
            if (rng is null) throw new ArgumentNullException(nameof(rng));

            int[,] mang = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mang[i, j] = rng.Next(min, max + 1); // Next can (max+1) vi can tren khong tinh

            return mang;
        }

        public static (int[] Chan, int[] Le) TachChanLe(int[,] mang)
        {
            if (mang is null)
                throw new ArgumentNullException(nameof(mang));

            List<int> chan = new List<int>();
            List<int> le = new List<int>();

            foreach (int x in mang)
            {
                if (x % 2 == 0) chan.Add(x);
                else le.Add(x);
            }

            return (chan.ToArray(), le.ToArray());
        }
    }
}
