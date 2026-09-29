using System;

namespace OOPLib;

// ============================================================
// Bai 3.1: dung Array.Sort() tinh de sap xep mang doi tuong.
// Khong can code them o day - PhanSo (Bai 1.4) da implement IComparable<PhanSo>,
// nen Array.Sort(mangPhanSo) trong OOPConsole se hoat dong duoc ngay.
// (Xem ham DemoBai3_1 trong OOPConsole/Program.cs)
// ============================================================

// ============================================================
// Bai 3.2: sap xep mang tong quat bang INTERFACE (mo phong Array.Sort)
// Dinh nghia interface rieng ISoSanhDuoc<T>, tuong tu IComparable<T> cua .NET,
// de chung minh hieu duoc co che polymorphism dung sau Array.Sort tich hop san.
// ============================================================
public interface ISoSanhDuoc<T>
{
    // Am neu "this" nho hon other, 0 neu bang, duong neu lon hon
    // (dung quy uoc giong IComparable<T> chuan cua .NET)
    int SoSanh(T other);
}

public static class SapXepTongQuat
{
    // Sap xep bang thuat toan selection sort, dua vao SoSanh() cua interface
    // ISoSanhDuoc<T> - hoat dong duoc voi BAT KY kieu T nao co implement interface nay,
    // khong can biet truoc T la kieu gi (day la diem cot loi cua lap trinh tong quat).
    public static void SapXep<T>(T[] mang) where T : ISoSanhDuoc<T>
    {
        for (int i = 0; i < mang.Length - 1; i++)
        {
            int viTriNhoNhat = i;
            for (int j = i + 1; j < mang.Length; j++)
            {
                if (mang[j].SoSanh(mang[viTriNhoNhat]) < 0)
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
