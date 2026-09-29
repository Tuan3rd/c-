using System;

namespace OOPLib;

// ============================================================
// Bai 3.6: ke thua + da hinh - tinh diem 2 loai thi sinh khac nhau
// ============================================================
public abstract class ThiSinh
{
    public string Sbd { get; set; }
    public string HoTen { get; set; }
    public double Bai1 { get; set; }
    public double Bai2 { get; set; }
    public double Bai3 { get; set; }

    protected ThiSinh(string sbd, string hoTen, double bai1, double bai2, double bai3)
    {
        Sbd = sbd;
        HoTen = hoTen;
        Bai1 = bai1;
        Bai2 = bai2;
        Bai3 = bai3;
    }

    protected double TongBaLapTrinh => Bai1 + Bai2 + Bai3;

    // Moi loai thi sinh tinh tong diem cuoi cung theo cach khac nhau
    public abstract double TinhTongDiem();
}

// Thi sinh Chuyen: 3 bai lap trinh + diem thuong tu bai tieng Anh
public class ThiSinhChuyen : ThiSinh
{
    public double TiengAnh { get; set; }

    public ThiSinhChuyen(string sbd, string hoTen, double bai1, double bai2, double bai3, double tiengAnh)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        TiengAnh = tiengAnh;
    }

    public override double TinhTongDiem()
    {
        double diemThuong = 0;
        if (TiengAnh >= 9 && TiengAnh <= 10) diemThuong = 2;
        else if (TiengAnh >= 7 && TiengAnh <= 8) diemThuong = 1;

        return TongBaLapTrinh + diemThuong;
    }
}

// Thi sinh Sieu cup: 3 bai lap trinh + bai CSDL, khong co diem thuong rieng
public class ThiSinhSieuCup : ThiSinh
{
    public double Csdl { get; set; }

    public ThiSinhSieuCup(string sbd, string hoTen, double bai1, double bai2, double bai3, double csdl)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        Csdl = csdl;
    }

    public override double TinhTongDiem()
    {
        return TongBaLapTrinh + Csdl;
    }
}
