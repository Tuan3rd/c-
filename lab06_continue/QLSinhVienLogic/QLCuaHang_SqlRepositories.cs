using Microsoft.Data.SqlClient;

namespace QLSinhVienLogic;

// Cai dat ADO.NET thuc su cho QLCuaHang. Giong cac lop Sql...Repository khac trong du
// an nay: dung SqlParameter de tranh SQL Injection (khac voi vi du trong de bai noi
// chuoi truc tiep tu TextBox.Text). Da kiem tra bien dich thanh cong, CHUA chay tren
// SQL Server thuc vi moi truong sandbox khong co may chu SQL Server.
public class SqlSanPhamRepository(string connectionString) : ISanPhamRepository
{
    public IReadOnlyList<SanPham> LayTatCa()
    {
        var ketQua = new List<SanPham>();
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand("SELECT MaSP, TenSP FROM SANPHAM ORDER BY MaSP", ket_noi);
        ket_noi.Open();
        using var reader = lenh.ExecuteReader();
        while (reader.Read())
        {
            ketQua.Add(new SanPham { MaSP = reader.GetInt32(0), TenSP = reader.GetString(1) });
        }

        return ketQua;
    }

    public bool TonTai(int maSP)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand("SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP", ket_noi);
        lenh.Parameters.AddWithValue("@MaSP", maSP);
        ket_noi.Open();
        return (int)lenh.ExecuteScalar() > 0;
    }

    // MaSP la IDENTITY ben SQL Server nen dung OUTPUT INSERTED.MaSP de lay lai ma vua tao.
    public SanPham Them(string tenSP)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "INSERT INTO SANPHAM (TenSP) OUTPUT INSERTED.MaSP VALUES (@TenSP)", ket_noi);
        lenh.Parameters.AddWithValue("@TenSP", tenSP);
        ket_noi.Open();
        int maSPMoi = (int)lenh.ExecuteScalar();
        return new SanPham { MaSP = maSPMoi, TenSP = tenSP };
    }
}

public class SqlTonKhoRepository(string connectionString) : ITonKhoRepository
{
    public IReadOnlyList<TonKho> LayTatCa()
    {
        var ketQua = new List<TonKho>();
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "SELECT MaSP, NgayTon, SLDau, SLNhap, SLBan FROM TONKHO ORDER BY NgayTon, MaSP", ket_noi);
        ket_noi.Open();
        using var reader = lenh.ExecuteReader();
        while (reader.Read())
        {
            ketQua.Add(new TonKho
            {
                MaSP = reader.GetInt32(0),
                NgayTon = reader.GetDateTime(1),
                SLDau = reader.GetInt32(2),
                SLNhap = reader.GetInt32(3),
                SLBan = reader.GetInt32(4),
            });
        }

        return ketQua;
    }

    public TonKho? LayTheoSanPhamVaNgay(int maSP, DateTime ngay)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "SELECT MaSP, NgayTon, SLDau, SLNhap, SLBan FROM TONKHO WHERE MaSP = @MaSP AND NgayTon = @NgayTon",
            ket_noi);
        lenh.Parameters.AddWithValue("@MaSP", maSP);
        lenh.Parameters.AddWithValue("@NgayTon", ngay.Date);
        ket_noi.Open();
        using var reader = lenh.ExecuteReader();
        if (!reader.Read())
            return null;

        return new TonKho
        {
            MaSP = reader.GetInt32(0),
            NgayTon = reader.GetDateTime(1),
            SLDau = reader.GetInt32(2),
            SLNhap = reader.GetInt32(3),
            SLBan = reader.GetInt32(4),
        };
    }

    public void Them(TonKho tonKho)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES (@MaSP, @NgayTon, @SLDau, @SLNhap, @SLBan)",
            ket_noi);
        lenh.Parameters.AddWithValue("@MaSP", tonKho.MaSP);
        lenh.Parameters.AddWithValue("@NgayTon", tonKho.NgayTon.Date);
        lenh.Parameters.AddWithValue("@SLDau", tonKho.SLDau);
        lenh.Parameters.AddWithValue("@SLNhap", tonKho.SLNhap);
        lenh.Parameters.AddWithValue("@SLBan", tonKho.SLBan);
        ket_noi.Open();
        lenh.ExecuteNonQuery();
    }

    public void CongSoLuongBan(int maSP, DateTime ngay, int soLuongBanThem)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "UPDATE TONKHO SET SLBan = SLBan + @SoLuong WHERE MaSP = @MaSP AND NgayTon = @NgayTon", ket_noi);
        lenh.Parameters.AddWithValue("@SoLuong", soLuongBanThem);
        lenh.Parameters.AddWithValue("@MaSP", maSP);
        lenh.Parameters.AddWithValue("@NgayTon", ngay.Date);
        ket_noi.Open();
        lenh.ExecuteNonQuery();
    }
}

