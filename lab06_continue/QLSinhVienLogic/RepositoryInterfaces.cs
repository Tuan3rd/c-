namespace QLSinhVienLogic;

// Cac interface repository - tach rieng "noi luu du lieu" khoi "logic nghiep vu" de
// Form co the dung chung 1 loai code du phia sau la InMemory (chay thu/test, khong can
// cai SQL Server) hay Sql...Repository (ket noi SQL Server that qua Microsoft.Data.SqlClient).
public interface IKhoaRepository
{
    IReadOnlyList<Khoa> LayTatCa();
    bool TonTai(string maKhoa);
    void Them(Khoa khoa);
    void Xoa(string maKhoa);
    void Sua(Khoa khoa);
}

public interface IMonHocRepository
{
    IReadOnlyList<MonHoc> LayTatCa();
    bool TonTai(string maMonHoc);
    void Them(MonHoc monHoc);
    void Xoa(string maMonHoc);
    void Sua(MonHoc monHoc);
}

public interface ILopRepository
{
    IReadOnlyList<Lop> LayTatCa();
    bool TonTai(string maLop);
    void Them(Lop lop);
    void Xoa(string maLop);

    // Sua kieu "partial update": truong nao null thi giu nguyen gia tri cu (dung yeu cau
    // de bai "truong nao khong nhap lieu thi khong thay doi").
    void Sua(string maLop, string? tenLopMoi, string? maKhoaMoi);
}

public interface ISinhVienRepository
{
    IReadOnlyList<SinhVien> LayTatCa();
    bool TonTai(string maSinhVien);
    void Them(SinhVien sinhVien);

    // Xoa theo dung Ma SV VA Ho ten trung khop (yeu cau rieng cua de bai).
    void Xoa(string maSinhVien, string hoTen);

    void Sua(string maSinhVien, string? maLopMoi, string? hoTenMoi, DateTime? ngaySinhMoi);
}

public interface IDiemRepository
{
    IReadOnlyList<Diem> LayTatCa();
    bool TonTai(string maSinhVien, string maMonHoc);
    void Them(Diem diem);
    void Xoa(string maSinhVien, string maMonHoc);
    void Sua(string maSinhVien, string maMonHoc, double diemMoi);
}
