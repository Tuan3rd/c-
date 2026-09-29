using System;

namespace OOPLib;

// ============================================================
// Bai 3.3: sap xep mang tong quat bang DELEGATE
// Khac voi Bai 3.2 (T phai implement san mot interface co dinh),
// o day cach so sanh duoc TRUYEN VAO nhu mot tham so (delegate) luc goi ham,
// nen dung duoc voi BAT KY kieu T nao, ke ca kieu khong the sua doi de them interface.
// ============================================================
public static class SapXepBangDelegate
{
    // SoSanh<T> la delegate co san cua .NET (using System), tuong duong:
    // public delegate int SoSanh<T>(T a, T b);
    public static void SapXep<T>(T[] mang, Comparison<T> soSanh)
    {
        for (int i = 0; i < mang.Length - 1; i++)
        {
            int viTriNhoNhat = i;
            for (int j = i + 1; j < mang.Length; j++)
            {
                if (soSanh(mang[j], mang[viTriNhoNhat]) < 0)
                    viTriNhoNhat = j;
            }

            if (viTriNhoNhat != i)
            {
                T tmp = mang[i];
                mang[i] = mang[viTriNhoNhat];
                mang[viTriNhoNhat] = tmp;
            }
        }
    }
}
