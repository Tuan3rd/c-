using System;

namespace OOPLib;

// ============================================================
// Bai 1.1: lop Sinh Vien co du Field, Constructor, Property, Method
// ============================================================
public class SinhVien
{
    // Field private, chi truy cap duoc qua Property ben duoi
    private string hoTen;
    private int namSinh;

    public string HoTen
    {
        get => hoTen;
        set => hoTen = value;
    }

    public int NamSinh
    {
        get => namSinh;
        set => namSinh = value;
    }

    public SinhVien(string hoTen, int namSinh)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
    }

    // Tuoi = nam hien tai - nam sinh. Nhan nam hien tai tu ben ngoai
    // (khong dung DateTime.Now.Year truc tiep ben trong) de ket qua
    // khong phu thuoc vao ngay chay chuong trinh -> de unit test.
    public int TinhTuoi(int namHienTai)
    {
        return namHienTai - namSinh;
    }

    public override string ToString()
    {
        return $"{hoTen} (sinh nam {namSinh})";
    }
}