public class SqlHoaDonRepository(string connectionString) : IHoaDonRepository
{
    public IReadOnlyList<HoaDon> LayTatCa()
    {
        var ketQua = new List<HoaDon>();
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand("SELECT MaHD, NgayTao, TinhTrangThanhToan FROM HOADON ORDER BY MaHD", ket_noi);
        ket_noi.Open();
        using var reader = lenh.ExecuteReader();
        while (reader.Read())
        {
            ketQua.Add(new HoaDon
            {
                MaHD = reader.GetInt32(0),
                NgayTao = reader.GetDateTime(1),
                TinhTrangThanhToan = reader.GetInt32(2),
            });
        }

        return ketQua;
    }

    public HoaDon TaoHoaDonMoi(DateTime ngayTao)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "INSERT INTO HOADON (NgayTao, TinhTrangThanhToan) OUTPUT INSERTED.MaHD VALUES (@NgayTao, 0)", ket_noi);
        lenh.Parameters.AddWithValue("@NgayTao", ngayTao);
        ket_noi.Open();
        int maHDMoi = (int)lenh.ExecuteScalar();
        return new HoaDon { MaHD = maHDMoi, NgayTao = ngayTao, TinhTrangThanhToan = 0 };
    }

    public void DanhDauDaThanhToan(int maHD)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "UPDATE HOADON SET TinhTrangThanhToan = 1 WHERE MaHD = @MaHD", ket_noi);
        lenh.Parameters.AddWithValue("@MaHD", maHD);
        ket_noi.Open();
        lenh.ExecuteNonQuery();
    }
}

public class SqlChiTietHoaDonRepository(string connectionString) : IChiTietHoaDonRepository
{
    public IReadOnlyList<ChiTietHoaDon> LayTatCa()
    {
        var ketQua = new List<ChiTietHoaDon>();
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand("SELECT MaHD, MaSP, SoLuong FROM CHITIET_HOADON ORDER BY MaHD, MaSP", ket_noi);
        ket_noi.Open();
        using var reader = lenh.ExecuteReader();
        while (reader.Read())
        {
            ketQua.Add(new ChiTietHoaDon
            {
                MaHD = reader.GetInt32(0),
                MaSP = reader.GetInt32(1),
                SoLuong = reader.GetInt32(2),
            });
        }

        return ketQua;
    }

    public bool TonTai(int maHD, int maSP)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "SELECT COUNT(*) FROM CHITIET_HOADON WHERE MaHD = @MaHD AND MaSP = @MaSP", ket_noi);
        lenh.Parameters.AddWithValue("@MaHD", maHD);
        lenh.Parameters.AddWithValue("@MaSP", maSP);
        ket_noi.Open();
        return (int)lenh.ExecuteScalar() > 0;
    }

    public void Them(ChiTietHoaDon chiTiet)
    {
        using var ket_noi = new SqlConnection(connectionString);
        using var lenh = new SqlCommand(
            "INSERT INTO CHITIET_HOADON (MaHD, MaSP, SoLuong) VALUES (@MaHD, @MaSP, @SoLuong)", ket_noi);
        lenh.Parameters.AddWithValue("@MaHD", chiTiet.MaHD);
        lenh.Parameters.AddWithValue("@MaSP", chiTiet.MaSP);
        lenh.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
        ket_noi.Open();
        lenh.ExecuteNonQuery();
    }
}
