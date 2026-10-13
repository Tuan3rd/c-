using Microsoft.Data.SqlClient;

namespace WinForm05ContinueLogic;

// Cac repository ket noi SQL Server that qua Microsoft.Data.SqlClient (ban ke nhiem
// duoc Microsoft tich cuc duy tri cua System.Data.SqlClient ma tai lieu thuc hanh dung -
// System.Data.SqlClient da ngung phat trien tren .NET hien dai).
//
// Khac voi code mau trong de bai (noi chuoi SQL truc tiep tu Text cua TextBox, de bi
// SQL Injection neu nguoi dung go ky tu nhay don), moi lenh o day deu dung SqlParameter
// de truyen gia tri - khong bao gio noi chuoi du lieu nguoi dung vao cau lenh SQL.
public class SqlKhoaRepository : IKhoaRepository
{
    private readonly string _chuoiKetNoi;

    public SqlKhoaRepository(string chuoiKetNoi) => _chuoiKetNoi = chuoiKetNoi;

    public IReadOnlyList<Khoa> LayTatCa()
    {
        var ds = new List<Khoa>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT MaKhoa, TenKhoa FROM Khoa", conn);
        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
            ds.Add(new Khoa { MaKhoa = rdr.GetString(0), TenKhoa = rdr.GetString(1) });
        return ds;
    }

    public bool TonTai(string maKhoa)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT COUNT(1) FROM Khoa WHERE MaKhoa = @MaKhoa", conn);
        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public void Them(Khoa khoa)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@MaKhoa, @TenKhoa)", conn);
        cmd.Parameters.AddWithValue("@MaKhoa", khoa.MaKhoa);
        cmd.Parameters.AddWithValue("@TenKhoa", khoa.TenKhoa);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Xoa(string maKhoa)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("DELETE FROM Khoa WHERE MaKhoa = @MaKhoa", conn);
        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Sua(Khoa khoa)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa", conn);
        cmd.Parameters.AddWithValue("@TenKhoa", khoa.TenKhoa);
        cmd.Parameters.AddWithValue("@MaKhoa", khoa.MaKhoa);
        conn.Open();
        cmd.ExecuteNonQuery();
    }
}

public class SqlMonHocRepository : IMonHocRepository
{
    private readonly string _chuoiKetNoi;

    public SqlMonHocRepository(string chuoiKetNoi) => _chuoiKetNoi = chuoiKetNoi;

    public IReadOnlyList<MonHoc> LayTatCa()
    {
        var ds = new List<MonHoc>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT MaMonHoc, TenMonHoc FROM MonHoc", conn);
        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
            ds.Add(new MonHoc { MaMonHoc = rdr.GetString(0), TenMonHoc = rdr.GetString(1) });
        return ds;
    }

    public bool TonTai(string maMonHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT COUNT(1) FROM MonHoc WHERE MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public void Them(MonHoc monHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMonHoc, @TenMonHoc)", conn);
        cmd.Parameters.AddWithValue("@MaMonHoc", monHoc.MaMonHoc);
        cmd.Parameters.AddWithValue("@TenMonHoc", monHoc.TenMonHoc);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Xoa(string maMonHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Sua(MonHoc monHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("UPDATE MonHoc SET TenMonHoc = @TenMonHoc WHERE MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@TenMonHoc", monHoc.TenMonHoc);
        cmd.Parameters.AddWithValue("@MaMonHoc", monHoc.MaMonHoc);
        conn.Open();
        cmd.ExecuteNonQuery();
    }
}

public class SqlLopRepository : ILopRepository
{
    private readonly string _chuoiKetNoi;

    public SqlLopRepository(string chuoiKetNoi) => _chuoiKetNoi = chuoiKetNoi;

    public IReadOnlyList<Lop> LayTatCa()
    {
        var ds = new List<Lop>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT MaLop, TenLop, MaKhoa FROM Lop", conn);
        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
            ds.Add(new Lop { MaLop = rdr.GetString(0), TenLop = rdr.GetString(1), MaKhoa = rdr.GetString(2) });
        return ds;
    }

    public bool TonTai(string maLop)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT COUNT(1) FROM Lop WHERE MaLop = @MaLop", conn);
        cmd.Parameters.AddWithValue("@MaLop", maLop);
        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public void Them(Lop lop)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)", conn);
        cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
        cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
        cmd.Parameters.AddWithValue("@MaKhoa", lop.MaKhoa);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Xoa(string maLop)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("DELETE FROM Lop WHERE MaLop = @MaLop", conn);
        cmd.Parameters.AddWithValue("@MaLop", maLop);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    // Partial update: chi dua vao cau lenh SET nhung cot thuc su co gia tri moi, dung
    // yeu cau "truong nao khong nhap lieu thi khong thay doi".
    public void Sua(string maLop, string? tenLopMoi, string? maKhoaMoi)
    {
        var phanSet = new List<string>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand { Connection = conn };

        if (!string.IsNullOrWhiteSpace(tenLopMoi))
        {
            phanSet.Add("TenLop = @TenLop");
            cmd.Parameters.AddWithValue("@TenLop", tenLopMoi);
        }
        if (!string.IsNullOrWhiteSpace(maKhoaMoi))
        {
            phanSet.Add("MaKhoa = @MaKhoa");
            cmd.Parameters.AddWithValue("@MaKhoa", maKhoaMoi);
        }

        if (phanSet.Count == 0)
            return;

        cmd.CommandText = $"UPDATE Lop SET {string.Join(", ", phanSet)} WHERE MaLop = @MaLop";
        cmd.Parameters.AddWithValue("@MaLop", maLop);
        conn.Open();
        cmd.ExecuteNonQuery();
    }
}

public class SqlSinhVienRepository : ISinhVienRepository
{
    private readonly string _chuoiKetNoi;

