namespace QLSinhVienLogic;

// Dung cho Bai 2 (nang cao): danh sach diem sinh vien theo mon hoc tren ListView.
// Ket hop (join) 3 bang Diem + SinhVien + MonHoc thanh 1 dong xem duoc truc tiep,
// co the loc theo mot Ma mon hoc cu the hoac lay tat ca khi maMonHocLoc la null/rong.
public record DiemChiTiet(string TenSV, DateTime? NgaySinh, string TenMonHoc, double DiemSo);

public static class DiemChiTietLogic
{
    public static List<DiemChiTiet> LayDanhSach(
        IEnumerable<Diem> dsDiem,
        IEnumerable<SinhVien> dsSinhVien,
        IEnumerable<MonHoc> dsMonHoc,
        string? maMonHocLoc)
    {
        var danhSach =
            from d in dsDiem
            join sv in dsSinhVien on d.MaSinhVien equals sv.MaSinhVien
            join mh in dsMonHoc on d.MaMonHoc equals mh.MaMonHoc
            where string.IsNullOrWhiteSpace(maMonHocLoc) || d.MaMonHoc == maMonHocLoc
            select new DiemChiTiet(sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.DiemSo);

        return danhSach.ToList();
    }

    public static double TinhTongDiem(IEnumerable<DiemChiTiet> danhSach) => danhSach.Sum(d => d.DiemSo);
}
