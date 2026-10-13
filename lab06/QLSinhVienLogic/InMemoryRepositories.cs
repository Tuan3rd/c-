namespace QLSinhVienLogic;

// Cac repository luu trong bo nho (List<T>), dung cho unit test va cho Form chay thu
// khong can cai dat SQL Server that. Hanh vi (kiem tra ton tai, nem loi khi khong tim
// thay de xoa/sua) duoc viet giong het nhu mot repository SQL that se lam.
public class InMemoryKhoaRepository : IKhoaRepository
{
    private readonly List<Khoa> _ds = new();

    public InMemoryKhoaRepository(IEnumerable<Khoa>? duLieuMau = null)
    {
        if (duLieuMau is not null)
            _ds.AddRange(duLieuMau);
    }

    public IReadOnlyList<Khoa> LayTatCa() => _ds.AsReadOnly();

    public bool TonTai(string maKhoa) => _ds.Any(k => k.MaKhoa == maKhoa);

    public void Them(Khoa khoa)
    {
        if (TonTai(khoa.MaKhoa))
            throw new InvalidOperationException($"Mã khoa {khoa.MaKhoa} đã tồn tại");

        _ds.Add(khoa);
    }

    public void Xoa(string maKhoa)
    {
        var khoa = _ds.FirstOrDefault(k => k.MaKhoa == maKhoa) ??
            throw new InvalidOperationException($"Không tìm thấy khoa {maKhoa}");
        _ds.Remove(khoa);
    }

    public void Sua(Khoa khoa)
    {
        var hienTai = _ds.FirstOrDefault(k => k.MaKhoa == khoa.MaKhoa) ??
            throw new InvalidOperationException($"Không tìm thấy khoa {khoa.MaKhoa}");
        hienTai.TenKhoa = khoa.TenKhoa;
    }
}

public class InMemoryMonHocRepository : IMonHocRepository
{
    private readonly List<MonHoc> _ds = new();

    public InMemoryMonHocRepository(IEnumerable<MonHoc>? duLieuMau = null)
    {
        if (duLieuMau is not null)
            _ds.AddRange(duLieuMau);
    }

    public IReadOnlyList<MonHoc> LayTatCa() => _ds.AsReadOnly();

    public bool TonTai(string maMonHoc) => _ds.Any(m => m.MaMonHoc == maMonHoc);

    public void Them(MonHoc monHoc)
    {
        if (TonTai(monHoc.MaMonHoc))
            throw new InvalidOperationException($"Mã môn học {monHoc.MaMonHoc} đã tồn tại");

        _ds.Add(monHoc);
    }

    public void Xoa(string maMonHoc)
    {
        var mh = _ds.FirstOrDefault(m => m.MaMonHoc == maMonHoc) ??
            throw new InvalidOperationException($"Không tìm thấy môn học {maMonHoc}");
        _ds.Remove(mh);
    }

    public void Sua(MonHoc monHoc)
    {
        var hienTai = _ds.FirstOrDefault(m => m.MaMonHoc == monHoc.MaMonHoc) ??
            throw new InvalidOperationException($"Không tìm thấy môn học {monHoc.MaMonHoc}");
        hienTai.TenMonHoc = monHoc.TenMonHoc;
    }
}

public class InMemoryLopRepository : ILopRepository
{
    private readonly List<Lop> _ds = new();

    public InMemoryLopRepository(IEnumerable<Lop>? duLieuMau = null)
    {
        if (duLieuMau is not null)
            _ds.AddRange(duLieuMau);
    }

    public IReadOnlyList<Lop> LayTatCa() => _ds.AsReadOnly();

    public bool TonTai(string maLop) => _ds.Any(l => l.MaLop == maLop);

    public void Them(Lop lop)
    {
        if (TonTai(lop.MaLop))
            throw new InvalidOperationException($"Mã lớp {lop.MaLop} đã tồn tại");

        _ds.Add(lop);
    }

    public void Xoa(string maLop)
    {
        var lop = _ds.FirstOrDefault(l => l.MaLop == maLop) ??
            throw new InvalidOperationException($"Không tìm thấy lớp {maLop}");
        _ds.Remove(lop);
    }

