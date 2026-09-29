using System;

namespace OOPLib;

// ============================================================
// Bai 3.5: ke thua + da hinh - tinh luong 2 loai nhan vien khac nhau
// ============================================================

// Lop truu tuong (abstract) - khong the new truc tiep NhanVienCongTy,
// bat buoc phai la mot trong 2 lop con ben duoi. TinhLuong() la abstract
// vi moi loai nhan vien tinh luong theo cong thuc hoan toan khac nhau.
public abstract class NhanVienCongTy
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }

    protected NhanVienCongTy(string maNV, string hoTen)
    {
        MaNV = maNV;
        HoTen = hoTen;
    }

    public abstract double TinhLuong();
}

public class NhanVienKinhDoanh : NhanVienCongTy
{
    public double LuongCoBan { get; set; }
    public int SoHopDong { get; set; }

    private const double THUONG_MOI_HOP_DONG = 500_000;

    public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, int soHopDong)
        : base(maNV, hoTen)
    {
        LuongCoBan = luongCoBan;
        SoHopDong = soHopDong;
    }

    // Luong = luong co ban + 500.000 * so hop dong ky duoc
    public override double TinhLuong()
    {
        return LuongCoBan + SoHopDong * THUONG_MOI_HOP_DONG;
    }
}

public class NhanVienSanXuat : NhanVienCongTy
{
    public int SoLuongSanPham { get; set; }

    private const double DON_GIA_SAN_PHAM = 1000;
    private const int NGUONG_THUONG = 3000;
    private const double TY_LE_THUONG = 0.05;

    public NhanVienSanXuat(string maNV, string hoTen, int soLuongSanPham)
        : base(maNV, hoTen)
    {
        SoLuongSanPham = soLuongSanPham;
    }

    // Luong = so luong san pham * 1000, neu lam tren 3000 san pham thi thuong them 5%
    public override double TinhLuong()
    {
        double luong = SoLuongSanPham * DON_GIA_SAN_PHAM;
        if (SoLuongSanPham > NGUONG_THUONG)
            luong *= 1 + TY_LE_THUONG;
        return luong;
    }
}