    public SqlSinhVienRepository(string chuoiKetNoi) => _chuoiKetNoi = chuoiKetNoi;

    public IReadOnlyList<SinhVien> LayTatCa()
    {
        var ds = new List<SinhVien>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT MaSinhVien, HoTen, NgaySinh, MaLop FROM SinhVien", conn);
        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            ds.Add(new SinhVien
            {
                MaSinhVien = rdr.GetString(0),
                HoTen = rdr.GetString(1),
                NgaySinh = rdr.IsDBNull(2) ? null : rdr.GetDateTime(2),
                MaLop = rdr.GetString(3)
            });
        }
        return ds;
    }

    public bool TonTai(string maSinhVien)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT COUNT(1) FROM SinhVien WHERE MaSinhVien = @MaSinhVien", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public void Them(SinhVien sinhVien)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @MaLop)", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", sinhVien.MaSinhVien);
        cmd.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
        cmd.Parameters.AddWithValue("@NgaySinh", (object?)sinhVien.NgaySinh ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@MaLop", sinhVien.MaLop);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    // Xoa theo dung Ma SV VA Ho ten trung khop, dung yeu cau rieng cua de bai.
    public void Xoa(string maSinhVien, string hoTen)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien AND HoTen = @HoTen", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        cmd.Parameters.AddWithValue("@HoTen", hoTen);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Sua(string maSinhVien, string? maLopMoi, string? hoTenMoi, DateTime? ngaySinhMoi)
    {
        var phanSet = new List<string>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand { Connection = conn };

        if (!string.IsNullOrWhiteSpace(maLopMoi))
        {
            phanSet.Add("MaLop = @MaLop");
            cmd.Parameters.AddWithValue("@MaLop", maLopMoi);
        }
        if (!string.IsNullOrWhiteSpace(hoTenMoi))
        {
            phanSet.Add("HoTen = @HoTen");
            cmd.Parameters.AddWithValue("@HoTen", hoTenMoi);
        }
        if (ngaySinhMoi.HasValue)
        {
            phanSet.Add("NgaySinh = @NgaySinh");
            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinhMoi.Value);
        }

        if (phanSet.Count == 0)
            return;

        cmd.CommandText = $"UPDATE SinhVien SET {string.Join(", ", phanSet)} WHERE MaSinhVien = @MaSinhVien";
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        conn.Open();
        cmd.ExecuteNonQuery();
    }
}

public class SqlDiemRepository : IDiemRepository
{
    private readonly string _chuoiKetNoi;

    public SqlDiemRepository(string chuoiKetNoi) => _chuoiKetNoi = chuoiKetNoi;

    public IReadOnlyList<Diem> LayTatCa()
    {
        var ds = new List<Diem>();
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand("SELECT MaSinhVien, MaMonHoc, Diem FROM Diem", conn);
        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
            ds.Add(new Diem { MaSinhVien = rdr.GetString(0), MaMonHoc = rdr.GetString(1), DiemSo = rdr.GetDouble(2) });
        return ds;
    }

    public bool TonTai(string maSinhVien, string maMonHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "SELECT COUNT(1) FROM Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public void Them(Diem diem)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@MaSinhVien, @MaMonHoc, @Diem)", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", diem.MaSinhVien);
        cmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMonHoc);
        cmd.Parameters.AddWithValue("@Diem", diem.DiemSo);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Xoa(string maSinhVien, string maMonHoc)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "DELETE FROM Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Sua(string maSinhVien, string maMonHoc, double diemMoi)
    {
        using var conn = new SqlConnection(_chuoiKetNoi);
        using var cmd = new SqlCommand(
            "UPDATE Diem SET Diem = @Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc", conn);
        cmd.Parameters.AddWithValue("@Diem", diemMoi);
        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
        cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
        conn.Open();
        cmd.ExecuteNonQuery();
    }
}