    public void Sua(string maLop, string? tenLopMoi, string? maKhoaMoi)
    {
        var lop = _ds.FirstOrDefault(l => l.MaLop == maLop) ??
            throw new InvalidOperationException($"Không tìm thấy lớp {maLop}");

        if (!string.IsNullOrWhiteSpace(tenLopMoi))
            lop.TenLop = tenLopMoi;
        if (!string.IsNullOrWhiteSpace(maKhoaMoi))
            lop.MaKhoa = maKhoaMoi;
    }
}

public class InMemorySinhVienRepository : ISinhVienRepository
{
    private readonly List<SinhVien> _ds = new();

    public InMemorySinhVienRepository(IEnumerable<SinhVien>? duLieuMau = null)
    {
        if (duLieuMau is not null)
            _ds.AddRange(duLieuMau);
    }

    public IReadOnlyList<SinhVien> LayTatCa() => _ds.AsReadOnly();

    public bool TonTai(string maSinhVien) => _ds.Any(s => s.MaSinhVien == maSinhVien);

    public void Them(SinhVien sinhVien)
    {
        if (TonTai(sinhVien.MaSinhVien))
            throw new InvalidOperationException($"Mã sinh viên {sinhVien.MaSinhVien} đã tồn tại");

        _ds.Add(sinhVien);
    }

    public void Xoa(string maSinhVien, string hoTen)
    {
        var sv = _ds.FirstOrDefault(s => s.MaSinhVien == maSinhVien && s.HoTen == hoTen) ??
            throw new InvalidOperationException($"Không tìm thấy sinh viên {maSinhVien} - {hoTen}");
        _ds.Remove(sv);
    }

    public void Sua(string maSinhVien, string? maLopMoi, string? hoTenMoi, DateTime? ngaySinhMoi)
    {
        var sv = _ds.FirstOrDefault(s => s.MaSinhVien == maSinhVien) ??
            throw new InvalidOperationException($"Không tìm thấy sinh viên {maSinhVien}");

        if (!string.IsNullOrWhiteSpace(maLopMoi))
            sv.MaLop = maLopMoi;
        if (!string.IsNullOrWhiteSpace(hoTenMoi))
            sv.HoTen = hoTenMoi;
        if (ngaySinhMoi.HasValue)
            sv.NgaySinh = ngaySinhMoi;
    }
}

public class InMemoryDiemRepository : IDiemRepository
{
    private readonly List<Diem> _ds = new();

    public InMemoryDiemRepository(IEnumerable<Diem>? duLieuMau = null)
    {
        if (duLieuMau is not null)
            _ds.AddRange(duLieuMau);
    }

    public IReadOnlyList<Diem> LayTatCa() => _ds.AsReadOnly();

    public bool TonTai(string maSinhVien, string maMonHoc) =>
        _ds.Any(d => d.MaSinhVien == maSinhVien && d.MaMonHoc == maMonHoc);

    public void Them(Diem diem)
    {
        if (TonTai(diem.MaSinhVien, diem.MaMonHoc))
            throw new InvalidOperationException($"Điểm của SV {diem.MaSinhVien} - môn {diem.MaMonHoc} đã tồn tại");

        _ds.Add(diem);
    }

    public void Xoa(string maSinhVien, string maMonHoc)
    {
        var diem = _ds.FirstOrDefault(d => d.MaSinhVien == maSinhVien && d.MaMonHoc == maMonHoc) ??
            throw new InvalidOperationException($"Không tìm thấy điểm của SV {maSinhVien} - môn {maMonHoc}");
        _ds.Remove(diem);
    }

    public void Sua(string maSinhVien, string maMonHoc, double diemMoi)
    {
        var diem = _ds.FirstOrDefault(d => d.MaSinhVien == maSinhVien && d.MaMonHoc == maMonHoc) ??
            throw new InvalidOperationException($"Không tìm thấy điểm của SV {maSinhVien} - môn {maMonHoc}");
        diem.DiemSo = diemMoi;
    }
}
