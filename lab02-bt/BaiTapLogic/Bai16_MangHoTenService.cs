using System;
using System.Globalization;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 16: sap xep mang ho ten theo thu tu tang dan
    // ============================================================
    public static class Bai16_MangHoTenService
    {
        // Dung StringComparer voi CultureInfo "vi-VN" de sap xep dung theo
        // bang chu cai tieng Viet (co dau), thay vi so sanh ky tu Unicode tho
        // (neu so sanh tho thi cac chu co dau se bi xep sai vi tri so voi chu khong dau).
        // Tra ve mang MOI, khong sua doi mang truyen vao.
        public static string[] SapXepTangDan(string[] hoTenMang)
        {
            if (hoTenMang is null)
                throw new ArgumentNullException(nameof(hoTenMang));

            string[] ketQua = (string[])hoTenMang.Clone();
            Array.Sort(ketQua, StringComparer.Create(new CultureInfo("vi-VN"), ignoreCase: false));
            return ketQua;
        }
    }
}
