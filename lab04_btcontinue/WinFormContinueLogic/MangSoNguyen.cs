namespace WinFormContinueLogic;

// Bai 2 (BT tai lop): class luu tru va xu ly mang mot chieu so nguyen.
// Moi thao tac (sap xep, tim kiem, them, xoa, tong, max-min, thay the) la mot
// phuong thuc rieng de Form goi truc tiep, khong dung vong lap/cong thuc trong
// code-behind.
public class MangSoNguyen
{
    private List<int> _ds = new();

    public IReadOnlyList<int> DanhSach => _ds;

    public int SoPhanTu => _ds.Count;

    public void Nhap(IEnumerable<int> cacGiaTri) => _ds = cacGiaTri.ToList();

    public void Xoa() => _ds.Clear();

    public void SapXepTang() => _ds.Sort();

    public void SapXepGiam() => _ds.Sort((x, y) => y.CompareTo(x));

    // Tra ve vi tri (chi so 0-based) xuat hien dau tien cua giaTri, hoac -1 neu khong co.
    public int TimViTriTheoGiaTri(int giaTri) => _ds.IndexOf(giaTri);

    public int TimGiaTriTheoViTri(int viTri)
    {
        KiemTraViTriHopLe(viTri);
        return _ds[viTri];
    }

    public void ThemTaiViTri(int giaTri, int viTri)
    {
        if (viTri < 0 || viTri > _ds.Count)
            throw new ArgumentOutOfRangeException(nameof(viTri), "Vị trí thêm không hợp lệ");

        _ds.Insert(viTri, giaTri);
    }

    // Xoa phan tu dau tien co gia tri bang giaTri; nem loi neu khong tim thay.
    public void XoaTheoGiaTri(int giaTri)
    {
        int viTri = TimViTriTheoGiaTri(giaTri);
        if (viTri < 0)
            throw new ArgumentException($"Không tìm thấy giá trị {giaTri} trong mảng");

        _ds.RemoveAt(viTri);
    }

    public void XoaTheoViTri(int viTri)
    {
        KiemTraViTriHopLe(viTri);
        _ds.RemoveAt(viTri);
    }

    public int TinhTong() => _ds.Sum();

    public int TinhTongChan() => _ds.Where(x => x % 2 == 0).Sum();

    public int TinhTongLe() => _ds.Where(x => x % 2 != 0).Sum();

    public int GiaTriLonNhat()
    {
        KiemTraMangKhongRong();
        return _ds.Max();
    }

    public int GiaTriNhoNhat()
    {
        KiemTraMangKhongRong();
        return _ds.Min();
    }

    // Thay toan bo cac phan tu co gia tri = giaTriCu bang giaTriMoi.
    public int ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi)
    {
        int soLanThay = 0;
        for (int i = 0; i < _ds.Count; i++)
        {
            if (_ds[i] == giaTriCu)
            {
                _ds[i] = giaTriMoi;
                soLanThay++;
            }
        }

        return soLanThay;
    }

    public void ThayTheTheoViTri(int viTri, int giaTriMoi)
    {
        KiemTraViTriHopLe(viTri);
        _ds[viTri] = giaTriMoi;
    }

    private void KiemTraViTriHopLe(int viTri)
    {
        if (viTri < 0 || viTri >= _ds.Count)
            throw new ArgumentOutOfRangeException(nameof(viTri), "Vị trí không hợp lệ");
    }

    private void KiemTraMangKhongRong()
    {
        if (_ds.Count == 0)
            throw new InvalidOperationException("Mảng đang rỗng");
    }
}
