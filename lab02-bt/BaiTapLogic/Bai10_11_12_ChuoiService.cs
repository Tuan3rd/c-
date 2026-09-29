using System;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 10: kiem tra chuoi doi xung (palindrome)
    // Bai 11: dao nguoc chuoi
    // Bai 12: chuyen hoa/thuong, dem so tu trong chuoi
    // ============================================================
    public static class Bai10_11_12_ChuoiService
    {
        // ================== BAI 10 ==================
        // So sanh chuoi goc voi chuoi da dao nguoc; phan biet hoa/thuong va khoang trang
        // (giu don gian dung theo yeu cau de bai, khong xu ly them dau/khoang trang)
        public static bool KiemTraDoiXung(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s == DaoNguoc(s);
        }

        // ================== BAI 11 ==================
        public static string DaoNguoc(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            char[] mang = s.ToCharArray();
            Array.Reverse(mang);
            return new string(mang);
        }

        // ================== BAI 12 ==================
        public static string ChuyenHoa(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.ToUpper();
        }

        public static string ChuyenThuong(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.ToLower();
        }

        // Dem so tu, dua vao khoang trang de tach - dung RemoveEmptyEntries
        // de khong bi dem sai khi chuoi co nhieu khoang trang lien tiep
        public static int DemSoTu(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            string[] tuMang = s.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return tuMang.Length;
        }
    }
}
