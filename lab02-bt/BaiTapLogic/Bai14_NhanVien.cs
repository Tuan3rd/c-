using System;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 14: lop Nhan Vien - tinh luong, moi ngay vang bi tru 100.000 VND
    // ============================================================
    public class NhanVien
    {
        public const double TIEN_TRU_MOI_NGAY_VANG = 100_000;

        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen ?? throw new ArgumentNullException(nameof(hoTen));
            MucLuong = mucLuong;
            SoNgayVang = soNgayVang;
        }

        // Luong thuc nhan = muc luong - (so ngay vang * 100.000).
        // Neu vang qua nhieu khien ket qua am thi tra ve 0, vi thuc te
        // khong the co chuyen nhan vien phai "no nguoc" lai cong ty.
        public double TinhLuong()
        {
            double luong = MucLuong - SoNgayVang * TIEN_TRU_MOI_NGAY_VANG;
            return luong < 0 ? 0 : luong;
        }
    }
}
