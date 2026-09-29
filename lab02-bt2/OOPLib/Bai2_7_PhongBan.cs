using System;
using System.Collections.Generic;

namespace OOPLib;

// ============================================================
// Bai 2.5: mot phong ban co n nhan vien, tinh tong luong ca phong ban
// (nhan vien don gian: ho ten, muc luong, so ngay vang - moi ngay vang tru 100.000)
// ============================================================
public class NhanVienDonGian
{
    public string HoTen { get; set; }
    public double MucLuong { get; set; }
    public int SoNgayVang { get; set; }

    public const double TIEN_TRU_MOI_NGAY_VANG = 100_000;

    public NhanVienDonGian(string hoTen, double mucLuong, int soNgayVang)
    {
        HoTen = hoTen;
        MucLuong = mucLuong;
        SoNgayVang = soNgayVang;
    }

    public double TinhLuong()
    {
        double luong = MucLuong - SoNgayVang * TIEN_TRU_MOI_NGAY_VANG;
        return luong < 0 ? 0 : luong;
    }
}

public class PhongBan
{
    private readonly List<NhanVienDonGian> danhSach = new List<NhanVienDonGian>();

    public int SoLuong => danhSach.Count;

    public void Add(NhanVienDonGian nv) => danhSach.Add(nv);

    public NhanVienDonGian this[int i] => danhSach[i];

    // Tong luong ca phong ban = tong luong tung nhan vien
    public double TongLuong()
    {
        double tong = 0;
        foreach (NhanVienDonGian nv in danhSach)
            tong += nv.TinhLuong();
        return tong;
    }
}
