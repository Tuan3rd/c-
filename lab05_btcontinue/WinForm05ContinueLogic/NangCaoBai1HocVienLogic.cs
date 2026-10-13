namespace WinForm05ContinueLogic;

// Dat ten LopHocVien (khong phai Lop) de tranh trung voi entity Lop cua Bai 7 (ADO.NET)
// trong cung thu vien nay.
public enum LopHocVien { LopA, LopB }

// Bai 1 (nang cao): quan ly hoc vien giua 2 lop bang MenuStrip.
public static class NangCaoBai1HocVienLogic
{
    public static void ChuyenHocVien(List<string> nguon, List<string> dich, IEnumerable<string> dsDangChon)
    {
        foreach (string hocVien in dsDangChon.ToList())
        {
            dich.Add(hocVien);
            nguon.Remove(hocVien);
        }
    }

    public static void XoaHocVien(List<string> ds, IEnumerable<string> dsDangChon)
    {
        foreach (string hocVien in dsDangChon.ToList())
            ds.Remove(hocVien);
    }

    public static bool TenHopLe(string? hoTen) => !string.IsNullOrWhiteSpace(hoTen);
}
