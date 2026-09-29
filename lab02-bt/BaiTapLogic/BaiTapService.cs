using System;

namespace BaiTapLogic
{
    // ============================================================
    // Noi chua toan bo phan "logic thuan" (khong dung Console.ReadLine/WriteLine)
    // cua Bai 1 -> Bai 5, de co the unit test duoc doc lap voi phan nhap xuat.
    // Ca hai project console (Bai1_HoTen va Bai2345_NhapXuat) deu goi vao day,
    // tranh viet trung logic hai noi.
    // ============================================================
    public static class BaiTapService
    {
        // ================== BAI 1 ==================
        // Tao cau xuat lai ho ten da nhap
        public static string TaoLoiChaoHoTen(string hoTen)
        {
            if (hoTen is null)
                throw new ArgumentNullException(nameof(hoTen));

            return "Ho ten ban vua nhap la: " + hoTen;
        }

        // ================== BAI 2 ==================
        // Tao cau chao theo dung dinh dang de bai yeu cau
        public static string ChaoBan(string hoTen)
        {
            if (hoTen is null)
                throw new ArgumentNullException(nameof(hoTen));

            return "Chao ban " + hoTen + "!";
        }

        // ================== BAI 3 ==================
        // Tinh x^y voi x, y la so nguyen, tra ve long de tranh tran so khi y lon
        public static long TinhLuyThua(int x, int y)
        {
            return (long)Math.Pow(x, y);
        }

        // ================== BAI 4 ==================
        // Giong Bai 3 nhung nhan chuoi nhap vao truoc, tu kiem tra co phai so nguyen khong.
        // Tra ve false + thongBaoLoi neu inputX/inputY khong phai so nguyen hop le.
        public static bool ThuTinhLuyThua(string? inputX, string? inputY, out long ketQua, out string? thongBaoLoi)
        {
            ketQua = 0;
            thongBaoLoi = null;

            bool xHopLe = int.TryParse(inputX, out int x);
            bool yHopLe = int.TryParse(inputY, out int y);

            if (!xHopLe || !yHopLe)
            {
                thongBaoLoi = "Loi: x hoac y ban nhap khong phai la so nguyen. Vui long thu lai!";
                return false;
            }

            ketQua = TinhLuyThua(x, y);
            return true;
        }

        // ================== BAI 5 ==================
        // Tinh x^y voi x, y la so thuc
        public static double TinhLuyThuaThuc(double x, double y)
        {
            return Math.Pow(x, y);
        }

        // Tinh can bac 2 cua x va y. Tra ve false + thongBaoLoi neu x hoac y la so am
        // (vi can bac 2 cua so am khong ton tai trong tap so thuc).
        public static bool ThuTinhCanBac2(double x, double y, out double canBacX, out double canBacY, out string? thongBaoLoi)
        {
            canBacX = 0;
            canBacY = 0;
            thongBaoLoi = null;

            if (x < 0 || y < 0)
            {
                thongBaoLoi = "Khong tinh duoc can bac 2 cua so am.";
                return false;
            }

            canBacX = Math.Sqrt(x);
            canBacY = Math.Sqrt(y);
            return true;
        }
    }
}
