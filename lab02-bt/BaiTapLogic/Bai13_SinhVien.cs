using System;

namespace BaiTapLogic
{
    // ============================================================
    // Bai 13: lop Sinh Vien - luu thong tin 1 sinh vien va xuat ra dang chuoi
    // ============================================================
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int NamThu { get; set; }

        public SinhVien(string maSV, string hoTen, string diaChi, int namThu)
        {
            MaSV = maSV ?? throw new ArgumentNullException(nameof(maSV));
            HoTen = hoTen ?? throw new ArgumentNullException(nameof(hoTen));
            DiaChi = diaChi ?? throw new ArgumentNullException(nameof(diaChi));
            NamThu = namThu;
        }

        // Xuat thong tin sinh vien theo mot dinh dang co dinh, de vua in ra man hinh
        // vua co the unit test duoc (so sanh chuoi tra ve)
        public string XuatThongTin()
        {
            return $"Ma SV: {MaSV} - Ho ten: {HoTen} - Dia chi: {DiaChi} - Nam thu: {NamThu}";
        }
    }
}
